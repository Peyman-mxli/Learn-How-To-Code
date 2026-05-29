using System;

namespace StructTasksSolutions
{
    struct Point
    {
        public int X;
        public int Y;
    }

    struct Person
    {
        public string Name;
        public int Age;
    }

    struct Car
    {
        public string Brand;
        public string Model;
        public int Year;
    }

    struct Rectangle
    {
        public double Width;
        public double Height;

        public double GetArea()
        {
            return Width * Height;
        }
    }

    struct Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    struct Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    struct Score
    {
        public int Value;
    }

    readonly struct Temperature
    {
        public readonly double Value;

        public Temperature(double value)
        {
            Value = value;
        }
    }

    struct Address
    {
        public string City;
        public string Country;
    }

    struct Customer
    {
        public string Name;
        public Address Address;
    }

    struct Circle
    {
        public double Radius;

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    struct Employee
    {
        public string Name;
        public double Salary;
    }

    struct BankAccount
    {
        public string AccountNumber;
        public double Balance;

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough balance.");
            }
        }
    }

    struct InventoryItem
    {
        public string ItemName;
        public int Quantity;
        public double Price;
    }

    struct Book
    {
        public string Title;
        public string Author;
        public int Year;

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("STRUCT TASK SOLUTIONS");
            Console.WriteLine("=================================\n");

            Point point;
            point.X = 10;
            point.Y = 20;
            Console.WriteLine($"Task 1: X = {point.X}, Y = {point.Y}");

            Person person;
            person.Name = "Peyman";
            person.Age = 25;
            Console.WriteLine($"Task 2: {person.Name}, {person.Age}");

            Car car;
            car.Brand = "Toyota";
            car.Model = "Corolla";
            car.Year = 2026;
            Console.WriteLine($"Task 3: {car.Brand} {car.Model} {car.Year}");

            Rectangle rectangle;
            rectangle.Width = 10;
            rectangle.Height = 5;
            Console.WriteLine($"Task 4 Area: {rectangle.GetArea()}");

            Student student = new Student
            {
                Name = "Sara",
                Grade = 95
            };
            Console.WriteLine($"Task 5: {student.Name}, Grade: {student.Grade}");

            Product product = new Product("Laptop", 1200.50);
            Console.WriteLine($"Task 6: {product.Name}, Price: {product.Price}");

            Score score1;
            score1.Value = 100;

            Score score2 = score1;
            score2.Value = 500;

            Console.WriteLine($"Task 7 Score 1: {score1.Value}");
            Console.WriteLine($"Task 7 Score 2: {score2.Value}");

            Temperature temperature = new Temperature(36.5);
            Console.WriteLine($"Task 8 Temperature: {temperature.Value}");

            Customer customer;
            customer.Name = "Peyman";
            customer.Address.City = "Mexicali";
            customer.Address.Country = "Mexico";

            Console.WriteLine($"Task 9 Customer: {customer.Name}");
            Console.WriteLine($"Task 9 City: {customer.Address.City}");
            Console.WriteLine($"Task 9 Country: {customer.Address.Country}");

            Point[] points = new Point[5];

            points[0].X = 1;
            points[0].Y = 1;

            points[1].X = 2;
            points[1].Y = 2;

            points[2].X = 3;
            points[2].Y = 3;

            points[3].X = 4;
            points[3].Y = 4;

            points[4].X = 5;
            points[4].Y = 5;

            Console.WriteLine("\nTask 10:");

            foreach (Point p in points)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }

            Employee[] employees =
            {
                new Employee { Name = "Ali", Salary = 5000 },
                new Employee { Name = "Sara", Salary = 6500 },
                new Employee { Name = "Reza", Salary = 7200 }
            };

            Console.WriteLine("\nTask 11:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }

            Circle circle;
            circle.Radius = 5;

            Console.WriteLine($"\nTask 12 Circle Area: {circle.GetArea()}");

            BankAccount account;
            account.AccountNumber = "ACC-1001";
            account.Balance = 1000;

            account.Deposit(500);
            account.Withdraw(300);

            Console.WriteLine("\nTask 13:");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");

            InventoryItem[] items =
            {
                new InventoryItem { ItemName = "Keyboard", Quantity = 5, Price = 25.99 },
                new InventoryItem { ItemName = "Mouse", Quantity = 10, Price = 15.50 },
                new InventoryItem { ItemName = "Monitor", Quantity = 3, Price = 199.99 }
            };

            Console.WriteLine("\nTask 14:");

            foreach (InventoryItem item in items)
            {
                Console.WriteLine($"{item.ItemName} | Quantity: {item.Quantity} | Price: {item.Price}");
            }

            Book[] books =
            {
                new Book { Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
                new Book { Title = "C# Player's Guide", Author = "RB Whitaker", Year = 2022 },
                new Book { Title = "Head First C#", Author = "Andrew Stellman", Year = 2020 }
            };

            Console.WriteLine("\nTask 15:");

            foreach (Book book in books)
            {
                book.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=================================");
            Console.WriteLine("END OF STRUCT SOLUTIONS");
            Console.WriteLine("=================================");
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
