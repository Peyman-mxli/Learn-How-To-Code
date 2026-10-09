# Class 01 — SQL & Supabase Basics: Questions

**Course:** SQL & Supabase Learning Journey  
**Project context:** ProTrack MX  
**Class:** 01 — Introduction to Databases and SQL  
**Total:** 10 questions  
**Instructions:** Answer each question before opening [the answer key](./ANSWERS.md). The sample tables are fictional. No SQL needs to be executed on a production database.

---

## Question 01 — Read a Single Column

In ProTrack MX, suppose the `students` table contains 100 student records. What does the following SQL query do?

```sql
SELECT name FROM students;
```

- **A.** Returns the name column for all student records.
- **B.** Creates a new student record.
- **C.** Deletes all student records.

## Question 02 — Rows and Columns

Consider the sample table:

| id | name | grade |
| --- | --- | --- |
| 1 | Ali | 95 |
| 2 | Sara | 88 |

What is the difference between a **row** and a **column**?

- **A.** A row is a complete record, and a column represents a field such as `name` or `grade`.
- **B.** A row is the table name, and a column contains the entire database.
- **C.** Rows and columns mean exactly the same thing.

## Question 03 — SQL, PostgreSQL, and Supabase

Which explanation is correct?

- **A.** All three are programming languages with identical purposes.
- **B.** SQL is a language for working with databases; PostgreSQL is a database management system; Supabase provides PostgreSQL and additional backend services.
- **C.** Supabase is only for designing web pages, while SQL builds website interfaces.

## Question 04 — Select Specific Columns

The ProTrack MX `students` table includes `id`, `name`, `age`, and `grade`. You want **only the name and grade** columns. Which query is correct?

- **A.**
  ```sql
  SELECT * FROM students;
  ```
- **B.**
  ```sql
  SELECT name, grade FROM students;
  ```
- **C.**
  ```sql
  INSERT INTO students (name, grade);
  ```
- **D.**
  ```sql
  DELETE FROM students;
  ```

## Question 05 — The Asterisk in SELECT

What does `*` mean in this query?

```sql
SELECT * FROM students;
```

- **A.** Display only the first student.
- **B.** Select all columns from the table.
- **C.** Delete all students.
- **D.** Create a new table.

## Question 06 — Authentication and Authorization

A teacher signs in to ProTrack MX using an email address and password. What is the difference between **authentication** and **authorization**?

- **A.** Authentication deletes data; authorization saves data.
- **B.** Both are used only to create tables.
- **C.** Authentication verifies a user's identity; authorization determines what information and actions the user may access.
- **D.** Authentication is only for SQL; authorization is for designing website interfaces.

## Question 07 — Querying a Nonexistent Table

Suppose the `students` table has **not** been created in PostgreSQL. What happens if you run the following statement, assuming no other accessible relation with this name exists?

```sql
SELECT * FROM students;
```

- **A.** PostgreSQL automatically creates the `students` table.
- **B.** PostgreSQL reports an error because the table does not exist.
- **C.** The statement creates a new table with three sample student records.
- **D.** PostgreSQL deletes every other table.

## Question 08 — Write Your Own SQL Query

In ProTrack MX, you want to display **only the student identifier (`id`) and name (`name`)** from the `students` table.

**Write a SQL SELECT statement yourself.** The order of the selected columns is not prescribed.

```sql
-- Write your answer here.
```

## Question 09 — Production Database Safety

Why should experimental SQL statements not be run directly against the ProTrack MX **production database**?

- **A.** SQL cannot run in production.
- **B.** Supabase permits SQL only in testing environments.
- **C.** Experiments can accidentally change or delete real data, or damage access/security configurations.
- **D.** PostgreSQL does not support SELECT in production.

## Question 10 — Write a Single-Column Query

Consider this fictional `students` table:

| id | name | age | grade |
| --- | --- | --- | --- |
| 1 | Ali | 15 | 95 |
| 2 | Sara | 14 | 88 |
| 3 | Reza | 16 | 76 |

**Write a SQL query that retrieves only the `name` column** from `students`.

```sql
-- Write your answer here.
```

---

## After Completing the Quiz

Read [ANSWERS.md](./ANSWERS.md) to compare your responses with the correct answers and explanations.

**Safety reminder:** All sample names, tables, and scores in this document are educational examples—not verified production records.
