# 🧵 - Tuples

## Introduction

In this module, I learn about **Tuples** in C#.

Tuples allow me to store multiple values together without creating a full class or struct.

They are useful when I need to return more than one value from a method or quickly group related information.

Tuples make code shorter, cleaner, and easier to write when the data is simple and temporary.

---

## What I Learn In This Module

* What tuples are
* Why tuples are useful
* Creating tuples
* Named tuple values
* Returning multiple values from methods
* Accessing tuple values
* Tuple deconstruction
* Tuples vs classes
* Tuples vs structs
* Real-world tuple usage

---

## Why It Matters

Sometimes I need a method to return more than one value.

Without tuples, I may need to create a full class or struct just for a small result.

Example:

```csharp
string name = "Peyman";
int age = 25;
```

With tuples, I can group them together:

```csharp
var person = ("Peyman", 25);
```

Even better, I can name the values:

```csharp
var person = (Name: "Peyman", Age: 25);
```

Now the code is simple and easy to understand.

---

## Simple Example

```csharp
var student = ("Sara", 95);

Console.WriteLine(student.Item1);
Console.WriteLine(student.Item2);
```

Output:

```text
Sara
95
```

---

## Real-World Example

A method can return multiple values:

```csharp
static (string Name, int Score) GetStudent()
{
    return ("Peyman", 100);
}
```

Usage:

```csharp
var student = GetStudent();

Console.WriteLine(student.Name);
Console.WriteLine(student.Score);
```

Output:

```text
Peyman
100
```

This is useful when I need quick grouped results without creating extra types.

---

## Skills Gained

After completing this module, I can:

* Create tuples
* Use named tuple values
* Access tuple data
* Return multiple values from methods
* Deconstruct tuples
* Compare tuples with classes and structs
* Use tuples in practical C# programs
* Write cleaner short-result methods

---

## Module Files

This module contains:

```text
31-TUPLES
│
├── README.md
├── Tuple_Notes.cs
├── Tuple_Examples.cs
├── Tuple_Tasks.cs
└── Tuple_Tasks_Solutions.cs
```

---

## Difficulty

**Rank 2 : Easy 🙂**

Tuples are simple to learn and very helpful when working with grouped temporary data.

---

## Completion Checklist

Before moving to the next module, I can:

- [ ] Create a tuple
- [ ] Access tuple values using Item1 and Item2
- [ ] Create named tuples
- [ ] Return multiple values from a method
- [ ] Deconstruct tuples
- [ ] Explain when tuples are useful
- [ ] Compare tuples with classes and structs

---

## Next Module

After completing this module, I will continue with:

**32-INDEXERS**

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
