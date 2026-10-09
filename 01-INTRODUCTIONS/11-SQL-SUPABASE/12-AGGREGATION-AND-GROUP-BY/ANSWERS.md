# Class 12 — Answer Key

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What does GROUP BY do?

**Correct explanation:** It partitions input rows into groups sharing the named values.

## Answer 2

**Question:** What does COUNT(*) count?

**Correct explanation:** All input rows in a group, even if some columns contain NULL.

## Answer 3

**Question:** What does COUNT(score) count?

**Correct explanation:** Rows with a non-NULL score.

## Answer 4

**Question:** What does AVG calculate?

**Correct explanation:** The average of non-NULL numeric values.

## Answer 5

**Question:** What does HAVING filter?

**Correct explanation:** Groups based on aggregate or group expressions.

## Answer 6

**Question:** WHERE versus HAVING?

**Correct explanation:** WHERE filters input rows; HAVING filters groups after grouping.

## Answer 7

**Question:** Why can COUNT(*) differ from COUNT(score)?

**Correct explanation:** A score column may contain NULL.

## Answer 8

**Question:** What does SUM(score) do?

**Correct explanation:** Adds non-NULL score values.

## Answer 9

**Question:** Why ORDER BY?

**Correct explanation:** Aggregate query results are not otherwise guaranteed to appear in a chosen order.

## Answer 10

**Question:** How to treat missing grades?

**Correct explanation:** Define explicit business rules instead of silently treating all NULL values as zero.


**Always practice with fictional records in a development database.**