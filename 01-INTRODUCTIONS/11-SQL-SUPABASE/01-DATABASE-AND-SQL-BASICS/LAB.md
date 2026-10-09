# Practical Lab — Reading a Student Roster

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
SELECT 1 AS student_count;
```

**Expected result:** One row and one column named student_count containing 1.

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
SELECT 2 + 3 AS total;
```

**Expected result:** One row where total = 5.

## Step 3 — Troubleshooting Challenge

Try SELECT missing_column; (without a FROM clause).

**Expected diagnosis:** PostgreSQL reports the column does not exist.

## Step 4 — Think Like a ProTrack MX Developer

Why can a SELECT expression return a result without a table?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
