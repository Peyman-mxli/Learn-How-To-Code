using System;

/*
==================================================
REST APIS NOTES
==================================================

REST API is one of the most important concepts
in modern software development.

Almost every modern application communicates
through APIs.

Examples:

- Mobile Apps
- Websites
- Banking Systems
- Social Networks
- E-Commerce Platforms
- School Systems
- Cloud Services

==================================================
WHAT IS AN API?
==================================================

API

Application Programming Interface

An API allows two applications
to communicate with each other.

Example:

Mobile App
   ↓
API
   ↓
Database

The mobile app does not access
the database directly.

Instead:

Mobile App
→ API

API
→ Database

Database
→ API

API
→ Mobile App

==================================================
REAL WORLD EXAMPLE
==================================================

Imagine a restaurant.

Customer
=
Client

Waiter
=
API

Kitchen
=
Server

Customer tells waiter:

"I want pizza."

Waiter delivers request
to kitchen.

Kitchen prepares food.

Waiter returns food.

API works similarly.

==================================================
WHAT IS REST?
==================================================

REST

Representational State Transfer

REST is a set of architectural rules
for designing APIs.

REST APIs are:

✔ Simple

✔ Fast

✔ Scalable

✔ Easy to Understand

✔ Widely Used

==================================================
REST PRINCIPLES
==================================================

REST APIs should:

1. Use HTTP

2. Use Resources

3. Be Stateless

4. Return Representations

5. Use Standard Methods

==================================================
RESOURCE
==================================================

A resource is something
the API manages.

Examples:

Student

Product

Order

Customer

Book

User

Examples:

/students

/products

/orders

/users

==================================================
ENDPOINTS
==================================================

Endpoints are URLs
that expose resources.

Examples:

/api/students

/api/products

/api/orders

/api/users

Clients communicate
through endpoints.

==================================================
HTTP
==================================================

REST APIs use HTTP.

HTTP

HyperText Transfer Protocol

Used for:

Requests
Responses

==================================================
HTTP METHODS
==================================================

GET

Retrieve data.

--------------------------------

POST

Create data.

--------------------------------

PUT

Update data.

--------------------------------

PATCH

Partially update data.

--------------------------------

DELETE

Remove data.

==================================================
GET REQUEST
==================================================

GET

Used for reading data.

Example:

GET /api/students

Returns:

All students.

Example:

GET /api/students/5

Returns:

Student with Id 5.

==================================================
POST REQUEST
==================================================

POST

Creates new data.

Example:

POST /api/students

Request Body:

{
  "name": "Peyman",
  "age": 25
}

Creates a new student.

==================================================
PUT REQUEST
==================================================

PUT

Updates an existing resource.

Example:

PUT /api/students/5

Request Body:

{
  "name": "Ali",
  "age": 30
}

Entire resource is replaced.

==================================================
PATCH REQUEST
==================================================

PATCH

Partially updates a resource.

Example:

PATCH /api/students/5

Request Body:

{
  "age": 30
}

Only age changes.

==================================================
DELETE REQUEST
==================================================

DELETE

Removes data.

Example:

DELETE /api/students/5

Student is removed.

==================================================
REQUEST
==================================================

A request contains:

- URL
- Method
- Headers
- Optional Body

Example:

POST /api/students

Body:

{
  "name":"Peyman"
}

==================================================
RESPONSE
==================================================

A response contains:

- Status Code
- Headers
- Data

Example:

200 OK

{
  "id":1,
  "name":"Peyman"
}

==================================================
JSON
==================================================

JSON

JavaScript Object Notation

Most common format
for REST APIs.

Example:

{
  "id": 1,
  "name": "Peyman",
  "age": 25
}

==================================================
JSON ARRAY
==================================================

[
  {
    "id": 1,
    "name": "Peyman"
  },

  {
    "id": 2,
    "name": "Sara"
  }
]

Used for multiple records.

==================================================
STATUS CODES
==================================================

HTTP Status Codes indicate results.

==================================================
200 OK
==================================================

Request successful.

==================================================
201 CREATED
==================================================

Resource created successfully.

==================================================
204 NO CONTENT
==================================================

Request successful.

No content returned.

==================================================
400 BAD REQUEST
==================================================

Invalid request.

==================================================
401 UNAUTHORIZED
==================================================

User not authenticated.

==================================================
403 FORBIDDEN
==================================================

User lacks permission.

==================================================
404 NOT FOUND
==================================================

Resource not found.

==================================================
500 INTERNAL SERVER ERROR
==================================================

Unexpected server error.

==================================================
ROUTE PARAMETERS
==================================================

Route parameters are values
inside URLs.

Example:

/api/students/5

5

is a route parameter.

Used to identify resources.

==================================================
QUERY PARAMETERS
==================================================

Query parameters provide filters.

Example:

/api/students?age=25

Parameter:

age=25

Example:

/api/products?category=laptop

==================================================
CONTROLLERS
==================================================

Controllers process requests.

Example:

StudentController

Handles:

GET Students

POST Students

PUT Students

DELETE Students

==================================================
API MODEL
==================================================

Model represents data.

Example:

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }
}

==================================================
REQUEST BODY
==================================================

POST and PUT usually
contain request body data.

Example:

{
  "name":"Peyman",
  "age":25
}

Body data becomes
a C# object.

==================================================
CRUD OPERATIONS
==================================================

REST APIs commonly perform:

Create
Read
Update
Delete

CRUD

Create
=
POST

Read
=
GET

Update
=
PUT / PATCH

Delete
=
DELETE

==================================================
STATELESS
==================================================

REST APIs are stateless.

Meaning:

Every request contains
all required information.

Server does not remember
previous requests.

Benefits:

✔ Scalability

✔ Simplicity

✔ Better Performance

==================================================
API VERSIONING
==================================================

Large APIs often use versions.

Example:

/api/v1/students

/api/v2/students

Allows updates without
breaking old clients.

==================================================
AUTHENTICATION
==================================================

Authentication verifies identity.

Examples:

- Login
- Tokens
- JWT
- OAuth

Question:

Who are you?

==================================================
AUTHORIZATION
==================================================

Authorization verifies permissions.

Question:

What are you allowed to do?

Example:

Admin

Can delete users.

Normal User

Cannot delete users.

==================================================
HTTPS
==================================================

HTTPS encrypts communication.

Protects:

- Passwords
- Credit Cards
- Personal Data
- Tokens

Always use HTTPS
in production systems.

==================================================
ADVANTAGES OF REST APIS
==================================================

✔ Easy to Learn

✔ Platform Independent

✔ Scalable

✔ Fast

✔ Widely Supported

✔ Works with Mobile Apps

✔ Works with Websites

✔ Works with Cloud Systems

==================================================
WHERE REST APIS ARE USED
==================================================

- Facebook

- Instagram

- TikTok

- GitHub

- Amazon

- Banking Apps

- Hospital Systems

- School Systems

- Enterprise Software

==================================================
MODULE SUMMARY
==================================================

In this module I learned:

✔ What an API is

✔ What REST means

✔ REST principles

✔ Resources

✔ Endpoints

✔ HTTP

✔ GET

✔ POST

✔ PUT

✔ PATCH

✔ DELETE

✔ Requests

✔ Responses

✔ JSON

✔ Status Codes

✔ Route Parameters

✔ Query Parameters

✔ Controllers

✔ Models

✔ CRUD Operations

✔ Authentication

✔ Authorization

✔ HTTPS

✔ API Versioning

These concepts form the foundation
of professional REST API development
using ASP.NET Core and C#.
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
