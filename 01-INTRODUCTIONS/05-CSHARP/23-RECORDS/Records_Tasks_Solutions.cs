using System;

namespace RecordsTaskSolutions
{
    // Rank 1 — Beginner
    public record Student(string Name, int Age);

    public record Book(string Title, string Author);

    public record Car(string Brand, string Model, int Year);

    // Rank 2 — Easy
    public record Person(string Name, int Age);

    public record Product(string Name, decimal Price);

    public record Movie(string Title, int ReleaseYear);

    // Rank 3 — Intermediate
    public record Employee(int Id, string Name, string Department);

    public record Customer(int CustomerId, string FullName, string Email);

    // Rank 4 — Advanced
    public record Laptop
    {
        public int Id { get; init; }
        public string Brand { get; init; }
        public decimal Price { get; init; }
    }

    public record Phone
    {
        public int Id { get; init; }
        public string Brand { get; init; }
        public string Model { get; init; }
    }

    public record Address(string Street, string City, string Country);

    // Rank 5 — Professional
    public record UserDto(int Id, string Username, string Email);

    public record ProductDto(int ProductId, string ProductName, decimal Price);

    public record OrderDto(int OrderId, string CustomerName, decimal TotalAmount);

    public record CustomerDto(int CustomerId, string FullName, string Email);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== RECORDS TASK SOLUTIONS =====\n");

            Student student = new Student("Peyman", 25);
            Console.WriteLine("Task 1:");
            Console.WriteLine(student);
            Console.WriteLine();

            Book book = new Book("Clean Code", "Robert C. Martin");
            Console.WriteLine("Task 2:");
            Console.WriteLine(book);
            Console.WriteLine();

            Car car = new Car("Toyota", "Corolla", 2024);
            Console.WriteLine("Task 3:");
            Console.WriteLine(car);
            Console.WriteLine();

            Person person1 = new Person("Peyman", 25);
            Person person2 = new Person("Peyman", 25);
            Console.WriteLine("Task 4:");
            Console.WriteLine($"person1 == person2: {person1 == person2}");
            Console.WriteLine();

            Product product1 = new Product("Laptop", 1500m);
            Product product2 = new Product("Phone", 800m);
            Console.WriteLine("Task 5:");
            Console.WriteLine($"product1 == product2: {product1 == product2}");
            Console.WriteLine();

            Movie movie1 = new Movie("Inception", 2010);
            Movie movie2 = new Movie("Inception", 2010);
            Console.WriteLine("Task 6:");
            Console.WriteLine($"movie1 == movie2: {movie1 == movie2}");
            Console.WriteLine();

            Employee employee = new Employee(1, "Peyman", "IT");
            Console.WriteLine("Task 7:");
            Console.WriteLine(employee);
            Console.WriteLine();

            Employee updatedEmployee = employee with
            {
                Department = "Software Development"
            };

            Console.WriteLine("Task 8:");
            Console.WriteLine($"Original: {employee}");
            Console.WriteLine($"Updated : {updatedEmployee}");
            Console.WriteLine();

            Customer customer = new Customer(
                101,
                "Peyman Miyandashti",
                "old.email@example.com"
            );

            Customer updatedCustomer = customer with
            {
                Email = "new.email@example.com"
            };

            Console.WriteLine("Task 9:");
            Console.WriteLine($"Original: {customer}");
            Console.WriteLine($"Updated : {updatedCustomer}");
            Console.WriteLine();

            Laptop laptop = new Laptop
            {
                Id = 1,
                Brand = "Dell",
                Price = 1200m
            };

            Console.WriteLine("Task 10:");
            Console.WriteLine(laptop);
            Console.WriteLine();

            Phone phone1 = new Phone
            {
                Id = 1,
                Brand = "Samsung",
                Model = "Galaxy"
            };

            Phone phone2 = new Phone
            {
                Id = 1,
                Brand = "Samsung",
                Model = "Galaxy"
            };

            Console.WriteLine("Task 11:");
            Console.WriteLine($"phone1 == phone2: {phone1 == phone2}");
            Console.WriteLine();

            Address address = new Address(
                "Main Street",
                "Mexicali",
                "Mexico"
            );

            Address updatedAddress = address with
            {
                City = "Tijuana"
            };

            Console.WriteLine("Task 12:");
            Console.WriteLine($"Original: {address}");
            Console.WriteLine($"Updated : {updatedAddress}");
            Console.WriteLine();

            UserDto userDto = new UserDto(
                1,
                "peyman_dev",
                "peyman@example.com"
            );

            Console.WriteLine("Task 13:");
            Console.WriteLine(userDto);
            Console.WriteLine();

            ProductDto productDto = new ProductDto(
                1001,
                "Gaming Laptop",
                2500m
            );

            ProductDto updatedProductDto = productDto with
            {
                Price = 2300m
            };

            Console.WriteLine("Task 14:");
            Console.WriteLine($"Original: {productDto}");
            Console.WriteLine($"Updated : {updatedProductDto}");
            Console.WriteLine();

            OrderDto order1 = new OrderDto(
                5001,
                "Peyman Miyandashti",
                2300m
            );

            OrderDto order2 = new OrderDto(
                5001,
                "Peyman Miyandashti",
                2300m
            );

            Console.WriteLine("Task 15:");
            Console.WriteLine($"order1 == order2: {order1 == order2}");
            Console.WriteLine();

            CustomerDto customerDto = new CustomerDto(
                101,
                "Peyman Miyandashti",
                "peyman@example.com"
            );

            ProductDto ecommerceProduct = new ProductDto(
                2001,
                "Mechanical Keyboard",
                150m
            );

            OrderDto ecommerceOrder = new OrderDto(
                9001,
                customerDto.FullName,
                ecommerceProduct.Price
            );

            Console.WriteLine("Task 16:");
            Console.WriteLine(customerDto);
            Console.WriteLine(ecommerceProduct);
            Console.WriteLine(ecommerceOrder);
            Console.WriteLine();

            Console.WriteLine("All record task solutions completed.");
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
