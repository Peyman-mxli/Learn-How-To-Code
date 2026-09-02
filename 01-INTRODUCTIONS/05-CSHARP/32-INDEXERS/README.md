# 🧵 - Indexers

## Introduction

In this module, I learn about **Indexers** in C#.

Indexers allow objects to be accessed like arrays.

This means I can use square brackets `[ ]` on my own classes and structs to get or set values.

Indexers are useful when I create custom collections, lists, inventories, catalogs, student records, game slots, or any object that stores multiple values internally.

---

## What I Learn In This Module

* What indexers are
* Why indexers are useful
* How to create an indexer
* How to use square brackets with objects
* Get and set accessors
* Indexers with arrays
* Indexers with lists
* Indexers with strings
* Read-only indexers
* Real-world indexer usage

---

## Why It Matters

Normally, arrays use square brackets:

```csharp
string[] names = { "Ali", "Sara", "Peyman" };

Console.WriteLine(names[0]);
```

With indexers, I can make my own class work the same way:

```csharp
StudentList students = new StudentList();

students[0] = "Peyman";

Console.WriteLine(students[0]);
```

This makes custom objects easier and more natural to use.

---

## Simple Example

```csharp
class StudentList
{
    private string[] students = new string[3];

    public string this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }
}
```

Usage:

```csharp
StudentList list = new StudentList();

list[0] = "Peyman";

Console.WriteLine(list[0]);
```

Output:

```text
Peyman
```

---

## Real-World Example

A game inventory can use an indexer:

```csharp
class Inventory
{
    private string[] items = new string[5];

    public string this[int slot]
    {
        get
        {
            return items[slot];
        }

        set
        {
            items[slot] = value;
        }
    }
}
```

Usage:

```csharp
Inventory inventory = new Inventory();

inventory[0] = "Sword";
inventory[1] = "Potion";

Console.WriteLine(inventory[0]);
Console.WriteLine(inventory[1]);
```

Output:

```text
Sword
Potion
```

---

## Skills Gained

After completing this module, I can:

* Create indexers
* Access objects using square brackets
* Add get and set accessors
* Build custom collection-like classes
* Use indexers with arrays
* Use indexers with lists
* Create read-only indexers
* Apply indexers in real-world projects

---

## Module Files

This module contains:

```text
32-INDEXERS
│
├── README.md
├── Indexer_Notes.cs
├── Indexer_Examples.cs
├── Indexer_Tasks.cs
└── Indexer_Tasks_Solutions.cs
```

---

## Difficulty

**Rank 3 : Intermediate ⚙️**

Indexers are simple to use, but they require a good understanding of classes, arrays, properties, get accessors, and set accessors.

---

## Completion Checklist

Before moving to the next module, I can:

- [ ] Explain what an indexer is
- [ ] Create an indexer
- [ ] Use square brackets on a custom object
- [ ] Add get and set accessors
- [ ] Create read-only indexers
- [ ] Use indexers with arrays
- [ ] Use indexers in practical projects

---

## Next Module

After completing this module, I will continue with:

**33-OVERLOADING**

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
