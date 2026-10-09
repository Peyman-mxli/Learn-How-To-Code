# Class 17 — Explained Answers: SQL Functions and Triggers

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a SQL function?

**Explanation:** A named reusable database routine returning declared results.

## Answer 2

**Question:** What does RETURNS mean?

**Explanation:** It declares the function's result type.

## Answer 3

**Question:** What does LANGUAGE sql indicate?

**Explanation:** The function body is parsed as SQL.

## Answer 4

**Question:** What does $$ mean?

**Explanation:** A dollar-quoted string delimiter for a function body.

## Answer 5

**Question:** How do you call a function?

**Explanation:** Use its name with parentheses in an appropriate SQL expression.

## Answer 6

**Question:** What is a trigger?

**Explanation:** A rule that invokes a trigger function when a specified table event occurs.

## Answer 7

**Question:** What does BEFORE UPDATE mean?

**Explanation:** Run the trigger logic before a row is updated.

## Answer 8

**Question:** What does NEW mean in a row trigger?

**Explanation:** The proposed new row available to the trigger function.

## Answer 9

**Question:** Why RETURN NEW?

**Explanation:** For a BEFORE ROW trigger, return the row to proceed with the modified values.

## Answer 10

**Question:** What security issues apply?

**Explanation:** Execution privileges and SECURITY DEFINER, role rights and search_path require review.


Always consider validation, authorization, and production-data safety.