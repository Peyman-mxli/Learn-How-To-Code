# Class 19 — Supabase Realtime and Edge Functions

[Course Index](../README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

## Learning Goals

By the end of this class you should be able to explain the whole example word by word, describe the use case, identify its risks, and respond to ten checks without looking up the answers.

## 1. Setup and Assumptions

A private development database contains a fictional class record. A browser has a configured authenticated Supabase JS client. Changes should only be delivered to users allowed to see them.

## 2. Worked Example

```javascript
const channel = supabase
  .channel('demo-class-updates')
  .on('postgres_changes', {
    event: 'UPDATE', schema: 'public', table: 'demo_classes'
  }, (payload) => {
    console.log('A class changed', payload.new.id);
  })
  .subscribe();
```

### Every Important Part Explained

| Part | Meaning |
|---|---|
| `const` | Declare a JavaScript variable. |
| `supabase.channel` | Create a named Realtime channel subscription. |
| `.on` | Register a handler for a particular event source. |
| `postgres_changes` | Listen for supported Postgres change events. |
| `event: 'UPDATE'` | Subscribe to updates rather than all events. |
| `schema: 'public'` | Limit to a PostgreSQL schema. |
| `table: 'demo_classes'` | Limit to the named table. |
| `payload` | Event information supplied to a callback. |
| `.subscribe()` | Connect and subscribe to the channel. |

### Step-by-step reading

1. **const:** Declare a JavaScript variable.
2. **supabase.channel:** Create a named Realtime channel subscription.
3. **.on:** Register a handler for a particular event source.
4. **postgres_changes:** Listen for supported Postgres change events.
5. **event: 'UPDATE':** Subscribe to updates rather than all events.
6. **schema: 'public':** Limit to a PostgreSQL schema.
7. **table: 'demo_classes':** Limit to the named table.
8. **payload:** Event information supplied to a callback.
9. **.subscribe():** Connect and subscribe to the channel.

## 3. Related Example

```javascript
// Cleanup when the component/session no longer needs the channel:
await supabase.removeChannel(channel);

// Conceptual Edge Function invocation:
const { data, error } = await supabase.functions.invoke('demo-health-check', {
  body: { ping: true }
});
```

Read the comments and explain why the additional statement matters. Do not confuse an event, callback, or SQL command with a security guarantee.

## 4. ProTrack MX Scenario

Imagine an educator signing in to check class data, submit assessments and review trimester grades. Only the teacher's authorized records should be accessible. Avoid committing secrets or any real student data; use independent test users and simulated classes.

## 5. Important Security and Operational Warnings

A Realtime subscription is not a substitute for authorization. Configure publication/change-event availability, RLS and channel access as required for the chosen Realtime mode. Edge Functions run server-side but must verify callers, authorize requests, and protect secrets.

## 6. Practice Exercises

1. What is Realtime?
2. What is a channel?
3. What does .on do?
4. What does postgres_changes mean?
5. What does event UPDATE select?
6. What is payload?
7. Why call subscribe?
8. Why clean up channels?
9. What is an Edge Function?
10. Are Realtime and Edge Functions automatically secure?

Use the separate [QUESTIONS.md](./QUESTIONS.md) and wait until after answering before reviewing [ANSWERS.md](./ANSWERS.md).

## 7. Final Checklist

- [ ] I understand each keyword and example.
- [ ] I know what is and is not guaranteed.
- [ ] I understand the security checks and possible failures.
- [ ] I completed the ten practice questions.

## Official Documentation

- [Supabase Documentation](https://supabase.com/docs)
- [PostgreSQL Documentation](https://www.postgresql.org/docs/current/)
- [Supabase Realtime](https://supabase.com/docs/guides/realtime)
- [Supabase Edge Functions](https://supabase.com/docs/guides/functions)
