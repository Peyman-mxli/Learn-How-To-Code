```csharp
/*
📘 Module — Variables in C#
📂 Examples File

This file contains small, focused demonstrations of how variables work in C#.
Each example shows a common concept or realistic use case.

▶ Run this file in Visual Studio or with:

    dotnet run
*/

using System;

class Program
{
    static void Main()
    {
        // Rank 1
        Example1_CreateAndPrintVariables();
        Example2_StoreBasicInformation();

        // Rank 2
        Example3_ChangeVariableValues();
        Example4_UseVariablesInSentences();

        // Rank 3
        Example5_SimpleCalculations();
        Example6_UserInformation();

        // Rank 4
        Example7_Constants();
        Example8_UsingVar();

        // Rank 5
        Example9_GameCharacterStats();
        Example10_ProductSummary();
    }

    // ===========================================================================
    // 🟢 Rank 1 — Beginner
    // ===========================================================================

    static void Example1_CreateAndPrintVariables()
    {
        Console.WriteLine("Example 1 — Create and print variables");

        string name = "Peyman";
        int age = 43;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine();
    }

    static void Example2_StoreBasicInformation()
    {
        Console.WriteLine("Example 2 — Store basic information");

        string city = "Mexicali";
        double temperature = 32.5;
        bool isSunny = true;

        Console.WriteLine(city);
        Console.WriteLine(temperature);
        Console.WriteLine(isSunny);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔵 Rank 2 — Easy
    // ===========================================================================

    static void Example3_ChangeVariableValues()
    {
        Console.WriteLine("Example 3 — Change variable values");

        int score = 10;
        Console.WriteLine("Original score: " + score);

        score = 50;
        Console.WriteLine("New score: " + score);
        Console.WriteLine();
    }

    static void Example4_UseVariablesInSentences()
    {
        Console.WriteLine("Example 4 — Use variables in sentences");

        string studentName = "Peyman";
        int level = 1;

        Console.WriteLine($"{studentName} is learning C#.");
        Console.WriteLine($"{studentName} is currently level {level}.");
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟡 Rank 3 — Intermediate
    // ===========================================================================

    static void Example5_SimpleCalculations()
    {
        Console.WriteLine("Example 5 — Simple calculations");

        int apples = 5;
        int oranges = 3;
        int totalFruit = apples + oranges;

        Console.WriteLine("Apples: " + apples);
        Console.WriteLine("Oranges: " + oranges);
        Console.WriteLine("Total fruit: " + totalFruit);
        Console.WriteLine();
    }

    static void Example6_UserInformation()
    {
        Console.WriteLine("Example 6 — User information");

        string firstName = "Peyman";
        string lastName = "Miyandashti";
        string fullName = firstName + " " + lastName;

        Console.WriteLine("Full name: " + fullName);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟠 Rank 4 — Advanced
    // ===========================================================================

    static void Example7_Constants()
    {
        Console.WriteLine("Example 7 — Constants");

        const double TaxRate = 0.16;
        double price = 100.00;
        double taxAmount = price * TaxRate;
        double finalPrice = price + taxAmount;

        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Tax: $" + taxAmount);
        Console.WriteLine("Final price: $" + finalPrice);
        Console.WriteLine();
    }

    static void Example8_UsingVar()
    {
        Console.WriteLine("Example 8 — Using var");

        var username = "NovaPlayer";
        var playerLevel = 25;
        var speed = 4.5;
        var isAlive = true;

        Console.WriteLine(username);
        Console.WriteLine(playerLevel);
        Console.WriteLine(speed);
        Console.WriteLine(isAlive);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔴 Rank 5 — Professional
    // ===========================================================================

    static void Example9_GameCharacterStats()
    {
        Console.WriteLine("Example 9 — Game character stats");

        string characterName = "Nova";
        int level = 10;
        double health = 250.75;
        double damage = 35.5;
        bool isAlive = true;

        Console.WriteLine($"Character: {characterName}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Damage: {damage}");
        Console.WriteLine($"Alive: {isAlive}");
        Console.WriteLine();
    }

    static void Example10_ProductSummary()
    {
        Console.WriteLine("Example 10 — Product summary");

        string productName = "Keyboard";
        int quantity = 2;
        double price = 599.99;
        double total = quantity * price;

        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Total: ${total}");
        Console.WriteLine();
    }
}

/*
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
