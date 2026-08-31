# Debugging with IntelliJ IDEA — Reference Solutions

## Task 1

Run executes normally. Debug attaches debugging capabilities and can suspend execution at breakpoints.

## Task 2

- Breakpoint: configured pause location or condition.
- Stack frame: one active function-call context.
- Call stack: ordered active calls leading to the current location.
- Watch: expression evaluated while paused.
- Suspended state: program paused under debugger control.

## Task 3

- Step Over: execute current line without entering its called function.
- Step Into: enter the called function.
- Step Out: finish the current function and return to its caller.
- Resume: continue to the next pause or completion.
- Stop: terminate the process.

## Task 4

Expected:

| Value | Result |
|---|---:|
| first | 7 |
| second | 6 |
| result | 42 |
| answer | 42 |
| output | Answer: 42 |

## Tasks 5–6

A disabled breakpoint remains configured but does not pause execution. A removed breakpoint no longer exists. Recreate it by clicking the gutter beside executable code.

## Task 7

Step Into enters multiply, Step Over evaluates multiplication, and Step Out returns to main.

## Task 8

Inside multiply, the call stack contains multiply above main. Selecting multiply shows its parameters and locals. Selecting main shows main's scope.

## Task 9

Expected watches:

~~~text
first * second = 42
result == 42 = true
~~~

The second watch is meaningful only after result has been assigned.

## Task 10

The code adds the discount instead of subtracting it.

Corrected:

~~~kotlin
fun calculateFinalPrice(price: Int, discount: Int): Int {
    return price - discount
}
~~~

Expected output:

~~~text
Final price: 85
~~~

## Task 11

When number is 7, total is 21 before the addition and 28 after Step Over.

## Task 12

A valid example is price - discount or result == 42. It should not intentionally change program state.

## Task 13

A complete report separates expected and actual behavior, provides reproducible steps, records relevant state, identifies the first incorrect operation, documents one focused correction, and verifies the outcome.

## Task 14

Variables, arguments, environment values, paths, and responses can contain credentials or personal data. Share only sanitized, necessary evidence.

## Task 15

Check Debug mode, selected configuration, enabled breakpoint, executable line, reachable path, saved source, successful build, and source-to-binary alignment.

## Task 16

Conditional breakpoints are useful when a failure occurs only for a specific iteration or state. They avoid source edits and excessive console output.

## Final outcome

The learner should be able to pause, inspect, navigate, identify a root cause, fix it, and verify the correction without exposing sensitive information.

## Navigation

- [Overview](./README.md)
- [Tasks](./Tasks.md)
- [Previous lesson](../03-FIRST-KOTLIN-PROJECT/)
