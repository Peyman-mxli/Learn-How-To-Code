using System;

namespace LearnHowToCode.OperatorsTaskSolutions
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
        int number1 = 10;
        int number2 = 5;

        int addition = number1 + number2;

        Console.WriteLine("Addition Result: " + addition);

        // Task 2
        int subtraction = number1 - number2;

        Console.WriteLine("Subtraction Result: " + subtraction);

        // Task 3
        int multiplication = number1 * number2;

        Console.WriteLine("Multiplication Result: " + multiplication);

        // Task 4
        int division = number1 / number2;

        Console.WriteLine("Division Result: " + division);

        // Task 5
        int remainder = 15 % 4;

        Console.WriteLine("Remainder: " + remainder);

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        // Task 6
        int score = 100;

        Console.WriteLine("\nInitial Score: " + score);

        // Task 7
        score += 10;

        Console.WriteLine("After += 10: " + score);

        // Task 8
        score -= 5;

        Console.WriteLine("After -= 5: " + score);

        // Task 9
        score *= 2;

        Console.WriteLine("After *= 2: " + score);

        // Task 10
        score /= 3;

        Console.WriteLine("After /= 3: " + score);

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        // Task 11
        bool equalTo = 10 == 10;

        Console.WriteLine("\n10 == 10 : " + equalTo);

        // Task 12
        bool notEqualTo = 10 != 5;

        Console.WriteLine("10 != 5 : " + notEqualTo);

        // Task 13
        bool greaterThan = 20 > 10;

        Console.WriteLine("20 > 10 : " + greaterThan);

        // Task 14
        bool lessThan = 5 < 20;

        Console.WriteLine("5 < 20 : " + lessThan);

        // Task 15
        bool greaterOrEqual = 10 >= 10;
        bool lessOrEqual = 5 <= 10;

        Console.WriteLine("10 >= 10 : " + greaterOrEqual);
        Console.WriteLine("5 <= 10 : " + lessOrEqual);

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        // Task 16
        bool andCondition = (10 > 5) && (20 > 10);

        Console.WriteLine("\nAND Condition: " + andCondition);

        // Task 17
        bool orCondition = (10 > 5) || (5 > 10);

        Console.WriteLine("OR Condition: " + orCondition);

        // Task 18
        bool isActive = true;

        Console.WriteLine("Original Value: " + isActive);
        Console.WriteLine("Reversed Value: " + !isActive);

        // Task 19
        int level = 1;

        level++;

        Console.WriteLine("Level After Increment: " + level);

        // Task 20
        int lives = 5;

        lives--;

        Console.WriteLine("Lives After Decrement: " + lives);

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        // Task 21
        int playerHealth = 100;
        int damageTaken = 30;

        playerHealth -= damageTaken;

        Console.WriteLine("\nPlayer Health: " + playerHealth);

        // Task 22
        double item1 = 19.99;
        double item2 = 49.99;
        double item3 = 29.99;

        double shoppingCartTotal = item1 + item2 + item3;

        Console.WriteLine("Shopping Cart Total: $" + shoppingCartTotal);

        // Task 23
        int studentGrade = 75;
        bool passed = studentGrade >= 60;

        Console.WriteLine("Student Passed: " + passed);

        // Task 24
        bool isLoggedIn = true;
        bool isAdministrator = true;

        bool hasAccess = isLoggedIn && isAdministrator;

        Console.WriteLine("Administrator Access: " + hasAccess);

        // Task 25
        int resultWithoutParentheses = 5 + 2 * 3;
        int resultWithParentheses = (5 + 2) * 3;

        Console.WriteLine("Without Parentheses: " + resultWithoutParentheses);
        Console.WriteLine("With Parentheses: " + resultWithParentheses);

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        // Challenge 1
        int firstNumber = 20;
        int secondNumber = 4;

        Console.WriteLine("\nCalculator Results");
        Console.WriteLine("Addition: " + (firstNumber + secondNumber));
        Console.WriteLine("Subtraction: " + (firstNumber - secondNumber));
        Console.WriteLine("Multiplication: " + (firstNumber * secondNumber));
        Console.WriteLine("Division: " + (firstNumber / secondNumber));

        // Challenge 2
        int checkNumber = 12;

        bool isEven = checkNumber % 2 == 0;

        Console.WriteLine("\nNumber: " + checkNumber);
        Console.WriteLine("Is Even: " + isEven);

        // Challenge 3
        int heroHealth = 100;
        int heroDamage = 15;
        int heroLevel = 1;
        int heroExperience = 0;

        heroHealth -= heroDamage;
        heroExperience += 50;
        heroLevel++;

        Console.WriteLine("\nMini RPG Example");
        Console.WriteLine("Health: " + heroHealth);
        Console.WriteLine("Damage Taken: " + heroDamage);
        Console.WriteLine("Level: " + heroLevel);
        Console.WriteLine("Experience: " + heroExperience);

        Console.WriteLine("\nAll Operator Tasks Completed!");

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
