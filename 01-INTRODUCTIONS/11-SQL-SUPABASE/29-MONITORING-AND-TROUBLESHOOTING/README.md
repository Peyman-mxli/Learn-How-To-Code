# Class 29 — Monitoring, Errors, and Troubleshooting

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Objectives

Use everything learned in SQL, PostgreSQL, and Supabase to read code accurately, explain its purpose, anticipate errors and review secure educational application design.

## 1. Main example (isolated test environment only)

```sql
SELECT pid, state, wait_event_type, query
FROM pg_stat_activity
WHERE datname = current_database();
```

## 2. Explain every important phrase

| Expression | Explanation |
|---|---|
| `pg_stat_activity` | PostgreSQL view describing server processes and current activity. |
| `pid` | Server process identifier. |
| `state` | Backend state, such as active or idle. |
| `wait_event_type` | Category of any currently reported wait. |
| `query` | Recently active statement text, visibility subject to permissions. |
| `current_database()` | Name of the current connection's database. |
| `WHERE` | Filter to current database. |

### Step-by-step explanation

1. **pg_stat_activity:** PostgreSQL view describing server processes and current activity.
2. **pid:** Server process identifier.
3. **state:** Backend state, such as active or idle.
4. **wait_event_type:** Category of any currently reported wait.
5. **query:** Recently active statement text, visibility subject to permissions.
6. **current_database():** Name of the current connection's database.
7. **WHERE:** Filter to current database.

## 3. Additional example

```sql
EXPLAIN (ANALYZE, BUFFERS)
SELECT COUNT(*) FROM lab_attendance WHERE class_id = 10;
-- EXPLAIN ANALYZE really executes this SELECT.
```

Discuss what this statement returns and which assumptions must hold for its results to be meaningful.

## 4. Applied assignment

In a fictional ProTrack MX testing project: explain expected outputs, test invalid input and unauthorized access, and document your conclusions. Do not access production student data or execute destructive operations against any live project.

## 5. Warnings and limitations

Queries and logs may contain sensitive user values. Never publish raw SQL activity from production; restrict monitoring access. Investigate slow queries with plans, indexes, row counts and request patterns before optimizing.

## 6. Questions for review

1. What is pg_stat_activity?
2. What is a backend PID?
3. What does state show?
4. What is wait_event_type?
5. What is EXPLAIN?
6. Does EXPLAIN ANALYZE run the statement?
7. What is a slow query?
8. Why protect logs?
9. What can cause timeout errors?
10. What is a safe troubleshooting sequence?

Write answers one question at a time in [QUESTIONS.md](./QUESTIONS.md), then check [ANSWERS.md](./ANSWERS.md).

## 7. Course completion checklist

- [ ] All keywords explained in my own words.
- [ ] Test-only examples reviewed.
- [ ] Error cases and security boundaries documented.
- [ ] Ten review questions attempted.
- [ ] I can describe an appropriate secure implementation plan.

## References

- [PostgreSQL](https://www.postgresql.org/docs/current/)
- [Supabase](https://supabase.com/docs)
- [Supabase RLS](https://supabase.com/docs/guides/database/postgres/row-level-security)
