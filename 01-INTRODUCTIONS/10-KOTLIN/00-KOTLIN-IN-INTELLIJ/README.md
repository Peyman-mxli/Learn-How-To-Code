# 00 — Kotlin in IntelliJ IDEA

## Overview

This module prepares the development environment before the Kotlin language modules begin.

## Learning goals

- create a Kotlin/JVM project in IntelliJ IDEA;
- understand the JDK, JVM, Kotlin compiler, and Gradle at a beginner level;
- recognize source folders and build configuration;
- run and debug Kotlin programs;
- use consistent Kotlin naming conventions.

## Typical Kotlin/JVM project

```text
MyKotlinProject/
├── build.gradle.kts
├── settings.gradle.kts
└── src/
    └── main/
        └── kotlin/
            └── Main.kt
```

## Execution model

```text
Kotlin source (.kt)
        ↓
Kotlin compiler
        ↓
JVM bytecode (.class)
        ↓
JVM
        ↓
Program output
```

## Useful IntelliJ actions

| Action | Common shortcut |
|---|---|
| Run | Shift + F10 |
| Debug | Shift + F9 |
| Search Everywhere | Double Shift |
| Rename | Shift + F6 |
| Format Code | Ctrl + Alt + L |

Shortcuts can vary by operating system and keymap.

## Module files

Study in this order:

1. `README.md`
2. `Notes.kt`
3. `Examples.kt`
4. `Tasks.kt`
5. `Tasks_Solutions.kt`

## Checklist

- [ ] I can create a Kotlin/JVM project.
- [ ] I know where Kotlin source files belong.
- [ ] I can select a JDK.
- [ ] I can run and debug a Kotlin program.
- [ ] I understand the basic compile/run flow.

## Next module

Continue to [01 — Introduction to Kotlin](../01-INTRODUCTION-TO-KOTLIN/).

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
