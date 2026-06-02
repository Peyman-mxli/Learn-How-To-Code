using System;

namespace RefactoringTasksSolutions
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class ProductRepository
    {
        public void SaveProduct(Product product)
        {
            Console.WriteLine($"Product saved: {product.Name}");
        }
    }

    public class ProductPrinter
    {
        public void PrintProduct(Product product)
        {
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Product Price: ${product.Price}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    public class CustomerValidator
    {
        public bool IsValid(Customer customer)
        {
            return !string.IsNullOrWhiteSpace(customer.Name)
                && !string.IsNullOrWhiteSpace(customer.Email);
        }
    }

    public class CustomerRepository
    {
        public void SaveCustomer(Customer customer)
        {
            Console.WriteLine($"Customer saved: {customer.Name}");
        }
    }

    public class EmailService
    {
        public void SendWelcomeEmail(Customer customer)
        {
            Console.WriteLine($"Welcome email sent to: {customer.Email}");
        }
    }

    public class CustomerRegistrationService
    {
        private readonly CustomerValidator customerValidator;
        private readonly CustomerRepository customerRepository;
        private readonly EmailService emailService;

        public CustomerRegistrationService(
            CustomerValidator customerValidator,
            CustomerRepository customerRepository,
            EmailService emailService)
        {
            this.customerValidator = customerValidator;
            this.customerRepository = customerRepository;
            this.emailService = emailService;
        }

        public void RegisterCustomer(Customer customer)
        {
            if (!customerValidator.IsValid(customer))
            {
                Console.WriteLine("Invalid customer data");
                return;
            }

            customerRepository.SaveCustomer(customer);
            emailService.SendWelcomeEmail(customer);
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

    public class EmployeeValidator
    {
        public bool IsValid(Employee employee)
        {
            return !string.IsNullOrWhiteSpace(employee.Name)
                && !string.IsNullOrWhiteSpace(employee.Position)
                && employee.Salary > 0;
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

    public class EmployeeService
    {
        private readonly EmployeeValidator employeeValidator;
        private readonly EmployeeRepository employeeRepository;
        private readonly EmployeePrinter employeePrinter;

        public EmployeeService(
            EmployeeValidator employeeValidator,
            EmployeeRepository employeeRepository,
            EmployeePrinter employeePrinter)
        {
            this.employeeValidator = employeeValidator;
            this.employeeRepository = employeeRepository;
            this.employeePrinter = employeePrinter;
        }

        public void ProcessEmployee(Employee employee)
        {
            if (!employeeValidator.IsValid(employee))
            {
                Console.WriteLine("Invalid employee data");
                return;
            }

            employeeRepository.SaveEmployee(employee);
            employeePrinter.PrintEmployee(employee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task1_RefactorVariables();
            Task2_ExtractWelcomeMessage();
            Task3_RemoveDuplicateSeparator();
            Task4_ReplaceMagicNumber();
            Task5_RefactorCondition();
            Task6_SplitUserRegistration();
            Task7_RefactorPriceCalculation();
            Task8_RefactorOrderLogic();
            Task9_RefactorProductDesign();
            Task10_UseEarlyReturns();
            Task11_CustomerRegistrationSystem();
            Task12_CalculatorSystem();
            Task13_EmployeeSystem();
        }

        static void Task1_RefactorVariables()
        {
            int productPrice = 20;
            int quantity = 5;
            int totalPrice = productPrice * quantity;

            Console.WriteLine($"Total Price: {totalPrice}");
        }

        static void Task2_ExtractWelcomeMessage()
        {
            ShowWelcomeMessage();
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to Refactoring!");
        }

        static void Task3_RemoveDuplicateSeparator()
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

        static void Task4_ReplaceMagicNumber()
        {
            const int PassingScore = 70;

            int studentScore = 85;

            if (studentScore >= PassingScore)
            {
                Console.WriteLine("Student passed");
            }
            else
            {
                Console.WriteLine("Student failed");
            }
        }

        static void Task5_RefactorCondition()
        {
            int age = 20;
            int examScore = 90;

            bool isAdult = age >= 18;
            bool passedExam = examScore >= 70;

            if (isAdult && passedExam)
            {
                Console.WriteLine("Student accepted");
            }
            else
            {
                Console.WriteLine("Student not accepted");
            }
        }

        static void Task6_SplitUserRegistration()
        {
            RegisterUser("Peyman");
        }

        static void RegisterUser(string username)
        {
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
            Console.WriteLine($"Welcome email sent to: {username}");
        }

        static void Task7_RefactorPriceCalculation()
        {
            decimal totalPrice = CalculateTotalPrice(50, 3);

            Console.WriteLine($"Total Price: ${totalPrice}");
        }

        static decimal CalculateTotalPrice(
            decimal productPrice,
            int quantity)
        {
            return productPrice * quantity;
        }

        static void Task8_RefactorOrderLogic()
        {
            ValidateOrder();

            decimal orderTotal = CalculateOrderTotal(100, 2);

            decimal finalTotal = ApplyDiscount(orderTotal, 10);

            ProcessPayment(finalTotal);
        }

        static void ValidateOrder()
        {
            Console.WriteLine("Order validated");
        }

        static decimal CalculateOrderTotal(
            decimal productPrice,
            int quantity)
        {
            return productPrice * quantity;
        }

        static decimal ApplyDiscount(
            decimal orderTotal,
            decimal discountPercentage)
        {
            decimal discountAmount =
                orderTotal * (discountPercentage / 100);

            return orderTotal - discountAmount;
        }

        static void ProcessPayment(decimal finalTotal)
        {
            Console.WriteLine($"Payment processed: ${finalTotal}");
        }

        static void Task9_RefactorProductDesign()
        {
            Product product =
                new Product("Laptop", 1200);

            ProductRepository productRepository =
                new ProductRepository();

            ProductPrinter productPrinter =
                new ProductPrinter();

            productRepository.SaveProduct(product);
            productPrinter.PrintProduct(product);
        }

        static void Task10_UseEarlyReturns()
        {
            CheckAccess("Peyman", true);
            CheckAccess("", true);
            CheckAccess("Sara", false);
        }

        static void CheckAccess(string username, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username is required");
                return;
            }

            if (!isActive)
            {
                Console.WriteLine("User is not active");
                return;
            }

            Console.WriteLine("Access granted");
        }

        static void Task11_CustomerRegistrationSystem()
        {
            Customer customer =
                new Customer(
                    "Peyman",
                    "mxli.peyman@gmail.com"
                );

            CustomerValidator customerValidator =
                new CustomerValidator();

            CustomerRepository customerRepository =
                new CustomerRepository();

            EmailService emailService =
                new EmailService();

            CustomerRegistrationService registrationService =
                new CustomerRegistrationService(
                    customerValidator,
                    customerRepository,
                    emailService
                );

            registrationService.RegisterCustomer(customer);
        }

        static void Task12_CalculatorSystem()
        {
            decimal firstNumber = 20;
            decimal secondNumber = 5;

            DisplayResult("Addition", Add(firstNumber, secondNumber));
            DisplayResult("Subtraction", Subtract(firstNumber, secondNumber));
            DisplayResult("Multiplication", Multiply(firstNumber, secondNumber));
            DisplayResult("Division", Divide(firstNumber, secondNumber));
        }

        static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        static void DisplayResult(string operationName, decimal result)
        {
            Console.WriteLine($"{operationName}: {result}");
        }

        static void Task13_EmployeeSystem()
        {
            Employee employee =
                new Employee(
                    "Peyman",
                    "Software Developer",
                    5000
                );

            EmployeeValidator employeeValidator =
                new EmployeeValidator();

            EmployeeRepository employeeRepository =
                new EmployeeRepository();

            EmployeePrinter employeePrinter =
                new EmployeePrinter();

            EmployeeService employeeService =
                new EmployeeService(
                    employeeValidator,
                    employeeRepository,
                    employeePrinter
                );

            employeeService.ProcessEmployee(employee);
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
