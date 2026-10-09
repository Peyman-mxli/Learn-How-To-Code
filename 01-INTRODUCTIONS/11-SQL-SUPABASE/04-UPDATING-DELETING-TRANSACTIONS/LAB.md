# Practical Lab — Safe UPDATE and ROLLBACK

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
CREATE TEMP TABLE lab_edit (id int PRIMARY KEY,grade int);
INSERT INTO lab_edit VALUES(1,70),(2,80);
BEGIN;
UPDATE lab_edit SET grade=90 WHERE id=1;
SELECT * FROM lab_edit ORDER BY id;
ROLLBACK;
```

**Expected result:** Inside the transaction, grades are 90 and 80; ROLLBACK undoes the update.

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
SELECT * FROM lab_edit ORDER BY id;
```

**Expected result:** After ROLLBACK, grades are 70 and 80.

## Step 3 — Troubleshooting Challenge

Inspect DELETE FROM lab_edit; without executing it.

**Expected diagnosis:** Without WHERE it would remove all rows, not just one.

## Step 4 — Think Like a ProTrack MX Developer

Why is a pre-change SELECT valuable?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
