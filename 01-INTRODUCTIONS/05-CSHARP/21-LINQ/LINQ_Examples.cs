```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public bool IsActive { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("LINQ WITH NUMBERS");
            Console.WriteLine("=========================================");

            List<int> numbers = new List<int>
            {
                5, 10, 15, 20, 25, 30, 35, 40
            };

            var evenNumbers =
                numbers.Where(number => number % 2 == 0);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine($"Even Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("WHERE FILTER EXAMPLE");
            Console.WriteLine("=========================================");

            var numbersGreaterThanTwenty =
                numbers.Where(number => number > 20);

            foreach (int number in numbersGreaterThanTwenty)
            {
                Console.WriteLine($"Greater Than 20: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ORDERBY EXAMPLE");
            Console.WriteLine("=========================================");

            var sortedNumbers =
                numbers.OrderBy(number => number);

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine($"Sorted Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ORDERBYDESCENDING EXAMPLE");
            Console.WriteLine("=========================================");

            var descendingNumbers =
                numbers.OrderByDescending(number => number);

            foreach (int number in descendingNumbers)
            {
                Console.WriteLine($"Descending Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("SELECT EXAMPLE");
            Console.WriteLine("=========================================");

            var doubledNumbers =
                numbers.Select(number => number * 2);

            foreach (int number in doubledNumbers)
            {
                Console.WriteLine($"Doubled Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("FIRSTORDEFAULT EXAMPLE");
            Console.WriteLine("=========================================");

            int firstNumberOverTwenty =
                numbers.FirstOrDefault(number => number > 20);

            Console.WriteLine($"First Number Over 20: {firstNumberOverTwenty}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("COUNT, SUM, AVERAGE, MIN, MAX");
            Console.WriteLine("=========================================");

            Console.WriteLine($"Count: {numbers.Count()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");
            Console.WriteLine($"Minimum: {numbers.Min()}");
            Console.WriteLine($"Maximum: {numbers.Max()}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ANY AND ALL EXAMPLES");
            Console.WriteLine("=========================================");

            bool hasNumberOverThirty =
                numbers.Any(number => number > 30);

            bool allNumbersPositive =
                numbers.All(number => number > 0);

            Console.WriteLine($"Has Number Over 30: {hasNumberOverThirty}");
            Console.WriteLine($"All Numbers Positive: {allNumbersPositive}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("DISTINCT EXAMPLE");
            Console.WriteLine("=========================================");

            List<int> repeatedNumbers = new List<int>
            {
                1, 2, 2, 3, 3, 4, 5, 5
            };

            var uniqueNumbers =
                repeatedNumbers.Distinct();

            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine($"Unique Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TAKE AND SKIP EXAMPLES");
            Console.WriteLine("=========================================");

            var firstThreeNumbers =
                numbers.Take(3);

            Console.WriteLine("First Three Numbers:");

            foreach (int number in firstThreeNumbers)
            {
                Console.WriteLine(number);
            }

            var skippedNumbers =
                numbers.Skip(3);

            Console.WriteLine("After Skipping First Three Numbers:");

            foreach (int number in skippedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("LINQ WITH STRINGS");
            Console.WriteLine("=========================================");

            List<string> names = new List<string>
            {
                "Peyman",
                "Sarah",
                "David",
                "Maria",
                "John",
                "Daniel"
            };

            var namesStartingWithD =
                names.Where(name => name.StartsWith("D"));

            foreach (string name in namesStartingWithD)
            {
                Console.WriteLine($"Name Starting With D: {name}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("LINQ WITH OBJECTS");
            Console.WriteLine("=========================================");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Peyman", Age = 20, Grade = 95, IsActive = true },
                new Student { Name = "Sarah", Age = 22, Grade = 88, IsActive = true },
                new Student { Name = "David", Age = 19, Grade = 72, IsActive = false },
                new Student { Name = "Maria", Age = 24, Grade = 98, IsActive = true },
                new Student { Name = "John", Age = 21, Grade = 65, IsActive = false }
            };

            var activeStudents =
                students.Where(student => student.IsActive);

            foreach (Student student in activeStudents)
            {
                Console.WriteLine($"Active Student: {student.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("SELECT OBJECT PROPERTIES");
            Console.WriteLine("=========================================");

            var studentNames =
                students.Select(student => student.Name);

            foreach (string name in studentNames)
            {
                Console.WriteLine($"Student Name: {name}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ORDER STUDENTS BY GRADE");
            Console.WriteLine("=========================================");

            var studentsByGrade =
                students.OrderByDescending(student => student.Grade);

            foreach (Student student in studentsByGrade)
            {
                Console.WriteLine($"{student.Name} | Grade: {student.Grade}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("GROUP STUDENTS BY ACTIVE STATUS");
            Console.WriteLine("=========================================");

            var groupedStudents =
                students.GroupBy(student => student.IsActive);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Active Status: {group.Key}");

                foreach (Student student in group)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("QUERY SYNTAX EXAMPLE");
            Console.WriteLine("=========================================");

            var highGradeStudents =
                from student in students
                where student.Grade >= 90
                orderby student.Name
                select student;

            foreach (Student student in highGradeStudents)
            {
                Console.WriteLine(
                    $"High Grade Student: {student.Name} | Grade: {student.Grade}");
            }

            Console.WriteLine();

            Console.WriteLine("LINQ Examples Completed!");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
