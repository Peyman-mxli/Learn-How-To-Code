```csharp
/*
 * ============================================================
 * File: Examples.cs
 * Path: 07-DATA-STRUCTURES/03-ARRAYS-AND-LISTS/Examples.cs
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
using System.Linq;

namespace ArraysAndListsExamples
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: \"{Title}\", Author: {Author}, Year: {PublicationYear}";
        }
    }

    public class InventoryManager
    {
        private List<Book> inventory = new List<Book>();

        public void AddBook(Book book)
        {
            inventory.Add(book);
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return inventory.Where(book => book.Author == author).ToList();
        }

        public List<Book> GetBooksOrderedByYear()
        {
            return inventory.OrderBy(book => book.PublicationYear).ToList();
        }

        public void ShowInventory(string title, List<Book> books)
        {
            Console.WriteLine($"\n--- {title} ---");

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== ARRAYS AND LISTS EXAMPLES ===");
            Console.WriteLine();

            Example1_BasicArrayOperations();
            Example2_BaseballBattingAverage();
            Example3_MovieList();
            Example4_BookInventoryWithLinq();
            Example5_StudentGradesList();

            Console.WriteLine();
            Console.WriteLine("End of examples.");
        }

        // ============================================================
        // EXAMPLE 1: BASIC ARRAY OPERATIONS
        // ============================================================

        public static void Example1_BasicArrayOperations()
        {
            Console.WriteLine("Example 1: Basic Array Operations");

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Fourth element: " + numbers[3]);

            numbers[1] = 25;

            Console.WriteLine("Modified second element: " + numbers[1]);

            Console.WriteLine("\nTraversing the array with a for loop:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }

            Console.WriteLine("\nTraversing the array with a foreach loop:");

            foreach (int number in numbers)
            {
                Console.WriteLine("Element value: " + number);
            }

            string[] names = { "Ana", "Luis", "Carlos" };

            Console.WriteLine("\nSecond name: " + names[1]);

            Console.WriteLine();
        }

        // ============================================================
        // EXAMPLE 2: BASEBALL BATTING AVERAGE
        // ============================================================

        public static void Example2_BaseballBattingAverage()
        {
            Console.WriteLine("Example 2: Baseball Batting Average");

            int[] hits = { 150, 185, 120, 175 };
            int[] officialAtBats = { 500, 550, 450, 520 };
            string[] playerNames = { "Player A", "Player B", "Player C", "Player D" };

            Console.WriteLine("--- Batting Average Calculator ---");

            for (int i = 0; i < playerNames.Length; i++)
            {
                double average = (double)hits[i] / officialAtBats[i];

                Console.WriteLine($"\nStatistics for {playerNames[i]}:");
                Console.WriteLine($"Hits: {hits[i]}");
                Console.WriteLine($"Official At-Bats: {officialAtBats[i]}");
                Console.WriteLine($"Batting Average: {average:F3}");
            }

            Console.WriteLine();
        }

        // ============================================================
        // EXAMPLE 3: MOVIE LIST
        // ============================================================

        public static void Example3_MovieList()
        {
            Console.WriteLine("Example 3: Movie List");

            List<string> movies = new List<string>();

            movies.Add("Matrix");
            movies.Add("Shrek");
            movies.Add("Inception");

            Console.WriteLine("Movies in the list:");

            foreach (string movie in movies)
            {
                Console.WriteLine("- " + movie);
            }

            movies.Add("The Muppets");

            Console.WriteLine("\nMovies after adding a new one:");

            foreach (string movie in movies)
            {
                Console.WriteLine("- " + movie);
            }

            Console.WriteLine($"\nTotal movies in the list: {movies.Count}");

            Console.WriteLine();
        }

        // ============================================================
        // EXAMPLE 4: BOOK INVENTORY WITH LINQ
        // ============================================================

        public static void Example4_BookInventoryWithLinq()
        {
            Console.WriteLine("Example 4: Book Inventory With LINQ");

            InventoryManager manager = new InventoryManager();

            manager.AddBook(new Book
            {
                Id = 1,
                Title = "One Hundred Years of Solitude",
                Author = "Gabriel Garcia Marquez",
                PublicationYear = 1967
            });

            manager.AddBook(new Book
            {
                Id = 2,
                Title = "Don Quixote",
                Author = "Miguel de Cervantes",
                PublicationYear = 1605
            });

            manager.AddBook(new Book
            {
                Id = 3,
                Title = "Love in the Time of Cholera",
                Author = "Gabriel Garcia Marquez",
                PublicationYear = 1985
            });

            manager.AddBook(new Book
            {
                Id = 4,
                Title = "The Time of the Hero",
                Author = "Mario Vargas Llosa",
                PublicationYear = 1962
            });

            manager.ShowInventory(
                "Complete Inventory Ordered By Year",
                manager.GetBooksOrderedByYear()
            );

            List<Book> booksByAuthor = manager.GetBooksByAuthor("Gabriel Garcia Marquez");

            manager.ShowInventory(
                "Books by Gabriel Garcia Marquez",
                booksByAuthor
            );

            Console.WriteLine();
        }

        // ============================================================
        // EXAMPLE 5: STUDENT GRADES LIST
        // ============================================================

        public static void Example5_StudentGradesList()
        {
            Console.WriteLine("Example 5: Student Grades List");

            List<int> grades = new List<int> { 85, 90, 78, 92, 88 };

            int total = 0;

            foreach (int grade in grades)
            {
                total += grade;
            }

            double average = (double)total / grades.Count;

            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine("- " + grade);
            }

            Console.WriteLine("Average grade: " + average);
            Console.WriteLine("Highest grade: " + grades.Max());
            Console.WriteLine("Lowest grade: " + grades.Min());

            Console.WriteLine();
        }
    }
}
```
