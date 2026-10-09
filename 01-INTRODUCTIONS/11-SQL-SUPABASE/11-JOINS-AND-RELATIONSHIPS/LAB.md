# Practical Lab — Joining Teachers to Classes

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
CREATE TEMP TABLE lab_a(id int PRIMARY KEY,name text);
CREATE TEMP TABLE lab_b(id int PRIMARY KEY,teacher_id int REFERENCES lab_a(id),title text);
INSERT INTO lab_a VALUES(1,'Ali'),(2,'Sara');
INSERT INTO lab_b VALUES(10,1,'Physics');
SELECT a.name,b.title FROM lab_a a JOIN lab_b b ON a.id=b.teacher_id;
```

**Expected observation:** One row: Ali, Physics.

## 2. Make a prediction

**Question:** Use LEFT JOIN from lab_a to lab_b.

**Expected explanation:** Two teachers appear; Sara has NULL title.

## 3. Troubleshoot a mistake

**Scenario:** Remove ON from JOIN (do not execute).

**Expected diagnosis:** An invalid join form or unintended cross-product can occur; always specify intended relationship.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
