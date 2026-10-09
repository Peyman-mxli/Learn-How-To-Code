# Class 20 — Explained Answers

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a unit test?

**Correct explanation:** A focused test of one unit of behavior, such as an averaging helper.

## Answer 2

**Question:** What is an integration test?

**Correct explanation:** A test verifying that multiple components, such as Auth and database access, work together.

## Answer 3

**Question:** What is a negative authorization test?

**Correct explanation:** A test proving that forbidden access is rejected.

## Answer 4

**Question:** What does BEGIN do?

**Correct explanation:** Start a transaction.

## Answer 5

**Question:** What does ROLLBACK do?

**Correct explanation:** Revert reversible changes from the current transaction.

## Answer 6

**Question:** Do sequences necessarily roll back?

**Correct explanation:** No; consumed sequence values are generally not undone by transaction rollback.

## Answer 7

**Question:** Why test two teacher accounts?

**Correct explanation:** To verify isolation between users and prevent cross-teacher data exposure.

## Answer 8

**Question:** Why use migrations?

**Correct explanation:** To track and reproduce database changes across environments.

## Answer 9

**Question:** What is a deployment checklist?

**Correct explanation:** A repeatable review of tests, permissions, configuration, backups and rollback readiness before release.

## Answer 10

**Question:** What defines capstone completion?

**Correct explanation:** A tested learning prototype and documented design, with fake data, authorization checks, clear grading rules and safe failure handling.


Do all experiments in a test project, never on ProTrack MX production.