using System;

# /*

07 - ARRAYS
Arrays_Notes.cs
===============

In this module, I learn how to store multiple
values using arrays in C#.

An array is a collection that stores multiple
values of the same data type.

Arrays help keep related data organized.

==================================================

1. WHAT IS AN ARRAY?
   ==================================================

An array is a container that can hold multiple
values.

Example:

string[] names =
{
"Peyman",
"John",
"Maria"
};

Instead of creating:

string name1 = "Peyman";
string name2 = "John";
string name3 = "Maria";

I can use one array.

==================================================
2. WHY USE ARRAYS?
==================

Arrays help:

* Store multiple values
* Reduce repeated variables
* Organize related information
* Work efficiently with loops
* Process large amounts of data

==================================================
3. ARRAY DECLARATION
====================

Syntax:

dataType[] arrayName;

Example:

int[] numbers;

This creates an array variable.

==================================================
4. ARRAY CREATION
=================

Arrays need a size.

Example:

int[] numbers = new int[5];

This creates an array with:

5 positions

Indexes:

0
1
2
3
4

==================================================
5. ARRAY INITIALIZATION
=======================

Arrays can be created and assigned values
at the same time.

Example:

int[] numbers =
{
10,
20,
30,
40,
50
};

==================================================
6. ARRAY INDEXES
================

Each value inside an array has an index.

Indexes start at:

0

Example:

string[] colors =
{
"Red",
"Green",
"Blue"
};

Indexes:

colors[0] = Red
colors[1] = Green
colors[2] = Blue

==================================================
7. ACCESSING VALUES
===================

Use the index number.

Example:

string[] colors =
{
"Red",
"Green",
"Blue"
};

Console.WriteLine(colors[0]);

Output:

Red

==================================================
8. ACCESSING DIFFERENT INDEXES
==============================

Example:

Console.WriteLine(colors[1]);

Output:

Green

Example:

Console.WriteLine(colors[2]);

Output:

Blue

==================================================
9. MODIFYING VALUES
===================

Array values can be changed.

Example:

string[] colors =
{
"Red",
"Green",
"Blue"
};

colors[1] = "Yellow";

Result:

Red
Yellow
Blue

==================================================
10. ARRAY LENGTH
================

The Length property returns the number of
elements in an array.

Example:

int[] numbers =
{
10,
20,
30,
40,
50
};

Console.WriteLine(numbers.Length);

Output:

5

==================================================
11. LOOPING THROUGH ARRAYS
==========================

Arrays are commonly used with loops.

Example:

int[] numbers =
{
10,
20,
30
};

for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine(numbers[i]);
}

Output:

10
20
30

==================================================
12. FOREACH LOOP
================

The foreach loop is designed to work with
collections such as arrays.

Example:

string[] names =
{
"Peyman",
"John",
"Maria"
};

foreach (string name in names)
{
Console.WriteLine(name);
}

Output:

Peyman
John
Maria

==================================================
13. ARRAY OF STRINGS
====================

Example:

string[] countries =
{
"Mexico",
"Canada",
"Japan"
};

==================================================
14. ARRAY OF INTEGERS
=====================

Example:

int[] scores =
{
80,
90,
100
};

==================================================
15. ARRAY OF DOUBLES
====================

Example:

double[] prices =
{
9.99,
19.99,
29.99
};

==================================================
16. ARRAY OF BOOLEANS
=====================

Example:

bool[] status =
{
true,
false,
true
};

==================================================
17. COMMON ARRAY ERRORS
=======================

Accessing an index that does not exist.

Example:

int[] numbers =
{
10,
20,
30
};

Console.WriteLine(numbers[5]);

Error:

IndexOutOfRangeException

==================================================
18. SAFE ARRAY ACCESS
=====================

Always use Length when looping.

Correct:

for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine(numbers[i]);
}

This prevents invalid indexes.

==================================================
19. REAL-WORLD EXAMPLES
=======================

School Example:

Store student grades.

---

Game Example:

Store inventory items.

---

Store Example:

Store product prices.

---

Sports Example:

Store player scores.

==================================================
20. BEST PRACTICES
==================

* Use meaningful array names.
* Keep related values together.
* Use Length when looping.
* Avoid invalid indexes.
* Use foreach when possible.
* Choose the correct data type.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What arrays are
✓ Why arrays matter
✓ Array declaration
✓ Array creation
✓ Array initialization
✓ Array indexes
✓ Accessing values
✓ Modifying values
✓ Array Length
✓ For loops with arrays
✓ Foreach loops
✓ Arrays of strings
✓ Arrays of integers
✓ Arrays of doubles
✓ Arrays of booleans
✓ Common errors
✓ Best practices

Arrays allow me to store and manage multiple
values efficiently inside my programs.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
