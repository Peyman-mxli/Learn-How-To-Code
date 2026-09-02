using System;

namespace EnumsExamples
{
    enum Status
    {
        Pending,
        Active,
        Suspended,
        Deleted
    }

    enum Priority
    {
        Low = 1,
        Medium = 5,
        High = 10,
        Critical = 100
    }

    enum CharacterState
    {
        Idle,
        Walking,
        Running,
        Jumping,
        Attacking,
        Dead
    }

    enum UserRole
    {
        Guest,
        Member,
        Moderator,
        Administrator
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("ENUM EXAMPLES");
            Console.WriteLine("=================================\n");

            /*
            ---------------------------------
            Example 1
            Basic Enum
            ---------------------------------
            */

            Status userStatus = Status.Active;

            Console.WriteLine("Example 1");
            Console.WriteLine($"User Status: {userStatus}\n");

            /*
            ---------------------------------
            Example 2
            Enum To Integer
            ---------------------------------
            */

            Console.WriteLine("Example 2");

            int statusValue = (int)userStatus;

            Console.WriteLine($"Status Value: {statusValue}\n");

            /*
            ---------------------------------
            Example 3
            Integer To Enum
            ---------------------------------
            */

            Console.WriteLine("Example 3");

            int number = 2;

            Status convertedStatus = (Status)number;

            Console.WriteLine($"Converted Status: {convertedStatus}\n");

            /*
            ---------------------------------
            Example 4
            Custom Values
            ---------------------------------
            */

            Console.WriteLine("Example 4");

            Priority priority = Priority.Critical;

            Console.WriteLine($"Priority: {priority}");
            Console.WriteLine($"Priority Value: {(int)priority}\n");

            /*
            ---------------------------------
            Example 5
            Enum In If Statement
            ---------------------------------
            */

            Console.WriteLine("Example 5");

            if (userStatus == Status.Active)
            {
                Console.WriteLine("User account is active.\n");
            }

            /*
            ---------------------------------
            Example 6
            Enum In Switch Statement
            ---------------------------------
            */

            Console.WriteLine("Example 6");

            switch (userStatus)
            {
                case Status.Pending:
                    Console.WriteLine("Account Pending");
                    break;

                case Status.Active:
                    Console.WriteLine("Account Active");
                    break;

                case Status.Suspended:
                    Console.WriteLine("Account Suspended");
                    break;

                case Status.Deleted:
                    Console.WriteLine("Account Deleted");
                    break;
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 7
            Game Character State
            ---------------------------------
            */

            Console.WriteLine("Example 7");

            CharacterState playerState = CharacterState.Running;

            Console.WriteLine($"Player State: {playerState}\n");

            /*
            ---------------------------------
            Example 8
            User Roles
            ---------------------------------
            */

            Console.WriteLine("Example 8");

            UserRole role = UserRole.Administrator;

            Console.WriteLine($"User Role: {role}\n");

            /*
            ---------------------------------
            Example 9
            Get All Enum Values
            ---------------------------------
            */

            Console.WriteLine("Example 9");

            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine(status);
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 10
            Get All Enum Names
            ---------------------------------
            */

            Console.WriteLine("Example 10");

            string[] names = Enum.GetNames(typeof(Status));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 11
            Check If Enum Value Exists
            ---------------------------------
            */

            Console.WriteLine("Example 11");

            bool exists = Enum.IsDefined(typeof(Status), 3);

            Console.WriteLine($"Value Exists: {exists}\n");

            /*
            ---------------------------------
            Example 12
            Real World Order Status
            ---------------------------------
            */

            Console.WriteLine("Example 12");

            OrderStatus order = OrderStatus.Shipped;

            Console.WriteLine($"Order Status: {order}\n");

            Console.WriteLine("=================================");
            Console.WriteLine("END OF ENUM EXAMPLES");
            Console.WriteLine("=================================");
        }
    }

    enum OrderStatus
    {
        Created,
        Processing,
        Shipped,
        Delivered,
        Cancelled
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
