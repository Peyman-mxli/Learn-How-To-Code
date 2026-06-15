/*
=========================================================
TASKS_SOLUTIONS.CS
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
using System.Collections.Generic;

namespace QueuesTasksSolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("=== QUEUES TASKS SOLUTIONS ===");
                Console.WriteLine("1. Exercise 1: Store Numbers");
                Console.WriteLine("2. Exercise 2: Phrase Management");
                Console.WriteLine("3. Exercise 3: Customer Service Simulation");
                Console.WriteLine("4. Exit");
                Console.Write("\nChoose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Exercise1_StoreNumbers();
                        break;

                    case "2":
                        Exercise2_PhraseManagement();
                        break;

                    case "3":
                        Exercise3_CustomerServiceSimulation();
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

        public static void Exercise1_StoreNumbers()
        {
            Console.Clear();
            Console.WriteLine("=== EXERCISE 1: STORE NUMBERS ===\n");

            Queue<int> numbers = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                numbers.Enqueue(number);
            }

            Console.WriteLine("\nNumbers in the same order they were entered:");

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }

            Pause();
        }

        public static void Exercise2_PhraseManagement()
        {
            Console.Clear();
            Console.WriteLine("=== EXERCISE 2: PHRASE MANAGEMENT ===\n");

            Queue<string> phrases = new Queue<string>();

            while (true)
            {
                Console.Write("Enter a phrase, or press ENTER to finish: ");
                string phrase = Console.ReadLine();

                if (phrase == "")
                {
                    break;
                }

                phrases.Enqueue(phrase);
            }

            Console.WriteLine("\nPhrases entered:");

            foreach (string phrase in phrases)
            {
                Console.WriteLine(phrase);
            }

            Pause();
        }

        public static void Exercise3_CustomerServiceSimulation()
        {
            Queue<string> customers = new Queue<string>();
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("=== EXERCISE 3: CUSTOMER SERVICE SIMULATION ===");
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. Attend next customer");
                Console.WriteLine("3. Show next customer");
                Console.WriteLine("4. Show total customers");
                Console.WriteLine("5. Clear queue");
                Console.WriteLine("6. Exit");
                Console.Write("\nChoose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("\nEnter customer name: ");
                        string customerName = Console.ReadLine();

                        customers.Enqueue(customerName);

                        Console.WriteLine($"\nCustomer added: {customerName}");
                        Pause();
                        break;

                    case "2":
                        if (customers.Count > 0)
                        {
                            string attendedCustomer = customers.Dequeue();
                            Console.WriteLine($"\nCustomer attended: {attendedCustomer}");
                        }
                        else
                        {
                            Console.WriteLine("\nThere are no customers in the queue.");
                        }

                        Pause();
                        break;

                    case "3":
                        if (customers.Count > 0)
                        {
                            string nextCustomer = customers.Peek();
                            Console.WriteLine($"\nNext customer: {nextCustomer}");
                        }
                        else
                        {
                            Console.WriteLine("\nThere are no customers waiting.");
                        }

                        Pause();
                        break;

                    case "4":
                        Console.WriteLine($"\nTotal customers waiting: {customers.Count}");
                        Pause();
                        break;

                    case "5":
                        customers.Clear();
                        Console.WriteLine("\nThe queue was cleared.");
                        Pause();
                        break;

                    case "6":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option.");
                        Pause();
                        break;
                }
            }
        }

        public static void Pause()
        {
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
    }
}
