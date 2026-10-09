# Class 16 — Indexes and Query Performance

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Objectives

Read the main example without guessing what a keyword means; practice a realistic application task and identify potential safety problems. This builds on the earlier numbered lessons.

**Practice only in a test project with fictional data. No real student information, secrets or production migrations.**

## 1. Setup or Context

```sql
CREATE TABLE lab_attendance(id bigint GENERATED ALWAYS AS IDENTITY PRIMARY KEY, class_id integer NOT NULL, attended_on date NOT NULL, present boolean NOT NULL);
```

The context provides the minimum objects or assumptions needed to understand the main demonstration. Review all dependencies before executing code.

## 2. Fully Explained Main Example

```sql
CREATE INDEX lab_attendance_class_day_idx ON lab_attendance(class_id, attended_on);
EXPLAIN SELECT id, present FROM lab_attendance WHERE class_id = 10 AND attended_on = DATE '2026-10-09';
```

| Keyword / phrase | What it means |
|---|---|
| `CREATE INDEX` | Create a lookup structure to potentially improve certain queries. |
| `lab_attendance_class_day_idx` | Name for the index. |
| `ON lab_attendance` | Table indexed. |
| `(class_id, attended_on)` | Index key columns and their order. |
| `EXPLAIN` | Show PostgreSQL's planned execution strategy. |
| `SELECT` | Read records. |
| `WHERE` | Filter records. |
| `AND` | Require both conditions. |
| `DATE '2026-10-09'` | A typed date literal. |

### Read it from top to bottom

1. **CREATE INDEX:** Create a lookup structure to potentially improve certain queries.
2. **lab_attendance_class_day_idx:** Name for the index.
3. **ON lab_attendance:** Table indexed.
4. **(class_id, attended_on):** Index key columns and their order.
5. **EXPLAIN:** Show PostgreSQL's planned execution strategy.
6. **SELECT:** Read records.
7. **WHERE:** Filter records.
8. **AND:** Require both conditions.
9. **DATE '2026-10-09':** A typed date literal.

## 3. Second Example

```sql
EXPLAIN (ANALYZE, BUFFERS)
SELECT COUNT(*) FROM lab_attendance WHERE class_id = 10;
-- ANALYZE actually executes the query. Use an isolated safe environment.
```

The second example extends the first one. Explain what new command, option, or behavior it introduces and what might fail.

## 4. Practical ProTrack MX Design Exercise

Imagine a fictional teacher managing classes, marks, or educational attachments. Describe when this feature would help and what should happen if the user lacks permission, the input is invalid, or the operation fails. Keep the example separate from real school data.

## 5. What Beginners Often Miss

An index is not guaranteed to be selected on small tables. Indexes cost storage and write work. EXPLAIN ANALYZE executes the query and must be used carefully with writes.

A snippet that appears simple can have non-obvious effects. Always review permissions and test failure conditions before a deployment.

## 6. Ten Questions

1. What is an index?
2. What does CREATE INDEX do?
3. What does the composite index store?
4. Why does index column order matter?
5. What does EXPLAIN show?
6. What does EXPLAIN ANALYZE add?
7. Does PostgreSQL always use an index?
8. Why can too many indexes hurt?
9. What is a sequential scan?
10. What should be optimized first?

Answer them one by one in [QUESTIONS.md](./QUESTIONS.md), then check [ANSWERS.md](./ANSWERS.md) for detailed correct meanings.

## 7. Self-Check

- [ ] I know what every main token does.
- [ ] I can distinguish reading and changing data.
- [ ] I understand the security warnings.
- [ ] I attempted all practice questions before reviewing.

## Documentation

- [PostgreSQL Official Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Official Documentation](https://supabase.com/docs)
