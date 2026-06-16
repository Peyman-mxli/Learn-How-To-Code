using System;

namespace SortingAlgorithmsTaskSolutions
{
    internal class Tasks_Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SORTING ALGORITHMS TASK SOLUTIONS =====\n");

            Task1_BubbleSortAscending();
            Task2_BubbleSortDescending();
            Task3_SelectionSortAscending();
            Task4_InsertionSortAscending();
            Task5_SortStudentGrades();

            Console.WriteLine("\nAll task solutions completed.");
        }

        static void Task1_BubbleSortAscending()
        {
            Console.WriteLine("TASK 1: Bubble Sort Ascending");

            int[] numbers = { 9, 3, 7, 1, 5 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            PrintArray(numbers);
        }

        static void Task2_BubbleSortDescending()
        {
            Console.WriteLine("TASK 2: Bubble Sort Descending");

            int[] numbers = { 9, 3, 7, 1, 5 };

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

            PrintArray(numbers);
        }

        static void Task3_SelectionSortAscending()
        {
            Console.WriteLine("TASK 3: Selection Sort Ascending");

            int[] numbers = { 64, 25, 12, 22, 11 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minimumIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minimumIndex];
                numbers[minimumIndex] = temp;
            }

            PrintArray(numbers);
        }

        static void Task4_InsertionSortAscending()
        {
            Console.WriteLine("TASK 4: Insertion Sort Ascending");

            int[] numbers = { 5, 2, 4, 6, 1, 3 };

            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            PrintArray(numbers);
        }

        static void Task5_SortStudentGrades()
        {
            Console.WriteLine("TASK 5: Sort Student Grades");

            int[] grades = { 78, 95, 82, 67, 90 };

            for (int i = 0; i < grades.Length - 1; i++)
            {
                for (int j = 0; j < grades.Length - i - 1; j++)
                {
                    if (grades[j] > grades[j + 1])
                    {
                        int temp = grades[j];
                        grades[j] = grades[j + 1];
                        grades[j + 1] = temp;
                    }
                }
            }

            PrintArray(grades);
        }

        static void PrintArray(int[] array)
        {
            Console.Write("Sorted Array: ");

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
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
