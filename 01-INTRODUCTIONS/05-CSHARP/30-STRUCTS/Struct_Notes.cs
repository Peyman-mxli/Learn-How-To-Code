using System;

/*
=========================================
STRUCT NOTES
=========================================

In this module, I learn about Structs in C#.

A Struct is a user-defined data type that
allows me to group related values together.

Structs are very similar to classes.

However, there is one major difference:

Structs are VALUE TYPES.

Classes are REFERENCE TYPES.

Understanding this difference is extremely
important for becoming a professional C#
developer.

-----------------------------------------
WHAT IS A STRUCT?
-----------------------------------------

A struct groups related information into
one object.

Example:
*/

struct Point
{
    public int X;
    public int Y;
}

/*
The Point struct stores two values:

X coordinate
Y coordinate

Instead of storing them separately:

int x = 10;
int y = 20;

I can group them together:

Point point;

-----------------------------------------
CREATING A STRUCT
-----------------------------------------
*/

struct Person
{
    public string Name;
    public int Age;
}

/*
Usage:

Person person;

person.Name = "Peyman";
person.Age = 25;

-----------------------------------------
VALUE TYPES
-----------------------------------------

Structs are value types.

This means a copy is created whenever
the struct is assigned to another variable.

Example:
*/

struct Score
{
    public int Value;
}

/*
Example:

Score score1;
score1.Value = 100;

Score score2 = score1;

score2.Value = 500;

Result:

score1.Value = 100
score2.Value = 500

The original remains unchanged.

This happens because a COPY was created.

-----------------------------------------
REFERENCE TYPES
-----------------------------------------

Classes behave differently.

Example:

class Player
{
    public int Health;
}

Player player1 = new Player();
Player player2 = player1;

player2.Health = 0;

Result:

player1.Health = 0

Both variables point to the same object.

-----------------------------------------
STRUCT VS CLASS
-----------------------------------------

Struct

✔ Value Type
✔ Stored directly
✔ Faster for small data
✔ Copied on assignment
✔ Cannot inherit another struct/class

Class

✔ Reference Type
✔ Stored on heap
✔ Supports inheritance
✔ Shared references
✔ Better for large objects

-----------------------------------------
FIELDS IN STRUCTS
-----------------------------------------
*/

struct Car
{
    public string Brand;
    public string Model;
    public int Year;
}

/*
Usage:

Car car;

car.Brand = "Toyota";
car.Model = "Corolla";
car.Year = 2025;

-----------------------------------------
STRUCT PROPERTIES
-----------------------------------------
*/

struct Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

/*
Properties work exactly like they do in
classes.

-----------------------------------------
STRUCT METHODS
-----------------------------------------
*/

struct Rectangle
{
    public double Width;
    public double Height;

    public double GetArea()
    {
        return Width * Height;
    }
}

/*
Usage:

Rectangle rect;

rect.Width = 10;
rect.Height = 5;

double area = rect.GetArea();

-----------------------------------------
STRUCT CONSTRUCTORS
-----------------------------------------

Modern C# allows parameterized
constructors in structs.
*/

struct Employee
{
    public string Name;
    public int Age;

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

/*
Usage:

Employee employee =
    new Employee("Peyman", 25);

-----------------------------------------
READONLY STRUCTS
-----------------------------------------

A struct can be marked readonly.

Example:

readonly struct Temperature
{
    public readonly double Value;

    public Temperature(double value)
    {
        Value = value;
    }
}

Benefits:

✔ Safer
✔ Immutable
✔ Better performance

-----------------------------------------
PASSING STRUCTS TO METHODS
-----------------------------------------

By default, structs are copied.

Example:

void UpdateScore(Score score)
{
    score.Value = 999;
}

The original value is unchanged.

-----------------------------------------
PASSING BY REFERENCE
-----------------------------------------

Use ref when I want to modify the original.

Example:

void UpdateScore(ref Score score)
{
    score.Value = 999;
}

Now the original changes.

-----------------------------------------
NESTED STRUCTS
-----------------------------------------
*/

struct Address
{
    public string City;
    public string Country;
}

struct Customer
{
    public string Name;
    public Address Address;
}

/*
Structs can contain other structs.

-----------------------------------------
REAL-WORLD USES OF STRUCTS
-----------------------------------------

Game Development

✔ Positions
✔ Rotations
✔ Colors
✔ Velocities

Business Applications

✔ Coordinates
✔ Measurements
✔ Currency Values
✔ Configuration Data

Engineering

✔ Sensor Data
✔ Calculations
✔ Scientific Measurements

-----------------------------------------
WHEN TO USE STRUCTS
-----------------------------------------

Use structs when:

✔ Object is small
✔ Represents one value
✔ Rarely changes
✔ No inheritance needed
✔ Performance matters

Examples:

Point
Color
Vector
Rectangle
Date
Temperature

-----------------------------------------
WHEN NOT TO USE STRUCTS
-----------------------------------------

Avoid structs when:

✘ Object is large
✘ Requires inheritance
✘ Frequently modified
✘ Shared references are needed

In these situations, use classes.

-----------------------------------------
COMMON MISTAKES
-----------------------------------------

❌ Creating very large structs

❌ Forgetting structs are copied

❌ Expecting reference behavior

❌ Using structs when inheritance
is required

❌ Passing large structs frequently

-----------------------------------------
BEST PRACTICES
-----------------------------------------

✔ Keep structs small

✔ Use meaningful names

✔ Consider readonly structs

✔ Use properties when appropriate

✔ Use methods only when useful

✔ Understand value-copy behavior

✔ Use structs for data containers

-----------------------------------------
SUMMARY
-----------------------------------------

Structs allow me to:

✔ Group related data

✔ Create custom value types

✔ Improve performance

✔ Store small objects efficiently

✔ Build cleaner applications

✔ Understand value-type behavior

✔ Write more professional C# code

Structs are an important part of C#
and are used extensively throughout
the .NET ecosystem.
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
