# Practical Lab — CTE Scope

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
WITH sample AS (SELECT 80 AS score UNION ALL SELECT 90)
SELECT AVG(score) AS mean_score FROM sample;
```

**Expected observation:** mean_score = 85.

## 2. Make a prediction

**Question:** Use SELECT 1 WHERE 90 > (SELECT AVG(score) FROM (VALUES (80),(90)) AS x(score));

**Expected explanation:** Returns one row containing 1.

## 3. Troubleshoot a mistake

**Scenario:** Try SELECT * FROM sample; in a separate statement.

**Expected diagnosis:** The CTE only exists during its defining statement; relation sample is not available afterward.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
