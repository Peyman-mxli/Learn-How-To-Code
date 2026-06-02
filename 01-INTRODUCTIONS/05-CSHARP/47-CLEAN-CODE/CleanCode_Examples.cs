using System;

namespace CleanCodeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("CLEAN CODE EXAMPLES");
            Console.WriteLine("=================================");

            Example1_GoodVariableNames();

            Example2_GoodMethodNames();

            Example3_AvoidDuplicateCode();

            Example4_SimpleConditions();

            Example5_SmallFocusedMethods();
        }

        // =========================================
        // EXAMPLE 1
        // GOOD VARIABLE NAMES
        // =========================================

        static void Example1_GoodVariableNames()
        {
            Console.WriteLine(
                "\n--- Example 1: Good Variable Names ---");

            string customerName = "Peyman";

            int customerAge = 25;

            decimal productPrice = 1499.99m;

            Console.WriteLine(
                $"Customer: {customerName}");

            Console.WriteLine(
                $"Age: {customerAge}");

            Console.WriteLine(
                $"Price: ${productPrice}");
        }

        // =========================================
        // EXAMPLE 2
        // GOOD METHOD NAMES
        // =========================================

        static void Example2_GoodMethodNames()
        {
            Console.WriteLine(
                "\n--- Example 2: Good Method Names ---");

            DisplayWelcomeMessage();

            CalculateTotalPrice(100, 3);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine(
                "Welcome to Clean Code!");
        }

        static void CalculateTotalPrice(
            decimal productPrice,
            int quantity)
        {
            decimal totalPrice =
                productPrice * quantity;

            Console.WriteLine(
                $"Total Price: ${totalPrice}");
        }

        // =========================================
        // EXAMPLE 3
        // AVOID DUPLICATE CODE
        // =========================================

        static void Example3_AvoidDuplicateCode()
        {
            Console.WriteLine(
                "\n--- Example 3: Avoid Duplicate Code ---");

            ShowSeparator();

            Console.WriteLine("Section One");

            ShowSeparator();

            Console.WriteLine("Section Two");

            ShowSeparator();
        }

        static void ShowSeparator()
        {
            Console.WriteLine(
                "------------------------------");
        }

        // =========================================
        // EXAMPLE 4
        // SIMPLE CONDITIONS
        // =========================================

        static void Example4_SimpleConditions()
        {
            Console.WriteLine(
                "\n--- Example 4: Simple Conditions ---");

            int age = 22;

            int examScore = 85;

            bool isAdult = age >= 18;

            bool passedExam = examScore >= 70;

            if (isAdult && passedExam)
            {
                Console.WriteLine(
                    "Student accepted");
            }
            else
            {
                Console.WriteLine(
                    "Student rejected");
            }
        }

        // =========================================
        // EXAMPLE 5
        // SMALL FOCUSED METHODS
        // =========================================

        static void Example5_SmallFocusedMethods()
        {
            Console.WriteLine(
                "\n--- Example 5: Small Focused Methods ---");

            string username =
                GetUserName();

            ValidateUser(username);

            SaveUser(username);

            SendWelcomeEmail(username);
        }

        static string GetUserName()
        {
            return "Peyman";
        }

        static void ValidateUser(string username)
        {
            Console.WriteLine(
                $"Validating {username}");
        }

        static void SaveUser(string username)
        {
            Console.WriteLine(
                $"Saving {username}");
        }

        static void SendWelcomeEmail(string username)
        {
            Console.WriteLine(
                $"Sending welcome email to {username}");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
