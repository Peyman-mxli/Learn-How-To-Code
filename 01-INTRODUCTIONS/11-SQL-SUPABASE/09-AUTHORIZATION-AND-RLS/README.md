# Class 09 — Authorization, Grants, and Row Level Security

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Enforce which educator may read or update which data—not just who can log in. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
ALTER TABLE public.demo_teacher_profiles ENABLE ROW LEVEL SECURITY;
CREATE POLICY demo_profiles_select_own ON public.demo_teacher_profiles FOR SELECT TO authenticated USING (user_id = (SELECT auth.uid()));
```

**Plain-English summary:** Enforce which educator may read or update which data—not just who can log in.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `ALTER TABLE` | Change a table's configuration. |
| `ENABLE ROW LEVEL SECURITY` | Turn on row-level policy filtering. |
| `CREATE POLICY` | Define an access-control policy. |
| `FOR SELECT` | Policy applies to reads. |
| `TO authenticated` | Scope policy to the signed-in database role. |
| `USING` | Predicate deciding readable rows. |
| `auth.uid()` | Return the current authenticated user's ID. |
| `user_id = ...` | Allow rows matching that identity. |

### Read the query in order

1. **`ALTER TABLE`** — Change a table's configuration.
2. **`ENABLE ROW LEVEL SECURITY`** — Turn on row-level policy filtering.
3. **`CREATE POLICY`** — Define an access-control policy.
4. **`FOR SELECT`** — Policy applies to reads.
5. **`TO authenticated`** — Scope policy to the signed-in database role.
6. **`USING`** — Predicate deciding readable rows.
7. **`auth.uid()`** — Return the current authenticated user's ID.
8. **`user_id = ...`** — Allow rows matching that identity.

## 4. A Second Example and More Syntax

```sql
REVOKE ALL ON public.demo_teacher_profiles FROM anon;
GRANT SELECT ON public.demo_teacher_profiles TO authenticated;

-- GRANT controls table-level privilege; RLS controls which rows.
-- For INSERT/UPDATE, appropriate WITH CHECK / USING policies are also needed.
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

Never copy this snippet blindly to production. Other policies, roles, schema grants, security-definer functions, BYPASSRLS roles, and service keys can change access. Test permitted and forbidden operations using normal user sessions, not just the SQL Editor.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **ALTER TABLE**: Change a table's configuration.
- **ENABLE ROW LEVEL SECURITY**: Turn on row-level policy filtering.
- **CREATE POLICY**: Define an access-control policy.
- **FOR SELECT**: Policy applies to reads.
- **TO authenticated**: Scope policy to the signed-in database role.
- **USING**: Predicate deciding readable rows.
- **auth.uid()**: Return the current authenticated user's ID.
- **user_id = ...**: Allow rows matching that identity.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Define authorization.
2. Define GRANT.
3. Define REVOKE.
4. Define RLS.
5. Explain ENABLE ROW LEVEL SECURITY.
6. Explain CREATE POLICY.
7. Explain USING.
8. Explain WITH CHECK.
9. Explain auth.uid().
10. Explain why SQL Editor testing is insufficient.

Answer one question at a time. The separate [QUESTIONS.md](./QUESTIONS.md) provides a printable set, and [ANSWERS.md](./ANSWERS.md) provides explanations for self-review.

## 10. Lesson Completion Checklist

- [ ] I can explain every keyword in the worked example.
- [ ] I can describe what the query changes or returns.
- [ ] I understand the limitations of the example.
- [ ] I can identify the risks of running it in production.
- [ ] I have attempted all ten questions before reading answers.

## 11. References

- [PostgreSQL SQL Documentation](https://www.postgresql.org/docs/current/sql.html)
- [PostgreSQL Tutorial](https://www.postgresql.org/docs/current/tutorial.html)
- [Supabase Documentation](https://supabase.com/docs)
- [Supabase Row Level Security](https://supabase.com/docs/guides/database/postgres/row-level-security)

**Course sequencing:** Continue to the next numbered class only when this lesson is understood.