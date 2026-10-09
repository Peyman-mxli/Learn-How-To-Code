# Class 03 — Querying and Filtering

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Learn to choose precisely which records appear on a class or grade screen. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
SELECT name, grade FROM practice_students WHERE grade >= 80 AND active = TRUE ORDER BY grade DESC LIMIT 5;
```

**Plain-English summary:** Learn to choose precisely which records appear on a class or grade screen.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `SELECT` | Begin a read query and specify output columns. |
| `name, grade` | Output only these two columns. |
| `FROM` | Introduce the source table. |
| `practice_students` | Table containing fictional student records. |
| `WHERE` | Keep rows meeting the filter. |
| `grade >= 80` | Require a grade of at least 80. |
| `AND` | Require both conditions to hold. |
| `active = TRUE` | Require a true active flag. |
| `ORDER BY` | Sort the resulting rows. |
| `grade DESC` | Higher grades first. |
| `LIMIT 5` | Return at most five rows. |
| `;` | Finish the SQL statement. |

### Read the query in order

1. **`SELECT`** — Begin a read query and specify output columns.
2. **`name, grade`** — Output only these two columns.
3. **`FROM`** — Introduce the source table.
4. **`practice_students`** — Table containing fictional student records.
5. **`WHERE`** — Keep rows meeting the filter.
6. **`grade >= 80`** — Require a grade of at least 80.
7. **`AND`** — Require both conditions to hold.
8. **`active = TRUE`** — Require a true active flag.
9. **`ORDER BY`** — Sort the resulting rows.
10. **`grade DESC`** — Higher grades first.
11. **`LIMIT 5`** — Return at most five rows.
12. **`;`** — Finish the SQL statement.

## 4. A Second Example and More Syntax

```sql
SELECT name FROM practice_students WHERE grade IS NULL;
SELECT COUNT(*) FROM practice_students;
SELECT name FROM practice_students ORDER BY name ASC;
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

NULL is checked with IS NULL rather than = NULL. Without ORDER BY, result row order is unspecified. WHERE filters rows; it does not automatically enforce who may access them.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **SELECT**: Begin a read query and specify output columns.
- **name, grade**: Output only these two columns.
- **FROM**: Introduce the source table.
- **practice_students**: Table containing fictional student records.
- **WHERE**: Keep rows meeting the filter.
- **grade >= 80**: Require a grade of at least 80.
- **AND**: Require both conditions to hold.
- **active = TRUE**: Require a true active flag.
- **ORDER BY**: Sort the resulting rows.
- **grade DESC**: Higher grades first.
- **LIMIT 5**: Return at most five rows.
- **;**: Finish the SQL statement.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Select just name and grade.
2. Find grades of 90 or above.
3. Find active students with grade >= 80.
4. Sort grade high to low.
5. Return no more than three rows.
6. Identify why = NULL is wrong.
7. Use IS NULL correctly.
8. Explain COUNT(*) versus MAX(id).
9. Explain why ordering requires ORDER BY.
10. Explain why WHERE is not a security policy.

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