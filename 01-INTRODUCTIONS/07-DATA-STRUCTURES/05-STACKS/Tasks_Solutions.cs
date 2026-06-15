/*
=========================================================
TASKS_SOLUTIONS.CS
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

namespace StacksTasksSolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("=== STACKS TASKS SOLUTIONS ===");
                Console.WriteLine("1. Exercise 1: Basic Book Management");
                Console.WriteLine("2. Exercise 2: Checking If a Stack Is Empty");
                Console.WriteLine("3. Exercise 3: String Reversal and Palindrome Check");
                Console.WriteLine("4. Exit");

                Console.Write("\nChoose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Exercise1_BookManagement();
                        break;

                    case "2":
                        Exercise2_CheckEmptyStack();
                        break;

                    case "3":
                        Exercise3_PalindromeCheck();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option.");
                        Pause();
                        break;
                }
            }
        }

        /*
        =========================================================
        EXERCISE 1 SOLUTION
        =========================================================
        */

        public static void Exercise1_BookManagement()
        {
            Console.Clear();

            Console.WriteLine("=== EXERCISE 1: BASIC BOOK MANAGEMENT ===\n");

            Stack<string> books = new Stack<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter the title of book {i}: ");
                string title = Console.ReadLine();

                books.Push(title);
            }

            Console.WriteLine("\nBooks removed from the stack:");
            Console.WriteLine("(Last entered → First removed)\n");

            while (books.Count > 0)
            {
                Console.WriteLine(books.Pop());
            }

            Pause();
        }

        /*
        =========================================================
        EXERCISE 2 SOLUTION
        =========================================================
        */

        public static void Exercise2_CheckEmptyStack()
        {
            Console.Clear();

            Console.WriteLine("=== EXERCISE 2: CHECKING IF A STACK IS EMPTY ===\n");

            Stack<int> numbers = new Stack<int>();

            Console.Write("How many numbers would you like to add? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                numbers.Push(number);
            }

            Console.WriteLine("\nRemoving elements safely:\n");

            while (numbers.Count > 0)
            {
                Console.WriteLine($"Next element to remove (Peek): {numbers.Peek()}");

                int removed = numbers.Pop();

                Console.WriteLine($"Removed element: {removed}");
                Console.WriteLine();
            }

            Console.WriteLine("The stack is now empty.");

            Pause();
        }

        /*
        =========================================================
        EXERCISE 3 SOLUTION
        =========================================================
        */

        public static void Exercise3_PalindromeCheck()
        {
            Console.Clear();

            Console.WriteLine("=== EXERCISE 3: STRING REVERSAL AND PALINDROME CHECK ===\n");

            Stack<char> characters = new Stack<char>();

            Console.Write("Enter a word or phrase: ");
            string originalText = Console.ReadLine();

            foreach (char character in originalText)
            {
                characters.Push(character);
            }

            string reversedText = "";

            while (characters.Count > 0)
            {
                reversedText += characters.Pop();
            }

            Console.WriteLine($"\nReversed text: {reversedText}");

            string normalizedOriginal =
                originalText.Replace(" ", "").ToLower();

            string normalizedReversed =
                reversedText.Replace(" ", "").ToLower();

            if (normalizedOriginal == normalizedReversed)
            {
                Console.WriteLine("Result: It is a palindrome.");
            }
            else
            {
                Console.WriteLine("Result: It is NOT a palindrome.");
            }

            Pause();
        }

        /*
        =========================================================
        HELPER METHOD
        =========================================================
        */

        public static void Pause()
        {
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
    }
}
