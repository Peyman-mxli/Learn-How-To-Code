using System;

# /*

06 - LOOPS
Loops_Notes.cs
==============

In this module, I learn how to repeat code in C#.

Loops allow a program to execute the same block
of code multiple times.

Instead of writing the same instruction again
and again, I can use a loop.

Loops are useful for:

* Counting numbers
* Repeating menus
* Processing data
* Running game logic
* Validating input
* Working with arrays later

==================================================

1. WHAT IS A LOOP?
   ==================================================

A loop is a programming structure that repeats
a block of code while a condition is true or
for a specific number of times.

Example:

for (int i = 1; i <= 5; i++)
{
Console.WriteLine(i);
}

This prints numbers from 1 to 5.

==================================================
2. WHY LOOPS ARE IMPORTANT
==========================

Without loops, repeated code becomes messy.

Example without loop:

Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);

Example with loop:

for (int i = 1; i <= 5; i++)
{
Console.WriteLine(i);
}

The loop version is cleaner and easier to update.

==================================================
3. FOR LOOP
===========

A for loop repeats code a specific number of times.

Syntax:

for (initialization; condition; update)
{
// Code to repeat
}

Example:

for (int i = 1; i <= 5; i++)
{
Console.WriteLine(i);
}

Parts of a for loop:

1. Initialization:
   int i = 1

2. Condition:
   i <= 5

3. Update:
   i++

==================================================
4. LOOP COUNTER
===============

A loop counter controls how many times a loop runs.

Example:

int i = 1;

The variable i is commonly used as a counter.

Each time the loop repeats, i can increase or
decrease.

==================================================
5. FOR LOOP EXECUTION FLOW
==========================

Example:

for (int i = 1; i <= 3; i++)
{
Console.WriteLine(i);
}

Execution:

Start: i = 1
Check: i <= 3 true
Print: 1
Update: i++

Now i = 2

Check: i <= 3 true
Print: 2
Update: i++

Now i = 3

Check: i <= 3 true
Print: 3
Update: i++

Now i = 4

Check: i <= 3 false
Stop loop

==================================================
6. WHILE LOOP
=============

A while loop repeats code while a condition
is true.

Syntax:

while (condition)
{
// Code to repeat
}

Example:

int count = 1;

while (count <= 5)
{
Console.WriteLine(count);
count++;
}

The condition is checked before the loop runs.

==================================================
7. DO WHILE LOOP
================

A do while loop runs the code at least once,
then checks the condition.

Syntax:

do
{
// Code to repeat
}
while (condition);

Example:

int number = 1;

do
{
Console.WriteLine(number);
number++;
}
while (number <= 5);

This loop always runs at least one time.

==================================================
8. DIFFERENCE BETWEEN WHILE AND DO WHILE
========================================

while loop:

Checks condition first.

do while loop:

Runs first, checks condition after.

Example:

int number = 10;

while (number < 5)
{
Console.WriteLine("While Loop");
}

This does not run.

do
{
Console.WriteLine("Do While Loop");
}
while (number < 5);

This runs once.

==================================================
9. BREAK STATEMENT
==================

break stops a loop immediately.

Example:

for (int i = 1; i <= 10; i++)
{
if (i == 5)
{
break;
}

```
Console.WriteLine(i);
```

}

The loop stops when i equals 5.

==================================================
10. CONTINUE STATEMENT
======================

continue skips the current loop repetition and
moves to the next one.

Example:

for (int i = 1; i <= 5; i++)
{
if (i == 3)
{
continue;
}

```
Console.WriteLine(i);
```

}

This skips number 3.

==================================================
11. NESTED LOOPS
================

A nested loop is a loop inside another loop.

Example:

for (int row = 1; row <= 3; row++)
{
for (int column = 1; column <= 3; column++)
{
Console.WriteLine("Row " + row + " Column " + column);
}
}

Nested loops are useful for grids, tables,
patterns, and game maps.

==================================================
12. INFINITE LOOPS
==================

An infinite loop repeats forever because its
condition never becomes false.

Example:

while (true)
{
Console.WriteLine("This never stops");
}

Infinite loops can freeze or overload programs
if they are not controlled carefully.

==================================================
13. HOW TO AVOID INFINITE LOOPS
===============================

To avoid infinite loops:

* Make sure the condition can become false.
* Update counters correctly.
* Use break when needed.
* Test loop logic carefully.

Incorrect:

int i = 1;

while (i <= 5)
{
Console.WriteLine(i);
}

Correct:

int i = 1;

while (i <= 5)
{
Console.WriteLine(i);
i++;
}

==================================================
14. REAL-WORLD EXAMPLES
=======================

Menu Example:

Keep showing a menu until the user chooses exit.

---

Game Example:

Repeat enemy movement while the enemy is alive.

---

School Example:

Calculate grades for multiple students.

---

Store Example:

Process all items in a shopping cart.

==================================================
15. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Forgetting to update the counter.

---

Mistake 2:

Using the wrong condition.

---

Mistake 3:

Creating an infinite loop by accident.

---

Mistake 4:

Confusing break and continue.

break stops the loop.

continue skips one repetition.

---

Mistake 5:

Using nested loops without understanding how many
times they run.

==================================================
16. BEST PRACTICES
==================

* Use clear loop conditions.
* Use meaningful counter names when possible.
* Avoid infinite loops unless controlled.
* Keep loop code simple.
* Use break and continue carefully.
* Test the first and last loop values.
* Avoid deeply nested loops when possible.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What loops are
✓ Why loops matter
✓ For loops
✓ Loop counters
✓ While loops
✓ Do while loops
✓ Break statement
✓ Continue statement
✓ Nested loops
✓ Infinite loops
✓ Real-world examples
✓ Common mistakes
✓ Best practices

Loops help me repeat code efficiently and make
programs cleaner, smarter, and more powerful.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
