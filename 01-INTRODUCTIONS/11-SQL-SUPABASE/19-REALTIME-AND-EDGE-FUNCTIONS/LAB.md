# Practical Lab — Subscribe and Unsubscribe

[Main lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Conceptual JavaScript exercise; only run with a configured development Supabase client, dummy files/data and matching permissions.

## Step 1 — Core exercise

```javascript
const channel = supabase.channel('lab-updates').on('postgres_changes', { event: 'UPDATE', schema: 'public', table: 'demo_classes' }, payload => console.log(payload)).subscribe();
// Later: await supabase.removeChannel(channel);
```

**Expected result/behavior:** Only when configured and authorized, matching change events are delivered; cleanup stops the subscription.

## Step 2 — Check your understanding

**Question:** What does subscribe activate?

**Answer:** The Realtime subscription connection.

## Step 3 — Troubleshooting scenario

**Issue:** Assume subscribing grants permission to any class updates.

**Diagnosis or correction:** False; publication configuration, permissions and RLS still apply.

## Step 4 — Explain it aloud

Identify what the action does, which object/table/service it targets, which clause limits results, what error or permission is possible, and what would happen if an assumption changes.

## Step 5 — ProTrack MX safety challenge

Describe how you would protect fictional teachers, classes and assessment records while applying this concept. Do not experiment with the production project. Always test both permitted and denied access when applicable.

## Completion checklist

- [ ] Expected output understood.
- [ ] Every important keyword understood.
- [ ] Error or risk explained.
- [ ] Only isolated test data or conceptual examples used.
