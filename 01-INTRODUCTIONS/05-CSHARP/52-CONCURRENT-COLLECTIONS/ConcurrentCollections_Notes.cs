```csharp
/*
    ============================================================
    MODULE: 52 - CONCURRENT COLLECTIONS
    FILE: ConcurrentCollections_Notes.cs
    ============================================================

    Concurrent Collections are thread-safe collection types
    provided by .NET.

    They are designed to allow multiple threads to safely
    access and modify data at the same time.

    These collections reduce the need for manual locking
    and help prevent race conditions and data corruption.

    ============================================================
    WHY CONCURRENT COLLECTIONS EXIST
    ============================================================

    Standard collections are not always thread-safe.

    Examples:

        List<T>
        Dictionary<TKey, TValue>
        Queue<T>
        Stack<T>

    When multiple threads access these collections
    simultaneously, problems can occur.

    Example:

        Thread A adds an item

        Thread B removes an item

    At the same time.

    Possible results:

    ✗ Race conditions

    ✗ Invalid data

    ✗ Exceptions

    ✗ Application crashes

    Concurrent Collections solve these problems.

    ============================================================
    NAMESPACE
    ============================================================

    To use Concurrent Collections:

        using System.Collections.Concurrent;

    ============================================================
    THREAD SAFETY
    ============================================================

    Thread safety means:

        Multiple threads can safely access
        the same resource without causing
        incorrect behavior.

    Concurrent Collections provide built-in
    thread safety.

    ============================================================
    CONCURRENTDICTIONARY<TKey, TValue>
    ============================================================

    Thread-safe version of:

        Dictionary<TKey, TValue>

    Example:

        ConcurrentDictionary<int, string>
            users = new();

    Add:

        users.TryAdd(1, "Peyman");

    Retrieve:

        users.TryGetValue(1, out string name);

    Benefits:

    ✓ Fast

    ✓ Thread-safe

    ✓ No manual locking needed

    ============================================================
    TRYADD()
    ============================================================

    Adds an item only if the key
    does not already exist.

    Example:

        users.TryAdd(5, "Nova");

    Returns:

        true

    or

        false

    ============================================================
    TRYREMOVE()
    ============================================================

    Removes an item safely.

    Example:

        users.TryRemove(5, out string value);

    ============================================================
    ADDORUPDATE()
    ============================================================

    Adds a new value if missing.

    Updates existing value if found.

    Example:

        dictionary.AddOrUpdate(
            1,
            "New User",
            (key, oldValue) =>
                oldValue + " Updated");

    Useful for counters and statistics.

    ============================================================
    CONCURRENTQUEUE<T>
    ============================================================

    Thread-safe version of:

        Queue<T>

    FIFO

        First In First Out

    Example:

        ConcurrentQueue<string> queue =
            new();

    Add:

        queue.Enqueue("Task A");

    Remove:

        queue.TryDequeue(
            out string task);

    ============================================================
    PRODUCER-CONSUMER MODEL
    ============================================================

    ConcurrentQueue is commonly used
    in producer-consumer systems.

    Producer:

        Creates work

    Consumer:

        Processes work

    Example:

        Producer adds jobs

        Consumer removes jobs

    ============================================================
    CONCURRENTSTACK<T>
    ============================================================

    Thread-safe version of:

        Stack<T>

    LIFO

        Last In First Out

    Example:

        ConcurrentStack<int> stack =
            new();

    Push:

        stack.Push(10);

    Pop:

        stack.TryPop(out int value);

    ============================================================
    CONCURRENTBAG<T>
    ============================================================

    Thread-safe unordered collection.

    Example:

        ConcurrentBag<string> bag =
            new();

    Add:

        bag.Add("Item");

    Remove:

        bag.TryTake(out string value);

    Characteristics:

    ✓ Fast

    ✓ Unordered

    ✓ Optimized for parallel scenarios

    ============================================================
    WHEN TO USE CONCURRENTBAG
    ============================================================

    Good for:

    - Parallel processing
    - Temporary storage
    - Work sharing

    Not ideal when order matters.

    ============================================================
    BLOCKINGCOLLECTION<T>
    ============================================================

    Special collection for
    producer-consumer scenarios.

    Example:

        BlockingCollection<int>
            collection = new();

    Features:

    ✓ Thread-safe

    ✓ Blocking operations

    ✓ Bounded capacity

    ✓ Producer-consumer support

    ============================================================
    WHY NOT USE LOCK EVERYWHERE?
    ============================================================

    We can protect collections using:

        lock

    Example:

        lock(locker)
        {
            list.Add(item);
        }

    But excessive locking can:

    ✗ Reduce performance

    ✗ Increase complexity

    ✗ Create deadlocks

    Concurrent Collections provide
    optimized thread-safe behavior.

    ============================================================
    PERFORMANCE BENEFITS
    ============================================================

    Concurrent Collections are optimized
    for multithreaded workloads.

    Benefits:

    ✓ Better scalability

    ✓ Better throughput

    ✓ Reduced locking

    ✓ Improved responsiveness

    ============================================================
    COMMON USE CASES
    ============================================================

    Concurrent Collections are used in:

    - Web servers
    - APIs
    - Background processing
    - Task scheduling
    - Job queues
    - Cloud applications
    - Multiplayer games
    - Logging systems

    ============================================================
    CONCURRENT COLLECTION SELECTION
    ============================================================

    Need key/value storage?

        ConcurrentDictionary

    Need FIFO order?

        ConcurrentQueue

    Need LIFO order?

        ConcurrentStack

    Need unordered storage?

        ConcurrentBag

    Need producer-consumer workflow?

        BlockingCollection

    ============================================================
    THREAD SAFETY VS PERFORMANCE
    ============================================================

    Thread safety improves correctness.

    However:

    Every safety feature has a cost.

    Developers should choose the right
    collection for the situation.

    Do not use thread-safe collections
    when multithreading is not needed.

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Use ConcurrentDictionary
      for shared key/value data

    ✓ Use ConcurrentQueue
      for work queues

    ✓ Use ConcurrentStack
      for LIFO operations

    ✓ Use ConcurrentBag
      for unordered parallel storage

    ✓ Use BlockingCollection
      for producer-consumer systems

    ✓ Avoid unnecessary locking

    ✓ Choose the correct collection type

    ✓ Test multithreaded code carefully

    ============================================================
    SUMMARY
    ============================================================

    Concurrent Collections provide
    thread-safe data structures
    for modern multithreaded applications.

    Important collections include:

        ConcurrentDictionary

        ConcurrentQueue

        ConcurrentStack

        ConcurrentBag

        BlockingCollection

    Understanding these collections
    helps developers build safer,
    faster, and more scalable applications.
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
