# Class 27 — Validation and Configurable Grade Calculations

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning goals

Explain each command, identify its role in safe ProTrack MX development, practice the example in a separate test environment, and pass ten comprehension questions.

## 1. Main example

```sql
CREATE TABLE lab_criteria (
 id int PRIMARY KEY,
 class_id int NOT NULL,
 criterion text NOT NULL,
 weight numeric(5,2) NOT NULL CHECK(weight >= 0 AND weight <= 100)
);
SELECT class_id, SUM(weight) AS total_weight
FROM lab_criteria GROUP BY class_id;
```

## 2. Word-by-word explanations

| Term | Meaning and purpose |
|---|---|
| `CREATE TABLE` | Define a table. |
| `numeric(5,2)` | Exact numeric decimal with fixed precision and scale. |
| `CHECK` | Reject invalid rows when condition evaluates to false. |
| `SUM(weight)` | Sum weights per group. |
| `GROUP BY` | Calculate independently for each class. |
| `AS total_weight` | Give result column a meaningful name. |

### Read the statement line by line

1. **CREATE TABLE:** Define a table.
2. **numeric(5,2):** Exact numeric decimal with fixed precision and scale.
3. **CHECK:** Reject invalid rows when condition evaluates to false.
4. **SUM(weight):** Sum weights per group.
5. **GROUP BY:** Calculate independently for each class.
6. **AS total_weight:** Give result column a meaningful name.

## 3. Additional working example

```sql
-- Example weighted points for scores on a 0..100 scale:
SELECT SUM(score * weight / 100.0) AS weighted_grade
FROM lab_assessment_results
WHERE student_id = 1 AND period_id = 1;
-- Assumes appropriately validated data/model and total weight 100.
```

Read the code from left to right. Identify which objects it touches, whether it changes data, and what happens if its inputs do not match expected rows.

## 4. ProTrack MX practice

Use fictional teachers, students and periods to describe the appropriate purpose of the operation. The sample names are not verified database objects in the actual app. Discuss privileges, user identity and RLS before proposing an operation on any school records.

## 5. Important caveats

A CHECK constraint on an individual row cannot by itself guarantee that all category weights for a class and trimester sum to 100. Use transactions and validated application/database processes. Define missing-grade and rounding policy explicitly.

## 6. Review questions

1. What is an evaluation criterion?
2. What does weight represent?
3. Why use numeric for weights?
4. What does CHECK(weight >= 0 AND weight <= 100) ensure?
5. Does that CHECK make total weights equal 100?
6. What does SUM do?
7. What is a weighted grade?
8. Why define missing-score rules?
9. Why round only at deliberate steps?
10. What is required before applying grade changes?

Complete [QUESTIONS.md](./QUESTIONS.md) one question at a time; check [ANSWERS.md](./ANSWERS.md) afterward.

## 7. Completion criteria

- [ ] Explain the main statement without copying.
- [ ] Explain the additional example and differences.
- [ ] Describe at least two security or correctness risks.
- [ ] Attempt all ten questions independently.

## Further reading

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
