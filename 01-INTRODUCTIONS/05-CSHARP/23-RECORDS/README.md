# 🧵 Records

## Introduction

In this module, I learn about **Records** in C#.

Records were introduced to make it easier to create classes that primarily store data.

Before records existed, creating data models often required writing constructors, properties, equality logic, and other repetitive code.

Records help reduce boilerplate code and provide built-in value-based equality.

They are commonly used in modern C# applications, APIs, DTOs (Data Transfer Objects), configuration models, and many enterprise-level projects.

Understanding records helps me write cleaner, more maintainable, and more professional code.

---

## What I Learn In This Module

* What records are
* Why records were introduced
* Record syntax
* Positional records
* Property-based records
* Value-based equality
* Immutability concepts
* The `with` expression
* Records vs classes
* Real-world use cases

---

## Why It Matters

Records solve a common problem in software development.

Many classes are used only to store data.

Writing repetitive code for these classes wastes time and increases maintenance costs.

Records allow me to:

* Write less code
* Create cleaner models
* Improve readability
* Reduce bugs
* Work efficiently with immutable data
* Build modern C# applications

Records are heavily used in:

* Web APIs
* Enterprise applications
* Microservices
* Data transfer objects (DTOs)
* Configuration systems
* Domain models

---

## Simple Example

```csharp
public record Person(string Name, int Age);

Person person1 = new Person("Peyman", 25);
Person person2 = new Person("Peyman", 25);

Console.WriteLine(person1 == person2);
```

Output:

```text
True
```

Unlike normal classes, records compare values instead of memory references.

---

## Real-World Example

A company stores employee information.

```csharp
public record Employee(
    int Id,
    string Name,
    string Department
);
```

Usage:

```csharp
Employee employee =
    new Employee(1, "Peyman", "IT");
```

This creates a clean, professional data model with minimal code.

---

## Skills Gained

After completing this module, I can:

* Create records
* Use positional records
* Use property-based records
* Understand value equality
* Work with immutable objects
* Use the `with` expression
* Choose between records and classes
* Build cleaner data models

---

## Module Files

This module contains:

* README.md
* Records_Notes.cs
* Records_Examples.cs
* Records_Tasks.cs
* Records_Tasks_Solutions.cs

---

## Difficulty

Rank 3 — Intermediate ⚙️

Records introduce modern C# features that are heavily used in professional development.

---

## Completion Checklist

Before moving forward, I should be able to:

- [ ] Explain what a record is
- [ ] Create positional records
- [ ] Create property-based records
- [ ] Understand value equality
- [ ] Use immutable data
- [ ] Use the `with` expression
- [ ] Explain records vs classes
- [ ] Build real-world record models

---

## Next Module

After completing this module, I will continue with:

**24-PATTERN-MATCHING**

---

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
