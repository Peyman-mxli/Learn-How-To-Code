# Practical Lab — Validate Weight Totals

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
WITH weights(name,weight) AS (VALUES ('Homework',40::numeric),('Exam',60::numeric))
SELECT SUM(weight) AS total_weight, SUM(weight)=100 AS valid FROM weights;
```

**Expected output:** total_weight = 100 and valid = true.

## Exercise 2 — Short Question

**Q:** Does CHECK(weight BETWEEN 0 AND 100) guarantee totals of 100?

**A:** No; cross-row totals need separate validation.

## Exercise 3 — Troubleshooting

**Scenario:** Treat a missing grade as zero without defining policy.

**Why this is wrong / how to fix it:** Incorrect unless the grading policy explicitly defines missing scores that way.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
