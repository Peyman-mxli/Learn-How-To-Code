using System;

# /*

04 - OPERATORS
Operators_Notes.cs
==================

In this module, I learn about operators in C#.

Operators are special symbols that perform actions
on values and variables.

Operators are used for:

* Calculations
* Comparisons
* Assignments
* Decision Making
* Game Logic
* Business Applications

Almost every C# program uses operators.

==================================================

1. WHAT IS AN OPERATOR?
   ==================================================

An operator is a symbol that performs an operation.

Example:

int result = 5 + 3;

Operator:

*

Result:

8

==================================================
2. ARITHMETIC OPERATORS
=======================

Arithmetic operators perform mathematical
calculations.

---

## Addition (+)

Example:

int result = 10 + 5;

Result:

15

---

## Subtraction (-)

Example:

int result = 10 - 5;

Result:

5

---

## Multiplication (*)

Example:

int result = 10 * 5;

Result:

50

---

## Division (/)

Example:

int result = 10 / 5;

Result:

2

---

## Modulus (%)

Returns the remainder after division.

Example:

int result = 10 % 3;

Result:

1

Because:

10 ÷ 3 = 3 remainder 1

==================================================
3. ASSIGNMENT OPERATOR (=)
==========================

The assignment operator stores a value inside
a variable.

Example:

int age = 25;

Value Assigned:

25

Variable:

age

==================================================
4. COMPOUND ASSIGNMENT OPERATORS
================================

These operators combine assignment and arithmetic.

---

## +=

Example:

int score = 10;

score += 5;

Result:

15

Equivalent To:

score = score + 5;

---

## -=

Example:

score -= 2;

Result:

13

---

## *=

Example:

score *= 2;

Result:

26

---

## /=

Example:

score /= 2;

Result:

13

---

## %=

Example:

score %= 5;

Result:

3

==================================================
5. COMPARISON OPERATORS
=======================

Comparison operators compare values.

The result is always:

true
or
false

---

## Equal To (==)

Example:

5 == 5

Result:

true

---

## Not Equal To (!=)

Example:

5 != 3

Result:

true

---

## Greater Than (>)

Example:

10 > 5

Result:

true

---

## Less Than (<)

Example:

5 < 10

Result:

true

---

## Greater Than Or Equal (>=)

Example:

10 >= 10

Result:

true

---

## Less Than Or Equal (<=)

Example:

5 <= 10

Result:

true

==================================================
6. BOOLEAN RESULTS
==================

Comparison operators return boolean values.

Example:

bool result = 10 > 5;

Value:

true

Example:

bool result = 10 < 5;

Value:

false

==================================================
7. LOGICAL OPERATORS
====================

Logical operators combine multiple conditions.

---

## AND (&&)

Both conditions must be true.

Example:

bool result = (10 > 5) && (20 > 10);

Result:

true

---

## OR (||)

Only one condition must be true.

Example:

bool result = (10 > 5) || (5 > 10);

Result:

true

---

## NOT (!)

Reverses a boolean value.

Example:

bool isStudent = true;

bool result = !isStudent;

Result:

false

==================================================
8. INCREMENT OPERATOR (++)
==========================

Increases a value by one.

Example:

int level = 5;

level++;

Result:

6

Equivalent To:

level = level + 1;

==================================================
9. DECREMENT OPERATOR (--)
==========================

Decreases a value by one.

Example:

int lives = 5;

lives--;

Result:

4

Equivalent To:

lives = lives - 1;

==================================================
10. PRE-INCREMENT
=================

Example:

int number = 5;

++number;

Result:

6

The value changes before it is used.

==================================================
11. POST-INCREMENT
==================

Example:

int number = 5;

number++;

Result:

6

The value is used first and then increased.

==================================================
12. OPERATOR PRECEDENCE
=======================

C# follows mathematical order of operations.

Example:

int result = 5 + 2 * 3;

Result:

11

Because multiplication happens first.

Equivalent To:

5 + (2 * 3)

==================================================
13. USING PARENTHESES
=====================

Parentheses change execution order.

Example:

int result = (5 + 2) * 3;

Result:

21

Because:

(5 + 2) = 7

7 * 3 = 21

==================================================
14. REAL-WORLD EXAMPLES
=======================

Game Example:

int playerHealth = 100;

playerHealth -= 25;

Result:

75

---

Store Example:

double price = 50.00;
double discount = 10.00;

double finalPrice = price - discount;

Result:

40.00

---

School Example:

bool passed = score >= 60;

Result:

true or false

==================================================
15. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Using = instead of ==

Incorrect:

if (age = 18)

Correct:

if (age == 18)

---

Mistake 2:

Forgetting parentheses

Incorrect:

5 + 2 * 3

May produce unexpected results.

---

Mistake 3:

Dividing integers incorrectly

Example:

int result = 5 / 2;

Result:

2

Not:

2.5

Because both values are integers.

==================================================
16. BEST PRACTICES
==================

* Use meaningful variable names.
* Use parentheses when clarity is important.
* Keep calculations simple.
* Test comparison logic carefully.
* Avoid complex expressions when possible.
* Use logical operators clearly.

==================================================
SUMMARY
=======

In this module, I learned:

✓ Arithmetic Operators
✓ Assignment Operators
✓ Compound Assignment Operators
✓ Comparison Operators
✓ Boolean Results
✓ Logical Operators
✓ Increment Operator
✓ Decrement Operator
✓ Operator Precedence
✓ Parentheses
✓ Real-World Examples
✓ Common Mistakes
✓ Best Practices

Operators allow programs to calculate values,
compare information, update variables, and make
decisions. They are one of the most important
fundamental concepts in C# programming.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
