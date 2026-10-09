# Class 28 — Pagination and Safe API Queries

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning goals

Explain each command, identify its role in safe ProTrack MX development, practice the example in a separate test environment, and pass ten comprehension questions.

## 1. Main example

```sql
SELECT id, name
FROM lab_students
WHERE id > 20
ORDER BY id
LIMIT 10;
```

## 2. Word-by-word explanations

| Term | Meaning and purpose |
|---|---|
| `SELECT` | Select requested fields. |
| `FROM` | Name source table. |
| `WHERE id > 20` | Resume after a cursor key. |
| `ORDER BY id` | Provide stable key ordering. |
| `LIMIT 10` | Bound returned rows. |
| `;` | Finish the statement. |

### Read the statement line by line

1. **SELECT:** Select requested fields.
2. **FROM:** Name source table.
3. **WHERE id > 20:** Resume after a cursor key.
4. **ORDER BY id:** Provide stable key ordering.
5. **LIMIT 10:** Bound returned rows.
6. **;:** Finish the statement.

## 3. Additional working example

```sql
-- Offset pagination for comparison:
SELECT id, name FROM lab_students
ORDER BY id LIMIT 10 OFFSET 20;
-- Deep offsets can be expensive; changing data can shift pages.
```

Read the code from left to right. Identify which objects it touches, whether it changes data, and what happens if its inputs do not match expected rows.

## 4. ProTrack MX practice

Use fictional teachers, students and periods to describe the appropriate purpose of the operation. The sample names are not verified database objects in the actual app. Discuss privileges, user identity and RLS before proposing an operation on any school records.

## 5. Important caveats

Keyset paging requires a carefully chosen ordering and unique tie breaker when using nonunique sort columns. Pagination does not grant access or replace RLS. API input limits and safe request validation are essential.

## 6. Review questions

1. Why paginate?
2. What does LIMIT do?
3. What does OFFSET do?
4. Why is ORDER BY important?
5. What is keyset pagination?
6. What is a cursor?
7. What happens when records change during offset paging?
8. Does pagination replace authorization?
9. Why select only needed columns?
10. What is rate limiting?

Complete [QUESTIONS.md](./QUESTIONS.md) one question at a time; check [ANSWERS.md](./ANSWERS.md) afterward.

## 7. Completion criteria

- [ ] Explain the main statement without copying.
- [ ] Explain the additional example and differences.
- [ ] Describe at least two security or correctness risks.
- [ ] Attempt all ten questions independently.

## Further reading

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
