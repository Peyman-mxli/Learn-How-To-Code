using System;

namespace StudentManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Add Student feature coming soon.");
                        break;

                    case "2":
                        Console.WriteLine();
                        studentManager.DisplayAllStudents();
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Search Student feature coming soon.");
                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Update Student feature coming soon.");
                        break;

                    case "5":
                        Console.WriteLine();
                        Console.WriteLine("Delete Student feature coming soon.");
                        break;

                    case "6":
                        isRunning = false;
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using Student Management System.");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
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
