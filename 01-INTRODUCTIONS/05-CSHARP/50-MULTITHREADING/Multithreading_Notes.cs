```csharp
/*
    ============================================================
    MODULE: 50 - MULTITHREADING
    FILE: Multithreading_Notes.cs
    ============================================================

    Multithreading is one of the most important concepts
    in modern software development.

    It allows a program to perform multiple operations
    simultaneously using multiple threads.

    Understanding threads helps developers create faster,
    more responsive, and more scalable applications.

    ============================================================
    WHAT IS A THREAD?
    ============================================================

    A thread is the smallest unit of execution
    inside a process.

    A process is a running application.

    Examples:

    - Visual Studio
    - Chrome
    - Discord
    - A C# Console Application

    Every process contains at least one thread.

    This first thread is called:

        Main Thread

    Example:

        static void Main()
        {
            Console.WriteLine("Hello");
        }

    The Main() method runs on the Main Thread.

    ============================================================
    SINGLE-THREADED PROGRAM
    ============================================================

    A single-threaded application executes one task
    at a time.

    Example:

        Read File
        Process Data
        Save File

    Everything happens sequentially.

    Advantages:

    ✓ Easy to understand
    ✓ Easy to debug

    Disadvantages:

    ✗ Slow for large workloads
    ✗ UI can freeze
    ✗ Cannot fully utilize modern CPUs

    ============================================================
    MULTITHREADED PROGRAM
    ============================================================

    A multithreaded application executes multiple tasks
    simultaneously.

    Example:

        Thread 1 -> Download File
        Thread 2 -> Process Data
        Thread 3 -> Update UI

    Multiple operations can happen at the same time.

    Advantages:

    ✓ Better performance
    ✓ Better responsiveness
    ✓ Improved user experience
    ✓ Better CPU utilization

    ============================================================
    WHY MODERN COMPUTERS USE THREADS
    ============================================================

    Modern CPUs contain multiple cores.

    Example:

        2-Core CPU
        4-Core CPU
        8-Core CPU
        16-Core CPU

    Multiple cores allow multiple threads
    to run simultaneously.

    Multithreading helps utilize available hardware.

    ============================================================
    CREATING A THREAD
    ============================================================

    Namespace:

        using System.Threading;

    Example:

        Thread thread =
            new Thread(Work);

        thread.Start();

    Method:

        static void Work()
        {
            Console.WriteLine("Working...");
        }

    The Work() method runs on a separate thread.

    ============================================================
    THREAD START
    ============================================================

    Start() begins execution.

    Example:

        thread.Start();

    Without Start(),
    the thread never executes.

    ============================================================
    THREAD SLEEP
    ============================================================

    Sleep pauses a thread temporarily.

    Example:

        Thread.Sleep(2000);

    Meaning:

        Pause for 2000 milliseconds

        = 2 seconds

    Useful for:

    - Delays
    - Simulations
    - Testing

    ============================================================
    FOREGROUND THREADS
    ============================================================

    By default:

        Threads are Foreground Threads

    Foreground threads keep the application alive.

    The program cannot close while
    foreground threads are still running.

    ============================================================
    BACKGROUND THREADS
    ============================================================

    Background threads do not prevent
    application shutdown.

    Example:

        thread.IsBackground = true;

    When all foreground threads finish,
    background threads stop automatically.

    ============================================================
    THREAD STATES
    ============================================================

    Common thread states:

    Unstarted

        Thread created
        Not started

    Running

        Currently executing

    WaitSleepJoin

        Waiting or sleeping

    Stopped

        Execution finished

    ============================================================
    SHARED DATA
    ============================================================

    Multiple threads can access
    the same variables.

    Example:

        static int counter = 0;

    Thread A:

        counter++;

    Thread B:

        counter++;

    Shared data creates potential problems.

    ============================================================
    RACE CONDITION
    ============================================================

    A race condition occurs when
    multiple threads modify data
    at the same time.

    Example:

        counter++;

    Looks simple but actually means:

        Read value
        Add one
        Write value

    If two threads do this simultaneously,
    incorrect results may occur.

    Example:

        Expected: 2000
        Actual: 1743

    ============================================================
    THREAD SAFETY
    ============================================================

    Thread safety means code works correctly
    even when accessed by multiple threads.

    Thread-safe code prevents:

    - Corrupted data
    - Race conditions
    - Unexpected behavior

    ============================================================
    LOCK KEYWORD
    ============================================================

    lock protects shared resources.

    Example:

        private static object locker =
            new object();

        lock(locker)
        {
            counter++;
        }

    Only one thread may enter
    the lock block at a time.

    Benefits:

    ✓ Prevents race conditions
    ✓ Protects shared data

    ============================================================
    DEADLOCK
    ============================================================

    A deadlock occurs when
    two threads wait forever
    for each other.

    Example:

        Thread A waits for B

        Thread B waits for A

    Result:

        Application freezes

    Deadlocks should be avoided.

    ============================================================
    THREAD JOIN
    ============================================================

    Join waits for a thread to finish.

    Example:

        thread.Join();

    Main thread pauses until
    the target thread completes.

    Useful when execution order matters.

    ============================================================
    THREAD PRIORITY
    ============================================================

    Priorities influence scheduling.

    Examples:

        Lowest
        BelowNormal
        Normal
        AboveNormal
        Highest

    Example:

        thread.Priority =
            ThreadPriority.Highest;

    Modern operating systems often
    manage priorities automatically.

    ============================================================
    THREAD POOL
    ============================================================

    Creating threads repeatedly
    can be expensive.

    .NET provides:

        ThreadPool

    Benefits:

    ✓ Reuses threads
    ✓ Faster execution
    ✓ Lower memory usage

    ThreadPool is commonly used
    internally by Tasks.

    ============================================================
    COMMON USE CASES
    ============================================================

    Multithreading is used for:

    - File processing
    - Background calculations
    - Data analysis
    - Image processing
    - Video rendering
    - Game development
    - Networking
    - Servers
    - Database operations

    ============================================================
    PERFORMANCE CONSIDERATIONS
    ============================================================

    More threads do not always mean
    better performance.

    Too many threads can cause:

    - Context switching
    - Higher memory usage
    - CPU overhead

    Professional developers create
    only the threads they need.

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Keep threads focused on one task

    ✓ Protect shared resources

    ✓ Use lock when necessary

    ✓ Avoid excessive thread creation

    ✓ Avoid long-running locks

    ✓ Watch for deadlocks

    ✓ Prefer Tasks in modern applications

    ✓ Test multithreaded code carefully

    ============================================================
    MULTITHREADING VS ASYNC/AWAIT
    ============================================================

    Multithreading:

        Multiple threads

    Async/Await:

        Asynchronous execution
        without necessarily creating
        additional threads

    Both improve responsiveness,
    but solve different problems.

    ============================================================
    SUMMARY
    ============================================================

    Multithreading allows a program
    to perform multiple operations
    simultaneously.

    It improves performance,
    responsiveness, and scalability.

    Key concepts include:

    - Threads
    - Shared data
    - Race conditions
    - Locking
    - Thread safety

    Understanding multithreading is
    essential for professional software
    development and advanced C# programming.
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
