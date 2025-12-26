FROM python:3.11-slim

WORKDIR /app

COPY fermat.py .
COPY test_fermat.py .

RUN pip install --no-cache-dir pytest

CMD ["pytest", "-q"]