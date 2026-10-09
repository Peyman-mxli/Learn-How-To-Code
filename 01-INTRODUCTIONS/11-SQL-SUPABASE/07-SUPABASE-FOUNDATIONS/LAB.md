# Practical Lab — SQL Editor versus API

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
SELECT current_database() AS db_name, current_user AS role_name;
```

**Expected result:** One row showing the current database and active database role; values depend on environment.

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
SELECT 2 * 5 AS example_result;
```

**Expected result:** example_result = 10.

## Step 3 — Troubleshooting Challenge

Compare privileges of SQL Editor with a normal signed-in client; do not change any policy.

**Expected diagnosis:** A privileged SQL Editor success does not establish normal user API access.

## Step 4 — Think Like a ProTrack MX Developer

Why should experiments occur in a development project?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
