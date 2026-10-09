# Class 27 — Answers Explained

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is an evaluation criterion?

**Correct answer:** A category such as projects, homework or exams used in grading.

## Answer 2

**Question:** What does weight represent?

**Correct answer:** The percent contribution assigned to a criterion.

## Answer 3

**Question:** Why use numeric for weights?

**Correct answer:** To preserve precise decimal arithmetic.

## Answer 4

**Question:** What does CHECK(weight >= 0 AND weight <= 100) ensure?

**Correct answer:** Each non-NULL weight falls inside the valid range.

## Answer 5

**Question:** Does that CHECK make total weights equal 100?

**Correct answer:** No; it only validates individual rows.

## Answer 6

**Question:** What does SUM do?

**Correct answer:** Adds numeric values across selected rows.

## Answer 7

**Question:** What is a weighted grade?

**Correct answer:** The sum of each normalized score multiplied by its relative weight.

## Answer 8

**Question:** Why define missing-score rules?

**Correct answer:** Because skipped scores, zeros and unknown values have different meanings.

## Answer 9

**Question:** Why round only at deliberate steps?

**Correct answer:** Premature rounding can distort totals.

## Answer 10

**Question:** What is required before applying grade changes?

**Correct answer:** Validate inputs, authorization, period ownership, and consistent total weights.
