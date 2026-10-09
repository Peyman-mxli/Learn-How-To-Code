# Class 34 — Automated SQL, Constraint, and RLS Tests

[Course roadmap](../README.md) · [Practice questions](./QUESTIONS.md) · [Answer key](./ANSWERS.md)

## Objective

Explain the commands and symbols in simple English, predict their behavior, understand mistakes, and transfer the ideas to a fictional ProTrack MX learning environment. Prerequisites: previous classes.

## 1. Setup / context

```sql
CREATE TABLE lab_test_weights (id int PRIMARY KEY, weight numeric NOT NULL CHECK (weight BETWEEN 0 AND 100));
```

Use a separate, disposable development environment. Examples are instructional and are not verified against the production ProTrack MX schema.

## 2. Main example

```sql
BEGIN;
INSERT INTO lab_test_weights(id,weight) VALUES (1,50);
SELECT CASE WHEN COUNT(*) = 1 THEN 'PASS' ELSE 'FAIL' END AS result
FROM lab_test_weights WHERE id = 1;
ROLLBACK;
```

## 3. Explain every important keyword

| Keyword or phrase | English meaning and role |
|---|---|
| `BEGIN` | Start transaction. |
| `INSERT INTO` | Add a row. |
| `SELECT` | Read a result. |
| `CASE WHEN` | Evaluate test condition. |
| `COUNT(*)` | Count matching rows. |
| `THEN` | Expected output for success. |
| `ELSE` | Output on failure. |
| `END AS result` | Name test result. |
| `ROLLBACK` | Undo test changes where transactional. |

### Read the example in order

1. **BEGIN:** Start transaction.
2. **INSERT INTO:** Add a row.
3. **SELECT:** Read a result.
4. **CASE WHEN:** Evaluate test condition.
5. **COUNT(*):** Count matching rows.
6. **THEN:** Expected output for success.
7. **ELSE:** Output on failure.
8. **END AS result:** Name test result.
9. **ROLLBACK:** Undo test changes where transactional.

## 4. Additional example

```sql
-- Negative case to test separately in a disposable DB:
INSERT INTO lab_test_weights(id,weight) VALUES (2,150);
-- Expected: CHECK constraint error.
-- A real test framework should assert this error.
```

Explain how this second example differs, why it matters, and any expected result or error. A code sample is not an instruction to run it against live data.

## 5. ProTrack MX applied scenario

Assume fictional teachers, students, evaluation criteria, and academic periods. Describe how the new concept helps build a reliable and privacy-preserving educational backend. Identify what user authorization checks and validations should happen before using real data.

## 6. Common mistakes and important caveats

A query that prints PASS is not an automated testing framework. Use actual assertions, realistic auth contexts, and failures that break CI; tests must not touch real student data.

Never commit passwords, access tokens, secret keys, or real student records to a public repository. Prefer test accounts and a separate Supabase development project.

## 7. Ten review exercises

1. What is an assertion?
2. What is a positive test?
3. What is a negative test?
4. What is a constraint test?
5. What is an RLS test?
6. Why test two users?
7. Why use transactions for tests?
8. Can rollback reverse sequence values?
9. What should be tested for weight validation?
10. Why include tests in CI?

Work through [QUESTIONS.md](./QUESTIONS.md) **one at a time**. Use [ANSWERS.md](./ANSWERS.md) to check your understanding, not to memorize blindly.

## 8. Completion checklist

- [ ] I can explain all important keywords.
- [ ] I can describe the main example in my own words.
- [ ] I can distinguish safe test use from production use.
- [ ] I can explain relevant mistakes and permission boundaries.
- [ ] I completed the ten questions.

## Authoritative references

- [PostgreSQL documentation](https://www.postgresql.org/docs/current/)
- [Supabase documentation](https://supabase.com/docs)
- [Supabase local development](https://supabase.com/docs/guides/local-development)
