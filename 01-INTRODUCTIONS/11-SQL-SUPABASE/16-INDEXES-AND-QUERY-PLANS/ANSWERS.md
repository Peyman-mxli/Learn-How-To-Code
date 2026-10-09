# Class 16 — Explained Answers: Indexes and Query Performance

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is an index?

**Explanation:** A database structure that can accelerate qualifying access patterns.

## Answer 2

**Question:** What does CREATE INDEX do?

**Explanation:** Build an index on named table columns or expressions.

## Answer 3

**Question:** What does the composite index store?

**Explanation:** Index entries ordered by its first and subsequent key columns.

## Answer 4

**Question:** Why does index column order matter?

**Explanation:** It influences which predicates and orderings can use an index efficiently.

## Answer 5

**Question:** What does EXPLAIN show?

**Explanation:** The optimizer's planned approach and estimated costs.

## Answer 6

**Question:** What does EXPLAIN ANALYZE add?

**Explanation:** It executes the statement and includes actual timing and row information.

## Answer 7

**Question:** Does PostgreSQL always use an index?

**Explanation:** No; it may choose sequential scanning when estimated cheaper.

## Answer 8

**Question:** Why can too many indexes hurt?

**Explanation:** They use space and increase write maintenance.

## Answer 9

**Question:** What is a sequential scan?

**Explanation:** Reading table pages without using an index access path.

## Answer 10

**Question:** What should be optimized first?

**Explanation:** Measure actual workload and correct query/index design rather than guessing.


Always consider validation, authorization, and production-data safety.