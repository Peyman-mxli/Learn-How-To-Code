# Class 31 — SQL Operators, Expressions, and CASE

[Course roadmap](../README.md) · [Practice questions](./QUESTIONS.md) · [Answer key](./ANSWERS.md)

## Objective

Explain the commands and symbols in simple English, predict their behavior, understand mistakes, and transfer the ideas to a fictional ProTrack MX learning environment. Prerequisites: previous classes.

## 1. Setup / context

```sql
CREATE TABLE lab_results (id integer PRIMARY KEY, score integer, status text);
INSERT INTO lab_results VALUES (1,85,'active'),(2,NULL,'inactive'),(3,60,'active');
```

Use a separate, disposable development environment. Examples are instructional and are not verified against the production ProTrack MX schema.

## 2. Main example

```sql
SELECT id, score,
 CASE WHEN score IS NULL THEN 'missing'
      WHEN score >= 70 AND status = 'active' THEN 'passing'
      ELSE 'review' END AS result
FROM lab_results;
```

## 3. Explain every important keyword

| Keyword or phrase | English meaning and role |
|---|---|
| `SELECT` | Retrieve chosen expressions. |
| `CASE` | Begin conditional expression. |
| `WHEN` | Specify a condition. |
| `IS NULL` | Test for an absent SQL value. |
| `THEN` | Return a value when a condition matches. |
| `>=` | Greater than or equal to. |
| `AND` | Require both conditions. |
| `=` | Compare equality in a predicate. |
| `ELSE` | Provide fallback. |
| `END` | Finish CASE expression. |
| `AS` | Name the expression output. |
| `FROM` | Name input table. |

### Read the example in order

1. **SELECT:** Retrieve chosen expressions.
2. **CASE:** Begin conditional expression.
3. **WHEN:** Specify a condition.
4. **IS NULL:** Test for an absent SQL value.
5. **THEN:** Return a value when a condition matches.
6. **>=:** Greater than or equal to.
7. **AND:** Require both conditions.
8. **=:** Compare equality in a predicate.
9. **ELSE:** Provide fallback.
10. **END:** Finish CASE expression.
11. **AS:** Name the expression output.
12. **FROM:** Name input table.

## 4. Additional example

```sql
SELECT id FROM lab_results
WHERE status IN ('active','pending')
  AND score BETWEEN 60 AND 100;
SELECT id FROM lab_results WHERE status ILIKE 'act%';
```

Explain how this second example differs, why it matters, and any expected result or error. A code sample is not an instruction to run it against live data.

## 5. ProTrack MX applied scenario

Assume fictional teachers, students, evaluation criteria, and academic periods. Describe how the new concept helps build a reliable and privacy-preserving educational backend. Identify what user authorization checks and validations should happen before using real data.

## 6. Common mistakes and important caveats

SQL has three-valued Boolean logic: TRUE, FALSE, UNKNOWN. Conditions involving NULL require care; CASE is not a replacement for constraints or authorization.

Never commit passwords, access tokens, secret keys, or real student records to a public repository. Prefer test accounts and a separate Supabase development project.

## 7. Ten review exercises

1. What does CASE do?
2. What is the meaning of WHEN?
3. What does THEN provide?
4. What is ELSE?
5. What does IS NULL test?
6. Why is = NULL incorrect?
7. What is BETWEEN?
8. What is IN?
9. What does ILIKE do?
10. What does >= mean?

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
