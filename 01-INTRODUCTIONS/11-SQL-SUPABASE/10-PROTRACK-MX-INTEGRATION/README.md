# Class 10 — Integrating ProTrack MX with Supabase

**SQL & Supabase Learning Journey** · Final class · English documentation

[Course Home](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## 1. Learning Goals

Bring together PostgreSQL, SQL, Supabase Auth, permissions, RLS, and the client SDK to explain an end-to-end educational web application workflow. **This lesson is a design guide, not production deployment instructions.** Table examples are illustrative, not the verified schema of ProTrack MX.

## 2. Frontend vs Backend

The **frontend** contains the screens that teachers use: login, student rosters, grades, and configurable evaluation settings.

The **backend** includes authentication, authorized data access, validation, persistence, and services that the frontend calls.

A typical route is:

```text
Teacher -> ProTrack MX UI -> authenticated Supabase API request
        -> PostgreSQL grants + RLS -> permitted rows -> UI
```

The frontend is *not* a trusted security boundary. An attacker can change a browser request.

## 3. Main SQL Example: Every Word Explained

```sql
SELECT id, title
FROM public.demo_classes
WHERE teacher_id = 7
ORDER BY title;
```

| Part | Meaning | Why it exists |
| --- | --- | --- |
| SELECT | Request data | Read instead of changing rows |
| id, title | Two result columns | Keep the result focused |
| FROM | Source table follows | Specify the table to read |
| public | PostgreSQL schema | Qualify which namespace |
| . | Schema/table separator | Write a qualified name |
| demo_classes | Fictional class table | Name the data source |
| WHERE | Filter matching rows | Limit query results |
| teacher_id = 7 | Equality condition | Demonstrate filtering, not security |
| ORDER BY title | Sort output by title | Make the display predictable for differing titles |
| ; | End statement | Separate SQL statements |

**Critical:** `WHERE teacher_id = 7` is *not* an access-control mechanism. Users can modify filters. RLS must independently enforce who is allowed to read classes.

## 4. JavaScript Client Example

This example assumes `supabase` is an initialized Supabase JavaScript client and that suitable tables, grants, and RLS policies already exist in a **test environment**:

```javascript
const { data: userResult, error: userError } =
  await supabase.auth.getUser();

if (userError || !userResult.user) {
  throw new Error("Sign in is required.");
}

const { data: classes, error: classesError } =
  await supabase
    .from("classes")
    .select("id, title");

if (classesError) {
  throw new Error("Unable to load your classes.");
}

console.log(classes);
```

### Every Important JavaScript Piece

| Expression | Meaning |
| --- | --- |
| const | Declare a variable whose binding cannot be reassigned |
| await | Wait for an asynchronous operation |
| supabase.auth.getUser() | Retrieve the authenticated user via Supabase Auth |
| data / error | Returned success data and possible error |
| if | Branch based on a condition |
| throw new Error(...) | Stop that flow with an error |
| .from("classes") | Identify a table via the client SDK |
| .select("id, title") | Request specific columns |
| console.log | Print a value for developer inspection; don't print private production data |

This is a minimal **teaching example**, not complete frontend code. Avoid leaking sensitive error details to end users.

## 5. Authentication and Authorization

**Authentication:** identify the teacher using a supported sign-in mechanism. Handle sessions securely.

**Authorization:** verify which classes, students, and grades the teacher is allowed to access. PostgreSQL grants and RLS are part of the enforcement model. The Auth login does not automatically provide access to everyone else's records.

## 6. Example Data Model

A plausible educational model can include `teachers`, `students`, `classes`, `enrollments`, `assessment_criteria`, `assessments`, and `grades`. This is **not a claim about the actual ProTrack MX schema**.

For configurable evaluation weights, a related set of records might include:

| Example field | Meaning |
| --- | --- |
| class_id | Which class owns the criteria |
| period_id | Which trimester/period |
| criterion_name | Homework, project, examination |
| weight | The percentage assigned to the criterion |
| student_id | Student whose assessment is being calculated |
| score | Score for an assessment |

Validate total weights and protect teacher/class ownership when updating criteria or scores. Weighted averages should be computed from an intentionally defined formula with explicit handling of missing grades.

## 7. Security and Data Protection Checklist

- Separate development/testing and production Supabase projects.
- Store keys with the right level of secrecy; browser-safe publishable keys are not the same as service-role/secret credentials.
- Never put database passwords, service-role keys, or real student data in GitHub.
- Enable and test appropriate RLS policies on API-exposed tables.
- Use least-privilege grants and validate all role paths.
- Test with two ordinary teacher accounts: allowed and forbidden reads, inserts, and updates.
- Plan backups, migrations, and rollback/recovery.
- Handle failed operations and loading states.
- Follow local privacy and school-data rules.
- Review how assessment criteria and student results are associated before release.

## 8. Failure Modes

A query that works in the SQL Editor may fail for an ordinary user because the editor can run with greater privileges. Conversely, an overly permissive policy may expose records. Both success and denial cases must be tested with realistic user sessions.

Do not assume frontend filtering is a substitute for RLS. Do not assume that merely using Supabase makes the application secure.

## 9. Review Exercises

1. What is the frontend?
2. What is the backend?
3. What does the Supabase client SDK do?
4. What is the role of a login session?
5. Why is a frontend WHERE teacher_id filter not authorization?
6. Where should service-role or secret keys be stored?
7. How should app errors be handled?
8. How might configurable grading criteria be modeled?
9. What must be reviewed before a production release?
10. Describe an end-to-end flow to show a teacher's classes.

Work through [QUESTIONS.md](./QUESTIONS.md) one at a time. Review [ANSWERS.md](./ANSWERS.md) afterward.

## 10. Capstone Design Exercise

Without touching production, draw a small diagram for a teacher who logs in, views classes, edits an evaluation criterion, and views a student's trimester average. For each step, specify: UI action, backend request, relevant tables, authorization check, validation, and failure behavior.

## 11. Final Takeaways

SQL expresses database operations. PostgreSQL executes SQL and enforces table constraints. Supabase provides managed backend services, including Auth and data APIs. A trustworthy app ties these together with secure permission checks and carefully designed data models.

## Official References

- [Supabase Docs](https://supabase.com/docs)
- [Supabase JavaScript SDK](https://supabase.com/docs/reference/javascript/introduction)
- [Supabase Auth](https://supabase.com/docs/guides/auth)
- [Supabase RLS](https://supabase.com/docs/guides/database/postgres/row-level-security)
- [PostgreSQL Docs](https://www.postgresql.org/docs/)
