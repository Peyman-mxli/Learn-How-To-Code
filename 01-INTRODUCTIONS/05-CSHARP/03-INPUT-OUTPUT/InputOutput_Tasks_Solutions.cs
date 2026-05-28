using System;

namespace LearnHowToCode.InputOutputTaskSolutions
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
        Console.WriteLine("Hello World");

        // Task 2
        Console.WriteLine("Peyman");

        // Task 3
        Console.WriteLine("My favorite hobby is coding.");

        // Task 4
        Console.WriteLine("My favorite programming language is C#.");

        // Task 5
        Console.WriteLine("Learning C#");
        Console.WriteLine("Practicing input and output");
        Console.WriteLine("Building my programming foundation");

        // ==================================================
        // Rank 2 Easy 🙂
        // ==================================================

        // Task 6 - 8
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Welcome " + name);

        // Task 9 - 10
        Console.Write("\nEnter your city: ");
        string city = Console.ReadLine();

        Console.WriteLine("You live in " + city + ".");

        // ==================================================
        // Rank 3 Intermediate ⚙️
        // ==================================================

        // Task 11 - 13
        Console.Write("\nEnter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your age is " + age + ".");

        // Task 14 - 15
        Console.Write("\nEnter your favorite food: ");
        string favoriteFood = Console.ReadLine();

        Console.WriteLine(favoriteFood + " is a great choice!");

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        // Task 16 - 19
        Console.Write("\nEnter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("Result: " + sum);

        // Task 20
        Console.WriteLine("\n--- Simple Profile Program ---");

        Console.Write("Name: ");
        string profileName = Console.ReadLine();

        Console.Write("Age: ");
        int profileAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Country: ");
        string profileCountry = Console.ReadLine();

        Console.WriteLine("\n--- Profile Summary ---");
        Console.WriteLine("Name: " + profileName);
        Console.WriteLine("Age: " + profileAge);
        Console.WriteLine("Country: " + profileCountry);

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        // Task 21
        Console.WriteLine("\n--- Student Information Program ---");

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age: ");
        int studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("University: ");
        string university = Console.ReadLine();

        Console.WriteLine("\n--- Student Summary ---");
        Console.WriteLine("Full Name: " + firstName + " " + lastName);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("University: " + university);

        // Task 22 - 23
        Console.Write("\nEnter product price: ");
        double productPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Product Price: $" + productPrice);

        // Task 24
        Console.Write("\nAre you a student? (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Student Status: " + isStudent);

        // Task 25
        Console.WriteLine("\n--- Complete User Profile Application ---");

        Console.Write("Name: ");
        string userName = Console.ReadLine();

        Console.Write("Age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Country: ");
        string userCountry = Console.ReadLine();

        Console.Write("Favorite Programming Language: ");
        string favoriteLanguage = Console.ReadLine();

        Console.Write("Dream Job: ");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("\n--- Professional User Profile ---");
        Console.WriteLine("Name: " + userName);
        Console.WriteLine("Age: " + userAge);
        Console.WriteLine("Country: " + userCountry);
        Console.WriteLine("Favorite Programming Language: " + favoriteLanguage);
        Console.WriteLine("Dream Job: " + dreamJob);

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        // Challenge 1
        Console.Write("\nEnter your name for letter display: ");
        string letterName = Console.ReadLine();

        Console.WriteLine("Letters:");

        foreach (char letter in letterName)
        {
            Console.WriteLine(letter);
        }

        // Challenge 2
        Console.Write("\nEnter first challenge number: ");
        int challengeNumber1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second challenge number: ");
        int challengeNumber2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third challenge number: ");
        int challengeNumber3 = Convert.ToInt32(Console.ReadLine());

        int challengeTotal = challengeNumber1 + challengeNumber2 + challengeNumber3;

        Console.WriteLine("Total: " + challengeTotal);

        // Challenge 3
        Console.WriteLine("\n--- Personal Introduction Program ---");

        Console.Write("Enter your name: ");
        string introName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int introAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your country: ");
        string introCountry = Console.ReadLine();

        Console.Write("Enter your favorite hobby: ");
        string introHobby = Console.ReadLine();

        Console.WriteLine(
            "Hello, my name is " + introName +
            ". I am " + introAge +
            " years old. I am from " + introCountry +
            ", and my favorite hobby is " + introHobby + "."
        );

        Console.WriteLine("\nAll Input & Output Tasks Completed!");

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
