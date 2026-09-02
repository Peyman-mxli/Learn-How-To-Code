using System;

namespace PartialClassesTaskSolutions
{
    public partial class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Student
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}");
        }
    }

    public partial class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public partial class Book
    {
        public void DisplayBook()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}");
        }
    }

    public partial class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    public partial class Car
    {
        public void DisplayCar()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }
    }

    public partial class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
    }

    public partial class Player
    {
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }
    }

    public partial class Player
    {
        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed for {amount} HP.");
        }
    }

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

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }

    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public partial class Employee
    {
        public void DisplayEmployee()
        {
            Console.WriteLine(
                $"Employee ID: {Id}, Name: {Name}, Department: {Department}"
            );
        }
    }

    public partial class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }

    public partial class BankAccount
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
    }

    public partial class BankAccount
    {
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }

    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public partial class Product
    {
        public void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100m;
        }
    }

    public partial class Logger
    {
        partial void WriteMessage(string message);

        public void Log(string message)
        {
            WriteMessage(message);
        }
    }

    public partial class Logger
    {
        partial void WriteMessage(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public partial class UserProfile
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }

    public partial class UserProfile
    {
        public void DisplayProfile()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public partial class UserProfile
    {
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Email) &&
                   Email.Contains("@");
        }
    }

    public partial class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
    }

    public partial class GameCharacter
    {
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks the enemy!");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} took {damage} damage.");
        }
    }

    public partial class GameCharacter
    {
        public void Move()
        {
            Console.WriteLine($"{Name} moves forward.");
        }
    }

    public partial class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public partial class Order
    {
        public decimal CalculateTotal()
        {
            return Price * Quantity;
        }
    }

    public partial class Order
    {
        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Product: {ProductName}");
            Console.WriteLine($"Total: {CalculateTotal()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PARTIAL CLASSES TASK SOLUTIONS =====\n");

            Student student = new Student
            {
                Name = "Peyman",
                Age = 25
            };

            Console.WriteLine("Task 1:");
            student.DisplayInfo();
            Console.WriteLine();

            Book book = new Book
            {
                Title = "C# Basics",
                Author = "Programming Teacher"
            };

            Console.WriteLine("Task 2:");
            book.DisplayBook();
            Console.WriteLine();

            Car car = new Car
            {
                Brand = "Toyota",
                Model = "Corolla"
            };

            Console.WriteLine("Task 3:");
            car.DisplayCar();
            Console.WriteLine();

            Player player = new Player
            {
                Name = "Hero",
                Health = 100
            };

            Console.WriteLine("Task 4:");
            player.Attack();
            Console.WriteLine();

            Console.WriteLine("Task 5:");
            player.Heal(25);
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine();

            Calculator calculator = new Calculator();

            Console.WriteLine("Task 6:");
            Console.WriteLine($"Add: {calculator.Add(10, 5)}");
            Console.WriteLine($"Subtract: {calculator.Subtract(10, 5)}");
            Console.WriteLine();

            Console.WriteLine("Task 7:");
            Console.WriteLine($"Multiply: {calculator.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {calculator.Divide(10, 5)}");
            Console.WriteLine();

            Employee employee = new Employee
            {
                Id = 1,
                Name = "Peyman",
                Department = "IT"
            };

            Console.WriteLine("Task 8:");
            employee.DisplayEmployee();
            Console.WriteLine();

            BankAccount account = new BankAccount
            {
                AccountNumber = "ACC-1001",
                Balance = 1000m
            };

            Console.WriteLine("Task 9:");
            account.Deposit(500m);
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine();

            Console.WriteLine("Task 10:");
            account.Withdraw(200m);
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine();

            Product product = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1500m
            };

            Console.WriteLine("Task 11:");
            product.ApplyDiscount(10);
            Console.WriteLine($"Discounted Price: {product.Price}");
            Console.WriteLine();

            Logger logger = new Logger();

            Console.WriteLine("Task 12:");
            logger.Log("Partial method executed.");
            Console.WriteLine();

            UserProfile userProfile = new UserProfile
            {
                Username = "peyman_dev",
                Email = "peyman@example.com"
            };

            Console.WriteLine("Task 13:");
            userProfile.DisplayProfile();
            Console.WriteLine($"Valid: {userProfile.IsValid()}");
            Console.WriteLine();

            GameCharacter character = new GameCharacter
            {
                Name = "Nova Warrior",
                Health = 200
            };

            Console.WriteLine("Task 14:");
            character.Move();
            character.Attack();
            character.TakeDamage(30);
            Console.WriteLine($"Health: {character.Health}");
            Console.WriteLine();

            Order order = new Order
            {
                OrderId = 101,
                ProductName = "Keyboard",
                Price = 100m,
                Quantity = 2
            };

            Console.WriteLine("Task 15:");
            order.DisplayOrder();
            Console.WriteLine();

            Console.WriteLine("Task 16:");

            Student demoStudent = new Student
            {
                Name = "Student Demo",
                Age = 20
            };

            Player demoPlayer = new Player
            {
                Name = "Player Demo",
                Health = 100
            };

            BankAccount demoAccount = new BankAccount
            {
                AccountNumber = "ACC-DEMO",
                Balance = 300m
            };

            demoStudent.DisplayInfo();
            demoPlayer.Attack();
            demoPlayer.Heal(10);
            Console.WriteLine($"Calculator Add: {calculator.Add(5, 5)}");
            demoAccount.Deposit(100m);
            character.Move();

            Console.WriteLine();

            Console.WriteLine("All partial classes task solutions completed.");
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
