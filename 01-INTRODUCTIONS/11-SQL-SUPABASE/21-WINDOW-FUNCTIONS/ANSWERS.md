# Class 21: Explained Answers

[Lesson](./README.md) | [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a window function?

**Explanation:** It computes a result across related rows while generally retaining each input row.

## Answer 2

**Question:** What does OVER mean?

**Explanation:** It defines the window specification used by a window function.

## Answer 3

**Question:** What does PARTITION BY do?

**Explanation:** It separates rows into partitions for independent calculation.

## Answer 4

**Question:** What does DESC mean?

**Explanation:** Descending ordering.

## Answer 5

**Question:** What does RANK do with ties?

**Explanation:** Equal values tie, and subsequent ranks have gaps.

## Answer 6

**Question:** What does DENSE_RANK do?

**Explanation:** Equal values tie, with no rank-number gaps.

## Answer 7

**Question:** What does ROW_NUMBER do?

**Explanation:** Assigns a distinct row number following the specified ordering.

## Answer 8

**Question:** Does window ORDER BY sort final output?

**Explanation:** No; use a query-level ORDER BY for presentation.

## Answer 9

**Question:** Why include a tie-breaker?

**Explanation:** To ensure deterministic ordering among rows with otherwise equal sort values.

## Answer 10

**Question:** What might ProTrack MX use window functions for?

**Explanation:** Rankings or per-class analysis on authorized fictional score data.
