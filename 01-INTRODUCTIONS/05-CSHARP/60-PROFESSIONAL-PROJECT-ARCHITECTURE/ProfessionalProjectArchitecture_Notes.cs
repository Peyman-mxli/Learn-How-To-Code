using System;

/*
==================================================
PROFESSIONAL PROJECT ARCHITECTURE NOTES
==================================================

Professional software projects are not built by
placing everything inside one file.

As projects grow, organization becomes critical.

Good architecture helps software remain:

✔ Readable

✔ Maintainable

✔ Testable

✔ Scalable

✔ Flexible

✔ Team Friendly

==================================================
WHAT IS PROJECT ARCHITECTURE?
==================================================

Project Architecture is the structure of a software
application.

It defines:

- How code is organized
- How classes communicate
- How responsibilities are separated
- How data flows through the system

Architecture provides a blueprint for development.

==================================================
WHY ARCHITECTURE MATTERS
==================================================

Without architecture:

- Code becomes messy
- Bugs become harder to fix
- Features become harder to add
- Teamwork becomes difficult
- Testing becomes difficult

With architecture:

- Development becomes easier
- Maintenance becomes easier
- Scaling becomes easier

==================================================
REAL WORLD EXAMPLE
==================================================

Imagine building a city.

Without planning:

- Roads go everywhere
- Buildings are random
- Utilities become confusing

With planning:

- Roads are organized
- Buildings have purpose
- Growth becomes easier

Software architecture works the same way.

==================================================
SEPARATION OF RESPONSIBILITIES
==================================================

One of the most important principles.

Each class should have one clear responsibility.

Bad Example:

StudentManager

- Reads database
- Validates data
- Sends emails
- Creates reports

Too many responsibilities.

Good Example:

StudentRepository

Handles database.

--------------------------------

StudentService

Handles business logic.

--------------------------------

EmailService

Handles emails.

==================================================
LAYERS
==================================================

Professional projects commonly use layers.

Typical layers:

Presentation Layer

Application Layer

Domain Layer

Infrastructure Layer

==================================================
PRESENTATION LAYER
==================================================

Responsible for interacting with users.

Examples:

- Controllers
- API Endpoints
- Views
- User Interfaces

Responsibilities:

Receive requests.

Send responses.

Nothing more.

==================================================
APPLICATION LAYER
==================================================

Contains business logic.

Examples:

StudentService

OrderService

UserService

Responsibilities:

Process rules.

Coordinate operations.

Handle workflows.

==================================================
DOMAIN LAYER
==================================================

Contains core business entities.

Examples:

Student

Teacher

Order

Customer

Product

Domain objects represent business concepts.

==================================================
INFRASTRUCTURE LAYER
==================================================

Handles external systems.

Examples:

Database

File System

Email Service

Third-Party APIs

Cloud Storage

Infrastructure supports the application.

==================================================
TYPICAL DATA FLOW
==================================================

Client
 ↓

Controller
 ↓

Service
 ↓

Repository
 ↓

Database

Database
 ↓

Repository
 ↓

Service
 ↓

Controller
 ↓

Client

==================================================
CONTROLLERS
==================================================

Controllers belong to the presentation layer.

Responsibilities:

✔ Receive requests

✔ Validate basic input

✔ Return responses

Controllers should NOT contain
large business logic.

==================================================
SERVICES
==================================================

Services contain business rules.

Example:

StudentService

Responsibilities:

- Create students
- Update students
- Validate rules
- Coordinate repositories

==================================================
REPOSITORIES
==================================================

Repositories manage data access.

Responsibilities:

- Read database
- Write database
- Update database
- Delete database records

Repositories isolate data operations.

==================================================
REPOSITORY EXAMPLE
==================================================

StudentRepository

Methods:

GetAll()

GetById()

Add()

Update()

Delete()

Only handles data.

==================================================
DTO
==================================================

DTO

Data Transfer Object

Used to transfer data between layers.

==================================================
WHY USE DTOs?
==================================================

Benefits:

✔ Security

✔ Simplicity

✔ Smaller Responses

✔ Better API Design

==================================================
DTO EXAMPLE
==================================================

Entity:

Student

{
    Id
    Name
    Age
    Email
    Password
}

DTO:

StudentDto

{
    Id
    Name
    Age
}

Password hidden.

==================================================
DEPENDENCY INJECTION
==================================================

Dependency Injection allows services
to be supplied automatically.

Instead of:

StudentController

creates StudentService.

We inject StudentService.

Benefits:

✔ Loose Coupling

✔ Easier Testing

✔ Cleaner Code

==================================================
LOOSE COUPLING
==================================================

Loose Coupling means classes
depend less on each other.

Benefits:

✔ Easier Changes

✔ Easier Testing

✔ Better Maintenance

==================================================
HIGH COHESION
==================================================

High Cohesion means a class
focuses on one responsibility.

Good Example:

EmailService

Only handles email.

==================================================
PROJECT FOLDER STRUCTURE
==================================================

Example:

Project

├── Controllers

├── Services

├── Repositories

├── Models

├── DTOs

├── Interfaces

├── Data

├── Middleware

├── Configuration

└── Tests

Organization improves readability.

==================================================
INTERFACES
==================================================

Interfaces define contracts.

Example:

IStudentRepository

Defines:

GetAll()

GetById()

Add()

Benefits:

✔ Flexibility

✔ Testability

✔ Better Architecture

==================================================
CONFIGURATION
==================================================

Configuration stores settings.

Examples:

Connection Strings

API Keys

Application Settings

Environment Settings

Usually stored in:

appsettings.json

==================================================
ERROR HANDLING
==================================================

Professional projects handle errors properly.

Examples:

Try/Catch

Logging

Custom Exceptions

Validation Errors

==================================================
LOGGING
==================================================

Logging records application activity.

Examples:

User Login

Errors

Warnings

System Events

Logging helps debugging.

==================================================
TESTING
==================================================

Professional projects include testing.

Examples:

Unit Tests

Integration Tests

Benefits:

✔ Better Quality

✔ Fewer Bugs

✔ Safer Changes

==================================================
SCALABILITY
==================================================

Scalability means the application
can grow without major redesign.

Good architecture supports:

- More users
- More features
- More developers

==================================================
MAINTAINABILITY
==================================================

Maintainability means code remains
easy to update over time.

Good architecture improves:

✔ Readability

✔ Simplicity

✔ Documentation

✔ Refactoring

==================================================
CLEAN ARCHITECTURE IDEA
==================================================

Clean Architecture promotes:

Business Rules
Independent

Database
Independent

Framework
Independent

UI
Independent

Core logic remains protected.

==================================================
SOLID CONNECTION
==================================================

Professional architecture uses:

S
Single Responsibility

O
Open/Closed

L
Liskov Substitution

I
Interface Segregation

D
Dependency Inversion

Together with clean architecture.

==================================================
WHERE PROFESSIONAL ARCHITECTURE IS USED
==================================================

- Banking Systems

- School Systems

- Hospital Systems

- ERP Platforms

- Inventory Systems

- Cloud Services

- Enterprise Applications

- Government Systems

==================================================
MODULE SUMMARY
==================================================

In this module I learned:

✔ Project Architecture

✔ Layered Design

✔ Presentation Layer

✔ Application Layer

✔ Domain Layer

✔ Infrastructure Layer

✔ Controllers

✔ Services

✔ Repositories

✔ DTOs

✔ Dependency Injection

✔ Interfaces

✔ Configuration

✔ Logging

✔ Error Handling

✔ Testing

✔ Scalability

✔ Maintainability

✔ Clean Architecture

✔ Professional Project Structure

These concepts represent the foundation
of professional C# software development.
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
