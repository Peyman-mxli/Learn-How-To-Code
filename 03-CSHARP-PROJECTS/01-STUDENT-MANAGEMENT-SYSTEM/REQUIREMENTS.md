# 📋 Student Management System Requirements

## ✨ Introduction

This document defines the requirements for the Student Management System project.

The purpose of this project is to create a simple and organized console application that allows users to manage student information.

The application will be developed using C# and will run inside the console.

This project is intended as a practical learning experience while following professional software development practices.

---

# 🎯 Project Objective

The objective of the Student Management System is to allow users to manage student records through a menu-driven console application.

The system should allow users to:

* Add students
* View students
* Search students
* Update student information
* Delete students
* Exit the application

---

# 👥 User Type

### Administrator

The administrator is the person using the application.

The administrator can:

* Create student records
* View student records
* Search student records
* Modify student records
* Delete student records

---

# 📦 Student Information

Each student record must contain the following information:

| Field      | Description                       |
| ---------- | --------------------------------- |
| Student ID | Unique identifier for the student |
| Full Name  | Student full name                 |
| Age        | Student age                       |
| Email      | Student email address             |
| Course     | Student course name               |
| Grade      | Student final grade               |

---

# ⚙️ Functional Requirements

## FR-01 Add Student

The system shall allow the user to add a new student.

The user must provide:

* Student ID
* Full Name
* Age
* Email
* Course
* Grade

After successful creation, the system shall display a confirmation message.

### Example

```text
Student added successfully.
```

---

## FR-02 View Students

The system shall allow the user to view all registered students.

The information displayed should include:

* Student ID
* Name
* Age
* Email
* Course
* Grade

### Example

```text
ID: 1001
Name: John Smith
Age: 20
Course: C# Programming
Grade: 95
```

---

## FR-03 Search Student

The system shall allow the user to search for a student.

The search may be performed using:

* Student ID
* Student Name

If a student exists, the information shall be displayed.

If no student is found, the system shall display a message.

### Example

```text
Student not found.
```

---

## FR-04 Update Student

The system shall allow the user to update student information.

The user shall first search for the student.

After locating the student, the user may modify:

* Name
* Age
* Email
* Course
* Grade

The Student ID should remain unchanged.

---

## FR-05 Delete Student

The system shall allow the user to remove a student.

The user shall select a student using the Student ID.

The system shall ask for confirmation before deletion.

### Example

```text
Are you sure? (Y/N)
```

---

## FR-06 Exit Program

The system shall allow the user to exit the application safely.

### Example

```text
Thank you for using Student Management System.
```

---

# 🖥️ Menu Requirements

The application shall display a menu similar to:

```text
=================================
 Student Management System
=================================

1. Add Student
2. View Students
3. Search Student
4. Update Student
5. Delete Student
6. Exit

Select an option:
```

---

# 📊 Data Storage Requirements

### Version 1

Student data will be stored in memory using:

```csharp
List<Student>
```

Data will be lost when the program closes.

---

### Future Version

Future versions may store data using:

* Text Files
* JSON Files
* XML Files
* SQL Server
* SQLite
* Entity Framework

---

# 🛡️ Validation Requirements

The system should validate user input whenever possible.

Examples:

### Student ID

* Cannot be empty
* Must be unique

### Name

* Cannot be empty

### Age

* Must be greater than zero

### Email

* Cannot be empty

### Grade

* Must be between 0 and 100

---

# 🚀 Future Enhancements

Future versions of the project may include:

* Login System
* User Roles
* File Storage
* JSON Serialization
* Database Integration
* Reporting System
* ASP.NET Core Version
* REST API Version
* Unit Testing
* Search Filters
* Export to CSV
* Export to PDF

---

# 📚 Technologies Used

The project will use:

* C#
* .NET
* Console Application
* Object-Oriented Programming

---

# ✅ Acceptance Criteria

The project will be considered complete when:

* Users can add students
* Users can view students
* Users can search students
* Users can update students
* Users can delete students
* The menu works correctly
* The program exits correctly
* The code is clean and readable

---

# 🏁 Project Status

Current Status:

```text
Planning Phase
```

Next Step:

```text
Create NOTES.md
```

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
