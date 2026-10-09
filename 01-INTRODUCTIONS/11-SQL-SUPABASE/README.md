# SQL & Supabase — From Fundamentals to Secure Backend Development

> A structured, hands-on learning journey using **ProTrack MX**, an educational management application, as the running case study.

**Repository:** [Learn-How-To-Code](https://github.com/Peyman-mxli/Learn-How-To-Code)  
**Track:** 11 — SQL & Supabase  
**Audience:** Beginner → Intermediate  
**Database focus:** PostgreSQL (the database engine behind Supabase)  
**Documentation language:** English

---

## About This Learning Track

This course teaches the fundamentals of relational databases and SQL before introducing Supabase backend services, authentication, authorization, and secure application development.

The aim is to understand *why* each technology and command is used—not merely to copy queries. Every lesson includes conceptual explanations, code walkthroughs, ProTrack MX examples, practice activities, and review questions.

**ProTrack MX case study:** A teacher-facing platform that may manage educators, classes, students, attendance, configurable evaluation criteria, assignments, and grades. Examples in this course are **illustrative learning models**, not claims about the actual production schema.

## Learning Objectives

By the end of the track, learners should be able to:

1. Explain databases, tables, rows, columns, records, and relationships.
2. Read and write SQL queries and understand the difference between querying and changing data.
3. Model a relational schema using primary keys, foreign keys, data types, and constraints.
4. Use PostgreSQL safely through SQL tools.
5. Explain Supabase Database, Auth, Storage, APIs, Realtime, and Edge Functions.
6. Distinguish authentication (who you are) from authorization (what you may do).
7. Understand PostgreSQL grants and Row Level Security (RLS).
8. Build and test a small secure educational backend without exposing real student data.

## Course Roadmap

| Class | Topic | Key Concepts | Status |
| --- | --- | --- | --- |
| [01](./01-DATABASE-AND-SQL-BASICS/README.md) | Database & SQL Basics | Database, tables, rows, columns, SELECT | Available |
| 02 | Create Tables & Insert Data | CREATE TABLE, types, primary keys, INSERT | Planned |
| 03 | Query and Filter Records | SELECT, WHERE, ORDER BY, LIMIT | Planned |
| 04 | Updating and Deleting Data | UPDATE, DELETE, transactions, safe WHERE | Planned |
| 05 | Relational Database Design | Relationships, foreign keys, normalization | Planned |
| 06 | PostgreSQL Essentials | Constraints, indexes, schemas, useful functions | Planned |
| 07 | Supabase Foundations | Dashboard, projects, environments, database APIs | Planned |
| 08 | Authentication and Profiles | Supabase Auth, user sessions, profiles | Planned |
| 09 | Authorization and RLS | GRANT, REVOKE, roles, policies, testing | Planned |
| 10 | Connecting ProTrack MX | Client SDK, CRUD, safe access, review project | Planned |

Future lessons will be added as separate numbered directories. Their topics may be refined as learning progresses.

## Folder Convention

```text
01-INTRODUCTIONS/
└── 11-SQL-SUPABASE/
    ├── README.md                         # Course overview and index
    ├── 01-DATABASE-AND-SQL-BASICS/
    │   └── README.md                     # Class 01
    └── 02-.../                           # Added after Class 02
```

## Important: Production Database Safety

**Do not run experimental SQL against the ProTrack MX production database.**

- Use a separate test project or local development database for experiments.
- Never include actual student records, credentials, access tokens, or service-role/secret keys in this public repository.
- Reading data and changing data are different operations; learn what each query does before execution.
- Changes to grants, roles, or Row Level Security can expose information or break application access.
- Public-schema tables exposed through the API require intentional permission and RLS configuration.
- Examples are pedagogical and must be reviewed before any production use.

## Required Tools (Over Time)

- GitHub for organizing lesson notes and documenting progress.
- A code editor such as Visual Studio Code.
- A PostgreSQL learning environment (local database or an isolated Supabase test project).
- A Supabase account for the later hands-on modules.

**Class 01 requires no installation and no database account.** Start by understanding the concepts and studying the sample queries.

## How to Study

1. Open the next numbered class README.
2. Review its vocabulary, explanations, and examples.
3. Predict what each SQL statement will return or change.
4. Complete the exercises independently.
5. Check the provided answers and revisit unclear concepts.
6. Move to the next class only once the fundamentals are understood.

## Official References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/)
- [PostgreSQL SQL Tutorial](https://www.postgresql.org/docs/current/tutorial-sql.html)
- [Supabase Documentation](https://supabase.com/docs)
- [Supabase Database Guide](https://supabase.com/docs/guides/database)
- [Supabase Security Guide](https://supabase.com/docs/guides/database/postgres/row-level-security)

---

**Maintained as part of Peyman's Learn-How-To-Code learning journey.**  
**Learning principle:** Understand the concept, practice safely, then document it clearly.
