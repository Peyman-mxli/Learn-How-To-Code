/*
=========================================
33 - OVERLOADING
Overloading_Tasks_Solutions.cs
=========================================
*/

using System;

namespace OverloadingTasksSolutions
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"String: {message}");
        }

        public void Print(int number)
        {
            Console.WriteLine($"Integer: {number}");
        }

        public void Print(double number)
        {
            Console.WriteLine($"Double: {number}");
        }
    }

    class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Vehicle
    {
        public string Brand;
        public int Year;

        public Vehicle()
        {
            Brand = "Unknown";
            Year = 0;
        }

        public Vehicle(string brand)
        {
            Brand = brand;
            Year = 0;
        }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }

    class DisplayInfo
    {
        public void Display(string firstName)
        {
            Console.WriteLine($"First Name: {firstName}");
        }

        public void Display(string firstName, string lastName)
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }

        public void Display(string firstName, string lastName, int age)
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}, Age: {age}");
        }
    }

    class TemperatureConverter
    {
        public double Convert(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double Convert(double celsius, bool roundResult)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            if (roundResult)
            {
                return Math.Round(fahrenheit);
            }

            return fahrenheit;
        }
    }

    class Payment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount}");
        }

        public void Pay(double amount, string method)
        {
            Console.WriteLine($"Paid ${amount} using {method}");
        }

        public void Pay(double amount, string method, bool receipt)
        {
            Console.WriteLine($"Paid ${amount} using {method}");

            if (receipt)
            {
                Console.WriteLine("Receipt printed.");
            }
            else
            {
                Console.WriteLine("No receipt requested.");
            }
        }
    }

    class SearchEngine
    {
        public void Search(string keyword)
        {
            Console.WriteLine($"Searching for: {keyword}");
        }

        public void Search(string keyword, string category)
        {
            Console.WriteLine($"Searching for: {keyword} in category: {category}");
        }

        public void Search(string keyword, string category, int page)
        {
            Console.WriteLine($"Searching for: {keyword} in category: {category}, page: {page}");
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public string Major;

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Major = "Undeclared";
        }

        public Student(string name)
        {
            Name = name;
            Age = 0;
            Major = "Undeclared";
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Major = "Undeclared";
        }

        public Student(string name, int age, string major)
        {
            Name = name;
            Age = age;
            Major = major;
        }

        public void Display()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Major: {Major}");
        }
    }

    class ReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Generating default report.");
        }

        public void Generate(string title)
        {
            Console.WriteLine($"Generating report: {title}");
        }

        public void Generate(string title, string author)
        {
            Console.WriteLine($"Generating report: {title}, Author: {author}");
        }

        public void Generate(string title, string author, DateTime date)
        {
            Console.WriteLine($"Generating report: {title}, Author: {author}, Date: {date.ToShortDateString()}");
        }
    }

    class MathOperations
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }

    class BankingSystem
    {
        public void CreateAccount()
        {
            Console.WriteLine("Account created with default information.");
        }

        public void CreateAccount(string name)
        {
            Console.WriteLine($"Account created for {name}.");
        }

        public void CreateAccount(string name, decimal balance)
        {
            Console.WriteLine($"Account created for {name} with balance ${balance}.");
        }

        public void CreateAccount(string name, decimal balance, string accountType)
        {
            Console.WriteLine($"Account created for {name}, Balance: ${balance}, Type: {accountType}.");
        }
    }

    class InventorySystem
    {
        public void AddProduct(string name)
        {
            Console.WriteLine($"Product added: {name}");
        }

        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Product added: {name}, Price: ${price}");
        }

        public void AddProduct(string name, decimal price, int quantity)
        {
            Console.WriteLine($"Product added: {name}, Price: ${price}, Quantity: {quantity}");
        }
    }

    class UserRegistration
    {
        public void Register(string username)
        {
            Console.WriteLine($"Register(string username) called.");
            Console.WriteLine($"Username: {username}");
        }

        public void Register(string username, string email)
        {
            Console.WriteLine($"Register(string username, string email) called.");
            Console.WriteLine($"Username: {username}, Email: {email}");
        }

        public void Register(string username, string email, string password)
        {
            Console.WriteLine($"Register(string username, string email, string password) called.");
            Console.WriteLine($"Username: {username}, Email: {email}, Password: {password}");
        }

        public void Register(string username, string email, string password, string phoneNumber)
        {
            Console.WriteLine($"Register(string username, string email, string password, string phoneNumber) called.");
            Console.WriteLine($"Username: {username}, Email: {email}, Password: {password}, Phone: {phoneNumber}");
        }
    }

    class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Product()
        {
            Name = "Unknown Product";
            Price = 0;
            Quantity = 0;
        }

        public Product(string name)
        {
            Name = name;
            Price = 0;
            Quantity = 1;
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Quantity = 1;
        }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Display()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Quantity: {Quantity}");
        }
    }

    class Customer
    {
        public string Name;
        public string Email;

        public Customer()
        {
            Name = "Guest";
            Email = "No Email";
        }

        public Customer(string name)
        {
            Name = name;
            Email = "No Email";
        }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Display()
        {
            Console.WriteLine($"Customer: {Name}, Email: {Email}");
        }
    }

    class Order
    {
        public string OrderName;
        public decimal Total;

        public Order()
        {
            OrderName = "Default Order";
            Total = 0;
        }

        public Order(string orderName)
        {
            OrderName = orderName;
            Total = 0;
        }

        public Order(string orderName, decimal total)
        {
            OrderName = orderName;
            Total = total;
        }

        public void AddProduct()
        {
            Console.WriteLine("AddProduct() called: Default product added.");
        }

        public void AddProduct(string name)
        {
            Console.WriteLine($"AddProduct(string name) called: {name} added.");
        }

        public void AddProduct(string name, int quantity)
        {
            Console.WriteLine($"AddProduct(string name, int quantity) called: {quantity} {name}(s) added.");
        }

        public void CreateOrder()
        {
            Console.WriteLine("CreateOrder() called: Default order created.");
        }

        public void CreateOrder(string customerName)
        {
            Console.WriteLine($"CreateOrder(string customerName) called: Order created for {customerName}.");
        }

        public void Checkout()
        {
            Console.WriteLine("Checkout() called: Basic checkout completed.");
        }

        public void Checkout(string paymentMethod)
        {
            Console.WriteLine($"Checkout(string paymentMethod) called: Paid using {paymentMethod}.");
        }

        public void Search(string keyword)
        {
            Console.WriteLine($"Search(string keyword) called: Searching for {keyword}.");
        }

        public void Search(string keyword, string category)
        {
            Console.WriteLine($"Search(string keyword, string category) called: Searching for {keyword} in {category}.");
        }

        public void Display()
        {
            Console.WriteLine($"Order: {OrderName}, Total: ${Total}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(5, 10));
            Console.WriteLine(calculator.Add(5, 10, 15));
            Console.WriteLine(calculator.Multiply(4, 5));
            Console.WriteLine(calculator.Multiply(4.5, 2.5));

            Printer printer = new Printer();

            printer.Print("Hello");
            printer.Print(100);
            printer.Print(99.99);

            Person person1 = new Person();
            Person person2 = new Person("Peyman");
            Person person3 = new Person("Peyman", 25);

            person1.Display();
            person2.Display();
            person3.Display();

            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle("Toyota");
            Vehicle vehicle3 = new Vehicle("BMW", 2026);

            vehicle1.Display();
            vehicle2.Display();
            vehicle3.Display();

            DisplayInfo displayInfo = new DisplayInfo();

            displayInfo.Display("Peyman");
            displayInfo.Display("Peyman", "Miyandashti");
            displayInfo.Display("Peyman", "Miyandashti", 25);

            TemperatureConverter converter = new TemperatureConverter();

            Console.WriteLine(converter.Convert(25));
            Console.WriteLine(converter.Convert(25, true));

            Payment payment = new Payment();

            payment.Pay(100);
            payment.Pay(250, "Credit Card");
            payment.Pay(500, "Cash", true);

            SearchEngine searchEngine = new SearchEngine();

            searchEngine.Search("C#");
            searchEngine.Search("C#", "Programming");
            searchEngine.Search("C#", "Programming", 2);

            Student student = new Student("Peyman", 25, "Information Technology Engineering");

            student.Display();

            ReportGenerator reportGenerator = new ReportGenerator();

            reportGenerator.Generate();
            reportGenerator.Generate("Sales Report");
            reportGenerator.Generate("Sales Report", "Peyman");
            reportGenerator.Generate("Sales Report", "Peyman", DateTime.Now);

            MathOperations mathOperations = new MathOperations();

            Console.WriteLine(mathOperations.Subtract(20, 5));
            Console.WriteLine(mathOperations.Subtract(20.5, 5.2));
            Console.WriteLine(mathOperations.Multiply(5, 5));
            Console.WriteLine(mathOperations.Multiply(5.5, 2.2));
            Console.WriteLine(mathOperations.Divide(20, 4));
            Console.WriteLine(mathOperations.Divide(20.5, 2.5));

            BankingSystem bankingSystem = new BankingSystem();

            bankingSystem.CreateAccount();
            bankingSystem.CreateAccount("Peyman");
            bankingSystem.CreateAccount("Peyman", 5000);
            bankingSystem.CreateAccount("Peyman", 5000, "Savings");

            InventorySystem inventorySystem = new InventorySystem();

            inventorySystem.AddProduct("Keyboard");
            inventorySystem.AddProduct("Mouse", 25.99m);
            inventorySystem.AddProduct("Monitor", 199.99m, 2);

            UserRegistration registration = new UserRegistration();

            registration.Register("peyman");
            registration.Register("peyman", "peyman@email.com");
            registration.Register("peyman", "peyman@email.com", "12345");
            registration.Register("peyman", "peyman@email.com", "12345", "+526865090453");

            Product product = new Product("Laptop", 1200.50m, 1);
            Customer customer = new Customer("Peyman", "peyman@email.com");
            Order order = new Order("Technology Order", 1200.50m);

            product.Display();
            customer.Display();
            order.Display();

            order.AddProduct();
            order.AddProduct("Laptop");
            order.AddProduct("Mouse", 2);

            order.CreateOrder();
            order.CreateOrder("Peyman");

            order.Checkout();
            order.Checkout("Debit Card");

            order.Search("Laptop");
            order.Search("Laptop", "Electronics");
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
