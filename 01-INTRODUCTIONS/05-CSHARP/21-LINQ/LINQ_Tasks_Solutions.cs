```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTaskSolutions
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public bool IsActive { get; set; }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsAvailable { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 1: FIND EVEN NUMBERS");
            Console.WriteLine("=========================================");

            List<int> numbers = new List<int>
            {
                10, 15, 22, 37, 44, 51, 60, 73, 88, 91
            };

            var evenNumbers =
                numbers.Where(number => number % 2 == 0);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine($"Even Number: {number}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 2: FIND NUMBERS GREATER THAN 50");
            Console.WriteLine("=========================================");

            var numbersGreaterThanFifty =
                numbers.Where(number => number > 50);

            foreach (int number in numbersGreaterThanFifty)
            {
                Console.WriteLine($"Number Greater Than 50: {number}");
            }

            Console.WriteLine($"Total Found: {numbersGreaterThanFifty.Count()}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 3: SORT NUMBERS");
            Console.WriteLine("=========================================");

            var ascendingNumbers =
                numbers.OrderBy(number => number);

            Console.WriteLine("Ascending Order:");

            foreach (int number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }

            var descendingNumbers =
                numbers.OrderByDescending(number => number);

            Console.WriteLine("Descending Order:");

            foreach (int number in descendingNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 4: FILTER NAMES BY LETTER");
            Console.WriteLine("=========================================");

            List<string> names = new List<string>
            {
                "Peyman",
                "Sarah",
                "David",
                "Daniel",
                "Maria",
                "John",
                "Diana",
                "Carlos"
            };

            var namesStartingWithD =
                names.Where(name => name.StartsWith("D"));

            if (namesStartingWithD.Any())
            {
                foreach (string name in namesStartingWithD)
                {
                    Console.WriteLine($"Name Found: {name}");
                }
            }
            else
            {
                Console.WriteLine("No names found.");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 5: SELECT STUDENT NAMES");
            Console.WriteLine("=========================================");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Peyman", Grade = 95, IsActive = true },
                new Student { Name = "Sarah", Grade = 88, IsActive = true },
                new Student { Name = "David", Grade = 67, IsActive = false },
                new Student { Name = "Maria", Grade = 91, IsActive = true },
                new Student { Name = "John", Grade = 72, IsActive = false },
                new Student { Name = "Diana", Grade = 99, IsActive = true },
                new Student { Name = "Carlos", Grade = 84, IsActive = true },
                new Student { Name = "Linda", Grade = 58, IsActive = false }
            };

            var studentNames =
                students.Select(student => student.Name);

            foreach (string studentName in studentNames)
            {
                Console.WriteLine($"Student Name: {studentName}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 6: FIND PASSING STUDENTS");
            Console.WriteLine("=========================================");

            var passingStudents =
                students.Where(student => student.Grade >= 70);

            foreach (Student student in passingStudents)
            {
                Console.WriteLine($"{student.Name} passed with grade {student.Grade}");
            }

            Console.WriteLine($"Total Passing Students: {passingStudents.Count()}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 7: FIND TOP STUDENTS");
            Console.WriteLine("=========================================");

            var topStudents =
                students
                    .Where(student => student.Grade >= 90)
                    .OrderByDescending(student => student.Grade);

            Console.WriteLine("Top Student Report:");

            foreach (Student student in topStudents)
            {
                Console.WriteLine($"{student.Name} | Grade: {student.Grade}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 8: SEARCH FOR A STUDENT");
            Console.WriteLine("=========================================");

            string searchName = "Maria";

            Student foundStudent =
                students.FirstOrDefault(student => student.Name == searchName);

            if (foundStudent != null)
            {
                Console.WriteLine(
                    $"Student Found: {foundStudent.Name} | Grade: {foundStudent.Grade} | Active: {foundStudent.IsActive}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 9: STUDENT GRADE STATISTICS");
            Console.WriteLine("=========================================");

            int totalStudents =
                students.Count();

            double averageGrade =
                students.Average(student => student.Grade);

            int lowestGrade =
                students.Min(student => student.Grade);

            int highestGrade =
                students.Max(student => student.Grade);

            Console.WriteLine($"Total Students: {totalStudents}");
            Console.WriteLine($"Average Grade: {averageGrade:F2}");
            Console.WriteLine($"Lowest Grade: {lowestGrade}");
            Console.WriteLine($"Highest Grade: {highestGrade}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 10: GROUP STUDENTS BY ACTIVE STATUS");
            Console.WriteLine("=========================================");

            var groupedStudents =
                students.GroupBy(student => student.IsActive);

            foreach (var group in groupedStudents)
            {
                string status =
                    group.Key ? "Active Students" : "Inactive Students";

                Console.WriteLine(status);
                Console.WriteLine($"Total: {group.Count()}");

                foreach (Student student in group)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 11: PRODUCT FILTER SYSTEM");
            Console.WriteLine("=========================================");

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 5, IsAvailable = true },
                new Product { Name = "Keyboard", Category = "Electronics", Price = 80, Stock = 20, IsAvailable = true },
                new Product { Name = "Monitor", Category = "Electronics", Price = 250, Stock = 8, IsAvailable = true },
                new Product { Name = "Desk", Category = "Furniture", Price = 300, Stock = 4, IsAvailable = true },
                new Product { Name = "Chair", Category = "Furniture", Price = 150, Stock = 10, IsAvailable = true },
                new Product { Name = "Notebook", Category = "School", Price = 15, Stock = 50, IsAvailable = true },
                new Product { Name = "Backpack", Category = "School", Price = 60, Stock = 12, IsAvailable = false },
                new Product { Name = "Tablet", Category = "Electronics", Price = 500, Stock = 6, IsAvailable = true },
                new Product { Name = "Bookshelf", Category = "Furniture", Price = 180, Stock = 3, IsAvailable = false },
                new Product { Name = "Printer", Category = "Electronics", Price = 220, Stock = 7, IsAvailable = true },
                new Product { Name = "Mouse", Category = "Electronics", Price = 35, Stock = 25, IsAvailable = true },
                new Product { Name = "Lamp", Category = "Furniture", Price = 45, Stock = 16, IsAvailable = true },
                new Product { Name = "Pen Set", Category = "School", Price = 12, Stock = 100, IsAvailable = true },
                new Product { Name = "Drawing Tablet", Category = "Electronics", Price = 350, Stock = 2, IsAvailable = true },
                new Product { Name = "Office Cabinet", Category = "Furniture", Price = 400, Stock = 2, IsAvailable = true }
            };

            var filteredProducts =
                products
                    .Where(product => product.IsAvailable)
                    .Where(product => product.Price > 100)
                    .OrderBy(product => product.Price);

            foreach (Product product in filteredProducts)
            {
                Console.WriteLine(
                    $"{product.Name} | Category: {product.Category} | Price: ${product.Price}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 12: INVENTORY CATEGORY REPORT");
            Console.WriteLine("=========================================");

            var productGroups =
                products.GroupBy(product => product.Category);

            foreach (var group in productGroups)
            {
                Console.WriteLine($"Category: {group.Key}");
                Console.WriteLine($"Product Count: {group.Count()}");
                Console.WriteLine($"Average Price: ${group.Average(product => product.Price):F2}");

                foreach (Product product in group)
                {
                    Console.WriteLine($"- {product.Name} | ${product.Price}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 13: REMOVE DUPLICATE CUSTOMER EMAILS");
            Console.WriteLine("=========================================");

            List<string> emails = new List<string>
            {
                "peyman@email.com",
                "sarah@email.com",
                "john@email.com",
                "peyman@email.com",
                "maria@email.com",
                "david@email.com",
                "john@email.com",
                "diana@email.com",
                "sarah@email.com",
                "carlos@email.com"
            };

            var uniqueEmails =
                emails.Distinct();

            int duplicatesRemoved =
                emails.Count - uniqueEmails.Count();

            foreach (string email in uniqueEmails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine($"Duplicates Removed: {duplicatesRemoved}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 14: EMPLOYEE MANAGEMENT REPORT");
            Console.WriteLine("=========================================");

            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Peyman", Department = "IT", Salary = 4500, IsActive = true },
                new Employee { Name = "Sarah", Department = "IT", Salary = 5200, IsActive = true },
                new Employee { Name = "David", Department = "HR", Salary = 3900, IsActive = true },
                new Employee { Name = "Maria", Department = "Finance", Salary = 6100, IsActive = true },
                new Employee { Name = "John", Department = "Finance", Salary = 4800, IsActive = false },
                new Employee { Name = "Diana", Department = "HR", Salary = 4200, IsActive = true },
                new Employee { Name = "Carlos", Department = "Sales", Salary = 3700, IsActive = true },
                new Employee { Name = "Linda", Department = "Sales", Salary = 4000, IsActive = false },
                new Employee { Name = "Robert", Department = "IT", Salary = 7000, IsActive = true },
                new Employee { Name = "Emma", Department = "Finance", Salary = 5600, IsActive = true }
            };

            var activeEmployees =
                employees.Where(employee => employee.IsActive);

            var employeesByDepartment =
                activeEmployees.GroupBy(employee => employee.Department);

            foreach (var departmentGroup in employeesByDepartment)
            {
                Console.WriteLine($"Department: {departmentGroup.Key}");
                Console.WriteLine($"Active Employees: {departmentGroup.Count()}");
                Console.WriteLine($"Average Salary: ${departmentGroup.Average(employee => employee.Salary):F2}");

                foreach (Employee employee in departmentGroup)
                {
                    Console.WriteLine($"- {employee.Name} | Salary: ${employee.Salary}");
                }

                Console.WriteLine();
            }

            double highestSalary =
                activeEmployees.Max(employee => employee.Salary);

            Console.WriteLine($"Highest Active Employee Salary: ${highestSalary}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 15: STORE ANALYTICS REPORT");
            Console.WriteLine("=========================================");

            var availableProducts =
                products.Where(product => product.IsAvailable);

            var expensiveAvailableProducts =
                availableProducts
                    .Where(product => product.Price > 100)
                    .OrderByDescending(product => product.Price);

            Console.WriteLine("Available Products Above $100:");

            foreach (Product product in expensiveAvailableProducts)
            {
                Console.WriteLine(
                    $"{product.Name} | {product.Category} | ${product.Price} | Stock: {product.Stock}");
            }

            Console.WriteLine();

            var productsByCategory =
                availableProducts.GroupBy(product => product.Category);

            Console.WriteLine("Products By Category:");

            foreach (var categoryGroup in productsByCategory)
            {
                Console.WriteLine($"Category: {categoryGroup.Key}");
                Console.WriteLine($"Product Count: {categoryGroup.Count()}");
                Console.WriteLine($"Average Price: ${categoryGroup.Average(product => product.Price):F2}");
            }

            Product cheapestProduct =
                availableProducts.OrderBy(product => product.Price).FirstOrDefault();

            Product mostExpensiveProduct =
                availableProducts.OrderByDescending(product => product.Price).FirstOrDefault();

            double totalStockValue =
                availableProducts.Sum(product => product.Price * product.Stock);

            Console.WriteLine();

            if (cheapestProduct != null)
            {
                Console.WriteLine(
                    $"Cheapest Product: {cheapestProduct.Name} | ${cheapestProduct.Price}");
            }

            if (mostExpensiveProduct != null)
            {
                Console.WriteLine(
                    $"Most Expensive Product: {mostExpensiveProduct.Name} | ${mostExpensiveProduct.Price}");
            }

            Console.WriteLine($"Total Stock Value: ${totalStockValue:F2}");

            Console.WriteLine();

            Console.WriteLine("LINQ Task Solutions Completed!");
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
```
