```csharp
/*
=========================================
36 - SEALED
Sealed_Notes.cs
=========================================
*/

using System;

namespace SealedNotes
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
WHAT IS SEALED?
==================================================

The sealed keyword is used to stop inheritance.

When a class is marked as sealed,
no other class can inherit from it.

Example:

sealed class Vehicle
{
}

This is valid.

------------------------------------------

class Car : Vehicle
{
}

This is NOT valid.

Because Vehicle is sealed.

==================================================
WHY SEALED EXISTS
==================================================

Sometimes a class is already complete.

The designer does not want anyone
to change its behavior through inheritance.

Sealed allows me to protect that design.

Examples:

- Security systems
- Payment processors
- Authentication systems
- Core framework classes
- Utility classes

==================================================
SEALED CLASS
==================================================

Example:

sealed class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

Usage:

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(5, 3));

The class works normally.

The only restriction is that it
cannot be inherited.

==================================================
ATTEMPTING INHERITANCE
==================================================

Example:

sealed class Animal
{
}

class Dog : Animal
{
}

Compiler Error:

Cannot derive from sealed type.

==================================================
WHEN TO USE SEALED CLASSES
==================================================

Use sealed when:

✓ The class is finished

✓ Inheritance would be dangerous

✓ Security must be protected

✓ Behavior must remain unchanged

✓ Framework design requires restrictions

==================================================
SEALED METHODS
==================================================

Methods can also be sealed.

However:

A sealed method must also be override.

Example:

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dog : Animal
{
    public sealed override void Speak()
    {
        Console.WriteLine("Bark");
    }
}

==================================================
WHAT DOES THIS DO?
==================================================

Animal

   ↓

Dog

   ↓

Puppy

Dog overrides Speak()

and seals it.

Puppy cannot override Speak() again.

==================================================
EXAMPLE
==================================================

class Puppy : Dog
{
    public override void Speak()
    {
        Console.WriteLine("Small Bark");
    }
}

Compiler Error.

Because Speak() was sealed in Dog.

==================================================
WHY SEAL METHODS?
==================================================

Sometimes I want to allow inheritance
but stop modification of specific methods.

Example:

Authentication Process

ValidateUser()

SecurityCheck()

EncryptPassword()

These methods should not be changed
by child classes.

==================================================
SEALED VS VIRTUAL
==================================================

virtual

Allows overriding.

Example:

public virtual void Run()

------------------------------------------

override

Replaces parent implementation.

Example:

public override void Run()

------------------------------------------

sealed override

Stops further overriding.

Example:

public sealed override void Run()

==================================================
INHERITANCE CHAIN EXAMPLE
==================================================

Animal

↓

Dog

↓

GermanShepherd

Animal:

virtual Speak()

Dog:

sealed override Speak()

GermanShepherd:

Cannot override Speak()

==================================================
REAL-WORLD EXAMPLE
==================================================

BankAccount

↓

SavingsAccount

↓

PremiumSavingsAccount

If SavingsAccount seals:

CalculateInterest()

Then PremiumSavingsAccount
cannot change it.

This protects business rules.

==================================================
ADVANTAGES OF SEALED
==================================================

1. Prevents unwanted inheritance

2. Protects business rules

3. Improves security

4. Creates predictable behavior

5. Easier maintenance

6. Better API design

==================================================
DISADVANTAGES OF SEALED
==================================================

1. Less flexibility

2. Cannot extend behavior later

3. May force composition instead
   of inheritance

4. Can limit framework users

==================================================
COMMON USE CASES
==================================================

Authentication classes

Payment processors

Logging systems

Configuration managers

Utility classes

Framework classes

Security systems

==================================================
BEST PRACTICES
==================================================

✓ Seal classes that should never
  be extended

✓ Seal methods that should never
  be overridden again

✓ Think carefully before sealing

✓ Document why something is sealed

✓ Use inheritance only when needed

==================================================
WHEN NOT TO USE SEALED
==================================================

Avoid sealing classes when:

✗ Future extension is expected

✗ Framework users need inheritance

✗ Custom behavior is required

✗ The design is still evolving

==================================================
SEALED AND PERFORMANCE
==================================================

Sealed classes can sometimes improve
performance slightly.

The compiler can make additional
optimizations because it knows
the class cannot be inherited.

However:

Performance should never be the main
reason for using sealed.

Design and safety are more important.

==================================================
SUMMARY
==================================================

The sealed keyword prevents inheritance.

Types of sealed usage:

1. Sealed Class

sealed class Vehicle

No class can inherit from Vehicle.

------------------------------------------

2. Sealed Method

public sealed override void Run()

No child class can override Run() again.

Sealed helps create safer,
more predictable, and more professional
object-oriented designs.

Use it when a class or method should
remain unchanged.
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
