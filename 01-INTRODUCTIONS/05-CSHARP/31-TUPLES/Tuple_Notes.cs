using System;

/*
=========================================
TUPLE NOTES
=========================================

In this module, I learn about Tuples in C#.

A Tuple is a lightweight data structure that
allows me to store multiple values together.

The values can be of different data types.

Tuples are useful when I need to group
related information without creating a
class or struct.

-----------------------------------------
WHAT IS A TUPLE?
-----------------------------------------

A tuple is a collection of values.

Example:

(string, int)

This tuple contains:

A string
An integer

Example:

("Peyman", 25)

-----------------------------------------
WHY USE TUPLES?
-----------------------------------------

Without tuples:

string name = "Peyman";
int age = 25;

Multiple separate variables are needed.

With tuples:

var person = ("Peyman", 25);

Both values are grouped together.

Benefits:

✔ Cleaner code

✔ Fewer classes

✔ Easy to return multiple values

✔ Easy to read

-----------------------------------------
CREATING A TUPLE
-----------------------------------------

Example:

var person = ("Peyman", 25);

This creates:

Item1 = "Peyman"
Item2 = 25

-----------------------------------------
ACCESSING TUPLE VALUES
-----------------------------------------

Example:

Console.WriteLine(person.Item1);
Console.WriteLine(person.Item2);

Output:

Peyman
25

-----------------------------------------
NAMED TUPLES
-----------------------------------------

Instead of Item1 and Item2, I can
assign meaningful names.

Example:

var person =
(
    Name: "Peyman",
    Age: 25
);

Access:

person.Name
person.Age

This makes code much easier to read.

-----------------------------------------
TUPLES WITH DIFFERENT TYPES
-----------------------------------------

Example:

var data =
(
    "Peyman",
    25,
    true,
    95.5
);

Contains:

string
int
bool
double

-----------------------------------------
EXPLICIT TUPLE TYPES
-----------------------------------------

Example:

(string Name, int Age) person =
(
    "Peyman",
    25
);

Useful when I want to specify types
directly.

-----------------------------------------
RETURNING MULTIPLE VALUES
-----------------------------------------

One of the most common uses of tuples.

Example:

static (string Name, int Score)
GetPlayer()
{
    return ("Peyman", 100);
}

Usage:

var player = GetPlayer();

Console.WriteLine(player.Name);
Console.WriteLine(player.Score);

-----------------------------------------
TUPLE DECONSTRUCTION
-----------------------------------------

A tuple can be split into variables.

Example:

var person =
(
    Name: "Peyman",
    Age: 25
);

var (name, age) = person;

Console.WriteLine(name);
Console.WriteLine(age);

Output:

Peyman
25

-----------------------------------------
DECONSTRUCTING METHOD RETURNS
-----------------------------------------

Example:

var (name, score) = GetPlayer();

This is extremely common in modern C#.

-----------------------------------------
TUPLES IN METHODS
-----------------------------------------

Example:

static (int Sum, int Product)
Calculate(int a, int b)
{
    return
    (
        a + b,
        a * b
    );
}

Usage:

var result = Calculate(5, 10);

Console.WriteLine(result.Sum);
Console.WriteLine(result.Product);

-----------------------------------------
TUPLES IN LISTS
-----------------------------------------

Example:

List<(string Name, int Age)> people =
    new List<(string, int)>();

People can be stored as tuples.

-----------------------------------------
TUPLES VS CLASSES
-----------------------------------------

Tuple:

✔ Fast
✔ Lightweight
✔ Temporary data
✔ No separate file needed

Class:

✔ Better organization
✔ Reusable
✔ Supports inheritance
✔ Better for large projects

-----------------------------------------
TUPLES VS STRUCTS
-----------------------------------------

Tuple:

✔ Quick data grouping
✔ Temporary use

Struct:

✔ Custom type
✔ Better organization
✔ More functionality

-----------------------------------------
REAL-WORLD EXAMPLES
-----------------------------------------

Returning coordinates:

(double X, double Y)

Returning employee data:

(string Name, decimal Salary)

Returning game information:

(string PlayerName,
 int Level,
 int Health)

Returning statistics:

(int Wins,
 int Losses,
 double WinRate)

-----------------------------------------
NESTED TUPLES
-----------------------------------------

Example:

var data =
(
    Name: "Peyman",
    Info:
    (
        Age: 25,
        Country: "Mexico"
    )
);

Access:

data.Info.Age

data.Info.Country

-----------------------------------------
DISCARDS
-----------------------------------------

Sometimes I only need some values.

Example:

var (name, _) =
(
    "Peyman",
    25
);

The underscore ignores a value.

-----------------------------------------
COMMON MISTAKES
-----------------------------------------

❌ Using tuples everywhere

❌ Using too many tuple values

❌ Creating complex tuples

❌ Replacing proper classes unnecessarily

❌ Using Item1 and Item2 when
meaningful names should be used

-----------------------------------------
BEST PRACTICES
-----------------------------------------

✔ Use named tuples

✔ Keep tuples small

✔ Use tuples for temporary data

✔ Use classes for large models

✔ Use deconstruction when helpful

✔ Return multiple values cleanly

✔ Keep tuple names meaningful

-----------------------------------------
WHEN TO USE TUPLES
-----------------------------------------

Use tuples when:

✔ Returning multiple values

✔ Temporary grouped data

✔ Quick calculations

✔ Small utility methods

✔ Lightweight solutions

-----------------------------------------
WHEN NOT TO USE TUPLES
-----------------------------------------

Avoid tuples when:

✘ Data is complex

✘ Data is reused everywhere

✘ Business models are required

✘ Validation is needed

✘ Object behavior is required

In those cases, use classes or structs.

-----------------------------------------
SUMMARY
-----------------------------------------

Tuples allow me to:

✔ Store multiple values together

✔ Return multiple values

✔ Reduce unnecessary classes

✔ Write cleaner methods

✔ Use deconstruction

✔ Create lightweight data structures

✔ Improve code readability

Tuples are one of the most useful modern
features available in C#.
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
