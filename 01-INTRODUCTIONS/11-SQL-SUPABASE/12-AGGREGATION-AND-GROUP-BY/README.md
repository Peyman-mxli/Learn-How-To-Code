# Class 12 — Aggregation, GROUP BY, and HAVING

[Course index](../README.md) · [Practice Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## What You Will Learn

Summarize scores per class and understand how groups are formed.

**Prerequisites:** Classes 01–11. **Context:** fictional ProTrack MX test data; do not run these commands on the production database.

## 1. Start from a Clean Practice Environment

Run this setup only in an isolated development PostgreSQL database. It uses lab-prefixed tables to avoid interfering with real objects.

```sql
CREATE TABLE lab_scores (id integer PRIMARY KEY, class_id integer NOT NULL, score numeric(5,2));
INSERT INTO lab_scores VALUES (1,10,80),(2,10,90),(3,11,70),(4,11,NULL);
```

Read the table names, column types, constraints, and sample row values before continuing. `CREATE TABLE` declares structure; `INSERT INTO` creates rows; `VALUES` introduces row contents; `;` ends the statement.

## 2. Core Example

```sql
SELECT class_id, COUNT(*) AS attempts, AVG(score) AS average_score
FROM lab_scores
GROUP BY class_id
HAVING AVG(score) >= 80
ORDER BY class_id;
```

## 3. Every Important SQL Phrase

| Phrase | Exact meaning |
|---|---|
| `COUNT(*)` | Count rows, including rows with a NULL score. |
| `AS attempts` | Label a calculated output. |
| `AVG(score)` | Calculate average of non-NULL scores. |
| `FROM` | Choose source table. |
| `GROUP BY class_id` | Collect rows for each class_id. |
| `HAVING` | Filter groups after aggregate calculations. |
| `AVG(score) >= 80` | Keep groups whose average qualifies. |
| `ORDER BY` | Order result rows. |

### Walk Through It Line by Line

1. **COUNT(*)** — Count rows, including rows with a NULL score.
2. **AS attempts** — Label a calculated output.
3. **AVG(score)** — Calculate average of non-NULL scores.
4. **FROM** — Choose source table.
5. **GROUP BY class_id** — Collect rows for each class_id.
6. **HAVING** — Filter groups after aggregate calculations.
7. **AVG(score) >= 80** — Keep groups whose average qualifies.
8. **ORDER BY** — Order result rows.

## 4. A Related Example

```sql
SELECT class_id, COUNT(*) AS all_rows,
       COUNT(score) AS scored_rows,
       SUM(score) AS points
FROM lab_scores
GROUP BY class_id;
-- COUNT(score) omits NULL scores; COUNT(*) does not.
```

Compare this example to the previous statement. Notice what condition, clause, or result changed, and be ready to explain why.

## 5. Common Mistakes

WHERE filters individual rows before grouping; HAVING filters groups after grouping. AVG ignores NULL values. Decide how missing grades are represented before calculating real school averages.

Even a correct SQL query does not replace user permissions. Supabase API access requires appropriate database grants and row-level policies where applicable.

## 6. ProTrack MX Practice Scenario

Imagine a teacher working with fictional classes, assignment scores, and categories. Explain how the query would affect or summarize these records, and how you would protect real student data. The lab table design is intentionally simplified; it is not the actual ProTrack MX production schema.

## 7. Try These Ten Exercises

1. What does GROUP BY do?
2. What does COUNT(*) count?
3. What does COUNT(score) count?
4. What does AVG calculate?
5. What does HAVING filter?
6. WHERE versus HAVING?
7. Why can COUNT(*) differ from COUNT(score)?
8. What does SUM(score) do?
9. Why ORDER BY?
10. How to treat missing grades?

Use [QUESTIONS.md](./QUESTIONS.md) to answer **one question at a time**, then check [ANSWERS.md](./ANSWERS.md).

## 8. Completion Checklist

- [ ] I can define every keyword in the main query.
- [ ] I can describe its result or effect on the sample rows.
- [ ] I can compare the main and related examples.
- [ ] I understand the caveats and permissions involved.
- [ ] I have answered all ten questions before seeing their answers.

## Reference Documentation

- [PostgreSQL SQL Language](https://www.postgresql.org/docs/current/sql.html)
- [PostgreSQL Tutorial](https://www.postgresql.org/docs/current/tutorial.html)
- [Supabase Database Docs](https://supabase.com/docs/guides/database)
