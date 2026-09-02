# 🧵 - Encapsulation

## Introduction

In this module, I learn one of the most important principles of Object-Oriented Programming (OOP): **Encapsulation**.

Encapsulation is the practice of protecting data inside a class and controlling how that data is accessed or modified. Instead of allowing direct access to variables, I learn how to use methods and properties to manage data safely.

This concept helps me create more secure, organized, and maintainable applications.

Encapsulation is one of the four main pillars of Object-Oriented Programming:

* Encapsulation
* Inheritance
* Polymorphism
* Abstraction

By understanding encapsulation, I can prevent invalid data, reduce bugs, and make my code easier to maintain as projects grow larger.

---

## What I Learn In This Module

* What encapsulation is
* Why encapsulation is important
* Public vs Private access modifiers
* Protecting class data
* Using Getter methods
* Using Setter methods
* Creating Properties
* Auto-Implemented Properties
* Read-Only Properties
* Encapsulation best practices
* Real-world examples of encapsulation

---

## Why Encapsulation Matters

Without encapsulation, any part of a program could change important data and potentially create bugs.

For example:

* Negative ages
* Invalid salaries
* Empty usernames
* Incorrect account balances

Encapsulation allows me to control what values are accepted and reject invalid data before they cause problems.

This makes applications:

* Safer
* Cleaner
* Easier to debug
* Easier to maintain
* More professional

---

## Real-World Example

Imagine a bank account.

A user should not be able to directly modify the account balance:

```csharp
account.balance = -50000;
```

Instead, the balance should be protected:

```csharp
account.Deposit(100);
account.Withdraw(50);
```

This allows the class to verify that every operation is valid before changing the balance.

This is the core idea behind encapsulation.

---

## Skills Gained

After completing this module, I will be able to:

✅ Protect class data

✅ Use private fields

✅ Create getter and setter methods

✅ Build properties

✅ Validate user input

✅ Write safer object-oriented code

✅ Follow professional C# coding practices

---

## Module Files

### README.md

Module overview and learning objectives.

### Encapsulation_Notes.cs

Detailed explanation of encapsulation concepts, access modifiers, properties, validation, and best practices.

### Encapsulation_Examples.cs

Runnable examples demonstrating encapsulation in action.

### Encapsulation_Tasks.cs

Practice exercises to strengthen understanding of encapsulation.

### Encapsulation_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 2 — Easy 🙂**

Encapsulation is usually the first Object-Oriented Programming concept that beginners learn after classes and constructors.

Although simple at first, it becomes one of the most important skills for building professional software.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain encapsulation
* Create private fields
* Use public methods to access data
* Create properties
* Validate data before storing it
* Protect sensitive information inside classes
* Understand why encapsulation improves software quality

---

**Next Module:** 12-INHERITANCE 🚀

👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
