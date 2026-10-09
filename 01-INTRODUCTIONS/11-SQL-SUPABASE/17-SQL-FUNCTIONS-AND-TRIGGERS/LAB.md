# Practical Lab — Create a SQL Function

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
CREATE FUNCTION pg_temp.lab_double(x integer) RETURNS integer LANGUAGE sql AS $$ SELECT x*2 $$;
SELECT pg_temp.lab_double(7) AS doubled;
```

**Expected result/behavior:** doubled = 14; the pg_temp schema limits the function to the session.

## Step 2 — Check your understanding

**Question:** Why declare RETURNS integer?

**Answer:** It tells PostgreSQL the function's output type.

## Step 3 — Troubleshooting scenario

**Issue:** A function marked SECURITY DEFINER accesses private tables without reviewing privileges.

**Diagnosis or correction:** Potential privilege escalation: examine ownership, controlled search_path and access restrictions.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
