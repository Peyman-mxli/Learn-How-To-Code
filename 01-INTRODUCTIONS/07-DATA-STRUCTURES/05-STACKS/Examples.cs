/*
=========================================================
EXAMPLES.CS
Module: 07-DATA-STRUCTURES
Topic: 05-STACKS
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;
using System.Collections.Generic;

namespace StacksExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Example1_StackOfNumbers();

            Console.WriteLine("\nPress ENTER for Example 2...");
            Console.ReadLine();

            Example2_StackOfFruits();

            Console.WriteLine("\nEnd of stack examples.");
        }

        public static void Example1_StackOfNumbers()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 1: STACK OF NUMBERS ===\n");

            Stack<int> numbersStack = new Stack<int>();

            Console.WriteLine("Adding elements to the stack: 10, 20, 30");

            numbersStack.Push(10);
            numbersStack.Push(20);
            numbersStack.Push(30);

            Console.WriteLine($"\nTop element using Peek(): {numbersStack.Peek()}");

            Console.WriteLine("\nRemoving elements using Pop():");

            int firstRemoved = numbersStack.Pop();
            Console.WriteLine($"Removed element: {firstRemoved}");

            int secondRemoved = numbersStack.Pop();
            Console.WriteLine($"Removed element: {secondRemoved}");

            Console.WriteLine($"\nIs the stack empty? {numbersStack.Count == 0}");

            numbersStack.Pop();

            Console.WriteLine($"Is the stack empty now? {numbersStack.Count == 0}");
        }

        public static void Example2_StackOfFruits()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 2: STACK OF FRUITS ===\n");

            Stack<string> fruitsStack = new Stack<string>();

            fruitsStack.Push("Apple");
            fruitsStack.Push("Banana");
            fruitsStack.Push("Orange");

            Console.WriteLine("Stack elements:");

            foreach (string fruit in fruitsStack)
            {
                Console.WriteLine("- " + fruit);
            }

            Console.WriteLine("\nTop element: " + fruitsStack.Peek());

            string removedFruit = fruitsStack.Pop();
            Console.WriteLine("\nRemoved element: " + removedFruit);

            Console.WriteLine("New top element: " + fruitsStack.Peek());

            Console.WriteLine("\nIs the stack empty? " + (fruitsStack.Count == 0));

            fruitsStack.Clear();

            Console.WriteLine("Stack cleared. Is the stack empty now? " + (fruitsStack.Count == 0));
        }
    }
}
