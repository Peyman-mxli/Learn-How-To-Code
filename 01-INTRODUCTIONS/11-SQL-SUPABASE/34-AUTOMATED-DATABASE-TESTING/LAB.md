# Practical Lab — Positive and Negative Tests

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Disposable PostgreSQL dev connection. Never use the production ProTrack MX project or real student data.

## 1. Practical Demonstration

```sql
CREATE TEMP TABLE lab_assert(id int PRIMARY KEY,weight int NOT NULL CHECK(weight BETWEEN 0 AND 100));
INSERT INTO lab_assert VALUES(1,20);
SELECT COUNT(*)=1 AS expected_count FROM lab_assert;
```

**Expected result:** Boolean true for expected_count.

## 2. One-at-a-Time Question

**Question:** Why test weight=101 separately?

**Answer:** It should fail CHECK and verifies rejection of invalid input.

## 3. Troubleshooting Exercise

**Mistake:** Call SELECT true a complete automated test suite.

**Correct reasoning:** Not enough; assertions must fail CI when expectations are violated, including auth/RLS denial tests.

## 4. Make It Your Own

Explain what each keyword or method does, what assumptions the example relies on, how a user would see the outcome in ProTrack MX, and what would happen with unauthorized data.

## Lab Completion

- [ ] Predicted outcome before running.
- [ ] Understood all statements, expressions and symbols.
- [ ] Diagnosed the mistake.
- [ ] Identified data privacy and permission requirements.
