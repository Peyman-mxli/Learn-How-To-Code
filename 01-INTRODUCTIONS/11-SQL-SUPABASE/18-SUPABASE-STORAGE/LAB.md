# Practical Lab — Private Upload Workflow

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Conceptual JavaScript exercise; only run with a configured development Supabase client, dummy files/data and matching permissions.

## Step 1 — Core exercise

```javascript
const { data, error } = await supabase.storage.from('demo-private').upload('teacher-a/demo.pdf', file, { upsert: false });
```

**Expected result/behavior:** With a configured client, valid Blob/File, existing bucket and permissions, the upload may succeed; otherwise an error is returned.

## Step 2 — Check your understanding

**Question:** What does upsert: false request?

**Answer:** Avoid overwriting an existing path.

## Step 3 — Troubleshooting scenario

**Issue:** Upload a real student report to a public bucket.

**Diagnosis or correction:** Unsafe: use fabricated files and private authorization policies in a development project.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
