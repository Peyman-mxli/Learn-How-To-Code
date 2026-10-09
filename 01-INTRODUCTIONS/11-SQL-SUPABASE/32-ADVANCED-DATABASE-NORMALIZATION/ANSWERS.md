# Class 32 — Answer Explanations

[Lesson](./README.md) · [Questions](./QUESTIONS.md)

## Answer 1

**Question:** What is normalization?

**Explanation:** Structuring relations to reduce unnecessary redundancy and data anomalies.

## Answer 2

**Question:** What is a functional dependency?

**Explanation:** A set of attributes uniquely determines another set's value in a relation.

## Answer 3

**Question:** What is 1NF?

**Explanation:** Use proper scalar relational attributes without repeating groups.

## Answer 4

**Question:** What is 2NF?

**Explanation:** Meet 1NF and avoid non-key attribute dependence on part of a candidate key.

## Answer 5

**Question:** What is 3NF?

**Explanation:** Meet 2NF and avoid non-key dependencies that create transitive redundancy under the standard definition.

## Answer 6

**Question:** What is an update anomaly?

**Explanation:** Inconsistent data when duplicated facts are only partly changed.

## Answer 7

**Question:** What is an insertion anomaly?

**Explanation:** A model prevents adding one fact without unrelated data.

## Answer 8

**Question:** What is a deletion anomaly?

**Explanation:** Removing a row accidentally removes a separate fact.

## Answer 9

**Question:** Why a composite primary key?

**Explanation:** Use several columns jointly to identify a row uniquely.

## Answer 10

**Question:** When should denormalization be considered?

**Explanation:** Deliberately, when measured workload warrants duplication and consistency handling is designed.


Check your reasoning against the main example and official documentation.