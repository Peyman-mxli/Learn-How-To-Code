# Class 08 — Answer Key: Authentication and User Profiles

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

**Review after attempting the questions.** Some open-ended answers may be phrased differently and still be correct if the core concepts are accurate.

## Answer 01

**Question:** Define authentication.

**Reference answer:** CREATE TABLE means make a profile table. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 02

**Question:** Differentiate profile from auth user.

**Reference answer:** public.demo_teacher_profiles means profile table in the public schema. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 03

**Question:** Explain UUID.

**Reference answer:** user_id UUID means use a UUID for the identity reference. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 04

**Question:** Explain auth.users.

**Reference answer:** PRIMARY KEY means allow one profile per user ID. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 05

**Question:** Explain a session.

**Reference answer:** REFERENCES auth.users(id) means link to the Supabase Auth users table. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 06

**Question:** Explain sign-in.

**Reference answer:** ON DELETE CASCADE means delete the related profile if the referenced user is removed. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 07

**Question:** Explain auth.uid().

**Reference answer:** display_name TEXT NOT NULL means required profile display name. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 08

**Question:** Explain password handling.

**Reference answer:** CREATE TABLE means make a profile table. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 09

**Question:** Explain RLS for profiles.

**Reference answer:** public.demo_teacher_profiles means profile table in the public schema. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 10

**Question:** Distinguish authentication from authorization.

**Reference answer:** user_id UUID means use a UUID for the identity reference. In authentication and user profiles, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.


## Safety Reminder

Correct-looking SQL is not necessarily secure SQL. Never use these notes alone as permission to alter the production ProTrack MX database.