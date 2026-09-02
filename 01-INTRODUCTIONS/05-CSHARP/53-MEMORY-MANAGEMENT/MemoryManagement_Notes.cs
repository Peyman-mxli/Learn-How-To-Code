```csharp
/*
    ============================================================
    MODULE: 53 - MEMORY MANAGEMENT
    FILE: MemoryManagement_Notes.cs
    ============================================================

    Memory Management is the process of controlling
    how memory is allocated, used, and released
    during program execution.

    Every C# application uses memory to store:

    - Variables
    - Objects
    - Arrays
    - Strings
    - Collections
    - Files
    - Application data

    Understanding memory management helps developers
    build faster, safer, and more efficient software.

    ============================================================
    WHAT IS MEMORY?
    ============================================================

    Memory (RAM) is temporary storage used by a program
    while it is running.

    When an application closes,
    its memory is released back to the operating system.

    Example:

        int age = 25;

    The value 25 is stored in memory.

    ============================================================
    STACK MEMORY
    ============================================================

    The Stack is a fast memory area used for:

    - Local variables
    - Method parameters
    - Value types

    Example:

        int age = 25;
        double salary = 1500.50;
        bool isActive = true;

    Advantages:

    ✓ Very fast

    ✓ Automatically managed

    ✓ Simple allocation and removal

    Stack memory is released automatically
    when methods finish execution.

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

    The reference variable exists on the Stack.

    The actual object exists on the Heap.

    Visual representation:

        Stack

        person ----------+

                          |
                          v

        Heap

        [ Person Object ]

    ============================================================
    VALUE TYPES
    ============================================================

    Value types store actual values directly.

    Examples:

        int
        double
        float
        bool
        char
        struct
        enum

    Example:

        int age = 25;

    The value itself is stored.

    ============================================================
    REFERENCE TYPES
    ============================================================

    Reference types store memory addresses.

    Examples:

        class
        string
        array
        List<T>
        Dictionary<TKey, TValue>

    Example:

        Person person = new Person();

    The variable stores a reference
    to an object on the Heap.

    ============================================================
    MEMORY ALLOCATION
    ============================================================

    Allocation means reserving memory.

    Example:

        Person person = new Person();

    When the object is created,
    memory is allocated on the Heap.

    ============================================================
    OBJECT LIFETIME
    ============================================================

    Every object has a lifetime.

    Object lifecycle:

        Created
            ↓
        Used
            ↓
        No longer referenced
            ↓
        Garbage Collected

    Example:

        Person person = new Person();

        person = null;

    The object becomes eligible
    for Garbage Collection.

    ============================================================
    GARBAGE COLLECTION
    ============================================================

    .NET uses Garbage Collection (GC)
    to automatically reclaim memory.

    Responsibilities:

    ✓ Find unused objects

    ✓ Free memory

    ✓ Improve memory efficiency

    Example:

        GC.Collect();

    Manual collection is possible,
    but usually not recommended.

    ============================================================
    GENERATIONS
    ============================================================

    The Garbage Collector organizes objects
    into generations.

    Generation 0

        New objects

    Generation 1

        Objects surviving Gen 0

    Generation 2

        Long-lived objects

    Benefits:

    ✓ Faster collections

    ✓ Better performance

    ============================================================
    MEMORY LEAKS
    ============================================================

    Memory leaks can still occur
    in managed applications.

    Example:

        static List<Person> people =
            new List<Person>();

    If objects remain referenced forever,
    GC cannot remove them.

    Result:

        Memory usage increases.

    ============================================================
    UNMANAGED RESOURCES
    ============================================================

    Some resources exist outside
    .NET memory management.

    Examples:

    - Files
    - Database connections
    - Network sockets
    - Operating system handles

    These resources require explicit cleanup.

    ============================================================
    IDISPOSABLE
    ============================================================

    IDisposable provides a standard way
    to release unmanaged resources.

    Example:

        public class FileManager
            : IDisposable
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

        using(StreamReader reader =
              new StreamReader("file.txt"))
        {
            // Read file
        }

    Dispose() executes automatically.

    ============================================================
    MEMORY EFFICIENCY
    ============================================================

    Efficient memory usage improves:

    ✓ Performance

    ✓ Scalability

    ✓ Stability

    ✓ Resource consumption

    Example:

        Reuse objects when possible.

    Avoid:

        Creating unnecessary objects.

    ============================================================
    LARGE OBJECT HEAP (LOH)
    ============================================================

    Very large objects are stored
    in a special area called:

        Large Object Heap

    Generally:

        Objects larger than 85,000 bytes

    Examples:

    - Large arrays
    - Large buffers

    LOH collections are more expensive.

    ============================================================
    BOXING
    ============================================================

    Boxing converts a value type
    into a reference type.

    Example:

        int number = 10;

        object obj = number;

    This creates additional allocations.

    ============================================================
    UNBOXING
    ============================================================

    Unboxing converts a reference type
    back into a value type.

    Example:

        int value = (int)obj;

    Excessive boxing/unboxing can reduce performance.

    ============================================================
    STRING MEMORY
    ============================================================

    Strings are immutable.

    Example:

        string name = "Peyman";

        name += " Nova";

    A new string object is created.

    Excessive string modifications
    can increase memory allocations.

    ============================================================
    STRINGBUILDER
    ============================================================

    StringBuilder is more efficient
    for frequent string modifications.

    Example:

        StringBuilder builder =
            new StringBuilder();

    Benefits:

    ✓ Fewer allocations

    ✓ Better performance

    ============================================================
    COMMON MEMORY PROBLEMS
    ============================================================

    Examples:

    - Memory leaks
    - Excessive allocations
    - Large collections
    - Unreleased resources
    - Excessive boxing
    - Huge strings

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Let Garbage Collection work naturally

    ✓ Use IDisposable correctly

    ✓ Use using statements

    ✓ Remove unused references

    ✓ Avoid unnecessary allocations

    ✓ Reuse objects when possible

    ✓ Monitor memory usage

    ✓ Use StringBuilder when needed

    ✓ Dispose unmanaged resources

    ============================================================
    SUMMARY
    ============================================================

    Memory Management is a fundamental
    part of professional software development.

    Important concepts include:

    - Stack
    - Heap
    - Value Types
    - Reference Types
    - Allocation
    - Object Lifetime
    - Garbage Collection
    - IDisposable
    - Memory Leaks

    Understanding memory management helps
    developers create faster, safer,
    and more efficient C# applications.
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
