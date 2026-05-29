# 🧵 - Inheritance

## Introduction

In this module, I learn another important pillar of Object-Oriented Programming: **Inheritance**.

Inheritance allows one class to reuse fields and methods from another class. This helps me avoid repeating code and makes my programs more organized.

With inheritance, I can create a general class and then create more specific classes based on it.

For example, I can create a general `Character` class, then create `Warrior`, `Mage`, and `Archer` classes that inherit from it.

---

## What I Learn In This Module

* What inheritance is
* Why inheritance is useful
* Base classes
* Derived classes
* The `:` inheritance symbol
* Reusing code from a parent class
* Adding new behavior in child classes
* Constructor behavior in inheritance
* The `base` keyword
* Method overriding introduction
* Real-world inheritance examples

---

## Why Inheritance Matters

Inheritance helps me write cleaner code by reusing common behavior.

Instead of writing the same fields and methods again and again, I can place shared code inside a base class.

This makes my code:

* Cleaner
* Shorter
* Easier to maintain
* Easier to expand
* More professional

---

## Simple Example

A base class can contain shared information:

```csharp
class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}
```

A derived class can inherit from it:

```csharp
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}
```

Now `Dog` can use both its own method and the inherited method.

---

## Real-World Example

Imagine a game with different characters.

All characters may have:

* Name
* Level
* Health
* Attack method

But each character type may also have unique abilities:

* Warrior uses sword attacks
* Mage casts spells
* Archer uses arrows

Inheritance lets me place shared data in one class and special behavior in separate child classes.

---

## Skills Gained

After completing this module, I will be able to:

✅ Create a base class

✅ Create a derived class

✅ Reuse code through inheritance

✅ Use the `base` keyword

✅ Understand parent and child class relationships

✅ Build cleaner object-oriented programs

✅ Avoid duplicate code

✅ Create expandable class structures

---

## Module Files

### README.md

Module overview and learning objectives.

### Inheritance_Notes.cs

Detailed explanation of inheritance, base classes, derived classes, constructors, and best practices.

### Inheritance_Examples.cs

Runnable examples demonstrating inheritance in C#.

### Inheritance_Tasks.cs

Practice exercises to strengthen inheritance skills.

### Inheritance_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 3 — Intermediate ⚙️**

Inheritance is more advanced than basic classes and encapsulation because it introduces relationships between classes.

Once I understand inheritance, I can design larger and more organized object-oriented programs.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain inheritance
* Create parent and child classes
* Use the `:` symbol for inheritance
* Reuse methods from a base class
* Add special behavior in derived classes
* Use the `base` keyword
* Understand why inheritance reduces duplicate code

---

**Next Module:** 13-POLYMORPHISM 🚀

👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx //  mxli.peyman@gmail.com
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
