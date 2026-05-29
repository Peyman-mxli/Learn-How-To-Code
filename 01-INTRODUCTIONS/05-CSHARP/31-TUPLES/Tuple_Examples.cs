using System;
using System.Collections.Generic;

namespace TupleExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("TUPLE EXAMPLES");
            Console.WriteLine("=================================\n");

            /*
            ---------------------------------
            Example 1
            Basic Tuple
            ---------------------------------
            */

            var person = ("Peyman", 25);

            Console.WriteLine("Example 1");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 2
            Named Tuple
            ---------------------------------
            */

            var student =
            (
                Name: "Sara",
                Grade: 95
            );

            Console.WriteLine("Example 2");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Grade);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 3
            Explicit Tuple Type
            ---------------------------------
            */

            (string Name, int Age) employee =
            (
                "Ali",
                30
            );

            Console.WriteLine("Example 3");
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Age);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 4
            Multiple Data Types
            ---------------------------------
            */

            var data =
            (
                "Peyman",
                25,
                true,
                95.5
            );

            Console.WriteLine("Example 4");
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);
            Console.WriteLine(data.Item4);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 5
            Method Returning Tuple
            ---------------------------------
            */

            var player = GetPlayer();

            Console.WriteLine("Example 5");
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Score);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 6
            Tuple Deconstruction
            ---------------------------------
            */

            var personInfo =
            (
                Name: "Peyman",
                Age: 25
            );

            var (name, age) = personInfo;

            Console.WriteLine("Example 6");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 7
            Deconstruct Method Return
            ---------------------------------
            */

            var (playerName, playerScore) = GetPlayer();

            Console.WriteLine("Example 7");
            Console.WriteLine(playerName);
            Console.WriteLine(playerScore);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 8
            Mathematical Results
            ---------------------------------
            */

            var result = Calculate(10, 5);

            Console.WriteLine("Example 8");
            Console.WriteLine($"Sum: {result.Sum}");
            Console.WriteLine($"Product: {result.Product}");
            Console.WriteLine();

            /*
            ---------------------------------
            Example 9
            Nested Tuple
            ---------------------------------
            */

            var customer =
            (
                Name: "Peyman",
                Info:
                (
                    Age: 25,
                    Country: "Mexico"
                )
            );

            Console.WriteLine("Example 9");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Info.Age);
            Console.WriteLine(customer.Info.Country);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 10
            Tuple List
            ---------------------------------
            */

            List<(string Name, int Age)> people =
                new List<(string, int)>
                {
                    ("Ali", 20),
                    ("Sara", 22),
                    ("Peyman", 25)
                };

            Console.WriteLine("Example 10");

            foreach (var personItem in people)
            {
                Console.WriteLine($"{personItem.Name} - {personItem.Age}");
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 11
            Discards
            ---------------------------------
            */

            var (userName, _) =
            (
                "Peyman",
                25
            );

            Console.WriteLine("Example 11");
            Console.WriteLine(userName);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 12
            Coordinate Example
            ---------------------------------
            */

            var position =
            (
                X: 15.5,
                Y: 30.2
            );

            Console.WriteLine("Example 12");
            Console.WriteLine($"X = {position.X}");
            Console.WriteLine($"Y = {position.Y}");
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("END OF TUPLE EXAMPLES");
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
