# Class 19 — Explained Answers

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is Realtime?

**Correct explanation:** Supabase functionality for receiving live events such as certain database changes.

## Answer 2

**Question:** What is a channel?

**Correct explanation:** A named connection context for subscribing to supported realtime events.

## Answer 3

**Question:** What does .on do?

**Correct explanation:** Registers a callback for an event source and criteria.

## Answer 4

**Question:** What does postgres_changes mean?

**Correct explanation:** A subscription type for supported PostgreSQL change events.

## Answer 5

**Question:** What does event UPDATE select?

**Correct explanation:** Only update change events.

## Answer 6

**Question:** What is payload?

**Correct explanation:** The change-event information passed to the callback.

## Answer 7

**Question:** Why call subscribe?

**Correct explanation:** To activate the configured channel connection.

## Answer 8

**Question:** Why clean up channels?

**Correct explanation:** To prevent unused subscriptions and resource leakage.

## Answer 9

**Question:** What is an Edge Function?

**Correct explanation:** Server-side function code deployed to a supported edge runtime.

## Answer 10

**Question:** Are Realtime and Edge Functions automatically secure?

**Correct explanation:** No. Correct authorization, RLS, caller validation, and secret handling are required.


Do all experiments in a test project, never on ProTrack MX production.