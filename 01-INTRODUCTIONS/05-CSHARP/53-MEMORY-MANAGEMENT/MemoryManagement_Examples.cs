```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryManagementExamples
{
    public class Person
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

    public class FileManager : IDisposable
    {
        public void OpenFile()
        {
            Console.WriteLine("File opened.");
        }

        public void Dispose()
        {
            Console.WriteLine("File resource released.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("MEMORY MANAGEMENT EXAMPLES");
            Console.WriteLine("========================================");

            Example1_ValueType();
            Example2_ReferenceType();
            Example3_ObjectLifetime();
            Example4_MemoryUsage();
            Example5_BoxingUnboxing();
            Example6_StringBuilder();
            Example7_IDisposable();

            Console.WriteLine("\nAll examples completed.");
        }

        // ----------------------------------------------------
        // Example 1
        // Value Type
        // ----------------------------------------------------
        static void Example1_ValueType()
        {
            Console.WriteLine("\nEXAMPLE 1 - Value Type");

            int number1 = 10;
            int number2 = number1;

            number2 = 50;

            Console.WriteLine($"Number1: {number1}");
            Console.WriteLine($"Number2: {number2}");

            Console.WriteLine("Value types create independent copies.");
        }

        // ----------------------------------------------------
        // Example 2
        // Reference Type
        // ----------------------------------------------------
        static void Example2_ReferenceType()
        {
            Console.WriteLine("\nEXAMPLE 2 - Reference Type");

            Person person1 = new Person("Peyman");

            Person person2 = person1;

            person2.Name = "Nova";

            Console.WriteLine($"Person1 Name: {person1.Name}");
            Console.WriteLine($"Person2 Name: {person2.Name}");

            Console.WriteLine("Both variables reference the same object.");
        }

        // ----------------------------------------------------
        // Example 3
        // Object Lifetime
        // ----------------------------------------------------
        static void Example3_ObjectLifetime()
        {
            Console.WriteLine("\nEXAMPLE 3 - Object Lifetime");

            Person person = new Person("Temporary User");

            person = null;

            Console.WriteLine("Reference removed.");
            Console.WriteLine("Object is now eligible for Garbage Collection.");
        }

        // ----------------------------------------------------
        // Example 4
        // Memory Usage
        // ----------------------------------------------------
        static void Example4_MemoryUsage()
        {
            Console.WriteLine("\nEXAMPLE 4 - Memory Usage");

            long memoryBefore = GC.GetTotalMemory(false);

            List<int> numbers = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                numbers.Add(i);
            }

            long memoryAfter = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory Before: {memoryBefore:N0} bytes");
            Console.WriteLine($"Memory After : {memoryAfter:N0} bytes");
        }

        // ----------------------------------------------------
        // Example 5
        // Boxing and Unboxing
        // ----------------------------------------------------
        static void Example5_BoxingUnboxing()
        {
            Console.WriteLine("\nEXAMPLE 5 - Boxing and Unboxing");

            int number = 100;

            object boxedNumber = number;

            int unboxedNumber = (int)boxedNumber;

            Console.WriteLine($"Original Number: {number}");
            Console.WriteLine($"Unboxed Number : {unboxedNumber}");
        }

        // ----------------------------------------------------
        // Example 6
        // StringBuilder
        // ----------------------------------------------------
        static void Example6_StringBuilder()
        {
            Console.WriteLine("\nEXAMPLE 6 - StringBuilder");

            StringBuilder builder = new StringBuilder();

            builder.Append("Hello ");
            builder.Append("Peyman ");
            builder.Append("Welcome!");

            Console.WriteLine(builder.ToString());

            Console.WriteLine("StringBuilder reduces unnecessary string allocations.");
        }

        // ----------------------------------------------------
        // Example 7
        // IDisposable
        // ----------------------------------------------------
        static void Example7_IDisposable()
        {
            Console.WriteLine("\nEXAMPLE 7 - IDisposable");

            using (FileManager manager = new FileManager())
            {
                manager.OpenFile();
            }

            Console.WriteLine("Dispose() executed automatically.");
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
