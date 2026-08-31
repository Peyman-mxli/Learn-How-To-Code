# Debugging with IntelliJ IDEA — Notes

## 1. What is debugging?

Debugging is the process of observing program execution, identifying the cause of incorrect behavior, and validating a correction.

A debugger allows the developer to pause a running program and inspect its state.

Debugging is different from guessing. A professional workflow collects evidence before changing code.

## 2. Run versus Debug

### Run

Run executes the program normally. It is appropriate when testing completed behavior or checking output.

### Debug

Debug attaches debugging tools that can pause execution at breakpoints, display variables, evaluate expressions, and move through code.

A program started with Run will not normally stop at standard debugger breakpoints.

## 3. Breakpoints

A line breakpoint requests that the debugger pause before executing a selected line.

To create one:

1. open the Kotlin file;
2. click the gutter beside an executable line; and
3. confirm that the breakpoint marker appears.

A breakpoint must be placed on executable code. Blank lines, comments, and some declarations cannot stop execution.

### Disable versus remove

- Disable keeps the breakpoint configured but inactive.
- Remove deletes the breakpoint.

This distinction is useful when temporarily testing a path without losing breakpoint settings.

## 4. Start Debug

Use:

- the Debug icon beside main;
- right-click and choose **Debug**;
- select a run configuration and use the toolbar Debug action; or
- use the current keymap shortcut.

A common Windows keymap uses:

~~~text
Shift + F9
~~~

Shortcuts vary by operating system and keymap.

## 5. Debug tool window

When execution pauses, IntelliJ can display:

- **Frames** or the call stack;
- **Variables** in the selected frame;
- **Watches**;
- console output;
- threads;
- execution controls; and
- the currently paused source line.

Exact layout varies by IntelliJ version.

## 6. Variables

The Variables panel shows values available in the current scope.

Inspect:

- function parameters;
- local variables;
- object properties;
- collection contents; and
- nullability state.

A variable not yet assigned may not appear with its final value because its assignment line has not executed.

## 7. Step controls

### Step Over

Executes the current line and pauses on the next line in the same general frame. If the line calls a function, the debugger runs that function without entering its body.

Common Windows keymap:

~~~text
F8
~~~

### Step Into

Enters the function called on the current line so its internal statements can be inspected.

Common Windows keymap:

~~~text
F7
~~~

### Step Out

Finishes the current function and returns to its caller.

Common Windows keymap:

~~~text
Shift + F8
~~~

### Resume

Continues execution until the next breakpoint, exception pause, or program completion.

Common Windows keymap:

~~~text
F9
~~~

### Stop

Terminates the current process. Stopping is not the same as allowing the program to complete normally.

## 8. Call stack

The call stack shows the chain of function calls leading to the current point.

Example:

~~~text
main
└── calculateTotal
~~~

Selecting a frame changes the scope displayed in Variables. This helps determine which function called the current function and with what state.

## 9. Watches

A watch evaluates an expression whenever execution pauses.

Examples:

~~~kotlin
price * quantity
subtotal - discount
quantity > 0
~~~

Use watches for relevant expressions. Avoid evaluating expressions with side effects unless their impact is understood.

## 10. Evaluate Expression

Evaluate Expression computes a selected expression in the paused context.

It is useful for:

- testing a possible condition;
- inspecting a transformation;
- checking a method result; and
- validating a hypothesis.

Do not call destructive or state-changing functions casually while debugging.

## 11. Conditional breakpoints

A conditional breakpoint pauses only when a condition is true.

Example condition:

~~~kotlin
number == 7
~~~

This is useful inside loops where stopping on every iteration would be inefficient.

The condition should be valid in the breakpoint's scope.

## 12. Exception breakpoints

An exception breakpoint can pause when a selected exception is thrown. This helps locate the original failure before it is caught or transformed.

Configuration varies by IntelliJ version. Use the breakpoint-management dialog and select the relevant exception type.

## 13. Logging breakpoints

Some IntelliJ configurations allow a breakpoint to log a message without suspending execution. This can provide temporary diagnostic information without adding print statements to source.

Review breakpoint properties carefully to confirm whether execution will suspend.

## 14. Inline values

While paused, IntelliJ can display values beside source statements. Treat these as snapshots of the current suspended state, not permanent annotations.

## 15. Systematic workflow

1. Reproduce the incorrect behavior.
2. State the expected and actual results.
3. Identify the smallest suspicious code area.
4. Place a breakpoint before the state becomes incorrect.
5. Start Debug with the correct configuration.
6. Inspect parameters and locals.
7. Step through one decision at a time.
8. Compare state with expectations.
9. Identify the first incorrect value or branch.
10. Stop or complete the session.
11. make one focused correction;
12. rerun normally;
13. rerun relevant tests; and
14. remove obsolete diagnostic breakpoints.

## 16. Debugging loops

For long loops:

- use a conditional breakpoint;
- watch the index and relevant accumulator;
- avoid stopping on every iteration;
- inspect boundary cases;
- verify loop termination; and
- check whether a collection changes during iteration.

## 17. Debugging functions

When a function returns the wrong result:

- inspect incoming parameters;
- step through intermediate variables;
- inspect branches;
- verify the return expression;
- Step Out to inspect the result in the caller; and
- confirm the caller uses the result correctly.

## 18. Privacy and security

Debugger state can expose:

- passwords;
- tokens;
- environment variables;
- file paths;
- personal data;
- database records; and
- network responses.

Do not publish screenshots or logs containing sensitive values. Redact only in shared evidence; do not falsify the technical result.

## 19. Common problems

### Breakpoint is ignored

Check:

- the program started with Debug;
- the correct run configuration is active;
- the breakpoint is enabled;
- the line is executable;
- the code path reaches that line;
- source matches the compiled code; and
- the latest build succeeded.

### Variables are unavailable

The wrong stack frame may be selected, the variable may be out of scope, or assignment may not have executed.

### Step Into enters library code

Use Smart Step Into or Step Over when only application code matters. Debugger filters can affect navigation.

### Debugger shows old code

Save changes, rebuild if needed, confirm the correct source and configuration, and restart the session.

### Program waits for input

Check the console for an input request. Provide input in the appropriate Run or Debug console.

### Debug session will not terminate

Use Stop, wait briefly for cleanup, and investigate background processes only if necessary.

## 20. Verification record

| Field | Result |
|---|---|
| Breakpoint file and purpose | |
| Function inspected | |
| Parameters observed | |
| Incorrect value found | |
| Root cause | |
| Correction | |
| Expected output | |
| Actual output after fix | |
| Exit code | |

Do not record secrets or private data.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
