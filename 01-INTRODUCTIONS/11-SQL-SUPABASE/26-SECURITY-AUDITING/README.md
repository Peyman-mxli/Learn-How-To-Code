# Class 26 — Security Auditing and Least Privilege

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning goals

Explain each command, identify its role in safe ProTrack MX development, practice the example in a separate test environment, and pass ten comprehension questions.

## 1. Main example

```sql
SELECT grantee, privilege_type
FROM information_schema.role_table_grants
WHERE table_schema = 'public'
  AND table_name = 'lab_students';
```

## 2. Word-by-word explanations

| Term | Meaning and purpose |
|---|---|
| `information_schema` | Standard metadata views available in PostgreSQL. |
| `role_table_grants` | View showing table privileges. |
| `grantee` | Role that has the reported privilege. |
| `privilege_type` | Kind of granted privilege. |
| `WHERE` | Filter metadata records. |
| `AND` | Require both predicates. |

### Read the statement line by line

1. **information_schema:** Standard metadata views available in PostgreSQL.
2. **role_table_grants:** View showing table privileges.
3. **grantee:** Role that has the reported privilege.
4. **privilege_type:** Kind of granted privilege.
5. **WHERE:** Filter metadata records.
6. **AND:** Require both predicates.

## 3. Additional working example

```sql
-- Review RLS status in a test database:
SELECT schemaname, tablename, rowsecurity
FROM pg_tables
WHERE schemaname = 'public';
```

Read the code from left to right. Identify which objects it touches, whether it changes data, and what happens if its inputs do not match expected rows.

## 4. ProTrack MX practice

Use fictional teachers, students and periods to describe the appropriate purpose of the operation. The sample names are not verified database objects in the actual app. Discuss privileges, user identity and RLS before proposing an operation on any school records.

## 5. Important caveats

Metadata checks alone do not prove security. Roles may inherit privileges and certain roles can bypass RLS. Test effective authorization as actual distinct user accounts, and never publish keys, tokens or private audit logs.

## 6. Review questions

1. What is least privilege?
2. What is a GRANT?
3. What is REVOKE?
4. What does information_schema provide?
5. What does grantee mean?
6. What is RLS?
7. Can a privileged role bypass RLS?
8. Why test denial cases?
9. Why avoid logging student data?
10. What is security auditing?

Complete [QUESTIONS.md](./QUESTIONS.md) one question at a time; check [ANSWERS.md](./ANSWERS.md) afterward.

## 7. Completion criteria

- [ ] Explain the main statement without copying.
- [ ] Explain the additional example and differences.
- [ ] Describe at least two security or correctness risks.
- [ ] Attempt all ten questions independently.

## Further reading

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
