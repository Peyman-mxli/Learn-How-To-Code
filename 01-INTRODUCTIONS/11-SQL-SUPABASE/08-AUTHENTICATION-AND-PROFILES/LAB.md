# Practical Lab — Auth Versus Profile

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
SELECT 'demo-user'::text AS username, 'teacher'::text AS role_label;
```

**Expected observation:** One fictional identity row, not a real authentication event.

## 2. Make a prediction

**Question:** What does a profile store that an Auth service does not necessarily store?

**Expected explanation:** A profile stores app-specific display information, not the password.

## 3. Troubleshoot a mistake

**Scenario:** Try placing a password in a public profile table.

**Expected diagnosis:** This is unsafe; passwords belong to managed authentication flows, not an app profile column.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
