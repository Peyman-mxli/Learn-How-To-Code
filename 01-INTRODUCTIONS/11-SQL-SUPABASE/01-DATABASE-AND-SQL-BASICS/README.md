# Class 01 — Introduction to Databases and SQL

> **SQL & Supabase Learning Journey · Beginner · ProTrack MX case study**

**Course:** [SQL & Supabase](../README.md)  
**Lesson:** 01 of 10  
**Topic:** Database fundamentals, relational data, and the first SELECT query  
**Prerequisites:** None  
**Hands-on risk:** None — all examples are conceptual; do not run anything on the live project.

---

## 1. Learning Outcomes

After this lesson, you should be able to:

1. Describe what a database is and why applications use one.
2. Explain the difference between a database, a database management system (DBMS), SQL, PostgreSQL, and Supabase.
3. Identify a table, row, column, record, value, and identifier.
4. Recognize the parts of a basic SQL SELECT statement.
5. Explain what SELECT *, SELECT name, and SELECT with more than one column return.
6. Relate these concepts to the ProTrack MX educational application.
7. Explain why it is important to use a safe practice environment rather than a production database.

## 2. What Is a Database?

A **database** is an organized collection of data, typically managed electronically, so software can store, retrieve, and maintain information efficiently.

Consider a school using ProTrack MX. It needs to keep track of teachers, students, classes, attendance, assignments, evaluation criteria, and grades. If these records existed only in the temporary memory of a running application, they would not provide reliable long-term storage. A database provides persistent data storage and structured access.

A database can help an application:

- **Persist information:** Keep records after users close the website or restart devices.
- **Retrieve information:** Find a particular student's grades without searching every screen manually.
- **Update information:** Record a corrected name or revised assessment.
- **Maintain consistency:** Apply rules that prevent certain invalid values or relationships.
- **Coordinate access:** Support multiple users under controlled permissions.
- **Protect information:** Combine authentication, authorization, database roles, and security policies.

A database does not automatically guarantee a correct design or secure application. Those properties depend on how it is configured and used.

### Real-life analogy: A school filing system

Imagine a school office containing filing cabinets:

| Real-world concept | Relational database concept |
| --- | --- |
| Filing system for the school | Database |
| One organized register of students | Table |
| One student's entry in that register | Row / record |
| The field for a student's name | Column |
| The name "Sara" in one entry | Value |
| Unique student record identifier | Primary key (in a designed table) |

This analogy is useful, but databases can additionally enforce constraints, represent relationships, and answer complex queries.

## 3. What Is a Relational Database?

A **relational database** organizes information into tables with defined columns. Tables can be related through keys.

For example, ProTrack MX might conceptually require these tables:

| Example table | What it represents | Example columns |
| --- | --- | --- |
| `teachers` | Educators | `id`, `name`, `email` |
| `students` | Student records | `id`, `name`, `grade_level` |
| `classes` | Class sections | `id`, `title`, `teacher_id` |
| `enrollments` | Membership in class sections | `student_id`, `class_id` |
| `assessments` | Evaluation activities | `id`, `class_id`, `title` |
| `grades` | Assessment results | `student_id`, `assessment_id`, `score` |

**Important:** These names and columns are **educational examples**, not an inspection or verified description of the current ProTrack MX production database. A real educational platform also needs appropriate privacy, access controls, and careful schema planning.

### Why not store everything in one table?

One giant table may duplicate teacher names for every student and assessment, making updates difficult and inconsistent. Separating distinct concepts into appropriately related tables often improves correctness and maintainability.

We will learn primary keys, foreign keys, and relationships in later classes.

## 4. Tables, Rows, Columns, Records, and Values

Here is a **fictional** `students` table used throughout this lesson:

| id | name | age | grade |
| ---: | --- | ---: | ---: |
| 1 | Ali | 15 | 95 |
| 2 | Sara | 14 | 88 |
| 3 | Reza | 16 | 76 |

### Table

The entire collection above is a **table** named `students`. It holds entries that follow a consistent structure.

### Column

A **column** describes a field. This table has four columns:

- `id`: An identifier for each example student.
- `name`: The student's name.
- `age`: The student's age.
- `grade`: A sample score out of 100.

A column has an associated data type, such as an integer or text type. We will study types in Class 02.

### Row (Record)

A **row** is one record. For instance:

```text
id = 2
name = Sara
age = 14
grade = 88
```

This row holds the example data for Sara.

### Value

A **value** is a specific data item at the intersection of a row and column. In Sara's row, the value of the `grade` column is `88`.

### Identifier and Primary Key

In our example, `id` distinguishes records even if two students share the same name.

An identifier is not automatically a primary key. A **primary key** must be explicitly defined as a constraint in the database design. In this introductory example, assume `id` is intended to serve as the primary key; its actual definition comes later.

### A useful distinction

- **Column:** What kind of information is stored?
- **Row:** Whose or which record is it?
- **Value:** What information appears in that specific field?

## 5. What Is SQL?

**SQL** stands for **Structured Query Language**. It is a language used to define, query, and modify data in relational database systems.

Common SQL operations include:

| Keyword | Purpose | Introduced |
| --- | --- | --- |
| `SELECT` | Read requested data | Class 01 |
| `CREATE TABLE` | Define a table | Class 02 |
| `INSERT INTO` | Add records | Class 02 |
| `WHERE` | Restrict which records match | Class 03 |
| `UPDATE` | Modify records | Class 04 |
| `DELETE` | Remove records | Class 04 |
| `JOIN` | Combine related tables in queries | Later |

SQL is **declarative**: instead of describing every procedural step for searching records, you state *what information you want*.

## 6. SQL vs. PostgreSQL vs. Supabase

These terms are related, but they do **not** mean the same thing.

| Technology | Category | Role |
| --- | --- | --- |
| SQL | Query language | Expresses operations on relational data |
| PostgreSQL | Relational database management system (RDBMS) | Stores relational data and processes SQL |
| Supabase | Backend development platform | Provides managed PostgreSQL and services including Auth, APIs, Storage, and Realtime |
| ProTrack MX | Application | Uses backend services to implement teacher-facing features |

### Example flow

```text
Teacher opens ProTrack MX
        |
        v
ProTrack MX frontend
        |
        v
Authorized API request to Supabase
        |
        v
PostgreSQL database + permission checks
        |
        v
Permitted information is returned to the app
```

This diagram is intentionally simplified. The exact data flow depends on the application architecture and authentication configuration.

### Authentication vs. authorization

- **Authentication** asks: *Who is this user?*
- **Authorization** asks: *What is this user allowed to access or change?*

A teacher successfully logging in must **not** automatically gain access to every student or every school.

## 7. Your First SQL Query: SELECT

Suppose the fictional `students` table shown earlier already exists in a safe practice database.

To request **all its columns**:

```sql
SELECT * FROM students;
```

### Read it from left to right

| SQL part | Meaning |
| --- | --- |
| `SELECT` | Specify the information to retrieve |
| `*` | All columns |
| `FROM` | Identify the source table |
| `students` | The table being queried |
| `;` | A statement terminator, especially useful when writing multiple SQL statements |

This command is a **read query**: it does not itself insert, update, or delete student records.

### Expected result

| id | name | age | grade |
| ---: | --- | ---: | ---: |
| 1 | Ali | 15 | 95 |
| 2 | Sara | 14 | 88 |
| 3 | Reza | 16 | 76 |

**Important:** SQL does not promise a stable result order without `ORDER BY`. The displayed order here is only illustrative. Class 03 will cover sorting.

## 8. Select Only the Columns You Need

If the school screen only needs student names:

```sql
SELECT name FROM students;
```

Example result:

| name |
| --- |
| Ali |
| Sara |
| Reza |

If it needs both names and grades:

```sql
SELECT name, grade FROM students;
```

Example result:

| name | grade |
| --- | ---: |
| Ali | 95 |
| Sara | 88 |
| Reza | 76 |

### Why choose specific columns?

- You communicate exactly which data the screen needs.
- You avoid transferring unnecessary fields.
- Your queries are easier to understand and maintain.
- In a real app, this can reduce unnecessary data exposure, although access controls—not selecting fewer columns alone—are responsible for enforcing data privacy.

## 9. A Classroom Example from ProTrack MX

Imagine a teacher opening the grade overview screen.

Conceptually, the app could request a class roster and grade-related data from its backend. A simple introductory exercise looks like:

```sql
SELECT name, grade FROM students;
```

However, **this is not a complete production query**. It does not filter by teacher, class, or enrollment; it does not model different assignments, trimesters, or configurable grade weights.

A production-ready ProTrack MX design would need related entities and database authorization rules, and it would typically calculate/display grades according to configured evaluation criteria.

We intentionally postpone that complexity until you understand SELECT, WHERE, relationships, and Row Level Security.

## 10. SQL Syntax and Common Beginner Mistakes

### SQL keywords and casing

These statements are generally equivalent in PostgreSQL:

```sql
SELECT name FROM students;
```

```sql
select name from students;
```

Writing keywords in uppercase is a readability convention, not a requirement.

### Common mistakes

**Mistake 1 — Forgetting FROM**

```sql
SELECT name students;
```

This does not mean "select the name column from the students table." In PostgreSQL it can be parsed as a SELECT expression with an alias, and it will fail without a resolvable `name` column in scope.

Use:

```sql
SELECT name FROM students;
```

**Mistake 2 — Using a nonexistent table name**

```sql
SELECT * FROM student;
```

If the table is actually called `students`, PostgreSQL cannot retrieve that nonexistent relation.

**Mistake 3 — Assuming star means multiplication**

In this context, `*` requests **all columns**. Its meaning depends on SQL syntax.

**Mistake 4 — Assuming an example table already exists**

```sql
SELECT * FROM students;
```

This only works if `students` exists in the connected database and your current role has permission to read it. The query does **not** create the table.

**Mistake 5 — Treating a successful query as proof of security**

A query succeeding does not prove that permissions or Row Level Security were configured correctly. Security must be reviewed and tested with appropriate user roles.

## 11. Safe Practice Guidance

The ProTrack MX Supabase dashboard may be connected to a **production** project. This course's queries are educational examples, not production migration instructions.

For now:

1. Read the queries and predict their results.
2. Answer the questions below without running SQL.
3. Do not create demo tables or change grants/RLS in production.
4. When we reach hands-on work, use a separate local PostgreSQL database or a dedicated Supabase test project.
5. Never add passwords, API secrets, service-role keys, access tokens, or real student data to GitHub.

## 12. Guided Practice — Predict the Output

Use only this fictional data:

| id | name | age | grade |
| ---: | --- | ---: | ---: |
| 1 | Ali | 15 | 95 |
| 2 | Sara | 14 | 88 |
| 3 | Reza | 16 | 76 |

**Exercise A**

```sql
SELECT * FROM students;
```

- Which columns are returned?
- How many rows are in our example result?
- Does this command change any stored student information?

**Exercise B**

```sql
SELECT age FROM students;
```

- Which column is returned?
- List its three example values.

**Exercise C**

```sql
SELECT name, grade FROM students;
```

- Which columns are returned?
- What grade belongs to Sara in the sample data?

**Exercise D — Write your own query**

Write an SQL statement that returns only the `id` and `name` columns from `students`.

**Exercise E — Explain**

In two or three sentences, explain why a school app should not give every logged-in teacher access to every student's private information.

### Practice Answers (Check After Trying)

<details>
<summary>Reveal the sample answers</summary>

**A:** The columns `id`, `name`, `age`, and `grade`; three example rows; no data modification.

**B:** The `age` column; example values 15, 14, 16 (result row order is not guaranteed without ORDER BY).

**C:** `name` and `grade`; Sara's sample grade is 88.

**D:**

```sql
SELECT id, name FROM students;
```

**E:** Signing in only identifies the teacher; it should not automatically grant full data access. The backend must enforce authorization so teachers can access only permitted class and student records.

</details>

## 13. Knowledge Check — Class 01

1. In your own words, what is a database?
2. What distinguishes a table from a row?
3. What does a column describe?
4. What does SQL stand for?
5. Which system executes SQL in Supabase?
6. Does `SELECT * FROM students;` create a new table?
7. What does the asterisk mean in `SELECT *`?
8. What is the difference between authentication and authorization?
9. Why should beginner exercises not run against the live ProTrack MX database?
10. Write a query that returns only the `name` column from `students`.

### Suggested Self-Assessment

- **8–10 correct:** You are ready to review the next class.
- **5–7 correct:** Revisit the terminology and SELECT examples.
- **0–4 correct:** Repeat Sections 2–8 and redo the guided exercises.

## 14. Class Summary

- A database stores and organizes information.
- A relational database stores records in tables.
- Tables contain columns (fields) and rows (records).
- SQL is the language used to work with relational data.
- PostgreSQL is the database system; Supabase builds backend services around PostgreSQL.
- `SELECT` retrieves data, `FROM` identifies its table, and `*` selects all columns.
- A successful SQL command does not automatically prove correct security.
- Learning examples should be tested separately from production systems.

## 15. What's Next?

**Class 02 — Creating Tables and Inserting Data**

You will learn:

- `CREATE TABLE`
- Basic PostgreSQL data types (`INTEGER`, `TEXT`, `NUMERIC`, and `BOOLEAN`)
- `PRIMARY KEY` and `NOT NULL`
- `INSERT INTO`
- Automatically generated identifiers
- Why schema constraints matter

---

## References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/)
- [PostgreSQL Tutorial — SQL Language](https://www.postgresql.org/docs/current/tutorial-sql.html)
- [Supabase Documentation](https://supabase.com/docs)
- [Supabase Database](https://supabase.com/docs/guides/database)
- [Supabase Row Level Security](https://supabase.com/docs/guides/database/postgres/row-level-security)

**Lesson status:** Class 01 documentation complete.  
**Note:** All student names, grades, and table layouts used here are fictional training examples.
