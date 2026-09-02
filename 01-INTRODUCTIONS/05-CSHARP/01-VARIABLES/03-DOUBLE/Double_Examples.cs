```csharp
/*
📘 Module — Basic Data Types: Double (double)
📂 Examples File

This file contains small, focused demonstrations of how doubles work in C#.

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
        Example1_CreateDoubles();
        Example2_PrintDoubles();

        // Rank 2
        Example3_Addition();
        Example4_Subtraction();

        // Rank 3
        Example5_Multiplication();
        Example6_Division();

        // Rank 4
        Example7_Percentages();
        Example8_DecimalFormatting();

        // Rank 5
        Example9_StorePrices();
        Example10_PlayerStats();
        Example11_ShippingCalculator();
    }

    // ===========================================================================
    // 🟢 Rank 1 — Basic double creation and printing
    // ===========================================================================

    static void Example1_CreateDoubles()
    {
        Console.WriteLine("Example 1 — Create doubles");

        double price = 19.99;
        double height = 1.80;
        double temperature = 32.5;

        Console.WriteLine(price);
        Console.WriteLine(height);
        Console.WriteLine(temperature);
        Console.WriteLine();
    }

    static void Example2_PrintDoubles()
    {
        Console.WriteLine("Example 2 — Print doubles");

        double productPrice = 599.99;

        Console.WriteLine("Price: $" + productPrice);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔵 Rank 2 — Addition and subtraction
    // ===========================================================================

    static void Example3_Addition()
    {
        Console.WriteLine("Example 3 — Addition");

        double keyboard = 599.99;
        double mouse = 299.99;

        double total = keyboard + mouse;

        Console.WriteLine("Total: $" + total);
        Console.WriteLine();
    }

    static void Example4_Subtraction()
    {
        Console.WriteLine("Example 4 — Subtraction");

        double balance = 1000.00;

        balance -= 249.99;

        Console.WriteLine("Remaining Balance: $" + balance);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟡 Rank 3 — Multiplication and division
    // ===========================================================================

    static void Example5_Multiplication()
    {
        Console.WriteLine("Example 5 — Multiplication");

        double price = 19.99;
        double quantity = 3;

        double totalCost = price * quantity;

        Console.WriteLine("Total Cost: $" + totalCost);
        Console.WriteLine();
    }

    static void Example6_Division()
    {
        Console.WriteLine("Example 6 — Division");

        double distance = 150.0;
        double hours = 3.0;

        double speed = distance / hours;

        Console.WriteLine("Average Speed: " + speed);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟠 Rank 4 — Percentages and formatting
    // ===========================================================================

    static void Example7_Percentages()
    {
        Console.WriteLine("Example 7 — Percentages");

        double completionRate = 87.5;

        Console.WriteLine($"Completion Rate: {completionRate}%");
        Console.WriteLine();
    }

    static void Example8_DecimalFormatting()
    {
        Console.WriteLine("Example 8 — Decimal formatting");

        double pi = 3.14159265359;

        Console.WriteLine(pi);
        Console.WriteLine(pi.ToString("F2"));
        Console.WriteLine(pi.ToString("F4"));

        Console.WriteLine();
    }

    // ===========================================================================
    // 🔴 Rank 5 — Professional examples
    // ===========================================================================

    static void Example9_StorePrices()
    {
        Console.WriteLine("Example 9 — Store prices");

        double keyboardPrice = 599.99;
        double monitorPrice = 3999.99;

        Console.WriteLine($"Keyboard: ${keyboardPrice}");
        Console.WriteLine($"Monitor: ${monitorPrice}");

        Console.WriteLine();
    }

    static void Example10_PlayerStats()
    {
        Console.WriteLine("Example 10 — Player stats");

        double criticalChance = 15.5;
        double attackSpeed = 1.75;
        double movementSpeed = 4.25;

        Console.WriteLine($"Critical Chance: {criticalChance}%");
        Console.WriteLine($"Attack Speed: {attackSpeed}");
        Console.WriteLine($"Movement Speed: {movementSpeed}");

        Console.WriteLine();
    }

    static void Example11_ShippingCalculator()
    {
        Console.WriteLine("Example 11 — Shipping calculator");

        double packageWeight = 2.75;
        double costPerKg = 4.50;

        double shippingCost = packageWeight * costPerKg;

        Console.WriteLine($"Package Weight: {packageWeight} kg");
        Console.WriteLine($"Shipping Cost: ${shippingCost:F2}");

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
