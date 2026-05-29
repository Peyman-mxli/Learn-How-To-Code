```csharp
using System;

namespace LearnHowToCode.Abstraction
{
    class AbstractionTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("ABSTRACTION TASK SOLUTIONS");
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

            AnimalTask dog = new DogTask();
            dog.MakeSound();

            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - Character and Warrior");

            CharacterTask warrior = new WarriorTask();
            warrior.Attack();

            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - Vehicle and Car");

            VehicleTask car = new CarTask();
            car.Drive();

            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - Shape Classes");

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
            Console.WriteLine("Task 7 - Game Skills");

            GameSkillTask[] skills =
            {
                new FireballTask { SkillName = "Fireball" },
                new HealTask { SkillName = "Heal" },
                new ShieldTask { SkillName = "Shield" }
            };

            foreach (GameSkillTask skill in skills)
            {
                skill.UseSkill();
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
            Console.WriteLine("Task 10 - Reports");

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

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Delivery Services");

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

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - User Accounts");

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

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Database Connections");

            DatabaseConnectionTask[] databases =
            {
                new SqlDatabaseTask { ConnectionString = "Server=localhost;Database=School;" },
                new MySqlDatabaseTask { ConnectionString = "Server=localhost;Database=Store;" },
                new PostgreSqlDatabaseTask { ConnectionString = "Server=localhost;Database=Reports;" }
            };

            foreach (DatabaseConnectionTask database in databases)
            {
                database.Connect();
            }

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Devices");

            DeviceTask[] devices =
            {
                new ComputerTask { DeviceName = "Desktop Computer" },
                new SmartphoneTask { DeviceName = "Android Smartphone" },
                new TabletTask { DeviceName = "Drawing Tablet" }
            };

            foreach (DeviceTask device in devices)
            {
                device.Start();
            }

            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Ability System");

            AbilityTask[] abilities =
            {
                new FireballAbilityTask { AbilityName = "Fireball", Cooldown = 3.5 },
                new HealAbilityTask { AbilityName = "Heal", Cooldown = 5.0 },
                new ShieldAbilityTask { AbilityName = "Shield", Cooldown = 8.0 },
                new TeleportAbilityTask { AbilityName = "Teleport", Cooldown = 12.0 }
            };

            foreach (AbilityTask ability in abilities)
            {
                ability.Activate();
            }

            Console.WriteLine();
        }
    }

    abstract class AnimalTask
    {
        public abstract void MakeSound();
    }

    class DogTask : AnimalTask
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    abstract class CharacterTask
    {
        public abstract void Attack();
    }

    class WarriorTask : CharacterTask
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }
    }

    abstract class VehicleTask
    {
        public abstract void Drive();
    }

    class CarTask : VehicleTask
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    abstract class ShapeTask
    {
        public abstract void Draw();
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

    abstract class PaymentMethodTask
    {
        public abstract void ProcessPayment();
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

    abstract class EmployeeTask
    {
        public abstract void CalculateSalary();
    }

    class ManagerTask : EmployeeTask
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating manager salary.");
        }
    }

    class DeveloperTask : EmployeeTask
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculating developer salary.");
        }
    }

    abstract class GameSkillTask
    {
        public string SkillName { get; set; } = "";

        public abstract void UseSkill();
    }

    class FireballTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} launches a fireball at the enemy.");
        }
    }

    class HealTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} restores health.");
        }
    }

    class ShieldTask : GameSkillTask
    {
        public override void UseSkill()
        {
            Console.WriteLine($"{SkillName} creates a protective shield.");
        }
    }

    abstract class NotificationTask
    {
        public abstract void Send();
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

    abstract class InstrumentTask
    {
        public abstract void Play();
    }

    class GuitarTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Guitar plays chords.");
        }
    }

    class PianoTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Piano plays melody.");
        }
    }

    class DrumTask : InstrumentTask
    {
        public override void Play()
        {
            Console.WriteLine("Drum plays rhythm.");
        }
    }

    abstract class ReportTask
    {
        public string Title { get; set; } = "";

        public abstract void Generate();
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

    abstract class DeliveryServiceTask
    {
        public string PackageId { get; set; } = "";

        public abstract void DeliverPackage();
    }

    class StandardDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will be delivered using standard delivery.");
        }
    }

    class ExpressDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will be delivered quickly using express delivery.");
        }
    }

    class InternationalDeliveryTask : DeliveryServiceTask
    {
        public override void DeliverPackage()
        {
            Console.WriteLine($"Package {PackageId} will be delivered internationally.");
        }
    }

    abstract class UserAccountTask
    {
        public string Username { get; set; } = "";

        public abstract void GetPermissions();
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

    abstract class DatabaseConnectionTask
    {
        public string ConnectionString { get; set; } = "";

        public abstract void Connect();
    }

    class SqlDatabaseTask : DatabaseConnectionTask
    {
        public override void Connect()
        {
            Console.WriteLine($"Connecting to SQL Database with: {ConnectionString}");
        }
    }

    class MySqlDatabaseTask : DatabaseConnectionTask
    {
        public override void Connect()
        {
            Console.WriteLine($"Connecting to MySQL Database with: {ConnectionString}");
        }
    }

    class PostgreSqlDatabaseTask : DatabaseConnectionTask
    {
        public override void Connect()
        {
            Console.WriteLine($"Connecting to PostgreSQL Database with: {ConnectionString}");
        }
    }

    abstract class DeviceTask
    {
        public string DeviceName { get; set; } = "";

        public abstract void Start();
    }

    class ComputerTask : DeviceTask
    {
        public override void Start()
        {
            Console.WriteLine($"{DeviceName} is starting Windows.");
        }
    }

    class SmartphoneTask : DeviceTask
    {
        public override void Start()
        {
            Console.WriteLine($"{DeviceName} is starting mobile system.");
        }
    }

    class TabletTask : DeviceTask
    {
        public override void Start()
        {
            Console.WriteLine($"{DeviceName} is starting tablet mode.");
        }
    }

    abstract class AbilityTask
    {
        public string AbilityName { get; set; } = "";
        public double Cooldown { get; set; }

        public abstract void Activate();

        public void ShowAbilityInfo()
        {
            Console.WriteLine($"Ability: {AbilityName}");
            Console.WriteLine($"Cooldown: {Cooldown} seconds");
        }
    }

    class FireballAbilityTask : AbilityTask
    {
        public override void Activate()
        {
            ShowAbilityInfo();
            Console.WriteLine("Effect: Launches a powerful fireball.");
            Console.WriteLine();
        }
    }

    class HealAbilityTask : AbilityTask
    {
        public override void Activate()
        {
            ShowAbilityInfo();
            Console.WriteLine("Effect: Restores health to the target.");
            Console.WriteLine();
        }
    }

    class ShieldAbilityTask : AbilityTask
    {
        public override void Activate()
        {
            ShowAbilityInfo();
            Console.WriteLine("Effect: Creates a defensive shield.");
            Console.WriteLine();
        }
    }

    class TeleportAbilityTask : AbilityTask
    {
        public override void Activate()
        {
            ShowAbilityInfo();
            Console.WriteLine("Effect: Moves instantly to another location.");
            Console.WriteLine();
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
