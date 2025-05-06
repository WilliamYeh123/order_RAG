# Order Management System with RAG Integration

This is a Windows Forms-based Order Management System built with C# and .NET Framework. It allows CRUD operations for customers, products, and orders. Additionally, it integrates a basic Retrieval-Augmented Generation (RAG) system using Qdrant and Ollama to enable semantic search and question-answering based on saved order data.

## Features

- Customer, Product, and Order management (create and delete models)
- Product Category system
- DataGridView-based UI for editing and displaying records
- Order creation with real-time total price calculation
- RAG (Retrieval-Augmented Generation) integration:
  - Converts order summaries into vector embeddings
  - Saves to Qdrant vector database
  - Enables querying order-related questions via Ollama

## Tech Stack

### Backend

- **.NET Framework / WinForms**
- **Entity Framework Core** – ORM for SQL Server
- **SQL Server** – Relational database
- **Qdrant** – Vector search engine
- **Ollama (e.g. Mistral)** – Lightweight local LLM for question answering
- **FastAPI** – For embedding API that connects to vector DB and LLM

### Python Environment

- `fastapi`
- `qdrant-client`
- `sentence-transformers` – For generating vector embeddings
- `requests`
- `uvicorn`