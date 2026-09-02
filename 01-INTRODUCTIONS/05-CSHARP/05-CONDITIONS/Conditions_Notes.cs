using System;

# /*

05 - CONDITIONS
Conditions_Notes.cs
===================

In this module, I learn how programs make
decisions using conditions.

Conditions allow a program to execute different
code depending on whether something is true
or false.

Conditions are used in:

* Games
* Login Systems
* Menus
* Business Software
* Mobile Applications
* Web Applications

==================================================

1. WHAT IS A CONDITION?
   ==================================================

A condition is an expression that evaluates to:

true

or

false

Example:

10 > 5

Result:

true

Example:

5 > 10

Result:

false

Conditions allow programs to make decisions.

==================================================
2. BOOLEAN VALUES
=================

Conditions work with boolean values.

A boolean can only contain:

true
false

Example:

bool isOnline = true;

Example:

bool isDead = false;

==================================================
3. IF STATEMENT
===============

The if statement executes code only when a
condition is true.

Syntax:

if (condition)
{
// Code
}

Example:

if (10 > 5)
{
Console.WriteLine("Condition is true");
}

==================================================
4. HOW IF WORKS
===============

Step 1:

Evaluate condition.

Step 2:

If condition is true:

Execute code block.

Step 3:

If condition is false:

Skip code block.

==================================================
5. ELSE STATEMENT
=================

The else statement executes when the if
condition is false.

Syntax:

if (condition)
{
// True code
}
else
{
// False code
}

Example:

int age = 15;

if (age >= 18)
{
Console.WriteLine("Adult");
}
else
{
Console.WriteLine("Minor");
}

==================================================
6. ELSE IF STATEMENT
====================

Used when checking multiple conditions.

Syntax:

if (condition1)
{
}
else if (condition2)
{
}
else
{
}

Example:

int score = 85;

if (score >= 90)
{
Console.WriteLine("A");
}
else if (score >= 80)
{
Console.WriteLine("B");
}
else
{
Console.WriteLine("C");
}

==================================================
7. MULTIPLE ELSE IF BLOCKS
==========================

A program may contain many else if statements.

Example:

if (score >= 90)
{
}
else if (score >= 80)
{
}
else if (score >= 70)
{
}
else if (score >= 60)
{
}
else
{
}

The first true condition executes.

==================================================
8. COMPARISON OPERATORS
=======================

Conditions often use comparison operators.

== Equal To

!= Not Equal To

> Greater Than

< Less Than

> = Greater Than Or Equal

<= Less Than Or Equal

Example:

if (age >= 18)

==================================================
9. LOGICAL AND (&&)
===================

Both conditions must be true.

Example:

if (age >= 18 && hasLicense)
{
Console.WriteLine("Can Drive");
}

==================================================
10. LOGICAL OR (||)
===================

Only one condition must be true.

Example:

if (isAdmin || isModerator)
{
Console.WriteLine("Access Granted");
}

==================================================
11. LOGICAL NOT (!)
===================

Reverses a boolean value.

Example:

if (!isBanned)
{
Console.WriteLine("Can Login");
}

==================================================
12. NESTED CONDITIONS
=====================

A condition inside another condition.

Example:

if (age >= 18)
{
if (hasLicense)
{
Console.WriteLine("Can Drive");
}
}

==================================================
13. REAL-WORLD EXAMPLE
======================

Login System

string password = "1234";

if (password == "1234")
{
Console.WriteLine("Login Successful");
}
else
{
Console.WriteLine("Login Failed");
}

==================================================
14. GAME EXAMPLE
================

int health = 0;

if (health <= 0)
{
Console.WriteLine("Player Dead");
}
else
{
Console.WriteLine("Player Alive");
}

==================================================
15. GRADE EXAMPLE
=================

int grade = 75;

if (grade >= 60)
{
Console.WriteLine("Passed");
}
else
{
Console.WriteLine("Failed");
}

==================================================
16. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Using = instead of ==

Incorrect:

if (age = 18)

Correct:

if (age == 18)

---

Mistake 2:

Forgetting curly braces.

---

Mistake 3:

Using invalid logic.

Example:

if (score > 100)

when score can never exceed 100.

---

Mistake 4:

Incorrect condition order.

Example:

if (score >= 60)
{
}
else if (score >= 90)
{
}

The 90 condition will never be reached.

==================================================
17. BEST PRACTICES
==================

* Keep conditions simple.
* Use meaningful variable names.
* Avoid deeply nested conditions.
* Use logical operators carefully.
* Test both true and false outcomes.
* Format code clearly.

==================================================
SUMMARY
=======

In this module, I learned:

✓ Conditions
✓ Boolean Values
✓ If Statements
✓ Else Statements
✓ Else If Statements
✓ Comparison Operators
✓ Logical Operators
✓ Nested Conditions
✓ Login Examples
✓ Game Examples
✓ Grade Examples
✓ Common Mistakes
✓ Best Practices

Conditions allow programs to make decisions
and respond differently depending on the
situation.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
