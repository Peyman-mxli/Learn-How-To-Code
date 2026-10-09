# Class 08 — Authentication and User Profiles

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Understand signing in, sessions, identity IDs, and app-specific teacher profiles. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
CREATE TABLE public.demo_teacher_profiles (
  user_id UUID PRIMARY KEY REFERENCES auth.users(id) ON DELETE CASCADE,
  display_name TEXT NOT NULL
);
```

**Plain-English summary:** Understand signing in, sessions, identity IDs, and app-specific teacher profiles.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `CREATE TABLE` | Make a profile table. |
| `public.demo_teacher_profiles` | Profile table in the public schema. |
| `user_id UUID` | Use a UUID for the identity reference. |
| `PRIMARY KEY` | Allow one profile per user ID. |
| `REFERENCES auth.users(id)` | Link to the Supabase Auth users table. |
| `ON DELETE CASCADE` | Delete the related profile if the referenced user is removed. |
| `display_name TEXT NOT NULL` | Required profile display name. |

### Read the query in order

1. **`CREATE TABLE`** — Make a profile table.
2. **`public.demo_teacher_profiles`** — Profile table in the public schema.
3. **`user_id UUID`** — Use a UUID for the identity reference.
4. **`PRIMARY KEY`** — Allow one profile per user ID.
5. **`REFERENCES auth.users(id)`** — Link to the Supabase Auth users table.
6. **`ON DELETE CASCADE`** — Delete the related profile if the referenced user is removed.
7. **`display_name TEXT NOT NULL`** — Required profile display name.

## 4. A Second Example and More Syntax

```sql
-- Conceptual Supabase JS client usage:
const { data, error } = await supabase.auth.signInWithPassword({
  email: 'teacher@example.test',
  password: 'example-password'
});
// Never use real passwords in source code.

// With RLS, a common policy condition is:
-- user_id = (SELECT auth.uid())
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

The profile CREATE TABLE example is intentionally incomplete as a deployable app: review RLS, grants, policies and lifecycle handling first. Never store passwords in profile tables. Login success alone does not authorize accessing any class.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **CREATE TABLE**: Make a profile table.
- **public.demo_teacher_profiles**: Profile table in the public schema.
- **user_id UUID**: Use a UUID for the identity reference.
- **PRIMARY KEY**: Allow one profile per user ID.
- **REFERENCES auth.users(id)**: Link to the Supabase Auth users table.
- **ON DELETE CASCADE**: Delete the related profile if the referenced user is removed.
- **display_name TEXT NOT NULL**: Required profile display name.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Define authentication.
2. Differentiate profile from auth user.
3. Explain UUID.
4. Explain auth.users.
5. Explain a session.
6. Explain sign-in.
7. Explain auth.uid().
8. Explain password handling.
9. Explain RLS for profiles.
10. Distinguish authentication from authorization.

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