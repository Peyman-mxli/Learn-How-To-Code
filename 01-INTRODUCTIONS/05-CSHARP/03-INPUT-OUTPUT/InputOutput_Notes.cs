using System;

# /*

03 - INPUT & OUTPUT
InputOutput_Notes.cs
====================

In this module, I learn how programs communicate
with users.

Communication happens through:

1. Input
2. Output

Output displays information to the user.

Input receives information from the user.

These concepts are fundamental because almost
every application interacts with users in some way.

==================================================

1. WHAT IS OUTPUT?
   ==================================================

Output is information sent from a program to
the user.

In Console Applications, output is usually
displayed in the console window.

Example:

Console.WriteLine("Hello World");

The message appears on the screen.

==================================================
2. Console.WriteLine()
======================

Console.WriteLine() displays text and then
moves the cursor to the next line.

Example:

Console.WriteLine("First Line");
Console.WriteLine("Second Line");

Output:

First Line
Second Line

Each WriteLine creates a new line.

==================================================
3. Console.Write()
==================

Console.Write() displays text without moving
to the next line.

Example:

Console.Write("Hello ");
Console.Write("World");

Output:

Hello World

The cursor remains on the same line.

==================================================
4. DIFFERENCE BETWEEN
WriteLine() AND Write()
=======================

WriteLine():

Console.WriteLine("A");
Console.WriteLine("B");

Output:

A
B

Write():

Console.Write("A");
Console.Write("B");

Output:

AB

Choose the method depending on how you want
the output formatted.

==================================================
5. WHAT IS INPUT?
=================

Input is information entered by the user.

Users commonly provide input through:

* Keyboard
* Mouse
* Touch Screen
* Microphone

In Console Applications, input is usually
received from the keyboard.

==================================================
6. Console.ReadLine()
=====================

Console.ReadLine() reads a line of text entered
by the user.

Example:

string name = Console.ReadLine();

The program waits until the user presses Enter.

==================================================
7. ASKING FOR USER INPUT
========================

Example:

Console.Write("Enter your name: ");

string name = Console.ReadLine();

Console.WriteLine("Hello " + name);

The program asks for information and then
uses the user's response.

==================================================
8. STORING INPUT IN VARIABLES
=============================

Input is usually stored inside variables.

Example:

string city = Console.ReadLine();

The variable city now contains whatever the
user typed.

Example:

Input:

Mexicali

Stored Value:

city = "Mexicali"

==================================================
9. INPUT IS ALWAYS TEXT
=======================

Console.ReadLine() always returns a string.

Example:

string ageText = Console.ReadLine();

Even if the user types:

25

The value is still stored as text.

==================================================
10. CONVERTING INPUT TO NUMBERS
===============================

To perform mathematical operations, text must
be converted into numeric data types.

Example:

int age = Convert.ToInt32(Console.ReadLine());

Input:

25

Stored Value:

age = 25

Age is now an integer instead of text.

==================================================
11. Convert.ToInt32()
=====================

Converts text into an integer.

Example:

int number = Convert.ToInt32("100");

Result:

100

Data Type:

int

==================================================
12. Convert.ToDouble()
======================

Converts text into a double.

Example:

double price = Convert.ToDouble("19.99");

Result:

19.99

Data Type:

double

==================================================
13. Convert.ToBoolean()
=======================

Converts text into a boolean.

Example:

bool isActive = Convert.ToBoolean("true");

Result:

true

Data Type:

bool

==================================================
14. COMBINING INPUT AND OUTPUT
==============================

Example:

Console.Write("Enter your name: ");

string name = Console.ReadLine();

Console.WriteLine("Welcome " + name);

This creates a simple interaction between
the program and the user.

==================================================
15. PERSONALIZED OUTPUT
=======================

Programs become more useful when they display
information based on user input.

Example:

Console.Write("Enter your city: ");

string city = Console.ReadLine();

Console.WriteLine("You live in " + city);

Output changes depending on the user's answer.

==================================================
16. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Forgetting parentheses

Incorrect:

Console.ReadLine;

Correct:

Console.ReadLine();

---

Mistake 2:

Forgetting to store input

Incorrect:

Console.ReadLine();

Correct:

string name = Console.ReadLine();

---

Mistake 3:

Trying to calculate with text

Incorrect:

string age = Console.ReadLine();

Correct:

int age = Convert.ToInt32(Console.ReadLine());

==================================================
17. BEST PRACTICES
==================

* Display clear instructions.
* Use meaningful variable names.
* Validate user input when possible.
* Convert data carefully.
* Keep prompts easy to understand.
* Format output neatly.

==================================================
18. REAL-WORLD USES
===================

Input and output are used in:

* Login systems
* Registration forms
* Games
* Calculators
* Surveys
* Databases
* Business software
* Mobile applications
* Web applications

Almost every software project uses some form
of input and output.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What output is
✓ Console.WriteLine()
✓ Console.Write()
✓ What input is
✓ Console.ReadLine()
✓ Storing input in variables
✓ Converting input to numbers
✓ Convert.ToInt32()
✓ Convert.ToDouble()
✓ Convert.ToBoolean()
✓ Combining input and output
✓ Personalized output
✓ Common mistakes
✓ Best practices

Input and output allow programs to interact
with users and are essential skills for every
C# developer.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
