# 🧵 Extension Methods

## Introduction

In this module, I learn about **Extension Methods** in C#.

Extension methods allow me to add new methods to existing types without modifying the original class.

This is useful when I want to make my code cleaner, easier to read, and more reusable.

Extension methods are commonly used in modern C#, especially with LINQ and helper methods.

---

## What I Learn In This Module

* What extension methods are
* Why extension methods are useful
* How to create extension methods
* Static classes
* Static methods
* The `this` keyword in extension methods
* Extension methods with strings
* Extension methods with numbers
* Extension methods with objects
* Real-world helper methods

---

## Why It Matters

Extension methods help me improve code readability.

Instead of writing helper methods like this:

```csharp
StringHelper.Capitalize(name);
```

I can write cleaner code like this:

```csharp
name.Capitalize();
```

This makes the method feel like it belongs to the object.

Extension methods are useful for:

* Cleaner code
* Reusable helper methods
* LINQ-style programming
* Utility functions
* Professional C# projects

---

## Simple Example

```csharp
public static class StringExtensions
{
    public static string AddExclamation(this string text)
    {
        return text + "!";
    }
}
```

Usage:

```csharp
string message = "Hello";

Console.WriteLine(message.AddExclamation());
```

Output:

```text
Hello!
```

---

## Real-World Example

A system formats usernames.

```csharp
public static class UserExtensions
{
    public static string ToDisplayName(this string username)
    {
        return "User: " + username;
    }
}
```

Usage:

```csharp
string username = "peyman";

Console.WriteLine(username.ToDisplayName());
```

Output:

```text
User: peyman
```

---

## Skills Gained

After completing this module, I can:

* Create extension methods
* Use static classes
* Use static methods
* Understand the `this` keyword
* Extend string functionality
* Extend number functionality
* Create reusable helper methods
* Write cleaner C# code

---

## Module Files

This module contains:

* README.md
* ExtensionMethods_Notes.cs
* ExtensionMethods_Examples.cs
* ExtensionMethods_Tasks.cs
* ExtensionMethods_Tasks_Solutions.cs

---

## Difficulty

Rank 3 — Intermediate ⚙️

Extension methods are simple to use but important for writing clean professional C# code.

---

## Completion Checklist

Before moving forward, I should be able to:

- [ ] Explain what extension methods are
- [ ] Create a static extension class
- [ ] Create a static extension method
- [ ] Use the `this` keyword correctly
- [ ] Add helper methods to existing types
- [ ] Use extension methods with strings
- [ ] Use extension methods with numbers
- [ ] Build reusable utility methods

---

## Next Module

After completing this module, I will continue with:

**27-PARTIAL-CLASSES**

---

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
