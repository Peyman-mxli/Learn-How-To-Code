# Class 14 — INSERT Conflicts, UPSERT, and RETURNING

[Course index](../README.md) · [Practice Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## What You Will Learn

Handle duplicate keys intentionally without replacing unrelated records.

**Prerequisites:** Classes 01–13. **Context:** fictional ProTrack MX test data; do not run these commands on the production database.

## 1. Start from a Clean Practice Environment

Run this setup only in an isolated development PostgreSQL database. It uses lab-prefixed tables to avoid interfering with real objects.

```sql
CREATE TABLE lab_categories (id integer PRIMARY KEY, label text NOT NULL, weight integer NOT NULL CHECK(weight BETWEEN 0 AND 100));
INSERT INTO lab_categories VALUES (1,'Exam',40);
```

Read the table names, column types, constraints, and sample row values before continuing. `CREATE TABLE` declares structure; `INSERT INTO` creates rows; `VALUES` introduces row contents; `;` ends the statement.

## 2. Core Example

```sql
INSERT INTO lab_categories (id, label, weight)
VALUES (1, 'Exam', 45)
ON CONFLICT (id) DO UPDATE
SET weight = EXCLUDED.weight
RETURNING id, label, weight;
```

## 3. Every Important SQL Phrase

| Phrase | Exact meaning |
|---|---|
| `INSERT INTO` | Insert into the named table. |
| `VALUES` | Provide row values. |
| `ON CONFLICT (id)` | Handle collision on a unique/primary-key arbiter. |
| `DO UPDATE` | Update a conflicting row rather than failing. |
| `SET` | Assign a new column value. |
| `EXCLUDED.weight` | Refer to the proposed inserted value. |
| `RETURNING` | Return columns of affected rows. |

### Walk Through It Line by Line

1. **INSERT INTO** — Insert into the named table.
2. **VALUES** — Provide row values.
3. **ON CONFLICT (id)** — Handle collision on a unique/primary-key arbiter.
4. **DO UPDATE** — Update a conflicting row rather than failing.
5. **SET** — Assign a new column value.
6. **EXCLUDED.weight** — Refer to the proposed inserted value.
7. **RETURNING** — Return columns of affected rows.

## 4. A Related Example

```sql
INSERT INTO lab_categories(id,label,weight)
VALUES (1,'Exam',45)
ON CONFLICT(id) DO NOTHING
RETURNING id;
-- DO NOTHING avoids an error and usually returns no row for skipped insert.
```

Compare this example to the previous statement. Notice what condition, clause, or result changed, and be ready to explain why.

## 5. Common Mistakes

UPSERT requires a suitable uniqueness arbiter. Conflict handling does not bypass CHECK, NOT NULL, permissions, or RLS. Choose carefully which columns may change.

Even a correct SQL query does not replace user permissions. Supabase API access requires appropriate database grants and row-level policies where applicable.

## 6. ProTrack MX Practice Scenario

Imagine a teacher working with fictional classes, assignment scores, and categories. Explain how the query would affect or summarize these records, and how you would protect real student data. The lab table design is intentionally simplified; it is not the actual ProTrack MX production schema.

## 7. Try These Ten Exercises

1. What is an UPSERT?
2. What does ON CONFLICT detect?
3. What does DO UPDATE mean?
4. What does EXCLUDED.weight represent?
5. What does RETURNING do?
6. What is DO NOTHING?
7. Does UPSERT ignore CHECK constraints?
8. Why specify conflict target?
9. What happens without ON CONFLICT on duplicate PK?
10. What security is needed?

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
