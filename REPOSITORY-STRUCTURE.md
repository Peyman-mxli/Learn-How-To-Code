# Repository Structure

This file documents the current top-level organization of **Learn-How-To-Code**.

## Top level

```text
Learn-How-To-Code/
├── 01-INTRODUCTIONS/
├── 02-PROJECTS/
├── 03-CSHARP-PROJECTS/
├── LICENSE
├── README.md
└── REPOSITORY-STRUCTURE.md
```

## 01-INTRODUCTIONS

```text
01-INTRODUCTIONS/
├── 01-VSCODE/
├── 02-PYTHON/
│   ├── INSTALLING-PYTHON.md
│   ├── JUPYTER-INSTALLATION.md
│   ├── PYTHON-ENVIRONMENT.md
│   ├── VIRTUAL-ENVIRONMENTS/
│   └── MODULES/
├── 03-GITHUB/
├── 04-EMOJIS/
├── 05-CSHARP/
├── 06-VISUALSTUDIO/
├── 07-DATA-STRUCTURES/
├── 08-ALGORITHMS/
├── 09-INTELLIJ/
└── 10-KOTLIN/
```

### Python

The Python path includes setup, virtual environments, variables, syntax, modules, control flow, functions, types/objects, exception handling, file handling, collections, OOP, and testing/debugging.

### C#

The C# path contains a broad curriculum from fundamentals through advanced .NET/software-engineering topics.

### Data Structures

Current dedicated structures include:

- arrays and lists;
- queues;
- stacks;
- trees;
- dictionaries;
- linked lists;
- hash sets;
- heaps and priority queues;
- graphs.

### Algorithms

Current algorithm modules include:

- searching;
- sorting;
- Big-O complexity;
- recursion;
- two pointers;
- sliding window;
- greedy algorithms;
- graph algorithms;
- dynamic programming.

### Kotlin

The Kotlin track now runs from IntelliJ setup and language introduction through variables, operators, I/O, control flow, functions, null safety, collections, OOP, data classes, exceptions, files, projects, and next steps.

## 02-PROJECTS

```text
02-PROJECTS/
├── 01-CLI-CALCULATOR/
├── 02-TODO-APP/
├── 03-VEHICLE-MANAGEMENT-SYSTEM/
├── 04-UNITRACK/
├── 05-LIBRARY-OOP/
├── 06-VETERINARY-OOP/
└── 07-ZOO-OOP/
```

These projects apply Python, OOP, Flask, persistence, validation, and software-organization concepts.

## 03-CSHARP-PROJECTS

```text
03-CSHARP-PROJECTS/
└── 01-STUDENT-MANAGEMENT-SYSTEM/
    ├── StudentManagementSystem.csproj
    ├── Program.cs
    ├── Student.cs
    ├── StudentManager.cs
    ├── README.md
    ├── NOTES.md
    └── REQUIREMENTS.md
```

The first C# project is a complete buildable .NET 8 console CRUD application.

## Naming guidance

New folders should use clear, stable names such as:

```text
NN-TOPIC-NAME
NN-PROJECT-NAME
```

Executable source files should use conventional extensions:

- Python: `.py`
- C#: `.cs`
- Kotlin: `.kt`
- documentation: `.md`
- Python dependencies: `requirements.txt`

## Generated files

Do not commit:

```text
__pycache__/
*.pyc
.venv/
venv/
bin/
obj/
.env
*.db
*.sqlite
*.sqlite3
```

unless a specific educational artifact intentionally requires otherwise.
