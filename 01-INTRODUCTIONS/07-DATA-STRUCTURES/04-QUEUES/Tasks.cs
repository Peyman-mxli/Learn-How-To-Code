/*
=========================================================
TASKS.CS
Module: 07-DATA-STRUCTURES
Topic: 04-QUEUES
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;

namespace QueuesTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            =================================================
            EXERCISE 1: STORE NUMBERS
            =================================================

            Objective:
            Ask the user for 5 integer numbers, store them in
            a queue, and then display them in the same order
            they were entered.

            Instructions:

            1. Create a queue to store int values using Queue<int>.
            2. Use a for loop to ask the user for 5 numbers.
            3. Inside the loop, read the number from the user.
            4. Add the number to the queue using Enqueue().
            5. After the loop, use a while loop.
            6. The while loop must run while the queue is not empty.
            7. Inside the while loop, display the result of Dequeue().

            Expected behavior:

            Input:
            10
            20
            30
            40
            50

            Output:
            10
            20
            30
            40
            50
            */

            /*
            =================================================
            EXERCISE 2: PHRASE MANAGEMENT
            =================================================

            Objective:
            Allow the user to write phrases until they enter
            an empty phrase. Then display all entered phrases.

            Instructions:

            1. Create a queue to store string values using Queue<string>.
            2. Use a while loop with the condition true.
            3. Ask the user to enter a phrase.
            4. Read the user input.
            5. If the input is an empty string, use break.
            6. Otherwise, add the phrase to the queue using Enqueue().
            7. After the while loop, use foreach to display each phrase.

            Expected behavior:

            Input:
            Hello world
            I am learning queues
            FIFO is easy

            Output:
            Hello world
            I am learning queues
            FIFO is easy
            */

            /*
            =================================================
            EXERCISE 3: CUSTOMER SERVICE SIMULATION
            =================================================

            Objective:
            Simulate a customer service line using a queue.
            Customers are added to the end of the line, and the
            first customer in the line is attended first.

            Instructions:

            1. Create a queue of type string to represent customers.
            2. Create a simple menu with these options:

               1. Add customer
               2. Attend next customer
               3. Show next customer
               4. Show total customers
               5. Exit

            3. In "Add customer":
               - Ask for the customer's name.
               - Use Enqueue() to add the customer to the queue.

            4. In "Attend next customer":
               - Check if the queue is empty.
               - If it is not empty, use Dequeue().
               - Display the customer who was attended.
               - If it is empty, display a message.

            5. In "Show next customer":
               - Check if the queue is empty.
               - If it is not empty, use Peek().
               - Display the next customer without removing them.

            6. In "Show total customers":
               - Display the value of Count.

            7. In "Exit":
               - End the program.

            Important:
            Never use Dequeue() or Peek() when the queue is empty.

            */

            Console.WriteLine("Queues Tasks");
            Console.WriteLine("Complete the exercises above.");
        }
    }
}
