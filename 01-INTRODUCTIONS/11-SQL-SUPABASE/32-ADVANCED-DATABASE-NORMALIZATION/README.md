# Class 32 — Normalization, Functional Dependencies, and Constraints

[Course roadmap](../README.md) · [Practice questions](./QUESTIONS.md) · [Answer key](./ANSWERS.md)

## Objective

Explain the commands and symbols in simple English, predict their behavior, understand mistakes, and transfer the ideas to a fictional ProTrack MX learning environment. Prerequisites: previous classes.

## 1. Setup / context

```sql
CREATE TABLE lab_teachers_normal (id integer PRIMARY KEY, name text NOT NULL);
CREATE TABLE lab_courses_normal (id integer PRIMARY KEY, teacher_id integer REFERENCES lab_teachers_normal(id), title text NOT NULL);
```

Use a separate, disposable development environment. Examples are instructional and are not verified against the production ProTrack MX schema.

## 2. Main example

```sql
CREATE TABLE lab_enrollments_normal (
 student_id integer NOT NULL,
 course_id integer NOT NULL REFERENCES lab_courses_normal(id),
 enrolled_on date NOT NULL DEFAULT CURRENT_DATE,
 PRIMARY KEY (student_id,course_id)
);
```

## 3. Explain every important keyword

| Keyword or phrase | English meaning and role |
|---|---|
| `CREATE TABLE` | Define a new relation. |
| `NOT NULL` | Reject absent values. |
| `REFERENCES` | Require a valid referenced parent key. |
| `DEFAULT` | Provide value when omitted. |
| `CURRENT_DATE` | Date in session time zone. |
| `PRIMARY KEY (student_id,course_id)` | Together the two columns uniquely identify an enrollment. |
| `date` | Calendar date type. |

### Read the example in order

1. **CREATE TABLE:** Define a new relation.
2. **NOT NULL:** Reject absent values.
3. **REFERENCES:** Require a valid referenced parent key.
4. **DEFAULT:** Provide value when omitted.
5. **CURRENT_DATE:** Date in session time zone.
6. **PRIMARY KEY (student_id,course_id):** Together the two columns uniquely identify an enrollment.
7. **date:** Calendar date type.

## 4. Additional example

```sql
-- A single student name repeated in every grade row creates update anomalies.
-- Normalize teacher, class, student, and enrollment entities into dedicated relations.
```

Explain how this second example differs, why it matters, and any expected result or error. A code sample is not an instruction to run it against live data.

## 5. ProTrack MX applied scenario

Assume fictional teachers, students, evaluation criteria, and academic periods. Describe how the new concept helps build a reliable and privacy-preserving educational backend. Identify what user authorization checks and validations should happen before using real data.

## 6. Common mistakes and important caveats

Normalization improves consistency but does not automatically make an application secure; schema decisions should reflect actual business rules.

Never commit passwords, access tokens, secret keys, or real student records to a public repository. Prefer test accounts and a separate Supabase development project.

## 7. Ten review exercises

1. What is normalization?
2. What is a functional dependency?
3. What is 1NF?
4. What is 2NF?
5. What is 3NF?
6. What is an update anomaly?
7. What is an insertion anomaly?
8. What is a deletion anomaly?
9. Why a composite primary key?
10. When should denormalization be considered?

Work through [QUESTIONS.md](./QUESTIONS.md) **one at a time**. Use [ANSWERS.md](./ANSWERS.md) to check your understanding, not to memorize blindly.

## 8. Completion checklist

- [ ] I can explain all important keywords.
- [ ] I can describe the main example in my own words.
- [ ] I can distinguish safe test use from production use.
- [ ] I can explain relevant mistakes and permission boundaries.
- [ ] I completed the ten questions.

## Authoritative references

- [PostgreSQL documentation](https://www.postgresql.org/docs/current/)
- [Supabase documentation](https://supabase.com/docs)
- [Supabase local development](https://supabase.com/docs/guides/local-development)
