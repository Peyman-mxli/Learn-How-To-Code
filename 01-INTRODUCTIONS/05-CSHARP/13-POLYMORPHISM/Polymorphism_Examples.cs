```csharp
using System;

namespace LearnHowToCode.Polymorphism
{
    class PolymorphismExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("POLYMORPHISM EXAMPLES");
            Console.WriteLine("=====================================\n");

            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
        }

        /*
            ============================================================
            EXAMPLE 1
            BASIC METHOD OVERRIDING
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - BASIC METHOD OVERRIDING");

            Character warrior = new Warrior();

            warrior.Attack();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 2
            MULTIPLE DERIVED CLASSES
            ============================================================
        */

        static void Example2()
        {
            Console.WriteLine("EXAMPLE 2 - MULTIPLE DERIVED CLASSES");

            Character mage = new Mage();
            Character archer = new Archer();

            mage.Attack();
            archer.Attack();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 3
            ARRAY POLYMORPHISM
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - ARRAY POLYMORPHISM");

            Character[] characters =
            {
                new Warrior(),
                new Mage(),
                new Archer()
            };

            foreach (Character character in characters)
            {
                character.Attack();
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 4
            PAYMENT SYSTEM
            ============================================================
        */

        static void Example4()
        {
            Console.WriteLine("EXAMPLE 4 - PAYMENT SYSTEM");

            PaymentMethod payment1 = new CreditCard();
            PaymentMethod payment2 = new PayPal();
            PaymentMethod payment3 = new BankTransfer();

            payment1.ProcessPayment();
            payment2.ProcessPayment();
            payment3.ProcessPayment();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 5
            EMPLOYEE SYSTEM
            ============================================================
        */

        static void Example5()
        {
            Console.WriteLine("EXAMPLE 5 - EMPLOYEE SYSTEM");

            Employee manager = new Manager();
            Employee developer = new Developer();

            manager.CalculateSalary();
            developer.CalculateSalary();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            ANIMAL SYSTEM
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - ANIMAL SYSTEM");

            Animal[] animals =
            {
                new Dog(),
                new Cat(),
                new Bird()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine();
        }
    }

    /*
        ============================================================
        EXAMPLE 1, 2, 3
        CHARACTER SYSTEM
        ============================================================
    */

    class Character
    {
        public virtual void Attack()
        {
            Console.WriteLine("Character attacks.");
        }
    }

    class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }
    }

    class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Mage attacks with magic.");
        }
    }

    class Archer : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Archer attacks with arrows.");
        }
    }

    /*
        ============================================================
        EXAMPLE 4
        PAYMENT SYSTEM
        ============================================================
    */

    class PaymentMethod
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment.");
        }
    }

    class CreditCard : PaymentMethod
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Credit Card payment.");
        }
    }

    class PayPal : PaymentMethod
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class BankTransfer : PaymentMethod
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Bank Transfer payment.");
        }
    }

    /*
        ============================================================
        EXAMPLE 5
        EMPLOYEE SYSTEM
        ============================================================
    */

    class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Calculating employee salary.");
        }
    }

    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating manager salary.");
        }
    }

    class Developer : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating developer salary.");
        }
    }

    /*
        ============================================================
        EXAMPLE 6
        ANIMAL SYSTEM
        ============================================================
    */

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bird says: Tweet!");
        }
    }
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
