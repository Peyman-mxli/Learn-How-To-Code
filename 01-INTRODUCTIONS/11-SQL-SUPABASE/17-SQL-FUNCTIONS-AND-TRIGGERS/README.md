# Class 17 — SQL Functions and Triggers

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Objectives

Read the main example without guessing what a keyword means; practice a realistic application task and identify potential safety problems. This builds on the earlier numbered lessons.

**Practice only in a test project with fictional data. No real student information, secrets or production migrations.**

## 1. Setup or Context

```sql
CREATE TABLE lab_notes(id integer PRIMARY KEY, note text NOT NULL, updated_at timestamptz NOT NULL DEFAULT now());
```

The context provides the minimum objects or assumptions needed to understand the main demonstration. Review all dependencies before executing code.

## 2. Fully Explained Main Example

```sql
CREATE FUNCTION lab_note_count() RETURNS bigint
LANGUAGE sql
AS $$ SELECT COUNT(*) FROM lab_notes; $$;
SELECT lab_note_count();
```

| Keyword / phrase | What it means |
|---|---|
| `CREATE FUNCTION` | Define a reusable database function. |
| `lab_note_count()` | Function name and empty parameter list. |
| `RETURNS bigint` | Declare the output as a 64-bit integer. |
| `LANGUAGE sql` | Use SQL as the function body language. |
| `AS $$ ... $$` | Dollar-quote the function body text. |
| `SELECT COUNT(*)` | Count rows. |
| `SELECT lab_note_count()` | Invoke the function. |

### Read it from top to bottom

1. **CREATE FUNCTION:** Define a reusable database function.
2. **lab_note_count():** Function name and empty parameter list.
3. **RETURNS bigint:** Declare the output as a 64-bit integer.
4. **LANGUAGE sql:** Use SQL as the function body language.
5. **AS $$ ... $$:** Dollar-quote the function body text.
6. **SELECT COUNT(*):** Count rows.
7. **SELECT lab_note_count():** Invoke the function.

## 3. Second Example

```sql
CREATE OR REPLACE FUNCTION lab_touch_timestamp()
RETURNS trigger LANGUAGE plpgsql AS $$
BEGIN
  NEW.updated_at := now();
  RETURN NEW;
END;
$$;
CREATE TRIGGER lab_notes_touch BEFORE UPDATE ON lab_notes
FOR EACH ROW EXECUTE FUNCTION lab_touch_timestamp();
```

The second example extends the first one. Explain what new command, option, or behavior it introduces and what might fail.

## 4. Practical ProTrack MX Design Exercise

Imagine a fictional teacher managing classes, marks, or educational attachments. Describe when this feature would help and what should happen if the user lacks permission, the input is invalid, or the operation fails. Keep the example separate from real school data.

## 5. What Beginners Often Miss

Triggers execute automatically on data changes and can surprise future maintainers. Security-definer functions may bypass intended access constraints; review ownership, search_path, privileges and input carefully.

A snippet that appears simple can have non-obvious effects. Always review permissions and test failure conditions before a deployment.

## 6. Ten Questions

1. What is a SQL function?
2. What does RETURNS mean?
3. What does LANGUAGE sql indicate?
4. What does $$ mean?
5. How do you call a function?
6. What is a trigger?
7. What does BEFORE UPDATE mean?
8. What does NEW mean in a row trigger?
9. Why RETURN NEW?
10. What security issues apply?

Answer them one by one in [QUESTIONS.md](./QUESTIONS.md), then check [ANSWERS.md](./ANSWERS.md) for detailed correct meanings.

## 7. Self-Check

- [ ] I know what every main token does.
- [ ] I can distinguish reading and changing data.
- [ ] I understand the security warnings.
- [ ] I attempted all practice questions before reviewing.

## Documentation

- [PostgreSQL Official Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Official Documentation](https://supabase.com/docs)
