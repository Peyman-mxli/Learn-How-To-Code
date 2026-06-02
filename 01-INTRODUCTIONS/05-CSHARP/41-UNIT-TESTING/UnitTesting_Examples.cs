using System;

namespace UnitTestingExamples
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(
                    "Cannot divide by zero.");
            }

            return a / b;
        }
    }

    public class UserValidator
    {
        public bool IsAdult(int age)
        {
            return age >= 18;
        }

        public bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password)
                   && password.Length >= 8;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 1 - TEST ADD");
            Console.WriteLine("====================================");

            int addResult = calculator.Add(2, 3);

            int expectedAdd = 5;

            Console.WriteLine($"Expected: {expectedAdd}");
            Console.WriteLine($"Actual:   {addResult}");

            Console.WriteLine(
                expectedAdd == addResult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 2 - TEST SUBTRACT");
            Console.WriteLine("====================================");

            int subtractResult =
                calculator.Subtract(10, 4);

            int expectedSubtract = 6;

            Console.WriteLine($"Expected: {expectedSubtract}");
            Console.WriteLine($"Actual:   {subtractResult}");

            Console.WriteLine(
                expectedSubtract == subtractResult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 3 - TEST MULTIPLY");
            Console.WriteLine("====================================");

            int multiplyResult =
                calculator.Multiply(5, 4);

            int expectedMultiply = 20;

            Console.WriteLine($"Expected: {expectedMultiply}");
            Console.WriteLine($"Actual:   {multiplyResult}");

            Console.WriteLine(
                expectedMultiply == multiplyResult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 4 - TEST DIVIDE");
            Console.WriteLine("====================================");

            double divideResult =
                calculator.Divide(20, 5);

            double expectedDivide = 4;

            Console.WriteLine($"Expected: {expectedDivide}");
            Console.WriteLine($"Actual:   {divideResult}");

            Console.WriteLine(
                expectedDivide == divideResult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 5 - TEST DIVIDE BY ZERO");
            Console.WriteLine("====================================");

            try
            {
                calculator.Divide(10, 0);

                Console.WriteLine("FAIL");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("PASS");
            }

            Console.WriteLine();


            UserValidator validator =
                new UserValidator();

            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 6 - TEST ADULT USER");
            Console.WriteLine("====================================");

            bool isAdult =
                validator.IsAdult(20);

            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Actual:   {isAdult}");

            Console.WriteLine(
                isAdult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 7 - TEST MINOR USER");
            Console.WriteLine("====================================");

            bool isMinorAdult =
                validator.IsAdult(15);

            Console.WriteLine($"Expected: False");
            Console.WriteLine($"Actual:   {isMinorAdult}");

            Console.WriteLine(
                !isMinorAdult
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 8 - TEST VALID PASSWORD");
            Console.WriteLine("====================================");

            bool validPassword =
                validator.IsValidPassword("Password123");

            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Actual:   {validPassword}");

            Console.WriteLine(
                validPassword
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 9 - TEST SHORT PASSWORD");
            Console.WriteLine("====================================");

            bool shortPassword =
                validator.IsValidPassword("123");

            Console.WriteLine($"Expected: False");
            Console.WriteLine($"Actual:   {shortPassword}");

            Console.WriteLine(
                !shortPassword
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 10 - TEST EMPTY PASSWORD");
            Console.WriteLine("====================================");

            bool emptyPassword =
                validator.IsValidPassword("");

            Console.WriteLine($"Expected: False");
            Console.WriteLine($"Actual:   {emptyPassword}");

            Console.WriteLine(
                !emptyPassword
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 11 - EDGE CASE");
            Console.WriteLine("====================================");

            int edgeCaseResult =
                calculator.Add(0, 0);

            Console.WriteLine($"Expected: 0");
            Console.WriteLine($"Actual:   {edgeCaseResult}");

            Console.WriteLine(
                edgeCaseResult == 0
                ? "PASS"
                : "FAIL");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 12 - TESTING COMPLETE");
            Console.WriteLine("====================================");
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
