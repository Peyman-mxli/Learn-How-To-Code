# Class 25 — Answers Explained

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a backup?

**Correct answer:** A preserved copy of data or database state for recovery.

## Answer 2

**Question:** What does pg_dump do?

**Correct answer:** Exports database schema and data to a supported format.

## Answer 3

**Question:** What does custom format mean?

**Correct answer:** A PostgreSQL archive format suitable for flexible pg_restore operations.

## Answer 4

**Question:** What does pg_restore do?

**Correct answer:** Restores supported PostgreSQL dump archives.

## Answer 5

**Question:** Why test restoration?

**Correct answer:** To prove recovery is possible and detect missing objects or corrupted archives.

## Answer 6

**Question:** What is RPO?

**Correct answer:** Recovery Point Objective: acceptable amount of recent data loss measured as time.

## Answer 7

**Question:** What is RTO?

**Correct answer:** Recovery Time Objective: acceptable time to restore service.

## Answer 8

**Question:** Is a GitHub SQL script a database backup?

**Correct answer:** No; migrations do not necessarily capture actual data or production state.

## Answer 9

**Question:** Why protect backup files?

**Correct answer:** They can contain confidential student information.

## Answer 10

**Question:** Does every Supabase plan include identical recovery features?

**Correct answer:** No, confirm current feature and plan availability.
