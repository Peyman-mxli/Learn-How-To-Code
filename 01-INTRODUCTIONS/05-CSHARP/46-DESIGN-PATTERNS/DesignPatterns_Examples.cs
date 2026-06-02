using System;
using System.Collections.Generic;

namespace DesignPatternsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("DESIGN PATTERNS EXAMPLES");
            Console.WriteLine("=================================");

            Example1_Singleton();
            Example2_Factory();
            Example3_Builder();
            Example4_Observer();
            Example5_Strategy();
        }

        // =========================================
        // EXAMPLE 1
        // SINGLETON PATTERN
        // =========================================

        static void Example1_Singleton()
        {
            Console.WriteLine("\n--- Example 1: Singleton Pattern ---");

            SettingsManager settings1 =
                SettingsManager.Instance;

            SettingsManager settings2 =
                SettingsManager.Instance;

            Console.WriteLine(
                $"Same Object: {ReferenceEquals(settings1, settings2)}"
            );
        }

        public class SettingsManager
        {
            private static SettingsManager instance;

            private SettingsManager()
            {
            }

            public static SettingsManager Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance =
                            new SettingsManager();
                    }

                    return instance;
                }
            }
        }

        // =========================================
        // EXAMPLE 2
        // FACTORY PATTERN
        // =========================================

        static void Example2_Factory()
        {
            Console.WriteLine("\n--- Example 2: Factory Pattern ---");

            IAnimal dog =
                AnimalFactory.CreateAnimal("Dog");

            IAnimal cat =
                AnimalFactory.CreateAnimal("Cat");

            dog.MakeSound();
            cat.MakeSound();
        }

        public interface IAnimal
        {
            void MakeSound();
        }

        public class Dog : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Dog Barks");
            }
        }

        public class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Cat Meows");
            }
        }

        public static class AnimalFactory
        {
            public static IAnimal CreateAnimal(string animalType)
            {
                if (animalType == "Dog")
                {
                    return new Dog();
                }

                if (animalType == "Cat")
                {
                    return new Cat();
                }

                return null;
            }
        }

        // =========================================
        // EXAMPLE 3
        // BUILDER PATTERN
        // =========================================

        static void Example3_Builder()
        {
            Console.WriteLine("\n--- Example 3: Builder Pattern ---");

            ComputerBuilder builder =
                new ComputerBuilder();

            builder.AddCpu("Intel i9");
            builder.AddRam("32 GB");
            builder.AddStorage("2 TB SSD");

            Computer computer =
                builder.Build();

            computer.DisplaySpecifications();
        }

        public class Computer
        {
            public string Cpu { get; set; }
            public string Ram { get; set; }
            public string Storage { get; set; }

            public void DisplaySpecifications()
            {
                Console.WriteLine($"CPU: {Cpu}");
                Console.WriteLine($"RAM: {Ram}");
                Console.WriteLine($"Storage: {Storage}");
            }
        }

        public class ComputerBuilder
        {
            private readonly Computer computer =
                new Computer();

            public void AddCpu(string cpu)
            {
                computer.Cpu = cpu;
            }

            public void AddRam(string ram)
            {
                computer.Ram = ram;
            }

            public void AddStorage(string storage)
            {
                computer.Storage = storage;
            }

            public Computer Build()
            {
                return computer;
            }
        }

        // =========================================
        // EXAMPLE 4
        // OBSERVER PATTERN
        // =========================================

        static void Example4_Observer()
        {
            Console.WriteLine("\n--- Example 4: Observer Pattern ---");

            YouTubeChannel channel =
                new YouTubeChannel();

            channel.Subscribe("Peyman");
            channel.Subscribe("Sara");

            channel.UploadVideo(
                "Learning Design Patterns"
            );
        }

        public class YouTubeChannel
        {
            private readonly List<string> subscribers =
                new List<string>();

            public void Subscribe(string subscriber)
            {
                subscribers.Add(subscriber);
            }

            public void UploadVideo(string title)
            {
                Console.WriteLine(
                    $"New Video Uploaded: {title}"
                );

                foreach (string subscriber
                    in subscribers)
                {
                    Console.WriteLine(
                        $"Notification sent to {subscriber}"
                    );
                }
            }
        }

        // =========================================
        // EXAMPLE 5
        // STRATEGY PATTERN
        // =========================================

        static void Example5_Strategy()
        {
            Console.WriteLine("\n--- Example 5: Strategy Pattern ---");

            PaymentContext context =
                new PaymentContext(
                    new CreditCardStrategy()
                );

            context.ProcessPayment(100);

            context =
                new PaymentContext(
                    new PayPalStrategy()
                );

            context.ProcessPayment(250);
        }

        public interface IPaymentStrategy
        {
            void Pay(decimal amount);
        }

        public class CreditCardStrategy
            : IPaymentStrategy
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine(
                    $"Credit Card Paid: ${amount}"
                );
            }
        }

        public class PayPalStrategy
            : IPaymentStrategy
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine(
                    $"PayPal Paid: ${amount}"
                );
            }
        }

        public class PaymentContext
        {
            private readonly IPaymentStrategy
                paymentStrategy;

            public PaymentContext(
                IPaymentStrategy paymentStrategy)
            {
                this.paymentStrategy =
                    paymentStrategy;
            }

            public void ProcessPayment(decimal amount)
            {
                paymentStrategy.Pay(amount);
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
