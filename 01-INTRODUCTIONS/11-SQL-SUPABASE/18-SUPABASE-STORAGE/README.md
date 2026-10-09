# Class 18 — Supabase Storage and File Access

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Objectives

Read the main example without guessing what a keyword means; practice a realistic application task and identify potential safety problems. This builds on the earlier numbered lessons.

**Practice only in a test project with fictional data. No real student information, secrets or production migrations.**

## 1. Setup or Context

```text
-- Storage objects are normally managed through the Storage API/dashboard.
-- Treat bucket names and upload paths here as conceptual examples.
```

The context provides the minimum objects or assumptions needed to understand the main demonstration. Review all dependencies before executing code.

## 2. Fully Explained Main Example

```javascript
const filePath = 'assignments/demo-class/example.pdf';
const { data, error } = await supabase.storage
  .from('teacher-uploads')
  .upload(filePath, file, { upsert: false });
```

| Keyword / phrase | What it means |
|---|---|
| `const` | Declare a JavaScript binding. |
| `filePath` | Object key/path within the bucket. |
| `await` | Wait for the async upload request. |
| `supabase.storage` | Storage service on the configured client. |
| `.from('teacher-uploads')` | Select a named Storage bucket. |
| `.upload(filePath, file, ...)` | Send a local File/Blob at that object path. |
| `upsert: false` | Do not silently overwrite a path that already exists. |
| `data, error` | Result data and potential failure. |

### Read it from top to bottom

1. **const:** Declare a JavaScript binding.
2. **filePath:** Object key/path within the bucket.
3. **await:** Wait for the async upload request.
4. **supabase.storage:** Storage service on the configured client.
5. **.from('teacher-uploads'):** Select a named Storage bucket.
6. **.upload(filePath, file, ...):** Send a local File/Blob at that object path.
7. **upsert: false:** Do not silently overwrite a path that already exists.
8. **data, error:** Result data and potential failure.

## 3. Second Example

```javascript
const { data, error } = await supabase.storage
  .from('teacher-uploads')
  .createSignedUrl('assignments/demo-class/example.pdf', 60);
// Temporary URL duration is 60 seconds; requires appropriate permissions.
```

The second example extends the first one. Explain what new command, option, or behavior it introduces and what might fail.

## 4. Practical ProTrack MX Design Exercise

Imagine a fictional teacher managing classes, marks, or educational attachments. Describe when this feature would help and what should happen if the user lacks permission, the input is invalid, or the operation fails. Keep the example separate from real school data.

## 5. What Beginners Often Miss

Storage permission policies are essential for private school uploads. Signed URLs are bearer-style access links while valid, so do not leak them. Validate content type, size and names; never upload sensitive real files for practice.

A snippet that appears simple can have non-obvious effects. Always review permissions and test failure conditions before a deployment.

## 6. Ten Questions

1. What is a bucket?
2. What is an object path?
3. What does .from() mean here?
4. What does .upload() do?
5. What does upsert false do?
6. What is a signed URL?
7. Why use private buckets?
8. What needs authorization?
9. What should be validated?
10. Is a Storage bucket a SQL table?

Answer them one by one in [QUESTIONS.md](./QUESTIONS.md), then check [ANSWERS.md](./ANSWERS.md) for detailed correct meanings.

## 7. Self-Check

- [ ] I know what every main token does.
- [ ] I can distinguish reading and changing data.
- [ ] I understand the security warnings.
- [ ] I attempted all practice questions before reviewing.

## Documentation

- [PostgreSQL Official Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Official Documentation](https://supabase.com/docs)
