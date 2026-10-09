# Class 25 — Backups, Restore, and Recovery Planning

[Course index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning goals

Explain each command, identify its role in safe ProTrack MX development, practice the example in a separate test environment, and pass ten comprehension questions.

## 1. Main example

```bash
pg_dump --format=custom --file=lab_backup.dump lab_database
# Restore ONLY into a separate disposable environment:
pg_restore --dbname=lab_restore --no-owner lab_backup.dump
```

## 2. Word-by-word explanations

| Term | Meaning and purpose |
|---|---|
| `pg_dump` | PostgreSQL utility that exports a database. |
| `--format=custom` | Choose flexible archive format. |
| `--file` | Path of generated backup archive. |
| `lab_database` | Source test database. |
| `pg_restore` | Utility to restore a dump archive. |
| `--dbname` | Target database for restoration. |
| `--no-owner` | Avoid applying original ownership during restore. |

### Read the statement line by line

1. **pg_dump:** PostgreSQL utility that exports a database.
2. **--format=custom:** Choose flexible archive format.
3. **--file:** Path of generated backup archive.
4. **lab_database:** Source test database.
5. **pg_restore:** Utility to restore a dump archive.
6. **--dbname:** Target database for restoration.
7. **--no-owner:** Avoid applying original ownership during restore.

## 3. Additional working example

```sql
-- Verify backup with a restore into an isolated destination.
-- Compare expected schema, table counts and basic integrity checks.
SELECT COUNT(*) FROM lab_students;
```

Read the code from left to right. Identify which objects it touches, whether it changes data, and what happens if its inputs do not match expected rows.

## 4. ProTrack MX practice

Use fictional teachers, students and periods to describe the appropriate purpose of the operation. The sample names are not verified database objects in the actual app. Discuss privileges, user identity and RLS before proposing an operation on any school records.

## 5. Important caveats

Backups can contain sensitive data and credentials; store securely and control access. A successful dump is not a verified restore. Managed Supabase backup and PITR availability depend on project configuration and plan.

## 6. Review questions

1. What is a backup?
2. What does pg_dump do?
3. What does custom format mean?
4. What does pg_restore do?
5. Why test restoration?
6. What is RPO?
7. What is RTO?
8. Is a GitHub SQL script a database backup?
9. Why protect backup files?
10. Does every Supabase plan include identical recovery features?

Complete [QUESTIONS.md](./QUESTIONS.md) one question at a time; check [ANSWERS.md](./ANSWERS.md) afterward.

## 7. Completion criteria

- [ ] Explain the main statement without copying.
- [ ] Explain the additional example and differences.
- [ ] Describe at least two security or correctness risks.
- [ ] Attempt all ten questions independently.

## Further reading

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
