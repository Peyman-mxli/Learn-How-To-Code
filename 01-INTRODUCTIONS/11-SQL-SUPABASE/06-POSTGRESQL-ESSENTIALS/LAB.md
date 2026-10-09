# Practical Lab — Data Constraints

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
CREATE TEMP TABLE lab_rule (id int PRIMARY KEY,weight numeric NOT NULL CHECK(weight BETWEEN 0 AND 100));
INSERT INTO lab_rule VALUES (1,50);
SELECT * FROM lab_rule;
```

**Expected result:** One row: (1,50).

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
INSERT INTO lab_rule VALUES(2,100);
SELECT COUNT(*) FROM lab_rule;
```

**Expected result:** Count is 2, since boundary 100 is allowed.

## Step 3 — Troubleshooting Challenge

Try INSERT INTO lab_rule VALUES(3,101);

**Expected diagnosis:** CHECK constraint violation.

## Step 4 — Think Like a ProTrack MX Developer

What is the difference between CHECK and NOT NULL?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
