using System;

namespace LearnHowToCode.ConditionsTaskSolutions
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
        int age = 20;

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // Task 2
        int level = 12;

        if (level >= 10)
        {
            Console.WriteLine("Level requirement met.");
        }

        // Task 3
        bool isOnline = true;

        if (isOnline)
        {
            Console.WriteLine("User is online.");
        }

        // Task 4
        int health = 45;

        if (health < 50)
        {
            Console.WriteLine("Warning: Low health!");
        }

        // Task 5
        int gold = 150;

        if (gold > 100)
        {
            Console.WriteLine("You have enough gold.");
        }

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        // Task 6
        int playerHealth = 0;

        if (playerHealth > 0)
        {
            Console.WriteLine("Player is alive.");
        }
        else
        {
            Console.WriteLine("Player is dead.");
        }

        // Task 7
        int grade = 75;

        if (grade >= 60)
        {
            Console.WriteLine("Student passed.");
        }
        else
        {
            Console.WriteLine("Student failed.");
        }

        // Task 8
        int voterAge = 18;

        if (voterAge >= 18)
        {
            Console.WriteLine("User is old enough to vote.");
        }
        else
        {
            Console.WriteLine("User is not old enough to vote.");
        }

        // Task 9
        double productPrice = 120.00;

        if (productPrice >= 100)
        {
            Console.WriteLine("Product qualifies for a discount.");
        }
        else
        {
            Console.WriteLine("Product does not qualify for a discount.");
        }

        // Task 10
        int number = -5;

        if (number >= 0)
        {
            Console.WriteLine("Number is positive.");
        }
        else
        {
            Console.WriteLine("Number is negative.");
        }

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        // Task 11
        int score = 85;

        if (score >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade F");
        }

        // Task 12
        int rankPoints = 70;

        if (rankPoints >= 90)
        {
            Console.WriteLine("Advanced");
        }
        else if (rankPoints >= 50)
        {
            Console.WriteLine("Intermediate");
        }
        else
        {
            Console.WriteLine("Beginner");
        }

        // Task 13
        int checkNumber = 0;

        if (checkNumber > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (checkNumber < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        // Task 14
        int temperature = 32;

        if (temperature >= 35)
        {
            Console.WriteLine("Very hot weather.");
        }
        else if (temperature >= 25)
        {
            Console.WriteLine("Warm weather.");
        }
        else if (temperature >= 15)
        {
            Console.WriteLine("Cool weather.");
        }
        else
        {
            Console.WriteLine("Cold weather.");
        }

        // Task 15
        int experience = 1200;

        if (experience >= 1000)
        {
            Console.WriteLine("Elite Player");
        }
        else if (experience >= 500)
        {
            Console.WriteLine("Experienced Player");
        }
        else
        {
            Console.WriteLine("New Player");
        }

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        // Task 16
        int driverAge = 25;
        bool hasLicense = true;

        if (driverAge >= 18 && hasLicense)
        {
            Console.WriteLine("User can drive.");
        }

        // Task 17
        bool isAdmin = false;
        bool isModerator = true;

        if (isAdmin || isModerator)
        {
            Console.WriteLine("Management access granted.");
        }

        // Task 18
        bool isBanned = false;

        if (!isBanned)
        {
            Console.WriteLine("User is not banned.");
        }

        // Task 19
        bool isVerified = true;
        bool hasSubscription = true;

        if (isVerified && hasSubscription)
        {
            Console.WriteLine("Premium access granted.");
        }

        // Task 20
        bool hasCoupon = false;
        bool isVip = true;

        if (hasCoupon || isVip)
        {
            Console.WriteLine("Discount access granted.");
        }

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        // Task 21
        string username = "Peyman";
        string password = "1234";

        if (username == "Peyman" && password == "1234")
        {
            Console.WriteLine("Login successful.");
        }
        else
        {
            Console.WriteLine("Login failed.");
        }

        // Task 22
        double balance = 500.00;
        double withdrawalAmount = 200.00;

        if (withdrawalAmount <= balance)
        {
            balance -= withdrawalAmount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: $" + balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }

        // Task 23
        int playerGold = 300;
        int itemCost = 250;

        if (playerGold >= itemCost)
        {
            playerGold -= itemCost;
            Console.WriteLine("Item purchased.");
            Console.WriteLine("Remaining Gold: " + playerGold);
        }
        else
        {
            Console.WriteLine("Not enough gold.");
        }

        // Task 24
        bool userVerified = true;
        bool correctPassword = true;
        bool accountLocked = false;

        if (userVerified && correctPassword && !accountLocked)
        {
            Console.WriteLine("Security access granted.");
        }
        else
        {
            Console.WriteLine("Security access denied.");
        }

        // Task 25
        int profileAge = 22;
        bool profileVerified = true;
        bool emailConfirmed = true;
        bool paymentActive = true;

        if (profileAge >= 18 && profileVerified && emailConfirmed && paymentActive)
        {
            Console.WriteLine("Premium features unlocked.");
        }
        else
        {
            Console.WriteLine("Premium features locked.");
        }

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        // Challenge 1
        int finalScore = 91;

        if (finalScore >= 90)
        {
            Console.WriteLine("A");
        }
        else if (finalScore >= 80)
        {
            Console.WriteLine("B");
        }
        else if (finalScore >= 70)
        {
            Console.WriteLine("C");
        }
        else if (finalScore >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        // Challenge 2
        string characterClass = "Warrior";

        if (characterClass == "Warrior")
        {
            Console.WriteLine("You selected Warrior.");
        }
        else if (characterClass == "Mage")
        {
            Console.WriteLine("You selected Mage.");
        }
        else if (characterClass == "Archer")
        {
            Console.WriteLine("You selected Archer.");
        }
        else
        {
            Console.WriteLine("Unknown class selected.");
        }

        // Challenge 3
        int dungeonLevelRequirement = 10;
        int characterLevel = 12;
        int requiredHealth = 50;
        int characterHealth = 80;
        int requiredGold = 100;
        int characterGold = 150;

        if (characterLevel >= dungeonLevelRequirement &&
            characterHealth >= requiredHealth &&
            characterGold >= requiredGold)
        {
            Console.WriteLine("Dungeon entry allowed.");
        }
        else
        {
            Console.WriteLine("Dungeon entry denied.");
        }

        Console.WriteLine("\nAll Condition Tasks Completed!");

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
