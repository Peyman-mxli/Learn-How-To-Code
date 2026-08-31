# Debugging with IntelliJ IDEA — Tasks

## Rank 1 — Concepts

### Task 1

Explain the difference between Run and Debug.

### Task 2

Define breakpoint, stack frame, call stack, watch, and suspended state.

### Task 3

Match each action with its purpose:

- Step Over
- Step Into
- Step Out
- Resume
- Stop

## Rank 2 — First session

### Task 4

Use:

~~~kotlin
fun multiply(first: Int, second: Int): Int {
    val result = first * second
    return result
}

fun main() {
    val answer = multiply(7, 6)
    println("Answer: $answer")
}
~~~

Set a breakpoint inside multiply, start Debug, and record first, second, result, answer, and output.

### Task 5

Disable the breakpoint, rerun Debug, and explain what changes. Re-enable it afterward.

### Task 6

Remove the breakpoint and recreate it on an executable line.

## Rank 3 — Navigation

### Task 7

Pause on the call to multiply, Step Into the function, Step Over the calculation, then Step Out.

### Task 8

Identify main and multiply in the call stack. Select each frame and observe variable scope.

### Task 9

Add watches for:

~~~kotlin
first * second
result == 42
~~~

Record the values.

## Rank 4 — Find a defect

### Task 10

Debug:

~~~kotlin
fun calculateFinalPrice(price: Int, discount: Int): Int {
    return price + discount
}

fun main() {
    val finalPrice = calculateFinalPrice(100, 15)
    println("Final price: $finalPrice")
}
~~~

Expected final price: 85.

Identify the first incorrect operation, correct it, and verify the output.

### Task 11

Create a conditional breakpoint that pauses only when number equals 7:

~~~kotlin
fun main() {
    var total = 0
    for (number in 1..10) {
        total += number
    }
    println(total)
}
~~~

Record total before and after the addition.

### Task 12

Use Evaluate Expression on one side-effect-free arithmetic or Boolean expression.

## Rank 5 — Professional workflow

### Task 13

Write a debugging report containing expected behavior, actual behavior, reproduction, breakpoint, observed state, root cause, correction, and verification.

### Task 14

Explain why debugger screenshots can be unsafe.

### Task 15

Provide a diagnostic checklist for an ignored breakpoint.

### Task 16

Explain when a conditional breakpoint is better than adding print statements.

## Final checklist

- [ ] Debug started.
- [ ] Breakpoint paused execution.
- [ ] Variables inspected.
- [ ] Step Over used.
- [ ] Step Into used.
- [ ] Step Out used.
- [ ] Resume used.
- [ ] Call stack inspected.
- [ ] Watch evaluated.
- [ ] Conditional breakpoint tested.
- [ ] Logic defect fixed.
- [ ] No secrets exposed.

## Navigation

- [Overview](./README.md)
- [Examples](./Examples.md)
- [Solutions](./Tasks_Solutions.md)
