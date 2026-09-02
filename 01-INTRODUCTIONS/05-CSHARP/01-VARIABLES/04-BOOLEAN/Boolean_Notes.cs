```csharp
/*
📘 Module — Basic Data Types: Boolean (bool)
Professional Notes

Booleans are used to store logical values in C#.

A boolean can only store one of two values:

- true
- false

Booleans are one of the most important data types in programming.

They are used everywhere:

- Login Systems
- Password Validation
- Game States
- Conditions
- Loops
- User Permissions
- Inventory Systems
- Online Status
- Character States

This file provides a structured overview with examples and best practices.
*/


// ===========================================================================
// ✅ 1. What Is a Boolean?
// ===========================================================================
//
// A boolean stores either:
//
// true
// false
//

bool isAlive = true;
bool isDead = false;


//
// A boolean can NEVER store:
//
// "true"
// "false"
// 1
// 0
// "yes"
//
// Only:
//
// true
// false
//


// ===========================================================================
// 🏗️ 2. Creating Boolean Variables
// ===========================================================================

bool isStudent = true;
bool isOnline = false;
bool hasQuest = true;


//
// Use the bool keyword.
//


// ===========================================================================
// 🖨️ 3. Printing Booleans
// ===========================================================================

bool isAdmin = true;

Console.WriteLine(isAdmin);


//
// Output:
//
// True
//


// ===========================================================================
// 🎮 4. Game State Examples
// ===========================================================================

bool playerAlive = true;
bool bossDefeated = false;
bool inCombat = true;

Console.WriteLine(playerAlive);
Console.WriteLine(bossDefeated);
Console.WriteLine(inCombat);


//
// Booleans are heavily used in games.
//


// ===========================================================================
// ⚖️ 5. Comparison Operators
// ===========================================================================
//
// Comparisons return booleans.
//

Console.WriteLine(5 > 3);

Console.WriteLine(10 < 2);

Console.WriteLine(5 == 5);

Console.WriteLine(5 != 3);


//
// Output:
//
// True
// False
// True
// True
//


// ===========================================================================
// 🔍 6. Equal To (==)
// ===========================================================================

bool sameValue = 10 == 10;

Console.WriteLine(sameValue);


//
// Output:
//
// True
//


// ===========================================================================
// 🚫 7. Not Equal To (!=)
// ===========================================================================

bool differentValue = 10 != 5;

Console.WriteLine(differentValue);


//
// Output:
//
// True
//


// ===========================================================================
// ⬆️ 8. Greater Than (>)
//
// ===========================================================================

bool greaterResult = 50 > 10;

Console.WriteLine(greaterResult);


//
// Output:
//
// True
//


// ===========================================================================
// ⬇️ 9. Less Than (<)
// ===========================================================================

bool lessResult = 10 < 50;

Console.WriteLine(lessResult);


//
// Output:
//
// True
//


// ===========================================================================
// 🔗 10. Logical AND (&&)
// ===========================================================================
//
// Both sides must be true.
//

bool hasSword = true;
bool hasLevel = true;

bool canEnterDungeon =
    hasSword && hasLevel;

Console.WriteLine(canEnterDungeon);


//
// Output:
//
// True
//


// ===========================================================================
// 🔀 11. Logical OR (||)
// ===========================================================================
//
// Only one side needs to be true.
//

bool hasVIP = false;
bool hasTicket = true;

bool canEnter =
    hasVIP || hasTicket;

Console.WriteLine(canEnter);


//
// Output:
//
// True
//


// ===========================================================================
// ❗ 12. Logical NOT (!)
// ===========================================================================
//
// Reverses the value.
//

bool isDoorOpen = true;

Console.WriteLine(!isDoorOpen);


//
// Output:
//
// False
//


// ===========================================================================
// 🔄 13. Reassigning Booleans
// ===========================================================================

bool questCompleted = false;

questCompleted = true;

Console.WriteLine(questCompleted);


//
// Output:
//
// True
//


// ===========================================================================
// 🔐 14. Validation Example
// ===========================================================================

bool passwordValid = true;
bool emailValid = true;

bool accountValid =
    passwordValid && emailValid;

Console.WriteLine(accountValid);


//
// Output:
//
// True
//


// ===========================================================================
// ⚠️ 15. Common Beginner Errors
// ===========================================================================


// Error 1
//
// Using quotes
//

// bool isAlive = "true";


//
// Correct
//

bool alive = true;


// ----------------------------------------------------


// Error 2
//
// Using numbers
//

// bool online = 1;


//
// Correct
//

bool onlineStatus = true;


// ----------------------------------------------------


// Error 3
//
// Confusing = and ==
//

// Wrong:
//
// if (age = 18)

//
// Correct:
//
// if (age == 18)
//


// ===========================================================================
// ✅ 16. Best Practices
// ===========================================================================
//
// ✔ Use meaningful names
// ✔ Start with words like:
//
// is
// has
// can
// should
//
// Examples:
//

bool isAliveNow = true;
bool hasInventory = true;
bool canAttack = true;
bool shouldRespawn = false;


//
// Good boolean names read like questions.
//


// ===========================================================================
// 🧠 17. Summary
// ===========================================================================
//
// In this module, I learned:
//
// ✔ What booleans are
// ✔ How to create booleans
// ✔ How to print booleans
// ✔ Comparison operators
// ✔ Logical AND
// ✔ Logical OR
// ✔ Logical NOT
// ✔ Validation examples
// ✔ Game state examples
// ✔ Common beginner mistakes
// ✔ Best practices
//
// Booleans are one of the most important
// foundations for conditions and decision-making
// in C#.
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
