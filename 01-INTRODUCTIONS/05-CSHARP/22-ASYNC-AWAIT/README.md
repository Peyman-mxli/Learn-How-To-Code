# 🧵 - Async Await

## Introduction

In this module, I learn about **async** and **await** in C#.

Async and await allow me to write code that can perform long-running operations without freezing the program.

These operations may include loading files, downloading data, connecting to APIs, waiting for database results, or running background tasks.

Instead of blocking the entire program, async and await help my code stay responsive while waiting for work to finish.

This is very important in modern applications, especially desktop apps, web apps, mobile apps, games, and API-based systems.

---

## What I Learn In This Module

* What asynchronous programming is
* Why async code is useful
* The difference between synchronous and asynchronous code
* The `async` keyword
* The `await` keyword
* The `Task` type
* The `Task<T>` type
* Returning values from async methods
* Waiting for operations without freezing the program
* Common async mistakes
* Real-world async examples

---

## Why Async Await Matters

Async and await help me write programs that stay responsive.

Without async code, long-running operations can block the program.

For example, if a program downloads data from the internet, the user interface may freeze until the download finishes.

With async and await, the program can continue working while waiting for the operation to complete.

This makes my code:

* More responsive
* More efficient
* Easier to maintain
* Easier to read
* More scalable
* More professional

---

## Simple Example

An async method can wait without blocking the program.

```csharp
using System;
using System.Threading.Tasks;

class Program
{
    static async Task LoadDataAsync()
    {
        Console.WriteLine("Loading data...");

        await Task.Delay(2000);

        Console.WriteLine("Data loaded.");
    }

    static async Task Main()
    {
        await LoadDataAsync();
    }
}
```

The `await` keyword waits for the task to finish without freezing the application.

---

## Real-World Example

Imagine I am building an application that loads user data from an online server.

The application may need to:

* Connect to the server
* Request user information
* Wait for the response
* Display the data
* Continue running smoothly while waiting

Async and await allow this process to happen without locking the program.

This is useful in:

* Web APIs
* File loading
* Database calls
* Download systems
* User interface applications
* Game loading systems

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain asynchronous programming

✅ Use the `async` keyword

✅ Use the `await` keyword

✅ Create async methods

✅ Return `Task`

✅ Return `Task<T>`

✅ Wait for operations without blocking the program

✅ Handle simple async workflows

✅ Understand common async mistakes

✅ Write more responsive C# applications

---

## Module Files

### README.md

Module overview and learning objectives.

### AsyncAwait_Notes.cs

Detailed explanation of asynchronous programming, async methods, await, Task, Task<T>, delays, return values, and best practices.

### AsyncAwait_Examples.cs

Runnable examples demonstrating async and await in C#.

### AsyncAwait_Tasks.cs

Practice exercises to strengthen async and await skills.

### AsyncAwait_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 4 — Advanced 🚀**

Async and await are advanced because they change how I think about program flow and waiting for operations.

Once I understand async and await, I can build applications that are smoother, faster, and more professional.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what asynchronous programming is
* Explain the difference between sync and async code
* Use the `async` keyword
* Use the `await` keyword
* Create methods that return `Task`
* Create methods that return `Task<T>`
* Use `Task.Delay`
* Understand why async code improves responsiveness
* Avoid blocking the program unnecessarily
* Apply async and await in real-world scenarios

---

**Next Module:** 23-RECORDS 🚀

👤 Author Peyman Miyandashti


🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026
