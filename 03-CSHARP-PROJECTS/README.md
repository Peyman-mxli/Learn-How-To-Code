# C# Projects

This section contains practical C# projects that apply the concepts from the C# curriculum in `01-INTRODUCTIONS/05-CSHARP`.

## Current projects

| # | Project | Focus | Status |
|---:|---|---|---|
| 01 | [Student Management System](./01-STUDENT-MANAGEMENT-SYSTEM/) | Console CRUD, OOP, collections, validation, LINQ | Complete |

## Project standards

Each C# project should include:

- a `.csproj` file so it can be built with the .NET CLI;
- a clear `README.md`;
- requirements or acceptance criteria;
- separated domain and application logic where practical;
- validation instead of unsafe direct conversions;
- no secrets or personal contact information in source code;
- no committed `bin/`, `obj/`, IDE caches, or user-specific files; and
- reproducible build and run instructions.

## Build workflow

From a project directory:

```bash
dotnet restore
dotnet build
dotnet run
```

For release verification:

```bash
dotnet build -c Release
```

## Learning progression

The first project focuses on a clean console application. Future projects can progress toward persistence, testing, Entity Framework Core, ASP.NET Core APIs, authentication, cloud deployment, and professional architecture.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026

