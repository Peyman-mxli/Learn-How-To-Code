using System;

/*
=========================================
ENTITY FRAMEWORK TASKS
=========================================

Complete the following tasks using the Entity Framework concepts
learned in this module.

These tasks use Option A:

Task descriptions only.
No Main method.
No full solutions in this file.

=========================================
TASK 1
CREATE A STUDENT ENTITY
=========================================

Create a class named Student.

The Student class should contain:

- Id
- FullName
- Age
- Email

=========================================
TASK 2
CREATE A COURSE ENTITY
=========================================

Create a class named Course.

The Course class should contain:

- Id
- Title
- Credits

=========================================
TASK 3
CREATE A DBCONTEXT
=========================================

Create a class named SchoolContext.

Inside SchoolContext, create:

- A DbSet for Students
- A DbSet for Courses

=========================================
TASK 4
ADD A STUDENT
=========================================

Create a new Student object.

Add the student to the Students DbSet.

Call SaveChanges().

=========================================
TASK 5
READ ALL STUDENTS
=========================================

Retrieve all students from the database.

Display:

- Id
- FullName
- Age
- Email

=========================================
TASK 6
FIND ONE STUDENT
=========================================

Find one student by Id.

Display the student's information.

=========================================
TASK 7
UPDATE A STUDENT
=========================================

Find a student by Id.

Change the student's email.

Call SaveChanges().

=========================================
TASK 8
DELETE A STUDENT
=========================================

Find a student by Id.

Remove the student from the Students DbSet.

Call SaveChanges().

=========================================
TASK 9
FILTER STUDENTS
=========================================

Use LINQ to find all students older than 18.

Display their names.

=========================================
TASK 10
ORDER STUDENTS
=========================================

Use LINQ to order students by FullName.

Display the ordered list.

=========================================
TASK 11
COUNT STUDENTS
=========================================

Count how many students exist in the database.

Display the total number.

=========================================
TASK 12
CHECK IF STUDENT EXISTS
=========================================

Use Any() to check if a student with a specific email exists.

Display true or false.

=========================================
TASK 13
CREATE A RELATIONSHIP
=========================================

Create a relationship between Student and Course.

A student can be enrolled in many courses.

A course can have many students.

=========================================
TASK 14
CREATE A MIGRATION
=========================================

Write the command used to create a migration named InitialCreate.

=========================================
TASK 15
UPDATE DATABASE
=========================================

Write the command used to apply migrations to the database.

=========================================
TASK 16
USE ASNOTRACKING
=========================================

Retrieve all students using AsNoTracking().

Explain why AsNoTracking() is useful.

=========================================
TASK 17
CREATE A PROFESSIONAL ENTITY
=========================================

Create an Employee entity.

The Employee class should contain:

- Id
- FirstName
- LastName
- Email
- Salary
- CreatedAt

=========================================
TASK 18
CREATE CRUD OPERATIONS
=========================================

Create CRUD operations for the Employee entity:

- Create employee
- Read employees
- Update employee
- Delete employee

=========================================
TASK 19
CREATE A REAL-WORLD QUERY
=========================================

Use LINQ to find employees with salary greater than 10000.

Order them by LastName.

=========================================
TASK 20
EXPLAIN ENTITY FRAMEWORK
=========================================

In your own words, explain:

- What Entity Framework is
- What an ORM is
- What DbContext does
- What DbSet does
- Why SaveChanges() is important

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
