/*
=========================================
33 - OVERLOADING
Overloading_Examples.cs
=========================================
*/

using System;

namespace OverloadingExamples
{
    class Calculator
    {
        // Overload #1
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overload #2
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overload #3
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Person
    {
        public string Name;
        public int Age;

        // Constructor Overload #1
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Constructor Overload #2
        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        // Constructor Overload #3
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }

    class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void Print(int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        public void Print(double number)
        {
            Console.WriteLine($"Double: {number}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("METHOD OVERLOADING");
            Console.WriteLine("=================================");

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(5, 3));
            Console.WriteLine(calculator.Add(5, 3, 2));
            Console.WriteLine(calculator.Add(5.5, 2.5));

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("CONSTRUCTOR OVERLOADING");
            Console.WriteLine("=================================");

            Person person1 = new Person();
            Person person2 = new Person("Peyman");
            Person person3 = new Person("Peyman", 25);

            person1.Display();

            Console.WriteLine();

            person2.Display();

            Console.WriteLine();

            person3.Display();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("PARAMETER TYPE OVERLOADING");
            Console.WriteLine("=================================");

            Printer printer = new Printer();

            printer.Print("Hello World");
            printer.Print(100);
            printer.Print(99.99);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("OVERLOADING COMPLETE");
            Console.WriteLine("=================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
