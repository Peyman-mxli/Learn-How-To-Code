```csharp
using System;

namespace LearnHowToCode.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("ENCAPSULATION EXAMPLES");
            Console.WriteLine("=====================================\n");

            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
        }

        // ============================================================
        // Example 1
        // Basic Getter and Setter Methods
        // ============================================================

        static void Example1()
        {
            Console.WriteLine("Example 1 - Getter and Setter Methods");

            Person person = new Person();

            person.SetAge(25);

            Console.WriteLine($"Age: {person.GetAge()}");
            Console.WriteLine();
        }

        // ============================================================
        // Example 2
        // Validation Using Setter Method
        // ============================================================

        static void Example2()
        {
            Console.WriteLine("Example 2 - Validation");

            Person person = new Person();

            person.SetAge(-50);

            Console.WriteLine($"Age after invalid input: {person.GetAge()}");

            person.SetAge(30);

            Console.WriteLine($"Age after valid input: {person.GetAge()}");
            Console.WriteLine();
        }

        // ============================================================
        // Example 3
        // Property with Get and Set
        // ============================================================

        static void Example3()
        {
            Console.WriteLine("Example 3 - Properties");

            Employee employee = new Employee();

            employee.Name = "Peyman";
            employee.Salary = 5000;

            Console.WriteLine($"Employee: {employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine();
        }

        // ============================================================
        // Example 4
        // Property Validation
        // ============================================================

        static void Example4()
        {
            Console.WriteLine("Example 4 - Property Validation");

            Product product = new Product();

            product.Price = -100;

            Console.WriteLine($"Price after invalid input: {product.Price}");

            product.Price = 250;

            Console.WriteLine($"Price after valid input: {product.Price}");
            Console.WriteLine();
        }

        // ============================================================
        // Example 5
        // Private Setter
        // ============================================================

        static void Example5()
        {
            Console.WriteLine("Example 5 - Private Setter");

            GameCharacter hero = new GameCharacter("Nova Warrior");

            Console.WriteLine($"Character Name: {hero.CharacterName}");

            hero.RenameCharacter("Nova Guardian");

            Console.WriteLine($"New Name: {hero.CharacterName}");
            Console.WriteLine();
        }

        // ============================================================
        // Example 6
        // Real-World Banking Example
        // ============================================================

        static void Example6()
        {
            Console.WriteLine("Example 6 - Bank Account");

            BankAccount account = new BankAccount();

            account.Deposit(1000);

            account.Withdraw(250);

            Console.WriteLine($"Current Balance: ${account.GetBalance()}");
            Console.WriteLine();
        }
    }

    // ============================================================
    // Example Class 1
    // Getter / Setter Methods
    // ============================================================

    class Person
    {
        private int age;

        public void SetAge(int value)
        {
            if (value >= 0)
            {
                age = value;
            }
        }

        public int GetAge()
        {
            return age;
        }
    }

    // ============================================================
    // Example Class 2
    // Auto Properties
    // ============================================================

    class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }
    }

    // ============================================================
    // Example Class 3
    // Property Validation
    // ============================================================

    class Product
    {
        private double price;

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }
    }

    // ============================================================
    // Example Class 4
    // Private Setter
    // ============================================================

    class GameCharacter
    {
        public string CharacterName { get; private set; }

        public GameCharacter(string characterName)
        {
            CharacterName = characterName;
        }

        public void RenameCharacter(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                CharacterName = newName;
            }
        }
    }

    // ============================================================
    // Example Class 5
    // Bank Account
    // ============================================================

    class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
