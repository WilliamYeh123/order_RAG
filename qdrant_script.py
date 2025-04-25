from qdrant_client import QdrantClient

client = QdrantClient("qdrant", port=6333)

# 假設你要刪的是叫 "orders" 的 collection
client.delete_collection(collection_name="winform_data")