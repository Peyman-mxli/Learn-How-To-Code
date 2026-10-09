# Practical Lab — Backup Recovery Rehearsal

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute only on your local workstation with installed PostgreSQL CLI tools; do not connect to production. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```bash
pg_dump --version
pg_restore --version
```

**Expected output:** Print installed PostgreSQL CLI tool versions if they are installed.

## Exercise 2 — Short Question

**Q:** What makes a backup verified?

**A:** Successful restoration into an isolated environment plus integrity checks.

## Exercise 3 — Troubleshooting

**Scenario:** Restore a test dump into production without checking target.

**Why this is wrong / how to fix it:** This risks overwriting or mixing live data; confirm destination and rehearse separately.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
