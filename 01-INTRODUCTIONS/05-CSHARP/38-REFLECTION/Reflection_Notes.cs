using System;

/*
=========================================================
REFLECTION NOTES
=========================================================

Reflection is one of the most powerful features in C#.

It allows a program to inspect information about itself
while it is running.

Normally, we know exactly which classes, methods,
properties, and fields our code will use.

Reflection allows us to discover this information
dynamically at runtime.

Many professional frameworks use Reflection behind
the scenes.

Examples:

- ASP.NET
- Entity Framework
- xUnit
- NUnit
- Dependency Injection Containers
- JSON Serializers
- Plugin Systems

=========================================================
WHAT IS REFLECTION?
=========================================================

Reflection is the ability to:

- Inspect classes
- Inspect methods
- Inspect properties
- Inspect fields
- Inspect constructors
- Inspect attributes
- Inspect assemblies

at runtime.

Reflection lives mainly in:

System.Reflection

namespace.

=========================================================
THE TYPE CLASS
=========================================================

Reflection starts with the Type class.

Type represents metadata about a class.

Example:

Type type = typeof(string);

This Type object contains information about String.

Examples of metadata:

- Class Name
- Namespace
- Base Class
- Methods
- Properties
- Fields
- Constructors

=========================================================
OBTAINING A TYPE
=========================================================

Method 1

Type type = typeof(Person);

Used when the type is known.

---------------------------------------------------------

Method 2

Person person = new Person();

Type type = person.GetType();

Used when an object already exists.

---------------------------------------------------------

Method 3

Type type = Type.GetType("System.String");

Used when the type name is stored as text.

=========================================================
GETTING CLASS INFORMATION
=========================================================

Reflection can inspect class metadata.

Example information:

type.Name
type.FullName
type.Namespace
type.BaseType

Example:

Console.WriteLine(type.Name);

Output:

Person

=========================================================
GETTING METHODS
=========================================================

Methods can be discovered dynamically.

Example:

MethodInfo[] methods =
    type.GetMethods();

This returns all methods.

Each MethodInfo contains:

- Name
- Return Type
- Parameters
- Attributes

Example:

foreach (MethodInfo method in methods)
{
    Console.WriteLine(method.Name);
}

=========================================================
GETTING PROPERTIES
=========================================================

Properties can also be inspected.

Example:

PropertyInfo[] properties =
    type.GetProperties();

Each PropertyInfo contains:

- Name
- Type
- Accessibility

Example:

foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
}

=========================================================
GETTING FIELDS
=========================================================

Fields are variables stored inside classes.

Example:

FieldInfo[] fields =
    type.GetFields();

Each FieldInfo contains:

- Name
- Type
- Accessibility

=========================================================
GETTING CONSTRUCTORS
=========================================================

Constructors can be inspected.

Example:

ConstructorInfo[] constructors =
    type.GetConstructors();

Useful when creating objects dynamically.

=========================================================
CREATING OBJECTS DYNAMICALLY
=========================================================

Reflection can create objects at runtime.

Example:

object person =
    Activator.CreateInstance(typeof(Person));

The class can be created without directly calling:

new Person();

This is heavily used by frameworks.

=========================================================
INVOKING METHODS DYNAMICALLY
=========================================================

Methods can be executed dynamically.

Example:

MethodInfo method =
    type.GetMethod("SayHello");

method.Invoke(person, null);

This executes:

person.SayHello();

without directly calling the method.

=========================================================
WORKING WITH PARAMETERS
=========================================================

Methods with parameters can also be invoked.

Example:

method.Invoke(person,
    new object[] { "Peyman" });

The parameter list is passed as an object array.

=========================================================
READING PROPERTY VALUES
=========================================================

Properties can be read dynamically.

Example:

PropertyInfo property =
    type.GetProperty("Name");

object value =
    property.GetValue(person);

=========================================================
WRITING PROPERTY VALUES
=========================================================

Properties can be modified dynamically.

Example:

property.SetValue(person, "Peyman");

Reflection changes the value at runtime.

=========================================================
CUSTOM ATTRIBUTES
=========================================================

Reflection is commonly used with Attributes.

Example:

[Obsolete]
public void OldMethod()
{
}

Reflection can inspect attributes.

Example:

Attribute[] attributes =
    Attribute.GetCustomAttributes(type);

This allows frameworks to discover special behavior.

=========================================================
ASSEMBLIES
=========================================================

An Assembly is a compiled .NET application.

Examples:

MyProgram.exe

MyLibrary.dll

Reflection can inspect assemblies.

Example:

Assembly assembly =
    Assembly.GetExecutingAssembly();

Information available:

- Classes
- Interfaces
- Enums
- Structs
- Attributes

=========================================================
REAL-WORLD USE CASES
=========================================================

1. Dependency Injection

Framework discovers services automatically.

---------------------------------------------------------

2. ORM Frameworks

Entity Framework reads model classes.

---------------------------------------------------------

3. Testing Frameworks

xUnit discovers test methods.

---------------------------------------------------------

4. JSON Serialization

Properties are discovered automatically.

---------------------------------------------------------

5. Plugin Systems

Applications load external DLL files.

---------------------------------------------------------

6. ASP.NET

Controllers and actions are discovered automatically.

=========================================================
ADVANTAGES OF REFLECTION
=========================================================

✓ Dynamic behavior

✓ Runtime inspection

✓ Flexible architectures

✓ Plugin support

✓ Framework development

✓ Automatic discovery

=========================================================
DISADVANTAGES OF REFLECTION
=========================================================

✗ Slower than direct code

✗ More difficult to debug

✗ More complex code

✗ Less compile-time safety

=========================================================
PERFORMANCE CONSIDERATIONS
=========================================================

Reflection is slower because information
must be discovered during execution.

Avoid Reflection inside performance-critical loops.

Use Reflection when flexibility is more important
than speed.

=========================================================
BEST PRACTICES
=========================================================

✓ Use Reflection only when necessary

✓ Cache Reflection results

✓ Prefer direct code when possible

✓ Validate method/property existence

✓ Handle exceptions properly

✓ Avoid excessive Reflection calls

=========================================================
SUMMARY
=========================================================

Reflection allows a C# program to inspect
and interact with itself at runtime.

Key concepts:

- Type
- MethodInfo
- PropertyInfo
- FieldInfo
- ConstructorInfo
- Assembly
- Activator
- Attributes

Reflection is a powerful advanced tool used
throughout the .NET ecosystem and forms the
foundation of many professional frameworks.
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
