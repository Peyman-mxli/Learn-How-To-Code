/*
=========================================
DEBUGGING NOTES
=========================================

In this module, I learn about Debugging in C#.

Debugging is the process of finding, understanding,
and fixing problems (bugs) in a program.

Every software developer encounters bugs.
The difference between a beginner and a professional
developer is often how efficiently they can find and
fix those bugs.

Debugging helps me understand what my program is
doing while it is running.

=========================================
WHAT IS A BUG?
=========================================

A bug is an error, flaw, or mistake in a program.

Examples:

- Incorrect calculations
- Crashes
- Unexpected output
- Infinite loops
- Wrong data stored
- Incorrect conditions

Example:

Expected:
5 + 5 = 10

Actual:
5 + 5 = 55

This is a bug.

=========================================
TYPES OF BUGS
=========================================

1. Syntax Errors

Syntax errors happen when code violates
the rules of C#.

Example:

int number = ;

Visual Studio usually detects these immediately.

-----------------------------------------

2. Runtime Errors

Runtime errors happen while the program
is running.

Example:

DivideByZeroException

int result = 10 / 0;

The application compiles successfully
but crashes during execution.

-----------------------------------------

3. Logical Errors

Logical errors occur when the program runs
without crashing but produces incorrect results.

Example:

int total = 5 * 5;

Expected:
10

Actual:
25

The code executes correctly from the compiler's
perspective but the logic is wrong.

=========================================
WHAT IS DEBUGGING?
=========================================

Debugging means investigating code while it runs.

Instead of guessing where a problem exists,
I can inspect the program step by step.

Questions debugging helps answer:

- What value does a variable contain?
- Did this method execute?
- Which condition was true?
- Which loop iteration caused the problem?
- Where did the exception occur?

=========================================
BREAKPOINTS
=========================================

A breakpoint tells Visual Studio to pause
program execution at a specific line.

Benefits:

- Inspect variables
- Check conditions
- Analyze execution flow
- Investigate errors

How to create a breakpoint:

1. Open a code file.
2. Click the left margin.
3. A red dot appears.
4. Run the application.

When execution reaches the breakpoint,
the program pauses.

Shortcut:

F9

Toggle breakpoint on/off.

=========================================
START DEBUGGING
=========================================

Shortcut:

F5

Starts debugging.

Visual Studio launches the program and
stops when it reaches a breakpoint.

=========================================
STEP OVER
=========================================

Shortcut:

F10

Executes the current line and moves to
the next line.

If the line contains a method call,
Visual Studio executes the method without
showing internal details.

Example:

CalculateTotal();

F10 executes the method immediately.

=========================================
STEP INTO
=========================================

Shortcut:

F11

Enters a method and allows me to inspect
every line inside it.

Example:

CalculateTotal();

Pressing F11 enters the method.

Useful when investigating problems inside
specific methods.

=========================================
STEP OUT
=========================================

Shortcut:

Shift + F11

Finishes the current method and returns
to the caller.

Useful when I accidentally enter a method
I do not need to inspect.

=========================================
CONTINUE EXECUTION
=========================================

Shortcut:

F5

After stopping at a breakpoint,
F5 resumes execution until the next
breakpoint or program completion.

=========================================
WATCH WINDOW
=========================================

The Watch Window allows me to monitor
variables during debugging.

Example:

name
age
total

I can see values changing while the
application runs.

Benefits:

- Track variables
- Monitor expressions
- Verify calculations

=========================================
LOCALS WINDOW
=========================================

The Locals Window automatically displays
variables available in the current scope.

Benefits:

- No manual setup
- Quick inspection
- Useful for troubleshooting

=========================================
CALL STACK
=========================================

The Call Stack shows how execution reached
the current location.

Example:

Main()
   ↓
LoginUser()
   ↓
ValidatePassword()

Current position:
ValidatePassword()

Call Stack reveals the execution path.

Benefits:

- Understand execution flow
- Trace errors
- Find method relationships

=========================================
EXCEPTION DEBUGGING
=========================================

When exceptions occur, Visual Studio
shows detailed information.

Example:

System.DivideByZeroException

This information helps identify:

- Error type
- Error location
- Error cause

=========================================
CONDITIONAL BREAKPOINTS
=========================================

A conditional breakpoint pauses execution
only when a condition becomes true.

Example:

i == 100

Instead of stopping 100 times,
Visual Studio stops only when
i equals 100.

Useful for large loops.

=========================================
DEBUGGING LOOPS
=========================================

Loops often contain bugs.

Common problems:

- Infinite loops
- Wrong conditions
- Incorrect counters

Example:

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Debugging helps inspect every iteration.

=========================================
DEBUGGING METHODS
=========================================

Methods frequently contain logical errors.

Questions to investigate:

- Was the method called?
- What arguments were passed?
- What value was returned?

Breakpoints and stepping tools make
these questions easy to answer.

=========================================
COMMON DEBUGGING STRATEGIES
=========================================

1. Reproduce the bug
2. Read the error message
3. Add breakpoints
4. Inspect variables
5. Follow execution flow
6. Identify root cause
7. Fix the issue
8. Test again

=========================================
PROFESSIONAL DEBUGGING TIPS
=========================================

- Never guess
- Reproduce problems consistently
- Read exception messages carefully
- Use breakpoints strategically
- Inspect variables frequently
- Verify assumptions
- Fix root causes, not symptoms
- Test after every fix

=========================================
SUMMARY
=========================================

Debugging is one of the most valuable
skills in software development.

In this module, I learned:

- What bugs are
- Types of bugs
- Breakpoints
- Step Over
- Step Into
- Step Out
- Watch Window
- Locals Window
- Call Stack
- Exception debugging
- Conditional breakpoints
- Professional debugging techniques

Mastering debugging allows me to solve
problems faster and become a stronger
C# developer.
*/

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
