using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsTaskSolutions
{
    // =========================================================
    // STRING EXTENSIONS
    // =========================================================

    public static class StringExtensions
    {
        public static string AddQuestionMark(this string text)
        {
            return text + "?";
        }

        public static string AddPeriod(this string text)
        {
            return text + ".";
        }

        public static string ToUpperCase(this string text)
        {
            return text.ToUpper();
        }

        public static string ToLowerCase(this string text)
        {
            return text.ToLower();
        }

        public static string ReverseText(this string text)
        {
            char[] characters = text.ToCharArray();

            Array.Reverse(characters);

            return new string(characters);
        }

        public static string CapitalizeFirstLetter(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static bool IsValidEmail(this string email)
        {
            return email.Contains("@") &&
                   email.Contains(".");
        }
    }

    // =========================================================
    // INTEGER EXTENSIONS
    // =========================================================

    public static class IntegerExtensions
    {
        public static int DoubleValue(this int number)
        {
            return number * 2;
        }

        public static int TripleValue(this int number)
        {
            return number * 3;
        }

        public static bool IsPositive(this int number)
        {
            return number > 0;
        }
    }

    // =========================================================
    // DECIMAL EXTENSIONS
    // =========================================================

    public static class DecimalExtensions
    {
        public static decimal ApplyTax(this decimal amount)
        {
            return amount * 1.16m;
        }

        public static decimal ApplyDiscount(
            this decimal amount,
            decimal discountPercentage)
        {
            return amount -
                   (amount * discountPercentage / 100m);
        }
    }

    // =========================================================
    // LIST EXTENSIONS
    // =========================================================

    public static class ListExtensions
    {
        public static bool IsEmpty<T>(
            this List<T> items)
        {
            return items.Count == 0;
        }

        public static void DisplayItems<T>(
            this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    // =========================================================
    // DATETIME EXTENSIONS
    // =========================================================

    public static class DateTimeExtensions
    {
        public static string ToShortDate(
            this DateTime date)
        {
            return date.ToShortDateString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "===== EXTENSION METHODS TASK SOLUTIONS =====\n");

            Console.WriteLine("Task 1:");
            Console.WriteLine(
                "Hello".AddQuestionMark());
            Console.WriteLine();

            Console.WriteLine("Task 2:");
            Console.WriteLine(
                "Welcome".AddPeriod());
            Console.WriteLine();

            Console.WriteLine("Task 3:");
            Console.WriteLine(
                10.DoubleValue());
            Console.WriteLine();

            Console.WriteLine("Task 4:");
            Console.WriteLine(
                10.TripleValue());
            Console.WriteLine();

            Console.WriteLine("Task 5:");
            Console.WriteLine(
                25.IsPositive());
            Console.WriteLine();

            Console.WriteLine("Task 6:");
            Console.WriteLine(
                "peyman".ToUpperCase());
            Console.WriteLine();

            Console.WriteLine("Task 7:");
            Console.WriteLine(
                "PEYMAN".ToLowerCase());
            Console.WriteLine();

            Console.WriteLine("Task 8:");
            Console.WriteLine(
                "Hello".ReverseText());
            Console.WriteLine();

            Console.WriteLine("Task 9:");
            decimal amount = 100m;

            Console.WriteLine(
                amount.ApplyTax());
            Console.WriteLine();

            Console.WriteLine("Task 10:");
            Console.WriteLine(
                amount.ApplyDiscount(20));
            Console.WriteLine();

            Console.WriteLine("Task 11:");

            List<string> emptyList =
                new List<string>();

            Console.WriteLine(
                emptyList.IsEmpty());

            Console.WriteLine();

            Console.WriteLine("Task 12:");

            List<string> names =
                new List<string>
                {
                    "Peyman",
                    "John",
                    "Maria"
                };

            names.DisplayItems();

            Console.WriteLine();

            Console.WriteLine("Task 13:");
            Console.WriteLine(
                "peyman".CapitalizeFirstLetter());
            Console.WriteLine();

            Console.WriteLine("Task 14:");
            Console.WriteLine(
                "peyman@example.com"
                .IsValidEmail());

            Console.WriteLine();

            Console.WriteLine("Task 15:");

            DateTime today =
                new DateTime(2026, 5, 29);

            Console.WriteLine(
                today.ToShortDate());

            Console.WriteLine();

            Console.WriteLine("Task 16:");

            string username = "peyman";

            Console.WriteLine(
                username.CapitalizeFirstLetter());

            int score = 50;

            Console.WriteLine(
                score.DoubleValue());

            decimal salary = 1000m;

            Console.WriteLine(
                salary.ApplyTax());

            List<int> numbers =
                new List<int>
                {
                    10,
                    20,
                    30
                };

            numbers.DisplayItems();

            Console.WriteLine(
                DateTime.Now.ToShortDate());

            Console.WriteLine();

            Console.WriteLine(
                "All extension methods task solutions completed.");
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
