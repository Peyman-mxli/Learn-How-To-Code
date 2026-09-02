/*
 * ============================================================
 * File: Tasks_Solutions.cs
 * Path: 07-DATA-STRUCTURES/02-RECURSION/Tasks_Solutions.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace RecursionTaskSolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== RECURSION TASK SOLUTIONS ===");
            Console.WriteLine();

            Task1_RangeSum();
            Task2_Factorial();
            Task3_Fibonacci();
            Task4_Countdown();
            Task5_Power();
            Task6_SumTo();
            Task7_ConceptQuestions();
            ChallengeTask();

            Console.WriteLine();
            Console.WriteLine("End of task solutions.");
        }

        // ============================================================
        // TASK 1: RECURSIVE RANGE SUM
        // ============================================================

        public static void Task1_RangeSum()
        {
            Console.WriteLine("Task 1: Recursive Range Sum");

            int start = 1;
            int end = 10;

            Console.WriteLine($"Sum from {start} to {end}: {RangeSum(start, end)}");

            Console.WriteLine();
        }

        public static int RangeSum(int start, int end)
        {
            if (start == end)
            {
                return start;
            }

            return start + RangeSum(start + 1, end);
        }

        // ============================================================
        // TASK 2: FACTORIAL
        // ============================================================

        public static void Task2_Factorial()
        {
            Console.WriteLine("Task 2: Factorial");

            int number = 5;

            Console.WriteLine($"Factorial of {number}: {CalculateFactorial(number)}");

            Console.WriteLine();
        }

        public static long CalculateFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }

        // ============================================================
        // TASK 3: FIBONACCI
        // ============================================================

        public static void Task3_Fibonacci()
        {
            Console.WriteLine("Task 3: Fibonacci");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(GetFibonacci(i) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static int GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        // ============================================================
        // TASK 4: COUNTDOWN
        // ============================================================

        public static void Task4_Countdown()
        {
            Console.WriteLine("Task 4: Countdown");

            Countdown(5);

            Console.WriteLine();
        }

        public static void Countdown(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Liftoff!");
                return;
            }

            Console.WriteLine(n);

            Countdown(n - 1);
        }

        // ============================================================
        // TASK 5: POWER FUNCTION
        // ============================================================

        public static void Task5_Power()
        {
            Console.WriteLine("Task 5: Power Function");

            Console.WriteLine($"2^4 = {Power(2, 4)}");

            Console.WriteLine();
        }

        public static int Power(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return number * Power(number, exponent - 1);
        }

        // ============================================================
        // TASK 6: SUM FROM 1 TO N
        // ============================================================

        public static void Task6_SumTo()
        {
            Console.WriteLine("Task 6: Sum From 1 To N");

            Console.WriteLine($"SumTo(5) = {SumTo(5)}");

            Console.WriteLine();
        }

        public static int SumTo(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + SumTo(n - 1);
        }

        // ============================================================
        // TASK 7: CONCEPT QUESTIONS
        // ============================================================

        public static void Task7_ConceptQuestions()
        {
            Console.WriteLine("Task 7: Concept Questions");
            Console.WriteLine();

            Console.WriteLine("1. What is recursion?");
            Console.WriteLine("A method calling itself to solve a problem.");
            Console.WriteLine();

            Console.WriteLine("2. What is a base case?");
            Console.WriteLine("The condition that stops recursion.");
            Console.WriteLine();

            Console.WriteLine("3. What is a recursive case?");
            Console.WriteLine("The part where the method calls itself.");
            Console.WriteLine();

            Console.WriteLine("4. Why is the base case important?");
            Console.WriteLine("It prevents infinite recursion.");
            Console.WriteLine();

            Console.WriteLine("5. What is Stack Overflow?");
            Console.WriteLine("An error caused by too many recursive calls.");
            Console.WriteLine();

            Console.WriteLine("6. What happens if recursion never reaches the base case?");
            Console.WriteLine("The program eventually crashes with Stack Overflow.");
            Console.WriteLine();

            Console.WriteLine("7. Name two examples of recursion.");
            Console.WriteLine("Factorial and Fibonacci.");
            Console.WriteLine();

            Console.WriteLine("8. Which Fibonacci values are the base cases?");
            Console.WriteLine("Fibonacci(0) and Fibonacci(1).");
            Console.WriteLine();

            Console.WriteLine("9. Which factorial values are the base cases?");
            Console.WriteLine("0! and 1!.");
            Console.WriteLine();

            Console.WriteLine("10. When should recursion be used?");
            Console.WriteLine("When a problem can be divided into smaller versions of itself.");
            Console.WriteLine();
        }

        // ============================================================
        // CHALLENGE TASK
        // ============================================================

        public static void ChallengeTask()
        {
            Console.WriteLine("Challenge Task: Reverse a String");

            string word = "HELLO";

            Console.WriteLine($"Original: {word}");
            Console.WriteLine($"Reversed: {Reverse(word)}");

            Console.WriteLine();
        }

        public static string Reverse(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }

            return Reverse(text.Substring(1)) + text[0];
        }
    }
}
