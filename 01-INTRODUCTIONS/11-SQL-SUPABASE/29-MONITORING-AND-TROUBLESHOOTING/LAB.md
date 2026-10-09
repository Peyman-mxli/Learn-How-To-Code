# Practical Lab — Safe Explain Plan

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
EXPLAIN SELECT 1 AS constant_value;
```

**Expected output:** A PostgreSQL plan for a constant expression (usually Result), with estimates.

## Exercise 2 — Short Question

**Q:** Does EXPLAIN ANALYZE execute the SQL statement?

**A:** Yes; it measures actual execution.

## Exercise 3 — Troubleshooting

**Scenario:** Use EXPLAIN ANALYZE on DELETE from a live table.

**Why this is wrong / how to fix it:** It executes the DELETE; this is destructive and unsafe.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
