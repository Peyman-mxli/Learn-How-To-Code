# Practical Lab — Duplicate ID Handling

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
CREATE TEMP TABLE lab_upsert(id int PRIMARY KEY,label text);
INSERT INTO lab_upsert VALUES(1,'Old');
INSERT INTO lab_upsert VALUES(1,'New') ON CONFLICT(id) DO UPDATE SET label=EXCLUDED.label;
SELECT * FROM lab_upsert;
```

**Expected observation:** One row: (1,New).

## 2. Make a prediction

**Question:** INSERT INTO lab_upsert VALUES(1,'Other') ON CONFLICT(id) DO NOTHING;
SELECT label FROM lab_upsert;

**Expected explanation:** Label stays New.

## 3. Troubleshoot a mistake

**Scenario:** Try an ordinary duplicate INSERT without ON CONFLICT.

**Expected diagnosis:** Unique constraint error; UPSERT only handles conflicts when explicitly requested.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
