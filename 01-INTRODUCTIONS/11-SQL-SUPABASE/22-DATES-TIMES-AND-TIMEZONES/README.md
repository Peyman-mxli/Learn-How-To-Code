# Class 22: Dates, Times, and Time Zones

[Course Index](../README.md) | [Questions](./QUESTIONS.md) | [Answers](./ANSWERS.md)

## Learning outcome

Understand each clause, execute a hypothetical query mentally, explain pitfalls, and apply the idea to a fictional ProTrack MX scenario. Prerequisite: previous numbered lessons.

## 1. Isolated test setup

Run only against a disposable PostgreSQL test environment. This SQL creates fictional lab-prefixed tables; never run on the live ProTrack MX database.

```sql
CREATE TABLE lab_sessions(id integer PRIMARY KEY, starts_at timestamptz NOT NULL);
INSERT INTO lab_sessions VALUES (1, '2026-10-09 16:00:00+00');
```

## 2. Main worked example

```sql
SELECT id, starts_at,
  starts_at AT TIME ZONE 'America/Tijuana' AS local_start
FROM lab_sessions
WHERE starts_at >= TIMESTAMPTZ '2026-10-09 00:00:00+00';
```

### Every SQL phrase explained

| Phrase | Why it is used |
|---|---|
| `timestamptz` | Timestamp with time zone semantics, stored as an absolute instant. |
| `AT TIME ZONE` | Convert an instant to a wall-clock timestamp for a named zone. |
| `America/Tijuana` | IANA time zone identifier. |
| `AS local_start` | Name the output column. |
| `WHERE` | Limit matching rows. |
| `TIMESTAMPTZ` | Explicitly typed timestamp literal. |
| `;` | End statement. |

### Walk through in order

1. **timestamptz:** Timestamp with time zone semantics, stored as an absolute instant.
2. **AT TIME ZONE:** Convert an instant to a wall-clock timestamp for a named zone.
3. **America/Tijuana:** IANA time zone identifier.
4. **AS local_start:** Name the output column.
5. **WHERE:** Limit matching rows.
6. **TIMESTAMPTZ:** Explicitly typed timestamp literal.
7. **;:** End statement.

## 3. Second example

```sql
SELECT CURRENT_DATE, now(),
  (now() AT TIME ZONE 'America/Tijuana') AS local_now;
-- Results depend on actual execution date and database settings.
```

Compare the first and second example. State what data each one reads or changes, what can fail, and why the additional clause matters.

## 4. ProTrack MX application

Consider fake classes, teacher sessions, preferences or grades. Explain how the example helps with authorized reports or safe updates. A SQL filter is not an authorization mechanism. Production data requires appropriate grants, RLS, validations and testing.

## 5. Important limitations

A fixed -07:00 offset is not the same thing as a named time zone; daylight-saving rules may vary by jurisdiction and date.

## 6. Exercises

1. What is DATE?
2. What is TIMESTAMP WITHOUT TIME ZONE?
3. What is TIMESTAMPTZ?
4. What does AT TIME ZONE do?
5. Why use IANA names?
6. What is CURRENT_DATE?
7. What does now() return?
8. Why is timezone testing important?
9. Is -07:00 always equivalent to America/Tijuana?
10. What storage works for an appointment instant?

Answer one question at a time, then consult the separate answer key.

## 7. Self-check

- [ ] I understand the terms and the code.
- [ ] I can describe expected results without executing SQL.
- [ ] I know the main failure modes.
- [ ] I can answer all ten questions.

## References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
