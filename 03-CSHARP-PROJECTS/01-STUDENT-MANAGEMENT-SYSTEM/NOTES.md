# 📚 Student Management System Notes

## ✨ Introduction

These notes explain the most important C# concepts used in the Student Management System project.

The goal is not only to build the project but also to understand why each piece of code exists and how it works.

A professional developer does not simply write code.

A professional developer understands:

* What problem the code solves
* Why the code is needed
* How the code works
* How the code can be improved

---

# 🧠 Project Architecture Overview

This project is separated into multiple files.

Each file has a specific responsibility.

```text
Student Management System
│
├── Program.cs
├── Student.cs
├── StudentManager.cs
├── NOTES.md
├── REQUIREMENTS.md
└── README.md
```

This organization makes the project easier to maintain and understand.

---

# 📄 Program.cs

## Purpose

Program.cs is the starting point of the application.

When the application runs, execution begins inside:

```csharp
Main()
```

Example:

```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine("Student Management System");
    }
}
```

Every C# console application starts from Main().

---

# 📄 Student.cs

## Purpose

The Student class represents a student.

A class is a blueprint.

An object is a real instance created from that blueprint.

Think of a class as a house design.

An actual house built from the design is an object.

---

## Student Example

```csharp
public class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Course { get; set; }

    public double Grade { get; set; }
}
```

This class defines what information every student should have.

---

# 📦 Properties

Properties store data inside a class.

Example:

```csharp
public string FullName { get; set; }
```

This property stores the student's name.

Examples:

```csharp
student.FullName = "John Smith";

Console.WriteLine(student.FullName);
```

Output:

```text
John Smith
```

---

# 🧍 Objects

An object is created from a class.

Example:

```csharp
Student student = new Student();
```

Now a real student object exists in memory.

Assigning values:

```csharp
student.StudentId = 1001;
student.FullName = "John Smith";
student.Age = 20;
```

---

# 📄 StudentManager.cs

## Purpose

The StudentManager class contains the application's business logic.

This file performs operations such as:

* Add Student
* View Students
* Search Student
* Update Student
* Delete Student

Instead of putting everything inside Program.cs, we separate responsibilities.

This makes the project cleaner and easier to maintain.

---

# 📚 Lists

A List is used to store multiple students.

Example:

```csharp
List<Student> students = new List<Student>();
```

This means:

* Store many Student objects
* Dynamically grow when needed
* Easily search and manage data

---

## Add To List

```csharp
students.Add(student);
```

Example:

```csharp
Student student = new Student();

students.Add(student);
```

---

## Count Students

```csharp
students.Count
```

Example:

```csharp
Console.WriteLine(students.Count);
```

Output:

```text
5
```

Meaning there are 5 students inside the list.

---

# 🔁 Loops

Loops allow repetition.

---

## foreach Loop

Used when displaying all students.

Example:

```csharp
foreach(Student student in students)
{
    Console.WriteLine(student.FullName);
}
```

Output:

```text
John
Sarah
Mike
Emily
```

The loop visits every student in the list.

---

# ❓ Conditions

Conditions allow decisions.

Example:

```csharp
if(student.Age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

---

# 🔍 Searching

Searching means locating a student.

Example:

```csharp
foreach(Student student in students)
{
    if(student.StudentId == id)
    {
        Console.WriteLine("Student Found");
    }
}
```

This checks every student until a match is found.

---

# ✏️ Updating Data

Updating means changing existing information.

Example:

Before:

```text
Name: John
```

After:

```text
Name: John Smith
```

Code:

```csharp
student.FullName = "John Smith";
```

---

# 🗑️ Deleting Data

Deleting means removing an object.

Example:

```csharp
students.Remove(student);
```

After removal, the object no longer exists in the list.

---

# 🎛️ Switch Statements

Switch statements are perfect for menus.

Example:

```csharp
switch(choice)
{
    case 1:
        AddStudent();
        break;

    case 2:
        ViewStudents();
        break;

    case 3:
        SearchStudent();
        break;
}
```

This makes menu code cleaner than many if statements.

---

# ⌨️ User Input

Console applications receive input through:

```csharp
Console.ReadLine();
```

Example:

```csharp
string name = Console.ReadLine();
```

User types:

```text
John Smith
```

The value is stored inside the variable.

---

# 🖨️ Output

Output is displayed using:

```csharp
Console.WriteLine();
```

Example:

```csharp
Console.WriteLine("Welcome");
```

Output:

```text
Welcome
```

---

# 🔄 CRUD Operations

CRUD is one of the most important concepts in software development.

CRUD stands for:

| Letter | Meaning |
| ------ | ------- |
| C      | Create  |
| R      | Read    |
| U      | Update  |
| D      | Delete  |

In this project:

| Operation | Feature        |
| --------- | -------------- |
| Create    | Add Student    |
| Read      | View Students  |
| Update    | Update Student |
| Delete    | Delete Student |

Almost every real-world application uses CRUD.

---

# 🏗️ Separation Of Responsibilities

Professional applications separate responsibilities.

Bad approach:

```text
Everything inside Program.cs
```

Good approach:

```text
Program.cs
    ↓
StudentManager.cs
    ↓
Student.cs
```

Benefits:

* Easier maintenance
* Easier debugging
* Cleaner code
* Better scalability

---

# 🚀 Future Improvements

Once the project is working, it can be expanded.

Possible improvements:

* File Storage
* JSON Serialization
* LINQ Searching
* Entity Framework
* SQL Server
* REST API
* ASP.NET Core
* Authentication
* Unit Testing

The same foundation can later become a professional application.

---

# 💡 Final Advice

Do not focus only on making the program work.

Focus on understanding:

* Why classes exist
* Why methods exist
* Why lists are used
* Why responsibilities are separated
* Why clean code matters

The more you understand these concepts, the easier future projects become.

---

## 👤 Author

👤 Author Peyman Miyandashti

📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)

📞 +526865090453

🎓 Polytechnic University of Baja California

💻 Information Technology Engineering & Digital Innovation

📍 From IRAN (Mexico)

📅 Year: 2026

🆔 ID: 250161
