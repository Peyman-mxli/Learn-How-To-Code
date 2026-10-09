# Class 02 — Creating Tables and Inserting Data

**SQL & Supabase Learning Journey | PostgreSQL | ProTrack MX**

[Course Home](../README.md) · [Class 01](../01-DATABASE-AND-SQL-BASICS/README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Objectives

By the end of this lesson, students can explain a table schema, create PostgreSQL tables, distinguish common data types and constraints, insert rows, and read their results.

All ProTrack MX examples below are fictional learning data, **not the verified production database structure**.

## 1. What Does CREATE TABLE Do?

Class 01 introduced reading existing data:

```sql
SELECT name FROM students;
```

SELECT does **not** create a table. Before querying records, a table needs to exist.

```sql
CREATE TABLE students (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    age INTEGER,
    grade NUMERIC
);
```

### Explain Every Part

| SQL | Meaning |
| --- | --- |
| CREATE TABLE | Define a new table |
| students | Table name |
| Parentheses | Enclose column definitions |
| id | Identifier column |
| INTEGER | Whole-number type |
| PRIMARY KEY | Unique, non-NULL identifier |
| name | Name column |
| TEXT | Character string type |
| NOT NULL | Forbid SQL NULL |
| age | Age column |
| NUMERIC | Exact numeric type, including decimals |
| Commas | Separate column definitions |
| Semicolon | End the statement |

PostgreSQL also uses the word *schema* for a namespace (for example, `public`). More generally, a database schema means its structural design.

## 2. PostgreSQL Data Types

| Data type | Meaning | Example |
| --- | --- | --- |
| INTEGER | Whole number | 15 |
| TEXT | Text | 'Ali' |
| NUMERIC(5,2) | Exact number, five total digits and two fractional digits | 95.75 |
| BOOLEAN | True or false | TRUE |
| DATE | Calendar date | '2026-10-09' |
| TIMESTAMPTZ | Time-zone-aware timestamp | NOW() |
| UUID | Unique identifier type | Application identifiers |

Single quotes usually delimit SQL string literals. Numbers are not ordinarily quoted.

## 3. Understanding Constraints

**PRIMARY KEY** identifies a row uniquely and prevents NULL. Two students named Ali can still have separate IDs.

**NOT NULL** requires the column to contain a non-NULL value. It does not automatically forbid an empty string.

**UNIQUE** constrains duplicates; PostgreSQL's default UNIQUE behavior normally permits multiple NULL values.

**CHECK** requires a condition, such as a grade being between 0 and 100, for non-NULL entries. Combine with NOT NULL when values must exist.

**DEFAULT** supplies a value when an insert omits that column (or uses DEFAULT).

Example:

```sql
grade NUMERIC(5,2) CHECK (grade BETWEEN 0 AND 100)
```

## 4. Auto-generated IDs

```sql
id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY
```

Unlike plain `INTEGER PRIMARY KEY`, PostgreSQL's identity declaration automatically generates ID values. `GENERATED ALWAYS` usually disallows explicitly supplied ID values without an override.

## 5. A More Carefully Designed Practice Table

**Never execute this example in the live ProTrack MX production project.** Use an isolated PostgreSQL database or separate Supabase testing project. Review permissions and Row Level Security before exposing any practice tables through an API.

```sql
CREATE TABLE public.lesson02_students_demo (
    id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name TEXT NOT NULL,
    age INTEGER CHECK (age BETWEEN 1 AND 120),
    grade NUMERIC(5,2) CHECK (grade BETWEEN 0 AND 100),
    active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMPTZ NOT NULL DEFAULT NOW()
);
```

This illustrates a **fictional** demo table. It is not a complete production security configuration.

### Expected Columns

| Column | Type | Rule |
| --- | --- | --- |
| id | INTEGER | Generated primary key |
| name | TEXT | Required (non-NULL) |
| age | INTEGER | If present, 1–120 |
| grade | NUMERIC(5,2) | If present, 0–100 |
| active | BOOLEAN | Required; defaults TRUE |
| created_at | TIMESTAMPTZ | Required; defaults to current timestamp |

## 6. INSERT INTO — Add One Student

```sql
INSERT INTO public.lesson02_students_demo (name, age, grade)
VALUES ('Ali', 15, 95);
```

The column list identifies the fields to fill. `VALUES` supplies matching values in exactly the same order. The database generates the ID and applies defaults for omitted columns.

## 7. Insert Several Students

```sql
INSERT INTO public.lesson02_students_demo (name, age, grade)
VALUES
    ('Sara', 14, 88),
    ('Reza', 16, 76),
    ('Ali', 15, 91.50);
```

This adds three distinct rows. Repeated names are allowed because names are not declared UNIQUE.

## 8. Check What Was Saved

```sql
SELECT id, name, age, grade
FROM public.lesson02_students_demo
ORDER BY id;
```

The ORDER BY clause sorts by ID. Generated IDs are not guaranteed to be consecutive after deletions or failed inserts.

## 9. Common Beginner Errors

### A. Strings without quotation marks

Wrong:
```sql
VALUES (Ali, 15, 95);
```

Correct:
```sql
VALUES ('Ali', 15, 95);
```

### B. Omitting a required name

If `name` is NOT NULL and has no default, an INSERT that does not supply it fails.

### C. Repeating a primary key

A duplicate primary-key value is rejected.

### D. Mixing column order and values

```sql
INSERT INTO public.lesson02_students_demo (name, age, grade)
VALUES ('Ali', 15, 95);
```

Each value must correspond to its named column.

### E. Assuming a successful INSERT means secure access

Database permissions and RLS must still be configured independently.

### F. Running examples in production

A CREATE TABLE or INSERT can modify a real database. Never run tutorial SQL against the production ProTrack MX project.

## 10. INSERT vs SELECT

| Command | Effect |
| --- | --- |
| CREATE TABLE | Creates a table |
| INSERT INTO | Adds row(s) |
| SELECT | Reads query results |

## 11. How This Applies to ProTrack MX

Real systems may model `students`, `teachers`, `classes`, `enrollments`, `assessments`, and `grades` in separate, related tables. ProTrack MX also needs configurable grading criteria and secure teacher-scoped access. This lesson does **not** prescribe its actual schema.

A teacher adds a student through the interface, the application sends an authorized request, PostgreSQL enforces constraints, and the record may be stored if validation and permissions pass.

## 12. Supabase Connection

Supabase supplies managed PostgreSQL, APIs, authentication, and other backend services. SQL statements inside Supabase SQL Editor run against the connected project. The SQL Editor may use elevated database permissions; successful execution is not proof that end-user API access is safe.

For development, create an **independent test project** with fake data. Do not publish passwords, database URLs with credentials, secret/service-role keys, or student records to a public repository.

## 13. Guided Exercises

1. Explain what CREATE TABLE accomplishes.
2. Choose a data type for a student's name, age, and decimal grade.
3. Explain the difference between PRIMARY KEY and NOT NULL.
4. Predict what happens when a grade of 125 is inserted into the practice table.
5. Write an INSERT for a fictional student named Mina, age 15, grade 92.5.
6. Write a SELECT that shows only names and grades.
7. Explain why the practice table must not be created in the production project.

Study the [10 class questions](./QUESTIONS.md) and consult the [answer key](./ANSWERS.md) only after attempting them.

## 14. Quick Reference

```sql
-- Create a table (in a SAFE, isolated testing database only)
CREATE TABLE public.lesson02_students_demo (
    id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name TEXT NOT NULL,
    age INTEGER,
    grade NUMERIC(5,2)
);

-- Add a row
INSERT INTO public.lesson02_students_demo (name, age, grade)
VALUES ('Mina', 15, 92.50);

-- Read data
SELECT name, grade
FROM public.lesson02_students_demo;
```

## 15. Summary and Next Class

In Class 02 we learned CREATE TABLE, PostgreSQL data types, constraints, automatically generated IDs, INSERT INTO, and SELECT verification.

**Next:** Class 03 — Filtering and Sorting with WHERE, ORDER BY, and LIMIT (only after the learner completes Class 02).

## Official References

- [PostgreSQL — Creating a New Table](https://www.postgresql.org/docs/current/tutorial-table.html)
- [PostgreSQL — Populating a Table](https://www.postgresql.org/docs/current/tutorial-populate.html)
- [PostgreSQL — Data Types](https://www.postgresql.org/docs/current/datatype.html)
- [PostgreSQL — Constraints](https://www.postgresql.org/docs/current/ddl-constraints.html)
- [Supabase Database Docs](https://supabase.com/docs/guides/database)
- [Supabase Row Level Security](https://supabase.com/docs/guides/database/postgres/row-level-security)
