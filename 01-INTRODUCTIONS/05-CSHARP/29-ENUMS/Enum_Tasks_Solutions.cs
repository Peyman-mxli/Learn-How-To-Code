using System;

namespace EnumTasksSolutions
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    enum Priority
    {
        Low = 1,
        Medium = 5,
        High = 10
    }

    enum UserRole
    {
        Guest,
        Member,
        Moderator,
        Administrator
    }

    enum CharacterState
    {
        Idle,
        Walking,
        Running,
        Attacking,
        Dead
    }

    enum OrderStatus
    {
        Created,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    enum Difficulty
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    enum Status
    {
        Pending,
        Active,
        Suspended,
        Deleted
    }

    enum Planet
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver
    }

    enum EmployeeRole
    {
        Intern,
        Employee,
        Manager,
        Director,
        CEO
    }

    enum PaymentStatus
    {
        Pending,
        Paid,
        Failed,
        Refunded
    }

    enum TicketStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("ENUM TASK SOLUTIONS");
            Console.WriteLine("=================================\n");

            /*
            =================================
            Task 1
            =================================
            */

            Days day = Days.Friday;
            Console.WriteLine($"Task 1: {day}");

            /*
            =================================
            Task 2
            =================================
            */

            Seasons season = Seasons.Summer;
            Console.WriteLine($"Task 2: {season}");

            /*
            =================================
            Task 3
            =================================
            */

            TrafficLight light = TrafficLight.Green;
            Console.WriteLine($"Task 3: {light}");

            /*
            =================================
            Task 4
            =================================
            */

            Priority priority = Priority.High;

            Console.WriteLine($"Task 4 Name: {priority}");
            Console.WriteLine($"Task 4 Value: {(int)priority}");

            /*
            =================================
            Task 5
            =================================
            */

            UserRole role = UserRole.Administrator;

            if (role == UserRole.Administrator)
            {
                Console.WriteLine("Task 5: Full Access Granted");
            }

            /*
            =================================
            Task 6
            =================================
            */

            CharacterState playerState = CharacterState.Running;

            Console.WriteLine($"Task 6: {playerState}");

            /*
            =================================
            Task 7
            =================================
            */

            OrderStatus order = OrderStatus.Shipped;

            switch (order)
            {
                case OrderStatus.Created:
                    Console.WriteLine("Task 7: Order Created");
                    break;

                case OrderStatus.Processing:
                    Console.WriteLine("Task 7: Order Processing");
                    break;

                case OrderStatus.Shipped:
                    Console.WriteLine("Task 7: Order Shipped");
                    break;

                case OrderStatus.Delivered:
                    Console.WriteLine("Task 7: Order Delivered");
                    break;

                case OrderStatus.Cancelled:
                    Console.WriteLine("Task 7: Order Cancelled");
                    break;
            }

            /*
            =================================
            Task 8
            =================================
            */

            Difficulty difficulty = Difficulty.Hard;

            Console.WriteLine($"Task 8 Enum: {difficulty}");
            Console.WriteLine($"Task 8 Value: {(int)difficulty}");

            /*
            =================================
            Task 9
            =================================
            */

            int value = 2;

            Status status = (Status)value;

            Console.WriteLine($"Task 9: {status}");

            /*
            =================================
            Task 10
            =================================
            */

            Console.WriteLine("\nTask 10:");

            string[] planets = Enum.GetNames(typeof(Planet));

            foreach (string planet in planets)
            {
                Console.WriteLine(planet);
            }

            /*
            =================================
            Task 11
            =================================
            */

            Console.WriteLine("\nTask 11:");

            foreach (GameState gameState in Enum.GetValues(typeof(GameState)))
            {
                Console.WriteLine(gameState);
            }

            /*
            =================================
            Task 12
            =================================
            */

            bool exists = Enum.IsDefined(typeof(Status), 3);

            Console.WriteLine($"\nTask 12: {exists}");

            /*
            =================================
            Task 13
            =================================
            */

            EmployeeRole employeeRole = EmployeeRole.Manager;

            Console.WriteLine("\nTask 13:");

            switch (employeeRole)
            {
                case EmployeeRole.Intern:
                    Console.WriteLine("Limited Access");
                    break;

                case EmployeeRole.Employee:
                    Console.WriteLine("Standard Access");
                    break;

                case EmployeeRole.Manager:
                    Console.WriteLine("Department Access");
                    break;

                case EmployeeRole.Director:
                    Console.WriteLine("Executive Access");
                    break;

                case EmployeeRole.CEO:
                    Console.WriteLine("Full Company Access");
                    break;
            }

            /*
            =================================
            Task 14
            =================================
            */

            Console.WriteLine("\nTask 14:");

            PaymentStatus payment1 = PaymentStatus.Pending;
            PaymentStatus payment2 = PaymentStatus.Paid;
            PaymentStatus payment3 = PaymentStatus.Refunded;

            Console.WriteLine(payment1);
            Console.WriteLine(payment2);
            Console.WriteLine(payment3);

            /*
            =================================
            Task 15
            =================================
            */

            Console.WriteLine("\nTask 15:");

            TicketStatus ticket = TicketStatus.Resolved;

            Console.WriteLine($"Ticket Status: {ticket}");

            switch (ticket)
            {
                case TicketStatus.Open:
                    Console.WriteLine("Waiting for technician.");
                    break;

                case TicketStatus.InProgress:
                    Console.WriteLine("Technician is working.");
                    break;

                case TicketStatus.Resolved:
                    Console.WriteLine("Issue solved.");
                    break;

                case TicketStatus.Closed:
                    Console.WriteLine("Ticket completed.");
                    break;
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine("END OF SOLUTIONS");
            Console.WriteLine("=================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
