# Class 15 — Schema Changes and Database Migrations

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Objectives

Read the main example without guessing what a keyword means; practice a realistic application task and identify potential safety problems. This builds on the earlier numbered lessons.

**Practice only in a test project with fictional data. No real student information, secrets or production migrations.**

## 1. Setup or Context

```sql
CREATE TABLE lab_terms(id integer PRIMARY KEY, title text NOT NULL);
```

The context provides the minimum objects or assumptions needed to understand the main demonstration. Review all dependencies before executing code.

## 2. Fully Explained Main Example

```sql
ALTER TABLE lab_terms ADD COLUMN starts_on date;
ALTER TABLE lab_terms ADD CONSTRAINT term_title_not_blank CHECK (length(trim(title)) > 0);
```

| Keyword / phrase | What it means |
|---|---|
| `ALTER TABLE` | Modify an existing table. |
| `ADD COLUMN` | Create a new column. |
| `starts_on` | The new column name. |
| `date` | Date storage type. |
| `ADD CONSTRAINT` | Give a new table constraint a name. |
| `CHECK` | Validate a Boolean condition on inserted/updated rows. |
| `length(trim(title)) > 0` | Reject empty or ordinary whitespace-only titles. |
| `;` | Terminate a SQL statement. |

### Read it from top to bottom

1. **ALTER TABLE:** Modify an existing table.
2. **ADD COLUMN:** Create a new column.
3. **starts_on:** The new column name.
4. **date:** Date storage type.
5. **ADD CONSTRAINT:** Give a new table constraint a name.
6. **CHECK:** Validate a Boolean condition on inserted/updated rows.
7. **length(trim(title)) > 0:** Reject empty or ordinary whitespace-only titles.
8. **;:** Terminate a SQL statement.

## 3. Second Example

```sql
BEGIN;
ALTER TABLE lab_terms ADD COLUMN ends_on date;
-- Inspect the change before deciding whether to:
ROLLBACK;
-- Or use COMMIT instead of ROLLBACK in a reviewed migration.
```

The second example extends the first one. Explain what new command, option, or behavior it introduces and what might fail.

## 4. Practical ProTrack MX Design Exercise

Imagine a fictional teacher managing classes, marks, or educational attachments. Describe when this feature would help and what should happen if the user lacks permission, the input is invalid, or the operation fails. Keep the example separate from real school data.

## 5. What Beginners Often Miss

Schema changes can lock or rewrite tables. Review existing data, backups, dependencies, rollout order and rollback. Transactions do not remove the need for planning.

A snippet that appears simple can have non-obvious effects. Always review permissions and test failure conditions before a deployment.

## 6. Ten Questions

1. What is a migration?
2. What does ALTER TABLE do?
3. What does ADD COLUMN mean?
4. Why use DATE?
5. What does ADD CONSTRAINT mean?
6. What does CHECK do?
7. Why must existing rows be considered?
8. What does BEGIN do?
9. What does ROLLBACK do?
10. Why review a migration before production?

Answer them one by one in [QUESTIONS.md](./QUESTIONS.md), then check [ANSWERS.md](./ANSWERS.md) for detailed correct meanings.

## 7. Self-Check

- [ ] I know what every main token does.
- [ ] I can distinguish reading and changing data.
- [ ] I understand the security warnings.
- [ ] I attempted all practice questions before reviewing.

## Documentation

- [PostgreSQL Official Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Official Documentation](https://supabase.com/docs)
