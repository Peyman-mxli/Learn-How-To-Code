# Practical Lab — Atomic Guarded Update

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
CREATE TEMP TABLE lab_seats(id int PRIMARY KEY,available int CHECK(available>=0));
INSERT INTO lab_seats VALUES(1,1);
UPDATE lab_seats SET available=available-1 WHERE id=1 AND available>0 RETURNING available;
UPDATE lab_seats SET available=available-1 WHERE id=1 AND available>0 RETURNING available;
```

**Expected output:** First UPDATE returns available = 0; second UPDATE affects zero rows.

## Exercise 2 — Short Question

**Q:** Why use available>0?

**A:** It prevents a decrement when no seats remain.

## Exercise 3 — Troubleshooting

**Scenario:** Read availability, then write based on an old value without proper concurrency control.

**Why this is wrong / how to fix it:** Concurrent requests can race; use guarded statements and/or locking.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
