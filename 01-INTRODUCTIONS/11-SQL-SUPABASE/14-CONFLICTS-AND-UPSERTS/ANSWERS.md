# Class 14 — Answer Key

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is an UPSERT?

**Correct explanation:** An INSERT that updates or does nothing when a specified uniqueness conflict occurs.

## Answer 2

**Question:** What does ON CONFLICT detect?

**Correct explanation:** A qualifying uniqueness or exclusion constraint conflict.

## Answer 3

**Question:** What does DO UPDATE mean?

**Correct explanation:** Update the conflicting existing row.

## Answer 4

**Question:** What does EXCLUDED.weight represent?

**Correct explanation:** The proposed incoming row's weight value.

## Answer 5

**Question:** What does RETURNING do?

**Correct explanation:** Return requested values from rows inserted or updated.

## Answer 6

**Question:** What is DO NOTHING?

**Correct explanation:** Skip the row on conflict rather than erroring.

## Answer 7

**Question:** Does UPSERT ignore CHECK constraints?

**Correct explanation:** No, remaining applicable constraints still apply.

## Answer 8

**Question:** Why specify conflict target?

**Correct explanation:** To define which conflict should trigger the chosen handling.

## Answer 9

**Question:** What happens without ON CONFLICT on duplicate PK?

**Correct explanation:** The INSERT fails with a uniqueness violation.

## Answer 10

**Question:** What security is needed?

**Correct explanation:** Suitable INSERT/UPDATE privileges and policies for the intended access paths.


**Always practice with fictional records in a development database.**