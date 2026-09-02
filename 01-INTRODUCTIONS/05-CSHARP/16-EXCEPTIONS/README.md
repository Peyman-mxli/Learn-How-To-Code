# 🧵 - Exceptions

## Introduction

In this module, I learn about **Exceptions** in C#.

Exceptions are errors that happen while a program is running.

Instead of letting the program crash, C# allows me to handle errors safely using exception handling.

Exception handling helps me build stronger, safer, and more professional applications.

---

## What I Learn In This Module

* What exceptions are
* Why exceptions happen
* Runtime errors
* The `try` block
* The `catch` block
* The `finally` block
* Common exception types
* Handling multiple exceptions
* Throwing exceptions
* Best practices for exception handling

---

## Why Exceptions Matter

Programs can fail for many reasons.

For example:

* A user enters invalid input
* A file does not exist
* A number is divided by zero
* A database connection fails
* A value is missing or null

Exception handling allows me to respond to these problems without crashing the entire program.

This makes code:

* Safer
* More stable
* Easier to debug
* Easier to maintain
* More professional

---

## Simple Example

```csharp
try
{
    int number = 10;
    int result = number / 0;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
```

The `try` block contains code that might fail.

The `catch` block handles the error safely.

---

## Real-World Example

Imagine a program that reads a file.

If the file does not exist, the program should not crash.

Instead, it can show a helpful message:

```csharp
try
{
    string text = File.ReadAllText("data.txt");
}
catch (FileNotFoundException)
{
    Console.WriteLine("The file was not found.");
}
```

This allows the program to continue or guide the user correctly.

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain exceptions

✅ Use `try` and `catch`

✅ Use `finally`

✅ Handle common runtime errors

✅ Handle multiple exception types

✅ Throw custom errors

✅ Prevent program crashes

✅ Write safer professional C# programs

---

## Module Files

### README.md

Module overview and learning objectives.

### Exceptions_Notes.cs

Detailed explanation of exceptions, try-catch-finally, common errors, throwing exceptions, and best practices.

### Exceptions_Examples.cs

Runnable examples demonstrating exception handling in C#.

### Exceptions_Tasks.cs

Practice exercises to strengthen exception handling skills.

### Exceptions_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 3 — Intermediate ⚙️**

Exceptions are an intermediate topic because they require understanding program flow and how errors can happen while code is running.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what an exception is
* Use a `try` block
* Use a `catch` block
* Use a `finally` block
* Handle divide-by-zero errors
* Handle invalid input errors
* Handle file-related errors
* Understand why exception handling improves program safety

---

**Next Module:** 17-FILES

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
