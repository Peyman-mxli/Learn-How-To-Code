```csharp
/*
📘 Module — Basic Data Types: Integer (int)
Professional Notes

Integers are one of the most commonly used data types in C#.

Integers store whole numbers.

Examples:

- Age
- Level
- Score
- Health
- Quantity
- Gold
- Inventory Slots
- Population
- Number of Players

Whenever a number does NOT need decimal places,
an integer is usually the correct choice.
*/


// ===========================================================================
// 🔢 1. What Is an Integer?
// ===========================================================================
//
// An integer stores whole numbers.
//
// Examples:
//

int age = 43;
int level = 10;
int score = 100;


//
// Integers do NOT store decimals.
//
// Correct:
//

int health = 250;


//
// Wrong:
//
// int price = 19.99;
//
// ERROR
//


// ===========================================================================
// 🏗️ 2. Creating Integers
// ===========================================================================

int playerLevel = 1;
int enemyCount = 5;
int inventorySlots = 16;


//
// Use the int keyword.
//


// ===========================================================================
// 🖨️ 3. Printing Integers
// ===========================================================================

int gold = 500;

Console.WriteLine(gold);


//
// Output:
//
// 500
//


// ===========================================================================
// ➕ 4. Addition
// ===========================================================================

int apples = 5;
int oranges = 3;

int totalFruit = apples + oranges;

Console.WriteLine(totalFruit);


//
// Output:
//
// 8
//


// ===========================================================================
// ➖ 5. Subtraction
// ===========================================================================

int healthPoints = 100;

healthPoints = healthPoints - 25;

Console.WriteLine(healthPoints);


//
// Output:
//
// 75
//


// ===========================================================================
// ✖️ 6. Multiplication
// ===========================================================================

int damage = 20;
int attacks = 3;

int totalDamage = damage * attacks;

Console.WriteLine(totalDamage);


//
// Output:
//
// 60
//


// ===========================================================================
// ➗ 7. Division
// ===========================================================================

int totalGold = 100;
int players = 4;

int goldPerPlayer = totalGold / players;

Console.WriteLine(goldPerPlayer);


//
// Output:
//
// 25
//


// ===========================================================================
// ⚠️ 8. Integer Division
// ===========================================================================
//
// Integers remove decimal values.
//

int result = 10 / 3;

Console.WriteLine(result);


//
// Output:
//
// 3
//
// NOT 3.3333
//


// ===========================================================================
// 🔁 9. Reassigning Values
// ===========================================================================

int scoreValue = 10;

scoreValue = 20;
scoreValue = 50;

Console.WriteLine(scoreValue);


//
// Output:
//
// 50
//


// ===========================================================================
// 🚀 10. Increment Operator
// ===========================================================================
//
// Increase by 1.
//

int levelNumber = 1;

levelNumber++;

Console.WriteLine(levelNumber);


//
// Output:
//
// 2
//


// ===========================================================================
// ⬇️ 11. Decrement Operator
// ===========================================================================
//
// Decrease by 1.
//

int lives = 5;

lives--;

Console.WriteLine(lives);


//
// Output:
//
// 4
//


// ===========================================================================
// 📦 12. Compound Assignment Operators
// ===========================================================================

int coins = 100;

coins += 50;
coins -= 20;
coins *= 2;
coins /= 2;

Console.WriteLine(coins);


//
// Shortcut operators:
//
// +=
// -=
// *=
// /=
//


// ===========================================================================
// 🎮 13. Real Game Example
// ===========================================================================

int playerHealth = 100;
int monsterDamage = 25;

playerHealth -= monsterDamage;

Console.WriteLine(playerHealth);


//
// Output:
//
// 75
//


// ===========================================================================
// 🧮 14. Order of Operations
// ===========================================================================

int answer1 = 2 + 3 * 4;
int answer2 = (2 + 3) * 4;

Console.WriteLine(answer1);
Console.WriteLine(answer2);


//
// Output:
//
// 14
// 20
//


// ===========================================================================
// ⚠️ 15. Common Beginner Errors
// ===========================================================================


// Error 1
//
// Using decimal values
//

// int price = 19.99;


//
// Correct
//

int price = 20;


// ----------------------------------------------------


// Error 2
//
// Using text
//

// int playerName = "Nova";


//
// Correct
//

int playerLevel2 = 10;


// ----------------------------------------------------


// Error 3
//
// Division confusion
//

int divisionResult = 10 / 3;

//
// Output:
//
// 3
//
// Not:
//
// 3.3333
//


// ===========================================================================
// ✅ 16. Best Practices
// ===========================================================================
//
// ✔ Use int for whole numbers
// ✔ Use meaningful variable names
// ✔ Avoid single-letter names
// ✔ Use compound operators when appropriate
// ✔ Be careful with division
//

int totalPlayers = 100;
int enemyLevel = 15;
int inventorySize = 24;


// ===========================================================================
// 🧠 17. Summary
// ===========================================================================
//
// In this module, I learned:
//
// ✔ What integers are
// ✔ How to create integers
// ✔ How to print integers
// ✔ Addition
// ✔ Subtraction
// ✔ Multiplication
// ✔ Division
// ✔ Integer division
// ✔ Increment and decrement
// ✔ Compound operators
// ✔ Real-world examples
// ✔ Common beginner mistakes
// ✔ Best practices
//
// Integers are one of the most important
// numeric data types in C# and are used
// in almost every application.
//


// ===========================================================================

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
