# CloudNativeMicroservices

A sample microservices application built with .NET Core, Docker, and Azure. This project demonstrates the architecture and implementation of a cloud-native microservices application using best practices.

## Table of Contents
- [Overview](#overview)
- [Architecture](#architecture)
- [Microservices](#microservices)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)

## Overview
This project is designed to help developers understand how to build and deploy a cloud-native microservices application using .NET Core, Docker, and Azure. It includes three primary microservices:
1. User Management Service
2. Product Catalog Service
3. Order Management Service

Each service is containerized using Docker and can be deployed to Azure using free-tier services.

## Architecture
![Architecture Diagram](path/to/architecture-diagram.png)

- **User Management Service:** Handles user registration, authentication, and profile management. Uses a SQL database.
- **Product Catalog Service:** Manages product information and inventory. Uses a NoSQL database (Azure Cosmos DB).
- **Order Management Service:** Processes orders and manages order history. Uses a SQL database.

## Microservices
### User Management Service
- **Responsibilities:** User registration, authentication, profile management.
- **Database:** SQL (Azure SQL Database)
- **Endpoints:**
  - `GET /api/users`
  - `GET /api/users/{id}`
  - `POST /api/users`
  - `PUT /api/users/{id}`
  - `DELETE /api/users/{id}`

### Product Catalog Service
- **Responsibilities:** Manage product information, inventory.
- **Database:** NoSQL (Azure Cosmos DB)
- **Endpoints:**
  - `GET /api/products`
  - `GET /api/products/{id}`
  - `POST /api/products`
  - `PUT /api/products/{id}`
  - `DELETE /api/products/{id}`

### Order Management Service
- **Responsibilities:** Order processing, order history.
- **Database:** SQL (Azure SQL Database)
- **Endpoints:**
  - `GET /api/orders`
  - `GET /api/orders/{id}`
  - `POST /api/orders`
  - `PUT /api/orders/{id}`
  - `DELETE /api/orders/{id}`

## Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Azure Account](https://azure.microsoft.com/en-us/free/)

## Getting Started
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/CloudNativeMicroservices.git
    cd CloudNativeMicroservices
    ```

2. Build and run the Docker containers:
    ```bash
    docker-compose up --build
    ```

3. Access the services:
    - User Management Service: `http://localhost:5001`
    - Product Catalog Service: `http://localhost:5002`
    - Order Management Service: `http://localhost:5003`

## Usage
You can interact with the microservices using tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/). Example requests:

### Create a User
```bash
curl -X POST http://localhost:5001/api/users -H "Content-Type: application/json" -d '{"username": "john_doe", "password": "password123", "email": "john@example.com"}'
```

### Get all Products
```bash
curl http://localhost:5002/api/products
```

### Create an Order
```bash
curl -X POST http://localhost:5003/api/orders -H "Content-Type: application/json" -d '{"userId": "user-id", "orderItems": [{"productId": "product-id", "quantity": 1, "price": 19.99}]}'

```

### Deployment
#### Azure Deployment

- Create resource groups and services on Azure for each microservice (Azure SQL Database, Azure Cosmos DB, etc.).
- Update the connection strings and configuration settings in each microservice.
- Use Docker to build and push images to Azure Container Registry.
- Deploy the containers to Azure Kubernetes Service (AKS) or Azure App Service.

### License
This project is licensed under the MIT License. See the LICENSE file for details.


This `README.md` provides a comprehensive overview of the project, instructions for getting started, usage examples, and guidance for deployment and contributing. Adjust the paths and URLs as needed to match your specific setup and repository details.

