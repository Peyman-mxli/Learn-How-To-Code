using System;

namespace CleanCodeTasksSolutions
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void DisplayCustomerInformation()
        {
            Console.WriteLine($"Customer: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
    }

    public class EmployeeRepository
    {
        public void SaveEmployee(Employee employee)
        {
            Console.WriteLine($"Employee saved: {employee.Name}");
        }
    }

    public class EmployeePrinter
    {
        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Salary: ${employee.Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task1_MeaningfulVariableNames();
            Task2_DisplayWelcomeMessage();
            Task3_RectangleArea();
            Task4_BooleanName();
            Task5_OrderTotal();
            Task6_ReusableSeparator();
            Task7_PassedExam();
            Task8_RefactoredVariables();
            Task9_UserRegistrationFlow();
            Task10_Discount();
            Task11_CustomerClass();
            Task12_OrderSystem();
            Task13_EmployeeSystem();
        }

        static void Task1_MeaningfulVariableNames()
        {
            string studentName = "Peyman";
            int studentAge = 25;
            double studentGrade = 95.5;

            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student Age: {studentAge}");
            Console.WriteLine($"Student Grade: {studentGrade}");
        }

        static void Task2_DisplayWelcomeMessage()
        {
            DisplayWelcomeMessage();
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Clean Code!");
        }

        static void Task3_RectangleArea()
        {
            double rectangleArea = CalculateRectangleArea(5, 10);

            Console.WriteLine($"Rectangle Area: {rectangleArea}");
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static void Task4_BooleanName()
        {
            bool isLoggedIn = true;

            Console.WriteLine($"Is Logged In: {isLoggedIn}");
        }

        static void Task5_OrderTotal()
        {
            decimal productPrice = 50.00m;
            int quantity = 3;
            decimal totalOrderPrice = productPrice * quantity;

            Console.WriteLine($"Total Order Price: ${totalOrderPrice}");
        }

        static void Task6_ReusableSeparator()
        {
            ShowSeparator();
            Console.WriteLine("Section One");

            ShowSeparator();
            Console.WriteLine("Section Two");

            ShowSeparator();
            Console.WriteLine("Section Three");
        }

        static void ShowSeparator()
        {
            Console.WriteLine("------------------------------");
        }

        static void Task7_PassedExam()
        {
            int examScore = 85;
            int passingScore = 70;

            bool passedExam = examScore >= passingScore;

            Console.WriteLine($"Passed Exam: {passedExam}");
        }

        static void Task8_RefactoredVariables()
        {
            int productPrice = 50;
            int productQuantity = 5;
            int totalPrice = productPrice * productQuantity;

            Console.WriteLine($"Total Price: {totalPrice}");
        }

        static void Task9_UserRegistrationFlow()
        {
            string username = "Peyman";

            ValidateUser(username);
            SaveUser(username);
            SendWelcomeEmail(username);
        }

        static void ValidateUser(string username)
        {
            Console.WriteLine($"Validating user: {username}");
        }

        static void SaveUser(string username)
        {
            Console.WriteLine($"Saving user: {username}");
        }

        static void SendWelcomeEmail(string username)
        {
            Console.WriteLine($"Sending welcome email to: {username}");
        }

        static void Task10_Discount()
        {
            decimal productPrice = 100;
            decimal discountPercentage = 20;

            decimal discountedValue =
                CalculateDiscount(productPrice, discountPercentage);

            Console.WriteLine($"Discounted Value: ${discountedValue}");
        }

        static decimal CalculateDiscount(
            decimal productPrice,
            decimal discountPercentage)
        {
            return productPrice * (discountPercentage / 100);
        }

        static void Task11_CustomerClass()
        {
            Customer customer =
                new Customer(
                    "Peyman",
                    "Miyandashti",
                    "mxli.peyman@gmail.com"
                );

            customer.DisplayCustomerInformation();
        }

        static void Task12_OrderSystem()
        {
            ValidateOrder();
            decimal orderTotal = CalculateOrderTotal(25, 4);
            ProcessPayment(orderTotal);
            GenerateReceipt(orderTotal);
        }

        static void ValidateOrder()
        {
            Console.WriteLine("Order validated successfully");
        }

        static decimal CalculateOrderTotal(
            decimal productPrice,
            int quantity)
        {
            return productPrice * quantity;
        }

        static void ProcessPayment(decimal orderTotal)
        {
            Console.WriteLine($"Payment processed: ${orderTotal}");
        }

        static void GenerateReceipt(decimal orderTotal)
        {
            Console.WriteLine($"Receipt generated for: ${orderTotal}");
        }

        static void Task13_EmployeeSystem()
        {
            Employee employee =
                new Employee(
                    "Peyman",
                    "Software Developer",
                    5000
                );

            EmployeeRepository employeeRepository =
                new EmployeeRepository();

            EmployeePrinter employeePrinter =
                new EmployeePrinter();

            employeeRepository.SaveEmployee(employee);
            employeePrinter.PrintEmployee(employee);
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
