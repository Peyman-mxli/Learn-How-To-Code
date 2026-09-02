using System;

# /*

02 - SYNTAX
Syntax_Notes.cs
===============

In this module, I learn the basic syntax of C#.

Syntax is the set of rules that defines how C# code
must be written so the compiler can understand it.

Every C# program follows syntax rules.

Learning syntax is important because even a small
mistake can cause compilation errors.

==================================================

1. WHAT IS SYNTAX?
   ==================================================

Syntax is the grammar of a programming language.

Example:

Console.WriteLine("Hello World");

The statement above follows correct C# syntax.

If I forget something important, such as a
semicolon or quotation mark, the code will fail.

Incorrect Example:

Console.WriteLine("Hello World")

Missing semicolon.

==================================================
2. STATEMENTS
=============

A statement is an instruction that tells the
computer to perform an action.

Example:

Console.WriteLine("Welcome");
Console.WriteLine("To C#");

Each statement usually ends with a semicolon (;)

The semicolon tells C# that the instruction
has finished.

==================================================
3. SEMICOLONS
=============

Semicolons are used to terminate statements.

Correct:

int age = 25;

Incorrect:

int age = 25

The compiler expects a semicolon at the end.

==================================================
4. CODE BLOCKS
==============

Code blocks are enclosed by curly braces.

{

}

Curly braces group multiple statements together.

Example:

{
Console.WriteLine("Line 1");
Console.WriteLine("Line 2");
}

Many structures use code blocks:

* Classes
* Methods
* Loops
* Conditions
* Namespaces

==================================================
5. THE MAIN METHOD
==================

Every Console Application starts execution
inside the Main method.

Example:

static void Main(string[] args)
{
Console.WriteLine("Program Started");
}

The Main method is known as the entry point
of the application.

Execution begins here.

==================================================
6. NAMESPACES
=============

Namespaces help organize code.

Example:

namespace LearnHowToCode
{

}

Namespaces prevent naming conflicts between
classes and projects.

==================================================
7. USING DIRECTIVES
===================

Using directives allow access to classes that
exist inside namespaces.

Example:

using System;

Without using System, I would need to write:

System.Console.WriteLine("Hello");

Using directives make code cleaner and easier
to read.

==================================================
8. COMMENTS
===========

Comments are notes inside code.

They are ignored by the compiler.

---

## Single-Line Comment

Example:

// This is a comment

---

## Multi-Line Comment

Example:

/*
This is
a multi-line
comment.
*/

---

## XML Documentation Comment

Example:

/// <summary>
/// Displays a message.
/// </summary>

XML comments are commonly used in professional
software development.

==================================================
9. CASE SENSITIVITY
===================

C# is case-sensitive.

This means uppercase and lowercase letters
are treated differently.

Correct:

Console.WriteLine("Hello");

Incorrect:

console.writeline("Hello");

The compiler sees them as different names.

==================================================
10. INDENTATION
===============

Indentation improves readability.

Example:

if (true)
{
Console.WriteLine("Good Formatting");
}

Poor formatting:

if(true){
Console.WriteLine("Hard To Read");
}

Both may work, but proper formatting is
considered professional.

==================================================
11. WHITESPACE
==============

Whitespace includes:

* Spaces
* Tabs
* Empty lines

Whitespace makes code easier to understand.

Example:

int age = 25;
string name = "John";

is easier to read than:

int age=25;string name="John";

==================================================
12. COMMON SYNTAX ERRORS
========================

Missing Semicolon

Example:

int number = 10

Missing Quotation Mark

Example:

Console.WriteLine("Hello);

Missing Curly Brace

Example:

if (true)
{
Console.WriteLine("Hello");

Missing Parenthesis

Example:

Console.WriteLine("Hello";

Incorrect Capitalization

Example:

console.writeline("Hello");

==================================================
13. BEST PRACTICES
==================

* Use proper indentation.
* Keep code organized.
* Use meaningful names.
* Write comments when needed.
* Follow consistent formatting.
* Always check for compiler errors.
* Read error messages carefully.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What syntax is
✓ Statements
✓ Semicolons
✓ Code blocks
✓ Main method
✓ Namespaces
✓ Using directives
✓ Comments
✓ Case sensitivity
✓ Formatting
✓ Whitespace
✓ Common syntax errors
✓ Syntax best practices

Syntax is the foundation of every C# program.
The better I understand syntax, the easier it
becomes to learn advanced programming topics.
*/
👤 Author Peyman Miyandashti 
🎓 Polytechnic University of Baja California 
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico) 
📅 Year: 2026 
🆔 ID: 250161
