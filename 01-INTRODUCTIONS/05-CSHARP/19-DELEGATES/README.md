# 🧵 - Delegates

## Introduction

In this module, I learn about **Delegates**, one of the most powerful features in C#.

A delegate is a type that can store a reference to a method.

This allows me to pass methods as arguments, store methods inside variables, and execute methods dynamically during runtime.

Delegates are extremely important because they are the foundation of events, callbacks, and many advanced C# features.

Understanding delegates will help me write more flexible, reusable, and professional applications.

---

## What I Learn In This Module

* What delegates are
* Why delegates are useful
* Delegate declaration syntax
* Creating delegate types
* Assigning methods to delegates
* Invoking delegates
* Passing delegates as parameters
* Return values in delegates
* Multicast delegates
* Anonymous methods
* Lambda expressions introduction
* Real-world delegate examples

---

## Why Delegates Matter

Delegates allow me to treat methods like data.

Instead of hardcoding which method should run, I can decide at runtime.

This makes my code:

* More flexible
* More reusable
* Easier to maintain
* Easier to expand
* More professional

Delegates are used throughout modern C# development and are the foundation of many advanced programming concepts.

---

## Simple Example

A delegate can store a reference to a method.

```csharp
delegate void MessageDelegate();

class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }

    static void Main()
    {
        MessageDelegate message = SayHello;

        message();
    }
}
```

The delegate stores the method and allows me to execute it later.

---

## Real-World Example

Imagine I am creating a game.

A button may perform different actions depending on the situation:

* Attack an enemy
* Heal the player
* Open inventory
* Cast a spell

Instead of creating separate button systems for every action, I can use delegates to assign different methods dynamically.

This makes my game systems much more flexible and easier to maintain.

Delegates are also commonly used in:

* User interfaces
* Game development
* Event systems
* Callbacks
* APIs
* Enterprise applications

---

## Skills Gained

After completing this module, I will be able to:

✅ Create delegate types

✅ Assign methods to delegates

✅ Invoke delegates

✅ Pass delegates as parameters

✅ Return values through delegates

✅ Create multicast delegates

✅ Understand anonymous methods

✅ Understand lambda expression basics

✅ Build more flexible C# applications

---

## Module Files

### README.md

Module overview and learning objectives.

### Delegates_Notes.cs

Detailed explanation of delegates, method references, callbacks, multicast delegates, anonymous methods, lambda expressions, and best practices.

### Delegates_Examples.cs

Runnable examples demonstrating delegates in C#.

### Delegates_Tasks.cs

Practice exercises to strengthen delegate programming skills.

### Delegates_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Delegates are considered an advanced topic because they introduce dynamic method execution and function references.

Once I understand delegates, I will be prepared to learn events, callbacks, and many professional C# programming patterns.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what a delegate is
* Create a delegate type
* Assign methods to delegates
* Invoke delegates
* Pass delegates as parameters
* Create multicast delegates
* Understand anonymous methods
* Understand basic lambda expressions
* Explain why delegates improve flexibility

---

**Next Module:** 20-EVENTS 🚀

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
