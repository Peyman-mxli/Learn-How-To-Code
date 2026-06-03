using System;

namespace StudentManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            Console.WriteLine("========================================");
            Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("========================================");

            Console.WriteLine();
            Console.WriteLine("Project setup completed successfully.");
            Console.WriteLine("Student Manager is ready.");
            Console.WriteLine();

            Console.WriteLine($"Total Students: {studentManager.GetTotalStudents()}");
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
