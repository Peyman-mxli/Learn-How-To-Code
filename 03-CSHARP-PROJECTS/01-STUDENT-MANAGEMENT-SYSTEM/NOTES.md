# Student Management System — Technical Notes

## Architecture

The project separates three responsibilities:

```text
Program.cs
    ↓
StudentManager.cs
    ↓
Student.cs
```

### Program.cs

Handles the console UI, menu, and safe input parsing.

### StudentManager.cs

Owns the in-memory collection and business operations:

- add;
- search;
- update;
- delete;
- count.

### Student.cs

Represents one student and protects its invariants through validation.

## Important C# concepts

### Nullable reference types

The project enables:

```xml
<Nullable>enable</Nullable>
```

This makes potential `null` values explicit and improves compile-time safety.

### `TryParse` instead of direct conversion

Interactive input should not crash when a user types non-numeric text.

```csharp
if (int.TryParse(raw, out int value))
{
    // safe parsed value
}
```

### Encapsulation

Student properties use private setters where external code should not change state arbitrarily.

Updates go through:

```csharp
student.Update(...)
```

so validation runs before state changes.

### Read-only collection exposure

`StudentManager` stores a mutable internal list but exposes:

```csharp
IReadOnlyList<Student>
```

This prevents callers from directly adding/removing items without the manager's rules.

### LINQ

The project uses `Any`, `FirstOrDefault`, and `Where` for readable collection queries.

## Complexity notes

With the current `List<Student>` implementation:

- add at end: O(1) amortized;
- search by ID: O(n);
- search by name: O(n);
- delete after search: O(n).

A larger system could use a dictionary keyed by Student ID or a database index.

## Next professional extensions

Possible later versions:

- JSON persistence;
- SQLite / SQL Server;
- Entity Framework Core;
- unit tests;
- logging;
- ASP.NET Core Web API;
- authentication/authorization;
- frontend dashboard.

These are extensions, not requirements for the current completed console MVP.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026

