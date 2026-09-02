using System;

namespace LearnHowToCode.OperatorsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Addition
// ==================================================

```
        int addition = 10 + 5;

        Console.WriteLine("10 + 5 = " + addition);

        // ==================================================
        // Example 2 - Subtraction
        // ==================================================

        int subtraction = 20 - 8;

        Console.WriteLine("20 - 8 = " + subtraction);

        // ==================================================
        // Example 3 - Multiplication
        // ==================================================

        int multiplication = 6 * 4;

        Console.WriteLine("6 * 4 = " + multiplication);

        // ==================================================
        // Example 4 - Division
        // ==================================================

        int division = 20 / 5;

        Console.WriteLine("20 / 5 = " + division);

        // ==================================================
        // Example 5 - Modulus
        // ==================================================

        int remainder = 10 % 3;

        Console.WriteLine("10 % 3 = " + remainder);

        // ==================================================
        // Example 6 - Assignment Operator
        // ==================================================

        int score = 100;

        Console.WriteLine("Score = " + score);

        // ==================================================
        // Example 7 - += Operator
        // ==================================================

        score += 50;

        Console.WriteLine("Score += 50 = " + score);

        // ==================================================
        // Example 8 - -= Operator
        // ==================================================

        score -= 25;

        Console.WriteLine("Score -= 25 = " + score);

        // ==================================================
        // Example 9 - *= Operator
        // ==================================================

        score *= 2;

        Console.WriteLine("Score *= 2 = " + score);

        // ==================================================
        // Example 10 - /= Operator
        // ==================================================

        score /= 5;

        Console.WriteLine("Score /= 5 = " + score);

        // ==================================================
        // Example 11 - Equal To
        // ==================================================

        bool isEqual = 10 == 10;

        Console.WriteLine("10 == 10 : " + isEqual);

        // ==================================================
        // Example 12 - Not Equal To
        // ==================================================

        bool isNotEqual = 10 != 5;

        Console.WriteLine("10 != 5 : " + isNotEqual);

        // ==================================================
        // Example 13 - Greater Than
        // ==================================================

        bool greaterThan = 20 > 10;

        Console.WriteLine("20 > 10 : " + greaterThan);

        // ==================================================
        // Example 14 - Less Than
        // ==================================================

        bool lessThan = 5 < 20;

        Console.WriteLine("5 < 20 : " + lessThan);

        // ==================================================
        // Example 15 - Greater Than Or Equal
        // ==================================================

        bool greaterOrEqual = 10 >= 10;

        Console.WriteLine("10 >= 10 : " + greaterOrEqual);

        // ==================================================
        // Example 16 - Less Than Or Equal
        // ==================================================

        bool lessOrEqual = 5 <= 10;

        Console.WriteLine("5 <= 10 : " + lessOrEqual);

        // ==================================================
        // Example 17 - Logical AND
        // ==================================================

        bool andResult = (10 > 5) && (20 > 10);

        Console.WriteLine("AND Result: " + andResult);

        // ==================================================
        // Example 18 - Logical OR
        // ==================================================

        bool orResult = (10 > 5) || (5 > 10);

        Console.WriteLine("OR Result: " + orResult);

        // ==================================================
        // Example 19 - Logical NOT
        // ==================================================

        bool isStudent = true;

        Console.WriteLine("isStudent = " + isStudent);
        Console.WriteLine("!isStudent = " + !isStudent);

        // ==================================================
        // Example 20 - Increment
        // ==================================================

        int level = 1;

        level++;

        Console.WriteLine("Level = " + level);

        // ==================================================
        // Example 21 - Decrement
        // ==================================================

        int lives = 5;

        lives--;

        Console.WriteLine("Lives = " + lives);

        // ==================================================
        // Example 22 - Operator Precedence
        // ==================================================

        int result1 = 5 + 2 * 3;

        Console.WriteLine("5 + 2 * 3 = " + result1);

        // ==================================================
        // Example 23 - Parentheses
        // ==================================================

        int result2 = (5 + 2) * 3;

        Console.WriteLine("(5 + 2) * 3 = " + result2);

        // ==================================================
        // Example 24 - Game Health Example
        // ==================================================

        int playerHealth = 100;

        playerHealth -= 35;

        Console.WriteLine("Player Health = " + playerHealth);

        // ==================================================
        // Example 25 - Store Discount Example
        // ==================================================

        double price = 99.99;
        double discount = 20.00;

        double finalPrice = price - discount;

        Console.WriteLine("Final Price = $" + finalPrice);

        // ==================================================
        // End of Examples
        // ==================================================

        Console.WriteLine("\nAll Operator Examples Completed!");

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
