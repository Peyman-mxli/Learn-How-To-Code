# Practical Lab — INSERT, INTO, VALUES and Identity

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
CREATE TEMP TABLE lab_people (id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY, name text NOT NULL);
INSERT INTO lab_people(name) VALUES ('Ali');
SELECT id,name FROM lab_people;
```

**Expected result:** One row: id = 1, name = Ali (fresh identity sequence).

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
INSERT INTO lab_people (name) VALUES ('Sara');
SELECT id,name FROM lab_people ORDER BY id;
```

**Expected result:** Two rows, IDs 1 and 2.

## Step 3 — Troubleshooting Challenge

Try INSERT INTO lab_people(id,name) VALUES(50,'Peyman');

**Expected diagnosis:** GENERATED ALWAYS normally rejects an explicit identity ID; study OVERRIDING SYSTEM VALUE before attempting an override.

## Step 4 — Think Like a ProTrack MX Developer

How does the role of INTO differ from VALUES?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
