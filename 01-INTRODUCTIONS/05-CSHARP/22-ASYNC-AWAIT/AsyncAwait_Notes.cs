```csharp
using System;

/*
=========================================
ASYNC AWAIT NOTES
=========================================

In this module, I learn about Async and Await.

Async and Await are used for asynchronous programming.

Asynchronous programming allows a program to continue
working while waiting for another operation to finish.

Examples:

• Downloading files
• Calling APIs
• Reading databases
• Loading game data
• Saving files
• Network communication

Async and Await help applications remain responsive.

=========================================
WHAT IS ASYNCHRONOUS PROGRAMMING?
=========================================

Asynchronous programming allows work to happen
without blocking the rest of the application.

Example:

A file takes 5 seconds to download.

Without Async:

The program waits 5 seconds.

Everything stops.

With Async:

The download starts.

The program continues running.

When the download finishes,
the program receives the result.

=========================================
SYNCHRONOUS VS ASYNCHRONOUS
=========================================

Synchronous:

Task A

↓

Wait

↓

Task B

↓

Wait

↓

Task C

Everything happens one at a time.

-----------------------------------------

Asynchronous:

Task A starts

↓

Task B starts

↓

Task C starts

↓

Results return later

Work can continue while waiting.

=========================================
WHY ASYNC EXISTS
=========================================

Without Async:

Applications may freeze.

Examples:

• Frozen user interfaces
• Slow websites
• Delayed responses
• Poor user experience

Async helps solve these problems.

=========================================
THE ASYNC KEYWORD
=========================================

The async keyword marks a method
as asynchronous.

Example:

public async Task LoadDataAsync()
{
}

The compiler now allows await
inside the method.

=========================================
THE AWAIT KEYWORD
=========================================

Await pauses the method until a Task finishes.

Example:

await Task.Delay(2000);

The method pauses.

The application continues running.

When the Task completes,
execution continues.

=========================================
WHAT IS A TASK?
=========================================

Task represents an asynchronous operation.

Think of a Task as:

"A promise that work will finish later."

Example:

Task downloadTask;

The Task may be:

• Running
• Completed
• Failed
• Cancelled

=========================================
TASK RETURN TYPES
=========================================

Common async return types:

Task

Task<T>

void (rarely)

=========================================
TASK
=========================================

Used when no value is returned.

Example:

public async Task SaveFileAsync()
{
    await Task.Delay(1000);
}

=========================================
TASK<T>
=========================================

Used when a value is returned.

Example:

public async Task<int> GetScoreAsync()
{
    await Task.Delay(1000);

    return 100;
}

Returned Value:

100

=========================================
ASYNC METHOD EXAMPLE
=========================================

Example:

public async Task LoadGameAsync()
{
    Console.WriteLine("Loading...");

    await Task.Delay(3000);

    Console.WriteLine("Loaded");
}

The program remains responsive.

=========================================
TASK.DELAY()
=========================================

Task.Delay creates an asynchronous wait.

Example:

await Task.Delay(2000);

Waits:

2 seconds

Useful for:

• Simulations
• Testing
• Delays
• Demonstrations

=========================================
RETURNING VALUES
=========================================

Example:

public async Task<string> GetPlayerNameAsync()
{
    await Task.Delay(1000);

    return "Peyman";
}

Usage:

string name =
await GetPlayerNameAsync();

=========================================
MULTIPLE ASYNC OPERATIONS
=========================================

Example:

Task task1 =
DownloadFileAsync();

Task task2 =
LoadDatabaseAsync();

await task1;
await task2;

Multiple tasks can run together.

=========================================
TASK.WHENALL()
=========================================

Waits for multiple tasks.

Example:

await Task.WhenAll(
    task1,
    task2,
    task3);

All tasks must finish.

=========================================
TASK.WHENANY()
=========================================

Waits for the first task.

Example:

await Task.WhenAny(
    task1,
    task2,
    task3);

Returns when one task completes.

=========================================
REAL-WORLD API EXAMPLE
=========================================

Application

↓

Request Data

↓

Wait For Server

↓

Receive Response

↓

Display Result

Async prevents the application
from freezing while waiting.

=========================================
REAL-WORLD GAME EXAMPLE
=========================================

Player enters a new zone.

↓

Load textures

↓

Load sounds

↓

Load NPCs

↓

Load quests

Async loading prevents lag
and improves player experience.

=========================================
REAL-WORLD DATABASE EXAMPLE
=========================================

User clicks Login.

↓

Database query starts.

↓

Application remains responsive.

↓

Database responds.

↓

User enters system.

=========================================
EXCEPTION HANDLING
=========================================

Async methods can throw exceptions.

Example:

try
{
    await DownloadAsync();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Always handle possible failures.

=========================================
COMMON MISTAKES
=========================================

Mistake #1

Forgetting await.

Wrong:

LoadDataAsync();

Correct:

await LoadDataAsync();

-----------------------------------------

Mistake #2

Using async void.

Avoid:

async void MyMethod()

Prefer:

async Task MyMethod()

-----------------------------------------

Mistake #3

Blocking async code.

Wrong:

task.Result

task.Wait()

These can cause deadlocks.

-----------------------------------------

Mistake #4

Ignoring exceptions.

Always use proper error handling.

=========================================
BEST PRACTICES
=========================================

• Use async for long operations
• Prefer Task over async void
• Always await Tasks
• Handle exceptions
• Keep async methods focused
• Avoid blocking async code
• Use meaningful method names

=========================================
NAMING CONVENTIONS
=========================================

Async methods should end with:

Async

Examples:

LoadDataAsync()

SaveFileAsync()

DownloadImageAsync()

GetPlayerStatsAsync()

This makes code easier to understand.

=========================================
ADVANTAGES OF ASYNC AWAIT
=========================================

1. Better User Experience

Applications remain responsive.

-----------------------------------------

2. Better Performance

Resources are used efficiently.

-----------------------------------------

3. Cleaner Code

Easier than traditional threading.

-----------------------------------------

4. Scalability

Useful for large systems.

-----------------------------------------

5. Modern Development

Widely used in professional applications.

=========================================
MODULE SUMMARY
=========================================

In this module, I learned:

• Asynchronous Programming
• Synchronous vs Asynchronous
• Async
• Await
• Task
• Task<T>
• Task.Delay
• Returning Values
• Task.WhenAll
• Task.WhenAny
• Async Exception Handling
• Async Best Practices

Async and Await are essential tools
for modern C# development.

They allow applications to remain
responsive while performing long-running
operations in the background.
*/

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
