/*
 * ============================================================
 * File: Tasks_Solutions.cs
 * Path: 07-DATA-STRUCTURES/03-ARRAYS-AND-LISTS/Tasks_Solutions.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;
using System.Collections.Generic;

namespace ArraysAndListsTaskSolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== ARRAYS AND LISTS TASK SOLUTIONS ===");
            Console.WriteLine();

            ArrayTask1_CustomerInformation();
            ArrayTask2_SumOfNumbers();
            ArrayTask3_LargestAndSmallest();
            ArrayTask4_AverageGrades();
            ArrayTask5_ReverseArray();
            ArrayTask6_SearchElement();

            ListTask1_NamesList();
            ListTask2_SumListElements();
            ListTask3_SearchAndRemove();
            ListTask4_CountGreaterThan();

            ChallengeTask1_StudentGradeManager();
            ChallengeTask2_ToDoListManager();

            Console.WriteLine();
            Console.WriteLine("End of task solutions.");
        }

        // ============================================================
        // ARRAY TASK 1: CUSTOMER INFORMATION
        // ============================================================

        public static void ArrayTask1_CustomerInformation()
        {
            Console.WriteLine("Array Task 1: Customer Information");

            string[] firstNames = { "Ana", "Luis", "Carlos", "Marta", "Sofia" };
            string[] lastNames = { "Lopez", "Garcia", "Rivera", "Torres", "Martinez" };
            int[] ages = { 25, 30, 22, 28, 35 };
            string[] genders = { "Female", "Male", "Male", "Female", "Female" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine(
                    $"Customer {i + 1}: {firstNames[i]} {lastNames[i]}, Age: {ages[i]}, Gender: {genders[i]}"
                );
            }

            Console.WriteLine();
        }

        // ============================================================
        // ARRAY TASK 2: SUM OF N NUMBERS
        // ============================================================

        public static void ArrayTask2_SumOfNumbers()
        {
            Console.WriteLine("Array Task 2: Sum Of N Numbers");

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Numbers: 10, 20, 30, 40, 50");
            Console.WriteLine("Sum: " + sum);

            Console.WriteLine();
        }

        // ============================================================
        // ARRAY TASK 3: LARGEST AND SMALLEST VALUE
        // ============================================================

        public static void ArrayTask3_LargestAndSmallest()
        {
            Console.WriteLine("Array Task 3: Largest And Smallest Value");

            int[] numbers = { 45, 12, 89, 3, 67, 22, 100, 54, 31, 9 };

            int largest = numbers[0];
            int smallest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine("Largest value: " + largest);
            Console.WriteLine("Smallest value: " + smallest);

            Console.WriteLine();
        }

        // ============================================================
        // ARRAY TASK 4: AVERAGE OF GRADES
        // ============================================================

        public static void ArrayTask4_AverageGrades()
        {
            Console.WriteLine("Array Task 4: Average Of Grades");

            double[] grades = { 85.5, 90.0, 78.5, 92.0, 88.0 };
            double total = 0;

            foreach (double grade in grades)
            {
                total += grade;
            }

            double average = total / grades.Length;

            Console.WriteLine("Average grade: " + average);

            Console.WriteLine();
        }

        // ============================================================
        // ARRAY TASK 5: REVERSE AN ARRAY
        // ============================================================

        public static void ArrayTask5_ReverseArray()
        {
            Console.WriteLine("Array Task 5: Reverse An Array");

            int[] original = { 1, 2, 3, 4, 5 };
            int[] reversed = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = original[original.Length - 1 - i];
            }

            Console.WriteLine("Original array:");

            foreach (int number in original)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Reversed array:");

            foreach (int number in reversed)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        // ============================================================
        // ARRAY TASK 6: SEARCH AN ELEMENT
        // ============================================================

        public static void ArrayTask6_SearchElement()
        {
            Console.WriteLine("Array Task 6: Search An Element");

            int[] numbers = { 4, 8, 15, 16, 23, 42, 50, 64, 72, 90 };
            int numberToSearch = 23;
            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                    Console.WriteLine($"Number {numberToSearch} found at index {i}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Number {numberToSearch} was not found.");
            }

            Console.WriteLine();
        }

        // ============================================================
        // LIST TASK 1: CREATE A LIST OF NAMES
        // ============================================================

        public static void ListTask1_NamesList()
        {
            Console.WriteLine("List Task 1: Create A List Of Names");

            List<string> names = new List<string>();

            names.Add("Ana");
            names.Add("Luis");
            names.Add("Carlos");
            names.Add("Marta");

            Console.WriteLine("Names in the list:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        // ============================================================
        // LIST TASK 2: SUM OF LIST ELEMENTS
        // ============================================================

        public static void ListTask2_SumListElements()
        {
            Console.WriteLine("List Task 2: Sum Of List Elements");

            List<int> numbers = new List<int> { 10, 20, 30, 45, 5 };
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine("Total sum: " + total);

            Console.WriteLine();
        }

        // ============================================================
        // LIST TASK 3: SEARCH AND REMOVE
        // ============================================================

        public static void ListTask3_SearchAndRemove()
        {
            Console.WriteLine("List Task 3: Search And Remove");

            List<string> names = new List<string> { "Ana", "Luis", "Carlos", "Marta" };
            string nameToRemove = "Luis";

            if (names.Remove(nameToRemove))
            {
                Console.WriteLine($"{nameToRemove} has been removed.");
            }
            else
            {
                Console.WriteLine($"{nameToRemove} was not found.");
            }

            Console.WriteLine("Remaining names:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        // ============================================================
        // LIST TASK 4: COUNT VALUES GREATER THAN
        // ============================================================

        public static void ListTask4_CountGreaterThan()
        {
            Console.WriteLine("List Task 4: Count Values Greater Than");

            List<int> grades = new List<int> { 85, 60, 92, 45, 70, 99, 55 };
            int limit = 70;
            int counter = 0;

            foreach (int grade in grades)
            {
                if (grade > limit)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} grades greater than {limit}.");

            Console.WriteLine();
        }

        // ============================================================
        // CHALLENGE TASK 1: STUDENT GRADE MANAGER
        // ============================================================

        public static void ChallengeTask1_StudentGradeManager()
        {
            Console.WriteLine("Challenge Task 1: Student Grade Manager");

            string[] studentNames = { "Ana", "Luis", "Carlos", "Marta", "Sofia" };
            double[] grades = { 90, 85, 78, 92, 88 };

            double total = 0;
            double highest = grades[0];
            double lowest = grades[0];

            Console.WriteLine("Student Grades:");

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{studentNames[i]}: {grades[i]}");

                total += grades[i];

                if (grades[i] > highest)
                {
                    highest = grades[i];
                }

                if (grades[i] < lowest)
                {
                    lowest = grades[i];
                }
            }

            double average = total / grades.Length;

            Console.WriteLine("Class average: " + average);
            Console.WriteLine("Highest grade: " + highest);
            Console.WriteLine("Lowest grade: " + lowest);

            Console.WriteLine();
        }

        // ============================================================
        // CHALLENGE TASK 2: TO-DO LIST MANAGER
        // ============================================================

        public static void ChallengeTask2_ToDoListManager()
        {
            Console.WriteLine("Challenge Task 2: To-Do List Manager");

            List<string> tasks = new List<string>();

            tasks.Add("Study arrays");
            tasks.Add("Practice lists");
            tasks.Add("Complete homework");
            tasks.Add("Review solutions");

            Console.WriteLine("Current tasks:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }

            string taskToRemove = "Complete homework";

            tasks.Remove(taskToRemove);

            Console.WriteLine("\nTasks after removing one item:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }

            string taskToSearch = "Practice lists";

            if (tasks.Contains(taskToSearch))
            {
                Console.WriteLine($"\nTask found: {taskToSearch}");
            }
            else
            {
                Console.WriteLine($"\nTask not found: {taskToSearch}");
            }

            Console.WriteLine("Total tasks: " + tasks.Count);

            Console.WriteLine();
        }
    }
}
