# C#

C# is a modern, statically typed, object-oriented programming language created by Microsoft and used with the .NET platform.

## What can C# build?

- console and desktop applications;
- ASP.NET Core websites and APIs;
- cloud services;
- enterprise applications;
- games with Unity;
- cross-platform applications with .NET MAUI; and
- backend systems and developer tools.

## How C# works

```text
C# source
   ↓
C# compiler
   ↓
Intermediate Language (IL)
   ↓
.NET runtime
   ↓
Program execution
```

The compiler checks syntax and type rules before execution, while the .NET runtime manages execution, memory, and many platform services.

## First program

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

## Understanding the code

### `using System;`

Imports names from the `System` namespace so types such as `Console` can be referenced conveniently.

### `class Program`

Defines a class named `Program`. A class is a type that can contain data and behavior.

### `static void Main()`

Defines a traditional program entry point. Modern .NET projects can also use top-level statements, but learning `Main` is useful for understanding program structure.

### `Console.WriteLine(...)`

Writes text to the console and moves to the next line.

### Semicolons

Most C# statements end with a semicolon.

## Curriculum

This section contains a broad C# path from fundamentals through professional topics, including:

- variables, syntax, input/output, operators, conditions, loops, arrays, and methods;
- classes, constructors, encapsulation, inheritance, polymorphism, abstraction, and interfaces;
- exceptions, files, generics, delegates, events, LINQ, async/await;
- modern C# features such as records, pattern matching, nullable types, tuples, and extension methods;
- testing, debugging, dependency injection, SOLID, design patterns, clean code;
- multithreading, networking, JSON, Entity Framework, ASP.NET Core, REST APIs; and
- professional project architecture.

Study the numbered folders in order when learning from the beginning.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026

