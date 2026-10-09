# Class 30 — End-to-End Secure ProTrack MX Learning Capstone

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Objectives

Use everything learned in SQL, PostgreSQL, and Supabase to read code accurately, explain its purpose, anticipate errors and review secure educational application design.

## 1. Main example (isolated test environment only)

```sql
-- TEST DATABASE ONLY. Simplified relational model.
CREATE TABLE lab_final_teachers(id uuid PRIMARY KEY, display_name text NOT NULL);
CREATE TABLE lab_final_classes(id int PRIMARY KEY, teacher_id uuid NOT NULL REFERENCES lab_final_teachers(id), title text NOT NULL);
CREATE TABLE lab_final_criteria(id int PRIMARY KEY, class_id int NOT NULL REFERENCES lab_final_classes(id), label text NOT NULL, weight numeric(5,2) NOT NULL CHECK(weight BETWEEN 0 AND 100));
```

## 2. Explain every important phrase

| Expression | Explanation |
|---|---|
| `CREATE TABLE` | Declare a relational table. |
| `uuid PRIMARY KEY` | Unique non-null teacher identifier. |
| `REFERENCES` | Foreign key to a parent table. |
| `NOT NULL` | Disallow absent NULL column values. |
| `numeric(5,2)` | Exact decimal suitable for example weights. |
| `CHECK` | Reject values outside a stated range. |
| `class_id` | Connect evaluation criterion to a class. |

### Step-by-step explanation

1. **CREATE TABLE:** Declare a relational table.
2. **uuid PRIMARY KEY:** Unique non-null teacher identifier.
3. **REFERENCES:** Foreign key to a parent table.
4. **NOT NULL:** Disallow absent NULL column values.
5. **numeric(5,2):** Exact decimal suitable for example weights.
6. **CHECK:** Reject values outside a stated range.
7. **class_id:** Connect evaluation criterion to a class.

## 3. Additional example

```sql
SELECT c.title, SUM(k.weight) AS configured_weight
FROM lab_final_classes c
JOIN lab_final_criteria k ON k.class_id = c.id
GROUP BY c.id, c.title;
-- Inspect each class's sum of criterion weights in a test DB.
```

Discuss what this statement returns and which assumptions must hold for its results to be meaningful.

## 4. Applied assignment

In a fictional ProTrack MX testing project: explain expected outputs, test invalid input and unauthorized access, and document your conclusions. Do not access production student data or execute destructive operations against any live project.

## 5. Warnings and limitations

This demonstration is NOT a production-ready school management schema and DOES NOT implement Auth or RLS. Add enrolled students, assessment periods, ownership checks, secure migrations, explicit missing-grade rules and comprehensive user-based permission tests before building any production application.

## 6. Questions for review

1. What is the project goal?
2. What does PRIMARY KEY guarantee?
3. Why foreign keys?
4. What should configurable weights total?
5. Why are test teacher identities needed?
6. Why is Auth not enough?
7. What should an RLS test verify?
8. Why do database migrations matter?
9. How should averages handle missing scores?
10. What makes the capstone complete?

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
