```csharp
/*
📘 Module — Basic Data Types: Boolean (bool)
📂 Examples File

This file contains small, focused demonstrations of how booleans work in C#.

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
        Example1_CreateBooleans();
        Example2_PrintBooleans();

        // Rank 2
        Example3_ComparisonOperators();
        Example4_EqualAndNotEqual();

        // Rank 3
        Example5_GreaterAndLessThan();
        Example6_LogicalAnd();

        // Rank 4
        Example7_LogicalOr();
        Example8_LogicalNot();

        // Rank 5
        Example9_GameCharacterStates();
        Example10_LoginValidation();
        Example11_DungeonAccessSystem();
    }

    // ===========================================================================
    // 🟢 Rank 1 — Basic boolean creation and printing
    // ===========================================================================

    static void Example1_CreateBooleans()
    {
        Console.WriteLine("Example 1 — Create booleans");

        bool isAlive = true;
        bool isDead = false;

        Console.WriteLine(isAlive);
        Console.WriteLine(isDead);
        Console.WriteLine();
    }

    static void Example2_PrintBooleans()
    {
        Console.WriteLine("Example 2 — Print booleans");

        bool isOnline = true;

        Console.WriteLine("Online Status: " + isOnline);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔵 Rank 2 — Comparison operators
    // ===========================================================================

    static void Example3_ComparisonOperators()
    {
        Console.WriteLine("Example 3 — Comparison operators");

        Console.WriteLine(10 > 5);
        Console.WriteLine(3 < 1);
        Console.WriteLine(20 >= 20);

        Console.WriteLine();
    }

    static void Example4_EqualAndNotEqual()
    {
        Console.WriteLine("Example 4 — Equal and not equal");

        bool sameLevel = 25 == 25;
        bool differentLevel = 25 != 10;

        Console.WriteLine(sameLevel);
        Console.WriteLine(differentLevel);

        Console.WriteLine();
    }

    // ===========================================================================
    // 🟡 Rank 3 — Logical operators
    // ===========================================================================

    static void Example5_GreaterAndLessThan()
    {
        Console.WriteLine("Example 5 — Greater and less than");

        bool canUseSkill = 15 > 10;
        bool canEnterZone = 5 < 3;

        Console.WriteLine(canUseSkill);
        Console.WriteLine(canEnterZone);

        Console.WriteLine();
    }

    static void Example6_LogicalAnd()
    {
        Console.WriteLine("Example 6 — Logical AND");

        bool hasSword = true;
        bool hasRequiredLevel = true;

        bool canEnterDungeon =
            hasSword && hasRequiredLevel;

        Console.WriteLine(canEnterDungeon);

        Console.WriteLine();
    }

    // ===========================================================================
    // 🟠 Rank 4 — OR and NOT
    // ===========================================================================

    static void Example7_LogicalOr()
    {
        Console.WriteLine("Example 7 — Logical OR");

        bool hasVIP = false;
        bool hasTicket = true;

        bool canEnterEvent =
            hasVIP || hasTicket;

        Console.WriteLine(canEnterEvent);

        Console.WriteLine();
    }

    static void Example8_LogicalNot()
    {
        Console.WriteLine("Example 8 — Logical NOT");

        bool isDoorOpen = true;

        Console.WriteLine(!isDoorOpen);

        Console.WriteLine();
    }

    // ===========================================================================
    // 🔴 Rank 5 — Professional examples
    // ===========================================================================

    static void Example9_GameCharacterStates()
    {
        Console.WriteLine("Example 9 — Game character states");

        bool isAlive = true;
        bool isInCombat = false;
        bool hasTarget = true;

        Console.WriteLine($"Alive: {isAlive}");
        Console.WriteLine($"In Combat: {isInCombat}");
        Console.WriteLine($"Has Target: {hasTarget}");

        Console.WriteLine();
    }

    static void Example10_LoginValidation()
    {
        Console.WriteLine("Example 10 — Login validation");

        bool usernameValid = true;
        bool passwordValid = true;

        bool canLogin =
            usernameValid && passwordValid;

        Console.WriteLine($"Can Login: {canLogin}");

        Console.WriteLine();
    }

    static void Example11_DungeonAccessSystem()
    {
        Console.WriteLine("Example 11 — Dungeon access system");

        bool hasKey = true;
        bool hasRequiredLevel = true;
        bool isBanned = false;

        bool canEnterDungeon =
            hasKey &&
            hasRequiredLevel &&
            !isBanned;

        Console.WriteLine($"Can Enter Dungeon: {canEnterDungeon}");

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
