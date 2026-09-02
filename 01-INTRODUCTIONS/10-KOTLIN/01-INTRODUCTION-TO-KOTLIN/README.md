# 🟣 01 - Introduction to Kotlin

## Overview

Kotlin is a modern programming language created by JetBrains to make software development simpler, safer, and more productive. It was designed to solve many of the problems developers faced with older languages while remaining practical and easy to learn.

Today, Kotlin is used by millions of developers around the world and is officially recommended by Google for Android development.

In this module, I will discover what Kotlin is, why it was created, where it is used, and how to write and run my very first Kotlin program using IntelliJ IDEA.

---

## What I Will Learn

By completing this module, I will be able to:

* Define what Kotlin is.
* Explain why JetBrains created Kotlin.
* Describe the history of Kotlin.
* Understand why Google adopted Kotlin.
* Identify where Kotlin is used.
* Compare Kotlin with Java.
* Compare Kotlin with C#.
* Write my first Kotlin program.
* Understand each part of a Kotlin program.
* Run Kotlin applications using IntelliJ IDEA.
* Recognize common beginner mistakes.

---

## What Is Kotlin?

Kotlin is a statically typed programming language developed by JetBrains.

It was designed to be:

* Modern
* Concise
* Safe
* Interoperable with Java
* Easy to maintain

Kotlin allows developers to build reliable applications with less code and fewer common errors.

---

## History of Kotlin

* 2011 → JetBrains announced Kotlin.
* 2012 → Kotlin became open source.
* 2016 → Kotlin 1.0 was officially released.
* 2017 → Google announced official support for Kotlin on Android.
* 2019 → Google declared Kotlin the preferred language for Android development.

---

## Why Was Kotlin Created?

JetBrains created Kotlin because developers wanted a language that:

* Reduced boilerplate code.
* Improved readability.
* Prevented common mistakes.
* Worked seamlessly with Java.
* Increased productivity.

Kotlin was designed by developers for developers.

---

## Why Did Google Choose Kotlin?

Before Kotlin, Android applications were primarily written in Java.

Google chose Kotlin because it provides:

* Cleaner syntax.
* Better safety features.
* Less repetitive code.
* Excellent Java interoperability.
* Improved developer productivity.

Today, Kotlin is one of the most important languages in Android development.

---

## Where Is Kotlin Used?

Kotlin is used in many areas of software development.

### Android Development

Building mobile applications.

### Backend Development

Creating APIs and server-side applications.

### Desktop Applications

Developing software for Windows, macOS, and Linux.

### Web Development

Building web applications using Kotlin frameworks.

### Multiplatform Development

Sharing code across Android, iOS, desktop, and web projects.

### Command-Line Applications

Creating utilities and automation tools.

---

## Kotlin vs Java

| Feature          | Kotlin            | Java         |
| ---------------- | ----------------- | ------------ |
| Syntax           | Shorter           | More Verbose |
| Null Safety      | Built-in          | Limited      |
| Boilerplate Code | Less              | More         |
| Interoperability | Excellent         | Native       |
| Learning Curve   | Beginner Friendly | Moderate     |

---

## Kotlin vs C#

| Feature      | Kotlin      | C#                           |
| ------------ | ----------- | ---------------------------- |
| Platform     | JVM         | .NET                         |
| Creator      | JetBrains   | Microsoft                    |
| Syntax Style | Similar     | Similar                      |
| Null Safety  | Built-in    | Nullable Reference Types     |
| Main Use     | Android/JVM | Windows/Web/Game Development |

---

## My First Kotlin Program

```kotlin
fun main() {
    println("Hello, World!")
}
```

---

## Understanding the Program

### fun

Declares a function.

---

### main()

The entry point of the application.

Execution starts here.

---

### println()

Prints text to the console.

---

### "Hello, World!"

The message displayed to the user.

---

## Running the Program

Inside IntelliJ IDEA:

### Method 1

Click:

```text
▶ Run
```

### Method 2

Press:

```text
Shift + F10
```

Expected output:

```text
Hello, World!
```

---

## Common Beginner Mistakes

### Missing Parentheses

Incorrect:

```kotlin
println"Hello"
```

Correct:

```kotlin
println("Hello")
```

---

### Misspelled Function Names

Incorrect:

```kotlin
prntln("Hello")
```

Correct:

```kotlin
println("Hello")
```

---

### Extra Braces

Incorrect:

```kotlin
fun main() {
    println("Hello")
}}
```

Correct:

```kotlin
fun main() {
    println("Hello")
}
```

---

## Difficulty Rank

⭐ Difficulty: 1/5 🌱 Beginner

---

## Study Workflow

1. Read `README.md`.
2. Study `Notes.kt`.
3. Run `Examples.kt`.
4. Read the written exercise brief in `Tasks.md`.
5. Write code in `Tasks.kt`.
6. Compare your work with `Tasks_Solutions.kt`.

`Tasks.md` contains the human-readable exercise instructions, while `Tasks.kt` is the coding workspace. They are intentionally both present.

---

## Checklist

* [ ] I understand what Kotlin is.
* [ ] I know why Kotlin was created.
* [ ] I know why Google chose Kotlin.
* [ ] I know where Kotlin is used.
* [ ] I understand the differences between Kotlin and Java.
* [ ] I understand the differences between Kotlin and C#.
* [ ] I can write my first Kotlin program.
* [ ] I can run Kotlin programs in IntelliJ IDEA.
* [ ] I can identify common beginner mistakes.

---

## Author

**Name:** Peyman Miyandashti

**University:** Polytechnic University of Baja California

**Program:** Information Technology Engineering & Digital Innovation

**Origin:** Iran (Mexico)

**Year:** 2026
