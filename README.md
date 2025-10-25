# 🧩 Appsian Task Manager — Minimal .NET 8 Web API

A lightweight and efficient **Task Management REST API** built with **.NET 8**, developed as part of the **Appsian Logical Assignment**.  
It provides a clean architecture, JWT authentication, and a simple SQLite database setup — ready for development or deployment.

---

## 🚀 Features

- 🧠 **Task & Project Management** — Create, update, and track tasks and projects efficiently.  
- 🔐 **JWT Authentication** — Secure endpoints with token-based access.  
- 💾 **SQLite Integration** — Lightweight database for easy local development.  
- ⚙️ **Minimal API Architecture** — Built using modern .NET 8 patterns.  
- 🌍 **Cross-platform** — Runs seamlessly on Windows, macOS, or Linux.  

---

## 🧰 Tech Stack

| Layer | Technology |
|:------|:------------|
| Backend | .NET 8 (C#) |
| Database | SQLite |
| Authentication | JWT (JSON Web Tokens) |
| ORM | Entity Framework Core |
| Deployment | Render |

---

## 🧑‍💻 Getting Started

### Prerequisites
Ensure the following are installed:
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Git
- SQLite (optional; included by default)

---

### 🌐 Deployment Link (On Render)

Explore the live API via Swagger:  

👉 **[Appsian Task Manager Backend](https://taskmanager-backend-appsian-2025-1.onrender.com/swagger/index.html)**

---

### ⚙️ Setup Instructions

```bash
# 1️⃣ Clone the repository
git clone https://github.com/<your-username>/task-manager-backend-app.git
cd task-manager-backend-app

# 2️⃣ Restore dependencies
dotnet restore

# 3️⃣ Run the application
dotnet run
