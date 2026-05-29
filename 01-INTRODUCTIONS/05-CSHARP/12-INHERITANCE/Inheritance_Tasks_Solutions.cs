```csharp
using System;

namespace LearnHowToCode.Inheritance
{
    class InheritanceTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("INHERITANCE TASK SOLUTIONS");
            Console.WriteLine("=====================================\n");

            RunTask1();
            RunTask2();
            RunTask3();
            RunTask4();
            RunTask5();
            RunTask6();
            RunTask7();
            RunTask8();
            RunTask9();
            RunTask10();
            RunTask11();
            RunTask12();
            RunTask13();
            RunTask14();
            RunFinalChallenge();
        }

        static void RunTask1()
        {
            Console.WriteLine("Task 1 - Animal and Dog");

            DogTask dog = new DogTask();

            dog.Eat();
            dog.Bark();

            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - Vehicle and Car");

            CarTask car = new CarTask();

            car.Brand = "Toyota";
            car.Model = "Corolla";

            Console.WriteLine($"Brand: {car.Brand}");
            Console.WriteLine($"Model: {car.Model}");

            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Person and Student");

            StudentTask student = new StudentTask();

            student.Name = "Peyman";
            student.Grade = 95;

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Grade: {student.Grade}");

            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Character and Warrior");

            WarriorTask warrior = new WarriorTask();

            warrior.Name = "Nova Warrior";
            warrior.Level = 10;

            Console.WriteLine($"Name: {warrior.Name}");
            Console.WriteLine($"Level: {warrior.Level}");

            warrior.Attack();
            warrior.ShieldBash();

            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - Employee and Manager");

            ManagerTask manager = new ManagerTask();

            manager.Name = "Peyman";
            manager.Salary = 8500;

            Console.WriteLine($"Name: {manager.Name}");
            Console.WriteLine($"Salary: {manager.Salary}");

            manager.ApproveBudget();

            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - Shape, Circle, and Rectangle");

            CircleTask circle = new CircleTask();
            RectangleTask rectangle = new RectangleTask();

            circle.Draw();
            circle.CalculateCircleArea();

            rectangle.Draw();
            rectangle.CalculateRectangleArea();

            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Hero and Mage");

            MageTask mage = new MageTask();

            mage.ShowHealth();

            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - Product and Electronic Product");

            ElectronicProductTask electronicProduct = new ElectronicProductTask("Laptop");

            electronicProduct.DisplayProductInfo();

            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Account and Premium Account");

            PremiumAccountTask premiumAccount = new PremiumAccountTask();

            premiumAccount.Username = "PeymanMXLI";
            premiumAccount.MembershipLevel = "Gold";

            Console.WriteLine($"Username: {premiumAccount.Username}");
            Console.WriteLine($"Membership Level: {premiumAccount.MembershipLevel}");

            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Monster, Goblin, and Dragon");

            GoblinTask goblin = new GoblinTask();
            DragonTask dragon = new DragonTask();

            goblin.Name = "Forest Goblin";
            goblin.Health = 50;

            dragon.Name = "Fire Dragon";
            dragon.Health = 500;

            Console.WriteLine($"Goblin Name: {goblin.Name}");
            Console.WriteLine($"Goblin Health: {goblin.Health}");
            goblin.Attack();
            goblin.Stab();

            Console.WriteLine();

            Console.WriteLine($"Dragon Name: {dragon.Name}");
            Console.WriteLine($"Dragon Health: {dragon.Health}");
            dragon.Attack();
            dragon.BreatheFire();

            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Appliance, Washing Machine, and Refrigerator");

            WashingMachineTask washingMachine = new WashingMachineTask();
            RefrigeratorTask refrigerator = new RefrigeratorTask();

            washingMachine.Brand = "Samsung";
            refrigerator.Brand = "LG";

            Console.WriteLine($"Washing Machine Brand: {washingMachine.Brand}");
            washingMachine.TurnOn();
            washingMachine.StartWashCycle();

            Console.WriteLine();

            Console.WriteLine($"Refrigerator Brand: {refrigerator.Brand}");
            refrigerator.TurnOn();
            refrigerator.CoolFood();

            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - School Member, Teacher, and Student");

            TeacherTask teacher = new TeacherTask();
            SchoolStudentTask student = new SchoolStudentTask();

            teacher.Name = "Mr. Smith";
            teacher.Subject = "Programming";

            student.Name = "Peyman";
            student.GradeLevel = "University";

            Console.WriteLine($"Teacher Name: {teacher.Name}");
            Console.WriteLine($"Subject: {teacher.Subject}");
            teacher.Teach();

            Console.WriteLine();

            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Grade Level: {student.GradeLevel}");
            student.Study();

            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Game Character Classes");

            WarriorGameTask warrior = new WarriorGameTask();
            MageGameTask mage = new MageGameTask();
            ArcherGameTask archer = new ArcherGameTask();

            warrior.Name = "Steel Guardian";
            warrior.Level = 15;
            warrior.Health = 200;
            warrior.Strength = 80;

            mage.Name = "Arcane Scholar";
            mage.Level = 14;
            mage.Health = 120;
            mage.MagicPower = 95;

            archer.Name = "Silent Arrow";
            archer.Level = 13;
            archer.Health = 140;
            archer.Range = 60;

            warrior.Attack();
            warrior.PowerStrike();

            mage.Attack();
            mage.Meteor();

            archer.Attack();
            archer.PrecisionShot();

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Bank Account Types");

            SavingsAccountTask savings = new SavingsAccountTask();
            CheckingAccountTask checking = new CheckingAccountTask();

            savings.AccountNumber = "SAV-1001";
            savings.Deposit(1000);
            savings.AddInterest();

            checking.AccountNumber = "CHK-2001";
            checking.Deposit(500);
            checking.PayMonthlyFee();

            Console.WriteLine($"Savings Account: {savings.AccountNumber}");
            Console.WriteLine($"Savings Balance: {savings.Balance}");

            Console.WriteLine();

            Console.WriteLine($"Checking Account: {checking.AccountNumber}");
            Console.WriteLine($"Checking Balance: {checking.Balance}");

            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Hierarchy");

            FinalWarrior warrior = new FinalWarrior("Nova Warrior", 20, 300, 50, 90);
            FinalMage mage = new FinalMage("Nova Mage", 18, 180, 250, 100);
            FinalArcher archer = new FinalArcher("Nova Archer", 17, 220, 100, 85);

            warrior.ShowStats();
            warrior.Attack();
            warrior.ShieldBlock();

            Console.WriteLine();

            mage.ShowStats();
            mage.Attack();
            mage.CastSpell();

            Console.WriteLine();

            archer.ShowStats();
            archer.Attack();
            archer.MultiShot();

            Console.WriteLine();
        }
    }

    class AnimalTask
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class DogTask : AnimalTask
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class VehicleTask
    {
        public string Brand { get; set; } = "";
    }

    class CarTask : VehicleTask
    {
        public string Model { get; set; } = "";
    }

    class PersonTask
    {
        public string Name { get; set; } = "";
    }

    class StudentTask : PersonTask
    {
        public int Grade { get; set; }
    }

    class CharacterTask
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }

        public void Attack()
        {
            Console.WriteLine("Character attacks.");
        }
    }

    class WarriorTask : CharacterTask
    {
        public void ShieldBash()
        {
            Console.WriteLine("Warrior uses Shield Bash.");
        }
    }

    class EmployeeTask
    {
        public string Name { get; set; } = "";
        public double Salary { get; set; }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class ManagerTask : EmployeeTask
    {
        public void ApproveBudget()
        {
            Console.WriteLine("Manager approved the budget.");
        }
    }

    class ShapeTask
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class CircleTask : ShapeTask
    {
        public void CalculateCircleArea()
        {
            Console.WriteLine("Calculating circle area.");
        }
    }

    class RectangleTask : ShapeTask
    {
        public void CalculateRectangleArea()
        {
            Console.WriteLine("Calculating rectangle area.");
        }
    }

    class HeroTask
    {
        protected int health = 100;
    }

    class MageTask : HeroTask
    {
        public void ShowHealth()
        {
            Console.WriteLine($"Mage Health: {health}");
        }
    }

    class ProductTask
    {
        protected string productName;

        public ProductTask(string productName)
        {
            this.productName = productName;
        }
    }

    class ElectronicProductTask : ProductTask
    {
        public ElectronicProductTask(string productName)
            : base(productName)
        {

        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Electronic Product: {productName}");
        }
    }

    class AccountTask
    {
        public string Username { get; set; } = "";
    }

    class PremiumAccountTask : AccountTask
    {
        public string MembershipLevel { get; set; } = "";
    }

    class MonsterTask
    {
        public string Name { get; set; } = "";
        public int Health { get; set; }

        public void Attack()
        {
            Console.WriteLine("Monster attacks.");
        }
    }

    class GoblinTask : MonsterTask
    {
        public void Stab()
        {
            Console.WriteLine("Goblin uses Stab.");
        }
    }

    class DragonTask : MonsterTask
    {
        public void BreatheFire()
        {
            Console.WriteLine("Dragon breathes fire.");
        }
    }

    class ApplianceTask
    {
        public string Brand { get; set; } = "";

        public void TurnOn()
        {
            Console.WriteLine("Appliance is turned on.");
        }
    }

    class WashingMachineTask : ApplianceTask
    {
        public void StartWashCycle()
        {
            Console.WriteLine("Washing machine starts washing clothes.");
        }
    }

    class RefrigeratorTask : ApplianceTask
    {
        public void CoolFood()
        {
            Console.WriteLine("Refrigerator cools the food.");
        }
    }

    class SchoolMemberTask
    {
        public string Name { get; set; } = "";
    }

    class TeacherTask : SchoolMemberTask
    {
        public string Subject { get; set; } = "";

        public void Teach()
        {
            Console.WriteLine("Teacher is teaching.");
        }
    }

    class SchoolStudentTask : SchoolMemberTask
    {
        public string GradeLevel { get; set; } = "";

        public void Study()
        {
            Console.WriteLine("Student is studying.");
        }
    }

    class GameCharacterTask
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Health { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks.");
        }
    }

    class WarriorGameTask : GameCharacterTask
    {
        public int Strength { get; set; }

        public void PowerStrike()
        {
            Console.WriteLine($"{Name} uses Power Strike with {Strength} strength.");
        }
    }

    class MageGameTask : GameCharacterTask
    {
        public int MagicPower { get; set; }

        public void Meteor()
        {
            Console.WriteLine($"{Name} casts Meteor with {MagicPower} magic power.");
        }
    }

    class ArcherGameTask : GameCharacterTask
    {
        public int Range { get; set; }

        public void PrecisionShot()
        {
            Console.WriteLine($"{Name} uses Precision Shot from {Range} meters.");
        }
    }

    class BankAccountTask
    {
        public string AccountNumber { get; set; } = "";
        public decimal Balance { get; protected set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }
    }

    class SavingsAccountTask : BankAccountTask
    {
        public void AddInterest()
        {
            Balance += Balance * 0.05m;
        }
    }

    class CheckingAccountTask : BankAccountTask
    {
        public void PayMonthlyFee()
        {
            decimal fee = 25;

            if (Balance >= fee)
            {
                Balance -= fee;
            }
        }
    }

    class FinalCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public FinalCharacter(string name, int level, int health, int mana)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks the enemy.");
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Mana: {Mana}");
        }
    }

    class FinalWarrior : FinalCharacter
    {
        public int Strength { get; set; }

        public FinalWarrior(string name, int level, int health, int mana, int strength)
            : base(name, level, health, mana)
        {
            Strength = strength;
        }

        public void ShieldBlock()
        {
            Console.WriteLine($"{Name} uses Shield Block with {Strength} strength.");
        }
    }

    class FinalMage : FinalCharacter
    {
        public int Intelligence { get; set; }

        public FinalMage(string name, int level, int health, int mana, int intelligence)
            : base(name, level, health, mana)
        {
            Intelligence = intelligence;
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a powerful spell with {Intelligence} intelligence.");
        }
    }

    class FinalArcher : FinalCharacter
    {
        public int Agility { get; set; }

        public FinalArcher(string name, int level, int health, int mana, int agility)
            : base(name, level, health, mana)
        {
            Agility = agility;
        }

        public void MultiShot()
        {
            Console.WriteLine($"{Name} uses Multi Shot with {Agility} agility.");
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
