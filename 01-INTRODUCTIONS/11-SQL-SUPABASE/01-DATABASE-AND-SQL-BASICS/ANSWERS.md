# Class 01 — SQL & Supabase Basics: Answer Key

**Course:** SQL & Supabase Learning Journey  
**Project context:** ProTrack MX  
**Class:** 01 — Introduction to Databases and SQL  
**Related document:** [10 Quiz Questions](./QUESTIONS.md)

> Review this file **after** attempting all 10 questions. Examples use fictional data.

---

## Answer Summary

| Question | Correct answer | Topic |
| --- | --- | --- |
| 01 | **A** | SELECT a column |
| 02 | **A** | Row vs. column |
| 03 | **B** | SQL vs. PostgreSQL vs. Supabase |
| 04 | **B** | SELECT specific columns |
| 05 | **B** | SELECT * |
| 06 | **C** | Authentication vs. authorization |
| 07 | **B** | Querying an absent table |
| 08 | **SQL statement** | `SELECT id, name FROM students;` (or reversed columns) |
| 09 | **C** | Production data safety |
| 10 | **SQL statement** | `SELECT name FROM students;` |

---

## Question 01 — Correct Answer: A

```sql
SELECT name FROM students;
```

**Why:** `SELECT` requests data, `name` specifies the desired column, and `FROM students` identifies the source table. If the table has 100 accessible rows, this query normally returns 100 name values, including repeated or NULL names where permitted. With permission controls, visibility can differ.

- **B is wrong:** SELECT does not create records.
- **C is wrong:** SELECT does not delete records.

**Key lesson:** A read query retrieves information without modifying those records.

## Question 02 — Correct Answer: A

A **row** represents one complete record. A **column** represents a field shared across records.

In the example, `(2, Sara, 88)` is one row, while `grade` is a column. The cell containing `88` is a value.

- **B is wrong:** The table has its own name, and no single column represents the entire database.
- **C is wrong:** Rows and columns represent different structural dimensions.

**Key lesson:** Row = record; column = field.

## Question 03 — Correct Answer: B

- **SQL:** Structured Query Language, used to define, retrieve, and manipulate relational data.
- **PostgreSQL:** A relational database management system that processes SQL and manages database storage.
- **Supabase:** A backend platform built around PostgreSQL, providing additional services such as authentication, APIs, storage, and realtime features.

- **A is wrong:** These are not three equivalent programming languages.
- **C is wrong:** Neither Supabase nor SQL is limited to the purposes described.

**Key lesson:** SQL = language; PostgreSQL = database system; Supabase = backend platform.

## Question 04 — Correct Answer: B

```sql
SELECT name, grade FROM students;
```

This retrieves the `name` and `grade` columns, and no other columns.

- **A:** `SELECT *` requests all columns, which is more than the question requests.
- **C:** `INSERT INTO` is used to add rows; the shown statement is incomplete.
- **D:** `DELETE FROM` would attempt to delete records, and without a WHERE condition it targets all rows.

**Key lesson:** Name only the columns you want to retrieve.

## Question 05 — Correct Answer: B

```sql
SELECT * FROM students;
```

Within the `SELECT` list, the `*` requests **all columns** of the selected table.

- **A:** `*` does not mean first row.
- **C:** No DELETE operation is present.
- **D:** No CREATE TABLE operation is present.

**Key lesson:** `SELECT *` requests all columns; it does not guarantee row ordering.

## Question 06 — Correct Answer: C

**Authentication** verifies identity: *Who are you?*

**Authorization** checks permissions: *What are you allowed to access or do?*

In ProTrack MX, successful login must not automatically give a teacher access to every student record.

- **A:** Neither term describes the basic insert/delete distinction.
- **B:** They are not table-creation commands.
- **D:** Both concepts apply broadly to application and backend security.

**Key lesson:** Being logged in is not the same as being permitted to view or change every record.

## Question 07 — Correct Answer: B

If no accessible relation named `students` exists in the search path, PostgreSQL will report an error similar to:

```text
ERROR: relation "students" does not exist
```

`SELECT` reads from a source; it does not create a missing table.

- **A:** PostgreSQL does not create the referenced table automatically.
- **C:** The query has no table-creation or row-insertion operation.
- **D:** A SELECT statement does not delete other tables.

**Key lesson:** Check that a table actually exists before querying it.

## Question 08 — Correct Answer: Either Column Order

Both queries meet the task:

```sql
SELECT id, name FROM students;
```

```sql
SELECT name, id FROM students;
```

The only difference is the **order of columns in the result**.

The learner's actual submitted answer during Class 01 was:

```sql
SELECT name, id FROM students;
```

This is fully correct.

**Key lesson:** You can select multiple columns by separating their names with commas.

## Question 09 — Correct Answer: C

Running experimental SQL against a production database can:

- Change or remove real data.
- Interrupt normal application operations.
- Modify database permissions or Row Level Security.
- Expose sensitive information when security rules are configured incorrectly.

- **A:** SQL runs in production environments.
- **B:** Supabase provides SQL tooling for real projects; access depends on permissions and configuration.
- **D:** PostgreSQL supports SELECT in production.

**Key lesson:** Experiment in an isolated test environment, using non-sensitive sample data.

## Question 10 — Correct SQL Query

```sql
SELECT name FROM students;
```

The learner's actual submitted answer was:

```sql
select name FROM students;
```

**This is correct.** SQL keywords such as `SELECT` and `FROM` are case-insensitive in PostgreSQL. Uppercase keywords are a common formatting convention, not a requirement.

**Key lesson:** `SELECT name` requests only the `name` column, and `FROM students` specifies the source table.

---

## Recorded Class 01 Quiz Result

**Score: 10 / 10 — 100%**

All ten responses were accepted as correct during the interactive lesson, including the two independently written SQL queries in Questions 08 and 10.

This result reflects the introductory conceptual quiz, **not** a production implementation or database security audit.

## Class 01 Concepts Mastered

- Database terminology: table, row, column, record, and value.
- SQL and the differences between PostgreSQL and Supabase.
- Reading data with SELECT and choosing specific columns.
- Authentication and authorization.
- Why missing tables cause query errors.
- Safe practices around production databases.

**Next class (when ready):** Class 02 — Creating Tables, Data Types, Primary Keys, and INSERT INTO.

---

[Return to Questions](./QUESTIONS.md) · [Class 01 README](./README.md) · [Course Home](../README.md)
