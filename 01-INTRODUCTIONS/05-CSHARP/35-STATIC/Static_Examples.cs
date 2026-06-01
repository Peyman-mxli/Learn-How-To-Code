```csharp
/*
=========================================
35 - STATIC
Static_Examples.cs
=========================================
*/

using System;

namespace StaticExamples
{
    // =========================================
    // Static Field Example
    // =========================================

    class Player
    {
        public string Name;

        public static int TotalPlayers = 0;

        public Player(string name)
        {
            Name = name;
            TotalPlayers++;
        }
    }

    // =========================================
    // Static Method Example
    // =========================================

    class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    // =========================================
    // Static Property Example
    // =========================================

    class GameInfo
    {
        public static string Version
        {
            get;
            set;
        } = "1.0.0";
    }

    // =========================================
    // Static Constructor Example
    // =========================================

    class Database
    {
        static Database()
        {
            Console.WriteLine("Database initialized.");
        }

        public static void Connect()
        {
            Console.WriteLine("Database connection established.");
        }
    }

    // =========================================
    // Static Class Example
    // =========================================

    static class Utilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("--------------------------------");
        }

        public static void PrintTitle(string title)
        {
            Console.WriteLine(title);
        }
    }

    // =========================================
    // Shared Static Data Example
    // =========================================

    class School
    {
        public string StudentName;

        public static int TotalStudents = 0;

        public School(string studentName)
        {
            StudentName = studentName;
            TotalStudents++;
        }
    }

    // =========================================
    // Static Configuration Example
    // =========================================

    static class ApplicationSettings
    {
        public static string ApplicationName = "Learn How To Code";

        public static int MaxUsers = 1000;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Utilities.PrintTitle("STATIC FIELD EXAMPLE");

            Player player1 = new Player("Peyman");
            Player player2 = new Player("John");
            Player player3 = new Player("Sara");

            Console.WriteLine($"Total Players: {Player.TotalPlayers}");

            Utilities.PrintSeparator();

            Utilities.PrintTitle("STATIC METHOD EXAMPLE");

            Console.WriteLine(MathHelper.Add(10, 5));
            Console.WriteLine(MathHelper.Multiply(10, 5));

            Utilities.PrintSeparator();

            Utilities.PrintTitle("STATIC PROPERTY EXAMPLE");

            Console.WriteLine($"Version: {GameInfo.Version}");

            GameInfo.Version = "2.0.0";

            Console.WriteLine($"Updated Version: {GameInfo.Version}");

            Utilities.PrintSeparator();

            Utilities.PrintTitle("STATIC CONSTRUCTOR EXAMPLE");

            Database.Connect();

            Utilities.PrintSeparator();

            Utilities.PrintTitle("STATIC CLASS EXAMPLE");

            Utilities.PrintSeparator();

            Utilities.PrintTitle("SHARED DATA EXAMPLE");

            School student1 = new School("Ali");
            School student2 = new School("Maria");
            School student3 = new School("David");

            Console.WriteLine($"Total Students: {School.TotalStudents}");

            Utilities.PrintSeparator();

            Utilities.PrintTitle("APPLICATION SETTINGS");

            Console.WriteLine($"Application Name: {ApplicationSettings.ApplicationName}");
            Console.WriteLine($"Maximum Users: {ApplicationSettings.MaxUsers}");

            Utilities.PrintSeparator();

            Utilities.PrintTitle("COMMON STATIC MEMBERS");

            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Abs(-100));
            Console.WriteLine(DateTime.Now);

            Utilities.PrintSeparator();

            Console.WriteLine("STATIC EXAMPLES COMPLETE");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
