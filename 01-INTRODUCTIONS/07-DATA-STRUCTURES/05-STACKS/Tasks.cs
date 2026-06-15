/*
=========================================================
TASKS.CS
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

namespace StacksTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            =================================================
            EXERCISE 1: BASIC BOOK MANAGEMENT
            =================================================

            Objective:
            Practice the main stack operations: Push() and Pop().

            Description:
            Simulate a stack of books.

            Ask the user to enter the titles of five books.
            Store the titles in a stack.
            Then display the books in reverse order, from the
            last book entered to the first book entered.

            Instructions:

            1. Create a stack of strings using Stack<string>.
            2. Ask the user to enter 5 book titles.
            3. Use Push() to add each book to the stack.
            4. Use a while loop while the stack is not empty.
            5. Use Pop() to remove and display each book.

            Concepts:
            Stack<string>, Push(), Pop(), loops.
            */

            /*
            =================================================
            EXERCISE 2: CHECKING IF A STACK IS EMPTY
            =================================================

            Objective:
            Use Peek() and Count to safely manage a stack.

            Description:
            Create a stack of integer numbers.
            Allow the user to add numbers.
            Then remove elements from the stack one by one,
            but only if the stack is not empty.

            Before each Pop(), use Peek() to show which element
            will be removed next.

            Stop the operation when the stack is empty.

            Instructions:

            1. Create a stack of integers using Stack<int>.
            2. Ask the user how many numbers they want to add.
            3. Use a loop to read and Push() each number.
            4. Use while (stack.Count > 0).
            5. Inside the loop:
               - Use Peek() to show the next number to remove.
               - Use Pop() to remove it.
            6. When Count == 0, display that the stack is empty.

            Concepts:
            Stack<int>, Peek(), Pop(), Count.
            */

            /*
            =================================================
            EXERCISE 3: STRING REVERSAL AND PALINDROME CHECK
            =================================================

            Objective:
            Apply the LIFO principle to reverse data.

            Description:
            Ask the user to enter a word or phrase.
            Use a stack to store each character.
            Then remove each character from the stack to build
            the reversed string.

            As an extra challenge, check if the original text
            is a palindrome.

            A palindrome is a word or phrase that reads the same
            forward and backward.

            Examples:

            radar  → palindrome
            level  → palindrome
            hello  → not palindrome

            Instructions:

            1. Ask the user to enter a word or phrase.
            2. Create a stack of characters using Stack<char>.
            3. Use a foreach loop to Push() each character.
            4. Create an empty string called reversedText.
            5. Use while (stack.Count > 0).
            6. Add each Pop() result to reversedText.
            7. Display the reversed text.
            8. Compare the original text with the reversed text.
            9. Display whether it is a palindrome.

            Concepts:
            Stack<char>, loops, string manipulation, comparison.
            */

            Console.WriteLine("Stacks Tasks");
            Console.WriteLine("Complete the exercises above.");
        }
    }
}
