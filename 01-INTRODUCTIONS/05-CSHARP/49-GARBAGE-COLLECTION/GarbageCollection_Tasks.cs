```csharp
/*
    ============================================================
    MODULE: 49 - GARBAGE COLLECTION
    FILE: GarbageCollection_Tasks.cs
    ============================================================

    TASK 1:
    Create a class named Student.

    Requirements:
    - Add a property called Name
    - Add a constructor that receives the student name
    - Print a message when the object is created

    ------------------------------------------------------------

    TASK 2:
    Create a method named CreateStudent.

    Requirements:
    - Inside the method, create a Student object
    - Print the student's name
    - Explain why the object becomes eligible for Garbage Collection
      after the method finishes

    ------------------------------------------------------------

    TASK 3:
    Create a class named TemporaryObject.

    Requirements:
    - Add a constructor that prints "Temporary object created"
    - Add a finalizer that prints "Temporary object destroyed"
    - Create an object from this class
    - Remove the reference by setting it to null

    ------------------------------------------------------------

    TASK 4:
    Use GC.GetTotalMemory(false).

    Requirements:
    - Store memory before creating a large array
    - Create an integer array with 100000 values
    - Store memory after creating the array
    - Print both memory values

    ------------------------------------------------------------

    TASK 5:
    Use GC.GetGeneration().

    Requirements:
    - Create an object
    - Print its current generation
    - Explain what generation means

    ------------------------------------------------------------

    TASK 6:
    Practice GC.Collect().

    Requirements:
    - Create an object
    - Set it to null
    - Call GC.Collect()
    - Call GC.WaitForPendingFinalizers()
    - Print a message after collection is requested

    ------------------------------------------------------------

    TASK 7:
    Create a class named ResourceHandler.

    Requirements:
    - Implement IDisposable
    - Create a Dispose() method
    - Print "Resource cleaned"
    - Use the class inside a using statement

    ------------------------------------------------------------

    TASK 8:
    Explain the difference between Stack and Heap.

    Requirements:
    - Explain what type of data is stored on the stack
    - Explain what type of data is stored on the heap
    - Give one example of each

    ------------------------------------------------------------

    TASK 9:
    Explain why memory leaks can still happen in C#.

    Requirements:
    - Explain that GC only removes unreachable objects
    - Explain how keeping references can prevent collection
    - Give an example using a static list

    ------------------------------------------------------------

    TASK 10:
    Write best practices for Garbage Collection.

    Requirements:
    - Write at least 5 best practices
    - Include IDisposable
    - Include using statements
    - Include avoiding unnecessary allocations
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
