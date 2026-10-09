# Practical Lab — Schema Change in a Transaction

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
CREATE TEMP TABLE lab_terms(id int PRIMARY KEY,title text NOT NULL);
BEGIN;
ALTER TABLE lab_terms ADD COLUMN starts_on date;
SELECT column_name FROM information_schema.columns WHERE table_name='lab_terms' ORDER BY ordinal_position;
ROLLBACK;
```

**Expected result/behavior:** The column list inside the transaction includes starts_on; after rollback it no longer exists.

## Step 2 — Check your understanding

**Question:** Why use a transaction for a reversible migration rehearsal?

**Answer:** It lets you inspect reversible schema changes before committing.

## Step 3 — Troubleshooting scenario

**Issue:** A migration adds NOT NULL to a column containing NULL values.

**Diagnosis or correction:** The change fails unless existing rows are cleaned or a suitable plan is applied.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
