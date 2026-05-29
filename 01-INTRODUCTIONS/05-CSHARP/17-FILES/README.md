# 🧵 - Files

## Introduction

In this module, I learn about **Files** in C#.

Files allow a program to store data permanently.

Without files, most data disappears when the program closes.

File handling helps me read, write, create, update, and manage information outside the program while it is running.

---

## What I Learn In This Module

* What file handling is
* Why files are important
* Reading files
* Writing files
* Creating files
* Appending text to files
* Checking if a file exists
* Working with file paths
* Handling file errors
* Real-world file examples

---

## Why Files Matter

Files are used in many real applications.

For example:

* Saving user settings
* Storing game progress
* Reading configuration data
* Saving reports
* Writing logs
* Loading external information

This makes programs:

* More useful
* More permanent
* More flexible
* More professional

---

## Simple Example

```csharp
File.WriteAllText("message.txt", "Hello, C#!");

string text = File.ReadAllText("message.txt");

Console.WriteLine(text);
```

The first line writes text into a file.

The second line reads the text back from the file.

---

## Real-World Example

Imagine a program that saves student names.

The program can write names into a file:

```csharp
File.WriteAllText("students.txt", "Peyman");
```

Later, the program can read the file again:

```csharp
string studentName = File.ReadAllText("students.txt");

Console.WriteLine(studentName);
```

This allows information to remain saved even after the program closes.

---

## Skills Gained

After completing this module, I will be able to:

✅ Explain file handling

✅ Create files

✅ Write text to files

✅ Read text from files

✅ Append new text to existing files

✅ Check if files exist

✅ Work with file paths

✅ Handle file-related errors

✅ Build programs that store data permanently

---

## Module Files

### README.md

Module overview and learning objectives.

### Files_Notes.cs

Detailed explanation of file handling, reading, writing, appending, paths, and best practices.

### Files_Examples.cs

Runnable examples demonstrating file handling in C#.

### Files_Tasks.cs

Practice exercises to strengthen file handling skills.

### Files_Tasks_Solutions.cs

Complete professional solutions for all tasks.

---

## Difficulty

**Rank 3 — Intermediate ⚙️**

Files are an intermediate topic because they introduce working with data outside the program and require basic exception handling knowledge.

---

## Completion Checklist

Before moving to the next module, I should be able to:

* Explain what file handling is
* Use `File.WriteAllText()`
* Use `File.ReadAllText()`
* Use `File.AppendAllText()`
* Check if a file exists
* Understand basic file paths
* Handle file errors safely
* Save and load data from files

---

**Next Module:** 18-GENERICS

👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
