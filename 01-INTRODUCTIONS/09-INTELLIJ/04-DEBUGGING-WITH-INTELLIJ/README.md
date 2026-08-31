# Debugging Kotlin with IntelliJ IDEA

This lesson teaches systematic debugging with IntelliJ IDEA. Learners pause a Kotlin program, inspect its state, move through execution, and identify the cause of incorrect behavior.

## Learning objectives

Learners will be able to:

- distinguish running from debugging;
- create, disable, and remove breakpoints;
- start a Debug session;
- inspect variables and expressions;
- use Step Over, Step Into, Step Out, and Resume;
- read the call stack;
- add watches;
- recognize conditional and exception breakpoints;
- correct a logic defect using evidence; and
- terminate or restart a debugging session safely.

## Prerequisites

Complete:

1. [IntelliJ installation](../01-INSTALLATION-AND-SETUP/)
2. [JDK configuration](../02-JDK-INSTALLATION-AND-CONFIGURATION/)
3. [First Kotlin project](../03-FIRST-KOTLIN-PROJECT/)

## Lesson materials

| File | Purpose |
|---|---|
| [Notes.md](./Notes.md) | Debugger concepts, controls, workflow, and troubleshooting |
| [Examples.md](./Examples.md) | Runnable Kotlin debugging scenarios |
| [Tasks.md](./Tasks.md) | Independent breakpoint and diagnosis exercises |
| [Tasks_Solutions.md](./Tasks_Solutions.md) | Expected observations and corrected code |

## Core example

~~~kotlin
fun calculateTotal(price: Int, quantity: Int): Int {
    val subtotal = price * quantity
    val discount = 10
    return subtotal - discount
}

fun main() {
    val total = calculateTotal(price = 25, quantity = 3)
    println("Total: $total")
}
~~~

The learner will pause inside calculateTotal, inspect values, step through the return statement, and confirm the result.

## Completion criteria

- [ ] Breakpoint pauses execution.
- [ ] Variables are inspected.
- [ ] Step Over and Step Into are used correctly.
- [ ] Call stack is identified.
- [ ] A watch expression is evaluated.
- [ ] Program resumes and exits normally.
- [ ] One logic defect is found and corrected.
- [ ] No secrets are exposed in debugger evidence.

## Navigation

- [Previous: First Kotlin project](../03-FIRST-KOTLIN-PROJECT/)
- [IntelliJ IDEA module](../)
- [Kotlin curriculum](../../10-KOTLIN/)

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
