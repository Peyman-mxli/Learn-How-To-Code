using System;

namespace LearnHowToCode.LoopsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Simple For Loop
// ==================================================

```
        Console.WriteLine("Example 1 - For Loop");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 2 - Counting From 1 To 10
        // ==================================================

        Console.WriteLine("\nExample 2 - Counting 1 To 10");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 3 - Counting Backwards
        // ==================================================

        Console.WriteLine("\nExample 3 - Countdown");

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 4 - Multiplication Table
        // ==================================================

        Console.WriteLine("\nExample 4 - Multiplication Table");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }

        // ==================================================
        // Example 5 - While Loop
        // ==================================================

        Console.WriteLine("\nExample 5 - While Loop");

        int whileCounter = 1;

        while (whileCounter <= 5)
        {
            Console.WriteLine(whileCounter);
            whileCounter++;
        }

        // ==================================================
        // Example 6 - Do While Loop
        // ==================================================

        Console.WriteLine("\nExample 6 - Do While Loop");

        int doCounter = 1;

        do
        {
            Console.WriteLine(doCounter);
            doCounter++;
        }
        while (doCounter <= 5);

        // ==================================================
        // Example 7 - Break Statement
        // ==================================================

        Console.WriteLine("\nExample 7 - Break");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;
            }

            Console.WriteLine(i);
        }

        // ==================================================
        // Example 8 - Continue Statement
        // ==================================================

        Console.WriteLine("\nExample 8 - Continue");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }

        // ==================================================
        // Example 9 - Even Numbers
        // ==================================================

        Console.WriteLine("\nExample 9 - Even Numbers");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 10 - Odd Numbers
        // ==================================================

        Console.WriteLine("\nExample 10 - Odd Numbers");

        for (int i = 1; i <= 19; i += 2)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 11 - Sum Numbers 1 To 10
        // ==================================================

        Console.WriteLine("\nExample 11 - Sum");

        int total = 0;

        for (int i = 1; i <= 10; i++)
        {
            total += i;
        }

        Console.WriteLine("Total = " + total);

        // ==================================================
        // Example 12 - Nested Loops
        // ==================================================

        Console.WriteLine("\nExample 12 - Nested Loops");

        for (int row = 1; row <= 3; row++)
        {
            for (int column = 1; column <= 3; column++)
            {
                Console.WriteLine("Row " + row + " Column " + column);
            }
        }

        // ==================================================
        // Example 13 - Star Pattern
        // ==================================================

        Console.WriteLine("\nExample 13 - Star Pattern");

        for (int row = 1; row <= 5; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // ==================================================
        // Example 14 - User Controlled Loop
        // ==================================================

        Console.WriteLine("\nExample 14 - User Controlled Loop");

        Console.Write("Enter a number: ");

        int userNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= userNumber; i++)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Example 15 - Countdown Timer
        // ==================================================

        Console.WriteLine("\nExample 15 - Countdown Timer");

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Go!");

        // ==================================================
        // Example 16 - Character Loop
        // ==================================================

        Console.WriteLine("\nExample 16 - Character Loop");

        string name = "Peyman";

        foreach (char letter in name)
        {
            Console.WriteLine(letter);
        }

        // ==================================================
        // Example 17 - Health Regeneration
        // ==================================================

        Console.WriteLine("\nExample 17 - Health Regeneration");

        int health = 50;

        while (health < 100)
        {
            health += 10;
            Console.WriteLine("Health: " + health);
        }

        // ==================================================
        // Example 18 - Menu Loop
        // ==================================================

        Console.WriteLine("\nExample 18 - Menu Loop");

        int menuChoice = 0;

        while (menuChoice != 4)
        {
            Console.WriteLine("\n1. Play");
            Console.WriteLine("2. Settings");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Exit");

            Console.Write("Choose: ");

            menuChoice = Convert.ToInt32(Console.ReadLine());
        }

        // ==================================================
        // Example 19 - Experience Gain
        // ==================================================

        Console.WriteLine("\nExample 19 - Experience Gain");

        int experience = 0;

        for (int i = 1; i <= 5; i++)
        {
            experience += 100;
        }

        Console.WriteLine("Experience: " + experience);

        // ==================================================
        // Example 20 - Level Progression
        // ==================================================

        Console.WriteLine("\nExample 20 - Level Progression");

        int level = 1;

        while (level <= 10)
        {
            Console.WriteLine("Level " + level);
            level++;
        }

        // ==================================================
        // End Of Examples
        // ==================================================

        Console.WriteLine("\nAll Loop Examples Completed!");

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
