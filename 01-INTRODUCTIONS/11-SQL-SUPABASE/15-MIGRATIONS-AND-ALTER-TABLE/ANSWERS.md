# Class 15 — Explained Answers: Schema Changes and Database Migrations

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a migration?

**Explanation:** A versioned and repeatable change to a database schema or data model.

## Answer 2

**Question:** What does ALTER TABLE do?

**Explanation:** It changes the structure or properties of an existing table.

## Answer 3

**Question:** What does ADD COLUMN mean?

**Explanation:** Create a new named column.

## Answer 4

**Question:** Why use DATE?

**Explanation:** To store dates without a time-of-day component.

## Answer 5

**Question:** What does ADD CONSTRAINT mean?

**Explanation:** Install a named data-integrity rule on a table.

## Answer 6

**Question:** What does CHECK do?

**Explanation:** Reject rows when its condition evaluates to FALSE; combine with NOT NULL if NULL must also be rejected.

## Answer 7

**Question:** Why must existing rows be considered?

**Explanation:** A new constraint may fail validation against existing data.

## Answer 8

**Question:** What does BEGIN do?

**Explanation:** Open a transaction.

## Answer 9

**Question:** What does ROLLBACK do?

**Explanation:** Undo applicable work in the current transaction.

## Answer 10

**Question:** Why review a migration before production?

**Explanation:** To manage locks, data compatibility, permissions, dependencies, backups and recovery.


Always consider validation, authorization, and production-data safety.