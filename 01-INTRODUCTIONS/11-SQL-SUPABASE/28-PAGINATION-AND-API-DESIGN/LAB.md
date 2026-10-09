# Practical Lab — Keyset Pagination

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
WITH classes(id,title) AS (VALUES (1,'Math'),(2,'Physics'),(3,'History')) SELECT * FROM classes WHERE id>1 ORDER BY id LIMIT 2;
```

**Expected output:** Rows: (2,Physics), (3,History), ordered by ID.

## Exercise 2 — Short Question

**Q:** What is the cursor here?

**A:** The last received id, here conceptually 1.

## Exercise 3 — Troubleshooting

**Scenario:** Use LIMIT without ORDER BY for repeatable paging.

**Why this is wrong / how to fix it:** Row order is not guaranteed; add deterministic ordering.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
