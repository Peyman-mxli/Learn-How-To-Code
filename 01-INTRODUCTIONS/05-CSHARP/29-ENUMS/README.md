# 🧵 - Enums

## Introduction

In this module, I learn about **Enums (Enumerations)** in C#.

Enums allow me to create a collection of named constants that make my code easier to read, understand, and maintain.

Instead of using random numbers throughout my programs, I can use meaningful names that clearly describe the values being used.

Enums are commonly used in professional applications for statuses, game states, user roles, menu options, days of the week, and many other situations where a variable can only have a limited set of predefined values.

---

## What I Learn In This Module

* What enums are
* Why enums are useful
* How to create enums
* How to assign values to enum members
* How to access enum values
* How to convert enums to integers
* How to convert integers to enums
* Using enums in conditions and switch statements
* Real-world enum usage

---

## Why It Matters

Without enums, I might write code like this:

```csharp
int status = 1;
```

Later, I may forget what the number means.

Does 1 mean Active?

Does it mean Pending?

Does it mean Completed?

Enums solve this problem:

```csharp
Status status = Status.Active;
```

Now the code clearly explains itself.

Enums make programs easier to read and reduce mistakes.

---

## Simple Example

```csharp
enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Days today = Days.Friday;

        Console.WriteLine(today);
    }
}
```

Output:

```text
Friday
```

---

## Real-World Example

A game character may have different states:

```csharp
enum CharacterState
{
    Idle,
    Walking,
    Running,
    Attacking,
    Dead
}
```

Usage:

```csharp
CharacterState playerState = CharacterState.Running;

Console.WriteLine(playerState);
```

Output:

```text
Running
```

This is much cleaner than storing numbers like:

```csharp
int state = 2;
```

---

## Skills Gained

After completing this module, I can:

* Create enums
* Assign custom enum values
* Read enum values
* Convert enums and integers
* Use enums in conditions
* Use enums in real-world projects
* Improve code readability
* Replace magic numbers with meaningful names

---

## Module Files

This module contains:

```text
29-ENUMS
│
├── README.md
├── Enum_Notes.cs
├── Enum_Examples.cs
├── Enum_Tasks.cs
└── Enum_Tasks_Solutions.cs
```

---

## Difficulty

**Rank 2 : Easy 🙂**

Enums are simple to learn but extremely useful in professional software development.

---

## Completion Checklist

Before moving to the next module, I can:

- [ ] Create an enum
- [ ] Access enum members
- [ ] Assign custom values
- [ ] Convert enum values to integers
- [ ] Convert integers to enums
- [ ] Use enums inside switch statements
- [ ] Use enums in real projects

---

## Next Module

After completing this module, I will continue with:

**30-STRUCTS**

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
