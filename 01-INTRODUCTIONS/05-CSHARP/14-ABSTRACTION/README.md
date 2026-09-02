# 🧵 - Abstraction

## Introduction

In this module, I learn another important pillar of Object-Oriented Programming: **Abstraction**.

Abstraction means hiding unnecessary details and showing only what is important.

In C#, abstraction helps me design classes that define what something should do, without always showing exactly how it does it.

This helps me write cleaner, more organized, and more professional code.

---

## What I Learn In This Module

* What abstraction is
* Why abstraction is important
* Abstract classes
* Abstract methods
* The `abstract` keyword
* How abstract classes are inherited
* How derived classes implement abstract methods
* Difference between abstraction and encapsulation
* Real-world abstraction examples

---

## Why Abstraction Matters

Abstraction allows me to focus on the important behavior of an object without worrying about all the internal details.

For example, when I use a car, I only need to know how to:

* Start the car
* Drive the car
* Stop the car

I do not need to know every internal detail of the engine to use it.

This makes code:

* Cleaner
* Easier to understand
* Easier to maintain
* Easier to expand
* More professional

---

## Simple Example

```csharp
abstract class Character
{
    public abstract void Attack();
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword.");
    }
}
```

The abstract class defines the method.

The derived class provides the real behavior.

---

## Real-World Example

Imagine a payment system.

All payment types must process payment:

* Credit Card
* PayPal
* Bank Transfer

An abstract class can require every payment type to create its own version of:

```csharp
ProcessPayment();
```

The system knows every payment must process payment, but each payment type handles it differently.

That is abstraction.

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain abstraction

✅ Create abstract classes

✅ Create abstract methods

✅ Use the `abstract` keyword

✅ Override abstract methods

✅ Hide unnecessary details

✅ Design cleaner object-oriented systems

✅ Understand how abstraction supports professional software structure

---

## Module Files

### README.md

Module overview and learning objectives.

### Abstraction_Notes.cs

Detailed explanation of abstraction, abstract classes, abstract methods, inheritance, and best practices.

### Abstraction_Examples.cs

Runnable examples demonstrating abstraction in C#.

### Abstraction_Tasks.cs

Practice exercises to strengthen abstraction skills.

### Abstraction_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Abstraction is an advanced Object-Oriented Programming concept because it requires understanding classes, inheritance, and polymorphism before using abstract classes correctly.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain abstraction in simple words
* Create an abstract class
* Create an abstract method
* Inherit from an abstract class
* Override abstract methods
* Understand why abstraction hides unnecessary details
* Recognize abstraction in real-world software
* Build flexible object-oriented structures

---

**Next Module:** 15-INTERFACES

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
