# Practical Lab — UTC and Local Time

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
SELECT TIMESTAMPTZ '2026-01-10 12:00:00+00' AT TIME ZONE 'America/Tijuana' AS local_clock;
```

**Expected result/behavior:** A timestamp representing the local wall-clock time at that instant, under installed zone rules.

## Step 2 — Check your understanding

**Question:** Why use a named zone rather than a fixed offset?

**Answer:** Named zones encode date-dependent rules.

## Step 3 — Troubleshooting scenario

**Issue:** Treat TIMESTAMP WITHOUT TIME ZONE as a globally unique instant.

**Diagnosis or correction:** It lacks the zone/offset context needed to identify an absolute instant.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
