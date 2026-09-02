using System;

namespace LearnHowToCode.ArraysExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Creating An Integer Array
// ==================================================

```
        int[] numbers =
        {
            10,
            20,
            30,
            40,
            50
        };

        Console.WriteLine("Example 1");
        Console.WriteLine(numbers[0]);

        // ==================================================
        // Example 2 - Accessing Different Indexes
        // ==================================================

        Console.WriteLine("\nExample 2");

        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);

        // ==================================================
        // Example 3 - String Array
        // ==================================================

        string[] names =
        {
            "Peyman",
            "John",
            "Maria",
            "David"
        };

        Console.WriteLine("\nExample 3");

        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);

        // ==================================================
        // Example 4 - Modifying Array Values
        // ==================================================

        Console.WriteLine("\nExample 4");

        names[1] = "Michael";

        Console.WriteLine(names[1]);

        // ==================================================
        // Example 5 - Array Length
        // ==================================================

        Console.WriteLine("\nExample 5");

        Console.WriteLine("Total Elements: " + names.Length);

        // ==================================================
        // Example 6 - For Loop With Arrays
        // ==================================================

        Console.WriteLine("\nExample 6");

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        // ==================================================
        // Example 7 - Foreach Loop
        // ==================================================

        Console.WriteLine("\nExample 7");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // ==================================================
        // Example 8 - Double Array
        // ==================================================

        double[] prices =
        {
            9.99,
            19.99,
            29.99,
            49.99
        };

        Console.WriteLine("\nExample 8");

        foreach (double price in prices)
        {
            Console.WriteLine("$" + price);
        }

        // ==================================================
        // Example 9 - Boolean Array
        // ==================================================

        bool[] onlineStatus =
        {
            true,
            false,
            true
        };

        Console.WriteLine("\nExample 9");

        foreach (bool status in onlineStatus)
        {
            Console.WriteLine(status);
        }

        // ==================================================
        // Example 10 - Fixed Size Array
        // ==================================================

        int[] scores = new int[5];

        scores[0] = 100;
        scores[1] = 95;
        scores[2] = 90;
        scores[3] = 85;
        scores[4] = 80;

        Console.WriteLine("\nExample 10");

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        // ==================================================
        // Example 11 - Sum Array Values
        // ==================================================

        int total = 0;

        foreach (int score in scores)
        {
            total += score;
        }

        Console.WriteLine("\nExample 11");
        Console.WriteLine("Total: " + total);

        // ==================================================
        // Example 12 - Average Score
        // ==================================================

        double average = (double)total / scores.Length;

        Console.WriteLine("\nExample 12");
        Console.WriteLine("Average: " + average);

        // ==================================================
        // Example 13 - Inventory Example
        // ==================================================

        string[] inventory =
        {
            "Sword",
            "Shield",
            "Potion",
            "Helmet"
        };

        Console.WriteLine("\nExample 13");

        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        // ==================================================
        // Example 14 - Grade Book Example
        // ==================================================

        int[] grades =
        {
            85,
            90,
            78,
            100,
            95
        };

        Console.WriteLine("\nExample 14");

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }

        // ==================================================
        // Example 15 - Country List
        // ==================================================

        string[] countries =
        {
            "Mexico",
            "Canada",
            "Japan",
            "Germany",
            "Brazil"
        };

        Console.WriteLine("\nExample 15");

        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        // ==================================================
        // Example 16 - Finding Largest Number
        // ==================================================

        int[] values =
        {
            10,
            40,
            90,
            25,
            75
        };

        int largest = values[0];

        foreach (int value in values)
        {
            if (value > largest)
            {
                largest = value;
            }
        }

        Console.WriteLine("\nExample 16");
        Console.WriteLine("Largest: " + largest);

        // ==================================================
        // Example 17 - Finding Smallest Number
        // ==================================================

        int smallest = values[0];

        foreach (int value in values)
        {
            if (value < smallest)
            {
                smallest = value;
            }
        }

        Console.WriteLine("\nExample 17");
        Console.WriteLine("Smallest: " + smallest);

        // ==================================================
        // Example 18 - User Names Array
        // ==================================================

        string[] users =
        {
            "Admin",
            "Moderator",
            "Player"
        };

        Console.WriteLine("\nExample 18");

        foreach (string user in users)
        {
            Console.WriteLine(user);
        }

        // ==================================================
        // Example 19 - RPG Levels
        // ==================================================

        int[] levels =
        {
            1,
            5,
            10,
            15,
            20
        };

        Console.WriteLine("\nExample 19");

        foreach (int level in levels)
        {
            Console.WriteLine("Level " + level);
        }

        // ==================================================
        // Example 20 - Complete Array Report
        // ==================================================

        Console.WriteLine("\nExample 20");

        Console.WriteLine("Names Count: " + names.Length);
        Console.WriteLine("Scores Count: " + scores.Length);
        Console.WriteLine("Countries Count: " + countries.Length);

        // ==================================================
        // End Of Examples
        // ==================================================

        Console.WriteLine("\nAll Array Examples Completed!");

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
