using System;

namespace LearnHowToCode.ArraysTaskSolutions
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Rank 1 Beginner 🌱
// ==================================================

```
        // Task 1
        int[] numbers =
        {
            10,
            20,
            30,
            40,
            50
        };

        // Task 2
        string[] names =
        {
            "Peyman",
            "John",
            "Maria",
            "David",
            "Sarah"
        };

        // Task 3
        double[] prices =
        {
            9.99,
            19.99,
            29.99,
            39.99,
            49.99
        };

        // Task 4
        bool[] onlineStatus =
        {
            true,
            false,
            true
        };

        // Task 5
        Console.WriteLine("First Number: " + numbers[0]);

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        // Task 6
        Console.WriteLine("\nSecond Name: " + names[1]);

        // Task 7
        Console.WriteLine("Last Number: " + numbers[numbers.Length - 1]);

        // Task 8
        names[2] = "Michael";

        // Task 9
        Console.WriteLine("Updated Name: " + names[2]);

        // Task 10
        Console.WriteLine("Array Length: " + names.Length);

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        // Task 11
        Console.WriteLine("\nTask 11");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Task 12
        Console.WriteLine("\nTask 12");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Task 13
        int[] scores =
        {
            80,
            90,
            100,
            95,
            85
        };

        int totalScore = 0;

        foreach (int score in scores)
        {
            totalScore += score;
        }

        Console.WriteLine("\nTotal Score: " + totalScore);

        // Task 14
        double averageScore =
            (double)totalScore / scores.Length;

        Console.WriteLine("Average Score: " + averageScore);

        // Task 15
        string[] countries =
        {
            "Mexico",
            "Canada",
            "Japan",
            "Germany",
            "Brazil"
        };

        Console.WriteLine("\nCountries:");

        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        // Task 16
        string[] inventory =
        {
            "Sword",
            "Shield",
            "Helmet",
            "Potion",
            "Boots"
        };

        // Task 17
        Console.WriteLine("\nInventory:");

        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        // Task 18
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine("\nLargest Number: " + largest);

        // Task 19
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }

        Console.WriteLine("Smallest Number: " + smallest);

        // Task 20
        int[] levels =
        {
            1,
            5,
            10,
            15,
            20
        };

        Console.WriteLine("\nLevels:");

        foreach (int level in levels)
        {
            Console.WriteLine("Level " + level);
        }

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        // Task 21
        int[] grades =
        {
            85,
            90,
            78,
            100,
            95
        };

        Console.WriteLine("\nStudent Grades:");

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }

        // Task 22
        int totalGrades = 0;

        foreach (int grade in grades)
        {
            totalGrades += grade;
        }

        double averageGrade =
            (double)totalGrades / grades.Length;

        Console.WriteLine("\nTotal Grades: " + totalGrades);
        Console.WriteLine("Average Grade: " + averageGrade);

        // Task 23
        int highestGrade = grades[0];
        int lowestGrade = grades[0];

        foreach (int grade in grades)
        {
            if (grade > highestGrade)
            {
                highestGrade = grade;
            }

            if (grade < lowestGrade)
            {
                lowestGrade = grade;
            }
        }

        Console.WriteLine("Highest Grade: " + highestGrade);
        Console.WriteLine("Lowest Grade: " + lowestGrade);

        // Task 24
        double[] productPrices =
        {
            15.99,
            29.99,
            49.99,
            99.99,
            149.99
        };

        Console.WriteLine("\nProduct Prices:");

        foreach (double price in productPrices)
        {
            Console.WriteLine("$" + price);
        }

        // Task 25
        double totalPrice = 0;

        foreach (double price in productPrices)
        {
            totalPrice += price;
        }

        Console.WriteLine("Total Price: $" + totalPrice);

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        // Challenge 1
        int[] challengeNumbers =
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };

        Console.WriteLine("\nEven Numbers:");

        foreach (int number in challengeNumbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }

        // Challenge 2
        string[] searchNames =
        {
            "Peyman",
            "John",
            "Maria",
            "David",
            "Sarah"
        };

        Console.Write("\nEnter a name to search: ");

        string searchName = Console.ReadLine();

        bool found = false;

        foreach (string name in searchNames)
        {
            if (name.Equals(searchName,
                StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Name found.");
        }
        else
        {
            Console.WriteLine("Name not found.");
        }

        // Challenge 3
        string[] rpgInventory =
        {
            "Sword",
            "Shield",
            "Potion",
            "Helmet",
            "Armor"
        };

        Console.WriteLine("\nRPG Inventory:");

        foreach (string item in rpgInventory)
        {
            Console.WriteLine("- " + item);
        }

        Console.WriteLine("\nAll Array Tasks Completed!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
```

}

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
