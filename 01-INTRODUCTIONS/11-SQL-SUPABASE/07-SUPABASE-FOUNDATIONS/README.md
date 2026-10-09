# Class 07 — Supabase Foundations

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Distinguish a database, Supabase backend services, dashboard tools, projects, and environments. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
SELECT id, title FROM public.practice_assessments ORDER BY id;
```

**Plain-English summary:** Distinguish a database, Supabase backend services, dashboard tools, projects, and environments.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `SELECT` | Request records. |
| `id, title` | Choose two columns. |
| `FROM` | Introduce the table source. |
| `public` | PostgreSQL schema name. |
| `.` | Separates schema and table. |
| `practice_assessments` | Demo table. |
| `ORDER BY id` | Sort records by ID. |

### Read the query in order

1. **`SELECT`** — Request records.
2. **`id, title`** — Choose two columns.
3. **`FROM`** — Introduce the table source.
4. **`public`** — PostgreSQL schema name.
5. **`.`** — Separates schema and table.
6. **`practice_assessments`** — Demo table.
7. **`ORDER BY id`** — Sort records by ID.

## 4. A Second Example and More Syntax

```sql
-- Conceptual browser client example, NOT a production configuration:
const { data, error } = await supabase
  .from('practice_assessments')
  .select('id, title');

// Supabase JavaScript SDK: the .from() method picks a table,
// and .select() requests specified columns.
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

The SQL Editor frequently has elevated privileges; successful execution there does not prove a normal signed-in user can query via API. Use a separate dev project, configure grants and RLS, and never expose secret/service-role keys.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **SELECT**: Request records.
- **id, title**: Choose two columns.
- **FROM**: Introduce the table source.
- **public**: PostgreSQL schema name.
- **.**: Separates schema and table.
- **practice_assessments**: Demo table.
- **ORDER BY id**: Sort records by ID.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Define Supabase.
2. Name the database engine.
3. Explain SQL Editor.
4. Explain Table Editor.
5. Describe Auth.
6. Describe Storage.
7. Describe Realtime.
8. Explain the generated database API.
9. Differentiate anon/publishable and secret keys.
10. Explain why production is unsafe for exercises.

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