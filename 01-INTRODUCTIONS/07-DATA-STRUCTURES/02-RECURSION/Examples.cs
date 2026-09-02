/*
 * ============================================================
 * File: Examples.cs
 * Path: 07-DATA-STRUCTURES/02-RECURSION/Examples.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace RecursionExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== RECURSION EXAMPLES ===");
            Console.WriteLine();

            Example1_Factorial();
            Example2_Fibonacci();
            Example3_Countdown();
            Example4_SumToN();
            Example5_Power();

            Console.WriteLine();
            Console.WriteLine("End of examples.");
        }

        // ============================================================
        // EXAMPLE 1: FACTORIAL
        // ============================================================

        public static void Example1_Factorial()
        {
            Console.WriteLine("Example 1: Recursive Factorial");

            int number = 5;
            long result = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} = {result}");
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
        // EXAMPLE 2: FIBONACCI
        // ============================================================

        public static void Example2_Fibonacci()
        {
            Console.WriteLine("Example 2: Recursive Fibonacci");

            int terms = 8;

            Console.Write("Sequence: ");

            for (int i = 0; i < terms; i++)
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
        // EXAMPLE 3: COUNTDOWN
        // ============================================================

        public static void Example3_Countdown()
        {
            Console.WriteLine("Example 3: Countdown");

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
        // EXAMPLE 4: SUM FROM 1 TO N
        // ============================================================

        public static void Example4_SumToN()
        {
            Console.WriteLine("Example 4: Sum From 1 To N");

            int number = 5;

            Console.WriteLine($"SumTo({number}) = {SumTo(number)}");

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
        // EXAMPLE 5: POWER FUNCTION
        // ============================================================

        public static void Example5_Power()
        {
            Console.WriteLine("Example 5: Power Function");

            int baseNumber = 2;
            int exponent = 4;

            Console.WriteLine($"{baseNumber}^{exponent} = {Power(baseNumber, exponent)}");

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
    }
}
