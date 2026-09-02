using System;
using System.Collections.Generic;

namespace DesignPatternsTasksSolutions
{
    // Task 1
    public class AppSettings
    {
        public string ApplicationName { get; set; }

        public AppSettings(string applicationName)
        {
            ApplicationName = applicationName;
        }

        public void DisplayApplicationName()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
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
                    instance = new SettingsManager();
                }

                return instance;
            }
        }

        public void ShowSettings()
        {
            Console.WriteLine("Application settings loaded");
        }
    }

    // Task 4
    public interface IAnimal
    {
        void MakeSound();
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    // Task 5
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

    // Task 6
    public class Computer
    {
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }

        public void DisplayComputer()
        {
            Console.WriteLine($"CPU: {Cpu}");
            Console.WriteLine($"RAM: {Ram}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }

    public class ComputerBuilder
    {
        private readonly Computer computer = new Computer();

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

    // Task 7
    public class NewsPublisher
    {
        private readonly List<string> subscribers =
            new List<string>();

        public void Subscribe(string subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void PublishNews(string newsTitle)
        {
            Console.WriteLine($"News Published: {newsTitle}");

            foreach (string subscriber in subscribers)
            {
                Console.WriteLine($"Notification sent to {subscriber}");
            }
        }
    }

    // Task 8
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Credit Card Payment: ${amount}");
        }
    }

    public class PayPalStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"PayPal Payment: ${amount}");
        }
    }

    public class PaymentContext
    {
        private readonly IPaymentStrategy paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }

    // Task 9
    public class AudioSystem
    {
        public void StartAudio()
        {
            Console.WriteLine("Audio system started");
        }
    }

    public class VideoSystem
    {
        public void StartVideo()
        {
            Console.WriteLine("Video system started");
        }
    }

    public class LightSystem
    {
        public void DimLights()
        {
            Console.WriteLine("Lights dimmed");
        }
    }

    public class HomeTheaterFacade
    {
        private readonly AudioSystem audioSystem;
        private readonly VideoSystem videoSystem;
        private readonly LightSystem lightSystem;

        public HomeTheaterFacade(
            AudioSystem audioSystem,
            VideoSystem videoSystem,
            LightSystem lightSystem)
        {
            this.audioSystem = audioSystem;
            this.videoSystem = videoSystem;
            this.lightSystem = lightSystem;
        }

        public void StartMovie()
        {
            audioSystem.StartAudio();
            videoSystem.StartVideo();
            lightSystem.DimLights();

            Console.WriteLine("Movie started");
        }
    }

    // Task 10
    public class OldPrinter
    {
        public void PrintOld()
        {
            Console.WriteLine("Printing with old printer");
        }
    }

    public interface INewPrinter
    {
        void Print();
    }

    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            this.oldPrinter = oldPrinter;
        }

        public void Print()
        {
            oldPrinter.PrintOld();
        }
    }

    // Task 11
    public interface ICoffee
    {
        string GetDescription();
    }

    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }

    public class MilkDecorator : ICoffee
    {
        private readonly ICoffee coffee;

        public MilkDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + " + Milk";
        }
    }

    public class SugarDecorator : ICoffee
    {
        private readonly ICoffee coffee;

        public SugarDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + " + Sugar";
        }
    }

    // Task 12
    public interface ICommand
    {
        void Execute();
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light turned off");
        }
    }

    public class TurnOnCommand : ICommand
    {
        private readonly Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    public class TurnOffCommand : ICommand
    {
        private readonly Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }

    public class RemoteControl
    {
        private readonly ICommand command;

        public RemoteControl(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }

    // Task 13
    public interface INotificationStrategy
    {
        void SendNotification(string message);
    }

    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }

    public class SmsNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS notification: {message}");
        }
    }

    public class PushNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Push notification: {message}");
        }
    }

    public class NotificationContext
    {
        private readonly INotificationStrategy notificationStrategy;

        public NotificationContext(
            INotificationStrategy notificationStrategy)
        {
            this.notificationStrategy = notificationStrategy;
        }

        public void Send(string message)
        {
            notificationStrategy.SendNotification(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppSettings appSettings =
                new AppSettings("Learn How To Code");

            appSettings.DisplayApplicationName();

            Logger logger = new Logger();

            logger.Log("Application started");

            SettingsManager settingsManager =
                SettingsManager.Instance;

            settingsManager.ShowSettings();

            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();

            IAnimal factoryDog =
                AnimalFactory.CreateAnimal("Dog");

            IAnimal factoryCat =
                AnimalFactory.CreateAnimal("Cat");

            factoryDog.MakeSound();
            factoryCat.MakeSound();

            ComputerBuilder computerBuilder =
                new ComputerBuilder();

            computerBuilder.AddCpu("Intel i7");
            computerBuilder.AddRam("16 GB");
            computerBuilder.AddStorage("1 TB SSD");

            Computer computer =
                computerBuilder.Build();

            computer.DisplayComputer();

            NewsPublisher newsPublisher =
                new NewsPublisher();

            newsPublisher.Subscribe("Peyman");
            newsPublisher.Subscribe("Sara");

            newsPublisher.PublishNews("Design Patterns Released");

            IPaymentStrategy creditCardStrategy =
                new CreditCardStrategy();

            PaymentContext paymentContext =
                new PaymentContext(creditCardStrategy);

            paymentContext.ProcessPayment(100);

            IPaymentStrategy payPalStrategy =
                new PayPalStrategy();

            paymentContext =
                new PaymentContext(payPalStrategy);

            paymentContext.ProcessPayment(200);

            AudioSystem audioSystem =
                new AudioSystem();

            VideoSystem videoSystem =
                new VideoSystem();

            LightSystem lightSystem =
                new LightSystem();

            HomeTheaterFacade homeTheater =
                new HomeTheaterFacade(
                    audioSystem,
                    videoSystem,
                    lightSystem
                );

            homeTheater.StartMovie();

            OldPrinter oldPrinter =
                new OldPrinter();

            INewPrinter printer =
                new PrinterAdapter(oldPrinter);

            printer.Print();

            ICoffee coffee =
                new SimpleCoffee();

            coffee =
                new MilkDecorator(coffee);

            coffee =
                new SugarDecorator(coffee);

            Console.WriteLine(coffee.GetDescription());

            Light light = new Light();

            ICommand turnOnCommand =
                new TurnOnCommand(light);

            RemoteControl remoteControl =
                new RemoteControl(turnOnCommand);

            remoteControl.PressButton();

            ICommand turnOffCommand =
                new TurnOffCommand(light);

            remoteControl =
                new RemoteControl(turnOffCommand);

            remoteControl.PressButton();

            INotificationStrategy emailNotification =
                new EmailNotificationStrategy();

            NotificationContext notificationContext =
                new NotificationContext(emailNotification);

            notificationContext.Send("Welcome by email");

            INotificationStrategy smsNotification =
                new SmsNotificationStrategy();

            notificationContext =
                new NotificationContext(smsNotification);

            notificationContext.Send("Welcome by SMS");

            INotificationStrategy pushNotification =
                new PushNotificationStrategy();

            notificationContext =
                new NotificationContext(pushNotification);

            notificationContext.Send("Welcome by push notification");
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
