```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryManagementTaskSolutions
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    public class ResourceManager : IDisposable
    {
        public void UseResource()
        {
            Console.WriteLine("Using resource...");
        }

        public void Dispose()
        {
            Console.WriteLine("Resource cleaned.");
        }
    }

    class Program
    {
        static List<Person> people = new List<Person>();

        static void Main()
        {
            Console.WriteLine("TASK 1:");
            Console.WriteLine("Memory management means controlling how a program stores, uses, and releases memory.");
            Console.WriteLine("A C# program uses memory for variables, objects, arrays, strings, and collections.");
            Console.WriteLine("Memory management is important because it improves speed, stability, and performance.");

            Console.WriteLine("\nTASK 2:");
            Console.WriteLine("The Stack stores local variables, method parameters, and value types.");
            Console.WriteLine("Example: int age = 25;");

            Console.WriteLine("\nTASK 3:");
            Console.WriteLine("The Heap stores objects, arrays, strings, and collections.");
            Console.WriteLine("Example: Person person = new Person(\"Peyman\");");

            Console.WriteLine("\nTASK 4:");
            Console.WriteLine("Value types store actual values directly.");
            Console.WriteLine("Examples: int, double, bool.");
            Console.WriteLine("Reference types store memory references to objects.");
            Console.WriteLine("Examples: class, string, array.");

            Console.WriteLine("\nTASK 5:");
            Person person1 = new Person("Peyman");
            Person person2 = person1;

            person2.Name = "Nova";

            Console.WriteLine($"Person1 Name: {person1.Name}");
            Console.WriteLine($"Person2 Name: {person2.Name}");

            Console.WriteLine("\nTASK 6:");
            Person temporaryPerson = new Person("Temporary User");
            Console.WriteLine($"Created object: {temporaryPerson.Name}");
            temporaryPerson = null;
            Console.WriteLine("The reference was set to null.");
            Console.WriteLine("If no other reference exists, the object becomes eligible for Garbage Collection.");

            Console.WriteLine("\nTASK 7:");
            long memoryBefore = GC.GetTotalMemory(false);

            List<int> numbers = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                numbers.Add(i);
            }

            long memoryAfter = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory before: {memoryBefore:N0} bytes");
            Console.WriteLine($"Memory after : {memoryAfter:N0} bytes");

            Console.WriteLine("\nTASK 8:");
            int number = 100;
            object boxedNumber = number;
            int unboxedNumber = (int)boxedNumber;

            Console.WriteLine($"Unboxed number: {unboxedNumber}");

            Console.WriteLine("\nTASK 9:");
            StringBuilder builder = new StringBuilder();

            builder.Append("Hello ");
            builder.Append("C# ");
            builder.Append("Memory");

            Console.WriteLine(builder.ToString());
            Console.WriteLine("StringBuilder is useful because it reduces unnecessary string allocations.");

            Console.WriteLine("\nTASK 10:");
            using (ResourceManager manager = new ResourceManager())
            {
                manager.UseResource();
            }

            Console.WriteLine("\nTASK 11:");
            people.Add(new Person("Static Reference Example"));
            Console.WriteLine("Memory leaks can still happen in C# when objects remain referenced forever.");
            Console.WriteLine("GC only removes unreachable objects.");
            Console.WriteLine("A static list can keep objects alive and prevent Garbage Collection.");

            Console.WriteLine("\nTASK 12:");
            Console.WriteLine("Memory Management Best Practices:");
            Console.WriteLine("1. Let Garbage Collection manage memory naturally.");
            Console.WriteLine("2. Use IDisposable for unmanaged resources.");
            Console.WriteLine("3. Use using statements with disposable objects.");
            Console.WriteLine("4. Avoid unnecessary object allocations.");
            Console.WriteLine("5. Use StringBuilder for frequent string modifications.");
            Console.WriteLine("6. Remove references when objects are no longer needed.");
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
