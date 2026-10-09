# Practical Lab — SELECT and WHERE

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
CREATE TEMP TABLE lab_filter (id int,name text,score int);
INSERT INTO lab_filter VALUES(1,'Ali',85),(2,'Sara',70),(3,'Mina',95);
SELECT name FROM lab_filter WHERE score >= 80 ORDER BY score DESC;
```

**Expected result:** Two rows in this order: Mina, Ali.

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
SELECT name FROM lab_filter WHERE score < 80;
```

**Expected result:** Sara.

## Step 3 — Troubleshooting Challenge

Try SELECT name FROM lab_filter WHERE score = NULL;

**Expected diagnosis:** No matching rows; = NULL evaluates to UNKNOWN. Use IS NULL.

## Step 4 — Think Like a ProTrack MX Developer

Why should ORDER BY be included for a predictable result?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
