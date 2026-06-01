/*
=========================================
36 - SEALED
Sealed_Tasks_Solutions.cs
=========================================
*/

using System;

namespace SealedTasksSolutions
{
    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    sealed class GameSettings
    {
        public int MaxLevel = 1000;
        public int StartingGold = 10;
    }

    sealed class CurrencyConverter
    {
        public double DollarToPeso(double dollars)
        {
            return dollars * 17.00;
        }

        public double PesoToDollar(double pesos)
        {
            return pesos / 17.00;
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public sealed override void Speak()
        {
            Console.WriteLine("Dog says: Bark!");
        }
    }

    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started.");
        }
    }

    class Car : Vehicle
    {
        public sealed override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Manager : Employee
    {
        public sealed override void Work()
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }

    class Character
    {
        public virtual void Attack()
        {
            Console.WriteLine("Character attacks.");
        }
    }

    class Warrior : Character
    {
        public sealed override void Attack()
        {
            Console.WriteLine("Warrior performs a sealed heavy attack.");
        }
    }

    class EliteWarrior : Warrior
    {
        public void DisplayRank()
        {
            Console.WriteLine("Rank: Elite Warrior.");
        }
    }

    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Account interest calculated.");
        }
    }

    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Savings account interest calculated with protected rules.");
        }
    }

    class PremiumSavingsAccount : SavingsAccount
    {
        public void DisplayBenefits()
        {
            Console.WriteLine("Premium benefits: Higher savings rewards.");
        }
    }

    class AuthenticationSystem
    {
        public virtual void Login()
        {
            Console.WriteLine("Basic login process.");
        }
    }

    class SecureAuthenticationSystem : AuthenticationSystem
    {
        public sealed override void Login()
        {
            Console.WriteLine("Secure login process with protected logic.");
        }
    }

    class EnterpriseAuthenticationSystem : SecureAuthenticationSystem
    {
        public void DisplaySecurityLevel()
        {
            Console.WriteLine("Security Level: Enterprise.");
        }
    }

    sealed class SecurityManager
    {
        public void ValidateUser()
        {
            Console.WriteLine("User validated successfully.");
        }

        public void CheckPermissions()
        {
            Console.WriteLine("User permissions checked successfully.");
        }
    }

    sealed class PaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed safely.");
        }

        public void RefundPayment()
        {
            Console.WriteLine("Payment refunded safely.");
        }
    }

    sealed class SystemConfiguration
    {
        public string ApplicationName = "Learn How To Code";
        public string Version = "1.0.0";
        public int MaxUsers = 1000;

        public void Display()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"Version: {Version}");
            Console.WriteLine($"Max Users: {MaxUsers}");
        }
    }

    class Person
    {
        public virtual void DisplayRole()
        {
            Console.WriteLine("Role: Person.");
        }
    }

    class Teacher : Person
    {
        public sealed override void DisplayRole()
        {
            Console.WriteLine("Role: Teacher.");
        }
    }

    class HeadTeacher : Teacher
    {
        public void ManageSchool()
        {
            Console.WriteLine("HeadTeacher manages the school.");
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Unit attacks.");
        }
    }

    class Knight : Unit
    {
        public sealed override void Attack()
        {
            Console.WriteLine("Knight performs sealed sword attack.");
        }
    }

    class EliteKnight : Knight
    {
        public void DisplayTitle()
        {
            Console.WriteLine("Title: Elite Knight.");
        }
    }

    class BankAccount
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Bank account interest calculated.");
        }
    }

    class VIPSavingsAccount : SavingsAccount
    {
        public void DisplayVIPFeatures()
        {
            Console.WriteLine("VIP features unlocked.");
        }
    }

    sealed class LoginManager
    {
        public void ValidateLogin()
        {
            Console.WriteLine("Login validated.");
        }

        public void Logout()
        {
            Console.WriteLine("User logged out.");
        }
    }

    sealed class AccountSecurity
    {
        public void EnableTwoFactorAuthentication()
        {
            Console.WriteLine("Two-factor authentication enabled.");
        }

        public void LockAccount()
        {
            Console.WriteLine("Account locked.");
        }
    }

    sealed class PaymentSecurity
    {
        public void EncryptPaymentData()
        {
            Console.WriteLine("Payment data encrypted.");
        }

        public void ValidatePaymentToken()
        {
            Console.WriteLine("Payment token validated.");
        }
    }

    sealed class ServerConfiguration
    {
        public string ServerName = "Nova Zone Server";
        public int MaxPlayers = 5000;

        public void DisplayServerInfo()
        {
            Console.WriteLine($"Server Name: {ServerName}");
            Console.WriteLine($"Max Players: {MaxPlayers}");
        }
    }

    class Player : Character
    {
        public sealed override void Attack()
        {
            Console.WriteLine("Player performs protected attack logic.");
        }
    }

    class VIPPlayer : Player
    {
        public void DisplayVIPStatus()
        {
            Console.WriteLine("VIP Player status active.");
        }
    }

    class PremiumAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Premium account interest protected.");
        }
    }

    class LegendaryAccount : PremiumAccount
    {
        public void DisplayLegendaryBenefits()
        {
            Console.WriteLine("Legendary benefits unlocked.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(10, 5));

            GameSettings gameSettings = new GameSettings();
            Console.WriteLine($"Max Level: {gameSettings.MaxLevel}");
            Console.WriteLine($"Starting Gold: {gameSettings.StartingGold}");

            CurrencyConverter converter = new CurrencyConverter();
            Console.WriteLine(converter.DollarToPeso(100));
            Console.WriteLine(converter.PesoToDollar(1700));

            Dog dog = new Dog();
            dog.Speak();

            Car car = new Car();
            car.StartEngine();

            Manager manager = new Manager();
            manager.Work();

            EliteWarrior eliteWarrior = new EliteWarrior();
            eliteWarrior.Attack();
            eliteWarrior.DisplayRank();

            PremiumSavingsAccount premiumSavings = new PremiumSavingsAccount();
            premiumSavings.CalculateInterest();
            premiumSavings.DisplayBenefits();

            EnterpriseAuthenticationSystem enterpriseAuth =
                new EnterpriseAuthenticationSystem();

            enterpriseAuth.Login();
            enterpriseAuth.DisplaySecurityLevel();

            SecurityManager securityManager = new SecurityManager();
            securityManager.ValidateUser();
            securityManager.CheckPermissions();

            PaymentProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessPayment();
            paymentProcessor.RefundPayment();

            SystemConfiguration configuration = new SystemConfiguration();
            configuration.Display();

            HeadTeacher headTeacher = new HeadTeacher();
            headTeacher.DisplayRole();
            headTeacher.ManageSchool();

            EliteKnight eliteKnight = new EliteKnight();
            eliteKnight.Attack();
            eliteKnight.DisplayTitle();

            VIPSavingsAccount vipSavings = new VIPSavingsAccount();
            vipSavings.CalculateInterest();
            vipSavings.DisplayVIPFeatures();

            LoginManager loginManager = new LoginManager();
            loginManager.ValidateLogin();
            loginManager.Logout();

            AccountSecurity accountSecurity = new AccountSecurity();
            accountSecurity.EnableTwoFactorAuthentication();
            accountSecurity.LockAccount();

            PaymentSecurity paymentSecurity = new PaymentSecurity();
            paymentSecurity.EncryptPaymentData();
            paymentSecurity.ValidatePaymentToken();

            ServerConfiguration serverConfiguration = new ServerConfiguration();
            serverConfiguration.DisplayServerInfo();

            VIPPlayer vipPlayer = new VIPPlayer();
            vipPlayer.Attack();
            vipPlayer.DisplayVIPStatus();

            LegendaryAccount legendaryAccount = new LegendaryAccount();
            legendaryAccount.CalculateInterest();
            legendaryAccount.DisplayLegendaryBenefits();

            Console.WriteLine();
            Console.WriteLine("Sealed improves security, stability, and maintainability");
            Console.WriteLine("because it prevents important classes or methods from");
            Console.WriteLine("being changed through unsafe inheritance.");
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
