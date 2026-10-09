# Class 20 — Testing, Deployment, and the ProTrack MX Capstone

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Goals

By the end of this class you should be able to explain the whole example word by word, describe the use case, identify its risks, and respond to ten checks without looking up the answers.

## 1. Setup and Assumptions

The capstone uses fictional test teachers, classes, students and weighted grading criteria. Treat production as out of scope until all migrations, access tests and privacy controls pass review.

## 2. Worked Example

```sql
BEGIN;
INSERT INTO lab_categories(id, label, weight) VALUES (2,'Homework',30);
SELECT id, label, weight FROM lab_categories WHERE id = 2;
ROLLBACK;
```

### Every Important Part Explained

| Part | Meaning |
|---|---|
| `BEGIN` | Open a PostgreSQL transaction. |
| `INSERT INTO` | Add a row to the named table. |
| `lab_categories` | A fictional table from Class 14. |
| `VALUES` | Supply values in column order. |
| `SELECT` | Inspect matching rows. |
| `WHERE id = 2` | Read the specific test row. |
| `ROLLBACK` | Undo changes made in this transaction. |
| `;` | Terminate each SQL statement. |

### Step-by-step reading

1. **BEGIN:** Open a PostgreSQL transaction.
2. **INSERT INTO:** Add a row to the named table.
3. **lab_categories:** A fictional table from Class 14.
4. **VALUES:** Supply values in column order.
5. **SELECT:** Inspect matching rows.
6. **WHERE id = 2:** Read the specific test row.
7. **ROLLBACK:** Undo changes made in this transaction.
8. **;:** Terminate each SQL statement.

## 3. Related Example

```sql
-- An example of a simple automated assertion in SQL using a SELECT:
SELECT COUNT(*) = 0 AS no_negative_weights
FROM lab_categories
WHERE weight < 0;

-- For a secure app, test under normal teacher accounts
-- that one teacher cannot read another teacher's classes.
```

Read the comments and explain why the additional statement matters. Do not confuse an event, callback, or SQL command with a security guarantee.

## 4. ProTrack MX Scenario

Imagine an educator signing in to check class data, submit assessments and review trimester grades. Only the teacher's authorized records should be accessible. Avoid committing secrets or any real student data; use independent test users and simulated classes.

## 5. Important Security and Operational Warnings

This testing pattern is designed for an isolated database. Never assume rollback reverses sequence increments or external side effects. Deployment requires review of backups, secret management, schema migrations, grants, RLS, logs and recovery plans.

## 6. Practice Exercises

1. What is a unit test?
2. What is an integration test?
3. What is a negative authorization test?
4. What does BEGIN do?
5. What does ROLLBACK do?
6. Do sequences necessarily roll back?
7. Why test two teacher accounts?
8. Why use migrations?
9. What is a deployment checklist?
10. What defines capstone completion?

Use the separate [QUESTIONS.md](./QUESTIONS.md) and wait until after answering before reviewing [ANSWERS.md](./ANSWERS.md).

## 7. Final Checklist

- [ ] I understand each keyword and example.
- [ ] I know what is and is not guaranteed.
- [ ] I understand the security checks and possible failures.
- [ ] I completed the ten practice questions.

## Official Documentation

- [Supabase Documentation](https://supabase.com/docs)
- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Realtime](https://supabase.com/docs/guides/realtime)
- [Supabase Edge Functions](https://supabase.com/docs/guides/functions)
