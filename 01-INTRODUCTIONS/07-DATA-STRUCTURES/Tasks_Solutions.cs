using System;

namespace AlgorithmsTaskSolutions
{
    internal class Tasks_Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ALGORITHMS TASK SOLUTIONS =====\n");

            Task1_GreetUser();
            Task2_AddTwoNumbers();
            Task3_EvenOrOdd();
            Task4_CalculateAverage();
            Task5_FindLargerNumber();

            Console.WriteLine("\nAll task solutions completed.");
        }

        // ==================================================
        // TASK 1 SOLUTION
        // ==================================================
        static void Task1_GreetUser()
        {
            Console.WriteLine("TASK 1: Greeting User");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to Algorithms.");

            Console.WriteLine();
        }

        // ==================================================
        // TASK 2 SOLUTION
        // ==================================================
        static void Task2_AddTwoNumbers()
        {
            Console.WriteLine("TASK 2: Add Two Numbers");

            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine($"Result: {number1} + {number2} = {sum}");

            Console.WriteLine();
        }

        // ==================================================
        // TASK 3 SOLUTION
        // ==================================================
        static void Task3_EvenOrOdd()
        {
            Console.WriteLine("TASK 3: Even or Odd");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

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

        // ==================================================
        // TASK 4 SOLUTION
        // ==================================================
        static void Task4_CalculateAverage()
        {
            Console.WriteLine("TASK 4: Calculate Average");

            Console.Write("Enter grade 1: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 2: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 3: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            double average = (grade1 + grade2 + grade3) / 3;

            Console.WriteLine($"Average: {average:F2}");

            Console.WriteLine();
        }

        // ==================================================
        // TASK 5 SOLUTION
        // ==================================================
        static void Task5_FindLargerNumber()
        {
            Console.WriteLine("TASK 5: Find the Larger Number");

            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is larger.");
            }
            else if (number2 > number1)
            {
                Console.WriteLine($"{number2} is larger.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

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
