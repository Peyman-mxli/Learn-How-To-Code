# Practical Lab — Read Database Grants

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
SELECT grantee, privilege_type FROM information_schema.role_table_grants WHERE table_schema='public' LIMIT 10;
```

**Expected output:** Up to 10 grant records; the exact rows depend on connected database permissions.

## Exercise 2 — Short Question

**Q:** Does a role grant alone prove per-row access?

**A:** No; RLS and other effective privileges matter.

## Exercise 3 — Troubleshooting

**Scenario:** Use SQL Editor superuser test as the only RLS check.

**Why this is wrong / how to fix it:** Not sufficient; test with real low-privilege authenticated user contexts.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
