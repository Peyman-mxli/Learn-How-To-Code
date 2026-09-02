# 🧵 - Interfaces

## Introduction

In this module, I learn about **Interfaces** in C#.

An interface defines a contract that a class must follow.

It tells a class what it must do, but not how it must do it.

Interfaces help me create flexible, organized, and professional code.

---

## What I Learn In This Module

* What an interface is
* Why interfaces are important
* The `interface` keyword
* Interface methods
* Interface properties
* Implementing interfaces
* Multiple interface implementation
* Difference between abstract classes and interfaces
* Real-world interface examples

---

## Why Interfaces Matter

Interfaces allow different classes to follow the same structure while still having their own behavior.

For example, many devices can be turned on:

* Computer
* Smartphone
* Television

Each device can have a method named:

```csharp
TurnOn();
```

But each device turns on in its own way.

This makes code:

* More flexible
* Easier to expand
* Easier to test
* Easier to maintain
* More professional

---

## Simple Example

```csharp
interface IAttackable
{
    void Attack();
}

class Warrior : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword.");
    }
}
```

The interface defines the required method.

The class provides the real behavior.

---

## Real-World Example

Imagine a payment system.

All payment types must process payment:

* Credit Card
* PayPal
* Bank Transfer

An interface can require every payment type to use:

```csharp
ProcessPayment();
```

Each payment class implements the method differently.

That is the power of interfaces.

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain interfaces

✅ Create interfaces

✅ Use the `interface` keyword

✅ Implement interface methods

✅ Implement interface properties

✅ Use multiple interfaces

✅ Understand interface contracts

✅ Build flexible object-oriented systems

---

## Module Files

### README.md

Module overview and learning objectives.

### Interfaces_Notes.cs

Detailed explanation of interfaces, contracts, implementation, multiple interfaces, and best practices.

### Interfaces_Examples.cs

Runnable examples demonstrating interfaces in C#.

### Interfaces_Tasks.cs

Practice exercises to strengthen interface skills.

### Interfaces_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Interfaces are an advanced Object-Oriented Programming concept because they require understanding classes, methods, inheritance, polymorphism, and abstraction.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what an interface is
* Create an interface
* Implement an interface in a class
* Understand why interfaces are contracts
* Use interface methods and properties
* Implement multiple interfaces
* Recognize interfaces in real-world software
* Build flexible and professional class structures

---

**Next Module:** 16-EXCEPTIONS

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
