using System;

namespace LearnHowToCode.InputOutputExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Console.WriteLine()
// ==================================================

```
        Console.WriteLine("Hello World!");
        Console.WriteLine("Welcome to C#.");
        Console.WriteLine("Learning Input and Output.");

        // ==================================================
        // Example 2 - Console.Write()
        // ==================================================

        Console.Write("Hello ");
        Console.Write("World");
        Console.WriteLine();

        // ==================================================
        // Example 3 - Reading a Name
        // ==================================================

        Console.Write("Enter your name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name + "!");

        // ==================================================
        // Example 4 - Reading a City
        // ==================================================

        Console.Write("Enter your city: ");

        string city = Console.ReadLine();

        Console.WriteLine("You live in " + city + ".");

        // ==================================================
        // Example 5 - Reading an Age
        // ==================================================

        Console.Write("Enter your age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You are " + age + " years old.");

        // ==================================================
        // Example 6 - Reading a Double Value
        // ==================================================

        Console.Write("Enter a product price: ");

        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Product Price: $" + price);

        // ==================================================
        // Example 7 - Personalized Greeting
        // ==================================================

        Console.Write("Enter your favorite programming language: ");

        string language = Console.ReadLine();

        Console.WriteLine("Great choice! You enjoy " + language + ".");

        // ==================================================
        // Example 8 - Simple Addition
        // ==================================================

        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("Result: " + sum);

        // ==================================================
        // Example 9 - Multiple Inputs
        // ==================================================

        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Full Name: " + firstName + " " + lastName);

        // ==================================================
        // Example 10 - Boolean Input
        // ==================================================

        Console.Write("Are you a student? (true/false): ");

        bool isStudent = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Student Status: " + isStudent);

        // ==================================================
        // Example 11 - User Profile
        // ==================================================

        Console.WriteLine("\n--- User Profile ---");

        Console.Write("Name: ");
        string profileName = Console.ReadLine();

        Console.Write("Age: ");
        int profileAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Country: ");
        string profileCountry = Console.ReadLine();

        Console.WriteLine("\nProfile Summary");
        Console.WriteLine("Name: " + profileName);
        Console.WriteLine("Age: " + profileAge);
        Console.WriteLine("Country: " + profileCountry);

        // ==================================================
        // Example 12 - Interactive Welcome Program
        // ==================================================

        Console.Write("\nWhat is your dream job? ");

        string dreamJob = Console.ReadLine();

        Console.WriteLine("Keep working hard to become a " + dreamJob + "!");

        // ==================================================
        // End of Examples
        // ==================================================

        Console.WriteLine("\nAll Input & Output Examples Completed!");

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
