# Practical Lab — Rollback a Test Transaction

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
CREATE TEMP TABLE lab_cap(id int PRIMARY KEY,label text);
BEGIN;
INSERT INTO lab_cap VALUES(1,'test');
SELECT COUNT(*) FROM lab_cap;
ROLLBACK;
SELECT COUNT(*) FROM lab_cap;
```

**Expected result/behavior:** Count 1 inside transaction and count 0 afterward.

## Step 2 — Check your understanding

**Question:** Why is a passing SQL query not enough to prove secure deployment?

**Answer:** You must test unauthorized access, migrations, recovery, configuration, and handling of errors.

## Step 3 — Troubleshooting scenario

**Issue:** A test script uses actual production student rows.

**Diagnosis or correction:** Unsafe: use fictional data and separate accounts.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
