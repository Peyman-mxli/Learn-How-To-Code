using System;

namespace RecordsExamples
{
    // Positional Record
    public record Person(string Name, int Age);

    // Property-Based Record
    public record Product
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }

    // Record Inheritance
    public record Employee(string Name, string Department)
        : Person(Name, 0);

    // Record Struct
    public record struct Point(int X, int Y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== RECORDS EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: Creating a Record
            // --------------------------------------------------

            Person person1 = new Person("Peyman", 25);

            Console.WriteLine("Example 1");
            Console.WriteLine(person1);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 2: Value Equality
            // --------------------------------------------------

            Person person2 = new Person("Peyman", 25);

            Console.WriteLine("Example 2");
            Console.WriteLine($"person1 == person2 : {person1 == person2}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 3: Different Values
            // --------------------------------------------------

            Person person3 = new Person("John", 30);

            Console.WriteLine("Example 3");
            Console.WriteLine($"person1 == person3 : {person1 == person3}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: Using With Expression
            // --------------------------------------------------

            Person person4 = person1 with { Age = 26 };

            Console.WriteLine("Example 4");
            Console.WriteLine($"Original : {person1}");
            Console.WriteLine($"Modified : {person4}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: Property-Based Record
            // --------------------------------------------------

            Product laptop = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1500m
            };

            Console.WriteLine("Example 5");
            Console.WriteLine(laptop);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Record Inheritance
            // --------------------------------------------------

            Employee employee =
                new Employee("Peyman", "IT");

            Console.WriteLine("Example 6");
            Console.WriteLine(employee);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: Record Struct
            // --------------------------------------------------

            Point point = new Point(10, 20);

            Console.WriteLine("Example 7");
            Console.WriteLine(point);
            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Cloning Product
            // --------------------------------------------------

            Product laptop2 = laptop with
            {
                Price = 1800m
            };

            Console.WriteLine("Example 8");
            Console.WriteLine($"Original : {laptop}");
            Console.WriteLine($"Copy     : {laptop2}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Equality With Products
            // --------------------------------------------------

            Product phone1 = new Product
            {
                Id = 2,
                Name = "Phone",
                Price = 800m
            };

            Product phone2 = new Product
            {
                Id = 2,
                Name = "Phone",
                Price = 800m
            };

            Console.WriteLine("Example 9");
            Console.WriteLine($"phone1 == phone2 : {phone1 == phone2}");
            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Real-World DTO Example
            // --------------------------------------------------

            OrderDto order =
                new OrderDto(
                    1001,
                    "Gaming Laptop",
                    2500m
                );

            Console.WriteLine("Example 10");
            Console.WriteLine(order);
            Console.WriteLine();

            Console.WriteLine("All record examples completed.");
        }
    }

    public record OrderDto(
        int OrderId,
        string ProductName,
        decimal TotalPrice
    );
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
