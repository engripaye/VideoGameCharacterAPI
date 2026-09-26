# 🎮 Video Game Character API

A lightweight **RESTful Web API built with C# and ASP.NET Core** for managing and retrieving video game character data.

This project demonstrates the fundamentals of building an ASP.NET Core Web API, including **controllers, routing, HTTP GET endpoints, model binding, dependency-free in-memory data storage, and asynchronous API responses**.

---

## 🚀 Features

* RESTful API architecture
* Retrieve all video game characters
* Attribute-based routing
* HTTP GET endpoint
* Strongly typed C# models
* In-memory data storage
* Asynchronous API response handling
* Automatic API validation through `[ApiController]`
* Swagger/OpenAPI integration

---

## 🛠️ Tech Stack

* **C#**
* **.NET / ASP.NET Core**
* **ASP.NET Core Web API**
* **Swagger / OpenAPI**
* **Visual Studio / JetBrains Rider**
* **Git & GitHub**

---

## 📁 Project Structure

```text
VideoGameCharacterAPI/
├── Controllers/
│   └── VideoGameCharacterController.cs
│
├── Models/
│   └── Character.cs
│
├── Program.cs
├── VideoGameCharacterAPI.csproj
└── README.md
```

---

## 🔌 API Endpoint

### Get All Characters

```http
GET /api/VideoGameCharacter
```

Returns a list of all available video game characters.

### Example Response

```json
[
  {
    "id": 1,
    "name": "Mr Ping",
    "game": "Ping pong",
    "role": "Actor"
  },
  {
    "id": 2,
    "name": "Mr Ben",
    "game": "Ben 10",
    "role": "Boss"
  },
  {
    "id": 3,
    "name": "Mr GTA",
    "game": "GTA VI",
    "role": "Police"
  }
]
```

---

## 🧩 Controller Overview

The API uses an ASP.NET Core controller to expose the character collection through an HTTP endpoint.

```csharp
[Route("api/[controller]")]
[ApiController]
public class VideoGameCharacterController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacters()
        => await Task.FromResult(Ok(characters));
}
```

The `[ApiController]` attribute enables API-specific conventions, while `[HttpGet]` maps the `GetCharacters()` method to an HTTP GET request.

---

## ▶️ Running the Project

### 1. Clone the repository

```bash
git clone https://github.com/engripaye/VideoGameCharacterAPI.git
```

### 2. Navigate into the project

```bash
cd VideoGameCharacterAPI
```

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Run the API

```bash
dotnet run
```

The application will start on the local development URL displayed by ASP.NET Core.

---

## 📖 API Documentation

If Swagger/OpenAPI is enabled, you can interact with the API through the Swagger UI provided by the application.

Typical development URL:

```text
https://localhost:<port>/swagger
```

Swagger provides an interactive interface for exploring and testing the available API endpoints.

---

## 🧠 Key Concepts Demonstrated

This project focuses on foundational ASP.NET Core Web API concepts:

* Controllers and `ControllerBase`
* Attribute routing
* HTTP methods
* REST API conventions
* `ActionResult<T>`
* Asynchronous programming with `Task`
* Strongly typed models
* In-memory collections
* Swagger/OpenAPI
* Dependency-free API design

---

## 🔮 Planned Improvements

The current implementation intentionally uses an in-memory collection to keep the project focused on API fundamentals.

Future improvements could include:

* [ ] Add `POST` endpoint for creating characters
* [ ] Add `GET /{id}` for retrieving a specific character
* [ ] Add `PUT` endpoint for updating characters
* [ ] Add `DELETE` endpoint
* [ ] Add DTOs for API contracts
* [ ] Add validation with Data Annotations
* [ ] Introduce Entity Framework Core
* [ ] Persist characters in SQL Server/PostgreSQL
* [ ] Add dependency injection and service layer
* [ ] Add global exception handling
* [ ] Add unit and integration tests
* [ ] Add pagination and filtering
* [ ] Add Docker support
* [ ] Add CI/CD with GitHub Actions

---

## 🧪 Example API Request

```bash
curl -X GET https://localhost:<port>/api/VideoGameCharacter
```

---

## 📌 Project Status

**🚧 In Development**

The current version provides a simple read-only API and serves as a foundation for progressively introducing production-oriented ASP.NET Core architecture and persistence.

---

## 👨‍💻 Author

**Engr. Ipaye Babatunde**

Software Engineer • Java Architect • Backend Specialist

* GitHub: [@engripaye](https://github.com/engripaye)
* LinkedIn: [Engr. Ipaye Babatunde](https://www.linkedin.com/in/engripayebabatunde/)

---

## ⭐ Purpose

This project is part of my continued development in **C#, .NET, and backend API engineering**, with a focus on building clean, maintainable, and production-oriented web services.

If you find the project useful, consider giving it a ⭐ on GitHub.
