# Practical Lab — Query Shape and User Permission

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
SELECT 10 AS class_id, 'Physics' AS class_title;
```

**Expected observation:** One fictional class row.

## 2. Make a prediction

**Question:** What would .select('id,title') in Supabase JS request?

**Expected explanation:** Only those two columns, subject to permissions and RLS.

## 3. Troubleshoot a mistake

**Scenario:** Assume the browser changes teacher_id=1 to teacher_id=2.

**Expected diagnosis:** Client filters alone cannot enforce ownership; backend RLS must reject unauthorized data.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
