```csharp
using System;
using System.IO;

namespace LearnHowToCode.Files
{
    class FilesTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("FILES TASK SOLUTIONS");
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
            Console.WriteLine("Task 1 - Hello File");

            File.WriteAllText("Hello.txt", "Hello C#!");

            Console.WriteLine("Hello.txt created successfully.");
            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - My Name File");

            File.WriteAllText("MyName.txt", "Peyman Miyandashti");

            string content = File.ReadAllText("MyName.txt");

            Console.WriteLine(content);
            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Notes File");

            File.WriteAllText("Notes.txt", "Today I am learning file handling in C#.");

            string note = File.ReadAllText("Notes.txt");

            Console.WriteLine(note);
            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Log File");

            File.WriteAllText("Log.txt", "First log entry\n");
            File.AppendAllText("Log.txt", "Second log entry\n");

            string logs = File.ReadAllText("Log.txt");

            Console.WriteLine(logs);
            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - Check File Exists");

            string fileName = "Data.txt";

            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, "Sample data file.");
            }

            if (File.Exists(fileName))
            {
                Console.WriteLine("Data.txt exists.");
            }
            else
            {
                Console.WriteLine("Data.txt is missing.");
            }

            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - Students File");

            string[] students =
            {
                "Peyman",
                "Sarah",
                "Michael",
                "John",
                "Emily"
            };

            File.WriteAllLines("Students.txt", students);

            string[] lines = File.ReadAllLines("Students.txt");

            foreach (string student in lines)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Create Reports Folder");

            Directory.CreateDirectory("Reports");

            if (Directory.Exists("Reports"))
            {
                Console.WriteLine("Reports folder created successfully.");
            }

            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - Monthly Report");

            Directory.CreateDirectory("Reports");

            string reportPath = Path.Combine("Reports", "MonthlyReport.txt");

            File.WriteAllText(reportPath, "This is the monthly report content.");

            string reportContent = File.ReadAllText(reportPath);

            Console.WriteLine(reportContent);
            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Backup System");

            File.WriteAllText("Original.txt", "This is the original file content.");

            File.Copy("Original.txt", "Backup.txt", true);

            string backupContent = File.ReadAllText("Backup.txt");

            Console.WriteLine(backupContent);
            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Rename File");

            string oldFile = "OldFile.txt";
            string newFile = "NewFile.txt";

            File.WriteAllText(oldFile, "This file will be renamed.");

            if (File.Exists(newFile))
            {
                File.Delete(newFile);
            }

            File.Move(oldFile, newFile);

            if (File.Exists(newFile))
            {
                Console.WriteLine("File renamed successfully.");
            }

            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Delete Temporary File");

            string fileName = "Temporary.txt";

            File.WriteAllText(fileName, "Temporary data.");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Temporary.txt deleted successfully.");
            }

            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - File Statistics");

            string[] content =
            {
                "Line 1",
                "Line 2",
                "Line 3",
                "Line 4"
            };

            File.WriteAllLines("Statistics.txt", content);

            string[] lines = File.ReadAllLines("Statistics.txt");

            Console.WriteLine($"Total lines: {lines.Length}");
            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Employee Database");

            string[] employees =
            {
                "Peyman Miyandashti",
                "Sarah Johnson",
                "Michael Brown",
                "Emily Davis"
            };

            File.WriteAllLines("Employees.txt", employees);

            string[] savedEmployees = File.ReadAllLines("Employees.txt");

            foreach (string employee in savedEmployees)
            {
                Console.WriteLine($"Employee: {employee}");
            }

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Logging System");

            File.WriteAllText("Logs.txt", "User Login\n");
            File.AppendAllText("Logs.txt", "User Logout\n");
            File.AppendAllText("Logs.txt", "File Created\n");

            string logs = File.ReadAllText("Logs.txt");

            Console.WriteLine(logs);
            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Save System");

            try
            {
                Directory.CreateDirectory("SaveGames");

                string savePath = Path.Combine("SaveGames", "SaveData.txt");

                string[] characterData =
                {
                    "Name: Nova Warrior",
                    "Level: 25",
                    "Health: 100",
                    "Mana: 80",
                    "Gold: 500"
                };

                File.WriteAllLines(savePath, characterData);

                if (File.Exists(savePath))
                {
                    string[] savedData = File.ReadAllLines(savePath);

                    foreach (string line in savedData)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("Save file was not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Save System Error: {ex.Message}");
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
