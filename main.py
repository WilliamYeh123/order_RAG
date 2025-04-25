from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
from typing import Literal
from typing import List
from sentence_transformers import SentenceTransformer
from qdrant_client import QdrantClient
from qdrant_client.models import PointStruct, VectorParams, Filter, FieldCondition, MatchValue
from fastapi.responses import JSONResponse
import requests
import uuid
import logging
import json

logging.basicConfig(level=logging.INFO, format="%(asctime)s [%(levelname)s] %(message)s")
logger = logging.getLogger(__name__)

# Initialize model and Qdrant client
model = SentenceTransformer('all-MiniLM-L6-v2')
qdrant = QdrantClient(host="qdrant", port=6333)
collection_name = "winform_data"

# Create collection if not exists
qdrant.recreate_collection(
    collection_name=collection_name,
    vectors_config=VectorParams(size=384, distance="Cosine")
)

app = FastAPI()

class DataPayload(BaseModel):
    type: Literal['order', 'customer', 'product']
    id: str
    text: str

class DeleteRequest(BaseModel):
    ids: List[str]

class QueryPayload(BaseModel):
    query: str

@app.post("/embed")
def embed_data(data: DataPayload):
    embedding = model.encode(data.text).tolist()
    point = PointStruct(id=data.id, vector=embedding, payload={"type": data.type, "text": data.text})
    qdrant.upsert(collection_name=collection_name, points=[point])
    return {"status": "success"}

@app.post("/delete")  # 使用 POST 接收 JSON
def delete_data(request: DeleteRequest):
    valid_ids = []
    for i in request.ids:
        try:
            valid_ids.append(str(uuid.UUID(i)))  # 驗證 UUID 格式
        except ValueError:
            continue  # 跳過無效 UUID

    if not valid_ids:
        return JSONResponse(content={"error": "No valid UUIDs to delete."}, status_code=400)

    qdrant.delete(collection_name=collection_name, points_selector={"points": valid_ids})
    return {"status": "success", "deleted": valid_ids}


@app.post("/search")
def search_data(payload: QueryPayload):
    logger.info(f"Searching with query:{payload.query}")
    vector = model.encode(payload.query).tolist()
    logger.info("Turned query into vector")
    hits = qdrant.search(
        collection_name=collection_name,
        query_vector=vector,
        limit=5
    )
    context = "\n".join([hit.payload['text'] for hit in hits])
    logger.info("Sending request to Ollama")
    try:
        response = requests.post(
            "http://ollama:11434/api/generate",
            json={
                "model": "mistral",
                "prompt": f"根據以下資訊回答：\n{context}\n\n問題：{payload.query}"
            }
        )
        
        # 檢查回應狀態
        if response.status_code != 200:
            logger.error(f"Ollama returned an error: {response.status_code}")
            return {"error": "Ollama 回應失敗"}
        
        # 逐行處理 JSON 資料
        try:
            responses = []
            for line in response.text.splitlines():
                try:
                    #logger.info(line)
                    # 解析每行為獨立的 JSON
                    data = json.loads(line)
                    #logger.info(data.get("response"))
                    responses.append(data.get("response"))
                except json.JSONDecodeError as e:
                    logger.error(f"Error decoding JSON from line: {line}, {e}")
            
            # 記錄解析結果
            return_text = "".join(responses)
            logger.info(f"Received responses: {return_text}")
            return {"result": return_text}
        
        except Exception as e:
            logger.error(f"Error processing the response: {e}")
            return {"error": "處理回應資料時發生錯誤"}
    
    except requests.exceptions.RequestException as e:
        logger.error(f"Request failed: {e}")
        return {"error": "請求失敗，請稍後再試"}
    
@app.get("/get/{item_id}")
def get_vector(item_id: str):
    result = qdrant.retrieve(collection_name=collection_name, ids=[item_id])
    if result:
        return {"exists": True, "data": result}
    else:
        return {"exists": False}
    
@app.get("/all/{data_type}")
def list_vectors_by_type(data_type: Literal['order', 'customer', 'product']):
    vectors, _ = qdrant.scroll(
        collection_name=collection_name,
        scroll_filter=Filter(must=[FieldCondition(key="type", match=MatchValue(value=data_type))]),
        limit=100
    )
    return {
        "count": len(vectors),
        "items": vectors
    }