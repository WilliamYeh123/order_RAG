#!/bin/sh

ollama serve &

# 等待 ollama serve 初始化
sleep 3

# 拉取 mistral 模型
ollama pull mistral

# 等背景執行的 ollama serve
wait