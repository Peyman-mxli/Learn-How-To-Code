# 🧵 - Structs

## Introduction

In this module, I learn about **Structs** in C#.

Structs are user-defined data types that allow me to group related data together into a single unit.

They are similar to classes because they can contain fields, properties, methods, and constructors.

However, structs are **value types**, while classes are **reference types**.

Understanding structs helps me write more efficient programs and choose the correct type when designing applications.

Structs are commonly used for small objects that represent a single value or concept, such as coordinates, colors, points, dates, measurements, and configurations.

---

## What I Learn In This Module

* What structs are
* Why structs are useful
* Structs vs classes
* Creating structs
* Struct fields
* Struct properties
* Struct methods
* Struct constructors
* Value type behavior
* Passing structs to methods
* Real-world struct usage

---

## Why It Matters

Without structs, I might create many small classes that consume more memory than necessary.

For example:

```csharp
class Point
{
    public int X;
    public int Y;
}
```

For simple data containers, a struct is often a better choice:

```csharp
struct Point
{
    public int X;
    public int Y;
}
```

Structs can improve performance and clearly communicate that an object represents a value.

---

## Simple Example

```csharp
struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point point;

        point.X = 10;
        point.Y = 20;

        Console.WriteLine($"X: {point.X}");
        Console.WriteLine($"Y: {point.Y}");
    }
}
```

Output:

```text
X: 10
Y: 20
```

---

## Real-World Example

A game might store player positions using a struct:

```csharp
struct Position
{
    public float X;
    public float Y;
    public float Z;
}
```

Usage:

```csharp
Position playerPosition;

playerPosition.X = 12.5f;
playerPosition.Y = 3.2f;
playerPosition.Z = 8.0f;
```

This is efficient because a position is simply a collection of values.

---

## Skills Gained

After completing this module, I can:

* Create structs
* Store related data inside structs
* Add methods to structs
* Create constructors for structs
* Understand value type behavior
* Compare structs and classes
* Use structs in real-world applications
* Design efficient data models

---

## Module Files

This module contains:

```text
30-STRUCTS
│
├── README.md
├── Struct_Notes.cs
├── Struct_Examples.cs
├── Struct_Tasks.cs
└── Struct_Tasks_Solutions.cs
```

---

## Difficulty

**Rank 2 : Easy 🙂**

Structs are straightforward to learn and are important for understanding how data is stored and managed in C#.

---

## Completion Checklist

Before moving to the next module, I can:

- [ ] Create a struct
- [ ] Add fields to a struct
- [ ] Add methods to a struct
- [ ] Create struct constructors
- [ ] Explain value types
- [ ] Compare structs and classes
- [ ] Use structs in practical applications

---

## Next Module

After completing this module, I will continue with:

**31-TUPLES**

---

## Author

👤 Author Peyman Miyandashti  
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)  
📞 +526865090453  
🎓 Polytechnic University of Baja California  
💻 Information Technology Engineering & Digital Innovation  
📍 From IRAN (Mexico)  
📅 Year: 2026  
🆔 ID: 250161
