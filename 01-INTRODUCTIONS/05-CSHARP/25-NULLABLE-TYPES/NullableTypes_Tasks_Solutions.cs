using System;

namespace NullableTypesTaskSolutions
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== NULLABLE TYPES TASK SOLUTIONS =====\n");

            int? age = null;
            Console.WriteLine("Task 1:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine();

            age = 25;
            Console.WriteLine("Task 2:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine();

            double? price = null;
            Console.WriteLine("Task 3:");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine();

            bool? isOnline = null;
            Console.WriteLine("Task 4:");
            Console.WriteLine($"Online: {isOnline}");
            Console.WriteLine();

            int? score = null;
            Console.WriteLine("Task 5:");
            if (score.HasValue)
            {
                Console.WriteLine($"Score: {score.Value}");
            }
            else
            {
                Console.WriteLine("Score has no value.");
            }
            Console.WriteLine();

            int? lives = 3;
            Console.WriteLine("Task 6:");
            Console.WriteLine($"Lives: {lives.Value}");
            Console.WriteLine();

            int? level = null;
            int finalLevel = level ?? 1;
            Console.WriteLine("Task 7:");
            Console.WriteLine($"Level: {finalLevel}");
            Console.WriteLine();

            string? username = null;
            string displayName = username ?? "Guest";
            Console.WriteLine("Task 8:");
            Console.WriteLine($"Username: {displayName}");
            Console.WriteLine();

            string? role = null;
            role ??= "Player";
            Console.WriteLine("Task 9:");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine();

            string? message = null;
            int? messageLength = message?.Length;
            Console.WriteLine("Task 10:");
            Console.WriteLine($"Message Length: {messageLength}");
            Console.WriteLine();

            DateTime? completedDate = null;
            Console.WriteLine("Task 11:");
            Console.WriteLine($"Completed Date: {completedDate}");
            Console.WriteLine();

            UserProfile user = new UserProfile
            {
                Name = "Peyman",
                PhoneNumber = null
            };

            Console.WriteLine("Task 12:");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Phone: {user.PhoneNumber ?? "Not Provided"}");
            Console.WriteLine();

            decimal? discount = null;
            decimal finalDiscount = discount ?? 0m;
            Console.WriteLine("Task 13:");
            Console.WriteLine($"Discount: {finalDiscount}");
            Console.WriteLine();

            string? email = null;
            Console.WriteLine("Task 14:");

            if (email is null)
            {
                Console.WriteLine("Email is null.");
            }

            email = "peyman@example.com";

            if (email is not null)
            {
                Console.WriteLine($"Email: {email}");
            }

            Console.WriteLine();

            UserProfile profile = new UserProfile
            {
                Name = "Peyman",
                PhoneNumber = "6865090453"
            };

            int? phoneLength = profile?.PhoneNumber?.Length;
            Console.WriteLine("Task 15:");
            Console.WriteLine($"Phone Length: {phoneLength}");
            Console.WriteLine();

            Console.WriteLine("Task 16:");

            int? demoAge = null;
            Console.WriteLine($"Nullable int: {demoAge ?? 0}");

            string? demoName = null;
            Console.WriteLine($"Nullable string: {demoName ?? "Unknown"}");

            int? demoScore = 100;

            if (demoScore.HasValue)
            {
                Console.WriteLine($"HasValue: {demoScore.HasValue}");
                Console.WriteLine($"Value: {demoScore.Value}");
            }

            string? demoRole = null;
            demoRole ??= "Guest";
            Console.WriteLine($"??= Operator: {demoRole}");

            string? demoText = "Hello";
            Console.WriteLine($"?. Operator: {demoText?.Length}");

            string? demoEmail = null;

            if (demoEmail is null)
            {
                Console.WriteLine("is null: Email is missing");
            }

            demoEmail = "student@example.com";

            if (demoEmail is not null)
            {
                Console.WriteLine($"is not null: {demoEmail}");
            }

            Console.WriteLine();

            Console.WriteLine("All nullable types task solutions completed.");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
