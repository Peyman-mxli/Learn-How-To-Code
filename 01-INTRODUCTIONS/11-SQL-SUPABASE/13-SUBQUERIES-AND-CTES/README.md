# Class 13 — Subqueries and Common Table Expressions

[Course index](../README.md) · [Practice Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## What You Will Learn

Build a query from smaller named query parts.

**Prerequisites:** Classes 01–12. **Context:** fictional ProTrack MX test data; do not run these commands on the production database.

## 1. Start from a Clean Practice Environment

Run this setup only in an isolated development PostgreSQL database. It uses lab-prefixed tables to avoid interfering with real objects.

```sql
CREATE TABLE lab_students (id integer PRIMARY KEY, name text NOT NULL, score integer);
INSERT INTO lab_students VALUES (1,'Ali',80),(2,'Sara',90),(3,'Carlos',70);
```

Read the table names, column types, constraints, and sample row values before continuing. `CREATE TABLE` declares structure; `INSERT INTO` creates rows; `VALUES` introduces row contents; `;` ends the statement.

## 2. Core Example

```sql
WITH average_result AS (
  SELECT AVG(score) AS avg_score FROM lab_students
)
SELECT s.name, s.score
FROM lab_students AS s
CROSS JOIN average_result AS a
WHERE s.score > a.avg_score;
```

## 3. Every Important SQL Phrase

| Phrase | Exact meaning |
|---|---|
| `WITH` | Introduce a common table expression (CTE). |
| `average_result` | Temporary name usable in this statement. |
| `AS ( ... )` | Associate that name with a subquery. |
| `AVG(score)` | Compute the average. |
| `SELECT` | Choose result columns. |
| `FROM lab_students AS s` | Read students with alias s. |
| `CROSS JOIN` | Combine each student with the single average row. |
| `WHERE` | Filter rows. |
| `s.score > a.avg_score` | Keep students above the calculated average. |

### Walk Through It Line by Line

1. **WITH** — Introduce a common table expression (CTE).
2. **average_result** — Temporary name usable in this statement.
3. **AS ( ... )** — Associate that name with a subquery.
4. **AVG(score)** — Compute the average.
5. **SELECT** — Choose result columns.
6. **FROM lab_students AS s** — Read students with alias s.
7. **CROSS JOIN** — Combine each student with the single average row.
8. **WHERE** — Filter rows.
9. **s.score > a.avg_score** — Keep students above the calculated average.

## 4. A Related Example

```sql
SELECT name FROM lab_students
WHERE score > (SELECT AVG(score) FROM lab_students);
-- Equivalent logical goal using a scalar subquery.
```

Compare this example to the previous statement. Notice what condition, clause, or result changed, and be ready to explain why.

## 5. Common Mistakes

A CTE exists only for its SQL statement. Do not assume it always speeds up a query; inspect the plan and indexes when performance matters.

Even a correct SQL query does not replace user permissions. Supabase API access requires appropriate database grants and row-level policies where applicable.

## 6. ProTrack MX Practice Scenario

Imagine a teacher working with fictional classes, assignment scores, and categories. Explain how the query would affect or summarize these records, and how you would protect real student data. The lab table design is intentionally simplified; it is not the actual ProTrack MX production schema.

## 7. Try These Ten Exercises

1. What is a subquery?
2. What does WITH mean here?
3. What is a CTE?
4. How long does a CTE name exist?
5. What does AVG do?
6. Why CROSS JOIN with a one-row CTE?
7. What is a scalar subquery?
8. Why use an alias?
9. Is a CTE always faster?
10. Does a CTE bypass RLS?

Use [QUESTIONS.md](./QUESTIONS.md) to answer **one question at a time**, then check [ANSWERS.md](./ANSWERS.md).

## 8. Completion Checklist

- [ ] I can define every keyword in the main query.
- [ ] I can describe its result or effect on the sample rows.
- [ ] I can compare the main and related examples.
- [ ] I understand the caveats and permissions involved.
- [ ] I have answered all ten questions before seeing their answers.

## Reference Documentation

- [PostgreSQL SQL Language](https://www.postgresql.org/docs/current/sql.html)
- [PostgreSQL Tutorial](https://www.postgresql.org/docs/current/tutorial.html)
- [Supabase Database Docs](https://supabase.com/docs/guides/database)
