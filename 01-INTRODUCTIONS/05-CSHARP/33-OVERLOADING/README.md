# 🧵 Overloading

## Introduction

In this module, I learn about **Overloading** in C#.

Overloading allows me to create multiple methods, constructors, or operators with the same name but different parameters.

This makes my code cleaner, easier to understand, and more flexible.

Instead of creating many different method names, I can reuse the same name and let C# decide which version to execute based on the arguments provided.

Overloading is a common technique used in professional software development and throughout the .NET ecosystem.

---

## What I Learn In This Module

* What overloading is
* Why overloading is useful
* Method overloading
* Constructor overloading
* Parameter differences
* Return type limitations
* How C# chooses overloaded methods
* Real-world uses of overloading

---

## Why It Matters

Without overloading, I would need many different method names.

For example:

```csharp
AddTwoNumbers()
AddThreeNumbers()
AddFourNumbers()
```

With overloading:

```csharp
Add()
```

can handle multiple versions.

This keeps code cleaner and easier to maintain.

Overloading is used everywhere in C#, including:

* Console.WriteLine()
* String methods
* Math operations
* Framework libraries
* Custom application development

---

## Simple Example

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

Usage:

```csharp
Calculator calc = new Calculator();

Console.WriteLine(calc.Add(5, 3));
Console.WriteLine(calc.Add(5, 3, 2));
```

Output:

```text
8
10
```

---

## Real-World Example

Imagine I am building a registration system.

Some users provide only a name.

Others provide a name and email.

Others provide a name, email, and phone number.

Instead of creating multiple method names:

```csharp
RegisterBasic()
RegisterWithEmail()
RegisterFull()
```

I can overload the same method:

```csharp
Register()
```

with different parameter combinations.

This keeps the API simple and professional.

---

## Skills Gained

After completing this module, I can:

✅ Understand method overloading

✅ Create multiple methods with the same name

✅ Use constructor overloading

✅ Improve code readability

✅ Reduce unnecessary method names

✅ Design cleaner APIs

✅ Understand how C# selects overloaded methods

---

## Module Files

This module contains:

```text
33-OVERLOADING
│
├── README.md
├── Overloading_Notes.cs
├── Overloading_Examples.cs
├── Overloading_Tasks.cs
└── Overloading_Tasks_Solutions.cs
```

---

## Difficulty

**Rank 2 — Easy 🙂**

This topic is straightforward once I understand methods and parameters.

---

## Completion Checklist

Before moving forward, I should be able to:

* [ ] Explain what overloading is
* [ ] Create overloaded methods
* [ ] Create overloaded constructors
* [ ] Understand parameter differences
* [ ] Know why return type alone cannot overload methods
* [ ] Apply overloading in real projects

---

## Next Module

After completing this module, I will continue to:

**34-OPERATOR-OVERLOADING**

There I will learn how to redefine operators such as:

```csharp
+
-
*
==
```

for my own custom classes and objects.

---

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
