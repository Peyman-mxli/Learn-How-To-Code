using System;

namespace NullableTypesExamples
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
            Console.WriteLine("===== NULLABLE TYPES EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: Nullable Integer
            // --------------------------------------------------

            int? age = null;

            Console.WriteLine("Example 1");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 2: Assigning a Value
            // --------------------------------------------------

            age = 25;

            Console.WriteLine("Example 2");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 3: HasValue Property
            // --------------------------------------------------

            Console.WriteLine("Example 3");

            if (age.HasValue)
            {
                Console.WriteLine("Age contains a value.");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: Value Property
            // --------------------------------------------------

            Console.WriteLine("Example 4");
            Console.WriteLine($"Age Value: {age.Value}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: Null Check
            // --------------------------------------------------

            int? score = null;

            Console.WriteLine("Example 5");

            if (score is null)
            {
                Console.WriteLine("Score is null.");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Null Coalescing Operator ??
            // --------------------------------------------------

            int? level = null;

            int finalLevel = level ?? 1;

            Console.WriteLine("Example 6");
            Console.WriteLine($"Level: {finalLevel}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: String with ??
            // --------------------------------------------------

            string? username = null;

            string displayName = username ?? "Guest";

            Console.WriteLine("Example 7");
            Console.WriteLine(displayName);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Null Coalescing Assignment ??=
            // --------------------------------------------------

            string? role = null;

            role ??= "Player";

            Console.WriteLine("Example 8");
            Console.WriteLine(role);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Safe Navigation Operator ?.
            // --------------------------------------------------

            string? text = null;

            int? length = text?.Length;

            Console.WriteLine("Example 9");
            Console.WriteLine($"Length: {length}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Safe Navigation with Value
            // --------------------------------------------------

            text = "Hello";

            length = text?.Length;

            Console.WriteLine("Example 10");
            Console.WriteLine($"Length: {length}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 11: Nullable Double
            // --------------------------------------------------

            double? price = null;

            Console.WriteLine("Example 11");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 12: Nullable Boolean
            // --------------------------------------------------

            bool? isOnline = null;

            Console.WriteLine("Example 12");
            Console.WriteLine($"Online Status: {isOnline}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 13: Nullable DateTime
            // --------------------------------------------------

            DateTime? completedDate = null;

            Console.WriteLine("Example 13");
            Console.WriteLine($"Completed Date: {completedDate}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 14: Nullable Reference Type
            // --------------------------------------------------

            string? phoneNumber = null;

            Console.WriteLine("Example 14");
            Console.WriteLine(phoneNumber ?? "No Phone Number");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 15: Real-World User Profile
            // --------------------------------------------------

            UserProfile user = new UserProfile
            {
                Name = "Peyman",
                PhoneNumber = null
            };

            Console.WriteLine("Example 15");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine(
                $"Phone: {user.PhoneNumber ?? "Not Provided"}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 16: Safe Property Access
            // --------------------------------------------------

            UserProfile? customer = null;

            string customerName =
                customer?.Name ?? "Unknown Customer";

            Console.WriteLine("Example 16");
            Console.WriteLine(customerName);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 17: Using is not null
            // --------------------------------------------------

            string? email = "peyman@example.com";

            Console.WriteLine("Example 17");

            if (email is not null)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 18: Chained Safe Access
            // --------------------------------------------------

            UserProfile profile = new UserProfile
            {
                Name = "Peyman",
                PhoneNumber = "6861234567"
            };

            int? phoneLength =
                profile?.PhoneNumber?.Length;

            Console.WriteLine("Example 18");
            Console.WriteLine($"Phone Length: {phoneLength}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 19: Nullable Decimal
            // --------------------------------------------------

            decimal? discount = null;

            decimal finalDiscount =
                discount ?? 0m;

            Console.WriteLine("Example 19");
            Console.WriteLine($"Discount: {finalDiscount}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 20: Default Values
            // --------------------------------------------------

            int? lives = null;

            Console.WriteLine("Example 20");
            Console.WriteLine($"Lives: {lives ?? 3}");
            Console.WriteLine();

            Console.WriteLine("All Nullable Types examples completed.");
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
