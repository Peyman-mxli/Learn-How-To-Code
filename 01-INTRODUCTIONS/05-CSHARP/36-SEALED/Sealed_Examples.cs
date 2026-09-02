```csharp
/*
=========================================
36 - SEALED
Sealed_Examples.cs
=========================================
*/

using System;

namespace SealedExamples
{
    // =========================================
    // Basic Sealed Class Example
    // =========================================

    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    // =========================================
    // Sealed Class Example
    // =========================================

    sealed class SecurityManager
    {
        public void ValidateAccess()
        {
            Console.WriteLine("Access Granted.");
        }
    }

    // =========================================
    // Virtual / Override Example
    // =========================================

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

    /*
    =========================================
    This class would generate a compiler error.

    class Puppy : Dog
    {
        public override void Speak()
        {
            Console.WriteLine("Small Bark");
        }
    }

    Reason:
    Speak() was sealed inside Dog.
    =========================================
    */

    class Puppy : Dog
    {
        public void Play()
        {
            Console.WriteLine("Puppy is playing.");
        }
    }

    // =========================================
    // Banking Example
    // =========================================

    class BankAccount
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating standard interest.");
        }
    }

    class SavingsAccount : BankAccount
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating savings account interest.");
        }
    }

    class PremiumSavingsAccount : SavingsAccount
    {
        public void DisplayAccountType()
        {
            Console.WriteLine("Premium Savings Account.");
        }
    }

    // =========================================
    // Authentication Example
    // =========================================

    class AuthenticationSystem
    {
        public virtual void Login()
        {
            Console.WriteLine("User login process started.");
        }
    }

    class SecureAuthenticationSystem : AuthenticationSystem
    {
        public sealed override void Login()
        {
            Console.WriteLine("Secure login process executed.");
        }
    }

    class EnterpriseAuthenticationSystem : SecureAuthenticationSystem
    {
        public void DisplaySecurityLevel()
        {
            Console.WriteLine("Enterprise Security Enabled.");
        }
    }

    // =========================================
    // Game Example
    // =========================================

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
            Console.WriteLine("Warrior performs a heavy attack.");
        }
    }

    class EliteWarrior : Warrior
    {
        public void DisplayRank()
        {
            Console.WriteLine("Elite Warrior.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("SEALED CLASS EXAMPLE");
            Console.WriteLine("=================================");

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(10, 5));

            SecurityManager securityManager = new SecurityManager();

            securityManager.ValidateAccess();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("SEALED METHOD EXAMPLE");
            Console.WriteLine("=================================");

            Dog dog = new Dog();

            dog.Speak();

            Puppy puppy = new Puppy();

            puppy.Speak();
            puppy.Play();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("BANKING EXAMPLE");
            Console.WriteLine("=================================");

            SavingsAccount savings = new SavingsAccount();

            savings.CalculateInterest();

            PremiumSavingsAccount premium = new PremiumSavingsAccount();

            premium.CalculateInterest();
            premium.DisplayAccountType();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("AUTHENTICATION EXAMPLE");
            Console.WriteLine("=================================");

            SecureAuthenticationSystem secureAuth =
                new SecureAuthenticationSystem();

            secureAuth.Login();

            EnterpriseAuthenticationSystem enterpriseAuth =
                new EnterpriseAuthenticationSystem();

            enterpriseAuth.Login();
            enterpriseAuth.DisplaySecurityLevel();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("GAME EXAMPLE");
            Console.WriteLine("=================================");

            Warrior warrior = new Warrior();

            warrior.Attack();

            EliteWarrior eliteWarrior = new EliteWarrior();

            eliteWarrior.Attack();
            eliteWarrior.DisplayRank();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("SEALED EXAMPLES COMPLETE");
            Console.WriteLine("=================================");
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
```
