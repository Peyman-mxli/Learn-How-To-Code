using System;

namespace LearnHowToCode.ConditionsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Simple If Statement
// ==================================================

```
        int age = 20;

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // ==================================================
        // Example 2 - If Statement (False Condition)
        // ==================================================

        int playerLevel = 5;

        if (playerLevel >= 10)
        {
            Console.WriteLine("Advanced Player");
        }

        // ==================================================
        // Example 3 - If Else Statement
        // ==================================================

        int score = 75;

        if (score >= 60)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }

        // ==================================================
        // Example 4 - Age Check
        // ==================================================

        int userAge = 16;

        if (userAge >= 18)
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }

        // ==================================================
        // Example 5 - Else If Statement
        // ==================================================

        int grade = 85;

        if (grade >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade F");
        }

        // ==================================================
        // Example 6 - Equality Check
        // ==================================================

        int number = 10;

        if (number == 10)
        {
            Console.WriteLine("Number equals 10.");
        }

        // ==================================================
        // Example 7 - Not Equal Check
        // ==================================================

        string username = "Peyman";

        if (username != "Admin")
        {
            Console.WriteLine("Standard User");
        }

        // ==================================================
        // Example 8 - Greater Than
        // ==================================================

        int gold = 500;

        if (gold > 100)
        {
            Console.WriteLine("You have plenty of gold.");
        }

        // ==================================================
        // Example 9 - Less Than
        // ==================================================

        int health = 25;

        if (health < 50)
        {
            Console.WriteLine("Low Health Warning!");
        }

        // ==================================================
        // Example 10 - Greater Than Or Equal
        // ==================================================

        int level = 20;

        if (level >= 20)
        {
            Console.WriteLine("Dungeon Unlocked");
        }

        // ==================================================
        // Example 11 - Less Than Or Equal
        // ==================================================

        int lives = 0;

        if (lives <= 0)
        {
            Console.WriteLine("Game Over");
        }

        // ==================================================
        // Example 12 - Logical AND (&&)
        // ==================================================

        bool hasKey = true;
        bool doorUnlocked = true;

        if (hasKey && doorUnlocked)
        {
            Console.WriteLine("Door Opened");
        }

        // ==================================================
        // Example 13 - Logical OR (||)
        // ==================================================

        bool isAdmin = false;
        bool isModerator = true;

        if (isAdmin || isModerator)
        {
            Console.WriteLine("Management Access Granted");
        }

        // ==================================================
        // Example 14 - Logical NOT (!)
        // ==================================================

        bool isBanned = false;

        if (!isBanned)
        {
            Console.WriteLine("User Can Login");
        }

        // ==================================================
        // Example 15 - Nested If Statement
        // ==================================================

        int driverAge = 25;
        bool hasLicense = true;

        if (driverAge >= 18)
        {
            if (hasLicense)
            {
                Console.WriteLine("Can Drive");
            }
        }

        // ==================================================
        // Example 16 - Login System
        // ==================================================

        string password = "1234";

        if (password == "1234")
        {
            Console.WriteLine("Login Successful");
        }
        else
        {
            Console.WriteLine("Login Failed");
        }

        // ==================================================
        // Example 17 - RPG Health System
        // ==================================================

        int playerHealth = 0;

        if (playerHealth <= 0)
        {
            Console.WriteLine("Player Dead");
        }
        else
        {
            Console.WriteLine("Player Alive");
        }

        // ==================================================
        // Example 18 - Shopping Discount
        // ==================================================

        double purchaseAmount = 150.00;

        if (purchaseAmount >= 100)
        {
            Console.WriteLine("Discount Applied");
        }
        else
        {
            Console.WriteLine("No Discount");
        }

        // ==================================================
        // Example 19 - Weather Check
        // ==================================================

        bool isRaining = true;

        if (isRaining)
        {
            Console.WriteLine("Take an Umbrella");
        }
        else
        {
            Console.WriteLine("Enjoy the Weather");
        }

        // ==================================================
        // Example 20 - Complete Profile Check
        // ==================================================

        int profileAge = 22;
        bool profileVerified = true;

        if (profileAge >= 18 && profileVerified)
        {
            Console.WriteLine("Full Access Granted");
        }
        else
        {
            Console.WriteLine("Restricted Access");
        }

        // ==================================================
        // End of Examples
        // ==================================================

        Console.WriteLine("\nAll Condition Examples Completed!");

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
