```csharp
/*
📘 Module — Basic Data Types: String (string)
📂 Examples File

This file contains small, focused demonstrations of how strings work in C#.

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
        Example1_StringCreation();
        Example2_PrintStrings();

        // Rank 2
        Example3_Concatenation();
        Example4_StringInterpolation();

        // Rank 3
        Example5_StringLength();
        Example6_AccessCharacters();

        // Rank 4
        Example7_StringMethods();
        Example8_EscapeCharacters();

        // Rank 5
        Example9_CleanUserInput();
        Example10_ProductMessage();
        Example11_SimpleEmailCheck();
    }

    // ===========================================================================
    // 🟢 Rank 1 — Basic string creation and printing
    // ===========================================================================

    static void Example1_StringCreation()
    {
        Console.WriteLine("Example 1 — String creation");

        string firstName = "Peyman";
        string city = "Mexicali";
        string message = "I am learning C#";

        Console.WriteLine(firstName);
        Console.WriteLine(city);
        Console.WriteLine(message);
        Console.WriteLine();
    }

    static void Example2_PrintStrings()
    {
        Console.WriteLine("Example 2 — Print strings");

        Console.WriteLine("Hello World");
        Console.WriteLine("Welcome to C#");
        Console.WriteLine("Strings store text");
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔵 Rank 2 — Concatenation and interpolation
    // ===========================================================================

    static void Example3_Concatenation()
    {
        Console.WriteLine("Example 3 — String concatenation");

        string firstName = "Peyman";
        string lastName = "Miyandashti";
        string fullName = firstName + " " + lastName;

        Console.WriteLine(fullName);
        Console.WriteLine();
    }

    static void Example4_StringInterpolation()
    {
        Console.WriteLine("Example 4 — String interpolation");

        string studentName = "Peyman";
        int level = 1;

        Console.WriteLine($"{studentName} is learning C#.");
        Console.WriteLine($"{studentName} is currently level {level}.");
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟡 Rank 3 — Length and character access
    // ===========================================================================

    static void Example5_StringLength()
    {
        Console.WriteLine("Example 5 — String length");

        string language = "CSharp";

        Console.WriteLine("Text: " + language);
        Console.WriteLine("Length: " + language.Length);
        Console.WriteLine();
    }

    static void Example6_AccessCharacters()
    {
        Console.WriteLine("Example 6 — Access characters");

        string word = "Programming";

        Console.WriteLine("First character: " + word[0]);
        Console.WriteLine("Second character: " + word[1]);
        Console.WriteLine("Last character: " + word[word.Length - 1]);
        Console.WriteLine();
    }

    // ===========================================================================
    // 🟠 Rank 4 — Common methods and escape characters
    // ===========================================================================

    static void Example7_StringMethods()
    {
        Console.WriteLine("Example 7 — Common string methods");

        string rawText = "   Hello C# World   ";

        Console.WriteLine("Original: [" + rawText + "]");
        Console.WriteLine("Trim: [" + rawText.Trim() + "]");
        Console.WriteLine("Upper: " + rawText.ToUpper());
        Console.WriteLine("Lower: " + rawText.ToLower());
        Console.WriteLine("Replace: " + rawText.Replace("C#", "Programming"));
        Console.WriteLine("Contains C#: " + rawText.Contains("C#"));
        Console.WriteLine();
    }

    static void Example8_EscapeCharacters()
    {
        Console.WriteLine("Example 8 — Escape characters");

        Console.WriteLine("Line 1\nLine 2");
        Console.WriteLine("She said \"Hello\"");
        Console.WriteLine("Name:\tPeyman");
        Console.WriteLine();
    }

    // ===========================================================================
    // 🔴 Rank 5 — Professional patterns
    // ===========================================================================

    static void Example9_CleanUserInput()
    {
        Console.WriteLine("Example 9 — Clean user input");

        string rawUsername = "   PEYMAN   ";
        string cleanUsername = rawUsername.Trim().ToLower();

        Console.WriteLine("Raw username: [" + rawUsername + "]");
        Console.WriteLine("Clean username: [" + cleanUsername + "]");
        Console.WriteLine();
    }

    static void Example10_ProductMessage()
    {
        Console.WriteLine("Example 10 — Product message");

        string productName = "Keyboard";
        double price = 599.99;

        string message = $"Product: {productName} | Price: ${price}";

        Console.WriteLine(message);
        Console.WriteLine();
    }

    static void Example11_SimpleEmailCheck()
    {
        Console.WriteLine("Example 11 — Simple email check");

        string email = "peyman@example.com";

        bool hasAtSymbol = email.Contains("@");
        bool hasDot = email.Contains(".");

        Console.WriteLine("Email: " + email);
        Console.WriteLine("Contains @: " + hasAtSymbol);
        Console.WriteLine("Contains dot: " + hasDot);
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
