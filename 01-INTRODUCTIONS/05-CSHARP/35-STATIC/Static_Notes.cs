```csharp
/*
=========================================
35 - STATIC
Static_Notes.cs
=========================================
*/

using System;

namespace StaticNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }
}

/*
==================================================
WHAT IS STATIC?
==================================================

The static keyword means that a member belongs
to the class itself instead of belonging to
an object created from the class.

Normally:

Class -> Create Object -> Use Members

With static:

Class -> Use Member Directly

No object is required.

==================================================
INSTANCE MEMBERS
==================================================

Instance members belong to an object.

Example:

class Person
{
    public string Name;
}

Usage:

Person person1 = new Person();
Person person2 = new Person();

person1.Name = "Peyman";
person2.Name = "John";

Each object has its own copy.

==================================================
STATIC MEMBERS
==================================================

Static members belong to the class.

Example:

class GameSettings
{
    public static int MaxLevel = 100;
}

Usage:

Console.WriteLine(GameSettings.MaxLevel);

No object is needed.

==================================================
WHY STATIC EXISTS
==================================================

Sometimes data should be shared by all objects.

Examples:

- Total players online
- Application version
- Tax rate
- Company name
- Utility methods
- Configuration values

Instead of creating copies inside every object,
one shared value can be used.

==================================================
STATIC FIELD
==================================================

A static field is shared by all objects.

Example:

class Player
{
    public static int TotalPlayers;
}

Usage:

Player.TotalPlayers++;

All Player objects see the same value.

==================================================
STATIC METHOD
==================================================

A static method belongs to the class.

Example:

class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

Usage:

int result = MathHelper.Add(5, 3);

No object required.

==================================================
REAL EXAMPLE
==================================================

Math class:

Math.Sqrt(25);

Math.Pow(2, 3);

Math.Abs(-10);

These are static methods.

No Math object exists.

==================================================
STATIC PROPERTY
==================================================

Properties can also be static.

Example:

class GameInfo
{
    public static string Version
    {
        get;
        set;
    }
}

Usage:

GameInfo.Version = "1.0";

Console.WriteLine(GameInfo.Version);

==================================================
STATIC CONSTRUCTOR
==================================================

A static constructor runs automatically.

It executes only once.

Example:

class Database
{
    static Database()
    {
        Console.WriteLine("Database initialized.");
    }
}

The static constructor runs before the class
is used for the first time.

==================================================
RULES OF STATIC CONSTRUCTORS
==================================================

✓ No access modifiers

✓ No parameters

✓ Runs automatically

✓ Executes only once

✓ Cannot be called manually

==================================================
STATIC CLASS
==================================================

A static class can only contain static members.

Example:

static class Utilities
{
    public static void PrintHello()
    {
        Console.WriteLine("Hello");
    }
}

Usage:

Utilities.PrintHello();

==================================================
IMPORTANT RULE
==================================================

Cannot create objects from static classes.

INVALID:

Utilities utility = new Utilities();

Static classes exist only as containers
for static members.

==================================================
WHEN TO USE STATIC CLASSES
==================================================

Good examples:

✓ Helper methods

✓ Utility functions

✓ Mathematical calculations

✓ Configuration managers

✓ Shared constants

✓ Global application information

==================================================
WHEN NOT TO USE STATIC
==================================================

Avoid static when every object needs
its own unique data.

Bad example:

class Person
{
    public static string Name;
}

Every person would share the same name.

That is incorrect.

Use instance members instead.

==================================================
INSTANCE VS STATIC
==================================================

Instance:

Each object owns its own value.

Example:

person1.Name

person2.Name

Different values.

------------------------------------------

Static:

One value shared by all objects.

Example:

Player.TotalPlayers

Same value everywhere.

==================================================
COMMON STATIC MEMBERS IN C#
==================================================

Math.Sqrt()

Math.Pow()

Math.Abs()

Console.WriteLine()

Environment.Exit()

DateTime.Now

Convert.ToInt32()

These are commonly used static members.

==================================================
ADVANTAGES OF STATIC
==================================================

1. Shared data

2. Better performance

3. No object creation required

4. Useful utility classes

5. Cleaner helper functions

6. Easy access

==================================================
DISADVANTAGES OF STATIC
==================================================

1. Global state problems

2. Harder testing

3. Tight coupling

4. Shared data bugs

5. Less flexibility

==================================================
BEST PRACTICES
==================================================

✓ Use static for utility methods

✓ Use static for constants

✓ Use static for shared application data

✓ Keep static classes focused

✓ Avoid unnecessary static fields

✓ Think carefully before sharing data

==================================================
REAL-WORLD EXAMPLES
==================================================

Game Development

GameSettings.MaxLevel

------------------------------------------

Banking System

BankConfiguration.InterestRate

------------------------------------------

School System

School.TotalStudents

------------------------------------------

Utility Library

MathHelper.CalculateTax()

==================================================
SUMMARY
==================================================

Static members belong to the class,
not to an object.

Types of static members:

- Static fields
- Static methods
- Static properties
- Static constructors
- Static classes

Static is useful when data or behavior
should be shared across the entire application.

Professional developers use static carefully
to avoid unnecessary global state and
maintain clean code.
*/

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
