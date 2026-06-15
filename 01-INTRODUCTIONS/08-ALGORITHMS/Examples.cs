using System;

namespace AlgorithmsExamples
{
    internal class Examples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ALGORITHM EXAMPLES =====\n");

            Example1_GreetUser();
            Example2_AddTwoNumbers();
            Example3_FindLargestNumber();
            Example4_EvenOrOdd();
            Example5_CalculateAverage();

            Console.WriteLine("\nAll examples completed.");
        }

        // Example 1
        static void Example1_GreetUser()
        {
            Console.WriteLine("EXAMPLE 1: Greeting Algorithm");

            string name = "Peyman";

            Console.WriteLine("Hello, " + name + "!");

            Console.WriteLine();
        }

        // Example 2
        static void Example2_AddTwoNumbers()
        {
            Console.WriteLine("EXAMPLE 2: Add Two Numbers");

            int number1 = 15;
            int number2 = 25;

            int sum = number1 + number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");

            Console.WriteLine();
        }

        // Example 3
        static void Example3_FindLargestNumber()
        {
            Console.WriteLine("EXAMPLE 3: Find the Largest Number");

            int a = 18;
            int b = 42;

            if (a > b)
            {
                Console.WriteLine($"{a} is the largest number.");
            }
            else
            {
                Console.WriteLine($"{b} is the largest number.");
            }

            Console.WriteLine();
        }

        // Example 4
        static void Example4_EvenOrOdd()
        {
            Console.WriteLine("EXAMPLE 4: Even or Odd");

            int number = 17;

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }

            Console.WriteLine();
        }

        // Example 5
        static void Example5_CalculateAverage()
        {
            Console.WriteLine("EXAMPLE 5: Calculate Average");

            int grade1 = 90;
            int grade2 = 85;
            int grade3 = 95;

            double average = (grade1 + grade2 + grade3) / 3.0;

            Console.WriteLine($"Grades: {grade1}, {grade2}, {grade3}");
            Console.WriteLine($"Average: {average:F2}");

            Console.WriteLine();
        }
    }
}

/*
==========================================================
AUTHOR
==========================================================

Name: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
*/
