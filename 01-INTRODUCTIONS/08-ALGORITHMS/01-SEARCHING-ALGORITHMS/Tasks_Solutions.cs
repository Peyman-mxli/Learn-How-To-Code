using System;

namespace SearchingAlgorithmsTaskSolutions
{
    internal class Tasks_Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SEARCHING ALGORITHMS TASK SOLUTIONS =====\n");

            Task1_LinearSearchNumbers();
            Task2_LinearSearchNames();
            Task3_BinarySearchNumbers();
            Task4_CountOccurrences();
            Task5_SearchStudentIndex();

            Console.WriteLine("\nAll task solutions completed.");
        }

        static void Task1_LinearSearchNumbers()
        {
            Console.WriteLine("TASK 1: Linear Search Numbers");

            int[] numbers = { 10, 25, 7, 40, 15 };

            Console.Write("Enter a number to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"{target} was found at index {i}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{target} was not found.");
            }

            Console.WriteLine();
        }

        static void Task2_LinearSearchNames()
        {
            Console.WriteLine("TASK 2: Linear Search Names");

            string[] names = { "Ana", "Carlos", "Peyman", "Maria", "Luis" };

            Console.Write("Enter a name to search: ");
            string target = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{target} was found at index {i}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{target} was not found.");
            }

            Console.WriteLine();
        }

        static void Task3_BinarySearchNumbers()
        {
            Console.WriteLine("TASK 3: Binary Search Numbers");

            int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40 };

            Console.Write("Enter a number to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int left = 0;
            int right = numbers.Length - 1;
            bool found = false;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (numbers[middle] == target)
                {
                    Console.WriteLine($"{target} was found at index {middle}.");
                    found = true;
                    break;
                }
                else if (target < numbers[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{target} was not found.");
            }

            Console.WriteLine();
        }

        static void Task4_CountOccurrences()
        {
            Console.WriteLine("TASK 4: Count Occurrences");

            int[] numbers = { 3, 7, 3, 9, 3, 12, 7, 3 };

            Console.Write("Enter a number to count: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    count++;
                }
            }

            Console.WriteLine($"{target} appears {count} time(s).");

            Console.WriteLine();
        }

        static void Task5_SearchStudentIndex()
        {
            Console.WriteLine("TASK 5: Search Student Index");

            string[] students =
            {
                "Peyman",
                "Arlette",
                "Juan",
                "Kathy",
                "Luis"
            };

            Console.Write("Enter student name: ");
            string target = Console.ReadLine();

            int foundIndex = -1;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                Console.WriteLine($"{target} was found at index {foundIndex}.");
            }
            else
            {
                Console.WriteLine("Student not found.");
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
