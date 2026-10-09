# Class 35 — Backend Architecture, API Security, and Secret Management

[Course roadmap](../README.md) · [Practice questions](./QUESTIONS.md) · [Answer key](./ANSWERS.md)

## Objective

Explain the commands and symbols in simple English, predict their behavior, understand mistakes, and transfer the ideas to a fictional ProTrack MX learning environment. Prerequisites: previous classes.

## 1. Setup / context

```javascript
// Pseudocode assumes a configured public Supabase client.
// Never embed secret/service-role credentials in browser applications.
```

Use a separate, disposable development environment. Examples are instructional and are not verified against the production ProTrack MX schema.

## 2. Main example

```javascript
const { data: userData, error: userError } = await supabase.auth.getUser();
if (userError || !userData.user) throw new Error('Sign-in required');
const { data, error } = await supabase.from('classes').select('id, title');
if (error) throw new Error('Unable to load classes');
```

## 3. Explain every important keyword

| Keyword or phrase | English meaning and role |
|---|---|
| `const` | Declare JavaScript binding. |
| `await` | Await asynchronous result. |
| `supabase.auth.getUser()` | Fetch/verify authenticated caller using Auth. |
| `if` | Test a condition. |
| `throw new Error` | Stop flow with an error. |
| `.from('classes')` | Choose data table in client SDK. |
| `.select('id, title')` | Request chosen columns. |
| `data, error` | Returned result fields. |

### Read the example in order

1. **const:** Declare JavaScript binding.
2. **await:** Await asynchronous result.
3. **supabase.auth.getUser():** Fetch/verify authenticated caller using Auth.
4. **if:** Test a condition.
5. **throw new Error:** Stop flow with an error.
6. **.from('classes'):** Choose data table in client SDK.
7. **.select('id, title'):** Request chosen columns.
8. **data, error:** Returned result fields.

## 4. Additional example

```javascript
// Backend-only pseudocode:
// 1. Verify bearer identity where required.
// 2. Authorize class ownership server-side.
// 3. Validate criteria and weight totals.
// 4. Apply changes transactionally.
// 5. Return safe errors without exposing secrets.
```

Explain how this second example differs, why it matters, and any expected result or error. A code sample is not an instruction to run it against live data.

## 5. ProTrack MX applied scenario

Assume fictional teachers, students, evaluation criteria, and academic periods. Describe how the new concept helps build a reliable and privacy-preserving educational backend. Identify what user authorization checks and validations should happen before using real data.

## 6. Common mistakes and important caveats

Do not assume a server function is secure by default. Always validate the caller, follow least privilege, and avoid leaking privileged keys through logs or frontend bundles.

Never commit passwords, access tokens, secret keys, or real student records to a public repository. Prefer test accounts and a separate Supabase development project.

## 7. Ten review exercises

1. What is an API?
2. What is a client?
3. What is a server?
4. What is an environment variable?
5. Where should secret keys live?
6. Why is frontend validation insufficient?
7. What is authorization?
8. Why use a backend for privileged operations?
9. What should an API error reveal?
10. What is defense in depth?

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
