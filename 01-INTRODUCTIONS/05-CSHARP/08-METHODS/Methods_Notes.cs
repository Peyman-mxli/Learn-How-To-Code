using System;

# /*

08 - METHODS
Methods_Notes.cs
================

In this module, I learn how to organize and
reuse code using methods.

Methods are one of the most important concepts
in programming because they help keep programs
clean, organized, and easier to maintain.

==================================================

1. WHAT IS A METHOD?
   ==================================================

A method is a reusable block of code that
performs a specific task.

Example:

SayHello();

Instead of writing the same code multiple times,
I can place it inside a method and call it
whenever I need it.

==================================================
2. WHY USE METHODS?
===================

Methods help:

* Reuse code
* Reduce duplication
* Improve readability
* Organize programs
* Simplify debugging
* Make maintenance easier

Without methods, programs can become very large
and difficult to understand.

==================================================
3. METHOD SYNTAX
================

Basic Syntax:

returnType MethodName()
{
// Code
}

Example:

void SayHello()
{
Console.WriteLine("Hello");
}

==================================================
4. METHOD NAME
==============

The method name describes what the method does.

Examples:

DisplayMenu()
CalculateTotal()
CreateCharacter()
AttackEnemy()

Good method names improve readability.

==================================================
5. RETURN TYPE
==============

The return type specifies what a method returns.

Examples:

void
int
double
string
bool

Example:

int GetLevel()
{
return 10;
}

==================================================
6. VOID METHODS
===============

A void method does not return a value.

Example:

void ShowMessage()
{
Console.WriteLine("Welcome");
}

Usage:

ShowMessage();

==================================================
7. CALLING A METHOD
===================

Creating a method does not automatically run it.

A method must be called.

Example:

ShowMessage();

The code inside the method executes when called.

==================================================
8. METHODS WITH PARAMETERS
==========================

Parameters allow data to be passed into a method.

Example:

void SayHello(string name)
{
Console.WriteLine("Hello " + name);
}

Usage:

SayHello("Peyman");

Output:

Hello Peyman

==================================================
9. MULTIPLE PARAMETERS
======================

Methods can accept multiple parameters.

Example:

void DisplayPlayer(string name, int level)
{
Console.WriteLine(name);
Console.WriteLine(level);
}

Usage:

DisplayPlayer("Peyman", 10);

==================================================
10. RETURN VALUES
=================

Methods can return data.

Example:

int AddNumbers()
{
return 10 + 5;
}

Usage:

int result = AddNumbers();

==================================================
11. RETURNING STRINGS
=====================

Example:

string GetPlayerName()
{
return "Peyman";
}

Usage:

string playerName = GetPlayerName();

==================================================
12. RETURNING BOOLEANS
======================

Example:

bool IsAlive()
{
return true;
}

Usage:

bool alive = IsAlive();

==================================================
13. RETURNING DOUBLES
=====================

Example:

double GetPrice()
{
return 19.99;
}

Usage:

double price = GetPrice();

==================================================
14. PARAMETERS AND RETURNS
==========================

Methods can accept parameters and return values.

Example:

int Add(int a, int b)
{
return a + b;
}

Usage:

int result = Add(10, 20);

Output:

30

==================================================
15. METHOD REUSE
================

Methods can be called many times.

Example:

SayHello("Peyman");
SayHello("Maria");
SayHello("John");

This avoids repeated code.

==================================================
16. REAL-WORLD EXAMPLES
=======================

Game Example:

AttackEnemy();

---

Store Example:

CalculateTotal();

---

School Example:

CalculateAverageGrade();

---

Bank Example:

WithdrawMoney();

==================================================
17. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Forgetting parentheses.

Incorrect:

ShowMessage;

Correct:

ShowMessage();

---

Mistake 2:

Calling a method with missing parameters.

Incorrect:

SayHello();

Correct:

SayHello("Peyman");

---

Mistake 3:

Forgetting return statements.

Incorrect:

int GetNumber()
{
}

Correct:

int GetNumber()
{
return 10;
}

---

Mistake 4:

Using the wrong return type.

==================================================
18. BEST PRACTICES
==================

* Use clear method names.
* Keep methods focused on one task.
* Avoid extremely long methods.
* Reuse methods whenever possible.
* Use parameters to make methods flexible.
* Return values when needed.
* Keep code organized.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What methods are
✓ Why methods matter
✓ Method syntax
✓ Return types
✓ Void methods
✓ Calling methods
✓ Parameters
✓ Multiple parameters
✓ Return values
✓ Method reuse
✓ Real-world examples
✓ Common mistakes
✓ Best practices

Methods help me organize programs into small,
reusable pieces that make code easier to build,
understand, and maintain.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
