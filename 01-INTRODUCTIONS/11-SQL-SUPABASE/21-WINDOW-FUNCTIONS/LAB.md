# Practical Lab — Rank With Ties

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
WITH scores(student_id,score) AS (VALUES (1,90),(2,90),(3,70))
SELECT student_id,score,RANK() OVER (ORDER BY score DESC) AS rank_value FROM scores ORDER BY student_id;
```

**Expected result/behavior:** Rank values are 1, 1, 3 for student IDs 1, 2, 3.

## Step 2 — Check your understanding

**Question:** What does DENSE_RANK return instead?

**Answer:** 1, 1, 2.

## Step 3 — Troubleshooting scenario

**Issue:** Assume ORDER BY inside OVER also guarantees final row display order.

**Diagnosis or correction:** No; an outer ORDER BY is required for deterministic presentation.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
