# Practical Lab — Fix Repeated Names

[Lesson](./README.md) · [Questions](./QUESTIONS.md) · [Answers](./ANSWERS.md)

**Environment:** Disposable PostgreSQL dev connection. Never use the production ProTrack MX project or real student data.

## 1. Practical Demonstration

```sql
CREATE TEMP TABLE lab_staff(id int PRIMARY KEY,name text NOT NULL);
CREATE TEMP TABLE lab_subjects(id int PRIMARY KEY,teacher_id int NOT NULL REFERENCES lab_staff(id),subject text NOT NULL);
INSERT INTO lab_staff VALUES(1,'Ali');
INSERT INTO lab_subjects VALUES(10,1,'Math'),(11,1,'Physics');
SELECT s.name,x.subject FROM lab_staff s JOIN lab_subjects x ON x.teacher_id=s.id ORDER BY x.id;
```

**Expected result:** Two subject rows share teacher Ali without storing Ali's name twice.

## 2. One-at-a-Time Question

**Question:** Why keep teacher_name out of each lab_subjects row?

**Answer:** To reduce data duplication and inconsistent updates.

## 3. Troubleshooting Exercise

**Mistake:** Delete the parent teacher while children still reference it.

**Correct reasoning:** Foreign-key restrictions typically prevent it unless a deliberate ON DELETE behavior is chosen.

## 4. Make It Your Own

Explain what each keyword or method does, what assumptions the example relies on, how a user would see the outcome in ProTrack MX, and what would happen with unauthorized data.

## Lab Completion

- [ ] Predicted outcome before running.
- [ ] Understood all statements, expressions and symbols.
- [ ] Diagnosed the mistake.
- [ ] Identified data privacy and permission requirements.
