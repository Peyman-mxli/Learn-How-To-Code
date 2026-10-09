# Practical Lab — Local CLI Navigation

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Locally installed Supabase CLI and a separate development project. Never use the production ProTrack MX project or real student data.

## 1. Practical Demonstration

```bash
supabase --version
supabase status
```

**Expected result:** First command prints installed CLI version; status reports local services or an error if not running/configured.

## 2. One-at-a-Time Question

**Question:** Why run supabase init before local setup?

**Answer:** It creates project configuration for local development.

## 3. Troubleshooting Exercise

**Mistake:** Execute supabase db reset against the wrong environment.

**Correct reasoning:** Reset may destroy local state; inspect target and use disposable development setup only.

## 4. Make It Your Own

Explain what each keyword or method does, what assumptions the example relies on, how a user would see the outcome in ProTrack MX, and what would happen with unauthorized data.

## Lab Completion

- [ ] Predicted outcome before running.
- [ ] Understood all statements, expressions and symbols.
- [ ] Diagnosed the mistake.
- [ ] Identified data privacy and permission requirements.
