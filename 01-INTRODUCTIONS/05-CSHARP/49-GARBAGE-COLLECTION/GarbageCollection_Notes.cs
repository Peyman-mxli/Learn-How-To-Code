```csharp
/*
    ============================================================
    MODULE: 49 - GARBAGE COLLECTION
    FILE: GarbageCollection_Notes.cs
    ============================================================

    Garbage Collection (GC) is the automatic memory management
    system used by the .NET runtime.

    Instead of manually freeing memory, the Garbage Collector
    automatically removes objects that are no longer being used
    by the application.

    This helps prevent memory leaks and improves application
    stability.

    ============================================================
    WHAT IS MEMORY?
    ============================================================

    Memory is where a program stores data while it runs.

    Every variable, object, collection, string, and class
    instance consumes memory.

    Example:

        Person person = new Person();

    When this object is created, memory is allocated for it.

    ============================================================
    STACK MEMORY
    ============================================================

    The Stack stores:

    - Local variables
    - Method parameters
    - Value types

    Examples:

        int age = 25;
        double salary = 1500.50;
        bool isActive = true;

    Stack memory is:

    - Fast
    - Automatically cleaned up
    - Managed by method calls

    When a method finishes, its stack memory disappears.

    ============================================================
    HEAP MEMORY
    ============================================================

    The Heap stores:

    - Objects
    - Classes
    - Arrays
    - Strings
    - Collections

    Example:

        Person person = new Person();

    The reference variable lives on the stack.

    The actual object lives on the heap.

    Visual example:

        Stack                    Heap

        person -------------> [Person Object]

    ============================================================
    WHAT IS GARBAGE COLLECTION?
    ============================================================

    Garbage Collection is the process of:

    1. Finding unused objects
    2. Reclaiming their memory
    3. Making that memory available again

    This process happens automatically.

    Developers normally do not manually delete objects.

    ============================================================
    HOW DOES GC KNOW AN OBJECT IS UNUSED?
    ============================================================

    The Garbage Collector starts from application roots.

    Examples of roots:

    - Local variables
    - Static fields
    - Active method references
    - CPU registers

    If an object cannot be reached from a root,
    it becomes eligible for collection.

    Example:

        Person person = new Person();

        person = null;

    The object still exists in memory.

    However, there is no longer a reference to it.

    Eventually GC can remove it.

    ============================================================
    MEMORY LEAKS IN MANAGED CODE
    ============================================================

    Even with Garbage Collection,
    memory leaks can still happen.

    Example:

        static List<Person> people = new();

    If objects remain inside the list forever,
    they can never be collected.

    GC only removes unreachable objects.

    If references remain,
    memory remains allocated.

    ============================================================
    OBJECT GENERATIONS
    ============================================================

    .NET uses a Generational Garbage Collector.

    Objects are grouped into generations.

    Generation 0 (Gen 0)

        New objects
        Most frequently collected

    Generation 1 (Gen 1)

        Objects that survived Gen 0

    Generation 2 (Gen 2)

        Long-lived objects

    Examples:

        Application configuration
        Cache systems
        Global objects

    ============================================================
    WHY GENERATIONS EXIST
    ============================================================

    Most objects die quickly.

    Example:

        Temporary strings
        Calculations
        Short-lived collections

    Instead of scanning all memory every time,
    GC focuses on newer objects first.

    This greatly improves performance.

    ============================================================
    GENERATION FLOW
    ============================================================

    New Object
         ↓
      Gen 0
         ↓
    Survives Collection
         ↓
      Gen 1
         ↓
    Survives Collection
         ↓
      Gen 2

    ============================================================
    FORCING GARBAGE COLLECTION
    ============================================================

    It is possible to manually request collection.

    Example:

        GC.Collect();

    However:

    Microsoft generally recommends
    avoiding manual collection.

    The runtime usually knows better.

    Manual collection can actually reduce performance.

    ============================================================
    GC CLASS
    ============================================================

    Common methods:

        GC.Collect()

    Forces collection.

        GC.GetTotalMemory(false)

    Returns allocated memory.

        GC.WaitForPendingFinalizers()

    Waits for finalizers to complete.

        GC.CollectionCount(0)

    Number of Gen 0 collections.

    ============================================================
    FINALIZERS (DESTRUCTORS)
    ============================================================

    A finalizer runs before an object is destroyed.

    Example:

        class FileHandler
        {
            ~FileHandler()
            {
                Console.WriteLine("Cleanup");
            }
        }

    Finalizers should be used carefully.

    They can slow down Garbage Collection.

    ============================================================
    UNMANAGED RESOURCES
    ============================================================

    Some resources are outside .NET memory management.

    Examples:

    - Files
    - Database connections
    - Network sockets
    - Operating system handles

    These require explicit cleanup.

    ============================================================
    IDISPOSABLE
    ============================================================

    IDisposable allows objects
    to release unmanaged resources.

    Example:

        public class FileManager : IDisposable
        {
            public void Dispose()
            {
                // Cleanup
            }
        }

    ============================================================
    USING STATEMENT
    ============================================================

    The using statement automatically
    calls Dispose().

    Example:

        using (StreamReader reader =
               new StreamReader("file.txt"))
        {
            // Read file
        }

    Dispose() is automatically executed.

    This is the preferred pattern.

    ============================================================
    GARBAGE COLLECTION PERFORMANCE
    ============================================================

    Frequent allocations create pressure on GC.

    Example:

        Creating millions of objects
        inside a loop.

    This causes:

    - More collections
    - More CPU usage
    - Lower performance

    Professional developers try to:

    - Reuse objects
    - Avoid unnecessary allocations
    - Use efficient collections

    ============================================================
    LARGE OBJECT HEAP (LOH)
    ============================================================

    Very large objects are stored
    in a separate area.

    Called:

        Large Object Heap

    Usually objects larger than:

        85,000 bytes

    Examples:

    - Large arrays
    - Large buffers

    LOH collections are more expensive.

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Let GC manage memory

    ✓ Use IDisposable for unmanaged resources

    ✓ Use using statements

    ✓ Avoid unnecessary allocations

    ✓ Remove unused references

    ✓ Monitor memory usage

    ✓ Reuse objects when appropriate

    ✓ Avoid forcing GC manually

    ============================================================
    SUMMARY
    ============================================================

    Garbage Collection is one of the most important
    features of C# and .NET.

    It automatically manages memory by removing
    unreachable objects from the heap.

    Understanding GC helps developers build:

    - Faster applications
    - More scalable systems
    - Memory-efficient software
    - Professional enterprise applications

    Knowing how the Garbage Collector works is
    essential for advanced C# development.
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
