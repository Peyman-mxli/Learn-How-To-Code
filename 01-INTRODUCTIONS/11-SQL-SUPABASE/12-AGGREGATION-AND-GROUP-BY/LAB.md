# Practical Lab — COUNT Versus AVG

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
CREATE TEMP TABLE lab_scores(id int,group_id int,score numeric);
INSERT INTO lab_scores VALUES(1,1,80),(2,1,100),(3,2,NULL);
SELECT group_id,COUNT(*) AS total,COUNT(score) AS graded,AVG(score) AS mean FROM lab_scores GROUP BY group_id ORDER BY group_id;
```

**Expected observation:** Group 1: total 2, graded 2, mean 90. Group 2: total 1, graded 0, mean NULL.

## 2. Make a prediction

**Question:** Why is NULL excluded from AVG?

**Expected explanation:** AVG operates on non-NULL inputs.

## 3. Troubleshoot a mistake

**Scenario:** Replace GROUP BY with nothing while selecting group_id.

**Expected diagnosis:** The nonaggregated group_id must be grouped or aggregated; PostgreSQL will reject the query.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
