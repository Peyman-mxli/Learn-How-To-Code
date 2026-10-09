# Class 09 — Answer Key: Authorization, Grants, and Row Level Security

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## 1. Authorization
Authorization determines which data and operations a user may access. Authentication verifies identity but does not grant universal access.

## 2. GRANT
`GRANT SELECT ON public.demo_teacher_profiles TO authenticated;` grants read privilege on the table to the authenticated database role. RLS can additionally limit rows.

## 3. REVOKE
`REVOKE` removes listed privileges. Other role membership, functions, and privileged connections can still create alternate paths; evaluate the full security design.

## 4. RLS
Row Level Security uses PostgreSQL policies to govern which rows particular roles may read, insert, update, or delete.

## 5. ENABLE ROW LEVEL SECURITY
`ALTER TABLE ... ENABLE ROW LEVEL SECURITY` enables policies on the specified table. You still need correct privileges and policies.

## 6. CREATE POLICY
`CREATE POLICY` declares a per-table rule for selected SQL commands and applicable roles.

## 7. USING
`USING (user_id = (SELECT auth.uid()))` lets an authenticated user read only rows whose user_id matches their identity, provided the surrounding permissions and RLS configuration are correct.

## 8. WITH CHECK
`WITH CHECK` validates the **new row state** for INSERT/UPDATE; `USING` typically determines which **existing rows** a role may see or target.

## 9. auth.uid()
Supabase function returning the requesting authenticated user's identifier; under an unauthenticated context this may be NULL.

## 10. Why SQL Editor Success Is Insufficient
SQL Editor connections can have elevated privileges and may bypass row policies. Test both authorized and unauthorized access with normal user sessions, including attempts to insert and update other users' records.

**Safety:** Do not alter ProTrack MX production security from examples. [PostgreSQL RLS](https://www.postgresql.org/docs/current/ddl-rowsecurity.html) · [Supabase RLS](https://supabase.com/docs/guides/database/postgres/row-level-security)
