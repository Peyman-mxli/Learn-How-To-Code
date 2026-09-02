# 🧵 Nullable Types

## Introduction

In this module, I learn about **Nullable Types** in C#.

Nullable types allow variables to store normal values or `null`.

This is important because sometimes data may be missing, unknown, or optional.

Understanding nullable types helps me write safer code and avoid common errors like `NullReferenceException`.

---

## What I Learn In This Module

* What nullable types are
* Why null values matter
* Nullable value types
* Nullable reference types
* The `?` symbol
* The `??` operator
* The `??=` operator
* Null checking
* Safe access with `?.`
* Real-world nullable examples

---

## Why It Matters

Null values are very common in real applications.

Data can be missing from:

* Forms
* Databases
* APIs
* User input
* Files
* Configuration settings

Nullable types help me handle missing data safely and professionally.

---

## Simple Example

```csharp
int? age = null;

if (age.HasValue)
{
    Console.WriteLine(age.Value);
}
else
{
    Console.WriteLine("Age is unknown");
}
```

---

## Real-World Example

A user profile may not always have a phone number.

```csharp
public class UserProfile
{
    public string Name { get; set; }
    public string? PhoneNumber { get; set; }
}
```

The phone number is optional, so it can be `null`.

---

## Skills Gained

After completing this module, I can:

* Create nullable value types
* Understand nullable reference types
* Check for null safely
* Use `??`
* Use `??=`
* Use `?.`
* Avoid null-related errors
* Build safer real-world applications

---

## Module Files

This module contains:

* README.md
* NullableTypes_Notes.cs
* NullableTypes_Examples.cs
* NullableTypes_Tasks.cs
* NullableTypes_Tasks_Solutions.cs

---

## Difficulty

Rank 3 — Intermediate ⚙️

Nullable types are important for writing safe and modern C# code.

---

## Completion Checklist

Before moving forward, I should be able to:

- [ ] Explain what nullable types are
- [ ] Use nullable value types
- [ ] Use nullable reference types
- [ ] Check if a nullable value has data
- [ ] Use the `??` operator
- [ ] Use the `??=` operator
- [ ] Use the `?.` operator
- [ ] Avoid common null errors

---

## Next Module

After completing this module, I will continue with:

**26-EXTENSION-METHODS**

---

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
