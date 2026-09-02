using System;

/*
=========================================
ENTITY FRAMEWORK NOTES
=========================================

Entity Framework (EF) is Microsoft's Object Relational Mapper (ORM).

An ORM allows me to work with a database using C# classes and objects
instead of writing large amounts of SQL manually.

Without Entity Framework:

I must write SQL:

SELECT * FROM Students

INSERT INTO Students(Name)
VALUES('Peyman')

UPDATE Students
SET Name = 'Ali'
WHERE Id = 1

DELETE FROM Students
WHERE Id = 1

With Entity Framework:

I work directly with C# objects:

Student student = new Student();
student.Name = "Peyman";

context.Students.Add(student);
context.SaveChanges();

Entity Framework automatically creates and executes
the SQL behind the scenes.

This makes development faster, cleaner, and easier.

==================================================
WHAT IS AN ORM?
==================================================

ORM = Object Relational Mapper

Object
=
C# Class

Relational
=
Database Tables

Mapper
=
Connects the two together

Example:

C# Class

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

Database Table

--------------------------------
| Id | Name                    |
--------------------------------
| 1  | Peyman                  |
| 2  | Ali                     |
--------------------------------

Entity Framework maps the class to the table.

==================================================
WHY USE ENTITY FRAMEWORK?
==================================================

Benefits:

1. Less SQL Code

I can write C# instead of SQL.

2. Faster Development

Less code means faster applications.

3. Easier Maintenance

Code is easier to read.

4. Strong Typing

Compile-time checking helps prevent errors.

5. LINQ Support

I can query data using LINQ.

6. Migration System

Database changes can be version controlled.

7. Industry Standard

Used heavily in professional .NET projects.

==================================================
ENTITY FRAMEWORK CORE
==================================================

The modern version is:

Entity Framework Core (EF Core)

Official Microsoft ORM.

Works with:

- SQL Server
- SQLite
- PostgreSQL
- MySQL
- Oracle
- Azure Databases

and many others.

==================================================
IMPORTANT COMPONENTS
==================================================

Entity
DbContext
DbSet
Migration
Database

These are the core building blocks.

==================================================
ENTITY
==================================================

An Entity is simply a class that represents a table.

Example:

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }
}

This class becomes:

Students Table

--------------------------------
| Id | Name | Age             |
--------------------------------

Each object becomes a row.

==================================================
PRIMARY KEY
==================================================

Entity Framework automatically recognizes:

Id

or

StudentId

as primary keys.

Example:

public int Id { get; set; }

This becomes:

PRIMARY KEY

inside the database.

==================================================
DBCONTEXT
==================================================

DbContext is the bridge between:

Application
and
Database

Example:

public class SchoolContext : DbContext
{
}

Without DbContext:

No database connection exists.

DbContext manages:

- Connections
- Queries
- Updates
- Inserts
- Deletes
- Tracking changes

==================================================
DBSET
==================================================

DbSet represents a database table.

Example:

public DbSet<Student> Students { get; set; }

Meaning:

Students table exists in the database.

If multiple tables exist:

public DbSet<Student> Students { get; set; }

public DbSet<Teacher> Teachers { get; set; }

public DbSet<Course> Courses { get; set; }

==================================================
CRUD OPERATIONS
==================================================

CRUD means:

C = Create
R = Read
U = Update
D = Delete

==================================================
CREATE
==================================================

Student student = new Student();

student.Name = "Peyman";
student.Age = 25;

context.Students.Add(student);

context.SaveChanges();

Add()
=
Adds object to database.

SaveChanges()
=
Executes SQL.

==================================================
READ
==================================================

var students = context.Students.ToList();

Returns all students.

Single student:

var student =
context.Students.Find(1);

Find()

Searches using primary key.

==================================================
UPDATE
==================================================

var student =
context.Students.Find(1);

student.Name = "Ali";

context.SaveChanges();

Entity Framework automatically detects changes.

==================================================
DELETE
==================================================

var student =
context.Students.Find(1);

context.Students.Remove(student);

context.SaveChanges();

Record removed from database.

==================================================
SAVECHANGES()
==================================================

Very important.

Nothing is sent to the database until:

context.SaveChanges();

Example:

student.Name = "Peyman";

Without SaveChanges()

Database is unchanged.

==================================================
LINQ WITH ENTITY FRAMEWORK
==================================================

Entity Framework works perfectly with LINQ.

Example:

var students =
context.Students
.Where(s => s.Age > 18)
.ToList();

Generated SQL happens automatically.

Example:

SELECT *
FROM Students
WHERE Age > 18

but I only write C#.

==================================================
ORDERING DATA
==================================================

var students =
context.Students
.OrderBy(s => s.Name)
.ToList();

Descending:

.OrderByDescending(s => s.Name)

==================================================
FILTERING DATA
==================================================

var students =
context.Students
.Where(s => s.Name.StartsWith("P"))
.ToList();

==================================================
FIRST RECORD
==================================================

var student =
context.Students.First();

First matching record:

var student =
context.Students.First(s => s.Age > 18);

==================================================
COUNT RECORDS
==================================================

int count =
context.Students.Count();

==================================================
ANY
==================================================

bool exists =
context.Students.Any(s => s.Name == "Peyman");

Returns:

true
or
false

==================================================
CODE FIRST APPROACH
==================================================

Most common approach.

Steps:

1. Create C# Classes

2. Create DbContext

3. Generate Migration

4. Create Database

Database is generated from code.

Hence:

Code First

==================================================
DATABASE FIRST APPROACH
==================================================

Opposite approach.

Steps:

1. Database already exists

2. Generate C# classes from database

Database comes first.

==================================================
MIGRATIONS
==================================================

Migration =
Database version control

Example:

I add:

public string Email { get; set; }

to Student.

Database must update.

Migration records the change.

Common commands:

Add-Migration AddEmailField

Update-Database

Entity Framework updates the database safely.

==================================================
RELATIONSHIPS
==================================================

Real applications contain related tables.

Examples:

Student
Course

Customer
Order

Author
Book

Relationships allow tables to connect.

==================================================
ONE TO MANY
==================================================

Example:

One Teacher

Many Students

Teacher

Id
Name

Student

Id
Name
TeacherId

TeacherId connects them.

==================================================
MANY TO MANY
==================================================

Example:

Students

Courses

One student can take many courses.

One course can contain many students.

Entity Framework can manage this automatically.

==================================================
TRACKING
==================================================

Entity Framework tracks objects.

Example:

Student student =
context.Students.Find(1);

student.Name = "Ali";

EF remembers:

Old value
New value

and generates UPDATE SQL automatically.

==================================================
ASNOTRACKING()
==================================================

Read-only optimization.

Example:

var students =
context.Students
.AsNoTracking()
.ToList();

Improves performance.

Useful when data won't be updated.

==================================================
ADVANTAGES OF ENTITY FRAMEWORK
==================================================

✔ Less SQL

✔ Faster development

✔ Strong typing

✔ LINQ support

✔ Automatic tracking

✔ Migrations

✔ Cross database support

✔ Industry standard

==================================================
DISADVANTAGES
==================================================

✘ Slight learning curve

✘ Can generate inefficient queries
  if used incorrectly

✘ Extra abstraction layer

==================================================
WHERE ENTITY FRAMEWORK IS USED
==================================================

- ASP.NET Core APIs

- Web Applications

- Inventory Systems

- Banking Software

- ERP Systems

- CRM Systems

- Hospital Management Systems

- E-Commerce Platforms

- Enterprise Applications

==================================================
MODULE SUMMARY
==================================================

In this module I learned:

✔ What Entity Framework is

✔ What an ORM is

✔ Entities

✔ DbContext

✔ DbSet

✔ CRUD Operations

✔ SaveChanges()

✔ LINQ Queries

✔ Code First

✔ Database First

✔ Migrations

✔ Relationships

✔ Tracking

✔ AsNoTracking()

✔ Professional EF Core Concepts

These concepts form the foundation of professional
database-driven C# applications.
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
