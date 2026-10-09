# Class 03 — Answer Key: Querying and Filtering

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

**Review after attempting the questions.** Some open-ended answers may be phrased differently and still be correct if the core concepts are accurate.

## Answer 01

**Question:** Select just name and grade.

**Reference answer:** SELECT means begin a read query and specify output columns. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 02

**Question:** Find grades of 90 or above.

**Reference answer:** name, grade means output only these two columns. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 03

**Question:** Find active students with grade >= 80.

**Reference answer:** FROM means introduce the source table. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 04

**Question:** Sort grade high to low.

**Reference answer:** practice_students means table containing fictional student records. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 05

**Question:** Return no more than three rows.

**Reference answer:** WHERE means keep rows meeting the filter. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 06

**Question:** Identify why = NULL is wrong.

**Reference answer:** grade >= 80 means require a grade of at least 80. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 07

**Question:** Use IS NULL correctly.

**Reference answer:** AND means require both conditions to hold. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 08

**Question:** Explain COUNT(*) versus MAX(id).

**Reference answer:** active = TRUE means require a true active flag. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 09

**Question:** Explain why ordering requires ORDER BY.

**Reference answer:** ORDER BY means sort the resulting rows. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 10

**Question:** Explain why WHERE is not a security policy.

**Reference answer:** grade DESC means higher grades first. In querying and filtering, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.


## Safety Reminder

Correct-looking SQL is not necessarily secure SQL. Never use these notes alone as permission to alter the production ProTrack MX database.