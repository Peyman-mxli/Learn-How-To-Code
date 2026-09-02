```csharp
/*
📘 Module — Basic Data Types: String (string)
Practice Task Solutions

This file contains clean, readable solutions to all tasks in
String_Tasks.cs.

Multiple answers are possible. These solutions show simple and professional approaches.

⚠️ IMPORTANT:
Only read these solutions AFTER attempting the tasks yourself!
*/


// ===========================================================================
// 🟢 Rank 1 — Beginner
// ===========================================================================


// 🔹 Task 1.1

string greeting = "Hello, World!";
Console.WriteLine(greeting);


// 🔹 Task 1.2

string firstName = "Peyman";
Console.WriteLine(firstName);


// 🔹 Task 1.3

string city = "Mexicali";
Console.WriteLine($"City: {city}");


// 🔹 Task 1.4

string message = "I am learning C# strings.";
Console.WriteLine(message);


// ===========================================================================
// 🔵 Rank 2 — Easy
// ===========================================================================


// 🔹 Task 2.1

string firstName2 = "Peyman";
string lastName = "Miyandashti";

string fullName = firstName2 + " " + lastName;

Console.WriteLine($"Full Name: {fullName}");


// 🔹 Task 2.2

string language = "C#";

Console.WriteLine($"I am learning {language}.");


// 🔹 Task 2.3

string school = "Polytechnic University of Baja California";

Console.WriteLine($"Length: {school.Length}");


// 🔹 Task 2.4

string gameName = "Nova Zone";

Console.WriteLine($"Game Name: {gameName}");


// ===========================================================================
// 🟡 Rank 3 — Intermediate
// ===========================================================================


// 🔹 Task 3.1

string word = "Programming";

Console.WriteLine($"First Character: {word[0]}");
Console.WriteLine($"Last Character: {word[word.Length - 1]}");


// 🔹 Task 3.2

string text = "CSharp";

Console.WriteLine(text.Substring(0, 4));


// 🔹 Task 3.3

string sentence = "I like Java";

string updatedSentence =
    sentence.Replace("Java", "C#");

Console.WriteLine(updatedSentence);


// 🔹 Task 3.4

string title = "Learning C#";

Console.WriteLine(title.Contains("C#"));


// ===========================================================================
// 🟠 Rank 4 — Advanced
// ===========================================================================


// 🔹 Task 4.1

string rawName = "   peyman   ";

string cleanName =
    rawName.Trim().ToUpper();

Console.WriteLine(cleanName);


// 🔹 Task 4.2

string email = "peyman@example.com";

bool containsAt =
    email.Contains("@");

bool containsDot =
    email.Contains(".");

Console.WriteLine(containsAt);
Console.WriteLine(containsDot);


// 🔹 Task 4.3

string fileName = "Notes.cs";

Console.WriteLine(
    fileName.EndsWith(".cs")
);


// 🔹 Task 4.4

string username = "   NovaPlayer   ";

string cleanUsername =
    username.Trim().ToLower();

Console.WriteLine(cleanUsername);


// ===========================================================================
// 🔴 Rank 5 — Professional
// ===========================================================================


// 🔹 Task 5.1

string name = "Peyman";
string userCity = "Mexicali";
string career = "Information Technology";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"City: {userCity}");
Console.WriteLine($"Career: {career}");


// 🔹 Task 5.2

string productName = "Keyboard";
double price = 599.99;

Console.WriteLine(
    $"Product: {productName} | Price: ${price}"
);


// 🔹 Task 5.3

string rawUsername = "   PEYMAN NOVA   ";

string sanitizedUsername =
    rawUsername
        .Trim()
        .ToLower()
        .Replace(" ", "_");

Console.WriteLine(sanitizedUsername);


// 🔹 Task 5.4

string password = "Nova12345";

bool lengthValid =
    password.Length >= 8;

bool contains123 =
    password.Contains("123");

Console.WriteLine(
    $"Length Valid: {lengthValid}"
);

Console.WriteLine(
    $"Contains 123: {contains123}"
);


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
