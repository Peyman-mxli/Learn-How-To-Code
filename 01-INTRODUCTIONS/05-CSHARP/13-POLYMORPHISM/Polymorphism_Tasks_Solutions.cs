```csharp
using System;

namespace LearnHowToCode.Polymorphism
{
    class PolymorphismTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("POLYMORPHISM TASK SOLUTIONS");
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

            AnimalTask animal = new DogTask();
            animal.MakeSound();

            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - Character and Warrior");

            CharacterTask character = new WarriorTask();
            character.Attack();

            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Vehicle and Car");

            VehicleTask vehicle = new CarTask();
            vehicle.Drive();

            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Shapes");

            ShapeTask[] shapes =
            {
                new CircleTask(),
                new RectangleTask()
            };

            foreach (ShapeTask shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - Payment Methods");

            PaymentMethodTask[] payments =
            {
                new CreditCardTask(),
                new PayPalTask(),
                new BankTransferTask()
            };

            foreach (PaymentMethodTask payment in payments)
            {
                payment.ProcessPayment();
            }

            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - Employees");

            EmployeeTask[] employees =
            {
                new ManagerTask(),
                new DeveloperTask()
            };

            foreach (EmployeeTask employee in employees)
            {
                employee.CalculateSalary();
            }

            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Enemies");

            EnemyTask[] enemies =
            {
                new GoblinTask(),
                new DragonTask(),
                new SkeletonTask()
            };

            foreach (EnemyTask enemy in enemies)
            {
                enemy.Attack();
            }

            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - Notifications");

            NotificationTask[] notifications =
            {
                new EmailNotificationTask(),
                new SmsNotificationTask(),
                new PushNotificationTask()
            };

            foreach (NotificationTask notification in notifications)
            {
                notification.Send();
            }

            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Instruments");

            InstrumentTask[] instruments =
            {
                new GuitarTask(),
                new PianoTask(),
                new DrumTask()
            };

            foreach (InstrumentTask instrument in instruments)
            {
                instrument.Play();
            }

            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Game Skills");

            GameSkillTask[] skills =
            {
                new FireballSkillTask { SkillName = "Fireball" },
                new HealSkillTask { SkillName = "Heal" },
                new ShieldSkillTask { SkillName = "Shield" }
            };

            foreach (GameSkillTask skill in skills)
            {
                skill.UseSkill();
            }

            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Orders");

            OrderTask[] orders =
            {
                new OnlineOrderTask { OrderId = "ONLINE-1001" },
                new StoreOrderTask { OrderId = "STORE-2001" },
                new InternationalOrderTask { OrderId = "INT-3001" }
            };

            foreach (OrderTask order in orders)
            {
                order.CalculateTotal();
            }

            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - Reports");

            ReportTask[] reports =
            {
                new SalesReportTask { Title = "Monthly Sales Report" },
                new InventoryReportTask { Title = "Warehouse Inventory Report" },
                new FinanceReportTask { Title = "Yearly Finance Report" }
            };

            foreach (ReportTask report in reports)
            {
                report.Generate();
            }

            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - User Accounts");

            UserAccountTask[] accounts =
            {
                new AdminAccountTask { Username = "AdminUser" },
                new StudentAccountTask { Username = "StudentUser" },
                new GuestAccountTask { Username = "GuestUser" }
            };

            foreach (UserAccountTask account in accounts)
            {
                account.GetPermissions();
            }

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Delivery Services");

            DeliveryServiceTask[] deliveries =
            {
                new StandardDeliveryTask { PackageId = "PKG-1001" },
                new ExpressDeliveryTask { PackageId = "PKG-2001" },
                new InternationalDeliveryTask { PackageId = "PKG-3001" }
            };

            foreach (DeliveryServiceTask delivery in deliveries)
            {
                delivery.DeliverPackage();
            }

            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Polymorphic Attack System");

            RpgCharacterTask[] characters =
            {
                new RpgWarriorTask { Name = "Nova Warrior", Level = 20 },
                new RpgMageTask { Name = "Nova Mage", Level = 18 },
                new RpgArcherTask { Name = "Nova Archer", Level = 17 },
                new RpgHealerTask { Name = "Nova Healer", Level = 16 }
            };

            foreach (RpgCharacterTask character in characters)
            {
                character.Attack();
            }

            Console.WriteLine();
        }
    }

    class AnimalTask
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class DogTask : AnimalTask
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class CharacterTask
    {
        public virtual void Attack()
        {
            Console.WriteLine("Character attacks.");
        }
    }

    class WarriorTask : CharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }
    }

    class VehicleTask
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving.");
        }
    }

    class CarTask : VehicleTask
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }

    class ShapeTask
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class CircleTask : ShapeTask
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class RectangleTask : ShapeTask
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    class PaymentMethodTask
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment.");
        }
    }

    class CreditCardTask : PaymentMethodTask
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }

    class PayPalTask : PaymentMethodTask
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class BankTransferTask : PaymentMethodTask
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing bank transfer payment.");
        }
    }

    class EmployeeTask
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Calculating employee salary.");
        }
    }

    class ManagerTask : EmployeeTask
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating manager salary with bonus.");
        }
    }

    class DeveloperTask : EmployeeTask
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating developer salary with project bonus.");
        }
    }

    class EnemyTask
    {
        public virtual void Attack()
        {
            Console.WriteLine("Enemy attacks.");
        }
    }

    class GoblinTask : EnemyTask
    {
        public override void Attack()
        {
            Console.WriteLine("Goblin attacks with a dagger.");
        }
    }

    class DragonTask : EnemyTask
    {
        public override void Attack()
        {
            Console.WriteLine("Dragon breathes fire.");
        }
    }

    class SkeletonTask : EnemyTask
    {
        public override void Attack()
        {
            Console.WriteLine("Skeleton attacks with old bones.");
        }
    }

    class NotificationTask
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending notification.");
        }
    }

    class EmailNotificationTask : NotificationTask
    {
        public override void Send()
        {
            Console.WriteLine("Sending email notification.");
        }
    }

    class SmsNotificationTask : NotificationTask
    {
        public override void Send()
        {
            Console.WriteLine("Sending SMS notification.");
        }
    }

    class PushNotificationTask : NotificationTask
    {
        public override void Send()
        {
            Console.WriteLine("Sending push notification.");
        }
    }

    class InstrumentTask
    {
        public virtual void Play()
        {
            Console.WriteLine("Instrument is playing.");
        }
    }

    class GuitarTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Guitar is playing chords.");
        }
    }

    class PianoTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Piano is playing melody.");
        }
    }

    class DrumTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Drum is playing rhythm.");
        }
    }

    class GameSkillTask
    {
        public string SkillName { get; set; } = "";

        public virtual void UseSkill()
        {
            Console.WriteLine($"{SkillName} is used.");
        }
    }

    class FireballSkillTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} launches a fireball.");
        }
    }

    class HealSkillTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} restores health.");
        }
    }

    class ShieldSkillTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} creates a protective shield.");
        }
    }

    class OrderTask
    {
        public string OrderId { get; set; } = "";

        public virtual void CalculateTotal()
        {
            Console.WriteLine($"Calculating total for order {OrderId}.");
        }
    }

    class OnlineOrderTask : OrderTask
    {
        public override void CalculateTotal()
        {
            Console.WriteLine($"Online order {OrderId}: calculating total with shipping.");
        }
    }

    class StoreOrderTask : OrderTask
    {
        public override void CalculateTotal()
        {
            Console.WriteLine($"Store order {OrderId}: calculating total without shipping.");
        }
    }

    class InternationalOrderTask : OrderTask
    {
        public override void CalculateTotal()
        {
            Console.WriteLine($"International order {OrderId}: calculating total with customs fee.");
        }
    }

    class ReportTask
    {
        public string Title { get; set; } = "";

        public virtual void Generate()
        {
            Console.WriteLine($"Generating report: {Title}");
        }
    }

    class SalesReportTask : ReportTask
    {
        public override void Generate()
        {
            Console.WriteLine($"Generating sales report: {Title}");
        }
    }

    class InventoryReportTask : ReportTask
    {
        public override void Generate()
        {
            Console.WriteLine($"Generating inventory report: {Title}");
        }
    }

    class FinanceReportTask : ReportTask
    {
        public override void Generate()
        {
            Console.WriteLine($"Generating finance report: {Title}");
        }
    }

    class UserAccountTask
    {
        public string Username { get; set; } = "";

        public virtual void GetPermissions()
        {
            Console.WriteLine($"{Username} has basic permissions.");
        }
    }

    class AdminAccountTask : UserAccountTask
    {
        public override void GetPermissions()
        {
            Console.WriteLine($"{Username} has full administrator permissions.");
        }
    }

    class StudentAccountTask : UserAccountTask
    {
        public override void GetPermissions()
        {
            Console.WriteLine($"{Username} has student learning permissions.");
        }
    }

    class GuestAccountTask : UserAccountTask
    {
        public override void GetPermissions()
        {
            Console.WriteLine($"{Username} has guest read-only permissions.");
        }
    }

    class DeliveryServiceTask
    {
        public string PackageId { get; set; } = "";

        public virtual void DeliverPackage()
        {
            Console.WriteLine($"Delivering package {PackageId}.");
        }
    }

    class StandardDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will arrive with standard delivery.");
        }
    }

    class ExpressDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will arrive quickly with express delivery.");
        }
    }

    class InternationalDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will arrive internationally with customs processing.");
        }
    }

    class RpgCharacterTask
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} Level {Level} performs a basic attack.");
        }
    }

    class RpgWarriorTask : RpgCharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} Level {Level} attacks with a heavy sword strike.");
        }
    }

    class RpgMageTask : RpgCharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} Level {Level} attacks with arcane magic.");
        }
    }

    class RpgArcherTask : RpgCharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} Level {Level} attacks with a precise arrow shot.");
        }
    }

    class RpgHealerTask : RpgCharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} Level {Level} attacks with holy light.");
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
