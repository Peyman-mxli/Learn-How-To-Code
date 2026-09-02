```csharp
using System;
using System.Collections.Generic;

namespace GarbageCollectionTaskSolutions
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"Student object created: {Name}");
        }
    }

    public class TemporaryObject
    {
        public TemporaryObject()
        {
            Console.WriteLine("Temporary object created");
        }

        ~TemporaryObject()
        {
            Console.WriteLine("Temporary object destroyed");
        }
    }

    public class ResourceHandler : IDisposable
    {
        public void UseResource()
        {
            Console.WriteLine("Using resource...");
        }

        public void Dispose()
        {
            Console.WriteLine("Resource cleaned");
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main()
        {
            Console.WriteLine("TASK 1:");
            Student student = new Student("Peyman");

            Console.WriteLine("\nTASK 2:");
            CreateStudent();

            Console.WriteLine("\nTASK 3:");
            TemporaryObject temp = new TemporaryObject();
            temp = null;

            Console.WriteLine("\nTASK 4:");
            long memoryBefore = GC.GetTotalMemory(false);
            int[] numbers = new int[100000];
            long memoryAfter = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory before: {memoryBefore:N0} bytes");
            Console.WriteLine($"Memory after : {memoryAfter:N0} bytes");

            Console.WriteLine("\nTASK 5:");
            object obj = new object();
            Console.WriteLine($"Object generation: {GC.GetGeneration(obj)}");
            Console.WriteLine("Generation means the age group of an object inside the Garbage Collector.");

            Console.WriteLine("\nTASK 6:");
            TemporaryObject collectObject = new TemporaryObject();
            collectObject = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Garbage Collection requested.");

            Console.WriteLine("\nTASK 7:");
            using (ResourceHandler handler = new ResourceHandler())
            {
                handler.UseResource();
            }

            Console.WriteLine("\nTASK 8:");
            Console.WriteLine("The Stack stores local variables, method parameters, and value types.");
            Console.WriteLine("The Heap stores objects, arrays, strings, and class instances.");
            Console.WriteLine("Stack example: int age = 25;");
            Console.WriteLine("Heap example: Student s = new Student(\"Nova\");");

            Console.WriteLine("\nTASK 9:");
            students.Add(new Student("Memory Leak Example"));
            Console.WriteLine("Memory leaks can still happen in C# when references stay alive.");
            Console.WriteLine("GC only removes unreachable objects.");
            Console.WriteLine("A static list can keep objects alive forever if they are never removed.");

            Console.WriteLine("\nTASK 10:");
            Console.WriteLine("Best Practices:");
            Console.WriteLine("1. Let GC manage memory automatically.");
            Console.WriteLine("2. Use IDisposable for unmanaged resources.");
            Console.WriteLine("3. Use using statements when working with disposable objects.");
            Console.WriteLine("4. Avoid unnecessary object allocations.");
            Console.WriteLine("5. Remove references when objects are no longer needed.");
        }

        static void CreateStudent()
        {
            Student student = new Student("Aria");

            Console.WriteLine($"Student name: {student.Name}");
            Console.WriteLine("After this method finishes, the local reference disappears.");
            Console.WriteLine("If no other reference exists, the object becomes eligible for Garbage Collection.");
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
