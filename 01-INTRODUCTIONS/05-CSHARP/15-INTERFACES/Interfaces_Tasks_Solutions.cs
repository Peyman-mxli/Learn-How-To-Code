```csharp
using System;

namespace LearnHowToCode.Interfaces
{
    class InterfacesTasksSolutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("INTERFACES TASK SOLUTIONS");
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
            Console.WriteLine("Task 1 - IAttackable");

            IAttackableTask warrior = new WarriorTask();
            warrior.Attack();

            Console.WriteLine();
        }

        static void RunTask2()
        {
            Console.WriteLine("Task 2 - IMovable");

            IMovableTask car = new CarTask();
            car.Move();

            Console.WriteLine();
        }

        static void RunTask3()
        {
            Console.WriteLine("Task 3 - ICharacter");

            ICharacterTask hero = new HeroTask
            {
                Name = "Peyman",
                Level = 25
            };

            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"Level: {hero.Level}");

            Console.WriteLine();
        }

        static void RunTask4()
        {
            Console.WriteLine("Task 4 - IJumpable");

            IJumpableTask player = new PlayerTask();
            player.Jump();

            Console.WriteLine();
        }

        static void RunTask5()
        {
            Console.WriteLine("Task 5 - IPaymentProcessor");

            IPaymentProcessorTask[] processors =
            {
                new CreditCardProcessorTask(),
                new PayPalProcessorTask()
            };

            foreach (IPaymentProcessorTask processor in processors)
            {
                processor.ProcessPayment();
            }

            Console.WriteLine();
        }

        static void RunTask6()
        {
            Console.WriteLine("Task 6 - IStartable");

            IStartableTask[] devices =
            {
                new ComputerTask(),
                new SmartphoneTask()
            };

            foreach (IStartableTask device in devices)
            {
                device.Start();
            }

            Console.WriteLine();
        }

        static void RunTask7()
        {
            Console.WriteLine("Task 7 - Multiple Interfaces");

            WarriorMultipleTask warrior = new WarriorMultipleTask();

            warrior.Attack();
            warrior.Move();

            Console.WriteLine();
        }

        static void RunTask8()
        {
            Console.WriteLine("Task 8 - File Manager");

            FileManagerTask fileManager = new FileManagerTask();

            fileManager.Read();
            fileManager.Write();

            Console.WriteLine();
        }

        static void RunTask9()
        {
            Console.WriteLine("Task 9 - Notifications");

            INotificationTask[] notifications =
            {
                new EmailNotificationTask(),
                new SmsNotificationTask(),
                new PushNotificationTask()
            };

            foreach (INotificationTask notification in notifications)
            {
                notification.Send();
            }

            Console.WriteLine();
        }

        static void RunTask10()
        {
            Console.WriteLine("Task 10 - Databases");

            IDatabaseTask[] databases =
            {
                new SqlDatabaseTask(),
                new MySqlDatabaseTask(),
                new PostgreSqlDatabaseTask()
            };

            foreach (IDatabaseTask database in databases)
            {
                database.Connect();
            }

            Console.WriteLine();
        }

        static void RunTask11()
        {
            Console.WriteLine("Task 11 - Loggers");

            ILoggerTask[] loggers =
            {
                new FileLoggerTask(),
                new DatabaseLoggerTask(),
                new ConsoleLoggerTask()
            };

            foreach (ILoggerTask logger in loggers)
            {
                logger.Log();
            }

            Console.WriteLine();
        }

        static void RunTask12()
        {
            Console.WriteLine("Task 12 - Start and Shutdown");

            ComputerSystemTask computer = new ComputerSystemTask();
            ServerTask server = new ServerTask();

            computer.Start();
            computer.Shutdown();

            server.Start();
            server.Shutdown();

            Console.WriteLine();
        }

        static void RunTask13()
        {
            Console.WriteLine("Task 13 - Shapes");

            IShapeTask[] shapes =
            {
                new CircleTask(),
                new RectangleTask(),
                new TriangleTask()
            };

            foreach (IShapeTask shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine();
        }

        static void RunTask14()
        {
            Console.WriteLine("Task 14 - Employees");

            IEmployeeTask[] employees =
            {
                new ManagerTask(),
                new DeveloperTask(),
                new DesignerTask()
            };

            foreach (IEmployeeTask employee in employees)
            {
                employee.Name = employee.GetType().Name.Replace("Task", "");
                employee.Work();
            }

            Console.WriteLine();
        }

        static void RunFinalChallenge()
        {
            Console.WriteLine("Final Challenge - RPG Interface System");

            IAttackableRpgTask[] attackers =
            {
                new WarriorRpgTask(),
                new MageRpgTask(),
                new ArcherRpgTask()
            };

            IMovableRpgTask[] movers =
            {
                new WarriorRpgTask(),
                new MageRpgTask(),
                new ArcherRpgTask(),
                new NpcRpgTask()
            };

            IInteractableRpgTask[] interactables =
            {
                new NpcRpgTask()
            };

            Console.WriteLine("Attack Actions:");

            foreach (IAttackableRpgTask attacker in attackers)
            {
                attacker.Attack();
            }

            Console.WriteLine();

            Console.WriteLine("Move Actions:");

            foreach (IMovableRpgTask mover in movers)
            {
                mover.Move();
            }

            Console.WriteLine();

            Console.WriteLine("Interact Actions:");

            foreach (IInteractableRpgTask interactable in interactables)
            {
                interactable.Interact();
            }

            Console.WriteLine();
        }
    }

    interface IAttackableTask
    {
        void Attack();
    }

    class WarriorTask : IAttackableTask
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }
    }

    interface IMovableTask
    {
        void Move();
    }

    class CarTask : IMovableTask
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }

    interface ICharacterTask
    {
        string Name { get; set; }

        int Level { get; set; }
    }

    class HeroTask : ICharacterTask
    {
        public string Name { get; set; } = "";

        public int Level { get; set; }
    }

    interface IJumpableTask
    {
        void Jump();
    }

    class PlayerTask : IJumpableTask
    {
        public void Jump()
        {
            Console.WriteLine("Player jumps.");
        }
    }

    interface IPaymentProcessorTask
    {
        void ProcessPayment();
    }

    class CreditCardProcessorTask : IPaymentProcessorTask
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }

    class PayPalProcessorTask : IPaymentProcessorTask
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class IStartableTask
    {
        public virtual void Start()
        {
            Console.WriteLine("Starting device.");
        }
    }

    class ComputerTask : IStartableTask
    {
        public override void Start()
        {
            Console.WriteLine("Computer is starting.");
        }
    }

    class SmartphoneTask : IStartableTask
    {
        public override void Start()
        {
            Console.WriteLine("Smartphone is starting.");
        }
    }

    class WarriorMultipleTask : IAttackableTask, IMovableTask
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks.");
        }

        public void Move()
        {
            Console.WriteLine("Warrior moves.");
        }
    }

    interface IReadableTask
    {
        void Read();
    }

    interface IWritableTask
    {
        void Write();
    }

    class FileManagerTask : IReadableTask, IWritableTask
    {
        public void Read()
        {
            Console.WriteLine("Reading file.");
        }

        public void Write()
        {
            Console.WriteLine("Writing file.");
        }
    }

    interface INotificationTask
    {
        void Send();
    }

    class EmailNotificationTask : INotificationTask
    {
        public void Send()
        {
            Console.WriteLine("Sending email notification.");
        }
    }

    class SmsNotificationTask : INotificationTask
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS notification.");
        }
    }

    class PushNotificationTask : INotificationTask
    {
        public void Send()
        {
            Console.WriteLine("Sending push notification.");
        }
    }

    interface IDatabaseTask
    {
        void Connect();
    }

    class SqlDatabaseTask : IDatabaseTask
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL database.");
        }
    }

    class MySqlDatabaseTask : IDatabaseTask
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to MySQL database.");
        }
    }

    class PostgreSqlDatabaseTask : IDatabaseTask
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to PostgreSQL database.");
        }
    }

    interface ILoggerTask
    {
        void Log();
    }

    class FileLoggerTask : ILoggerTask
    {
        public void Log()
        {
            Console.WriteLine("Writing log to file.");
        }
    }

    class DatabaseLoggerTask : ILoggerTask
    {
        public void Log()
        {
            Console.WriteLine("Writing log to database.");
        }
    }

    class ConsoleLoggerTask : ILoggerTask
    {
        public void Log()
        {
            Console.WriteLine("Writing log to console.");
        }
    }

    interface IShutdownableTask
    {
        void Shutdown();
    }

    class ComputerSystemTask : IStartableTask, IShutdownableTask
    {
        public override void Start()
        {
            Console.WriteLine("Computer system is starting.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Computer system is shutting down.");
        }
    }

    class ServerTask : IStartableTask, IShutdownableTask
    {
        public override void Start()
        {
            Console.WriteLine("Server is starting.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Server is shutting down.");
        }
    }

    interface IShapeTask
    {
        void Draw();
    }

    class CircleTask : IShapeTask
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class RectangleTask : IShapeTask
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    class TriangleTask : IShapeTask
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }
    }

    interface IEmployeeTask
    {
        string Name { get; set; }

        void Work();
    }

    class ManagerTask : IEmployeeTask
    {
        public string Name { get; set; } = "";

        public void Work()
        {
            Console.WriteLine($"{Name} manages the team.");
        }
    }

    class DeveloperTask : IEmployeeTask
    {
        public string Name { get; set; } = "";

        public void Work()
        {
            Console.WriteLine($"{Name} writes code.");
        }
    }

    class DesignerTask : IEmployeeTask
    {
        public string Name { get; set; } = "";

        public void Work()
        {
            Console.WriteLine($"{Name} creates designs.");
        }
    }

    interface IAttackableRpgTask
    {
        void Attack();
    }

    interface IMovableRpgTask
    {
        void Move();
    }

    interface IInteractableRpgTask
    {
        void Interact();
    }

    class WarriorRpgTask : IAttackableRpgTask, IMovableRpgTask
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword.");
        }

        public void Move()
        {
            Console.WriteLine("Warrior moves forward.");
        }
    }

    class MageRpgTask : IAttackableRpgTask, IMovableRpgTask
    {
        public void Attack()
        {
            Console.WriteLine("Mage attacks with magic.");
        }

        public void Move()
        {
            Console.WriteLine("Mage moves carefully.");
        }
    }

    class ArcherRpgTask : IAttackableRpgTask, IMovableRpgTask
    {
        public void Attack()
        {
            Console.WriteLine("Archer attacks with arrows.");
        }

        public void Move()
        {
            Console.WriteLine("Archer moves silently.");
        }
    }

    class NpcRpgTask : IMovableRpgTask, IInteractableRpgTask
    {
        public void Move()
        {
            Console.WriteLine("NPC walks around the town.");
        }

        public void Interact()
        {
            Console.WriteLine("NPC talks with the player.");
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
