```csharp
using System;

namespace LearnHowToCode.Abstraction
{
    class AbstractionExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("ABSTRACTION EXAMPLES");
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
            BASIC ABSTRACT CLASS
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - BASIC ABSTRACT CLASS");

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
            EXAMPLE 3
            ABSTRACT CLASS WITH NORMAL METHODS
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - ABSTRACT CLASS WITH NORMAL METHODS");

            Character mage = new Mage();

            mage.ShowClassType();
            mage.Attack();

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

            PaymentMethod[] payments =
            {
                new CreditCard(),
                new PayPal(),
                new BankTransfer()
            };

            foreach (PaymentMethod payment in payments)
            {
                payment.ProcessPayment();
            }

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

            Employee[] employees =
            {
                new Manager(),
                new Developer()
            };

            foreach (Employee employee in employees)
            {
                employee.CalculateSalary();
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            VEHICLE SYSTEM
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - VEHICLE SYSTEM");

            Vehicle[] vehicles =
            {
                new Car(),
                new Motorcycle()
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.StartEngine();
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

    abstract class Character
    {
        public abstract void Attack();

        public void ShowClassType()
        {
            Console.WriteLine("This object belongs to the Character hierarchy.");
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

    abstract class PaymentMethod
    {
        public abstract void ProcessPayment();
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

    abstract class Employee
    {
        public abstract void CalculateSalary();
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
        VEHICLE SYSTEM
        ============================================================
    */

    abstract class Vehicle
    {
        public abstract void StartEngine();
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
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
