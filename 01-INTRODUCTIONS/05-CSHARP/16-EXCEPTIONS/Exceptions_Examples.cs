```csharp
using System;
using System.IO;

namespace LearnHowToCode.Exceptions
{
    class ExceptionsExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("EXCEPTIONS EXAMPLES");
            Console.WriteLine("=====================================\n");

            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
        }

        /*
            ============================================================
            EXAMPLE 1
            BASIC TRY-CATCH
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - BASIC TRY-CATCH");

            try
            {
                int number = 10;
                int result = number / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 2
            FORMAT EXCEPTION
            ============================================================
        */

        static void Example2()
        {
            Console.WriteLine("EXAMPLE 2 - FORMAT EXCEPTION");

            try
            {
                int age = int.Parse("Hello");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be a valid number.");
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 3
            MULTIPLE CATCH BLOCKS
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - MULTIPLE CATCH BLOCKS");

            try
            {
                string value = "ABC";
                int number = int.Parse(value);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            catch (Exception)
            {
                Console.WriteLine("General error occurred.");
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 4
            FINALLY BLOCK
            ============================================================
        */

        static void Example4()
        {
            Console.WriteLine("EXAMPLE 4 - FINALLY BLOCK");

            try
            {
                Console.WriteLine("Executing risky code.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 5
            THROW KEYWORD
            ============================================================
        */

        static void Example5()
        {
            Console.WriteLine("EXAMPLE 5 - THROW KEYWORD");

            try
            {
                int age = -5;

                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            FILE EXCEPTION
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - FILE EXCEPTION");

            try
            {
                string text = File.ReadAllText("MissingFile.txt");

                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine();
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
