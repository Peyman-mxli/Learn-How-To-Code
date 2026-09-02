# Student Management System — Requirements

## Objective

Build a menu-driven C# console application that performs CRUD operations on student records.

## Student record

Each student contains:

| Field | Rule |
|---|---|
| Student ID | positive integer and unique |
| Full Name | required |
| Age | 1–130 |
| Email | required and basic email-format validation |
| Course | required |
| Grade | 0–100 |

## Functional requirements

### FR-01 — Add student

The system shall create a student only when the record passes validation and the Student ID is unique.

### FR-02 — View students

The system shall list all records and display the total count.

### FR-03 — Search

The system shall support:

- exact Student ID search;
- case-insensitive full or partial name search.

### FR-04 — Update

The system shall update name, age, email, course, and grade while preserving Student ID.

### FR-05 — Delete

The system shall require confirmation before deleting a record.

### FR-06 — Exit

The application shall exit cleanly through the menu.

## Non-functional requirements

- compile with .NET 8;
- avoid unsafe `Convert.ToInt32` / `Convert.ToDouble` for interactive input;
- use nullable reference type checking;
- keep domain logic out of the menu where practical;
- do not store personal contact details or secrets in source code;
- do not commit build artifacts.

## Storage

The MVP stores records in memory with `List<Student>`.

## Acceptance criteria

The project is complete when:

- all CRUD operations work;
- duplicate IDs are rejected;
- invalid ages and grades are rejected;
- empty required fields are rejected;
- invalid numeric input does not crash the program;
- searches by both ID and name work;
- the project builds through `dotnet build`.

## Status

**Implementation complete.**
