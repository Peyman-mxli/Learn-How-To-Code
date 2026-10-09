# Class 23: Explained Answers

[Lesson](./README.md) | [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is JSONB?

**Explanation:** A PostgreSQL type for storing and querying JSON-like structured data.

## Answer 2

**Question:** What does ->> extract?

**Explanation:** A JSON field converted to text.

## Answer 3

**Question:** What does -> extract?

**Explanation:** A JSON value in JSON form.

## Answer 4

**Question:** What does @> check?

**Explanation:** Whether the left jsonb value contains the right JSON structure.

## Answer 5

**Question:** What does ::jsonb mean?

**Explanation:** Cast the expression to jsonb.

## Answer 6

**Question:** What does jsonb_set do?

**Explanation:** Return JSONB with a specified path's value replaced or added according to parameters.

## Answer 7

**Question:** Why not store every field in JSONB?

**Explanation:** You lose advantages of explicit relational types, constraints and joins for core structured data.

## Answer 8

**Question:** Can JSONB be indexed?

**Explanation:** Yes, appropriate index types and operators can support JSONB queries.

## Answer 9

**Question:** Should private data be placed in JSONB without controls?

**Explanation:** No, access controls and data minimization still apply.

## Answer 10

**Question:** Name a good JSONB use case.

**Explanation:** Flexible nonsensitive user-interface preferences with clearly validated schema.
