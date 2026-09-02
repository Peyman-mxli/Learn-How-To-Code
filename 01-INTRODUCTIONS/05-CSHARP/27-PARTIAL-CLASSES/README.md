# 🧵 Partial Classes

## Introduction

In this module, I learn about **Partial Classes** in C#.

Partial classes allow me to split one class into multiple files.

This is useful when a class becomes large, or when generated code and handwritten code need to stay separated.

Even though the class is written in multiple files, C# combines all parts into one class when the program is compiled.

---

## What I Learn In This Module

* What partial classes are
* Why partial classes are useful
* How to create partial classes
* The `partial` keyword
* Splitting a class into multiple files
* Partial methods
* Generated code separation
* Real-world use cases

---

## Why It Matters

Partial classes help me organize large code files.

They allow me to separate responsibilities without creating unnecessary new classes.

Partial classes are commonly used in:

* Windows Forms
* WPF
* Entity Framework
* Generated code
* Large enterprise projects
* Game development systems

They help keep code cleaner, easier to manage, and more professional.

---

## Simple Example

```csharp
public partial class Player
{
    public string Name { get; set; }
}
```

Another file:

```csharp
public partial class Player
{
    public void Attack()
    {
        Console.WriteLine("Player attacks!");
    }
}
```

Both parts belong to the same `Player` class.

---

## Real-World Example

A game character can be split into different files:

```csharp
public partial class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
}
```

```csharp
public partial class Character
{
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
```

This keeps character data separate from combat behavior.

---

## Skills Gained

After completing this module, I can:

* Create partial classes
* Split a class into multiple files
* Use the `partial` keyword
* Organize large classes
* Understand generated code separation
* Use partial methods
* Build cleaner class structures

---

## Module Files

This module contains:

* README.md
* PartialClasses_Notes.cs
* PartialClasses_Examples.cs
* PartialClasses_Tasks.cs
* PartialClasses_Tasks_Solutions.cs

---

## Difficulty

Rank 3 — Intermediate ⚙️

Partial classes are not difficult, but they are important for organizing larger C# projects.

---

## Completion Checklist

Before moving forward, I should be able to:

- [ ] Explain what partial classes are
- [ ] Use the `partial` keyword
- [ ] Split one class into multiple files
- [ ] Understand how C# combines partial classes
- [ ] Create partial methods
- [ ] Explain when partial classes are useful
- [ ] Use partial classes in real-world projects

---

## Next Module

After completing this module, I will continue with:

**28-NAMESPACES**

---

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
