# Class 21: Window Functions and Rankings

[Course Index](../README.md) | [Questions](./QUESTIONS.md) | [Answers](./ANSWERS.md)

## Learning outcome

Understand each clause, execute a hypothetical query mentally, explain pitfalls, and apply the idea to a fictional ProTrack MX scenario. Prerequisite: previous numbered lessons.

## 1. Isolated test setup

Run only against a disposable PostgreSQL test environment. This SQL creates fictional lab-prefixed tables; never run on the live ProTrack MX database.

```sql
CREATE TABLE lab_marks(student_id int, class_id int, score numeric);
INSERT INTO lab_marks VALUES (1,10,90),(2,10,75),(3,10,90),(4,11,80);
```

## 2. Main worked example

```sql
SELECT student_id, class_id, score,
  RANK() OVER (PARTITION BY class_id ORDER BY score DESC) AS class_rank
FROM lab_marks;
```

### Every SQL phrase explained

| Phrase | Why it is used |
|---|---|
| `SELECT` | Choose output columns. |
| `RANK()` | Assign tied rankings, leaving gaps after ties. |
| `OVER` | Define a window for computation. |
| `PARTITION BY` | Restart ranking separately for each class. |
| `ORDER BY score DESC` | Rank higher scores first. |
| `AS class_rank` | Label the computed column. |

### Walk through in order

1. **SELECT:** Choose output columns.
2. **RANK():** Assign tied rankings, leaving gaps after ties.
3. **OVER:** Define a window for computation.
4. **PARTITION BY:** Restart ranking separately for each class.
5. **ORDER BY score DESC:** Rank higher scores first.
6. **AS class_rank:** Label the computed column.

## 3. Second example

```sql
SELECT student_id, score,
 ROW_NUMBER() OVER (ORDER BY score DESC, student_id) AS row_num,
 DENSE_RANK() OVER (ORDER BY score DESC) AS dense_rank
FROM lab_marks;
```

Compare the first and second example. State what data each one reads or changes, what can fail, and why the additional clause matters.

## 4. ProTrack MX application

Consider fake classes, teacher sessions, preferences or grades. Explain how the example helps with authorized reports or safe updates. A SQL filter is not an authorization mechanism. Production data requires appropriate grants, RLS, validations and testing.

## 5. Important limitations

RANK and DENSE_RANK handle ties differently; ORDER BY inside OVER is not guaranteed final display order.

## 6. Exercises

1. What is a window function?
2. What does OVER mean?
3. What does PARTITION BY do?
4. What does DESC mean?
5. What does RANK do with ties?
6. What does DENSE_RANK do?
7. What does ROW_NUMBER do?
8. Does window ORDER BY sort final output?
9. Why include a tie-breaker?
10. What might ProTrack MX use window functions for?

Answer one question at a time, then consult the separate answer key.

## 7. Self-check

- [ ] I understand the terms and the code.
- [ ] I can describe expected results without executing SQL.
- [ ] I know the main failure modes.
- [ ] I can answer all ten questions.

## References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
