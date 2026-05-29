```csharp
using System;

/*
=========================================
GENERICS NOTES
=========================================

In this module, I learn about Generics.

Generics allow me to create reusable code that works with different
data types while maintaining type safety.

Generics are one of the most important features in modern C# because
they reduce code duplication and help me build flexible applications.

=========================================
WHAT ARE GENERICS?
=========================================

A Generic is a type that uses placeholders for data types.

Instead of creating separate classes or methods for each data type,
I can create one generic version that works for many types.

Example:

Box<int>
Box<string>
Box<double>

The same class can be reused with different data types.

=========================================
WHY GENERICS EXIST
=========================================

Before Generics, developers often used the object type.

Example:

object value = 100;
object name = "Peyman";

The problem is that object can store anything.

When retrieving the value, I must cast it back to the original type.

Example:

int number = (int)value;

This introduces:

• Extra casting
• Reduced performance
• Runtime errors
• Less readable code

Generics solve these problems.

=========================================
GENERIC TYPE PARAMETERS
=========================================

A Generic type parameter is a placeholder for a real data type.

The most common placeholder is:

T

Example:

class Box<T>
{
}

T usually means:

Type

When creating an object:

Box<int>

The T becomes int.

When creating:

Box<string>

The T becomes string.

=========================================
GENERIC CLASS
=========================================

A Generic class can work with many data types.

Example:

class Box<T>
{
    public T Value;
}

Usage:

Box<int> numberBox = new Box<int>();

Box<string> textBox = new Box<string>();

Benefits:

• Reusable
• Type-safe
• Flexible

=========================================
GENERIC METHOD
=========================================

Methods can also be Generic.

Example:

public void Print<T>(T value)
{
    Console.WriteLine(value);
}

Usage:

Print<int>(100);

Print<string>("Hello");

Print<double>(99.99);

One method works with many data types.

=========================================
TYPE INFERENCE
=========================================

Often C# automatically determines the type.

Example:

Print(100);

Print("Hello");

Print(99.99);

The compiler figures out the type automatically.

This is called:

Type Inference

=========================================
MULTIPLE GENERIC TYPES
=========================================

A Generic can contain multiple type parameters.

Example:

class DataPair<TKey, TValue>
{
    public TKey Key;
    public TValue Value;
}

Usage:

DataPair<int, string>

Example:

ID = 1
Name = "Peyman"

Benefits:

• Stores related values
• Strong type safety
• Flexible design

=========================================
GENERIC INTERFACES
=========================================

Interfaces can also be Generic.

Example:

interface IRepository<T>
{
    void Add(T item);
}

Examples:

IRepository<User>

IRepository<Product>

IRepository<Employee>

This allows the same interface to support many data types.

=========================================
GENERIC COLLECTIONS
=========================================

The .NET Framework contains many Generic collections.

=========================================
LIST<T>
=========================================

Stores a dynamic collection of items.

Example:

List<string> names = new List<string>();

Benefits:

• Dynamic size
• Easy access
• Strong typing

=========================================
DICTIONARY<TKey, TValue>
=========================================

Stores key-value pairs.

Example:

Dictionary<int, string>

Example:

1 -> Peyman
2 -> Sarah

Benefits:

• Fast lookups
• Organized data

=========================================
QUEUE<T>
=========================================

First In First Out (FIFO)

Example:

Queue<string>

Order:

First Added
↓
First Removed

Examples:

Printer jobs
Customer service systems
Task processing

=========================================
STACK<T>
=========================================

Last In First Out (LIFO)

Example:

Stack<string>

Order:

Last Added
↓
First Removed

Examples:

Undo systems
Browser history

=========================================
HASHSET<T>
=========================================

Stores unique values.

Example:

HashSet<int>

Benefits:

• No duplicates
• Fast searching

=========================================
GENERIC CONSTRAINTS
=========================================

Constraints limit which data types can be used.

This improves safety and functionality.

=========================================
WHERE T : CLASS
=========================================

Reference types only.

Example:

where T : class

Allowed:

string
User
Employee

Not allowed:

int
double
bool

=========================================
WHERE T : STRUCT
=========================================

Value types only.

Example:

where T : struct

Allowed:

int
double
bool
DateTime

=========================================
WHERE T : NEW()
=========================================

Requires a parameterless constructor.

Example:

where T : new()

Allows:

T item = new T();

=========================================
WHERE T : BASECLASS
=========================================

Requires inheritance.

Example:

where T : Character

Only Character and derived classes can be used.

=========================================
WHERE T : INTERFACE
=========================================

Requires implementation of an interface.

Example:

where T : IAttackable

Only classes implementing IAttackable are allowed.

=========================================
COMBINING CONSTRAINTS
=========================================

Multiple constraints can be combined.

Example:

where T : Character, new()

Meaning:

• Must inherit Character
• Must have parameterless constructor

=========================================
ADVANTAGES OF GENERICS
=========================================

1. Type Safety

Errors are caught during compilation.

2. Reusable Code

Write once.
Use many times.

3. Better Performance

Avoids boxing and unboxing.

4. Cleaner Code

Less duplication.

5. Easier Maintenance

One implementation for many types.

=========================================
BOXING AND UNBOXING
=========================================

Generics help reduce boxing.

Boxing:

int number = 10;
object data = number;

Unboxing:

int result = (int)data;

Generics eliminate this problem.

Example:

List<int>

No boxing required.

=========================================
REAL-WORLD USES OF GENERICS
=========================================

Generics are used in:

• ASP.NET
• Unity
• Entity Framework
• APIs
• Databases
• Repositories
• Dependency Injection
• Collections
• Enterprise Software

Almost every professional C# application uses Generics.

=========================================
COMMON MISTAKES
=========================================

Mistake #1

Using object instead of Generics.

Bad:

List<object>

Better:

List<string>

-----------------------------------------

Mistake #2

Creating duplicate classes.

Bad:

StudentBox
EmployeeBox
ProductBox

Better:

Box<T>

-----------------------------------------

Mistake #3

Ignoring constraints.

Constraints help prevent invalid types.

=========================================
BEST PRACTICES
=========================================

• Use Generics whenever possible
• Prefer Generic collections
• Use meaningful constraints
• Avoid unnecessary object usage
• Keep Generic designs simple
• Follow .NET naming conventions
• Use type safety to your advantage

=========================================
MODULE SUMMARY
=========================================

In this module, I learned:

• What Generics are
• Why Generics are important
• Generic classes
• Generic methods
• Generic interfaces
• Generic collections
• Type parameters
• Constraints
• Type safety
• Professional usage patterns

Generics help me write reusable, scalable,
and professional C# applications.
*/

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
