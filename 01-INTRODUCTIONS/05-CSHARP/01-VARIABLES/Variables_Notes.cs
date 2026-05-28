📘 Module — Variables in C#
Professional Notes

Variables are one of the most important concepts in programming.

Almost every program uses variables to store information such as:
- Names
- Ages
- Scores
- Prices
- User input
- Settings
- Calculations

Understanding variables well will make learning the rest of C# much easier.
*/


// ===========================================================================
// 📦 1. What Is a Variable?
// ===========================================================================
//
// A variable is a container that stores data.
//
// Think of a variable like a labeled box.
//
// Example:
//
// Name Box
// ┌─────────────┐
// │   Peyman    │
// └─────────────┘
//
// The label is the variable name.
// The value inside the box is the stored data.
//

string name = "Peyman";


// ===========================================================================
// 🎯 2. Why Variables Matter
// ===========================================================================
//
// Without variables, programs cannot remember information.
//
// Variables allow programs to:
//
// ✔ Store data
// ✔ Reuse data
// ✔ Perform calculations
// ✔ Track changes
// ✔ Handle user input
// ✔ Build dynamic applications
//

int score = 100;


// ===========================================================================
// 🏗️ 3. Declaring Variables
// ===========================================================================
//
// Declaring a variable means creating it.
//
// Syntax:
//
// DataType VariableName;
//

string firstName;
int age;
double salary;
bool isStudent;


// ===========================================================================
// 🚀 4. Initializing Variables
// ===========================================================================
//
// Initializing means giving a variable its first value.
//

string city = "Mexicali";
int level = 10;
double price = 19.99;
bool isOnline = true;


// ===========================================================================
// 🔄 5. Assigning Values
// ===========================================================================
//
// The = operator assigns a value to a variable.
//

int gold;
gold = 500;


// ===========================================================================
// 🔁 6. Reassigning Values
// ===========================================================================
//
// Variables can change their values.
//

int health = 100;

health = 80;
health = 50;
health = 10;


// ===========================================================================
// 📝 7. Variable Naming Rules
// ===========================================================================
//
// ✔ Can contain letters
// ✔ Can contain numbers
// ✔ Can contain underscore (_)
//
// ❌ Cannot start with a number
// ❌ Cannot contain spaces
// ❌ Cannot use C# keywords
//

string playerName;
int level1;
double player_score;


// Wrong Examples:
//
// string 1player;
// int my age;
// string class;


// ===========================================================================
// ✨ 8. Variable Naming Conventions
// ===========================================================================
//
// C# commonly uses camelCase.
//
// Example:
//

string firstName;
string lastName;
int playerLevel;
double weaponDamage;


// Bad Examples:
//

string x;
string a;
int data;


// Better Examples:
//

string customerName;
int totalGold;
double characterSpeed;


// ===========================================================================
// 🧠 9. Understanding Data Types
// ===========================================================================
//
// Every variable has a data type.
//
// The data type tells C# what kind of information
// the variable can store.
//

string heroName = "Nova";
int levelNumber = 50;
double criticalChance = 15.5;
bool isAlive = true;


// ===========================================================================
// 🔍 10. Using var
// ===========================================================================
//
// C# can sometimes automatically determine
// the variable type.
//
// Example:
//

var username = "Peyman";
var ageValue = 43;
var priceValue = 12.99;
var onlineStatus = true;


//
// C# automatically understands:
//
// username = string
// ageValue = int
// priceValue = double
// onlineStatus = bool
//


// ===========================================================================
// 🔒 11. Constants (const)
// ===========================================================================
//
// Constants cannot change after creation.
//
// Use const when a value should never change.
//

const double PI = 3.14159265359;


//
// Wrong:
//
// PI = 10;
//
// This causes an error.
//


// ===========================================================================
// 🌍 12. Variable Scope (Introduction)
// ===========================================================================
//
// Scope means:
//
// "Where can this variable be used?"
//
// Example:
//

void ExampleMethod()
{
    int localScore = 100;

    // localScore only exists inside this method
}

//
// Outside ExampleMethod()
// localScore does not exist.
//


// ===========================================================================
// ⚠️ 13. Common Beginner Errors
// ===========================================================================


// Error 1
//
// Wrong data type
//

// int name = "Peyman";


//
// Correct
//

string nameCorrect = "Peyman";


// ----------------------------------------------------


// Error 2
//
// Missing semicolon
//

// int age = 20

//
// Correct
//

int ageCorrect = 20;


// ----------------------------------------------------


// Error 3
//
// Using variable before assigning value
//

int scoreValue;

// Console.WriteLine(scoreValue);

//
// This causes an error because scoreValue
// has no value yet.
//


// ----------------------------------------------------


// Error 4
//
// Duplicate variable name
//

// int gold = 100;
// int gold = 200;

//
// Same scope = error
//


// ===========================================================================
// ✅ 14. Best Practices
// ===========================================================================
//
// ✔ Use meaningful variable names
// ✔ Use camelCase naming
// ✔ Keep names short but clear
// ✔ Use const for fixed values
// ✔ Avoid cryptic names
// ✔ Choose the correct data type
// ✔ Initialize variables whenever possible
//

string playerName = "Peyman";
int playerLevel = 10;
double playerDamage = 25.5;


// ===========================================================================
// 🧠 15. Summary
// ===========================================================================
//
// In this module, I learned:
//
// ✔ What variables are
// ✔ Why variables matter
// ✔ How to declare variables
// ✔ How to initialize variables
// ✔ How to assign values
// ✔ How to reassign values
// ✔ Variable naming rules
// ✔ Variable naming conventions
// ✔ The var keyword
// ✔ Constants (const)
// ✔ Variable scope
// ✔ Common beginner mistakes
// ✔ Best practices for professional code
//
// Variables are the foundation of nearly every C# program.
// Understanding them well will make future topics much easier.
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
