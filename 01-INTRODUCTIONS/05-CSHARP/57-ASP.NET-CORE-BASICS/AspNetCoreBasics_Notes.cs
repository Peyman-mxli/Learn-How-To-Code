using System;

/*
==================================================
ASP.NET CORE BASICS NOTES
==================================================

ASP.NET Core is Microsoft's modern framework
for building web applications and APIs using C#.

It allows me to create:

- Websites
- Web Applications
- REST APIs
- Backend Services
- Cloud Applications
- Enterprise Systems

ASP.NET Core is one of the most important
technologies in the .NET ecosystem.

==================================================
WHAT IS A WEB APPLICATION?
==================================================

A web application is a program that runs on a server
and is accessed through a web browser.

Examples:

- Google
- YouTube
- Facebook
- Amazon
- GitHub

When I visit a website:

Browser
   ↓
Request
   ↓
Server
   ↓
Response
   ↓
Browser

This process happens constantly.

==================================================
CLIENT AND SERVER
==================================================

Client

The client is the application making requests.

Examples:

- Chrome
- Firefox
- Edge
- Mobile Apps

Server

The server receives requests and sends responses.

ASP.NET Core usually runs on the server.

Example:

Client
   ↓
Request
   ↓
ASP.NET Core Server
   ↓
Response
   ↓
Client

==================================================
FRONTEND VS BACKEND
==================================================

Frontend

The part users see.

Examples:

- Buttons
- Forms
- Images
- Menus
- Colors

Technologies:

- HTML
- CSS
- JavaScript

Backend

The part users do not see.

Examples:

- Database operations
- Authentication
- Business logic
- API processing

Technologies:

- C#
- ASP.NET Core
- SQL Server
- Entity Framework

==================================================
WHAT IS ASP.NET CORE?
==================================================

ASP.NET Core is:

- Open Source
- Cross Platform
- High Performance
- Cloud Ready
- Modern

It works on:

- Windows
- Linux
- macOS

==================================================
COMMON PROJECT TYPES
==================================================

1. MVC Application

Uses:

- Models
- Views
- Controllers

Creates full websites.

--------------------------------

2. Web API

Creates endpoints.

Example:

/api/students

Returns data.

--------------------------------

3. Razor Pages

Simplified page-based approach.

--------------------------------

4. Blazor

Builds interactive web applications using C#.

==================================================
REQUEST AND RESPONSE
==================================================

Everything on the web works using:

Request
Response

Example:

Browser requests:

https://mysite.com/products

Server responds:

Products Page

The cycle:

Client
→ Request

Server
→ Process Request

Server
→ Response

Client
→ Display Result

==================================================
HTTP
==================================================

HTTP

HyperText Transfer Protocol

Used for communication between:

Client
and
Server

Common HTTP Methods:

GET

Retrieve data.

POST

Create data.

PUT

Update data.

DELETE

Delete data.

==================================================
HTTP EXAMPLES
==================================================

GET

/api/students

Get all students.

--------------------------------

POST

/api/students

Create student.

--------------------------------

PUT

/api/students/1

Update student.

--------------------------------

DELETE

/api/students/1

Delete student.

==================================================
ROUTES
==================================================

Routes define URLs.

Example:

/home

/about

/contact

/api/students

ASP.NET Core maps routes
to specific code.

==================================================
CONTROLLERS
==================================================

Controllers handle requests.

Example:

StudentController

Receives requests.

Processes logic.

Returns response.

Example:

StudentController

GET Students

Returns:

Student List

==================================================
ACTION METHODS
==================================================

Actions are methods inside controllers.

Example:

GetStudents()

GetStudent()

CreateStudent()

DeleteStudent()

Each action performs a task.

==================================================
MODELS
==================================================

Models represent data.

Example:

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }
}

Models are often connected
to databases.

==================================================
MVC ARCHITECTURE
==================================================

MVC means:

Model
View
Controller

--------------------------------

Model

Stores data.

--------------------------------

View

Displays data.

--------------------------------

Controller

Handles requests.

Coordinates Model and View.

==================================================
MVC FLOW
==================================================

User
   ↓

Controller
   ↓

Model
   ↓

Database

Model
   ↓

Controller
   ↓

View
   ↓

User

==================================================
WEB APIs
==================================================

API

Application Programming Interface

An API allows applications
to communicate.

Example:

Mobile App

Requests:

/api/students

Server returns:

JSON Data

==================================================
JSON
==================================================

JSON

JavaScript Object Notation

Most common format
used in APIs.

Example:

{
  "id": 1,
  "name": "Peyman"
}

Easy for applications to read.

==================================================
MIDDLEWARE
==================================================

Middleware is software
that runs during requests.

Example:

Request
 ↓
Authentication
 ↓
Logging
 ↓
Routing
 ↓
Controller
 ↓
Response

Each middleware performs
a specific task.

==================================================
COMMON MIDDLEWARE
==================================================

Authentication

Checks user identity.

--------------------------------

Authorization

Checks permissions.

--------------------------------

Logging

Records activity.

--------------------------------

Exception Handling

Handles errors.

--------------------------------

Routing

Finds correct endpoint.

==================================================
DEPENDENCY INJECTION
==================================================

Dependency Injection (DI)

Built directly into ASP.NET Core.

Purpose:

Provide required services automatically.

Benefits:

- Cleaner code
- Easier testing
- Better maintenance

==================================================
SERVICE EXAMPLE
==================================================

StudentService

Contains student logic.

Controller receives:

StudentService

through dependency injection.

Controller doesn't create
the service manually.

==================================================
CONFIGURATION
==================================================

ASP.NET Core applications
use configuration files.

Most common:

appsettings.json

Stores:

- Connection Strings
- API Keys
- Settings
- Application Configuration

==================================================
PROGRAM.CS
==================================================

Program.cs is the startup file.

Responsibilities:

- Configure services
- Configure middleware
- Configure application startup

Every ASP.NET Core project
starts here.

==================================================
ENDPOINTS
==================================================

Endpoints are URLs exposed
by the application.

Examples:

/students

/products

/orders

/api/users

Clients access endpoints
to perform actions.

==================================================
STATUS CODES
==================================================

HTTP responses include status codes.

200

Success

--------------------------------

201

Created

--------------------------------

400

Bad Request

--------------------------------

401

Unauthorized

--------------------------------

403

Forbidden

--------------------------------

404

Not Found

--------------------------------

500

Internal Server Error

==================================================
SECURITY
==================================================

Important ASP.NET Core topics:

- Authentication
- Authorization
- HTTPS
- Secure APIs
- Input Validation

Security is critical
in production systems.

==================================================
ADVANTAGES OF ASP.NET CORE
==================================================

✔ Fast

✔ Cross Platform

✔ Modern

✔ Open Source

✔ Cloud Ready

✔ Built-in Dependency Injection

✔ Excellent Performance

✔ Large Community

✔ Enterprise Ready

==================================================
WHERE ASP.NET CORE IS USED
==================================================

- Banking Systems

- E-Commerce Platforms

- School Systems

- Hospital Systems

- Inventory Management

- ERP Software

- CRM Platforms

- Enterprise APIs

- Cloud Applications

==================================================
MODULE SUMMARY
==================================================

In this module I learned:

✔ What ASP.NET Core is

✔ Client and Server Concepts

✔ Frontend vs Backend

✔ HTTP Basics

✔ Requests and Responses

✔ Routes

✔ Controllers

✔ Models

✔ MVC Architecture

✔ APIs

✔ JSON

✔ Middleware

✔ Dependency Injection

✔ Program.cs

✔ Endpoints

✔ Status Codes

✔ Security Basics

These concepts form the foundation
for professional web development
using C# and ASP.NET Core.
*/

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
