# 🧵 - Events

## Introduction

In this module, I learn about **Events** in C#.

Events allow one part of a program to notify another part of the program when something happens.

Events are built on top of delegates, which means they use delegate behavior to connect actions and responses.

For example, when a button is clicked, a player takes damage, a file finishes loading, or a user logs in, an event can notify the program that something happened.

Events are important because they help me create programs that are flexible, organized, and reactive.

---

## What I Learn In This Module

* What events are
* Why events are useful
* How events connect to delegates
* Event declaration syntax
* Subscribing to events
* Unsubscribing from events
* Raising events
* Event handlers
* The `event` keyword
* Built-in `EventHandler`
* Custom event arguments
* Real-world event examples

---

## Why Events Matter

Events help my program respond to actions.

Instead of constantly checking if something happened, I can let an event notify the correct part of the program automatically.

This makes my code:

* Cleaner
* More organized
* Easier to maintain
* Easier to expand
* More professional

Events are used heavily in user interfaces, games, applications, APIs, and many professional C# systems.

---

## Simple Example

An event can notify the program when something happens.

```csharp
class Button
{
    public event Action OnClick;

    public void Click()
    {
        OnClick?.Invoke();
    }
}
```

Using the event:

```csharp
class Program
{
    static void ShowMessage()
    {
        Console.WriteLine("Button clicked!");
    }

    static void Main()
    {
        Button button = new Button();

        button.OnClick += ShowMessage;

        button.Click();
    }
}
```

When the button is clicked, the subscribed method runs automatically.

---

## Real-World Example

Imagine I am creating a game.

The player may trigger different events:

* Player takes damage
* Player levels up
* Player collects an item
* Enemy dies
* Quest is completed

Instead of connecting everything manually, I can use events to notify other systems.

For example:

* Health UI updates when health changes
* XP bar updates when the player gains experience
* Loot appears when an enemy dies
* Sound effects play when an item is collected

Events help different systems communicate without being tightly connected.

---

## Skills Gained

After completing this module, I will be able to:

✅ Create events

✅ Subscribe methods to events

✅ Unsubscribe methods from events

✅ Raise events safely

✅ Use the `event` keyword

✅ Understand event handlers

✅ Use `EventHandler`

✅ Create custom event arguments

✅ Build reactive C# systems

✅ Understand how professional applications communicate internally

---

## Module Files

### README.md

Module overview and learning objectives.

### Events_Notes.cs

Detailed explanation of events, delegates, event handlers, subscriptions, custom event arguments, and best practices.

### Events_Examples.cs

Runnable examples demonstrating events in C#.

### Events_Tasks.cs

Practice exercises to strengthen event programming skills.

### Events_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Events are considered advanced because they build on delegates and introduce communication between different parts of a program.

Once I understand events, I can create more professional, reactive, and maintainable C# applications.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what events are
* Explain how events use delegates
* Create an event
* Subscribe to an event
* Unsubscribe from an event
* Raise an event safely
* Use the `event` keyword
* Use `EventHandler`
* Understand why events reduce tight coupling
* Apply events in real-world systems

---

**Next Module:** 21-LINQ 🚀

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
