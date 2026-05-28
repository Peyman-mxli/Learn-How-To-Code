```csharp
/*
📘 Module — Basic Data Types: String (string)
Professional Notes

Strings represent text in C#.

They are used everywhere:

- Names
- Messages
- User input
- File paths
- Passwords
- Menus
- APIs
- Databases
- Game text
- User interfaces

Strings are one of the most commonly used data types in C#.

This file provides a structured overview with examples and best practices.
*/


// ===========================================================================
// 🧵 1. What Is a String?
// ===========================================================================
//
// A string stores text.
//
// Examples:
//

string firstName = "Peyman";
string city = "Mexicali";
string gameName = "Nova Zone";


//
// Everything inside quotation marks is text.
//


// ===========================================================================
// 🏗️ 2. Creating Strings
// ===========================================================================

string heroName = "Nova";
string guildName = "Guardians";
string country = "Mexico";


//
// String variables use the string keyword.
//


// ===========================================================================
// 🖨️ 3. Printing Strings
// ===========================================================================

Console.WriteLine("Hello World");

string playerName = "Peyman";

Console.WriteLine(playerName);


//
// Output:
//
// Hello World
// Peyman
//


// ===========================================================================
// ➕ 4. String Concatenation
// ===========================================================================
//
// Concatenation means joining strings together.
//

string first = "Peyman";
string last = "Miyandashti";

string fullName = first + " " + last;

Console.WriteLine(fullName);


//
// Output:
//
// Peyman Miyandashti
//


// ===========================================================================
// ✨ 5. String Interpolation (Recommended)
// ===========================================================================
//
// String interpolation is cleaner and easier to read.
//

string characterName = "Nova";
int level = 25;

Console.WriteLine($"Character: {characterName}");
Console.WriteLine($"Level: {level}");


//
// The $ symbol allows variables inside text.
//


// ===========================================================================
// 🔢 6. String Length
// ===========================================================================
//
// Length returns the number of characters.
//

string text = "Programming";

Console.WriteLine(text.Length);


//
// Output:
//
// 11
//


// ===========================================================================
// 🔍 7. Accessing Characters (Indexing)
// ===========================================================================
//
// Strings are made of characters.
//
// Every character has a position.
//
// Example:
//
// P r o g r a m
// 0 1 2 3 4 5 6
//

string word = "Programming";

Console.WriteLine(word[0]);
Console.WriteLine(word[1]);
Console.WriteLine(word[2]);


//
// Output:
//
// P
// r
// o
//


// ===========================================================================
// ✂️ 8. Accessing First and Last Character
// ===========================================================================

string language = "CSharp";

Console.WriteLine(language[0]);

Console.WriteLine(language[language.Length - 1]);


//
// Output:
//
// C
// p
//


// ===========================================================================
// 🔒 9. String Immutability
// ===========================================================================
//
// Strings cannot be changed after creation.
//
// This is called:
//
// Immutability
//

string originalText = "Hello";

//
// Wrong:
//
// originalText[0] = 'J';
//
// ERROR
//

//
// Correct:
//

string newText = "J" + originalText.Substring(1);

Console.WriteLine(newText);


//
// Output:
//
// Jello
//


// ===========================================================================
// 🧰 10. ToUpper()
// ===========================================================================
//
// Converts text to uppercase.
//

string message = "hello world";

Console.WriteLine(message.ToUpper());


//
// Output:
//
// HELLO WORLD
//


// ===========================================================================
// 🧰 11. ToLower()
// ===========================================================================
//
// Converts text to lowercase.
//

string userName = "PEYMAN";

Console.WriteLine(userName.ToLower());


//
// Output:
//
// peyman
//


// ===========================================================================
// 🧰 12. Trim()
// ===========================================================================
//
// Removes spaces from beginning and end.
//

string rawInput = "   Peyman   ";

Console.WriteLine(rawInput.Trim());


//
// Output:
//
// Peyman
//


// ===========================================================================
// 🧰 13. Replace()
// ===========================================================================
//
// Replaces text.
//

string sentence = "I like Java";

Console.WriteLine(
    sentence.Replace("Java", "C#")
);


//
// Output:
//
// I like C#
//


// ===========================================================================
// 🧰 14. Contains()
// ===========================================================================
//
// Checks if text exists.
//

string game = "Nova Zone";

Console.WriteLine(
    game.Contains("Nova")
);


//
// Output:
//
// True
//


// ===========================================================================
// 🧰 15. StartsWith()
// ===========================================================================

string title = "Programming";

Console.WriteLine(
    title.StartsWith("Pro")
);


//
// Output:
//
// True
//


// ===========================================================================
// 🧰 16. EndsWith()
// ===========================================================================

string fileName = "Notes.cs";

Console.WriteLine(
    fileName.EndsWith(".cs")
);


//
// Output:
//
// True
//


// ===========================================================================
// ⛔ 17. Escape Characters
// ===========================================================================
//
// Escape characters allow special symbols.
//

Console.WriteLine("Line 1\nLine 2");

Console.WriteLine("She said \"Hello\"");

Console.WriteLine("Column1\tColumn2");


//
// \n = New Line
// \t = Tab
// \" = Quote
//


// ===========================================================================
// 📜 18. Multi-Line Strings
// ===========================================================================

string description =
@"Welcome
to
C#";

Console.WriteLine(description);


//
// Output:
//
// Welcome
// to
// C#
//


// ===========================================================================
// ❓ 19. Empty Strings
// ===========================================================================

string emptyText = "";

Console.WriteLine(emptyText.Length);


//
// Output:
//
// 0
//


// ===========================================================================
// 🚫 20. Null Strings
// ===========================================================================

string nullableText = null;


//
// Null means:
//
// No object exists
//
// Be careful when using null.
//


// ===========================================================================
// ⚖️ 21. String Comparison
// ===========================================================================

string a = "Nova";
string b = "Nova";

Console.WriteLine(a == b);


//
// Output:
//
// True
//


// ===========================================================================
// 🔁 22. Looping Through Characters
// ===========================================================================

string name = "Nova";

foreach (char letter in name)
{
    Console.WriteLine(letter);
}


//
// Output:
//
// N
// o
// v
// a
//


// ===========================================================================
// ⚠️ 23. Common Beginner Errors
// ===========================================================================


// Error 1
//
// Missing quotation marks
//

// string name = Peyman;


//
// Correct
//

string correctName = "Peyman";


// ----------------------------------------------------


// Error 2
//
// Wrong data type
//

// int playerName = "Nova";


//
// Correct
//

string playerNameCorrect = "Nova";


// ----------------------------------------------------


// Error 3
//
// Index out of range
//

string sample = "Cat";

//
// Wrong:
//
// Console.WriteLine(sample[10]);
//
// ERROR
//


// ----------------------------------------------------


// Error 4
//
// Forgetting string is immutable
//

string textValue = "Hello";

//
// textValue[0] = 'J';
//
// ERROR
//


// ===========================================================================
// ✅ 24. Best Practices
// ===========================================================================
//
// ✔ Use meaningful variable names
// ✔ Use string interpolation when possible
// ✔ Use Trim() when handling user input
// ✔ Use ToLower() or ToUpper() when comparing text
// ✔ Check Length before accessing indexes
// ✔ Keep text readable
//

string customerName = "Peyman";
string productName = "Keyboard";

Console.WriteLine(
    $"Customer: {customerName}"
);


//
// Recommended style:
//


// ===========================================================================
// 🧠 25. Summary
// ===========================================================================
//
// In this module, I learned:
//
// ✔ What strings are
// ✔ How to create strings
// ✔ How to print strings
// ✔ String concatenation
// ✔ String interpolation
// ✔ String length
// ✔ Accessing characters
// ✔ String immutability
// ✔ Common string methods
// ✔ Escape characters
// ✔ Multi-line strings
// ✔ Empty and null strings
// ✔ String comparison
// ✔ Looping through text
// ✔ Common beginner mistakes
// ✔ Best practices
//
// Strings are one of the most important
// data types in C# and are used in almost
// every real-world application.
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
