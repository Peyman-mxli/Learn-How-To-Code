```csharp
using System;
using System.IO;

namespace LearnHowToCode.Exceptions
{
    class ExceptionsTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("EXCEPTIONS TASK SOLUTIONS");
            Console.WriteLine("=====================================\n");

            RunTask1();
            RunTask2();
            RunTask3();
            RunTask4();
            RunTask5();
            RunTask6();
            RunTask7();
            RunTask8();
            RunTask9();
            RunTask10();
            RunTask11();
            RunTask12();
            RunTask13();
            RunTask14();
            RunFinalChallenge();
        }

        static void RunTask1()
        {
            Console.WriteLine("Task 1 - Divide By Zero");

            try
            {
                int result = 10 / 0;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }

            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - Format Exception");

            try
            {
                int number = int.Parse("Hello");
                Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The text cannot be converted into a number.");
            }

            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Index Out Of Range");

            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: The array index does not exist.");
            }

            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Try Catch Finally");

            try
            {
                Console.WriteLine("The try block is running.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
            finally
            {
                Console.WriteLine("The finally block always runs.");
            }

            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - Missing File");

            try
            {
                string text = File.ReadAllText("MissingFile.txt");
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }

            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - Null Reference");

            try
            {
                string? name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: The object is null.");
            }

            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Multiple Catch Blocks");

            try
            {
                int number = int.Parse("ABC");
                int result = 10 / number;

                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }

            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - Age Validation");

            try
            {
                int age = -5;

                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }

                Console.WriteLine($"Age: {age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Username Validation");

            try
            {
                string username = "abc";

                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new Exception("Username cannot be empty.");
                }

                if (username.Length < 5)
                {
                    throw new Exception("Username must be at least 5 characters.");
                }

                Console.WriteLine($"Username: {username}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Banking Validation");

            try
            {
                decimal balance = 500;
                decimal withdrawalAmount = 700;

                if (withdrawalAmount > balance)
                {
                    throw new Exception("Withdrawal amount cannot exceed account balance.");
                }

                balance -= withdrawalAmount;

                Console.WriteLine($"Balance: {balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bank Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Product Inventory");

            try
            {
                int quantity = -10;

                if (quantity < 0)
                {
                    throw new Exception("Product quantity cannot be negative.");
                }

                Console.WriteLine($"Quantity: {quantity}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Inventory Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - Grade Validation");

            try
            {
                int grade = 150;

                if (grade < 0)
                {
                    throw new Exception("Grade cannot be lower than 0.");
                }

                if (grade > 100)
                {
                    throw new Exception("Grade cannot be higher than 100.");
                }

                Console.WriteLine($"Grade: {grade}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Grade Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Login System");

            try
            {
                string? username = null;
                string? password = null;

                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new Exception("Username cannot be null or empty.");
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("Password cannot be null or empty.");
                }

                Console.WriteLine("Login information is valid.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login Error: {ex.Message}");
            }

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - File Processing Simulation");

            string[] files =
            {
                "data.txt",
                "MissingFile.txt",
                "students.txt"
            };

            foreach (string file in files)
            {
                try
                {
                    Console.WriteLine($"Processing file: {file}");

                    if (file == "MissingFile.txt")
                    {
                        throw new FileNotFoundException("The file does not exist.");
                    }

                    Console.WriteLine($"{file} processed successfully.");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"File Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine($"Finished processing attempt for: {file}");
                }

                Console.WriteLine();
            }
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Character Validator");

            try
            {
                RpgCharacter character = new RpgCharacter("", 0, -50, -10);

                ValidateCharacter(character);

                Console.WriteLine("Character is valid.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Character validation process completed.");
            }

            Console.WriteLine();
        }

        static void ValidateCharacter(RpgCharacter character)
        {
            if (string.IsNullOrWhiteSpace(character.Name))
            {
                throw new ArgumentException("Character name cannot be empty.");
            }

            if (character.Level <= 0)
            {
                throw new ArgumentException("Character level must be greater than 0.");
            }

            if (character.Health < 0)
            {
                throw new ArgumentException("Character health cannot be negative.");
            }

            if (character.Mana < 0)
            {
                throw new ArgumentException("Character mana cannot be negative.");
            }
        }
    }

    class RpgCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public RpgCharacter(string name, int level, int health, int mana)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
        }
    }
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
