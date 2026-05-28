```csharp
/*
📘 Module — Basic Data Types: Integer (int)
📂 Examples File

This file contains small, focused demonstrations of how integers work in C#.

Each example illustrates a common concept or real use case.

▶ Run this file in Visual Studio or with:

    dotnet run
*/

using System;

class Program
{
    static void Main()
    {
        // Rank 1
        Example1_CreateIntegers();
        Example2_PrintIntegers();

        // Rank 2
        Example3_Addition();
        Example4_Subtraction();

        // Rank 3
        Example5_Multiplication();
        Example6_Division();

        // Rank 4
        Example7_IncrementAndDecrement();
        Example8_CompoundOperators();

        // Rank 5
        Example9_GameCharacterStats();
        Example10_InventorySystem();
        Example11_PlayerExperience();
    }

    // ===========================================================================
    // 🟢 Rank 1 — Basic integer creation and printing
    // ===========================================================================

    static void Example1_CreateIntegers()
    {
        Console.WriteLine("Example 1 — Create integers");

        int age = 43;
        int level = 10;
        int score = 100;

        Console.WriteLine(age);
        Console.WriteLine(level);
        Console.WriteLine(score);
        Console.WriteLine();
    }

    static void Example2_PrintIntegers()
    {
        Console.WriteLine("Example 2 — Print integers");

        int gold = 500;

        Console.WriteLine("Gold: " + gold);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔵 Rank 2 — Addition and subtraction
    // ===========================================================================

    static void Example3_Addition()
    {
        Console.WriteLine("Example 3 — Addition");

        int apples = 5;
        int oranges = 3;

        int totalFruit = apples + oranges;

        Console.WriteLine("Total Fruit: " + totalFruit);
        Console.WriteLine();
    }

    static void Example4_Subtraction()
    {
        Console.WriteLine("Example 4 — Subtraction");

        int health = 100;

        health = health - 25;

        Console.WriteLine("Remaining Health: " + health);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟡 Rank 3 — Multiplication and division
    // ===========================================================================

    static void Example5_Multiplication()
    {
        Console.WriteLine("Example 5 — Multiplication");

        int damage = 20;
        int attacks = 3;

        int totalDamage = damage * attacks;

        Console.WriteLine("Total Damage: " + totalDamage);
        Console.WriteLine();
    }

    static void Example6_Division()
    {
        Console.WriteLine("Example 6 — Division");

        int gold = 100;
        int players = 4;

        int goldPerPlayer = gold / players;

        Console.WriteLine("Gold Per Player: " + goldPerPlayer);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟠 Rank 4 — Increment, decrement, and shortcuts
    // ===========================================================================

    static void Example7_IncrementAndDecrement()
    {
        Console.WriteLine("Example 7 — Increment and decrement");

        int level = 1;

        level++;
        Console.WriteLine("After ++ : " + level);

        level--;
        Console.WriteLine("After -- : " + level);

        Console.WriteLine();
    }

    static void Example8_CompoundOperators()
    {
        Console.WriteLine("Example 8 — Compound operators");

        int coins = 100;

        coins += 50;
        Console.WriteLine("After += 50 : " + coins);

        coins -= 25;
        Console.WriteLine("After -= 25 : " + coins);

        coins *= 2;
        Console.WriteLine("After *= 2 : " + coins);

        coins /= 5;
        Console.WriteLine("After /= 5 : " + coins);

        Console.WriteLine();
    }

    // ===========================================================================
    // 🔴 Rank 5 — Professional examples
    // ===========================================================================

    static void Example9_GameCharacterStats()
    {
        Console.WriteLine("Example 9 — Game character stats");

        int level = 25;
        int health = 500;
        int mana = 300;
        int strength = 50;

        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Mana: {mana}");
        Console.WriteLine($"Strength: {strength}");

        Console.WriteLine();
    }

    static void Example10_InventorySystem()
    {
        Console.WriteLine("Example 10 — Inventory system");

        int inventorySlots = 16;
        int usedSlots = 10;

        int freeSlots = inventorySlots - usedSlots;

        Console.WriteLine($"Inventory Slots: {inventorySlots}");
        Console.WriteLine($"Used Slots: {usedSlots}");
        Console.WriteLine($"Free Slots: {freeSlots}");

        Console.WriteLine();
    }

    static void Example11_PlayerExperience()
    {
        Console.WriteLine("Example 11 — Player experience");

        int currentXP = 450;
        int xpNeeded = 1000;

        int remainingXP = xpNeeded - currentXP;

        Console.WriteLine($"Current XP: {currentXP}");
        Console.WriteLine($"XP Needed: {xpNeeded}");
        Console.WriteLine($"Remaining XP: {remainingXP}");

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
