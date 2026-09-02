using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsExamples
{
    public static class StringExtensions
    {
        public static string AddExclamation(this string text)
        {
            return text + "!";
        }

        public static string Capitalize(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static string Repeat(this string text, int times)
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += text;
            }

            return result;
        }
    }

    public static class NumberExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static int Square(this int number)
        {
            return number * number;
        }
    }

    public static class DecimalExtensions
    {
        public static string ToCurrency(this decimal amount)
        {
            return $"${amount:N2}";
        }
    }

    public static class ListExtensions
    {
        public static bool IsEmpty<T>(this List<T> items)
        {
            return items.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== EXTENSION METHODS EXAMPLES =====\n");

            // --------------------------------------------------
            // Example 1: AddExclamation
            // --------------------------------------------------

            string message = "Hello";

            Console.WriteLine("Example 1");
            Console.WriteLine(message.AddExclamation());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 2: Capitalize
            // --------------------------------------------------

            string name = "peyman";

            Console.WriteLine("Example 2");
            Console.WriteLine(name.Capitalize());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 3: Repeat Text
            // --------------------------------------------------

            Console.WriteLine("Example 3");
            Console.WriteLine("Hi".Repeat(3));
            Console.WriteLine();

            // --------------------------------------------------
            // Example 4: IsEven
            // --------------------------------------------------

            int number1 = 10;

            Console.WriteLine("Example 4");
            Console.WriteLine(number1.IsEven());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 5: IsOdd
            // --------------------------------------------------

            int number2 = 15;

            Console.WriteLine("Example 5");
            Console.WriteLine(number2.IsOdd());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 6: Square Number
            // --------------------------------------------------

            int value = 7;

            Console.WriteLine("Example 6");
            Console.WriteLine(value.Square());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 7: Currency Formatting
            // --------------------------------------------------

            decimal price = 1299.99m;

            Console.WriteLine("Example 7");
            Console.WriteLine(price.ToCurrency());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 8: Empty List Check
            // --------------------------------------------------

            List<string> names = new List<string>();

            Console.WriteLine("Example 8");
            Console.WriteLine(names.IsEmpty());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 9: Non-Empty List Check
            // --------------------------------------------------

            names.Add("Peyman");

            Console.WriteLine("Example 9");
            Console.WriteLine(names.IsEmpty());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 10: Multiple String Extensions
            // --------------------------------------------------

            string text = "hello";

            Console.WriteLine("Example 10");
            Console.WriteLine(
                text.Capitalize().AddExclamation()
            );
            Console.WriteLine();

            // --------------------------------------------------
            // Example 11: Large Number Square
            // --------------------------------------------------

            int points = 20;

            Console.WriteLine("Example 11");
            Console.WriteLine(points.Square());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 12: Validation Example
            // --------------------------------------------------

            int age = 18;

            Console.WriteLine("Example 12");

            if (age.IsEven())
            {
                Console.WriteLine("Age is even.");
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 13: Currency Example
            // --------------------------------------------------

            decimal salary = 4500m;

            Console.WriteLine("Example 13");
            Console.WriteLine(salary.ToCurrency());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 14: Repeat Welcome Message
            // --------------------------------------------------

            Console.WriteLine("Example 14");
            Console.WriteLine("Welcome ".Repeat(2));
            Console.WriteLine();

            // --------------------------------------------------
            // Example 15: LINQ Extension Methods
            // --------------------------------------------------

            List<int> scores = new List<int>
            {
                50,
                75,
                90,
                100
            };

            Console.WriteLine("Example 15");

            var passed =
                scores.Where(score => score >= 70);

            foreach (var score in passed)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine();

            // --------------------------------------------------
            // Example 16: Chained Number Extensions
            // --------------------------------------------------

            int level = 5;

            Console.WriteLine("Example 16");
            Console.WriteLine(level.Square());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 17: Capitalize User Input
            // --------------------------------------------------

            string username = "student";

            Console.WriteLine("Example 17");
            Console.WriteLine(username.Capitalize());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 18: Product Price Formatting
            // --------------------------------------------------

            decimal laptopPrice = 1999.95m;

            Console.WriteLine("Example 18");
            Console.WriteLine(laptopPrice.ToCurrency());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 19: Empty Inventory Check
            // --------------------------------------------------

            List<string> inventory =
                new List<string>();

            Console.WriteLine("Example 19");
            Console.WriteLine(inventory.IsEmpty());
            Console.WriteLine();

            // --------------------------------------------------
            // Example 20: Final Example
            // --------------------------------------------------

            string finalMessage = "goodbye";

            Console.WriteLine("Example 20");
            Console.WriteLine(
                finalMessage
                    .Capitalize()
                    .AddExclamation()
            );
            Console.WriteLine();

            Console.WriteLine(
                "All Extension Methods examples completed."
            );
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
