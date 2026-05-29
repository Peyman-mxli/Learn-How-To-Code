using System;

namespace PartialClassesExamples
{
    // =========================================================
    // PART 1
    // =========================================================

    public partial class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
    }

    // =========================================================
    // PART 2
    // =========================================================

    public partial class Player
    {
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }
    }

    // =========================================================
    // PART 3
    // =========================================================

    public partial class Player
    {
        public void Heal(int amount)
        {
            Health += amount;

            Console.WriteLine(
                $"{Name} healed for {amount} HP."
            );
        }
    }

    // =========================================================
    // STUDENT PARTIAL CLASS
    // =========================================================

    public partial class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class Student
    {
        public void DisplayFullName()
        {
            Console.WriteLine(
                $"{FirstName} {LastName}"
            );
        }
    }

    // =========================================================
    // CALCULATOR PARTIAL CLASS
    // =========================================================

    public partial class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public partial class Calculator
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public partial class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    // =========================================================
    // PARTIAL METHOD EXAMPLE
    // =========================================================

    public partial class Logger
    {
        partial void LogMessage(string message);

        public void WriteLog(string message)
        {
            LogMessage(message);
        }
    }

    public partial class Logger
    {
        partial void LogMessage(string message)
        {
            Console.WriteLine(
                $"Log: {message}"
            );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "===== PARTIAL CLASSES EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: Player Object
            // --------------------------------------------------

            Player player = new Player
            {
                Name = "Peyman",
                Health = 100
            };

            Console.WriteLine("Example 1");
            Console.WriteLine(
                $"Name: {player.Name}"
            );
            Console.WriteLine(
                $"Health: {player.Health}"
            );
            Console.WriteLine();

            // --------------------------------------------------
            // Example 2: Attack Method
            // --------------------------------------------------

            Console.WriteLine("Example 2");
            player.Attack();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 3: Heal Method
            // --------------------------------------------------

            Console.WriteLine("Example 3");
            player.Heal(25);

            Console.WriteLine(
                $"Current Health: {player.Health}"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: Student Class
            // --------------------------------------------------

            Student student = new Student
            {
                FirstName = "Peyman",
                LastName = "Miyandashti"
            };

            Console.WriteLine("Example 4");
            student.DisplayFullName();
            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: Calculator Add
            // --------------------------------------------------

            Calculator calculator =
                new Calculator();

            Console.WriteLine("Example 5");
            Console.WriteLine(
                calculator.Add(10, 5)
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Calculator Subtract
            // --------------------------------------------------

            Console.WriteLine("Example 6");
            Console.WriteLine(
                calculator.Subtract(10, 5)
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: Calculator Multiply
            // --------------------------------------------------

            Console.WriteLine("Example 7");
            Console.WriteLine(
                calculator.Multiply(10, 5)
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Partial Method
            // --------------------------------------------------

            Logger logger = new Logger();

            Console.WriteLine("Example 8");

            logger.WriteLog(
                "Application started."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Multiple Members
            // --------------------------------------------------

            Console.WriteLine("Example 9");

            Player warrior = new Player
            {
                Name = "Warrior",
                Health = 150
            };

            warrior.Attack();
            warrior.Heal(10);

            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Shared Object State
            // --------------------------------------------------

            Console.WriteLine("Example 10");

            Console.WriteLine(
                $"Health Before: {warrior.Health}"
            );

            warrior.Heal(40);

            Console.WriteLine(
                $"Health After: {warrior.Health}"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 11: Second Student
            // --------------------------------------------------

            Console.WriteLine("Example 11");

            Student student2 = new Student
            {
                FirstName = "John",
                LastName = "Smith"
            };

            student2.DisplayFullName();

            Console.WriteLine();

            // --------------------------------------------------
            // Example 12: More Calculator Usage
            // --------------------------------------------------

            Console.WriteLine("Example 12");

            Console.WriteLine(
                $"20 + 10 = {calculator.Add(20, 10)}"
            );

            Console.WriteLine(
                $"20 - 10 = {calculator.Subtract(20, 10)}"
            );

            Console.WriteLine(
                $"20 * 10 = {calculator.Multiply(20, 10)}"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 13: Logger
            // --------------------------------------------------

            Console.WriteLine("Example 13");

            logger.WriteLog(
                "User logged in."
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 14: Player Information
            // --------------------------------------------------

            Console.WriteLine("Example 14");

            Console.WriteLine(
                $"{player.Name} - {player.Health} HP"
            );

            Console.WriteLine();

            // --------------------------------------------------
            // Example 15: Combined Functionality
            // --------------------------------------------------

            Console.WriteLine("Example 15");

            Player hero = new Player
            {
                Name = "Hero",
                Health = 200
            };

            hero.Attack();
            hero.Heal(50);

            Console.WriteLine(
                $"Final HP: {hero.Health}"
            );

            Console.WriteLine();

            Console.WriteLine(
                "All Partial Classes examples completed."
            );
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
