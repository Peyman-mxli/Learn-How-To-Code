# Class 34 — Answer Explanations

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is an assertion?

**Explanation:** A condition a test expects to hold.

## Answer 2

**Question:** What is a positive test?

**Explanation:** Verify a permitted or valid operation succeeds.

## Answer 3

**Question:** What is a negative test?

**Explanation:** Verify an invalid or forbidden operation is rejected.

## Answer 4

**Question:** What is a constraint test?

**Explanation:** A test confirming database constraints enforce intended invariants.

## Answer 5

**Question:** What is an RLS test?

**Explanation:** A test using a realistic role context to verify row-level access.

## Answer 6

**Question:** Why test two users?

**Explanation:** To detect unauthorized cross-user data access.

## Answer 7

**Question:** Why use transactions for tests?

**Explanation:** To isolate reversible database changes.

## Answer 8

**Question:** Can rollback reverse sequence values?

**Explanation:** No; sequence increments generally persist.

## Answer 9

**Question:** What should be tested for weight validation?

**Explanation:** Both individual bounds and total-weight business rules.

## Answer 10

**Question:** Why include tests in CI?

**Explanation:** To catch regressions before changes are merged or deployed.


Check your reasoning against the main example and official documentation.