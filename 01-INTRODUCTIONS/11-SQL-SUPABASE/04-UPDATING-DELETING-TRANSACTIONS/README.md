# Class 04 — Updating, Deleting, and Transactions

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Modify data deliberately and recover safely from mistakes using transactions. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
UPDATE practice_students SET grade = 91 WHERE id = 3;
```

**Plain-English summary:** Modify data deliberately and recover safely from mistakes using transactions.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `UPDATE` | Modify existing row(s). |
| `practice_students` | Target table. |
| `SET` | Specify new column values. |
| `grade = 91` | Assign 91 to the grade column. |
| `WHERE` | Restrict affected rows. |
| `id = 3` | Target the row with ID 3. |
| `;` | End the statement. |

### Read the query in order

1. **`UPDATE`** — Modify existing row(s).
2. **`practice_students`** — Target table.
3. **`SET`** — Specify new column values.
4. **`grade = 91`** — Assign 91 to the grade column.
5. **`WHERE`** — Restrict affected rows.
6. **`id = 3`** — Target the row with ID 3.
7. **`;`** — End the statement.

## 4. A Second Example and More Syntax

```sql
DELETE FROM practice_students WHERE id = 3;

BEGIN;
UPDATE practice_students SET grade = 91 WHERE id = 3;
SELECT id, grade FROM practice_students WHERE id = 3;
ROLLBACK;

-- COMMIT would make a transaction's changes permanent.
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

Omitting WHERE from UPDATE or DELETE can affect all rows. A transaction is not a replacement for a backup or authorization. SELECT beforehand, scope changes, and test in a sandbox.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **UPDATE**: Modify existing row(s).
- **practice_students**: Target table.
- **SET**: Specify new column values.
- **grade = 91**: Assign 91 to the grade column.
- **WHERE**: Restrict affected rows.
- **id = 3**: Target the row with ID 3.
- **;**: End the statement.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Define UPDATE.
2. Define SET.
3. Explain the WHERE clause.
4. Write a safe single-row update.
5. Define DELETE.
6. Describe DELETE without WHERE.
7. Explain BEGIN.
8. Explain COMMIT.
9. Explain ROLLBACK.
10. Describe how to test a change in a transaction.

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