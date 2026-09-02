using System;

namespace LearnHowToCode.SyntaxExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Simple Statement
// ==================================================

```
        Console.WriteLine("Hello, World!");

        // ==================================================
        // Example 2 - Multiple Statements
        // ==================================================

        Console.WriteLine("Welcome");
        Console.WriteLine("To");
        Console.WriteLine("C#");

        // ==================================================
        // Example 3 - Variables and Syntax
        // ==================================================

        string name = "Peyman";
        int age = 25;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);

        // ==================================================
        // Example 4 - Curly Braces (Code Blocks)
        // ==================================================

        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }

        // ==================================================
        // Example 5 - Comments
        // ==================================================

        // This is a single-line comment.

        /*
            This is a
            multi-line comment.
        */

        Console.WriteLine("Comments do not affect execution.");

        // ==================================================
        // Example 6 - Case Sensitivity
        // ==================================================

        string city = "Mexicali";

        Console.WriteLine(city);

        // The following would cause an error:
        // Console.WriteLine(City);

        // ==================================================
        // Example 7 - Proper Formatting
        // ==================================================

        int number = 10;

        if (number > 5)
        {
            Console.WriteLine("Number is greater than 5.");
        }

        // ==================================================
        // Example 8 - Using System Namespace
        // ==================================================

        Console.WriteLine("System namespace allows access to Console.");

        // ==================================================
        // Example 9 - Escape Characters
        // ==================================================

        Console.WriteLine("Line 1\nLine 2");
        Console.WriteLine("Column1\tColumn2");

        // ==================================================
        // Example 10 - Final Syntax Example
        // ==================================================

        string language = "C#";

        Console.WriteLine("I am learning " + language + " syntax.");

        // ==================================================
        // End of Examples
        // ==================================================

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
