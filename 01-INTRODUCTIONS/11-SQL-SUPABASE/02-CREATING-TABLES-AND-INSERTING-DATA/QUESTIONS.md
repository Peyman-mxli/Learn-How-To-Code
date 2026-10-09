# Class 02 — Questions (10)

**SQL & Supabase Learning Journey | ProTrack MX**

Answer all questions before opening [ANSWERS.md](./ANSWERS.md). The tables and student names are fictional examples. Do not run exercise SQL in production.

## Question 01 — Create a Table

What does `CREATE TABLE students (...);` do?

- **A.** Reads existing student names.
- **B.** Creates a table with the specified structure.
- **C.** Adds a student record.
- **D.** Deletes every student.

## Question 02 — Choose Data Types

Which data type is most suitable for storing a student's name?

- **A.** INTEGER
- **B.** BOOLEAN
- **C.** TEXT
- **D.** DATE

## Question 03 — A Decimal Grade

A student has a score of **92.75**. Which column type is most suitable when an exact decimal value is wanted?

- **A.** INTEGER
- **B.** NUMERIC(5,2)
- **C.** BOOLEAN
- **D.** DATE

## Question 04 — Primary Key

Why would `id INTEGER PRIMARY KEY` be useful in a students table?

- **A.** It can uniquely identify each record.
- **B.** It forces all students to have different names.
- **C.** It automatically stores the current date.
- **D.** It automatically generates integer IDs in PostgreSQL without additional syntax.

## Question 05 — NOT NULL

Given `name TEXT NOT NULL`, what is true?

- **A.** The name cannot contain spaces.
- **B.** The name must be unique.
- **C.** The name cannot be an SQL NULL value.
- **D.** The name is automatically filled with the student's ID.

## Question 06 — Auto-generated IDs

Which PostgreSQL declaration generates integer IDs and makes them the primary key?

- **A.** `id TEXT UNIQUE`
- **B.** `id INTEGER PRIMARY KEY`
- **C.** `id INTEGER NOT NULL`
- **D.** `id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY`

## Question 07 — Insert a Record

Assume a practice table `students` has columns `name TEXT`, `age INTEGER`, and `grade NUMERIC`. Which query correctly inserts one row?

- **A.** `SELECT name, age, grade FROM students;`
- **B.** `INSERT INTO students (name, age, grade) VALUES ('Ali', 15, 95);`
- **C.** `CREATE TABLE students (name, age, grade);`
- **D.** `UPDATE students SET name = 'Ali';`

## Question 08 — CHECK Constraint

A `grade NUMERIC(5,2) CHECK (grade BETWEEN 0 AND 100)` column is given the value 125 in an INSERT. What happens?

- **A.** PostgreSQL automatically converts it to 100.
- **B.** PostgreSQL stores it as 125.
- **C.** PostgreSQL rejects the row because it violates the check.
- **D.** PostgreSQL deletes the entire table.

## Question 09 — Write an INSERT

The practice table `students` has `name TEXT`, `age INTEGER`, and `grade NUMERIC`. Write a valid SQL statement inserting **Mina**, age **15**, grade **92.50**.

```sql
-- Your SQL:
```

## Question 10 — Write a SELECT

Write SQL to retrieve only the `name` and `grade` columns from the practice table `students`.

```sql
-- Your SQL:
```

---

[Lesson README](./README.md) · [Answer Key](./ANSWERS.md)
