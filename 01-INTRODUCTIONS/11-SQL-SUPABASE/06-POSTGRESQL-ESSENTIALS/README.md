# Class 06 — PostgreSQL Essentials

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Understand constraints, indexes, schemas, aggregates, and safer queries. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
CREATE TABLE practice_assessments (id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY, title TEXT NOT NULL, weight NUMERIC(5,2) NOT NULL CHECK (weight >= 0 AND weight <= 100), active BOOLEAN NOT NULL DEFAULT TRUE);
```

**Plain-English summary:** Understand constraints, indexes, schemas, aggregates, and safer queries.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `CREATE TABLE` | Define a practice table. |
| `id` | Assessment identifier. |
| `GENERATED ALWAYS AS IDENTITY` | Automatically generate identifiers. |
| `PRIMARY KEY` | Require unique non-NULL IDs. |
| `title TEXT NOT NULL` | Require a non-NULL title. |
| `weight NUMERIC(5,2)` | Store a precise decimal weight. |
| `CHECK (...)` | Reject values violating the expression. |
| `AND` | Both lower and upper bounds must pass. |
| `DEFAULT TRUE` | Use TRUE when active is omitted. |
| `;` | End statement. |

### Read the query in order

1. **`CREATE TABLE`** — Define a practice table.
2. **`id`** — Assessment identifier.
3. **`GENERATED ALWAYS AS IDENTITY`** — Automatically generate identifiers.
4. **`PRIMARY KEY`** — Require unique non-NULL IDs.
5. **`title TEXT NOT NULL`** — Require a non-NULL title.
6. **`weight NUMERIC(5,2)`** — Store a precise decimal weight.
7. **`CHECK (...)`** — Reject values violating the expression.
8. **`AND`** — Both lower and upper bounds must pass.
9. **`DEFAULT TRUE`** — Use TRUE when active is omitted.
10. **`;`** — End statement.

## 4. A Second Example and More Syntax

```sql
CREATE INDEX demo_assessments_title_idx ON practice_assessments (title);
SELECT COUNT(*) AS total, AVG(weight) AS average_weight FROM practice_assessments;
SELECT * FROM public.practice_assessments;
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

INDEX improves selected query patterns, not all workloads; it also costs writes/storage. CHECK accepts UNKNOWN for NULL unless paired with NOT NULL. public is a schema, not a guarantee of public read access.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **CREATE TABLE**: Define a practice table.
- **id**: Assessment identifier.
- **GENERATED ALWAYS AS IDENTITY**: Automatically generate identifiers.
- **PRIMARY KEY**: Require unique non-NULL IDs.
- **title TEXT NOT NULL**: Require a non-NULL title.
- **weight NUMERIC(5,2)**: Store a precise decimal weight.
- **CHECK (...)**: Reject values violating the expression.
- **AND**: Both lower and upper bounds must pass.
- **DEFAULT TRUE**: Use TRUE when active is omitted.
- **;**: End statement.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Explain PostgreSQL schema.
2. Explain NOT NULL.
3. Explain UNIQUE.
4. Explain CHECK.
5. Explain DEFAULT.
6. Explain NUMERIC(5,2).
7. Explain an index.
8. Explain index tradeoffs.
9. Explain COUNT and AVG.
10. Explain why constraints cannot replace authorization.

Answer one question at a time. The separate [QUESTIONS.md](./QUESTIONS.md) provides a printable set, and [ANSWERS.md](./ANSWERS.md) provides explanations for self-review.

## 10. Lesson Completion Checklist

- [ ] I can explain every keyword in the worked example.
- [ ] I can describe what the query changes or returns.
- [ ] I understand the limitations of the example.
- [ ] I can identify the risks of running it in production.
- [ ] I have attempted all ten questions before reading answers.

## 11. References

- [PostgreSQL SQL Documentation](https://www.postgresql.org/docs/current/sql.html)
- [PostgreSQL Tutorial](https://www.postgresql.org/docs/current/tutorial.html)
- [Supabase Documentation](https://supabase.com/docs)
- [Supabase Row Level Security](https://supabase.com/docs/guides/database/postgres/row-level-security)

**Course sequencing:** Continue to the next numbered class only when this lesson is understood.