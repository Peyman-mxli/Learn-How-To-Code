# Practical Lab — CASE and NULL

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Disposable PostgreSQL dev connection. Never use the production ProTrack MX project or real student data.

## 1. Practical Demonstration

```sql
WITH grades(score) AS (VALUES (80),(NULL::integer),(60)) SELECT score, CASE WHEN score IS NULL THEN 'missing' WHEN score>=70 THEN 'pass' ELSE 'review' END AS status FROM grades;
```

**Expected result:** 80 = pass, NULL = missing, 60 = review.

## 2. One-at-a-Time Question

**Question:** Why put IS NULL before score >= 70?

**Answer:** A comparison to NULL returns UNKNOWN; CASE needs an explicit branch.

## 3. Troubleshooting Exercise

**Mistake:** Replace IS NULL with = NULL.

**Correct reasoning:** The branch does not match NULL; use IS NULL.

## 4. Make It Your Own

Explain what each keyword or method does, what assumptions the example relies on, how a user would see the outcome in ProTrack MX, and what would happen with unauthorized data.

## Lab Completion

- [ ] Predicted outcome before running.
- [ ] Understood all statements, expressions and symbols.
- [ ] Diagnosed the mistake.
- [ ] Identified data privacy and permission requirements.
