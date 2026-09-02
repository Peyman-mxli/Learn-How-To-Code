```csharp
/*
    ============================================================
    MODULE: 51 - TASK PARALLEL LIBRARY (TPL)
    FILE: TaskParallelLibrary_Notes.cs
    ============================================================

    The Task Parallel Library (TPL) is a powerful framework
    provided by .NET for running operations asynchronously
    and in parallel.

    TPL helps developers write cleaner, safer, and more
    efficient code without manually managing threads.

    Modern C# applications heavily rely on Tasks.

    ============================================================
    WHAT IS A TASK?
    ============================================================

    A Task represents a unit of work that can execute
    asynchronously.

    Think of a Task as:

        "A job that needs to be completed."

    Example:

        Task task = Task.Run(() =>
        {
            Console.WriteLine("Working...");
        });

    The task runs independently from the main program flow.

    ============================================================
    WHY TASKS EXIST
    ============================================================

    Before Tasks, developers often created Threads manually.

    Example:

        Thread thread = new Thread(Work);
        thread.Start();

    This works, but managing many threads becomes difficult.

    Problems:

    ✗ More code
    ✗ More complexity
    ✗ Higher resource usage
    ✗ Harder error handling

    Tasks solve these problems.

    ============================================================
    TASK VS THREAD
    ============================================================

    Thread

        Actual execution unit.

    Task

        Higher-level abstraction built on top of threads.

    Think of it like:

        Thread = Worker

        Task = Job assigned to worker

    Tasks are generally preferred in modern .NET development.

    ============================================================
    USING TASKS
    ============================================================

    Namespace:

        using System.Threading.Tasks;

    Example:

        Task task = Task.Run(() =>
        {
            Console.WriteLine("Task Running");
        });

    ============================================================
    TASK.RUN()
    ============================================================

    Task.Run() creates and starts a task immediately.

    Example:

        Task.Run(() =>
        {
            Console.WriteLine("Hello");
        });

    This is the most common way to create a task.

    ============================================================
    WAITING FOR A TASK
    ============================================================

    Sometimes we need to wait until a task finishes.

    Example:

        Task task = Task.Run(Work);

        task.Wait();

    Wait() blocks execution until the task completes.

    ============================================================
    TASK STATUS
    ============================================================

    Every task has a status.

    Common statuses:

        Created
        Running
        WaitingToRun
        RanToCompletion
        Faulted
        Canceled

    Example:

        Console.WriteLine(task.Status);

    ============================================================
    RETURNING VALUES
    ============================================================

    Tasks can return values.

    Example:

        Task<int> task =
            Task.Run(() => 10 + 20);

        int result = task.Result;

    Output:

        30

    Generic Tasks:

        Task<T>

    return values of type T.

    ============================================================
    TASK.RESULT
    ============================================================

    Result retrieves the returned value.

    Example:

        int value = task.Result;

    Important:

    Result waits automatically
    if the task has not finished.

    ============================================================
    MULTIPLE TASKS
    ============================================================

    Multiple tasks can run simultaneously.

    Example:

        Task task1 = Task.Run(Work1);
        Task task2 = Task.Run(Work2);
        Task task3 = Task.Run(Work3);

    All tasks can execute concurrently.

    ============================================================
    TASK.WAITALL()
    ============================================================

    WaitAll waits until all tasks finish.

    Example:

        Task.WaitAll(task1, task2, task3);

    Useful when all work must complete
    before continuing.

    ============================================================
    TASK.WHENALL()
    ============================================================

    WhenAll creates a task that completes
    when all supplied tasks finish.

    Example:

        await Task.WhenAll(
            task1,
            task2,
            task3);

    Commonly used in asynchronous applications.

    ============================================================
    TASK.WHENANY()
    ============================================================

    WhenAny completes when the first task finishes.

    Example:

        Task firstFinished =
            await Task.WhenAny(
                task1,
                task2);

    Useful for:

    - Time-sensitive operations
    - Fastest response wins

    ============================================================
    PARALLEL EXECUTION
    ============================================================

    Tasks allow multiple operations
    to run at the same time.

    Example:

        Download File
        Process Data
        Save Results

    Instead of waiting for each operation,
    tasks can perform work concurrently.

    ============================================================
    EXCEPTION HANDLING
    ============================================================

    Tasks can throw exceptions.

    Example:

        Task task = Task.Run(() =>
        {
            throw new Exception("Error");
        });

    Use try-catch.

        try
        {
            task.Wait();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    ============================================================
    TASK CANCELLATION
    ============================================================

    Tasks can be cancelled using:

        CancellationToken

    Example:

        CancellationTokenSource source =
            new();

        CancellationToken token =
            source.Token;

    This allows controlled cancellation.

    ============================================================
    CPU-BOUND TASKS
    ============================================================

    CPU-bound tasks perform calculations.

    Examples:

    - Mathematics
    - Image processing
    - Data analysis
    - Simulations

    Often executed using:

        Task.Run()

    ============================================================
    I/O-BOUND TASKS
    ============================================================

    I/O-bound tasks wait for external resources.

    Examples:

    - File operations
    - Database queries
    - API requests
    - Network communication

    Usually combined with:

        async / await

    ============================================================
    BENEFITS OF TASKS
    ============================================================

    ✓ Cleaner code

    ✓ Easier maintenance

    ✓ Better scalability

    ✓ Better performance

    ✓ Simplified error handling

    ✓ ThreadPool integration

    ✓ Modern .NET standard

    ============================================================
    THREADPOOL
    ============================================================

    Most Tasks use the ThreadPool.

    ThreadPool:

    - Reuses threads
    - Reduces creation overhead
    - Improves efficiency

    Developers usually do not manage
    ThreadPool threads directly.

    ============================================================
    COMMON USE CASES
    ============================================================

    Tasks are widely used for:

    - Background processing
    - Web APIs
    - Cloud applications
    - File systems
    - Data processing
    - Desktop applications
    - Games
    - Mobile applications

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Prefer Tasks over Threads

    ✓ Use Task.Run() for CPU-bound work

    ✓ Use async/await when appropriate

    ✓ Handle exceptions properly

    ✓ Avoid blocking unnecessarily

    ✓ Use cancellation tokens

    ✓ Keep tasks focused on one job

    ✓ Use WhenAll for multiple operations

    ============================================================
    TASKS AND ASYNC/AWAIT
    ============================================================

    Tasks are the foundation of
    async and await.

    Example:

        await SomeTask();

    Under the hood:

        SomeTask()
        returns a Task.

    Understanding Tasks makes
    async programming much easier.

    ============================================================
    SUMMARY
    ============================================================

    The Task Parallel Library is one of the
    most important technologies in modern C#.

    It provides a simple and powerful way
    to run work asynchronously and in parallel.

    Key concepts include:

    - Task
    - Task.Run()
    - Wait()
    - Result
    - WaitAll()
    - WhenAll()
    - Exception Handling
    - Cancellation

    Mastering Tasks is essential for
    professional .NET development.
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
```
