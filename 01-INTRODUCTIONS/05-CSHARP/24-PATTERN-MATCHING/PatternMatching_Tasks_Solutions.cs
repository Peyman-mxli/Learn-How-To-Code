using System;

namespace PatternMatchingTaskSolutions
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record User(string Name, int Age);

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PATTERN MATCHING TASK SOLUTIONS =====\n");

            object value = "Hello Pattern Matching";

            Console.WriteLine("Task 1:");
            if (value is string text)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();

            int number = 10;

            Console.WriteLine("Task 2:");
            if (number is 10)
            {
                Console.WriteLine("Number is 10");
            }
            Console.WriteLine();

            string name = null;

            Console.WriteLine("Task 3:");
            if (name is null)
            {
                Console.WriteLine("Name is null");
            }
            Console.WriteLine();

            int age = 20;

            Console.WriteLine("Task 4:");
            if (age is >= 18)
            {
                Console.WriteLine("Adult");
            }
            Console.WriteLine();

            int score = 85;

            Console.WriteLine("Task 5:");
            if (score is >= 80 and <= 100)
            {
                Console.WriteLine("Passed");
            }
            Console.WriteLine();

            string role = "Admin";

            Console.WriteLine("Task 6:");
            if (role is "Admin" or "Manager")
            {
                Console.WriteLine("Access Granted");
            }
            Console.WriteLine();

            string guestRole = "User";

            Console.WriteLine("Task 7:");
            if (guestRole is not "Guest")
            {
                Console.WriteLine("User is not a guest");
            }
            Console.WriteLine();

            string userRole = "Admin";

            string access = userRole switch
            {
                "Admin" => "Full Access",
                "User" => "Basic Access",
                "Guest" => "Limited Access",
                _ => "No Access"
            };

            Console.WriteLine("Task 8:");
            Console.WriteLine(access);
            Console.WriteLine();

            int gradeScore = 92;

            string grade = gradeScore switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine("Task 9:");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine();

            Person person = new Person
            {
                Name = "Peyman",
                Age = 25
            };

            Console.WriteLine("Task 10:");
            if (person is { Age: >= 18 })
            {
                Console.WriteLine("Person is an adult");
            }
            Console.WriteLine();

            Console.WriteLine("Task 11:");
            if (person is { Name: "Peyman", Age: >= 18 })
            {
                Console.WriteLine("Peyman is an adult");
            }
            Console.WriteLine();

            object item = 100;

            string detectedType = item switch
            {
                int n => $"Integer: {n}",
                string s => $"String: {s}",
                bool b => $"Boolean: {b}",
                _ => "Unknown Type"
            };

            Console.WriteLine("Task 12:");
            Console.WriteLine(detectedType);
            Console.WriteLine();

            User user = new User("Peyman", 25);

            Console.WriteLine("Task 13:");
            if (user is { Age: >= 18 })
            {
                Console.WriteLine("User is an adult");
            }
            Console.WriteLine();

            int memberLevel = 80;

            string membership = memberLevel switch
            {
                >= 100 => "Legend",
                >= 75 => "Elite",
                >= 50 => "Premium",
                >= 25 => "Standard",
                _ => "Beginner"
            };

            Console.WriteLine("Task 14:");
            Console.WriteLine($"Membership: {membership}");
            Console.WriteLine();

            Employee employee = new Employee
            {
                Name = "Peyman",
                Age = 25,
                Department = "IT"
            };

            Console.WriteLine("Task 15:");
            if (employee is { Age: >= 18, Department: "IT" })
            {
                Console.WriteLine("Valid Employee");
            }
            Console.WriteLine();

            Console.WriteLine("Task 16:");

            object demoValue = "Pattern Demo";

            if (demoValue is string demoText)
            {
                Console.WriteLine($"Type Pattern: {demoText}");
            }

            int demoNumber = 10;

            if (demoNumber is 10)
            {
                Console.WriteLine("Constant Pattern: Number is 10");
            }

            string nullValue = null;

            if (nullValue is null)
            {
                Console.WriteLine("Null Pattern: Value is null");
            }

            int demoAge = 30;

            if (demoAge is >= 18)
            {
                Console.WriteLine("Relational Pattern: Adult");
            }

            int demoScore = 90;

            if (demoScore is >= 80 and <= 100)
            {
                Console.WriteLine("Logical Pattern: Passed");
            }

            Person demoPerson = new Person
            {
                Name = "Peyman",
                Age = 25
            };

            if (demoPerson is { Name: "Peyman", Age: >= 18 })
            {
                Console.WriteLine("Property Pattern: Valid Person");
            }

            string demoRole = "Admin";

            string demoAccess = demoRole switch
            {
                "Admin" => "Full Access",
                "User" => "Basic Access",
                _ => "No Access"
            };

            Console.WriteLine($"Switch Expression: {demoAccess}");
            Console.WriteLine();

            Console.WriteLine("All pattern matching task solutions completed.");
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
