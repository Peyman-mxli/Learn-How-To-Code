# Class 24: Explained Answers

[Lesson](./README.md) | [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a concurrent transaction?

**Explanation:** Another transaction executing during an overlapping period.

## Answer 2

**Question:** What is a race condition?

**Explanation:** An outcome depending on unsafe interleaving of operations.

## Answer 3

**Question:** What does FOR UPDATE do?

**Explanation:** Lock selected rows against incompatible concurrent modifications.

## Answer 4

**Question:** Why use BEGIN?

**Explanation:** Start a transaction that groups related operations.

## Answer 5

**Question:** Why use a guarded UPDATE?

**Explanation:** Avoid changing values when the precondition is false.

## Answer 6

**Question:** What does RETURNING show?

**Explanation:** Values of rows actually changed.

## Answer 7

**Question:** What is a deadlock?

**Explanation:** Two or more transactions waiting on each other's locks.

## Answer 8

**Question:** Why keep transactions short?

**Explanation:** To reduce contention and limit lock durations.

## Answer 9

**Question:** Is SELECT then UPDATE always safe without locks?

**Explanation:** No; another transaction can change the row between steps.

## Answer 10

**Question:** How should retryable concurrency errors be handled?

**Explanation:** Use bounded retries with safe idempotent application logic.
