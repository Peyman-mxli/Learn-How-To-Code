# Class 22: Explained Answers

[Lesson](./README.md) | [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is DATE?

**Explanation:** Calendar day without a time-of-day.

## Answer 2

**Question:** What is TIMESTAMP WITHOUT TIME ZONE?

**Explanation:** A local date-and-time value with no absolute instant attached.

## Answer 3

**Question:** What is TIMESTAMPTZ?

**Explanation:** A timestamp representing an instant that displays relative to a time zone.

## Answer 4

**Question:** What does AT TIME ZONE do?

**Explanation:** Converts between instant and local clock representations depending on input type.

## Answer 5

**Question:** Why use IANA names?

**Explanation:** They encode historical and applicable time-zone rules.

## Answer 6

**Question:** What is CURRENT_DATE?

**Explanation:** The current date in the session time zone.

## Answer 7

**Question:** What does now() return?

**Explanation:** The current transaction's timestamp.

## Answer 8

**Question:** Why is timezone testing important?

**Explanation:** Dates and school schedules can shift across zones or daylight-saving changes.

## Answer 9

**Question:** Is -07:00 always equivalent to America/Tijuana?

**Explanation:** No, offsets and time-zone rules differ.

## Answer 10

**Question:** What storage works for an appointment instant?

**Explanation:** Generally timestamptz, with explicit time-zone handling in display.
