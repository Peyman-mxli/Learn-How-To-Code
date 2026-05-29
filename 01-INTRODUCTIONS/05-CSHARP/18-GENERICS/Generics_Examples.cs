```csharp
using System;
using System.Collections.Generic;

namespace GenericsExamples
{
    // Generic Class Example
    class Box<T>
    {
        public T Value { get; set; }

        public void DisplayValue()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }

    // Multiple Generic Types Example
    class DataPair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public void DisplayPair()
        {
            Console.WriteLine($"Key: {Key} | Value: {Value}");
        }
    }

    class Program
    {
        // Generic Method Example
        static void PrintValue<T>(T value)
        {
            Console.WriteLine($"Generic Value: {value}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("GENERIC CLASS EXAMPLE");
            Console.WriteLine("=================================");

            Box<int> numberBox = new Box<int>();
            numberBox.Value = 100;
            numberBox.DisplayValue();

            Box<string> textBox = new Box<string>();
            textBox.Value = "Hello Generics";
            textBox.DisplayValue();

            Box<double> decimalBox = new Box<double>();
            decimalBox.Value = 99.99;
            decimalBox.DisplayValue();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("GENERIC METHOD EXAMPLE");
            Console.WriteLine("=================================");

            PrintValue(500);
            PrintValue("Peyman");
            PrintValue(true);
            PrintValue(25.75);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("MULTIPLE GENERIC TYPES");
            Console.WriteLine("=================================");

            DataPair<int, string> student =
                new DataPair<int, string>();

            student.Key = 1;
            student.Value = "Peyman";

            student.DisplayPair();

            DataPair<string, double> product =
                new DataPair<string, double>();

            product.Key = "Laptop";
            product.Value = 1499.99;

            product.DisplayPair();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("LIST<T> EXAMPLE");
            Console.WriteLine("=================================");

            List<string> names = new List<string>();

            names.Add("Peyman");
            names.Add("Sarah");
            names.Add("John");
            names.Add("David");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("DICTIONARY<TKey, TValue>");
            Console.WriteLine("=================================");

            Dictionary<int, string> students =
                new Dictionary<int, string>();

            students.Add(1, "Peyman");
            students.Add(2, "Sarah");
            students.Add(3, "David");

            foreach (var studentData in students)
            {
                Console.WriteLine(
                    $"ID: {studentData.Key} | Name: {studentData.Value}");
            }

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("QUEUE<T> EXAMPLE");
            Console.WriteLine("=================================");

            Queue<string> tickets =
                new Queue<string>();

            tickets.Enqueue("Ticket A");
            tickets.Enqueue("Ticket B");
            tickets.Enqueue("Ticket C");

            Console.WriteLine(
                $"Serving: {tickets.Dequeue()}");

            Console.WriteLine(
                $"Serving: {tickets.Dequeue()}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("STACK<T> EXAMPLE");
            Console.WriteLine("=================================");

            Stack<string> actions =
                new Stack<string>();

            actions.Push("Open File");
            actions.Push("Edit File");
            actions.Push("Save File");

            Console.WriteLine(
                $"Undo: {actions.Pop()}");

            Console.WriteLine(
                $"Undo: {actions.Pop()}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("HASHSET<T> EXAMPLE");
            Console.WriteLine("=================================");

            HashSet<int> numbers =
                new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(10);
            numbers.Add(20);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("TYPE SAFETY EXAMPLE");
            Console.WriteLine("=================================");

            List<int> scores = new List<int>();

            scores.Add(100);
            scores.Add(90);
            scores.Add(80);

            foreach (int score in scores)
            {
                Console.WriteLine($"Score: {score}");
            }

            Console.WriteLine();

            Console.WriteLine("Generics Examples Completed!");
        }
    }
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
