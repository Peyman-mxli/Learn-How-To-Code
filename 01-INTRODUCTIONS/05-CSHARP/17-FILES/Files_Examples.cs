```csharp
using System;
using System.IO;

namespace LearnHowToCode.Files
{
    class FilesExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("FILES EXAMPLES");
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
            WRITE A FILE
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - WRITE A FILE");

            File.WriteAllText(
                "Example1.txt",
                "Hello from C# File Handling!"
            );

            Console.WriteLine("File created successfully.");

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 2
            READ A FILE
            ============================================================
        */

        static void Example2()
        {
            Console.WriteLine("EXAMPLE 2 - READ A FILE");

            File.WriteAllText(
                "Example2.txt",
                "This text was saved into a file."
            );

            string text =
                File.ReadAllText("Example2.txt");

            Console.WriteLine(text);

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 3
            APPEND TO A FILE
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - APPEND TO A FILE");

            File.WriteAllText(
                "Log.txt",
                "First Log Entry\n"
            );

            File.AppendAllText(
                "Log.txt",
                "Second Log Entry\n"
            );

            string content =
                File.ReadAllText("Log.txt");

            Console.WriteLine(content);

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 4
            CHECK IF FILE EXISTS
            ============================================================
        */

        static void Example4()
        {
            Console.WriteLine("EXAMPLE 4 - CHECK FILE EXISTS");

            string fileName = "Data.txt";

            File.WriteAllText(
                fileName,
                "Testing file existence."
            );

            if (File.Exists(fileName))
            {
                Console.WriteLine("The file exists.");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 5
            READ ALL LINES
            ============================================================
        */

        static void Example5()
        {
            Console.WriteLine("EXAMPLE 5 - READ ALL LINES");

            string[] students =
            {
                "Peyman",
                "John",
                "Sarah",
                "Michael"
            };

            File.WriteAllLines(
                "Students.txt",
                students
            );

            string[] lines =
                File.ReadAllLines("Students.txt");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            DIRECTORY AND TRY-CATCH
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - DIRECTORY AND TRY-CATCH");

            try
            {
                Directory.CreateDirectory("Reports");

                string reportPath =
                    @"Reports\MonthlyReport.txt";

                File.WriteAllText(
                    reportPath,
                    "Monthly Sales Report"
                );

                Console.WriteLine("Directory created.");
                Console.WriteLine("Report saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}"
                );
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
