# Practical Lab — Schema Design Review

[Main Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Safe environment:** Execute in an isolated development PostgreSQL environment only. All student/teacher identifiers must be fictional.

## Exercise 1 — Guided Example

```sql
CREATE TEMP TABLE lab_final_t(id int PRIMARY KEY,name text NOT NULL);
INSERT INTO lab_final_t VALUES(1,'Teacher A');
SELECT * FROM lab_final_t;
```

**Expected output:** One row with id 1 and name Teacher A.

## Exercise 2 — Short Question

**Q:** Is the single table a complete ProTrack MX schema?

**A:** No; it lacks class/student relationships, authorization, criteria, periods and grades.

## Exercise 3 — Troubleshooting

**Scenario:** Assume identifying a teacher by id gives access to all grades.

**Why this is wrong / how to fix it:** A caller-supplied id is not authorization; enforce ownership and roles with RLS.

## Exercise 4 — Teach It Back

Explain the verb, data source, expressions, constraints, options, return values, and risks from the example to a new learner. Predict one alternative result after changing an input in a test environment.

## Checklist

- [ ] Understood expected result.
- [ ] Can explain every keyword.
- [ ] Understood the failure scenario.
- [ ] Can connect it to a fictional ProTrack MX use case.

**Do not modify any production data or permissions as part of this lab.**
