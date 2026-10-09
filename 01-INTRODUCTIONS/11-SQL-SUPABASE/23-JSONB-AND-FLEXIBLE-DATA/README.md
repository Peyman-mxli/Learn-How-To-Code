# Class 23: JSONB and Semi-Structured Data

[Course Index](../README.md) | [Questions](./QUESTIONS.md) | [Answers](./ANSWERS.md)

## Learning outcome

Understand each clause, execute a hypothetical query mentally, explain pitfalls, and apply the idea to a fictional ProTrack MX scenario. Prerequisite: previous numbered lessons.

## 1. Isolated test setup

Run only against a disposable PostgreSQL test environment. This SQL creates fictional lab-prefixed tables; never run on the live ProTrack MX database.

```sql
CREATE TABLE lab_preferences(user_id integer PRIMARY KEY, settings jsonb NOT NULL);
INSERT INTO lab_preferences VALUES (1, '{"theme":"dark","notifications":true}');
```

## 2. Main worked example

```sql
SELECT user_id,
  settings ->> 'theme' AS theme
FROM lab_preferences
WHERE settings @> '{"notifications": true}'::jsonb;
```

### Every SQL phrase explained

| Phrase | Why it is used |
|---|---|
| `jsonb` | PostgreSQL binary JSON data type. |
| `->>` | Extract a JSON field as text. |
| `'theme'` | JSON key name. |
| `@>` | Test JSONB containment. |
| `::jsonb` | Explicit type cast to jsonb. |
| `WHERE` | Filter matching records. |

### Walk through in order

1. **jsonb:** PostgreSQL binary JSON data type.
2. **->>:** Extract a JSON field as text.
3. **'theme':** JSON key name.
4. **@>:** Test JSONB containment.
5. **::jsonb:** Explicit type cast to jsonb.
6. **WHERE:** Filter matching records.

## 3. Second example

```sql
UPDATE lab_preferences
SET settings = jsonb_set(settings, '{theme}', '"light"'::jsonb)
WHERE user_id = 1;
-- Update a nested property while preserving other keys.
```

Compare the first and second example. State what data each one reads or changes, what can fail, and why the additional clause matters.

## 4. ProTrack MX application

Consider fake classes, teacher sessions, preferences or grades. Explain how the example helps with authorized reports or safe updates. A SQL filter is not an authorization mechanism. Production data requires appropriate grants, RLS, validations and testing.

## 5. Important limitations

Use typed relational columns for core identities, foreign keys, and grades when strong constraints are required. JSONB can help for suitable flexible preferences, not as a universal replacement for modeling.

## 6. Exercises

1. What is JSONB?
2. What does ->> extract?
3. What does -> extract?
4. What does @> check?
5. What does ::jsonb mean?
6. What does jsonb_set do?
7. Why not store every field in JSONB?
8. Can JSONB be indexed?
9. Should private data be placed in JSONB without controls?
10. Name a good JSONB use case.

Answer one question at a time, then consult the separate answer key.

## 7. Self-check

- [ ] I understand the terms and the code.
- [ ] I can describe expected results without executing SQL.
- [ ] I know the main failure modes.
- [ ] I can answer all ten questions.

## References

- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Documentation](https://supabase.com/docs)
