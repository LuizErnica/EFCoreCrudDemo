# EF Core CRUD Demo

> A simple and practical ASP.NET Core Web API demonstrating CRUD operations using **Entity Framework Core** with a clean architecture approach.

## 📚 About the Project

This project is a sample REST API built with **ASP.NET Core** and **Entity Framework Core** to demonstrate the implementation of the four basic database operations:

- **Create**
- **Read**
- **Update**
- **Delete**

The main goal is to provide a straightforward example of how to build a data-driven API using EF Core, following modern development practices.

This repository is intended for educational purposes and serves as a reference for developers learning Entity Framework Core and ASP.NET Core Web API development.

---

## 🚀 Technologies

- .NET
- ASP.NET Core Web API
- Entity Framework Core
- C#
- SQL Server (or another EF Core provider)
- Swagger / OpenAPI

---

## ✨ Features

- RESTful API
- Complete CRUD operations
- Entity Framework Core integration
- Code-First approach
- Dependency Injection
- Repository pattern (if applicable)
- LINQ queries
- Data validation
- Swagger UI for API testing
- Clean and maintainable project structure

---

## 📂 Project Structure

```text
EFCoreCrudDemo
│
├── Controllers/
├── Data/
├── Models/
├── DTOs/
├── Services/
├── Repositories/
├── Migrations/
├── Program.cs
├── appsettings.json
└── README.md
```

> *The structure may vary depending on the project's evolution.*

---

## 🎯 Objectives

- Learn Entity Framework Core fundamentals
- Understand CRUD operations in ASP.NET Core
- Practice Code-First development
- Learn how EF Core handles database migrations
- Build a RESTful Web API
- Understand Dependency Injection in ASP.NET Core
- Work with LINQ for database queries

---

## ▶️ Getting Started

### Clone the repository

```bash
git clone https://github.com/LuizErnica/EFCoreCrudDemo.git
```

### Navigate to the project

```bash
cd EFCoreCrudDemo
```

### Restore dependencies

```bash
dotnet restore
```

### Apply database migrations

```bash
dotnet ef database update
```

### Run the application

```bash
dotnet run
```

The API will be available at:

```
https://localhost:xxxx
```

Swagger documentation:

```
https://localhost:xxxx/swagger
```

---

## 📖 Concepts Covered

- Entity Framework Core
- DbContext
- DbSet
- Code-First Migrations
- Dependency Injection
- LINQ
- Repository Pattern
- REST API
- HTTP Methods
- Model Validation
- Data Annotations
- Asynchronous Programming

---

## 📊 CRUD Operations

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | `/api/...` | Retrieve all records |
| GET | `/api/.../{id}` | Retrieve a record by ID |
| POST | `/api/...` | Create a new record |
| PUT | `/api/.../{id}` | Update an existing record |
| DELETE | `/api/.../{id}` | Delete a record |

---

## 💡 Learning Outcomes

By exploring this project, you will learn how to:

- Configure Entity Framework Core
- Connect an ASP.NET Core API to a relational database
- Perform CRUD operations efficiently
- Create and apply database migrations
- Use LINQ to query data
- Build clean and maintainable APIs
- Follow modern .NET development practices

---

## 📚 References

- Microsoft Learn — ASP.NET Core Web API
- Microsoft Learn — Entity Framework Core
- C# Documentation
- .NET Documentation

---

## 👨‍💻 Author

**Luiz Henrique Érnica**

GitHub: https://github.com/LuizErnica

---

## 📄 License

This project was created for educational and learning purposes.
