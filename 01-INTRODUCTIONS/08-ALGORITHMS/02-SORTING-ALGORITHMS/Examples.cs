using System;

namespace SortingAlgorithmsExamples
{
    internal class Examples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SORTING ALGORITHMS EXAMPLES =====\n");

            Example1_BubbleSort();
            Example2_SelectionSort();
            Example3_InsertionSort();
            Example4_DescendingBubbleSort();
            Example5_SortStudentGrades();

            Console.WriteLine("\nAll examples completed.");
        }

        // ==================================================
        // EXAMPLE 1
        // ==================================================
        static void Example1_BubbleSort()
        {
            Console.WriteLine("EXAMPLE 1: Bubble Sort");

            int[] numbers = { 5, 3, 8, 1, 2 };

            BubbleSort(numbers);

            Console.Write("Sorted Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        // ==================================================
        // EXAMPLE 2
        // ==================================================
        static void Example2_SelectionSort()
        {
            Console.WriteLine("EXAMPLE 2: Selection Sort");

            int[] numbers = { 64, 25, 12, 22, 11 };

            SelectionSort(numbers);

            Console.Write("Sorted Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        // ==================================================
        // EXAMPLE 3
        // ==================================================
        static void Example3_InsertionSort()
        {
            Console.WriteLine("EXAMPLE 3: Insertion Sort");

            int[] numbers = { 5, 2, 4, 6, 1, 3 };

            InsertionSort(numbers);

            Console.Write("Sorted Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        // ==================================================
        // EXAMPLE 4
        // ==================================================
        static void Example4_DescendingBubbleSort()
        {
            Console.WriteLine("EXAMPLE 4: Bubble Sort (Descending)");

            int[] numbers = { 10, 50, 20, 40, 30 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("Sorted Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        // ==================================================
        // EXAMPLE 5
        // ==================================================
        static void Example5_SortStudentGrades()
        {
            Console.WriteLine("EXAMPLE 5: Sort Student Grades");

            int[] grades = { 78, 95, 82, 67, 90 };

            BubbleSort(grades);

            Console.Write("Sorted Grades: ");

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\n");
        }

        // Bubble Sort Method
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort Method
        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minimumIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = array[minimumIndex];
                array[minimumIndex] = temp;
            }
        }

        // Insertion Sort Method
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
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
