# Class 18 — Explained Answers: Supabase Storage and File Access

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is a bucket?

**Explanation:** A top-level container of objects/files in Supabase Storage.

## Answer 2

**Question:** What is an object path?

**Explanation:** A path/key identifying a file within a bucket.

## Answer 3

**Question:** What does .from() mean here?

**Explanation:** Select the bucket for the Storage operation.

## Answer 4

**Question:** What does .upload() do?

**Explanation:** Upload file/blob content to an object path.

## Answer 5

**Question:** What does upsert false do?

**Explanation:** Avoid intentional overwrite of an existing object path.

## Answer 6

**Question:** What is a signed URL?

**Explanation:** A time-limited URL authorizing access to a particular resource.

## Answer 7

**Question:** Why use private buckets?

**Explanation:** To control who can access private documents.

## Answer 8

**Question:** What needs authorization?

**Explanation:** Uploads, reads, updates and deletions need appropriate Storage policies.

## Answer 9

**Question:** What should be validated?

**Explanation:** File type, content, size, ownership, destination path and security requirements.

## Answer 10

**Question:** Is a Storage bucket a SQL table?

**Explanation:** No; bucket objects are accessed using Storage APIs, backed by related metadata and policies.


Always consider validation, authorization, and production-data safety.