```csharp
using System;

namespace LearnHowToCode.Encapsulation
{
    class EncapsulationTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("ENCAPSULATION TASK SOLUTIONS");
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
            Console.WriteLine("Task 1 - Student");

            Student student = new Student();
            student.SetName("Peyman");

            Console.WriteLine($"Student Name: {student.GetName()}");
            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - Person");

            PersonTask person = new PersonTask();
            person.SetAge(-10);
            person.SetAge(25);

            Console.WriteLine($"Age: {person.GetAge()}");
            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Book");

            Book book = new Book();
            book.Title = "C# Fundamentals";
            book.Author = "Peyman Miyandashti";

            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Product");

            ProductTask product = new ProductTask();
            product.Price = -50;
            product.Price = 199.99;

            Console.WriteLine($"Product Price: {product.Price}");
            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - Bank Account");

            BankAccountTask account = new BankAccountTask();

            account.Deposit(500);
            account.Withdraw(150);
            account.Withdraw(1000);

            Console.WriteLine($"Balance: {account.GetBalance()}");
            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - Game Player");

            GamePlayer player = new GamePlayer("NovaHero");

            player.ChangeUsername("");
            player.ChangeUsername("NovaGuardian");

            Console.WriteLine($"Username: {player.Username}");
            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Employee");

            EmployeeTask employee = new EmployeeTask();

            employee.Name = "Peyman";
            employee.Salary = -1000;
            employee.Salary = 8000;

            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - Health System");

            HealthSystem healthSystem = new HealthSystem();

            healthSystem.Health = 100;
            healthSystem.TakeDamage(35);
            healthSystem.Heal(20);
            healthSystem.Heal(500);

            Console.WriteLine($"Health: {healthSystem.Health}");
            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Inventory Item");

            InventoryItem item = new InventoryItem();

            item.Name = "Health Potion";
            item.AddItems(10);
            item.RemoveItems(3);
            item.RemoveItems(50);

            Console.WriteLine($"Item Name: {item.Name}");
            Console.WriteLine($"Quantity: {item.Quantity}");
            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Account Security");

            AccountSecurity security = new AccountSecurity();

            security.SetPassword("123");
            security.SetPassword("StrongPass123");

            Console.WriteLine($"Password Correct: {security.CheckPassword("StrongPass123")}");
            Console.WriteLine($"Password Incorrect: {security.CheckPassword("wrong")}");
            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Character Stats");

            CharacterStats stats = new CharacterStats();

            stats.Strength = 150;
            stats.Agility = 75;
            stats.Stamina = -10;

            stats.PrintStats();
            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - Shopping Cart");

            ShoppingCart cart = new ShoppingCart();

            cart.ItemName = "Keyboard";
            cart.Quantity = 2;
            cart.Price = 49.99;

            Console.WriteLine($"Item: {cart.ItemName}");
            Console.WriteLine($"Quantity: {cart.Quantity}");
            Console.WriteLine($"Price: {cart.Price}");
            Console.WriteLine($"Total: {cart.GetTotal()}");
            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Course Enrollment");

            CourseEnrollment enrollment = new CourseEnrollment();

            enrollment.StudentName = "Peyman";
            enrollment.CourseName = "C# Programming";
            enrollment.Grade = 95;

            enrollment.PrintEnrollmentInfo();
            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Wallet");

            Wallet wallet = new Wallet();

            wallet.Deposit(300);
            wallet.Spend(75);
            wallet.Spend(1000);

            Console.WriteLine($"Wallet Balance: {wallet.Balance}");
            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - Video Game Character");

            VideoGameCharacter character = new VideoGameCharacter();

            character.Name = "Nova Warrior";
            character.Level = 10;
            character.Health = 100;
            character.Mana = 80;

            character.TakeDamage(25);
            character.Heal(10);
            character.UseMana(30);
            character.RestoreMana(20);

            character.PrintCharacterInfo();
            Console.WriteLine();
        }
    }

    class Student
    {
        private string name = "";

        public void SetName(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }

        public string GetName()
        {
            return name;
        }
    }

    class PersonTask
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

    class Book
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
    }

    class ProductTask
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

    class BankAccountTask
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

    class GamePlayer
    {
        public string Username { get; private set; }

        public GamePlayer(string username)
        {
            Username = string.IsNullOrWhiteSpace(username) ? "UnknownPlayer" : username;
        }

        public void ChangeUsername(string newUsername)
        {
            if (!string.IsNullOrWhiteSpace(newUsername))
            {
                Username = newUsername;
            }
        }
    }

    class EmployeeTask
    {
        private double salary;

        public string Name { get; set; } = "";

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }
    }

    class HealthSystem
    {
        private int health;

        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > 100)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
            }
        }

        public void TakeDamage(int damage)
        {
            if (damage > 0)
            {
                Health -= damage;
            }
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                Health += amount;
            }
        }
    }

    class InventoryItem
    {
        private int quantity;

        public string Name { get; set; } = "";

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public void AddItems(int amount)
        {
            if (amount > 0)
            {
                Quantity += amount;
            }
        }

        public void RemoveItems(int amount)
        {
            if (amount > 0 && amount <= Quantity)
            {
                Quantity -= amount;
            }
        }
    }

    class AccountSecurity
    {
        private string password = "";

        public void SetPassword(string newPassword)
        {
            if (!string.IsNullOrWhiteSpace(newPassword) && newPassword.Length >= 8)
            {
                password = newPassword;
            }
        }

        public bool CheckPassword(string inputPassword)
        {
            return password == inputPassword;
        }
    }

    class CharacterStats
    {
        private int strength = 1;
        private int agility = 1;
        private int stamina = 1;

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = ClampStat(value);
            }
        }

        public int Agility
        {
            get
            {
                return agility;
            }

            set
            {
                agility = ClampStat(value);
            }
        }

        public int Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                stamina = ClampStat(value);
            }
        }

        private int ClampStat(int value)
        {
            if (value < 1)
            {
                return 1;
            }

            if (value > 100)
            {
                return 100;
            }

            return value;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Stamina: {Stamina}");
        }
    }

    class ShoppingCart
    {
        private string itemName = "";
        private int quantity = 1;
        private double price;

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    itemName = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value >= 1)
                {
                    quantity = value;
                }
            }
        }

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

        public double GetTotal()
        {
            return Quantity * Price;
        }
    }

    class CourseEnrollment
    {
        private string studentName = "";
        private string courseName = "";
        private int grade;

        public string StudentName
        {
            get
            {
                return studentName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    studentName = value;
                }
            }
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    courseName = value;
                }
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            }
        }

        public void PrintEnrollmentInfo()
        {
            Console.WriteLine($"Student: {StudentName}");
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    class Wallet
    {
        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Spend(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }
    }

    class VideoGameCharacter
    {
        private string name = "";
        private int level = 1;
        private int health = 100;
        private int mana = 100;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = Clamp(value, 0, 100);
            }
        }

        public int Mana
        {
            get
            {
                return mana;
            }

            set
            {
                mana = Clamp(value, 0, 100);
            }
        }

        public void TakeDamage(int damage)
        {
            if (damage > 0)
            {
                Health -= damage;
            }
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                Health += amount;
            }
        }

        public void UseMana(int amount)
        {
            if (amount > 0 && amount <= Mana)
            {
                Mana -= amount;
            }
        }

        public void RestoreMana(int amount)
        {
            if (amount > 0)
            {
                Mana += amount;
            }
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Mana: {Mana}");
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
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
