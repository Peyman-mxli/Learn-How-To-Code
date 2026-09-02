using System;

namespace PatternMatchingExamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record User(string Name, int Age);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PATTERN MATCHING EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: Type Pattern
            // --------------------------------------------------

            object value = "Hello World";

            if (value is string text)
            {
                Console.WriteLine("Example 1");
                Console.WriteLine($"String Value: {text}");
                Console.WriteLine();
            }

            // --------------------------------------------------
            // Example 2: Constant Pattern
            // --------------------------------------------------

            int number = 5;

            if (number is 5)
            {
                Console.WriteLine("Example 2");
                Console.WriteLine("Number is 5");
                Console.WriteLine();
            }

            // --------------------------------------------------
            // Example 3: Null Pattern
            // --------------------------------------------------

            string name = null;

            Console.WriteLine("Example 3");

            if (name is null)
            {
                Console.WriteLine("Name is null");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: Not Null Pattern
            // --------------------------------------------------

            string username = "Peyman";

            Console.WriteLine("Example 4");

            if (username is not null)
            {
                Console.WriteLine(username);
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: Relational Pattern
            // --------------------------------------------------

            int age = 20;

            Console.WriteLine("Example 5");

            if (age is >= 18)
            {
                Console.WriteLine("Adult");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Logical AND Pattern
            // --------------------------------------------------

            int score = 85;

            Console.WriteLine("Example 6");

            if (score is >= 80 and <= 100)
            {
                Console.WriteLine("Passed");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: Logical OR Pattern
            // --------------------------------------------------

            string role = "Admin";

            Console.WriteLine("Example 7");

            if (role is "Admin" or "Manager")
            {
                Console.WriteLine("Access Granted");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Logical NOT Pattern
            // --------------------------------------------------

            Console.WriteLine("Example 8");

            if (role is not "Guest")
            {
                Console.WriteLine("User Allowed");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Switch Expression
            // --------------------------------------------------

            string accessLevel = role switch
            {
                "Admin" => "Full Access",
                "Manager" => "Limited Access",
                "User" => "Basic Access",
                _ => "No Access"
            };

            Console.WriteLine("Example 9");
            Console.WriteLine(accessLevel);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Grade System
            // --------------------------------------------------

            int examScore = 92;

            string grade = examScore switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine("Example 10");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 11: Property Pattern
            // --------------------------------------------------

            Person person = new Person
            {
                Name = "Peyman",
                Age = 25
            };

            Console.WriteLine("Example 11");

            if (person is { Age: >= 18 })
            {
                Console.WriteLine("Person is an Adult");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 12: Property Pattern With Multiple Values
            // --------------------------------------------------

            Console.WriteLine("Example 12");

            if (person is
                {
                    Age: >= 18,
                    Name: "Peyman"
                })
            {
                Console.WriteLine("Adult Peyman Found");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 13: Record Pattern Matching
            // --------------------------------------------------

            User user = new User("Peyman", 25);

            Console.WriteLine("Example 13");

            if (user is { Age: >= 18 })
            {
                Console.WriteLine("Adult User");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 14: Object Type Switch
            // --------------------------------------------------

            object item = 100;

            string result = item switch
            {
                int n => $"Integer: {n}",
                string s => $"String: {s}",
                bool b => $"Boolean: {b}",
                _ => "Unknown Type"
            };

            Console.WriteLine("Example 14");
            Console.WriteLine(result);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 15: Real-World Membership System
            // --------------------------------------------------

            int memberLevel = 75;

            string membership = memberLevel switch
            {
                >= 100 => "Legend",
                >= 75 => "Elite",
                >= 50 => "Premium",
                >= 25 => "Standard",
                _ => "Beginner"
            };

            Console.WriteLine("Example 15");
            Console.WriteLine($"Membership: {membership}");
            Console.WriteLine();

            Console.WriteLine("All Pattern Matching examples completed.");
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
