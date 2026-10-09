# Class 10 — Answer Key: Integrating ProTrack MX with Supabase

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

Read this after attempting each question. Equivalent technically correct answers are acceptable.

## Answer 01

**Question:** What is the frontend?

**Explanation:** The part of an app users directly interact with, including pages, buttons, and grade tables.

## Answer 02

**Question:** What is the backend?

**Explanation:** Services responsible for data access, business operations, authentication integration, and enforcing permissions.

## Answer 03

**Question:** What does the Supabase client SDK do?

**Explanation:** It offers functions for communicating with Supabase APIs such as database queries and Auth.

## Answer 04

**Question:** What is the role of a login session?

**Explanation:** It represents the signed-in user's authenticated state and helps requests carry the correct user context.

## Answer 05

**Question:** Why is a frontend WHERE teacher_id filter not authorization?

**Explanation:** Client requests can be modified, so the database must enforce access through appropriate grants and Row Level Security.

## Answer 06

**Question:** Where should service-role or secret keys be stored?

**Explanation:** In trusted backend secret storage, not browser source code, public repositories, or public logs.

## Answer 07

**Question:** How should app errors be handled?

**Explanation:** Check error results, avoid revealing sensitive data, and communicate a useful safe error message.

## Answer 08

**Question:** How might configurable grading criteria be modeled?

**Explanation:** Store criteria, weights, class/period relationships, and student results in related tables with explicit validation and permitted access.

## Answer 09

**Question:** What must be reviewed before a production release?

**Explanation:** Schema, backups, migrations, permissions, RLS tests, secrets, logging, input validation, and role-based access.

## Answer 10

**Question:** Describe an end-to-end flow to show a teacher's classes.

**Explanation:** Sign in, issue an authenticated request, check database privileges/RLS, return only permitted rows, and display them in the UI.


## Capstone Evaluation

A strong design explains UI, Auth, API calls, table relationships, authorization through RLS, grade-weight validation, and error behavior. It does not pretend to have inspected the actual production schema. **Never run these examples in production.**
