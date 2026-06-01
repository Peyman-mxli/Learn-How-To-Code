/*
=========================================
35 - STATIC
Static_Tasks_Solutions.cs
=========================================
*/

using System;

namespace StaticTasksSolutions
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Greeting
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello, Welcome To C#!");
        }
    }

    class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }

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

    class Student
    {
        public string Name;

        public static int TotalStudents = 0;

        public Student(string name)
        {
            Name = name;
            TotalStudents++;
        }
    }

    class Company
    {
        public static string CompanyName
        {
            get;
            set;
        } = "Nova Tech";
    }

    class BankAccount
    {
        public static double InterestRate = 0.05;
    }

    class GameSettings
    {
        public static int MaxLevel = 100;
        public static int MaxHealth = 500;
        public static int MaxMana = 300;
    }

    class Counter
    {
        public static int Count = 0;

        public static void Increment()
        {
            Count++;
        }
    }

    static class MathUtilities
    {
        public static int Square(int number)
        {
            return number * number;
        }

        public static int Cube(int number)
        {
            return number * number * number;
        }
    }

    static class TextUtilities
    {
        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string ToLowerCase(string text)
        {
            return text.ToLower();
        }
    }

    class Database
    {
        static Database()
        {
            Console.WriteLine("Database has been initialized.");
        }

        public static void Connect()
        {
            Console.WriteLine("Database connected successfully.");
        }
    }

    static class ApplicationSettings
    {
        public static string ApplicationName = "Learn How To Code";
        public static string Version = "1.0.0";
        public static int MaxUsers = 1000;

        public static void DisplaySettings()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"Version: {Version}");
            Console.WriteLine($"Max Users: {MaxUsers}");
        }
    }

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

    static class CurrencyConverter
    {
        public static double DollarToPeso(double dollars)
        {
            return dollars * 17.00;
        }

        public static double PesoToDollar(double pesos)
        {
            return pesos / 17.00;
        }
    }

    static class MMORPGGameSettings
    {
        public static int MaxLevel = 1000;
        public static double ExperienceRate = 1.5;
        public static double GoldRate = 1.2;
    }

    static class ServerSettings
    {
        public static string ServerName = "Nova Zone Server";
        public static int MaxPlayers = 5000;
        public static bool MaintenanceMode = false;
    }

    static class CurrencySettings
    {
        public static int StartingGold = 10;
        public static int MaxGold = 999999;
    }

    static class CombatSettings
    {
        public static double CriticalChance = 0.15;
        public static double AttackSpeed = 1.2;
    }

    static class ConfigurationPrinter
    {
        public static void DisplayAll()
        {
            Console.WriteLine("MMORPG CONFIGURATION SYSTEM");
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Max Level: {MMORPGGameSettings.MaxLevel}");
            Console.WriteLine($"Experience Rate: {MMORPGGameSettings.ExperienceRate}");
            Console.WriteLine($"Gold Rate: {MMORPGGameSettings.GoldRate}");

            Console.WriteLine($"Server Name: {ServerSettings.ServerName}");
            Console.WriteLine($"Max Players: {ServerSettings.MaxPlayers}");
            Console.WriteLine($"Maintenance Mode: {ServerSettings.MaintenanceMode}");

            Console.WriteLine($"Starting Gold: {CurrencySettings.StartingGold}");
            Console.WriteLine($"Max Gold: {CurrencySettings.MaxGold}");

            Console.WriteLine($"Critical Chance: {CombatSettings.CriticalChance}");
            Console.WriteLine($"Attack Speed: {CombatSettings.AttackSpeed}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(10, 5));
            Console.WriteLine(Calculator.Subtract(10, 5));

            Greeting.SayHello();

            Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(25));

            Player player1 = new Player("Peyman");
            Player player2 = new Player("Nova");

            Console.WriteLine($"Total Players: {Player.TotalPlayers}");

            Student student1 = new Student("Ali");
            Student student2 = new Student("Maria");
            Student student3 = new Student("Sara");

            Console.WriteLine($"Total Students: {Student.TotalStudents}");

            Console.WriteLine($"Company Name: {Company.CompanyName}");

            Console.WriteLine($"Interest Rate: {BankAccount.InterestRate * 100}%");

            Console.WriteLine($"Max Level: {GameSettings.MaxLevel}");
            Console.WriteLine($"Max Health: {GameSettings.MaxHealth}");
            Console.WriteLine($"Max Mana: {GameSettings.MaxMana}");

            Counter.Increment();
            Counter.Increment();
            Counter.Increment();

            Console.WriteLine($"Counter: {Counter.Count}");

            Console.WriteLine(MathUtilities.Square(5));
            Console.WriteLine(MathUtilities.Cube(5));

            Console.WriteLine(TextUtilities.ToUpperCase("hello"));
            Console.WriteLine(TextUtilities.ToLowerCase("HELLO"));

            Database.Connect();

            ApplicationSettings.DisplaySettings();

            School schoolStudent1 = new School("David");
            School schoolStudent2 = new School("Elena");

            Console.WriteLine($"School Total Students: {School.TotalStudents}");

            Console.WriteLine(CurrencyConverter.DollarToPeso(100));
            Console.WriteLine(CurrencyConverter.PesoToDollar(1700));

            ConfigurationPrinter.DisplayAll();

            Console.WriteLine();
            Console.WriteLine("Static classes are useful for global game configuration because");
            Console.WriteLine("they allow shared settings to be accessed from anywhere without");
            Console.WriteLine("creating unnecessary objects.");
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
