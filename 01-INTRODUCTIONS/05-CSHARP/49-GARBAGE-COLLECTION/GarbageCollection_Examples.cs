```csharp
using System;

namespace GarbageCollectionExamples
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Person Created: {Name}");
        }

        ~Person()
        {
            Console.WriteLine($"Person Destroyed: {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("GARBAGE COLLECTION EXAMPLES");
            Console.WriteLine("========================================");

            Example1_ObjectCreation();
            Example2_NullReference();
            Example3_GetTotalMemory();
            Example4_GenerationInformation();
            Example5_ManualCollection();
            Example6_IDisposablePattern();

            Console.WriteLine("\nAll examples completed.");
        }

        // ----------------------------------------------------
        // Example 1
        // Creating an object on the heap
        // ----------------------------------------------------
        static void Example1_ObjectCreation()
        {
            Console.WriteLine("\nEXAMPLE 1 - Object Creation");

            Person person = new Person("Peyman");

            Console.WriteLine("Object exists in memory.");
        }

        // ----------------------------------------------------
        // Example 2
        // Removing a reference
        // ----------------------------------------------------
        static void Example2_NullReference()
        {
            Console.WriteLine("\nEXAMPLE 2 - Null Reference");

            Person person = new Person("Nova");

            person = null;

            Console.WriteLine("Reference removed.");
            Console.WriteLine("Object is now eligible for GC.");
        }

        // ----------------------------------------------------
        // Example 3
        // Checking allocated memory
        // ----------------------------------------------------
        static void Example3_GetTotalMemory()
        {
            Console.WriteLine("\nEXAMPLE 3 - Get Total Memory");

            long memoryBefore = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory Before: {memoryBefore:N0} bytes");

            int[] numbers = new int[100000];

            long memoryAfter = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory After : {memoryAfter:N0} bytes");
        }

        // ----------------------------------------------------
        // Example 4
        // Object generation
        // ----------------------------------------------------
        static void Example4_GenerationInformation()
        {
            Console.WriteLine("\nEXAMPLE 4 - Generation Information");

            Person person = new Person("Generation Test");

            int generation = GC.GetGeneration(person);

            Console.WriteLine($"Current Generation: {generation}");
        }

        // ----------------------------------------------------
        // Example 5
        // Manual collection
        // ----------------------------------------------------
        static void Example5_ManualCollection()
        {
            Console.WriteLine("\nEXAMPLE 5 - Manual Collection");

            Person person = new Person("Manual GC");

            person = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Manual collection requested.");
        }

        // ----------------------------------------------------
        // Example 6
        // IDisposable pattern
        // ----------------------------------------------------
        static void Example6_IDisposablePattern()
        {
            Console.WriteLine("\nEXAMPLE 6 - IDisposable");

            using (FileManager manager = new FileManager())
            {
                manager.Work();
            }

            Console.WriteLine("Dispose() executed automatically.");
        }
    }

    public class FileManager : IDisposable
    {
        public void Work()
        {
            Console.WriteLine("Working with resource...");
        }

        public void Dispose()
        {
            Console.WriteLine("Cleaning unmanaged resources...");
        }
    }
}

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
