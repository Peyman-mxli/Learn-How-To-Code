# Class 29 — Explained Answers

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is pg_stat_activity?

**Explanation:** A PostgreSQL view for observing backend connections and recent activity.

## Answer 2

**Question:** What is a backend PID?

**Explanation:** The process identifier for a server backend.

## Answer 3

**Question:** What does state show?

**Explanation:** The connection's current activity state.

## Answer 4

**Question:** What is wait_event_type?

**Explanation:** A category identifying why a backend may be waiting.

## Answer 5

**Question:** What is EXPLAIN?

**Explanation:** A description of PostgreSQL's chosen execution plan.

## Answer 6

**Question:** Does EXPLAIN ANALYZE run the statement?

**Explanation:** Yes; it actually executes it to collect runtime statistics.

## Answer 7

**Question:** What is a slow query?

**Explanation:** A query whose execution time harms an application's expected performance.

## Answer 8

**Question:** Why protect logs?

**Explanation:** They may contain sensitive statements or identifiers.

## Answer 9

**Question:** What can cause timeout errors?

**Explanation:** Slow plans, locks, connection problems, overload or network issues.

## Answer 10

**Question:** What is a safe troubleshooting sequence?

**Explanation:** Reproduce in development, inspect errors/plans, identify bottleneck, test a fix and verify permissions.
