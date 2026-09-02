/*
 * ============================================================
 * File: Notes.cs
 * Path: 07-DATA-STRUCTURES/02-RECURSION/Notes.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace RecursionNotes
{
    /*
     * ============================================================
     * RECURSION
     * ============================================================
     *
     * Recursion is a programming technique in which
     * a method calls itself to solve a problem.
     *
     * Instead of solving the entire problem at once,
     * it breaks the problem into smaller versions
     * of the same problem.
     */


    /*
     * ============================================================
     * PARTS OF A RECURSIVE METHOD
     * ============================================================
     *
     * Every recursive method must have:
     *
     * 1. Base Case
     * 2. Recursive Case
     */


    /*
     * ============================================================
     * BASE CASE
     * ============================================================
     *
     * The base case stops the recursion.
     *
     * Without a base case, the method would
     * continue calling itself forever.
     *
     * Example:
     *
     *     if (n <= 1)
     *     {
     *         return 1;
     *     }
     */


    /*
     * ============================================================
     * RECURSIVE CASE
     * ============================================================
     *
     * The recursive case is where the method
     * calls itself again.
     *
     * Each recursive call should move closer
     * to the base case.
     *
     * Example:
     *
     *     return n * CalculateFactorial(n - 1);
     */


    /*
     * ============================================================
     * STACK OVERFLOW
     * ============================================================
     *
     * Stack Overflow happens when recursion
     * never stops.
     *
     * This usually occurs when the base case
     * is missing or incorrect.
     */


    /*
     * ============================================================
     * FACTORIAL
     * ============================================================
     *
     * The factorial of a number n is written as n!.
     *
     * It means multiplying all positive integers
     * from n down to 1.
     *
     * Examples:
     *
     *     5! = 5 × 4 × 3 × 2 × 1 = 120
     *     4! = 24
     *     3! = 6
     *
     * Recursive Formula:
     *
     *     n! = n × (n - 1)!
     *
     * Base Cases:
     *
     *     0! = 1
     *     1! = 1
     */


    /*
     * ============================================================
     * FACTORIAL STEP BY STEP
     * ============================================================
     *
     * CalculateFactorial(5)
     *
     * = 5 × CalculateFactorial(4)
     * = 5 × 4 × CalculateFactorial(3)
     * = 5 × 4 × 3 × CalculateFactorial(2)
     * = 5 × 4 × 3 × 2 × CalculateFactorial(1)
     * = 5 × 4 × 3 × 2 × 1
     * = 120
     *
     * Then the recursion "unwinds" and returns
     * the final result.
     */


    /*
     * ============================================================
     * FIBONACCI SEQUENCE
     * ============================================================
     *
     * The Fibonacci sequence starts with:
     *
     *     0, 1, 1, 2, 3, 5, 8, 13...
     *
     * Each number is the sum of the previous two.
     *
     * Recursive Formula:
     *
     *     Fibonacci(n) =
     *     Fibonacci(n - 1) + Fibonacci(n - 2)
     *
     * Base Cases:
     *
     *     Fibonacci(0) = 0
     *     Fibonacci(1) = 1
     */


    /*
     * ============================================================
     * RECURSIVE THINKING
     * ============================================================
     *
     * To solve a problem recursively:
     *
     * 1. Identify the base case.
     * 2. Break the problem into a smaller version.
     * 3. Move toward the base case.
     * 4. Combine the results.
     */


    /*
     * ============================================================
     * WHEN TO USE RECURSION
     * ============================================================
     *
     * Recursion is useful for:
     *
     *     • Factorials
     *     • Fibonacci sequences
     *     • Tree traversal
     *     • Folder traversal
     *     • Divide-and-conquer algorithms
     */


    /*
     * ============================================================
     * KEY TAKEAWAYS
     * ============================================================
     *
     * • Recursion means a method calls itself.
     *
     * • Every recursive method needs
     *   a base case.
     *
     * • Every recursive method needs
     *   a recursive case.
     *
     * • The base case stops recursion.
     *
     * • The recursive case moves the problem
     *   closer to the base case.
     *
     * • Missing a base case can cause
     *   a Stack Overflow error.
     *
     * • Factorial and Fibonacci are classic
     *   recursion examples.
     */
}
