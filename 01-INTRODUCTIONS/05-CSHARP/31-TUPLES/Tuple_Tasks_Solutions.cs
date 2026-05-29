using System;
using System.Collections.Generic;

namespace TupleTasksSolutions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("TUPLE TASK SOLUTIONS");
            Console.WriteLine("=================================\n");

            /*
            =================================
            Task 1
            =================================
            */

            var person = ("Peyman", 25);

            Console.WriteLine("Task 1");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine();

            /*
            =================================
            Task 2
            =================================
            */

            var fullName =
            (
                FirstName: "Peyman",
                LastName: "Miyandashti"
            );

            Console.WriteLine("Task 2");
            Console.WriteLine(fullName.FirstName);
            Console.WriteLine(fullName.LastName);
            Console.WriteLine();

            /*
            =================================
            Task 3
            =================================
            */

            var data =
            (
                "Peyman",
                25,
                true
            );

            Console.WriteLine("Task 3");
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);
            Console.WriteLine();

            /*
            =================================
            Task 4
            =================================
            */

            var student =
            (
                Name: "Sara",
                Grade: 95
            );

            Console.WriteLine("Task 4");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Grade);
            Console.WriteLine();

            /*
            =================================
            Task 5
            =================================
            */

            var product =
            (
                ProductName: "Laptop",
                Price: 1200.50
            );

            Console.WriteLine("Task 5");
            Console.WriteLine(product.ProductName);
            Console.WriteLine(product.Price);
            Console.WriteLine();

            /*
            =================================
            Task 6
            =================================
            */

            var point =
            (
                X: 10,
                Y: 20
            );

            Console.WriteLine("Task 6");
            Console.WriteLine($"X = {point.X}");
            Console.WriteLine($"Y = {point.Y}");
            Console.WriteLine();

            /*
            =================================
            Task 7
            =================================
            */

            var player = GetPlayer();

            Console.WriteLine("Task 7");
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Score);
            Console.WriteLine();

            /*
            =================================
            Task 8
            =================================
            */

            var result = Calculate(10, 5);

            Console.WriteLine("Task 8");
            Console.WriteLine($"Sum = {result.Sum}");
            Console.WriteLine($"Product = {result.Product}");
            Console.WriteLine();

            /*
            =================================
            Task 9
            =================================
            */

            var personInfo =
            (
                Name: "Peyman",
                Age: 25
            );

            var (name, age) = personInfo;

            Console.WriteLine("Task 9");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine();

            /*
            =================================
            Task 10
            =================================
            */

            List<(string Name, int Age)> people =
                new List<(string, int)>
                {
                    ("Ali", 20),
                    ("Sara", 22),
                    ("Peyman", 25)
                };

            Console.WriteLine("Task 10");

            foreach (var personItem in people)
            {
                Console.WriteLine($"{personItem.Name} - {personItem.Age}");
            }

            Console.WriteLine();

            /*
            =================================
            Task 11
            =================================
            */

            var customer =
            (
                Name: "Peyman",
                Details:
                (
                    Age: 25,
                    Country: "Mexico"
                )
            );

            Console.WriteLine("Task 11");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Details.Age);
            Console.WriteLine(customer.Details.Country);
            Console.WriteLine();

            /*
            =================================
            Task 12
            =================================
            */

            var (userName, _) =
            (
                "Peyman",
                25
            );

            Console.WriteLine("Task 12");
            Console.WriteLine(userName);
            Console.WriteLine();

            /*
            =================================
            Task 13
            =================================
            */

            var employee = GetEmployee();

            Console.WriteLine("Task 13");
            Console.WriteLine(employee.EmployeeName);
            Console.WriteLine(employee.Department);
            Console.WriteLine(employee.Salary);
            Console.WriteLine();

            /*
            =================================
            Task 14
            =================================
            */

            var character =
            (
                CharacterName: "Nova Pahlavan",
                Level: 25,
                Health: 2500,
                Mana: 1000
            );

            Console.WriteLine("Task 14");
            Console.WriteLine(character.CharacterName);
            Console.WriteLine(character.Level);
            Console.WriteLine(character.Health);
            Console.WriteLine(character.Mana);
            Console.WriteLine();

            /*
            =================================
            Task 15
            =================================
            */

            var statistics = GetStatistics();

            Console.WriteLine("Task 15");
            Console.WriteLine($"Wins: {statistics.Wins}");
            Console.WriteLine($"Losses: {statistics.Losses}");
            Console.WriteLine($"Win Rate: {statistics.WinRate}%");
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("END OF TUPLE SOLUTIONS");
            Console.WriteLine("=================================");
        }

        static (string Name, int Score) GetPlayer()
        {
            return
            (
                "Peyman",
                100
            );
        }

        static (int Sum, int Product) Calculate(int a, int b)
        {
            return
            (
                a + b,
                a * b
            );
        }

        static
        (
            string EmployeeName,
            string Department,
            double Salary
        )
        GetEmployee()
        {
            return
            (
                "Peyman",
                "IT",
                5000
            );
        }

        static
        (
            int Wins,
            int Losses,
            double WinRate
        )
        GetStatistics()
        {
            return
            (
                20,
                5,
                80.0
            );
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
