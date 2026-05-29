# 🧵 Pattern Matching

## Introduction

In this module, I learn about **Pattern Matching** in C#.

Pattern matching allows me to check values, types, properties, and conditions in a cleaner and more readable way.

Instead of writing long and repetitive `if` statements, I can use pattern matching to make my code more expressive and professional.

Pattern matching is commonly used with `if`, `switch`, objects, records, nullable values, and modern C# applications.

---

## What I Learn In This Module

* What pattern matching is
* Why pattern matching is useful
* Type patterns
* Constant patterns
* Relational patterns
* Logical patterns
* Property patterns
* Switch expressions
* Pattern matching with records
* Real-world use cases

---

## Why It Matters

Pattern matching helps me write cleaner decision-making code.

It makes conditions easier to understand and reduces repetitive logic.

Pattern matching is useful when I need to:

* Check object types
* Validate values
* Match specific conditions
* Work with records
* Build cleaner switch logic
* Write modern C# code

Professional C# developers use pattern matching in:

* APIs
* Validation systems
* Business rules
* Game logic
* Data processing
* Enterprise applications

---

## Simple Example

```csharp
object value = "Hello";

if (value is string message)
{
    Console.WriteLine(message);
}
```

This checks if `value` is a string and stores it inside the variable `message`.

---

## Real-World Example

A system checks user access level.

```csharp
string role = "Admin";

string access = role switch
{
    "Admin" => "Full Access",
    "Manager" => "Limited Access",
    "User" => "Basic Access",
    _ => "No Access"
};

Console.WriteLine(access);
```

This makes the access logic clean and easy to read.

---

## Skills Gained

After completing this module, I can:

* Use pattern matching with `is`
* Check types safely
* Use switch expressions
* Match values with constants
* Compare values with relational patterns
* Combine conditions with logical patterns
* Match object properties
* Use pattern matching with records
* Write cleaner decision logic

---

## Module Files

This module contains:

* README.md
* PatternMatching_Notes.cs
* PatternMatching_Examples.cs
* PatternMatching_Tasks.cs
* PatternMatching_Tasks_Solutions.cs

---

## Difficulty

Rank 3 — Intermediate ⚙️

Pattern matching is a modern C# feature that improves decision-making code.

---

## Completion Checklist

Before moving forward, I should be able to:

- [ ] Explain what pattern matching is
- [ ] Use the `is` keyword with pattern matching
- [ ] Use type patterns
- [ ] Use constant patterns
- [ ] Use relational patterns
- [ ] Use logical patterns
- [ ] Use property patterns
- [ ] Use switch expressions
- [ ] Apply pattern matching in real-world examples

---

## Next Module

After completing this module, I will continue with:

**25-NULLABLE-TYPES**

---

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
