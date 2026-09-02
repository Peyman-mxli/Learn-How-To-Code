using System;

namespace SolidPrinciplesTasksSolutions
{
    // Task 1
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Task 2
    public class StudentPrinter
    {
        public void PrintStudent(string studentName)
        {
            Console.WriteLine($"Student Name: {studentName}");
        }
    }

    // Task 3
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
            Console.WriteLine($"Product saved: {product.Name} - ${product.Price}");
        }
    }

    // Task 4
    public interface IDiscount
    {
        decimal CalculateDiscount(decimal price);
    }

    public class StudentDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price * 0.10m;
        }
    }

    // Task 5
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card Payment: ${amount}");
        }
    }

    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"PayPal Payment: ${amount}");
        }
    }

    // Task 6
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Task 7
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Human : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Human is working");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }

    // Task 8
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailMessageService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email Message: {message}");
        }
    }

    public class NotificationService
    {
        private readonly IMessageService messageService;

        public NotificationService(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public void Notify(string message)
        {
            messageService.SendMessage(message);
        }
    }

    // Task 9
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public class ReportPrinter
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine($"Report Title: {report.Title}");
            Console.WriteLine($"Report Content: {report.Content}");
        }
    }

    public class ReportRepository
    {
        public void SaveReport(Report report)
        {
            Console.WriteLine($"Report saved: {report.Title}");
        }
    }

    // Task 10
    public interface IShippingCalculator
    {
        decimal CalculateShipping(decimal orderAmount);
    }

    public class LocalShippingCalculator : IShippingCalculator
    {
        public decimal CalculateShipping(decimal orderAmount)
        {
            return 5.00m;
        }
    }

    public class InternationalShippingCalculator : IShippingCalculator
    {
        public decimal CalculateShipping(decimal orderAmount)
        {
            return 25.00m;
        }
    }

    public class OrderShippingService
    {
        private readonly IShippingCalculator shippingCalculator;

        public OrderShippingService(IShippingCalculator shippingCalculator)
        {
            this.shippingCalculator = shippingCalculator;
        }

        public void ShowShipping(decimal orderAmount)
        {
            decimal shippingCost =
                shippingCalculator.CalculateShipping(orderAmount);

            Console.WriteLine($"Shipping Cost: ${shippingCost}");
        }
    }

    // Task 11
    public interface IUserRepository
    {
        void SaveUser(string username);
    }

    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public interface ILoggerService
    {
        void Log(string message);
    }

    public class UserRepository : IUserRepository
    {
        public void SaveUser(string username)
        {
            Console.WriteLine($"User saved: {username}");
        }
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class ConsoleLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public class UserRegistrationService
    {
        private readonly IUserRepository userRepository;
        private readonly IEmailService emailService;
        private readonly ILoggerService loggerService;

        public UserRegistrationService(
            IUserRepository userRepository,
            IEmailService emailService,
            ILoggerService loggerService)
        {
            this.userRepository = userRepository;
            this.emailService = emailService;
            this.loggerService = loggerService;
        }

        public void RegisterUser(string username)
        {
            userRepository.SaveUser(username);
            emailService.SendEmail($"Welcome {username}");
            loggerService.Log("User registration completed");
        }
    }

    // Task 12
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card processed: ${amount}");
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"PayPal processed: ${amount}");
        }
    }

    public class BankTransferProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Bank Transfer processed: ${amount}");
        }
    }

    public class CheckoutService
    {
        private readonly IPaymentProcessor paymentProcessor;

        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }

        public void Checkout(decimal amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }

    // Task 13
    public interface INotificationSender
    {
        void Send(string message);
    }

    public class EmailSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    public class NotificationManager
    {
        private readonly INotificationSender notificationSender;
        private readonly ILoggerService loggerService;

        public NotificationManager(
            INotificationSender notificationSender,
            ILoggerService loggerService)
        {
            this.notificationSender = notificationSender;
            this.loggerService = loggerService;
        }

        public void SendNotification(string message)
        {
            notificationSender.Send(message);
            loggerService.Log("Notification sent successfully");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Peyman", 25);

            StudentPrinter studentPrinter = new StudentPrinter();
            studentPrinter.PrintStudent(student.Name);

            Product product = new Product("Laptop", 1200.50m);

            ProductRepository productRepository =
                new ProductRepository();

            productRepository.SaveProduct(product);

            IDiscount discount = new StudentDiscount();

            Console.WriteLine(
                $"Student Discount: ${discount.CalculateDiscount(100)}"
            );

            IPaymentProcessor creditCardPayment =
                new CreditCardPayment();

            creditCardPayment.ProcessPayment(150);

            IPaymentProcessor payPalPayment =
                new PayPalPayment();

            payPalPayment.ProcessPayment(200);

            Animal animal = new Dog();
            animal.MakeSound();

            Human human = new Human();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();

            IMessageService messageService =
                new EmailMessageService();

            NotificationService notificationService =
                new NotificationService(messageService);

            notificationService.Notify("Welcome to SOLID Principles");

            Report report = new Report(
                "Monthly Report",
                "This is the monthly report content."
            );

            ReportPrinter reportPrinter =
                new ReportPrinter();

            ReportRepository reportRepository =
                new ReportRepository();

            reportPrinter.PrintReport(report);
            reportRepository.SaveReport(report);

            IShippingCalculator localShipping =
                new LocalShippingCalculator();

            OrderShippingService shippingService =
                new OrderShippingService(localShipping);

            shippingService.ShowShipping(100);

            IShippingCalculator internationalShipping =
                new InternationalShippingCalculator();

            shippingService =
                new OrderShippingService(internationalShipping);

            shippingService.ShowShipping(100);

            IUserRepository userRepository =
                new UserRepository();

            IEmailService emailService =
                new EmailService();

            ILoggerService loggerService =
                new ConsoleLoggerService();

            UserRegistrationService userRegistrationService =
                new UserRegistrationService(
                    userRepository,
                    emailService,
                    loggerService
                );

            userRegistrationService.RegisterUser("Peyman");

            IPaymentProcessor bankTransfer =
                new BankTransferProcessor();

            CheckoutService checkoutService =
                new CheckoutService(bankTransfer);

            checkoutService.Checkout(500);

            INotificationSender emailSender =
                new EmailSender();

            NotificationManager notificationManager =
                new NotificationManager(
                    emailSender,
                    loggerService
                );

            notificationManager.SendNotification(
                "This is an email notification"
            );

            INotificationSender smsSender =
                new SmsSender();

            notificationManager =
                new NotificationManager(
                    smsSender,
                    loggerService
                );

            notificationManager.SendNotification(
                "This is an SMS notification"
            );
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
