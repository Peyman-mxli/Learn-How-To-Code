# 🧵 - Generics

## Introduction

In this module, I learn about **Generics**, one of the most powerful features in C#.

Generics allow me to create classes, methods, interfaces, and collections that can work with different data types while maintaining type safety.

Before generics, developers often used the `object` type to store values of different types. However, this required casting and increased the risk of runtime errors.

With generics, I can write reusable code that is safer, cleaner, and more efficient.

Generics are heavily used throughout the .NET framework and are considered an essential skill for professional C# developers.

---

## What I Learn In This Module

* What generics are
* Why generics are important
* Generic type parameters
* Generic classes
* Generic methods
* Generic interfaces
* Multiple generic type parameters
* Generic collections
* The `T` type convention
* Generic constraints
* Type safety with generics
* Real-world generic examples

---

## Why Generics Matter

Generics help me create reusable code without sacrificing type safety.

Without generics, I would often need to create multiple versions of the same class or method for different data types.

Generics allow me to write code once and use it with many different types.

This makes my code:

* Cleaner
* Safer
* Easier to maintain
* More reusable
* More efficient
* More professional

---

## Simple Example

A generic class can work with different data types:

```csharp
class Box<T>
{
    public T Value { get; set; }
}
```

Using the generic class:

```csharp
Box<int> numberBox = new Box<int>();
numberBox.Value = 100;

Box<string> textBox = new Box<string>();
textBox.Value = "Hello";
```

The same class works with multiple data types without duplication.

---

## Real-World Example

Many collections in C# use generics.

For example:

```csharp
List<string> names = new List<string>();

names.Add("John");
names.Add("Sarah");
names.Add("David");
```

The `List<T>` class is generic.

The `T` is replaced by the type I want to store.

This provides:

* Better performance
* Type safety
* Cleaner code
* Fewer runtime errors

---

## Skills Gained

After completing this module, I will be able to:

✅ Create generic classes

✅ Create generic methods

✅ Use generic interfaces

✅ Work with generic collections

✅ Apply generic constraints

✅ Understand type parameters

✅ Build reusable code

✅ Create more professional applications

---

## Module Files

### README.md

Module overview and learning objectives.

### Generics_Notes.cs

Detailed explanation of generic classes, methods, interfaces, collections, constraints, and best practices.

### Generics_Examples.cs

Runnable examples demonstrating generics in C#.

### Generics_Tasks.cs

Practice exercises to strengthen generic programming skills.

### Generics_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Generics are considered an advanced topic because they introduce reusable type-safe programming techniques.

Mastering generics will significantly improve my ability to write scalable and professional C# applications.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what generics are
* Create generic classes
* Create generic methods
* Use generic interfaces
* Work with generic collections
* Use type parameters correctly
* Apply generic constraints
* Understand why generics improve code quality

---

**Next Module:** 19-DELEGATES 🚀

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
