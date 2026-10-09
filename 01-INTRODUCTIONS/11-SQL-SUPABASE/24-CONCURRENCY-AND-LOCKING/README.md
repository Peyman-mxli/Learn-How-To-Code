# Class 24: Concurrent Transactions and Locking

[Course Index](../README.md) | [Questions](./QUESTIONS.md) | [Answers](./ANSWERS.md)

## Learning outcome

Understand each clause, execute a hypothetical query mentally, explain pitfalls, and apply the idea to a fictional ProTrack MX scenario. Prerequisite: previous numbered lessons.

## 1. Isolated test setup

Run only against a disposable PostgreSQL test environment. This SQL creates fictional lab-prefixed tables; never run on the live ProTrack MX database.

```sql
CREATE TABLE lab_seats(id int PRIMARY KEY, available int NOT NULL CHECK(available >= 0));
INSERT INTO lab_seats VALUES (1,5);
```

## 2. Main worked example

```sql
BEGIN;
SELECT available FROM lab_seats WHERE id = 1 FOR UPDATE;
UPDATE lab_seats SET available = available - 1
WHERE id = 1 AND available > 0;
COMMIT;
```

### Every SQL phrase explained

| Phrase | Why it is used |
|---|---|
| `BEGIN` | Start a transaction. |
| `SELECT ... FOR UPDATE` | Lock selected rows for subsequent update. |
| `WHERE` | Limit which row is locked or changed. |
| `UPDATE` | Modify an existing row. |
| `available = available - 1` | Decrement using the stored value. |
| `AND available > 0` | Avoid decrementing below zero. |
| `COMMIT` | Commit the transaction. |

### Walk through in order

1. **BEGIN:** Start a transaction.
2. **SELECT ... FOR UPDATE:** Lock selected rows for subsequent update.
3. **WHERE:** Limit which row is locked or changed.
4. **UPDATE:** Modify an existing row.
5. **available = available - 1:** Decrement using the stored value.
6. **AND available > 0:** Avoid decrementing below zero.
7. **COMMIT:** Commit the transaction.

## 3. Second example

```sql
-- Atomic guarded decrement pattern:
UPDATE lab_seats SET available = available - 1
WHERE id = 1 AND available > 0
RETURNING available;
-- Zero returned rows means no update succeeded.
```

Compare the first and second example. State what data each one reads or changes, what can fail, and why the additional clause matters.

## 4. ProTrack MX application

Consider fake classes, teacher sessions, preferences or grades. Explain how the example helps with authorized reports or safe updates. A SQL filter is not an authorization mechanism. Production data requires appropriate grants, RLS, validations and testing.

## 5. Important limitations

Locks can block concurrent requests and deadlock if taken in inconsistent order. Retry serialization/deadlock failures correctly and keep transactions short.

## 6. Exercises

1. What is a concurrent transaction?
2. What is a race condition?
3. What does FOR UPDATE do?
4. Why use BEGIN?
5. Why use a guarded UPDATE?
6. What does RETURNING show?
7. What is a deadlock?
8. Why keep transactions short?
9. Is SELECT then UPDATE always safe without locks?
10. How should retryable concurrency errors be handled?

Answer one question at a time, then consult the separate answer key.

## 7. Self-check

- [ ] I understand the terms and the code.
- [ ] I can describe expected results without executing SQL.
- [ ] I know the main failure modes.
- [ ] I can answer all ten questions.

## References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
