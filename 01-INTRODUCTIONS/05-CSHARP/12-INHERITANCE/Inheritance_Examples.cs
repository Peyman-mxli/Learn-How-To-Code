```csharp
using System;

namespace LearnHowToCode.Inheritance
{
    class InheritanceExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("INHERITANCE EXAMPLES");
            Console.WriteLine("=================================\n");

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
            BASIC INHERITANCE
            ============================================================
        */

        static void Example1()
        {
            Console.WriteLine("EXAMPLE 1 - BASIC INHERITANCE");

            Dog dog = new Dog();

            dog.Eat();
            dog.Bark();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 2
            INHERITED PROPERTIES
            ============================================================
        */

        static void Example2()
        {
            Console.WriteLine("EXAMPLE 2 - INHERITED PROPERTIES");

            Warrior warrior = new Warrior();

            warrior.Name = "Nova";
            warrior.Level = 10;

            Console.WriteLine($"Name: {warrior.Name}");
            Console.WriteLine($"Level: {warrior.Level}");

            warrior.Attack();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 3
            MULTIPLE CHILD CLASSES
            ============================================================
        */

        static void Example3()
        {
            Console.WriteLine("EXAMPLE 3 - MULTIPLE CHILD CLASSES");

            Mage mage = new Mage();
            Archer archer = new Archer();

            mage.CastSpell();
            archer.ShootArrow();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 4
            CONSTRUCTOR INHERITANCE
            ============================================================
        */

        static void Example4()
        {
            Console.WriteLine("EXAMPLE 4 - CONSTRUCTOR INHERITANCE");

            Hero hero = new Hero("Peyman");

            hero.ShowName();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 5
            USING THE BASE KEYWORD
            ============================================================
        */

        static void Example5()
        {
            Console.WriteLine("EXAMPLE 5 - BASE KEYWORD");

            Knight knight = new Knight("Guardian");

            knight.ShowName();
            knight.Defend();

            Console.WriteLine();
        }

        /*
            ============================================================
            EXAMPLE 6
            PROTECTED MEMBERS
            ============================================================
        */

        static void Example6()
        {
            Console.WriteLine("EXAMPLE 6 - PROTECTED MEMBERS");

            Monster monster = new Monster();

            monster.ShowHealth();

            Console.WriteLine();
        }
    }

    /*
        ============================================================
        EXAMPLE 1 CLASSES
        ============================================================
    */

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    /*
        ============================================================
        EXAMPLE 2 CLASSES
        ============================================================
    */

    class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public void Attack()
        {
            Console.WriteLine("Character attacks.");
        }
    }

    class Warrior : Character
    {

    }

    /*
        ============================================================
        EXAMPLE 3 CLASSES
        ============================================================
    */

    class Mage : Character
    {
        public void CastSpell()
        {
            Console.WriteLine("Mage casts Fireball.");
        }
    }

    class Archer : Character
    {
        public void ShootArrow()
        {
            Console.WriteLine("Archer shoots an arrow.");
        }
    }

    /*
        ============================================================
        EXAMPLE 4 CLASSES
        ============================================================
    */

    class Person
    {
        protected string name;

        public Person(string name)
        {
            this.name = name;
        }
    }

    class Hero : Person
    {
        public Hero(string name) : base(name)
        {

        }

        public void ShowName()
        {
            Console.WriteLine($"Hero Name: {name}");
        }
    }

    /*
        ============================================================
        EXAMPLE 5 CLASSES
        ============================================================
    */

    class Guardian
    {
        protected string guardianName;

        public Guardian(string guardianName)
        {
            this.guardianName = guardianName;
        }

        public void ShowName()
        {
            Console.WriteLine($"Guardian Name: {guardianName}");
        }
    }

    class Knight : Guardian
    {
        public Knight(string guardianName)
            : base(guardianName)
        {

        }

        public void Defend()
        {
            Console.WriteLine("Knight uses Shield Defense.");
        }
    }

    /*
        ============================================================
        EXAMPLE 6 CLASSES
        ============================================================
    */

    class Creature
    {
        protected int health = 100;
    }

    class Monster : Creature
    {
        public void ShowHealth()
        {
            Console.WriteLine($"Monster Health: {health}");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx //  mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```




