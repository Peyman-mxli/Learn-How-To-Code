```csharp
using System;

namespace LearnHowToCode.Interfaces
{
    class InterfacesExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("INTERFACES EXAMPLES");
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
            BASIC INTERFACE IMPLEMENTATION
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - BASIC INTERFACE");

            IAttackable warrior = new Warrior();

            warrior.Attack();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 2
            MULTIPLE CLASSES IMPLEMENTING
            THE SAME INTERFACE
            ============================================================
        */

        static void Example2()
        {
            Console.WriteLine("EXAMPLE 2 - MULTIPLE IMPLEMENTATIONS");

            IAttackable[] characters =
            {
                new Warrior(),
                new Mage(),
                new Archer()
            };

            foreach (IAttackable character in characters)
            {
                character.Attack();
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 3
            INTERFACE PROPERTIES
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - INTERFACE PROPERTIES");

            ICharacter hero = new Hero
            {
                Name = "Peyman",
                Level = 25
            };

            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"Level: {hero.Level}");

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 4
            MULTIPLE INTERFACES
            ============================================================
        */

        static void Example4()
        {
            Console.WriteLine("EXAMPLE 4 - MULTIPLE INTERFACES");

            WarriorChampion champion = new WarriorChampion();

            champion.Attack();
            champion.Move();
            champion.Jump();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 5
            PAYMENT PROCESSOR
            ============================================================
        */

        static void Example5()
        {
            Console.WriteLine("EXAMPLE 5 - PAYMENT PROCESSOR");

            IPaymentProcessor[] processors =
            {
                new CreditCardProcessor(),
                new PayPalProcessor(),
                new CryptoProcessor()
            };

            foreach (IPaymentProcessor processor in processors)
            {
                processor.ProcessPayment();
            }

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            DEVICE SYSTEM
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - DEVICE SYSTEM");

            IStartable[] devices =
            {
                new Computer(),
                new Smartphone(),
                new Tablet()
            };

            foreach (IStartable device in devices)
            {
                device.Start();
            }

            Console.WriteLine();
        }
    }

    /*
        ============================================================
        EXAMPLE 1 & 2
        ATTACKABLE INTERFACE
        ============================================================
    */

    interface IAttackable
    {
        void Attack();
    }

    class Warrior : IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }
    }

    class Mage : IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Mage attacks with a fireball.");
        }
    }

    class Archer : IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Archer attacks with arrows.");
        }
    }

    /*
        ============================================================
        EXAMPLE 3
        INTERFACE PROPERTIES
        ============================================================
    */

    interface ICharacter
    {
        string Name { get; set; }

        int Level { get; set; }
    }

    class Hero : ICharacter
    {
        public string Name { get; set; } = "";

        public int Level { get; set; }
    }

    /*
        ============================================================
        EXAMPLE 4
        MULTIPLE INTERFACES
        ============================================================
    */

    interface IMovable
    {
        void Move();
    }

    interface IJumpable
    {
        void Jump();
    }

    class WarriorChampion : IAttackable, IMovable, IJumpable
    {
        public void Attack()
        {
            Console.WriteLine("Champion attacks.");
        }

        public void Move()
        {
            Console.WriteLine("Champion moves.");
        }

        public void Jump()
        {
            Console.WriteLine("Champion jumps.");
        }
    }

    /*
        ============================================================
        EXAMPLE 5
        PAYMENT PROCESSOR
        ============================================================
    */

    interface IPaymentProcessor
    {
        void ProcessPayment();
    }

    class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }

    class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class CryptoProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing cryptocurrency payment.");
        }
    }

    /*
        ============================================================
        EXAMPLE 6
        DEVICE SYSTEM
        ============================================================
    */

    interface IStartable
    {
        void Start();
    }

    class Computer : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Computer is starting.");
        }
    }

    class Smartphone : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Smartphone is starting.");
        }
    }

    class Tablet : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Tablet is starting.");
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
