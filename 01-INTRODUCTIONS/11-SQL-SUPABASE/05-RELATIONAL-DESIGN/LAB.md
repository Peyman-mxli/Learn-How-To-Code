# Practical Lab — Foreign Keys

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Isolated PostgreSQL/Supabase *development* project only. Never run sample changes against the live ProTrack MX database. Use fictional data.

## Goal

Perform a small experiment, predict its output before running, and identify what would go wrong in a similar application.

## Step 1 — Execute and Explain

```sql
CREATE TEMP TABLE lab_parent (id int PRIMARY KEY);
CREATE TEMP TABLE lab_child (id int PRIMARY KEY, parent_id int REFERENCES lab_parent(id));
INSERT INTO lab_parent VALUES (10);
INSERT INTO lab_child VALUES (1,10);
```

**Expected result:** Parent row 10 and child row 1 referencing parent 10 are accepted.

**Explain:** Name each SQL keyword, the table or expression involved, and whether rows were read or changed.

## Step 2 — Change One Thing

```sql
SELECT c.id,c.parent_id FROM lab_child c JOIN lab_parent p ON c.parent_id=p.id;
```

**Expected result:** One row: (1,10).

## Step 3 — Troubleshooting Challenge

Try INSERT INTO lab_child VALUES (2,99);

**Expected diagnosis:** Foreign-key violation because parent 99 is absent.

## Step 4 — Think Like a ProTrack MX Developer

Why is a foreign key not a permission check?

## Verification Checklist

- [ ] I predicted the result before executing.
- [ ] I compared actual output with the expected result.
- [ ] I explained the error or unsafe scenario.
- [ ] I can describe how this concept affects an educational application.
- [ ] I used only a disposable learning environment.

**Note:** Temporary tables disappear at the end of the database session; run related statements using the same connection. SQL Editor sessions may vary, so rerun the setup when necessary.
