# Class 33 — Supabase CLI, Local Development, and Migration Workflow

[Course roadmap](../README.md) · [Practice questions](./QUESTIONS.md) · [Answer key](./ANSWERS.md)

## Objective

Explain the commands and symbols in simple English, predict their behavior, understand mistakes, and transfer the ideas to a fictional ProTrack MX learning environment. Prerequisites: previous classes.

## 1. Setup / context

```bash
# Run these commands only after installing the Supabase CLI and local container prerequisites.
supabase --version
supabase init
```

Use a separate, disposable development environment. Examples are instructional and are not verified against the production ProTrack MX schema.

## 2. Main example

```bash
supabase start
supabase migration new add_demo_table
supabase db reset
```

## 3. Explain every important keyword

| Keyword or phrase | English meaning and role |
|---|---|
| `supabase` | Supabase CLI executable. |
| `start` | Start a local Supabase development stack. |
| `migration` | Group of commands for migration files. |
| `new` | Generate a new timestamped migration file. |
| `add_demo_table` | Descriptive migration name. |
| `db reset` | Rebuild local development database from migrations and seeds; destructive to local data. |

### Read the example in order

1. **supabase:** Supabase CLI executable.
2. **start:** Start a local Supabase development stack.
3. **migration:** Group of commands for migration files.
4. **new:** Generate a new timestamped migration file.
5. **add_demo_table:** Descriptive migration name.
6. **db reset:** Rebuild local development database from migrations and seeds; destructive to local data.

## 4. Additional example

```bash
supabase status
supabase stop
# Review migration SQL before applying it to any remote project.
```

Explain how this second example differs, why it matters, and any expected result or error. A code sample is not an instruction to run it against live data.

## 5. ProTrack MX applied scenario

Assume fictional teachers, students, evaluation criteria, and academic periods. Describe how the new concept helps build a reliable and privacy-preserving educational backend. Identify what user authorization checks and validations should happen before using real data.

## 6. Common mistakes and important caveats

The CLI depends on currently supported prerequisites and configuration. Never confuse local reset with remote operations. Commands and flags may evolve; consult official documentation before running.

Never commit passwords, access tokens, secret keys, or real student records to a public repository. Prefer test accounts and a separate Supabase development project.

## 7. Ten review exercises

1. What is the CLI?
2. What does supabase init do?
3. What does supabase start do?
4. What is a migration file?
5. Why use a timestamped migration?
6. What does db reset do locally?
7. What is a seed file?
8. Why keep migrations in GitHub?
9. Should you push a migration blindly to production?
10. What does supabase status do?

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
