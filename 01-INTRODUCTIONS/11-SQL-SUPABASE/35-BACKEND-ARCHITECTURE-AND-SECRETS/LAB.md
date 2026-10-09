# Practical Lab — Safe Backend Request

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Conceptual JavaScript exercise; requires a properly configured development client. Never use the production ProTrack MX project or real student data.

## 1. Practical Demonstration

```javascript
// Conceptual browser code for a configured Supabase dev client:
const { data: user, error: authError } = await supabase.auth.getUser();
if (authError || !user.user) throw new Error('Sign-in required');
const { data, error } = await supabase.from('classes').select('id,title');
if (error) throw new Error('Request failed');
```

**Expected result:** When authenticated and authorized with a valid table/client, returns permitted classes; otherwise the relevant error path runs.

## 2. One-at-a-Time Question

**Question:** What truly limits which classes a teacher may read?

**Answer:** Proper backend authorization, grants and RLS, not a browser variable.

## 3. Troubleshooting Exercise

**Mistake:** Put a service-role key in JavaScript frontend.

**Correct reasoning:** Severe privilege exposure; use appropriate server-side secret storage and least privilege.

## 4. Make It Your Own

Explain what each keyword or method does, what assumptions the example relies on, how a user would see the outcome in ProTrack MX, and what would happen with unauthorized data.

## Lab Completion

- [ ] Predicted outcome before running.
- [ ] Understood all statements, expressions and symbols.
- [ ] Diagnosed the mistake.
- [ ] Identified data privacy and permission requirements.
