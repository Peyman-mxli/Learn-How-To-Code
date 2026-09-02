```csharp
/*
=========================================
34 - OPERATOR OVERLOADING
OperatorOverloading_Notes.cs
=========================================
*/

using System;

namespace OperatorOverloadingNotes
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
WHAT IS OPERATOR OVERLOADING?
==================================================

Operator Overloading allows me to define how
operators behave when used with my own classes
and structs.

Normally, operators work with built-in types:

int
double
float
decimal

Example:

int result = 5 + 10;

The + operator already knows how to add integers.

However, if I create my own class:

class Money
{
}

The + operator does not automatically know
how to add two Money objects.

Operator Overloading solves this problem.

==================================================
WHY OPERATOR OVERLOADING EXISTS
==================================================

Without operator overloading:

Money total = wallet1.Add(wallet2);

With operator overloading:

Money total = wallet1 + wallet2;

The second version is often easier to read.

Operator overloading helps custom objects behave
more naturally.

==================================================
OPERATOR KEYWORD
==================================================

C# uses the operator keyword.

Example:

public static Money operator +(Money a, Money b)
{
    return new Money(a.Amount + b.Amount);
}

The operator keyword tells C# that I am defining
custom behavior for an operator.

==================================================
STATIC REQUIREMENT
==================================================

All overloaded operators must be static.

Example:

public static Money operator +(Money a, Money b)

This is required by the C# language.

Operator methods belong to the class itself,
not to a specific object instance.

==================================================
SIMPLE EXAMPLE
==================================================

class Money
{
    public decimal Amount;

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }
}

Usage:

Money wallet1 = new Money(50);
Money wallet2 = new Money(25);

Money total = wallet1 + wallet2;

==================================================
ARITHMETIC OPERATORS
==================================================

The most common overloaded operators are:

+
-
*
/
%

Examples:

public static Vector operator +(Vector a, Vector b)

public static Vector operator -(Vector a, Vector b)

public static Vector operator *(Vector a, Vector b)

public static Vector operator /(Vector a, Vector b)

==================================================
COMPARISON OPERATORS
==================================================

Comparison operators can also be overloaded.

==
!=
>
<
>=
<=

Example:

public static bool operator ==(Money a, Money b)
{
    return a.Amount == b.Amount;
}

==================================================
IMPORTANT RULE
==================================================

When overloading ==

I should also overload !=

Example:

public static bool operator ==(Money a, Money b)
{
    return a.Amount == b.Amount;
}

public static bool operator !=(Money a, Money b)
{
    return a.Amount != b.Amount;
}

==================================================
UNARY OPERATORS
==================================================

Unary operators work with one operand.

Examples:

+
-
++
--
!

Example:

public static Counter operator ++(Counter c)
{
    c.Value++;
    return c;
}

==================================================
BINARY OPERATORS
==================================================

Binary operators work with two operands.

Examples:

+
-
*
/
==
>

Example:

Vector result = vector1 + vector2;

==================================================
REAL-WORLD USE CASES
==================================================

1. Money Systems

wallet1 + wallet2

------------------------------------------

2. Game Development

playerPosition + movementVector

------------------------------------------

3. Physics Simulations

force1 + force2

------------------------------------------

4. Mathematics

fraction1 + fraction2

------------------------------------------

5. Inventory Systems

weight1 + weight2

==================================================
VECTOR EXAMPLE
==================================================

class Vector2D
{
    public int X;
    public int Y;

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector2D operator +(Vector2D a, Vector2D b)
    {
        return new Vector2D
        (
            a.X + b.X,
            a.Y + b.Y
        );
    }
}

==================================================
COMPARISON EXAMPLE
==================================================

class Score
{
    public int Points;

    public Score(int points)
    {
        Points = points;
    }

    public static bool operator >(Score a, Score b)
    {
        return a.Points > b.Points;
    }

    public static bool operator <(Score a, Score b)
    {
        return a.Points < b.Points;
    }
}

==================================================
ADVANTAGES
==================================================

1. Cleaner code

2. More readable code

3. Natural object behavior

4. Better API design

5. Easier mathematical operations

6. Professional object models

==================================================
DISADVANTAGES
==================================================

1. Can be abused

2. Can confuse developers

3. Harder debugging

4. Unexpected behavior if poorly designed

==================================================
BEST PRACTICES
==================================================

✓ Use operator overloading only when it makes sense

✓ Keep behavior intuitive

✓ Follow mathematical expectations

✓ Keep implementation simple

✓ Overload comparison pairs together

✓ Document operator behavior clearly

==================================================
WHEN NOT TO USE IT
==================================================

Avoid operator overloading when:

✗ Meaning is unclear

✗ Behavior is surprising

✗ A method name would be easier to understand

Bad Example:

customer1 + customer2

What does that mean?

The meaning is unclear.

Good Example:

money1 + money2

The meaning is obvious.

==================================================
COMMONLY OVERLOADED OPERATORS
==================================================

+
-
*
/
%
==
!=
>
<
>=
<=
++
--
!

==================================================
SUMMARY
==================================================

Operator Overloading allows custom classes
and structs to define how operators behave.

C# uses:

public static operator

for all overloaded operators.

Common categories:

- Arithmetic operators
- Comparison operators
- Unary operators
- Binary operators

Operator overloading improves readability
when used carefully and appropriately.

Professional developers use operator overloading
only when it makes code clearer and more natural.
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
