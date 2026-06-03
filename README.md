# lms-course-service

**Owner:** Joachim Persson

This is the Course Service for our LMS project in the course *Molntjänster och distribuerade system*.

The service is responsible for managing course-related functionality and provides data to the LMS frontend application.

The service handles:

* Courses
* Popular Courses
* Reviews
* Course creation and administration
* Course ratings and review management

The project is built using ASP.NET Core Web API, Entity Framework Core, SQL Server, and Azure.

---

# Features

### Courses

* Create course
* Get all courses
* Get course by id
* Update course
* Delete course

### Popular Courses

* Get popular courses
* Display featured courses on the LMS dashboard

### Reviews

* Create review
* Get reviews for a course
* Update review
* Delete review
* Calculate course ratings

---

# Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Azure App Service
* Azure SQL Database
* Swagger / OpenAPI

---

# API Endpoints

## Courses

GET /api/courses

GET /api/courses/{id}

POST /api/courses

PUT /api/courses/{id}

DELETE /api/courses/{id}

---

## Popular Courses

GET /api/popularcourses

---

## Reviews

GET /api/reviews

GET /api/reviews/course/{courseId}

POST /api/reviews

PUT /api/reviews/{id}

DELETE /api/reviews/{id}

---

# How to run the project locally

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Update the connection string in `appsettings.json`.
4. Run Entity Framework migrations.
5. Start the project using the HTTPS profile.
6. Swagger will open automatically.

---

# Database Migrations

To update the database:

```bash
dotnet ef database update
```

To create a new migration:

```bash
dotnet ef migrations add MigrationName
```

---

# Azure

The service is deployed to Azure App Service.

The database runs on Azure SQL Database.

Connection strings and secrets are stored securely in Azure App Service Configuration and are not committed to GitHub.

---

# Frontend Integration

The frontend is built separately using Next.js and communicates with this service through REST API requests.

Frontend features connected to this service include:

* Course List
* Course Details
* Create Course
* Edit Course
* Delete Course
* Popular Courses
* Reviews

---

# Base URL

https://lms-course-service-api-gtd2cbc0dhesgjd5.germanywestcentral-01.azurewebsites.net

---

# Swagger

https://lms-course-service-api-gtd2cbc0dhesgjd5.germanywestcentral-01.azurewebsites.net/swagger

---

# Environment Variable

```env
NEXT_PUBLIC_API_URL=https://lms-course-service-api-gtd2cbc0dhesgjd5.germanywestcentral-01.azurewebsites.net
```
