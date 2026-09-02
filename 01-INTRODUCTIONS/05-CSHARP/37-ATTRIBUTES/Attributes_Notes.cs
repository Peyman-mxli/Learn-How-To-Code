```csharp
/*
=========================================
37 - ATTRIBUTES
Attributes_Notes.cs
=========================================
*/

using System;

namespace AttributesNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }
}

/*
==================================================
WHAT ARE ATTRIBUTES?
==================================================

Attributes are special pieces of information
that can be attached to code elements.

Attributes provide metadata.

Metadata means:

"Data about data"

Attributes allow me to describe additional
information about classes, methods,
properties, fields, parameters, and more.

==================================================
WHAT IS METADATA?
==================================================

Metadata is information that describes
something else.

Examples:

A book:

- Title
- Author
- ISBN
- Publication Date

These describe the book.

They are metadata.

In programming:

Attributes describe code.

==================================================
ATTRIBUTE SYNTAX
==================================================

Attributes are written inside square brackets.

Example:

[Obsolete]

class OldCalculator
{
}

The square brackets tell C# that an
attribute is being applied.

==================================================
BUILT-IN ATTRIBUTES
==================================================

C# provides many built-in attributes.

Examples:

[Obsolete]

[Serializable]

[Conditional]

[Flags]

[AttributeUsage]

These are included in .NET.

==================================================
OBSOLETE ATTRIBUTE
==================================================

The Obsolete attribute marks code
that should no longer be used.

Example:

[Obsolete]
public void OldMethod()
{
}

The compiler will show a warning.

==================================================
OBSOLETE WITH MESSAGE
==================================================

Example:

[Obsolete("Use NewMethod instead.")]
public void OldMethod()
{
}

The compiler displays:

Use NewMethod instead.

==================================================
OBSOLETE WITH ERROR
==================================================

Example:

[Obsolete("Method removed.", true)]
public void OldMethod()
{
}

Now the compiler generates an error.

The method cannot be used.

==================================================
SERIALIZABLE ATTRIBUTE
==================================================

Example:

[Serializable]
class PlayerData
{
}

Serializable indicates that an object
can be converted into a storable format.

Examples:

- File
- Database
- Network Transfer

==================================================
CONDITIONAL ATTRIBUTE
==================================================

Example:

[Conditional("DEBUG")]
public static void Log()
{
}

The method runs only when DEBUG mode
is enabled.

Useful for:

- Debugging
- Logging
- Diagnostics

==================================================
FLAGS ATTRIBUTE
==================================================

Flags is commonly used with enums.

Example:

[Flags]
enum Permissions
{
    Read = 1,
    Write = 2,
    Delete = 4
}

Multiple values can be combined.

==================================================
WHERE ATTRIBUTES CAN BE USED
==================================================

Attributes can be applied to:

✓ Classes

✓ Methods

✓ Properties

✓ Fields

✓ Parameters

✓ Enums

✓ Assemblies

✓ Structs

✓ Interfaces

==================================================
CLASS ATTRIBUTE EXAMPLE
==================================================

[Serializable]
class Character
{
}

The attribute applies to the entire class.

==================================================
METHOD ATTRIBUTE EXAMPLE
==================================================

[Obsolete]
public void OldAttack()
{
}

The attribute applies to the method.

==================================================
PROPERTY ATTRIBUTE EXAMPLE
==================================================

public class User
{
    [Obsolete]
    public string OldUsername
    {
        get;
        set;
    }
}

The attribute applies only to the property.

==================================================
CUSTOM ATTRIBUTES
==================================================

I can create my own attributes.

All custom attributes inherit from:

Attribute

Example:

class DeveloperAttribute : Attribute
{
}

==================================================
CREATING A CUSTOM ATTRIBUTE
==================================================

Example:

public class AuthorAttribute : Attribute
{
    public string Name;

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

Usage:

[Author("Peyman")]
class Project
{
}

==================================================
ATTRIBUTE NAMING RULE
==================================================

The class name usually ends with:

Attribute

Example:

AuthorAttribute

However:

Usage can omit Attribute.

Example:

[Author("Peyman")]

instead of

[AuthorAttribute("Peyman")]

==================================================
ATTRIBUTE PARAMETERS
==================================================

Attributes can accept values.

Example:

[Author("Peyman")]

------------------------------------------

Multiple values:

[Author("Peyman", Version = "1.0")]

==================================================
NAMED PARAMETERS
==================================================

Example:

public class AuthorAttribute : Attribute
{
    public string Name;

    public string Version
    {
        get;
        set;
    }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

Usage:

[Author("Peyman", Version = "1.0")]

==================================================
ATTRIBUTEUSAGE ATTRIBUTE
==================================================

AttributeUsage controls where an
attribute can be applied.

Example:

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
}

Now it can only be used on classes.

==================================================
COMMON ATTRIBUTE TARGETS
==================================================

AttributeTargets.Class

AttributeTargets.Method

AttributeTargets.Property

AttributeTargets.Field

AttributeTargets.Parameter

AttributeTargets.Enum

AttributeTargets.All

==================================================
MULTIPLE TARGETS
==================================================

Example:

[AttributeUsage
(
    AttributeTargets.Class |
    AttributeTargets.Method
)]

The attribute can be applied to both.

==================================================
REFLECTION
==================================================

Reflection allows a program to inspect
itself at runtime.

Reflection can read attributes.

Example:

Type type = typeof(Project);

object[] attributes =
    type.GetCustomAttributes(true);

==================================================
WHY REFLECTION IS IMPORTANT
==================================================

Many frameworks use reflection to
discover attributes.

Examples:

ASP.NET

Entity Framework

xUnit

NUnit

JSON Libraries

ORM Frameworks

Dependency Injection Systems

==================================================
REAL-WORLD USES
==================================================

1. Validation

[Required]

------------------------------------------

2. Database Mapping

[Table]

[Column]

------------------------------------------

3. APIs

[HttpGet]

[HttpPost]

------------------------------------------

4. Testing

[Test]

------------------------------------------

5. Serialization

[JsonPropertyName]

==================================================
ADVANTAGES OF ATTRIBUTES
==================================================

1. Add metadata

2. Cleaner code

3. Framework integration

4. Flexible design

5. Reusable information

6. Better documentation

==================================================
DISADVANTAGES OF ATTRIBUTES
==================================================

1. Reflection can be slower

2. Too many attributes can clutter code

3. Hidden behavior may confuse beginners

==================================================
BEST PRACTICES
==================================================

✓ Use meaningful attribute names

✓ Keep attributes simple

✓ Use AttributeUsage

✓ Document custom attributes

✓ Avoid unnecessary metadata

✓ Use attributes only when helpful

==================================================
SUMMARY
==================================================

Attributes provide metadata.

Metadata means:

Information about code.

Attributes use:

[AttributeName]

C# includes many built-in attributes.

Developers can create custom attributes
by inheriting from Attribute.

Reflection can read attributes at runtime.

Attributes are heavily used throughout
modern .NET development and frameworks.
*/

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
