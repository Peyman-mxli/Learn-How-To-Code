using System;

namespace LearnHowToCode.MethodsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Simple Void Method
// ==================================================

```
        SayHello();

        // ==================================================
        // Example 2 - Calling A Method Multiple Times
        // ==================================================

        SayHello();
        SayHello();
        SayHello();

        // ==================================================
        // Example 3 - Method With Parameter
        // ==================================================

        SayHelloTo("Peyman");

        // ==================================================
        // Example 4 - Multiple Calls With Parameters
        // ==================================================

        SayHelloTo("Maria");
        SayHelloTo("John");
        SayHelloTo("David");

        // ==================================================
        // Example 5 - Method With Multiple Parameters
        // ==================================================

        DisplayPlayer("Peyman", 25);

        // ==================================================
        // Example 6 - Method Returning Integer
        // ==================================================

        int level = GetLevel();

        Console.WriteLine("Level: " + level);

        // ==================================================
        // Example 7 - Method Returning String
        // ==================================================

        string playerName = GetPlayerName();

        Console.WriteLine("Player Name: " + playerName);

        // ==================================================
        // Example 8 - Method Returning Boolean
        // ==================================================

        bool alive = IsAlive();

        Console.WriteLine("Alive: " + alive);

        // ==================================================
        // Example 9 - Method Returning Double
        // ==================================================

        double price = GetPrice();

        Console.WriteLine("Price: $" + price);

        // ==================================================
        // Example 10 - Method With Return And Parameters
        // ==================================================

        int result = Add(10, 20);

        Console.WriteLine("Result: " + result);

        // ==================================================
        // Example 11 - Subtraction Method
        // ==================================================

        int subtraction = Subtract(50, 15);

        Console.WriteLine("Subtraction: " + subtraction);

        // ==================================================
        // Example 12 - Multiplication Method
        // ==================================================

        int multiplication = Multiply(5, 8);

        Console.WriteLine("Multiplication: " + multiplication);

        // ==================================================
        // Example 13 - Division Method
        // ==================================================

        double division = Divide(20, 4);

        Console.WriteLine("Division: " + division);

        // ==================================================
        // Example 14 - Check Adult Method
        // ==================================================

        bool isAdult = IsAdult(25);

        Console.WriteLine("Adult: " + isAdult);

        // ==================================================
        // Example 15 - Display Menu Method
        // ==================================================

        DisplayMenu();

        // ==================================================
        // Example 16 - Calculate Square
        // ==================================================

        int square = CalculateSquare(5);

        Console.WriteLine("Square: " + square);

        // ==================================================
        // Example 17 - Calculate Area
        // ==================================================

        double area = CalculateRectangleArea(10, 5);

        Console.WriteLine("Area: " + area);

        // ==================================================
        // Example 18 - Character Creation
        // ==================================================

        CreateCharacter("Warrior");

        // ==================================================
        // Example 19 - Experience Reward
        // ==================================================

        GiveExperience("Peyman", 500);

        // ==================================================
        // Example 20 - Method Reuse Example
        // ==================================================

        ShowSeparator();
        ShowSeparator();
        ShowSeparator();

        Console.WriteLine("\nAll Method Examples Completed!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // ==================================================
    // Methods
    // ==================================================

    static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    static void SayHelloTo(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void DisplayPlayer(string name, int level)
    {
        Console.WriteLine("Player: " + name);
        Console.WriteLine("Level: " + level);
    }

    static int GetLevel()
    {
        return 25;
    }

    static string GetPlayerName()
    {
        return "Peyman";
    }

    static bool IsAlive()
    {
        return true;
    }

    static double GetPrice()
    {
        return 19.99;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static bool IsAdult(int age)
    {
        return age >= 18;
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n=== MENU ===");
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Settings");
        Console.WriteLine("3. Exit");
    }

    static int CalculateSquare(int number)
    {
        return number * number;
    }

    static double CalculateRectangleArea(double width, double height)
    {
        return width * height;
    }

    static void CreateCharacter(string characterClass)
    {
        Console.WriteLine("Character Created: " + characterClass);
    }

    static void GiveExperience(string playerName, int experience)
    {
        Console.WriteLine(playerName + " gained " + experience + " XP.");
    }

    static void ShowSeparator()
    {
        Console.WriteLine("------------------------------");
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
