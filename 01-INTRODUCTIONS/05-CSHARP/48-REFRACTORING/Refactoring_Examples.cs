using System;

namespace RefactoringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("REFACTORING EXAMPLES");
            Console.WriteLine("=================================");

            Example1_RenameVariables();

            Example2_ExtractMethod();

            Example3_RemoveDuplicateCode();

            Example4_ReplaceMagicNumbers();

            Example5_SplitLargeMethod();
        }

        // =========================================
        // EXAMPLE 1
        // RENAME VARIABLES
        // =========================================

        static void Example1_RenameVariables()
        {
            Console.WriteLine(
                "\n--- Example 1: Rename Variables ---");

            int productPrice = 50;

            int quantity = 5;

            int totalPrice = productPrice * quantity;

            Console.WriteLine(
                $"Total Price: {totalPrice}");
        }

        // =========================================
        // EXAMPLE 2
        // EXTRACT METHOD
        // =========================================

        static void Example2_ExtractMethod()
        {
            Console.WriteLine(
                "\n--- Example 2: Extract Method ---");

            ShowWelcomeMessage();
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please Login");
            Console.WriteLine("Good Luck");
        }

        // =========================================
        // EXAMPLE 3
        // REMOVE DUPLICATE CODE
        // =========================================

        static void Example3_RemoveDuplicateCode()
        {
            Console.WriteLine(
                "\n--- Example 3: Remove Duplicate Code ---");

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
        // REPLACE MAGIC NUMBERS
        // =========================================

        static void Example4_ReplaceMagicNumbers()
        {
            Console.WriteLine(
                "\n--- Example 4: Replace Magic Numbers ---");

            const int PassingScore = 70;

            int studentScore = 85;

            if (studentScore >= PassingScore)
            {
                Console.WriteLine("Student Passed");
            }
            else
            {
                Console.WriteLine("Student Failed");
            }
        }

        // =========================================
        // EXAMPLE 5
        // SPLIT LARGE METHOD
        // =========================================

        static void Example5_SplitLargeMethod()
        {
            Console.WriteLine(
                "\n--- Example 5: Split Large Method ---");

            RegisterUser("Peyman");
        }

        static void RegisterUser(string username)
        {
            ValidateUser(username);

            SaveUser(username);

            SendWelcomeEmail(username);
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
