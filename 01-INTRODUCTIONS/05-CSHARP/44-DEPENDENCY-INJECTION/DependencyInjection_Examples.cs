using System;

namespace DependencyInjectionExamples
{
    // =========================================
    // Example 1 - Simple Dependency
    // =========================================

    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    // =========================================
    // Example 2 - Constructor Injection
    // =========================================

    public class UserService
    {
        private readonly EmailService emailService;

        public UserService(EmailService emailService)
        {
            this.emailService = emailService;
        }

        public void RegisterUser(string username)
        {
            Console.WriteLine($"User Registered: {username}");

            emailService.SendEmail(
                $"Welcome {username}!"
            );
        }
    }

    // =========================================
    // Example 3 - Interface Dependency
    // =========================================

    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }

    public class ProductService
    {
        private readonly ILogger logger;

        public ProductService(ILogger logger)
        {
            this.logger = logger;
        }

        public void AddProduct(string productName)
        {
            logger.Log(
                $"Product Added: {productName}"
            );
        }
    }

    // =========================================
    // Example 4 - Multiple Services
    // =========================================

    public interface INotificationService
    {
        void Notify(string message);
    }

    public class SmsNotificationService
        : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine(
                $"SMS Notification: {message}"
            );
        }
    }

    public class OrderService
    {
        private readonly INotificationService
            notificationService;

        public OrderService(
            INotificationService notificationService)
        {
            this.notificationService =
                notificationService;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order Created");

            notificationService.Notify(
                "Your order has been placed."
            );
        }
    }

    // =========================================
    // Example 5 - Swappable Implementations
    // =========================================

    public interface IMessageService
    {
        void Send(string message);
    }

    public class EmailMessageService
        : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine(
                $"Email Message: {message}"
            );
        }
    }

    public class SmsMessageService
        : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine(
                $"SMS Message: {message}"
            );
        }
    }

    public class NotificationManager
    {
        private readonly IMessageService
            messageService;

        public NotificationManager(
            IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public void SendNotification()
        {
            messageService.Send(
                "Dependency Injection Example"
            );
        }
    }

    // =========================================
    // Program
    // =========================================

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "================================="
            );
            Console.WriteLine(
                "DEPENDENCY INJECTION EXAMPLES"
            );
            Console.WriteLine(
                "================================="
            );

            Example1_SimpleDependency();

            Example2_ConstructorInjection();

            Example3_InterfaceInjection();

            Example4_MultipleServices();

            Example5_SwappableServices();
        }

        // =========================================
        // Example 1
        // =========================================

        static void Example1_SimpleDependency()
        {
            Console.WriteLine(
                "\n--- Example 1 ---"
            );

            EmailService emailService =
                new EmailService();

            emailService.SendEmail(
                "Hello World"
            );
        }

        // =========================================
        // Example 2
        // =========================================

        static void Example2_ConstructorInjection()
        {
            Console.WriteLine(
                "\n--- Example 2 ---"
            );

            EmailService emailService =
                new EmailService();

            UserService userService =
                new UserService(emailService);

            userService.RegisterUser(
                "Peyman"
            );
        }

        // =========================================
        // Example 3
        // =========================================

        static void Example3_InterfaceInjection()
        {
            Console.WriteLine(
                "\n--- Example 3 ---"
            );

            ILogger logger =
                new ConsoleLogger();

            ProductService productService =
                new ProductService(logger);

            productService.AddProduct(
                "Laptop"
            );
        }

        // =========================================
        // Example 4
        // =========================================

        static void Example4_MultipleServices()
        {
            Console.WriteLine(
                "\n--- Example 4 ---"
            );

            INotificationService
                notificationService =
                    new SmsNotificationService();

            OrderService orderService =
                new OrderService(
                    notificationService
                );

            orderService.PlaceOrder();
        }

        // =========================================
        // Example 5
        // =========================================

        static void Example5_SwappableServices()
        {
            Console.WriteLine(
                "\n--- Example 5 ---"
            );

            IMessageService messageService =
                new EmailMessageService();

            NotificationManager manager =
                new NotificationManager(
                    messageService
                );

            manager.SendNotification();

            Console.WriteLine();

            messageService =
                new SmsMessageService();

            manager =
                new NotificationManager(
                    messageService
                );

            manager.SendNotification();
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
