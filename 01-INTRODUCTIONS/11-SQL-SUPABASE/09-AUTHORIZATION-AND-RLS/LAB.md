# Practical Lab — Access Controls Without Production Writes

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Only use fictional data in an isolated PostgreSQL/Supabase test project.** If a command refers to a temporary table, use the same connection throughout.

## 1. Try the example

```sql
SELECT current_user AS active_role, session_user AS login_role;
```

**Expected observation:** Two role labels determined by the current PostgreSQL connection.

## 2. Make a prediction

**Question:** Explain why a role in the SQL Editor may see more than an authenticated browser user.

**Expected explanation:** Privileged SQL connections can differ from user-scoped API requests.

## 3. Troubleshoot a mistake

**Scenario:** Assume a policy uses USING (user_id = auth.uid()); can Teacher A read Teacher B's row?

**Expected diagnosis:** Not under that rule when IDs differ, provided roles and the complete security configuration enforce it.

## 4. Explain the Keywords

Read the original SQL aloud in plain English. Identify the verb (SELECT, INSERT or CREATE), input data, any predicates, and the output or database changes. Explain why each part is present rather than memorizing it.

## 5. Verification

- [ ] I predicted the output.
- [ ] I can explain each keyword.
- [ ] I understand why the mistake fails or is unsafe.
- [ ] I can apply the idea without exposing real school data.

**Privacy:** Do not use real students, production tables, tokens, passwords, or privileged credentials.
