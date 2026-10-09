# Class 05 — Relational Design and Relationships

**Course:** SQL & Supabase Learning Journey | **Case study:** ProTrack MX | **Level:** Beginner to intermediate

[Course Home](../README.md) · [10 Questions](./QUESTIONS.md) · [Answer Key](./ANSWERS.md)

## Lesson Goals

Model teachers, students, classes, enrollments, assessments, and grades without unnecessary duplication. By the end of this lesson, explain each keyword, read the example SQL accurately, identify relevant failure and security risks, and answer ten practice questions without copying.

**Prerequisites:** Earlier numbered classes. **Safety:** All scenarios are fictional; never run tutorial SQL or expose real records in the ProTrack MX production database.

## 1. Why This Topic Matters

ProTrack MX may handle classes, teachers, student records, assessment criteria, and grades. Correctly designed backend behavior requires understanding what each SQL statement does, how PostgreSQL processes it, and how Supabase exposes authorized results to an application. These table names are examples, not verified production schema.

## 2. Main Worked Example

```sql
CREATE TABLE demo_teachers (id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY, name TEXT NOT NULL);
CREATE TABLE demo_classes (id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY, teacher_id INTEGER NOT NULL REFERENCES demo_teachers(id), title TEXT NOT NULL);
```

**Plain-English summary:** Model teachers, students, classes, enrollments, assessments, and grades without unnecessary duplication.

## 3. Explain Every Keyword and Symbol

| Token or phrase | Meaning / reason for using it |
| --- | --- |
| `CREATE TABLE` | Create a new relation. |
| `demo_teachers` | Parent table storing teachers. |
| `id INTEGER` | Numeric identifier. |
| `GENERATED ALWAYS AS IDENTITY` | Generate the id using a sequence. |
| `PRIMARY KEY` | Ensure unique non-NULL identifiers. |
| `demo_classes` | Child table storing classes. |
| `teacher_id` | Column that identifies a teacher. |
| `REFERENCES demo_teachers(id)` | Foreign key requiring a referenced teacher. |
| `title TEXT NOT NULL` | Non-NULL class title. |

### Read the query in order

1. **`CREATE TABLE`** — Create a new relation.
2. **`demo_teachers`** — Parent table storing teachers.
3. **`id INTEGER`** — Numeric identifier.
4. **`GENERATED ALWAYS AS IDENTITY`** — Generate the id using a sequence.
5. **`PRIMARY KEY`** — Ensure unique non-NULL identifiers.
6. **`demo_classes`** — Child table storing classes.
7. **`teacher_id`** — Column that identifies a teacher.
8. **`REFERENCES demo_teachers(id)`** — Foreign key requiring a referenced teacher.
9. **`title TEXT NOT NULL`** — Non-NULL class title.

## 4. A Second Example and More Syntax

```sql
CREATE TABLE demo_enrollments (
  student_id INTEGER NOT NULL REFERENCES demo_students(id),
  class_id INTEGER NOT NULL REFERENCES demo_classes(id),
  PRIMARY KEY (student_id, class_id)
);

-- This assumes demo_students was created separately.
```

The extra commands illustrate adjacent concepts, not steps to run on a production server. Read the comments carefully and note which technology interprets each code fragment (PostgreSQL for SQL, JavaScript runtime for Supabase SDK examples).

## 5. ProTrack MX Application Example

Imagine a teacher using an educational application to inspect their own classes and student evaluations. Their screen should show only appropriate records, requested through an authorized application flow. This lesson's code is a deliberately simplified study model. The real solution also needs suitable data types, constraints, user-session management, role permissions, tested row-level security, and safe error handling.

## 6. Common Mistakes and Safety Risks

The referenced table must exist before creating its foreign key. A foreign key is not automatic authorization. Design enrollment as a join table for many-to-many membership, and define deletion behavior intentionally.

Additional rules: avoid using real student names in practice; avoid committing passwords, database URLs containing credentials, tokens or secret keys; separate test and production projects; carefully review SQL that modifies data or permissions.

## 7. Vocabulary Review

- **CREATE TABLE**: Create a new relation.
- **demo_teachers**: Parent table storing teachers.
- **id INTEGER**: Numeric identifier.
- **GENERATED ALWAYS AS IDENTITY**: Generate the id using a sequence.
- **PRIMARY KEY**: Ensure unique non-NULL identifiers.
- **demo_classes**: Child table storing classes.
- **teacher_id**: Column that identifies a teacher.
- **REFERENCES demo_teachers(id)**: Foreign key requiring a referenced teacher.
- **title TEXT NOT NULL**: Non-NULL class title.

## 8. Learn by Teaching Back

Without looking at the table above, explain the worked example to a beginner in your own words. Describe the operation, table involved, expected effect, possible error, and security implications. Explain why each important keyword exists.

## 9. Exercises

1. Define primary key.
2. Define foreign key.
3. Explain one-to-many.
4. Explain many-to-many.
5. Choose a join table for enrollments.
6. Explain composite primary keys.
7. Explain referential integrity.
8. Explain why duplicate data is risky.
9. Explain why a foreign key is not authorization.
10. Outline a classes-and-students relationship.

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