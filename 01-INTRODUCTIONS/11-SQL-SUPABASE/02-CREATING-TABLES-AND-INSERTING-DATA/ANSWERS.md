# Class 02 — Answer Key and Explanations

**SQL & Supabase Learning Journey | ProTrack MX**

[Questions](./QUESTIONS.md) · [Class 02 Lesson](./README.md)

> Open after answering the ten questions. This is the reference key, **not a claim that the student has completed the quiz**.

| Question | Answer | Concept |
| --- | --- | --- |
| 01 | B | CREATE TABLE |
| 02 | C | TEXT |
| 03 | B | NUMERIC |
| 04 | A | PRIMARY KEY |
| 05 | C | NOT NULL |
| 06 | D | IDENTITY |
| 07 | B | INSERT INTO |
| 08 | C | CHECK |
| 09 | See SQL below | INSERT statement |
| 10 | See SQL below | SELECT statement |

## Question 01 — B

`CREATE TABLE students (...)` defines a new table, including specified columns and constraints. It does not read, insert, or delete records. The statement must have valid column definitions.

## Question 02 — C

`TEXT` stores character strings such as names. `INTEGER` holds whole numbers, `BOOLEAN` stores boolean values, and `DATE` stores calendar dates.

## Question 03 — B

`NUMERIC(5,2)` can store exact decimal values such as 92.75. `INTEGER` does not represent the fractional part; BOOLEAN and DATE have different purposes.

## Question 04 — A

A primary key enforces uniqueness and non-NULL identifiers. Student names need not be unique. Crucially, ordinary `INTEGER PRIMARY KEY` in PostgreSQL does **not** generate IDs by itself.

## Question 05 — C

`NOT NULL` prevents SQL NULL. It does not require uniqueness and does not automatically reject empty strings, which are distinct from NULL.

## Question 06 — D

```sql
id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY
```

This provides PostgreSQL-managed integer identity values while enforcing a primary key. The other choices do not create an automatically generated integer identity.

## Question 07 — B

```sql
INSERT INTO students (name, age, grade)
VALUES ('Ali', 15, 95);
```

INSERT adds a row; SELECT reads, CREATE TABLE defines a table, and UPDATE modifies existing rows.

## Question 08 — C

A grade of 125 violates `CHECK (grade BETWEEN 0 AND 100)`, so PostgreSQL rejects that INSERT. The constraint does not clamp values and does not delete the table.

## Question 09 — Sample Correct SQL

```sql
INSERT INTO students (name, age, grade)
VALUES ('Mina', 15, 92.50);
```

The column order matches its values. Names are strings in single quotes; numeric fields use numeric literals.

## Question 10 — Sample Correct SQL

```sql
SELECT name, grade FROM students;
```

This reads only the requested columns. Reversing them is valid if output order is not specified.

## Scoring

1 point per question, up to **10/10**. For Questions 09–10, award the point for semantically correct SQL, not merely identical formatting. The student’s score should be recorded **only after they actually answer these Class 02 questions**.

## Additional Notes

- `NOT NULL` differs from `UNIQUE`.
- `PRIMARY KEY` does not automatically generate IDs.
- `CHECK` verifies rules on values.
- Experimental database changes belong in a separate testing environment, **not ProTrack MX production**.

[Back to Questions](./QUESTIONS.md)
