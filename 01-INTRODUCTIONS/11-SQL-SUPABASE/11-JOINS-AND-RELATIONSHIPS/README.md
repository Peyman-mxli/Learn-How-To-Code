# Class 11 — JOINs and Reading Related Tables

[Course index](../README.md) · [Practice Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## What You Will Learn

Read connected tables instead of duplicating teacher names inside class records.

**Prerequisites:** Classes 01–10. **Context:** fictional ProTrack MX test data; do not run these commands on the production database.

## 1. Start from a Clean Practice Environment

Run this setup only in an isolated development PostgreSQL database. It uses lab-prefixed tables to avoid interfering with real objects.

```sql
CREATE TABLE lab_teachers (id integer PRIMARY KEY, name text NOT NULL);
CREATE TABLE lab_classes (id integer PRIMARY KEY, teacher_id integer REFERENCES lab_teachers(id), title text NOT NULL);
INSERT INTO lab_teachers (id,name) VALUES (1,'Ali'),(2,'Sara');
INSERT INTO lab_classes (id,teacher_id,title) VALUES (10,1,'Math'),(11,1,'Physics');
```

Read the table names, column types, constraints, and sample row values before continuing. `CREATE TABLE` declares structure; `INSERT INTO` creates rows; `VALUES` introduces row contents; `;` ends the statement.

## 2. Core Example

```sql
SELECT c.title, t.name AS teacher_name
FROM lab_classes AS c
INNER JOIN lab_teachers AS t ON c.teacher_id = t.id
ORDER BY c.title;
```

## 3. Every Important SQL Phrase

| Phrase | Exact meaning |
|---|---|
| `SELECT` | Choose output columns. |
| `c.title` | title column from classes alias c. |
| `t.name` | name column from teachers alias t. |
| `AS teacher_name` | Rename an output column. |
| `FROM` | Introduce the left/source table. |
| `AS c` | Short alias for lab_classes. |
| `INNER JOIN` | Match rows appearing in both relations. |
| `ON` | State how the two tables relate. |
| `c.teacher_id = t.id` | Match class foreign key to teacher primary key. |
| `ORDER BY` | Control display ordering. |

### Walk Through It Line by Line

1. **SELECT** — Choose output columns.
2. **c.title** — title column from classes alias c.
3. **t.name** — name column from teachers alias t.
4. **AS teacher_name** — Rename an output column.
5. **FROM** — Introduce the left/source table.
6. **AS c** — Short alias for lab_classes.
7. **INNER JOIN** — Match rows appearing in both relations.
8. **ON** — State how the two tables relate.
9. **c.teacher_id = t.id** — Match class foreign key to teacher primary key.
10. **ORDER BY** — Control display ordering.

## 4. A Related Example

```sql
SELECT t.name, c.title
FROM lab_teachers AS t
LEFT JOIN lab_classes AS c ON c.teacher_id = t.id;
-- LEFT JOIN preserves teachers without classes, showing NULL for title.
```

Compare this example to the previous statement. Notice what condition, clause, or result changed, and be ready to explain why.

## 5. Common Mistakes

A JOIN does not grant permission to read both tables. Query privileges and RLS must protect each table. Missing ON or bad join conditions can multiply rows.

Even a correct SQL query does not replace user permissions. Supabase API access requires appropriate database grants and row-level policies where applicable.

## 6. ProTrack MX Practice Scenario

Imagine a teacher working with fictional classes, assignment scores, and categories. Explain how the query would affect or summarize these records, and how you would protect real student data. The lab table design is intentionally simplified; it is not the actual ProTrack MX production schema.

## 7. Try These Ten Exercises

1. Why do we use JOIN?
2. What does INNER JOIN return?
3. What does LEFT JOIN return?
4. What does ON mean?
5. Why use aliases c and t?
6. What is a foreign key?
7. Why can a join return multiple rows?
8. What happens if a LEFT JOIN has no matching row?
9. What does AS teacher_name do?
10. What security applies to joined records?

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
