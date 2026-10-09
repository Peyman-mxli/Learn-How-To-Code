# Class 30 — Explained Answers

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is the project goal?

**Explanation:** Model fictional teachers, classes, criteria and grades with tested, secure access.

## Answer 2

**Question:** What does PRIMARY KEY guarantee?

**Explanation:** Unique non-NULL identifier values.

## Answer 3

**Question:** Why foreign keys?

**Explanation:** To enforce references between related tables.

## Answer 4

**Question:** What should configurable weights total?

**Explanation:** The application's defined weighting total, commonly 100 percent, enforced with appropriate cross-row validation.

## Answer 5

**Question:** Why are test teacher identities needed?

**Explanation:** To verify normal permitted and denied access paths under distinct users.

## Answer 6

**Question:** Why is Auth not enough?

**Explanation:** Signing in proves identity, not authorization to all rows.

## Answer 7

**Question:** What should an RLS test verify?

**Explanation:** Teacher A cannot read or change Teacher B's unauthorized data.

## Answer 8

**Question:** Why do database migrations matter?

**Explanation:** To reproduce controlled versioned schema changes.

## Answer 9

**Question:** How should averages handle missing scores?

**Explanation:** Apply explicitly documented grading rules rather than guessing.

## Answer 10

**Question:** What makes the capstone complete?

**Explanation:** A tested prototype with documented requirements, validated calculations, least privilege and clear recovery strategy.
