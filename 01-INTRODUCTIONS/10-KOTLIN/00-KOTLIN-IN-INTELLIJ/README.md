# 🟣 00 - Kotlin in IntelliJ

## Overview

Before learning Kotlin syntax, it is important to understand how Kotlin development works inside IntelliJ IDEA. Many beginners jump directly into writing code without understanding how projects are created, how files are organized, or what happens when they press the Run button.

This module bridges that gap.

In this section, I will learn how to create Kotlin projects using IntelliJ IDEA, organize files professionally, understand the project structure, follow naming conventions, run Kotlin programs, and think like a real Kotlin developer.

By the end of this module, I will be able to confidently navigate IntelliJ and prepare Kotlin projects correctly before writing more advanced code.

---

## What I Will Learn

By completing this module, I will be able to:

* Create Kotlin projects using IntelliJ IDEA.
* Understand the Kotlin project creation wizard.
* Choose appropriate project names.
* Organize Kotlin projects professionally.
* Understand the purpose of the `src` folder.
* Create Kotlin files and Kotlin classes.
* Follow Kotlin naming conventions.
* Run Kotlin programs.
* Use IntelliJ shortcuts for Kotlin development.
* Understand what happens behind the scenes when Kotlin code executes.
* Interpret IntelliJ warnings and errors.
* Develop good habits used by professional developers.

---

## Why Learn Kotlin in IntelliJ First?

Many programming courses immediately start with:

```kotlin id="wq9syj"
fun main() {
    println("Hello, World!")
}
```

However, beginners often wonder:

* Where do I write this code?
* How do I create the file?
* What type of project should I select?
* Why is IntelliJ showing errors?
* What does the Run button actually do?

This module answers those questions first.

Understanding the environment makes learning Kotlin much easier.

---

## Creating a Kotlin Project

Inside IntelliJ IDEA, creating a Kotlin project generally follows these steps:

1. Open IntelliJ IDEA.
2. Click **New Project**.
3. Select **Kotlin**.
4. Choose the appropriate build system.
5. Enter a project name.
6. Select the project location.
7. Click **Create**.

Once the project is created, IntelliJ prepares everything needed for Kotlin development.

---

## Understanding the Project Structure

A typical Kotlin project may look like this:

```text id="jlwm8g"
MyKotlinProject
│
├── .idea
├── src
├── build.gradle.kts
└── External Libraries
```

### .idea

Stores IntelliJ project settings.

---

### src

Contains Kotlin source code.

This is where most of your programming work happens.

---

### build.gradle.kts

Contains project configuration information.

It defines dependencies and build settings.

---

### External Libraries

Contains Kotlin libraries and SDK components required by the project.

---

## Naming Conventions

Professional developers follow naming standards.

### Project Names

Use descriptive names.

Good examples:

```text id="4jv83q"
StudentManagementSystem
WeatherApp
ExpenseTracker
```

Avoid:

```text id="ojpwx5"
test
newproject
asdf
myapp123
```

---

### Kotlin Files

Use PascalCase.

Examples:

```text id="z12x4r"
HelloWorld.kt
Student.kt
Calculator.kt
```

---

### Variables

Use camelCase.

Examples:

```kotlin id="f30o6x"
firstName
studentAge
totalPrice
```

---

### Classes

Use PascalCase.

Examples:

```kotlin id="o3g7hv"
Student
BankAccount
ShoppingCart
```

---

## Kotlin File vs Kotlin Class

### Kotlin File

Usually contains:

* Functions
* Variables
* Small programs

Example:

```text id="tpjlwm"
Utilities.kt
```

---

### Kotlin Class

Usually represents objects.

Example:

```text id="hklz24"
Student.kt
```

Classes become important later when learning object-oriented programming.

---

## Running Kotlin Programs

There are two common ways to run Kotlin programs.

### Method 1: Run Button

Click the green button:

```text id="bh41ow"
▶ Run
```

---

### Method 2: Keyboard Shortcut

Press:

```text id="wz2d8x"
Shift + F10
```

---

## What Happens When You Press Run?

Many beginners think IntelliJ simply "executes" Kotlin code.

The actual process is:

```text id="y27rzk"
Kotlin Code (.kt)
        ↓
Kotlin Compiler
        ↓
JVM Bytecode (.class)
        ↓
Java Virtual Machine (JVM)
        ↓
Program Output
```

Understanding this process helps explain many IntelliJ messages and errors.

---

## Understanding IntelliJ Messages

### Red Errors

Usually indicate that the code cannot compile.

Example causes:

* Missing brackets.
* Misspelled keywords.
* Missing imports.

---

### Yellow Warnings

The code may work, but IntelliJ recommends improvements.

Warnings help improve code quality.

---

### Blue Suggestions

IntelliJ often suggests shortcuts or optimizations.

These recommendations help developers become more productive.

---

## Useful Shortcuts

| Action            | Shortcut       |
| ----------------- | -------------- |
| Run Program       | Shift + F10    |
| Debug Program     | Shift + F9     |
| Search Everywhere | Double Shift   |
| Rename Safely     | Shift + F6     |
| Format Code       | Ctrl + Alt + L |

Learning shortcuts early saves a tremendous amount of time.

---

## Professional Habits

Good Kotlin developers:

* Use meaningful names.
* Keep projects organized.
* Commit changes regularly.
* Read IntelliJ suggestions.
* Fix warnings early.
* Avoid rushing into coding without planning.

These habits are often more valuable than syntax knowledge alone.

---

## Difficulty Rank

⭐ Difficulty: 1/5 🌱 Beginner

This module focuses on understanding the development environment and workflow rather than complex programming concepts.

---

## Study Workflow

Recommended order:

1. Read this README.
2. Study Notes.md.
3. Explore Examples.kt.
4. Complete Tasks.md.
5. Review Tasks_Solutions.md.
6. Create your own Kotlin project.

---

## Checklist

* [ ] I can create a Kotlin project.
* [ ] I understand the project structure.
* [ ] I know where Kotlin files belong.
* [ ] I understand naming conventions.
* [ ] I can run Kotlin programs.
* [ ] I understand what happens when I press Run.
* [ ] I recognize IntelliJ warnings and errors.
* [ ] I am ready to begin writing Kotlin code.

---

## Next Module

➡️ 01-INTRODUCTION-TO-KOTLIN

After learning how Kotlin works inside IntelliJ IDEA, I will begin learning the Kotlin language itself and write my first Kotlin programs.
---
## Final Thoughts

Programming is not only about writing code.

It is also about understanding the tools, organizing projects correctly, and developing professional habits.

Learning Kotlin through IntelliJ IDEA prepares me to build software the same way professional developers do every day.
---

## Author

**Name:** Peyman Miyandashti

**University:** Polytechnic University of Baja California

**Program:** Information Technology Engineering & Digital Innovation

**Origin:** Iran (Mexico)

**Year:** 2026

---


