# Class 05 — Answer Key: Relational Design and Relationships

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

**Review after attempting the questions.** Some open-ended answers may be phrased differently and still be correct if the core concepts are accurate.

## Answer 01

**Question:** Define primary key.

**Reference answer:** CREATE TABLE means create a new relation. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 02

**Question:** Define foreign key.

**Reference answer:** demo_teachers means parent table storing teachers. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 03

**Question:** Explain one-to-many.

**Reference answer:** id INTEGER means numeric identifier. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 04

**Question:** Explain many-to-many.

**Reference answer:** GENERATED ALWAYS AS IDENTITY means generate the id using a sequence. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 05

**Question:** Choose a join table for enrollments.

**Reference answer:** PRIMARY KEY means ensure unique non-NULL identifiers. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 06

**Question:** Explain composite primary keys.

**Reference answer:** demo_classes means child table storing classes. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 07

**Question:** Explain referential integrity.

**Reference answer:** teacher_id means column that identifies a teacher. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 08

**Question:** Explain why duplicate data is risky.

**Reference answer:** REFERENCES demo_teachers(id) means foreign key requiring a referenced teacher. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 09

**Question:** Explain why a foreign key is not authorization.

**Reference answer:** title TEXT NOT NULL means non-NULL class title. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.

## Answer 10

**Question:** Outline a classes-and-students relationship.

**Reference answer:** CREATE TABLE means create a new relation. In relational design and relationships, connect that meaning to the illustrative ProTrack MX scenario rather than treating it as a permission to access real records.


## Safety Reminder

Correct-looking SQL is not necessarily secure SQL. Never use these notes alone as permission to alter the production ProTrack MX database.