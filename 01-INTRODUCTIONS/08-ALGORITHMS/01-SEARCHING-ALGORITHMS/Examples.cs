using System;

namespace SearchingAlgorithmsExamples
{
    internal class Examples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SEARCHING ALGORITHMS EXAMPLES =====\n");

            Example1_LinearSearchNumbers();
            Example2_LinearSearchStrings();
            Example3_BinarySearchNumbers();
            Example4_FindAllOccurrences();
            Example5_SearchStudentName();

            Console.WriteLine("\nAll examples completed.");
        }

        // ==================================================
        // EXAMPLE 1
        // ==================================================
        static void Example1_LinearSearchNumbers()
        {
            Console.WriteLine("EXAMPLE 1: Linear Search (Numbers)");

            int[] numbers = { 10, 25, 7, 40, 15 };
            int target = 40;

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"Found {target} at index {i}.");
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

        // ==================================================
        // EXAMPLE 2
        // ==================================================
        static void Example2_LinearSearchStrings()
        {
            Console.WriteLine("EXAMPLE 2: Linear Search (Names)");

            string[] names = { "Ana", "Carlos", "Peyman", "Maria", "Luis" };
            string target = "Peyman";

            bool found = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == target)
                {
                    Console.WriteLine($"{target} found at index {i}.");
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

        // ==================================================
        // EXAMPLE 3
        // ==================================================
        static void Example3_BinarySearchNumbers()
        {
            Console.WriteLine("EXAMPLE 3: Binary Search");

            int[] numbers = { 5, 10, 15, 20, 25, 30, 35 };
            int target = 25;

            int left = 0;
            int right = numbers.Length - 1;
            bool found = false;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (numbers[middle] == target)
                {
                    Console.WriteLine($"{target} found at index {middle}.");
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

        // ==================================================
        // EXAMPLE 4
        // ==================================================
        static void Example4_FindAllOccurrences()
        {
            Console.WriteLine("EXAMPLE 4: Find All Occurrences");

            int[] numbers = { 3, 7, 3, 9, 3, 12 };
            int target = 3;

            Console.Write($"Occurrences of {target}: ");

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }

            if (!found)
            {
                Console.Write("None");
            }

            Console.WriteLine("\n");
        }

        // ==================================================
        // EXAMPLE 5
        // ==================================================
        static void Example5_SearchStudentName()
        {
            Console.WriteLine("EXAMPLE 5: Search Student");

            string[] students =
            {
                "Peyman",
                "Arlette",
                "Juan",
                "Kathy",
                "Luis"
            };

            string target = "Arlette";

            bool found = false;

            foreach (string student in students)
            {
                if (student == target)
                {
                    Console.WriteLine($"{target} is enrolled.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{target} is not enrolled.");
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
