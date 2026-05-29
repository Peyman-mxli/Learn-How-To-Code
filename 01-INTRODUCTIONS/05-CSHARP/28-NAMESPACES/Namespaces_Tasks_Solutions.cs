using System;
using School;
using Library;
using Garage;
using University;
using Game;

namespace School
{
    public class Student
    {
        public string Name { get; set; }
    }
}

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
    }
}

namespace Garage
{
    public class Car
    {
        public string Brand { get; set; }
    }
}

namespace Company.HR
{
    public class Employee
    {
        public string Name { get; set; }
    }
}

namespace Company.IT
{
    public class Employee
    {
        public string Name { get; set; }
    }
}

namespace University
{
    public class Student
    {
        public string Name { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
    }
}

namespace Game
{
    public class Player
    {
        public string Name { get; set; }
    }

    public class Enemy
    {
        public string Name { get; set; }
    }
}

namespace Company.Sales
{
    public class SalesReport
    {
        public string Title { get; set; }
    }
}

namespace Company.Marketing
{
    public class MarketingCampaign
    {
        public string Name { get; set; }
    }
}

namespace Store.Products
{
    public class Product
    {
        public string Name { get; set; }
    }
}

namespace Warehouse.Products
{
    public class Product
    {
        public string Name { get; set; }
    }
}

namespace OnlineStore.Products
{
    public class Product
    {
        public string Name { get; set; }
    }
}

namespace OnlineStore.Customers
{
    public class Customer
    {
        public string Name { get; set; }
    }
}

namespace OnlineStore.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
    }
}

namespace NovaZone.Player
{
    public class PlayerData
    {
        public string Name { get; set; }
    }
}

namespace NovaZone.Inventory
{
    public class InventorySystem
    {
        public int SlotCount { get; set; }
    }
}

namespace NovaZone.Combat
{
    public class CombatSystem
    {
        public string SkillName { get; set; }
    }
}

namespace School.Students
{
    public class StudentProfile
    {
        public string Name { get; set; }
    }
}

namespace School.Teachers
{
    public class TeacherProfile
    {
        public string Name { get; set; }
    }
}

namespace School.Administration
{
    public class AdminProfile
    {
        public string Name { get; set; }
    }
}

namespace NamespacesTaskSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== NAMESPACES TASK SOLUTIONS =====\n");

            Student schoolStudent = new Student
            {
                Name = "Peyman"
            };

            Console.WriteLine("Task 1:");
            Console.WriteLine($"Student: {schoolStudent.Name}");
            Console.WriteLine();

            Book book = new Book
            {
                Title = "C# Programming"
            };

            Console.WriteLine("Task 2:");
            Console.WriteLine($"Book: {book.Title}");
            Console.WriteLine();

            Car car = new Car
            {
                Brand = "Toyota"
            };

            Console.WriteLine("Task 3:");
            Console.WriteLine($"Car: {car.Brand}");
            Console.WriteLine();

            Company.HR.Employee hrEmployee =
                new Company.HR.Employee
                {
                    Name = "Sarah"
                };

            Console.WriteLine("Task 4:");
            Console.WriteLine($"HR Employee: {hrEmployee.Name}");
            Console.WriteLine();

            Company.IT.Employee itEmployee =
                new Company.IT.Employee
                {
                    Name = "John"
                };

            Console.WriteLine("Task 5:");
            Console.WriteLine($"IT Employee: {itEmployee.Name}");
            Console.WriteLine();

            Console.WriteLine("Task 6:");
            Console.WriteLine($"HR: {hrEmployee.Name}");
            Console.WriteLine($"IT: {itEmployee.Name}");
            Console.WriteLine();

            University.Student universityStudent =
                new University.Student
                {
                    Name = "Maria"
                };

            Teacher teacher = new Teacher
            {
                Name = "Professor Smith"
            };

            Console.WriteLine("Task 7:");
            Console.WriteLine($"University Student: {universityStudent.Name}");
            Console.WriteLine($"Teacher: {teacher.Name}");
            Console.WriteLine();

            Player player = new Player
            {
                Name = "Hero"
            };

            Enemy enemy = new Enemy
            {
                Name = "Wolf"
            };

            Console.WriteLine("Task 8:");
            Console.WriteLine($"Player: {player.Name}");
            Console.WriteLine($"Enemy: {enemy.Name}");
            Console.WriteLine();

            Console.WriteLine("Task 9:");
            Console.WriteLine("The using keyword allowed Book, Car, Teacher, Player, and Enemy to be used directly.");
            Console.WriteLine();

            Company.Sales.SalesReport salesReport =
                new Company.Sales.SalesReport
                {
                    Title = "Monthly Sales Report"
                };

            Company.Marketing.MarketingCampaign marketingCampaign =
                new Company.Marketing.MarketingCampaign
                {
                    Name = "Summer Campaign"
                };

            Console.WriteLine("Task 10:");
            Console.WriteLine($"Sales: {salesReport.Title}");
            Console.WriteLine($"Marketing: {marketingCampaign.Name}");
            Console.WriteLine();

            Store.Products.Product storeProduct =
                new Store.Products.Product
                {
                    Name = "Laptop"
                };

            Warehouse.Products.Product warehouseProduct =
                new Warehouse.Products.Product
                {
                    Name = "Keyboard"
                };

            Console.WriteLine("Task 11:");
            Console.WriteLine($"Store Product: {storeProduct.Name}");
            Console.WriteLine($"Warehouse Product: {warehouseProduct.Name}");
            Console.WriteLine();

            Console.WriteLine("Task 12:");
            Console.WriteLine("File-scoped namespace example:");
            Console.WriteLine("namespace MyProject;");
            Console.WriteLine("public class Example { }");
            Console.WriteLine();

            OnlineStore.Products.Product onlineProduct =
                new OnlineStore.Products.Product
                {
                    Name = "Gaming Mouse"
                };

            OnlineStore.Customers.Customer onlineCustomer =
                new OnlineStore.Customers.Customer
                {
                    Name = "Peyman Miyandashti"
                };

            OnlineStore.Orders.Order onlineOrder =
                new OnlineStore.Orders.Order
                {
                    OrderId = 1001
                };

            Console.WriteLine("Task 13:");
            Console.WriteLine($"Product: {onlineProduct.Name}");
            Console.WriteLine($"Customer: {onlineCustomer.Name}");
            Console.WriteLine($"Order ID: {onlineOrder.OrderId}");
            Console.WriteLine();

            NovaZone.Player.PlayerData playerData =
                new NovaZone.Player.PlayerData
                {
                    Name = "Nova Pahlavan"
                };

            NovaZone.Inventory.InventorySystem inventorySystem =
                new NovaZone.Inventory.InventorySystem
                {
                    SlotCount = 16
                };

            NovaZone.Combat.CombatSystem combatSystem =
                new NovaZone.Combat.CombatSystem
                {
                    SkillName = "Auto Attack"
                };

            Console.WriteLine("Task 14:");
            Console.WriteLine($"Player: {playerData.Name}");
            Console.WriteLine($"Inventory Slots: {inventorySystem.SlotCount}");
            Console.WriteLine($"Skill: {combatSystem.SkillName}");
            Console.WriteLine();

            School.Students.StudentProfile studentProfile =
                new School.Students.StudentProfile
                {
                    Name = "Student Profile"
                };

            School.Teachers.TeacherProfile teacherProfile =
                new School.Teachers.TeacherProfile
                {
                    Name = "Teacher Profile"
                };

            School.Administration.AdminProfile adminProfile =
                new School.Administration.AdminProfile
                {
                    Name = "Admin Profile"
                };

            Console.WriteLine("Task 15:");
            Console.WriteLine(studentProfile.Name);
            Console.WriteLine(teacherProfile.Name);
            Console.WriteLine(adminProfile.Name);
            Console.WriteLine();

            Console.WriteLine("Task 16:");
            Console.WriteLine("Multiple namespaces were created.");
            Console.WriteLine("Nested namespaces were used.");
            Console.WriteLine("using directives were used.");
            Console.WriteLine("Fully qualified names resolved conflicts.");
            Console.WriteLine("Different Employee and Product classes worked correctly.");
            Console.WriteLine();

            Console.WriteLine("All namespace task solutions completed.");
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
