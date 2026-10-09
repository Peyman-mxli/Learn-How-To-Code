# Class 28 — Answers Explained

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** Why paginate?

**Correct answer:** To avoid returning very large record sets in a single request.

## Answer 2

**Question:** What does LIMIT do?

**Correct answer:** Sets a maximum row count.

## Answer 3

**Question:** What does OFFSET do?

**Correct answer:** Skips preceding ordered rows.

## Answer 4

**Question:** Why is ORDER BY important?

**Correct answer:** It defines deterministic pagination order.

## Answer 5

**Question:** What is keyset pagination?

**Correct answer:** Fetching subsequent rows based on a remembered ordered key rather than a count-based offset.

## Answer 6

**Question:** What is a cursor?

**Correct answer:** A reference key or position representing where pagination resumes.

## Answer 7

**Question:** What happens when records change during offset paging?

**Correct answer:** Rows may shift between pages, creating skips or duplicates.

## Answer 8

**Question:** Does pagination replace authorization?

**Correct answer:** No; RLS and privileges must still protect rows.

## Answer 9

**Question:** Why select only needed columns?

**Correct answer:** To minimize bandwidth and exposure of unnecessary fields.

## Answer 10

**Question:** What is rate limiting?

**Correct answer:** Restricting request frequency to protect resources and availability.
