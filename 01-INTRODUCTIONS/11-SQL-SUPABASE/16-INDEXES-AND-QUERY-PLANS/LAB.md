# Practical Lab — Read a Query Plan

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Use a disposable PostgreSQL test connection; SQL may need appropriate temporary-object privileges.

## Step 1 — Core exercise

```sql
CREATE TEMP TABLE lab_perf(id int PRIMARY KEY, class_id int NOT NULL);
INSERT INTO lab_perf VALUES(1,10),(2,10),(3,20);
CREATE INDEX lab_perf_class_idx ON lab_perf(class_id);
EXPLAIN SELECT * FROM lab_perf WHERE class_id=10;
```

**Expected result/behavior:** A plan is printed; PostgreSQL may choose a sequential scan for this very small table.

## Step 2 — Check your understanding

**Question:** Why might PostgreSQL ignore an index on a tiny table?

**Answer:** Scanning a tiny relation can cost less than using the index.

## Step 3 — Troubleshooting scenario

**Issue:** Assume EXPLAIN ANALYZE on DELETE is harmless.

**Diagnosis or correction:** False; ANALYZE executes the operation, so never casually run it on writes.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
