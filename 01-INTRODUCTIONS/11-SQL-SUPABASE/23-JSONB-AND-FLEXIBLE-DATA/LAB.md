# Practical Lab — Read JSONB Fields

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
SELECT ('{"theme":"dark","notify":true}'::jsonb)->>'theme' AS theme;
```

**Expected output:** One row with theme = dark.

## Exercise 2 — Short Question

**Q:** What does ->> do?

**A:** Extracts a JSON value as SQL text.

## Exercise 3 — Troubleshooting

**Scenario:** Extracting a missing property always raises an error.

**Why this is wrong / how to fix it:** Typically it returns NULL for an absent key.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
