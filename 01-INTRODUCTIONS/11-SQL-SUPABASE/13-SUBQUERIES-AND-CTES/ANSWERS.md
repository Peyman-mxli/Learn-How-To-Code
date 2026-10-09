# Class 13 — Answer Key

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a subquery?

**Correct explanation:** A SELECT statement used inside another SQL statement.

## Answer 2

**Question:** What does WITH mean here?

**Correct explanation:** It declares one or more common table expressions for the following statement.

## Answer 3

**Question:** What is a CTE?

**Correct explanation:** A named query expression referenced by the main statement.

## Answer 4

**Question:** How long does a CTE name exist?

**Correct explanation:** Only within its SQL statement.

## Answer 5

**Question:** What does AVG do?

**Correct explanation:** Computes an average excluding NULL inputs.

## Answer 6

**Question:** Why CROSS JOIN with a one-row CTE?

**Correct explanation:** To make the single average value available to every student row.

## Answer 7

**Question:** What is a scalar subquery?

**Correct explanation:** A subquery used as one value; it must return a suitable single value.

## Answer 8

**Question:** Why use an alias?

**Correct explanation:** To distinguish sources and simplify references.

## Answer 9

**Question:** Is a CTE always faster?

**Correct explanation:** No; execution plans vary.

## Answer 10

**Question:** Does a CTE bypass RLS?

**Correct explanation:** No; normal applicable database security controls still matter.


**Always practice with fictional records in a development database.**