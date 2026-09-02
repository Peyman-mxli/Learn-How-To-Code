using System;

namespace SolidPrinciplesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("SOLID PRINCIPLES EXAMPLES");
            Console.WriteLine("=================================");

            Example1_SingleResponsibility();

            Example2_OpenClosed();

            Example3_LiskovSubstitution();

            Example4_InterfaceSegregation();

            Example5_DependencyInversion();
        }

        // =========================================
        // EXAMPLE 1
        // SINGLE RESPONSIBILITY PRINCIPLE
        // =========================================

        static void Example1_SingleResponsibility()
        {
            Console.WriteLine("\n--- Example 1: Single Responsibility Principle ---");

            User user = new User("Peyman");

            UserRepository repository = new UserRepository();

            repository.SaveUser(user);
        }

        public class User
        {
            public string Name { get; set; }

            public User(string name)
            {
                Name = name;
            }
        }

        public class UserRepository
        {
            public void SaveUser(User user)
            {
                Console.WriteLine($"Saving user: {user.Name}");
            }
        }

        // =========================================
        // EXAMPLE 2
        // OPEN/CLOSED PRINCIPLE
        // =========================================

        static void Example2_OpenClosed()
        {
            Console.WriteLine("\n--- Example 2: Open/Closed Principle ---");

            IPaymentProcessor creditCard =
                new CreditCardPayment();

            IPaymentProcessor payPal =
                new PayPalPayment();

            creditCard.ProcessPayment(100);

            payPal.ProcessPayment(200);
        }

        public interface IPaymentProcessor
        {
            void ProcessPayment(decimal amount);
        }

        public class CreditCardPayment
            : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine(
                    $"Credit Card Payment: ${amount}");
            }
        }

        public class PayPalPayment
            : IPaymentProcessor
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine(
                    $"PayPal Payment: ${amount}");
            }
        }

        // =========================================
        // EXAMPLE 3
        // LISKOV SUBSTITUTION PRINCIPLE
        // =========================================

        static void Example3_LiskovSubstitution()
        {
            Console.WriteLine(
                "\n--- Example 3: Liskov Substitution Principle ---");

            Animal dog = new Dog();

            dog.MakeSound();
        }

        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal Sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog Barks");
            }
        }

        // =========================================
        // EXAMPLE 4
        // INTERFACE SEGREGATION PRINCIPLE
        // =========================================

        static void Example4_InterfaceSegregation()
        {
            Console.WriteLine(
                "\n--- Example 4: Interface Segregation Principle ---");

            Human human = new Human();

            Robot robot = new Robot();

            human.Work();
            human.Eat();

            robot.Work();
        }

        public interface IWorkable
        {
            void Work();
        }

        public interface IEatable
        {
            void Eat();
        }

        public class Human
            : IWorkable, IEatable
        {
            public void Work()
            {
                Console.WriteLine("Human Working");
            }

            public void Eat()
            {
                Console.WriteLine("Human Eating");
            }
        }

        public class Robot
            : IWorkable
        {
            public void Work()
            {
                Console.WriteLine("Robot Working");
            }
        }

        // =========================================
        // EXAMPLE 5
        // DEPENDENCY INVERSION PRINCIPLE
        // =========================================

        static void Example5_DependencyInversion()
        {
            Console.WriteLine(
                "\n--- Example 5: Dependency Inversion Principle ---");

            IMessageService emailService =
                new EmailService();

            NotificationService notificationService =
                new NotificationService(emailService);

            notificationService.Notify(
                "Welcome to SOLID Principles");
        }

        public interface IMessageService
        {
            void Send(string message);
        }

        public class EmailService
            : IMessageService
        {
            public void Send(string message)
            {
                Console.WriteLine(
                    $"Email Sent: {message}");
            }
        }

        public class NotificationService
        {
            private readonly IMessageService
                messageService;

            public NotificationService(
                IMessageService messageService)
            {
                this.messageService = messageService;
            }

            public void Notify(string message)
            {
                messageService.Send(message);
            }
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
