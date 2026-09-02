# 🧵 - Polymorphism

## Introduction

In this module, I learn another important pillar of Object-Oriented Programming: **Polymorphism**.

Polymorphism means **many forms**.

In C#, polymorphism allows different classes to use the same method name but behave differently depending on the object.

This helps me write flexible, reusable, and professional code.

---

## What I Learn In This Module

* What polymorphism is
* Why polymorphism is important
* Method overriding
* The `virtual` keyword
* The `override` keyword
* Base class references
* Runtime polymorphism
* Real-world polymorphism examples
* How polymorphism improves object-oriented design

---

## Why Polymorphism Matters

Polymorphism allows me to write one general action and let each class respond in its own way.

For example, different game characters can all have an `Attack()` method:

* Warrior attacks with a sword
* Mage attacks with magic
* Archer attacks with arrows

The method name is the same, but the behavior is different.

This makes code:

* Cleaner
* More flexible
* Easier to expand
* Easier to maintain
* More professional

---

## Simple Example

```csharp
class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks.");
    }
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword.");
    }
}
```

The base class provides a general method.

The derived class changes the behavior using `override`.

---

## Real-World Example

Imagine a payment system.

All payment types can process a payment:

* Credit Card
* PayPal
* Bank Transfer

Each one uses the same method name:

```csharp
ProcessPayment();
```

But each payment type processes the payment differently.

That is polymorphism.

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain polymorphism

✅ Use `virtual` methods

✅ Use `override` methods

✅ Create flexible class behavior

✅ Use base class references

✅ Understand runtime polymorphism

✅ Reduce duplicated code

✅ Build more professional object-oriented programs

---

## Module Files

### README.md

Module overview and learning objectives.

### Polymorphism_Notes.cs

Detailed explanation of polymorphism, virtual methods, overriding, runtime behavior, and best practices.

### Polymorphism_Examples.cs

Runnable examples demonstrating polymorphism in C#.

### Polymorphism_Tasks.cs

Practice exercises to strengthen polymorphism skills.

### Polymorphism_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Polymorphism is more advanced than classes, constructors, encapsulation, and inheritance because it depends on understanding how objects can behave differently through shared structure.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain polymorphism in simple words
* Create a base class with a `virtual` method
* Override a method in a derived class
* Understand why the same method name can behave differently
* Use base class references with derived objects
* Recognize runtime polymorphism
* Apply polymorphism in real-world programs

---

**Next Module:** 14-ABSTRACTION 

👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx //  mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
