# Repository Structure

This document reflects the current organization of **Learn-How-To-Code**.

```text
Learn-How-To-Code/
├── .github/
│   └── workflows/
│       └── repository-quality.yml
├── 01-INTRODUCTIONS/
│   ├── 01-VSCODE/
│   ├── 02-PYTHON/
│   ├── 03-GITHUB/
│   ├── 04-EMOJIS/
│   ├── 05-CSHARP/
│   ├── 06-VISUALSTUDIO/
│   ├── 07-DATA-STRUCTURES/
│   ├── 08-ALGORITHMS/
│   ├── 09-INTELLIJ/
│   └── 10-KOTLIN/
├── 02-PROJECTS/
│   ├── 01-CLI-CALCULATOR/
│   ├── 02-TODO-APP/
│   ├── 03-VEHICLE-MANAGEMENT-SYSTEM/
│   ├── 04-UNITRACK/
│   ├── 05-LIBRARY-OOP/
│   ├── 06-VETERINARY-OOP/
│   └── 07-ZOO-OOP/
├── 03-CSHARP-PROJECTS/
│   └── 01-STUDENT-MANAGEMENT-SYSTEM/
│       ├── StudentManagementSystem.csproj
│       ├── Program.cs
│       ├── Student.cs
│       ├── StudentManager.cs
│       ├── StudentManagementSystem.Tests/
│       ├── student-management-system-console.png
│       ├── README.md
│       ├── NOTES.md
│       └── REQUIREMENTS.md
├── .gitignore
├── LICENSE
├── README.md
├── REPOSITORY-STRUCTURE.md
└── SECURITY.md
```

## Naming conventions

- learning/project folders: `NN-TOPIC-NAME`
- Python source: `.py`
- C# source: `.cs`
- Kotlin source: `.kt`
- documentation: `.md`
- diagrams.net source: `.drawio`
- Python dependencies: `requirements.txt`

## Generated files

Do not commit generated/local artifacts such as:

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
.idea/
.vs/
```

## Automated validation

`.github/workflows/repository-quality.yml` runs automated compilation, tests, and repository-hygiene checks on pushes and pull requests.
