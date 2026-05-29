using System;

namespace LearnHowToCode.MethodsTaskSolutions
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Rank 1 Beginner 🌱
// ==================================================

```
        SayHello();
        ShowName();
        ShowCourse();
        ShowSeparator();

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        DisplayWelcomeMessage();
        DisplayMenu();
        ShowStudentInfo();
        ShowGameInfo();

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        GreetUser("Peyman");
        DisplayPlayer("Peyman", 25);
        AddNumbers(10, 20);
        ShowProduct("Keyboard", 49.99);
        CheckAge(25);

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        int level = GetLevel();
        string playerName = GetPlayerName();
        bool isAlive = IsPlayerAlive();
        int square = CalculateSquare(5);
        double area = CalculateRectangleArea(10, 5);

        Console.WriteLine("Level: " + level);
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Is Alive: " + isAlive);
        Console.WriteLine("Square: " + square);
        Console.WriteLine("Rectangle Area: " + area);

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        Console.WriteLine("Add: " + Add(10, 5));
        Console.WriteLine("Subtract: " + Subtract(10, 5));
        Console.WriteLine("Multiply: " + Multiply(10, 5));
        Console.WriteLine("Divide: " + Divide(10, 5));

        bool passed = CheckPassed(85);
        bool loginValid = ValidateLogin("Peyman", "1234");

        Console.WriteLine("Passed: " + passed);
        Console.WriteLine("Login Valid: " + loginValid);

        CreateCharacter("Nova", "Warrior", 10);
        DisplayUserProfile("Peyman", 25, "Mexico", "C#");

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        int[] numbers =
        {
            10,
            20,
            30,
            40,
            50
        };

        int[] grades =
        {
            80,
            90,
            100,
            95,
            85
        };

        Console.WriteLine("Array Total: " + CalculateArrayTotal(numbers));
        Console.WriteLine("Grade Average: " + CalculateAverage(grades));

        DisplayCharacter("Nova", "Tank", 15);
        AttackEnemy("Wolf", 25);
        GainExperience(500);
        LevelUp(16);

        Console.WriteLine("\nAll Method Tasks Completed!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // ==================================================
    // Rank 1 Beginner 🌱
    // ==================================================

    static void SayHello()
    {
        Console.WriteLine("Hello");
    }

    static void ShowName()
    {
        Console.WriteLine("Peyman");
    }

    static void ShowCourse()
    {
        Console.WriteLine("Learning C#");
    }

    static void ShowSeparator()
    {
        Console.WriteLine("------------------------------");
    }

    // ==================================================
    // Rank 2 Easy 🙂
    // ==================================================

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the C# course.");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Settings");
        Console.WriteLine("3. Exit");
    }

    static void ShowStudentInfo()
    {
        Console.WriteLine("Student Name: Peyman");
        Console.WriteLine("Student Age: 25");
    }

    static void ShowGameInfo()
    {
        Console.WriteLine("Player Name: Nova");
        Console.WriteLine("Level: 10");
    }

    // ==================================================
    // Rank 3 Intermediate ⚙️
    // ==================================================

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void DisplayPlayer(string playerName, int level)
    {
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Level: " + level);
    }

    static void AddNumbers(int number1, int number2)
    {
        int result = number1 + number2;

        Console.WriteLine("Sum: " + result);
    }

    static void ShowProduct(string productName, double price)
    {
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Price: $" + price);
    }

    static void CheckAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }
    }

    // ==================================================
    // Rank 4 Advanced 🚀
    // ==================================================

    static int GetLevel()
    {
        return 25;
    }

    static string GetPlayerName()
    {
        return "Peyman";
    }

    static bool IsPlayerAlive()
    {
        return true;
    }

    static int CalculateSquare(int number)
    {
        return number * number;
    }

    static double CalculateRectangleArea(double width, double height)
    {
        return width * height;
    }

    // ==================================================
    // Rank 5 Professional 🏗️
    // ==================================================

    static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    static int Subtract(int number1, int number2)
    {
        return number1 - number2;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static double Divide(double number1, double number2)
    {
        return number1 / number2;
    }

    static bool CheckPassed(int score)
    {
        return score >= 60;
    }

    static bool ValidateLogin(string username, string password)
    {
        return username == "Peyman" && password == "1234";
    }

    static void CreateCharacter(string characterName, string characterClass, int level)
    {
        Console.WriteLine("\nCharacter Summary");
        Console.WriteLine("Name: " + characterName);
        Console.WriteLine("Class: " + characterClass);
        Console.WriteLine("Level: " + level);
    }

    static void DisplayUserProfile(string name, int age, string country, string language)
    {
        Console.WriteLine("\nUser Profile");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Country: " + country);
        Console.WriteLine("Favorite Language: " + language);
    }

    // ==================================================
    // Challenge Tasks ⭐
    // ==================================================

    static int CalculateArrayTotal(int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        return total;
    }

    static double CalculateAverage(int[] grades)
    {
        int total = 0;

        foreach (int grade in grades)
        {
            total += grade;
        }

        return (double)total / grades.Length;
    }

    static void DisplayCharacter(string characterName, string characterClass, int level)
    {
        Console.WriteLine("\nRPG Character");
        Console.WriteLine("Name: " + characterName);
        Console.WriteLine("Class: " + characterClass);
        Console.WriteLine("Level: " + level);
    }

    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine("Attacked " + enemyName + " for " + damage + " damage.");
    }

    static void GainExperience(int experience)
    {
        Console.WriteLine("Gained " + experience + " XP.");
    }

    static void LevelUp(int newLevel)
    {
        Console.WriteLine("Level Up! New Level: " + newLevel);
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
