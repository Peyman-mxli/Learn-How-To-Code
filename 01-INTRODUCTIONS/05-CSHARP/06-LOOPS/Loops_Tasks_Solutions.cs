using System;

namespace LearnHowToCode.LoopsTaskSolutions
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
        Console.WriteLine("Task 1");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Task 2
        Console.WriteLine("\nTask 2");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 3
        Console.WriteLine("\nTask 3");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Peyman");
        }

        // Task 4
        Console.WriteLine("\nTask 4");

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Task 5
        Console.WriteLine("\nTask 5");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        // Task 6
        Console.WriteLine("\nTask 6");

        int counter1 = 1;

        while (counter1 <= 5)
        {
            Console.WriteLine(counter1);
            counter1++;
        }

        // Task 7
        Console.WriteLine("\nTask 7");

        int counter2 = 1;

        while (counter2 <= 10)
        {
            Console.WriteLine(counter2);
            counter2++;
        }

        // Task 8
        Console.WriteLine("\nTask 8");

        int counter3 = 5;

        while (counter3 >= 1)
        {
            Console.WriteLine(counter3);
            counter3--;
        }

        // Task 9
        Console.WriteLine("\nTask 9");

        int counter4 = 1;

        do
        {
            Console.WriteLine(counter4);
            counter4++;
        }
        while (counter4 <= 5);

        // Task 10
        Console.WriteLine("\nTask 10");

        int counter5 = 10;

        do
        {
            Console.WriteLine("This runs at least once.");
        }
        while (counter5 < 5);

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        // Task 11
        Console.WriteLine("\nTask 11");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }

        // Task 12
        Console.WriteLine("\nTask 12");

        int total = 0;

        for (int i = 1; i <= 10; i++)
        {
            total += i;
        }

        Console.WriteLine("Total = " + total);

        // Task 13
        Console.WriteLine("\nTask 13");

        for (int i = 1; i <= 19; i += 2)
        {
            Console.WriteLine(i);
        }

        // Task 14
        Console.WriteLine("\nTask 14");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;
            }

            Console.WriteLine(i);
        }

        // Task 15
        Console.WriteLine("\nTask 15");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        // Task 16
        Console.WriteLine("\nTask 16");

        for (int row = 1; row <= 3; row++)
        {
            for (int column = 1; column <= 3; column++)
            {
                Console.WriteLine("Row " + row + " Column " + column);
            }
        }

        // Task 17
        Console.WriteLine("\nTask 17");

        for (int row = 1; row <= 5; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Task 18
        Console.WriteLine("\nTask 18");

        Console.Write("Enter a number: ");

        int userNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= userNumber; i++)
        {
            Console.WriteLine(i);
        }

        // Task 19
        Console.WriteLine("\nTask 19");

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Go!");

        // Task 20
        Console.WriteLine("\nTask 20");

        string name = "Peyman";

        foreach (char letter in name)
        {
            Console.WriteLine(letter);
        }

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        // Task 21
        Console.WriteLine("\nTask 21");

        int health = 50;

        while (health < 100)
        {
            health += 10;
            Console.WriteLine("Health: " + health);
        }

        // Task 22
        Console.WriteLine("\nTask 22");

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

        // Task 23
        Console.WriteLine("\nTask 23");

        int experience = 0;

        for (int i = 1; i <= 5; i++)
        {
            experience += 100;
        }

        Console.WriteLine("Experience: " + experience);

        // Task 24
        Console.WriteLine("\nTask 24");

        int level = 1;

        while (level <= 10)
        {
            Console.WriteLine("Level " + level);
            level++;
        }

        // Task 25
        Console.WriteLine("\nTask 25");

        string correctPassword = "1234";
        string enteredPassword = "";

        while (enteredPassword != correctPassword)
        {
            Console.Write("Enter Password: ");
            enteredPassword = Console.ReadLine();
        }

        Console.WriteLine("Access Granted!");

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        // Challenge 1
        Console.WriteLine("\nChallenge 1");

        Console.Write("Enter a number: ");

        int multiplicationNumber =
            Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(
                multiplicationNumber +
                " x " +
                i +
                " = " +
                (multiplicationNumber * i));
        }

        // Challenge 2
        Console.WriteLine("\nChallenge 2");

        int secretNumber = 7;
        int guess = 0;

        while (guess != secretNumber)
        {
            Console.Write("Guess the number: ");
            guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Correct!");

        // Challenge 3
        Console.WriteLine("\nChallenge 3");

        int playerExperience = 0;
        int targetExperience = 1000;

        while (playerExperience < targetExperience)
        {
            playerExperience += 100;

            Console.WriteLine(
                "Experience: " +
                playerExperience);
        }

        Console.WriteLine("Target Experience Reached!");

        Console.WriteLine("\nAll Loop Tasks Completed!");

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
