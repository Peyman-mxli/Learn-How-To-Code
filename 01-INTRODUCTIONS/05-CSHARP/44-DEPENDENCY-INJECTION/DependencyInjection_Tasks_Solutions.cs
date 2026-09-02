using System;

namespace DependencyInjectionTasksSolutions
{
    // Task 1
    public class MessageService
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello from MessageService");
        }
    }

    // Task 2
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    // Task 3
    public class UserService
    {
        private readonly Logger logger;

        public UserService(Logger logger)
        {
            this.logger = logger;
        }

        public void CreateUser()
        {
            logger.Log("User created successfully");
        }
    }

    // Task 4
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    public class NotificationService
    {
        private readonly EmailService emailService;

        public NotificationService(EmailService emailService)
        {
            this.emailService = emailService;
        }

        public void Notify()
        {
            emailService.SendEmail("Notification sent");
        }
    }

    // Task 5
    public interface IPrinter
    {
        void Print(string message);
    }

    public class ConsolePrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Print: {message}");
        }
    }

    public class ReportService
    {
        private readonly IPrinter printer;

        public ReportService(IPrinter printer)
        {
            this.printer = printer;
        }

        public void PrintReport()
        {
            printer.Print("Report generated successfully");
        }
    }

    // Task 6
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit card payment processed: ${amount}");
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"PayPal payment processed: ${amount}");
        }
    }

    public class OrderService
    {
        private readonly IPaymentProcessor paymentProcessor;

        public OrderService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }

        public void CompleteOrder(decimal amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }

    // Task 7
    public interface IEmailSender
    {
        void Send(string message);
    }

    public class GmailSender : IEmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Gmail sent: {message}");
        }
    }

    public class AccountService
    {
        private readonly IEmailSender emailSender;

        public AccountService(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public void CreateAccount()
        {
            emailSender.Send("Welcome to your new account");
        }
    }

    // Task 8
    public interface IRepository
    {
        void Save(string data);
    }

    public class UserRepository : IRepository
    {
        public void Save(string data)
        {
            Console.WriteLine($"User saved: {data}");
        }
    }

    public class UserManager
    {
        private readonly IRepository repository;

        public UserManager(IRepository repository)
        {
            this.repository = repository;
        }

        public void SaveUser(string username)
        {
            repository.Save(username);
        }
    }

    // Task 9
    public interface INotification
    {
        void SendNotification(string message);
    }

    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS notification: {message}");
        }
    }

    public class NotificationManager
    {
        private readonly INotification notification;

        public NotificationManager(INotification notification)
        {
            this.notification = notification;
        }

        public void Send(string message)
        {
            notification.SendNotification(message);
        }
    }

    // Task 10
    public interface ILoggerService
    {
        void Log(string message);
    }

    public interface IRepositoryService
    {
        void Save(string data);
    }

    public class ConsoleLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logger Service: {message}");
        }
    }

    public class ProductRepositoryService : IRepositoryService
    {
        public void Save(string data)
        {
            Console.WriteLine($"Product saved: {data}");
        }
    }

    public class ProductService
    {
        private readonly ILoggerService loggerService;
        private readonly IRepositoryService repositoryService;

        public ProductService(
            ILoggerService loggerService,
            IRepositoryService repositoryService)
        {
            this.loggerService = loggerService;
            this.repositoryService = repositoryService;
        }

        public void AddProduct(string productName)
        {
            repositoryService.Save(productName);
            loggerService.Log("Product added successfully");
        }
    }

    // Task 11
    public interface IPaymentService
    {
        void Pay(decimal amount);
    }

    public interface IReceiptService
    {
        void CreateReceipt(decimal amount);
    }

    public class SimplePaymentService : IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment completed: ${amount}");
        }
    }

    public class SimpleReceiptService : IReceiptService
    {
        public void CreateReceipt(decimal amount)
        {
            Console.WriteLine($"Receipt created for: ${amount}");
        }
    }

    public class CheckoutService
    {
        private readonly IPaymentService paymentService;
        private readonly IReceiptService receiptService;
        private readonly ILoggerService loggerService;

        public CheckoutService(
            IPaymentService paymentService,
            IReceiptService receiptService,
            ILoggerService loggerService)
        {
            this.paymentService = paymentService;
            this.receiptService = receiptService;
            this.loggerService = loggerService;
        }

        public void Checkout(decimal amount)
        {
            paymentService.Pay(amount);
            receiptService.CreateReceipt(amount);
            loggerService.Log("Checkout completed successfully");
        }
    }

    // Task 12
    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public class RealEmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Real email sent: {message}");
        }
    }

    public class FakeEmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Fake email simulated: {message}");
        }
    }

    public class UserRegistrationService
    {
        private readonly IEmailService emailService;

        public UserRegistrationService(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void RegisterUser(string username)
        {
            Console.WriteLine($"User registered: {username}");
            emailService.SendEmail("Registration email sent");
        }
    }

    // Task 13
    public interface ICustomerRepository
    {
        void SaveCustomer(string customerName);
    }

    public interface ICustomerValidator
    {
        bool IsValid(string customerName);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void SaveCustomer(string customerName)
        {
            Console.WriteLine($"Customer saved: {customerName}");
        }
    }

    public class CustomerValidator : ICustomerValidator
    {
        public bool IsValid(string customerName)
        {
            return !string.IsNullOrWhiteSpace(customerName);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Logger: {message}");
        }
    }

    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ICustomerValidator customerValidator;
        private readonly ILogger logger;

        public CustomerService(
            ICustomerRepository customerRepository,
            ICustomerValidator customerValidator,
            ILogger logger)
        {
            this.customerRepository = customerRepository;
            this.customerValidator = customerValidator;
            this.logger = logger;
        }

        public void AddCustomer(string customerName)
        {
            if (customerValidator.IsValid(customerName))
            {
                customerRepository.SaveCustomer(customerName);
                logger.Log("Customer added successfully");
            }
            else
            {
                logger.Log("Invalid customer name");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MessageService messageService = new MessageService();
            messageService.ShowMessage();

            Logger logger = new Logger();
            logger.Log("This is a simple log message");

            UserService userService = new UserService(logger);
            userService.CreateUser();

            EmailService emailService = new EmailService();
            NotificationService notificationService =
                new NotificationService(emailService);
            notificationService.Notify();

            IPrinter printer = new ConsolePrinter();
            ReportService reportService = new ReportService(printer);
            reportService.PrintReport();

            IPaymentProcessor creditCardProcessor =
                new CreditCardProcessor();
            OrderService orderService =
                new OrderService(creditCardProcessor);
            orderService.CompleteOrder(250);

            IPaymentProcessor payPalProcessor =
                new PayPalProcessor();
            orderService = new OrderService(payPalProcessor);
            orderService.CompleteOrder(300);

            IEmailSender emailSender = new GmailSender();
            AccountService accountService =
                new AccountService(emailSender);
            accountService.CreateAccount();

            IRepository repository = new UserRepository();
            UserManager userManager = new UserManager(repository);
            userManager.SaveUser("Peyman");

            INotification emailNotification =
                new EmailNotification();
            NotificationManager notificationManager =
                new NotificationManager(emailNotification);
            notificationManager.Send("Hello by email");

            INotification smsNotification =
                new SmsNotification();
            notificationManager =
                new NotificationManager(smsNotification);
            notificationManager.Send("Hello by SMS");

            ILoggerService loggerService =
                new ConsoleLoggerService();
            IRepositoryService repositoryService =
                new ProductRepositoryService();
            ProductService productService =
                new ProductService(loggerService, repositoryService);
            productService.AddProduct("Laptop");

            IPaymentService paymentService =
                new SimplePaymentService();
            IReceiptService receiptService =
                new SimpleReceiptService();
            CheckoutService checkoutService =
                new CheckoutService(
                    paymentService,
                    receiptService,
                    loggerService
                );
            checkoutService.Checkout(500);

            IEmailService realEmailService =
                new RealEmailService();
            UserRegistrationService registrationService =
                new UserRegistrationService(realEmailService);
            registrationService.RegisterUser("Peyman");

            IEmailService fakeEmailService =
                new FakeEmailService();
            registrationService =
                new UserRegistrationService(fakeEmailService);
            registrationService.RegisterUser("Test User");

            ICustomerRepository customerRepository =
                new CustomerRepository();
            ICustomerValidator customerValidator =
                new CustomerValidator();
            ILogger customerLogger =
                new ConsoleLogger();

            CustomerService customerService =
                new CustomerService(
                    customerRepository,
                    customerValidator,
                    customerLogger
                );

            customerService.AddCustomer("Sara");
            customerService.AddCustomer("");
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
