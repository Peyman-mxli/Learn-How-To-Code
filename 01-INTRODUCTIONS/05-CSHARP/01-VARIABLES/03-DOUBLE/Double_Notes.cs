```csharp
/*
📘 Module — Basic Data Types: Double (double)
Professional Notes

Doubles are used to store decimal numbers in C#.

Whenever a number needs digits after the decimal point,
double is usually the correct choice.

Examples:

- Prices
- Tax Rates
- Measurements
- Speed
- Weight
- Height
- Percentages
- Scientific Calculations

This file provides a structured overview with examples and best practices.
*/


// ===========================================================================
// 🔢 1. What Is a Double?
// ===========================================================================
//
// A double stores decimal numbers.
//
// Examples:
//

double price = 19.99;
double height = 1.80;
double temperature = 32.5;


//
// Unlike int, doubles can store decimal values.
//


// ===========================================================================
// 🏗️ 2. Creating Doubles
// ===========================================================================

double weight = 72.5;
double distance = 12.75;
double taxRate = 0.16;


//
// Use the double keyword.
//


// ===========================================================================
// 🖨️ 3. Printing Doubles
// ===========================================================================

double productPrice = 599.99;

Console.WriteLine(productPrice);


//
// Output:
//
// 599.99
//


// ===========================================================================
// ➕ 4. Addition
// ===========================================================================

double item1 = 19.99;
double item2 = 5.50;

double total = item1 + item2;

Console.WriteLine(total);


//
// Output:
//
// 25.49
//


// ===========================================================================
// ➖ 5. Subtraction
// ===========================================================================

double balance = 100.00;

balance = balance - 25.50;

Console.WriteLine(balance);


//
// Output:
//
// 74.50
//


// ===========================================================================
// ✖️ 6. Multiplication
// ===========================================================================

double pricePerItem = 12.50;
double quantity = 4;

double totalCost = pricePerItem * quantity;

Console.WriteLine(totalCost);


//
// Output:
//
// 50.00
//


// ===========================================================================
// ➗ 7. Division
// ===========================================================================

double totalDistance = 100.0;
double hours = 4.0;

double speed = totalDistance / hours;

Console.WriteLine(speed);


//
// Output:
//
// 25.0
//


// ===========================================================================
// 🎯 8. Why Use Double Instead of Int?
// ===========================================================================

int integerResult = 10 / 3;

Console.WriteLine(integerResult);


//
// Output:
//
// 3
//


double doubleResult = 10.0 / 3.0;

Console.WriteLine(doubleResult);


//
// Output:
//
// 3.333333...
//


// ===========================================================================
// 📊 9. Percentages
// ===========================================================================

double completionRate = 87.5;

Console.WriteLine(
    $"Completion Rate: {completionRate}%"
);


//
// Percentages commonly use double.
//


// ===========================================================================
// 💰 10. Prices and Money
// ===========================================================================

double keyboardPrice = 599.99;
double mousePrice = 299.99;

double cartTotal =
    keyboardPrice + mousePrice;

Console.WriteLine(cartTotal);


//
// NOTE:
//
// Real financial software usually uses decimal.
//
// For learning purposes we use double here.
//


// ===========================================================================
// 📏 11. Measurements
// ===========================================================================

double heightInMeters = 1.82;
double weightInKg = 75.5;

Console.WriteLine(heightInMeters);
Console.WriteLine(weightInKg);


//
// Measurements commonly use doubles.
//


// ===========================================================================
// 🔄 12. Reassigning Values
// ===========================================================================

double healthMultiplier = 1.0;

healthMultiplier = 1.5;
healthMultiplier = 2.0;

Console.WriteLine(healthMultiplier);


//
// Output:
//
// 2.0
//


// ===========================================================================
// 🧮 13. Formatting Decimal Places
// ===========================================================================

double pi = 3.14159265359;

Console.WriteLine(pi);

Console.WriteLine(
    pi.ToString("F2")
);

Console.WriteLine(
    pi.ToString("F4")
);


//
// Output:
//
// 3.14159265359
// 3.14
// 3.1416
//


// ===========================================================================
// ⚠️ 14. Common Beginner Errors
// ===========================================================================


// Error 1
//
// Using text inside double
//

// double price = "19.99";


//
// Correct
//

double correctPrice = 19.99;


// ----------------------------------------------------


// Error 2
//
// Using int when decimal is needed
//

// int height = 1.80;


//
// Correct
//

double heightCorrect = 1.80;


// ----------------------------------------------------


// Error 3
//
// Forgetting decimal values
//

double tax = 0.16;

//
// Correct:
//
// 0.16
//
// Not:
//
// 16
//


// ===========================================================================
// ✅ 15. Best Practices
// ===========================================================================
//
// ✔ Use double for decimal values
// ✔ Use meaningful variable names
// ✔ Format output when displaying prices
// ✔ Use double for measurements and percentages
// ✔ Use consistent naming conventions
//

double playerSpeed = 4.75;
double criticalChance = 15.5;
double attackRange = 8.25;


// ===========================================================================
// 🧠 16. Summary
// ===========================================================================
//
// In this module, I learned:
//
// ✔ What doubles are
// ✔ How to create doubles
// ✔ How to print doubles
// ✔ Addition
// ✔ Subtraction
// ✔ Multiplication
// ✔ Division
// ✔ Percentages
// ✔ Prices
// ✔ Measurements
// ✔ Decimal formatting
// ✔ Common beginner mistakes
// ✔ Best practices
//
// Doubles are one of the most important
// numeric data types in C# whenever
// decimal precision is needed.
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
