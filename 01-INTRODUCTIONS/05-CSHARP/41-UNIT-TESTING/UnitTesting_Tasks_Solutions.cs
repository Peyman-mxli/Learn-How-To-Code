using System;

namespace UnitTestingTasksSolutions
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
                throw new DivideByZeroException("Cannot divide by zero.");
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

    public class NameFormatter
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }

    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email)
                   && email.Contains("@");
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            UserValidator userValidator = new UserValidator();
            NameFormatter nameFormatter = new NameFormatter();
            EmailValidator emailValidator = new EmailValidator();

            Console.WriteLine("TASK 1 - UNDERSTAND UNIT TESTING");
            Console.WriteLine("Unit testing means testing a small part of code, like one method or class.");
            Console.WriteLine();

            Console.WriteLine("TASK 2 - CREATE A CALCULATOR CLASS");
            Console.WriteLine("Calculator class created.");
            Console.WriteLine();

            Console.WriteLine("TASK 3 - TEST ADD METHOD");
            PrintTestResult(calculator.Add(2, 3) == 5);
            Console.WriteLine();

            Console.WriteLine("TASK 4 - TEST SUBTRACT METHOD");
            PrintTestResult(calculator.Subtract(10, 4) == 6);
            Console.WriteLine();

            Console.WriteLine("TASK 5 - TEST MULTIPLY METHOD");
            PrintTestResult(calculator.Multiply(5, 4) == 20);
            Console.WriteLine();

            Console.WriteLine("TASK 6 - TEST DIVIDE METHOD");
            PrintTestResult(calculator.Divide(20, 5) == 4);
            Console.WriteLine();

            Console.WriteLine("TASK 7 - TEST DIVIDE BY ZERO");

            try
            {
                calculator.Divide(10, 0);
                PrintTestResult(false);
            }
            catch (DivideByZeroException)
            {
                PrintTestResult(true);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 8 - CREATE USER VALIDATOR");
            Console.WriteLine("UserValidator class created.");
            Console.WriteLine();

            Console.WriteLine("TASK 9 - TEST ADULT USER");
            PrintTestResult(userValidator.IsAdult(20) == true);
            Console.WriteLine();

            Console.WriteLine("TASK 10 - TEST MINOR USER");
            PrintTestResult(userValidator.IsAdult(15) == false);
            Console.WriteLine();

            Console.WriteLine("TASK 11 - TEST VALID PASSWORD");
            PrintTestResult(userValidator.IsValidPassword("Password123") == true);
            Console.WriteLine();

            Console.WriteLine("TASK 12 - TEST SHORT PASSWORD");
            PrintTestResult(userValidator.IsValidPassword("123") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 13 - TEST EMPTY PASSWORD");
            PrintTestResult(userValidator.IsValidPassword("") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 14 - ARRANGE ACT ASSERT");
            Console.WriteLine("Arrange means prepare the data.");
            Console.WriteLine("Act means run the method.");
            Console.WriteLine("Assert means check if the result is correct.");
            Console.WriteLine();

            Console.WriteLine("TASK 15 - EDGE CASE TEST");
            PrintTestResult(calculator.Add(0, 0) == 0);
            Console.WriteLine();

            Console.WriteLine("TASK 16 - NEGATIVE NUMBER TEST");
            PrintTestResult(calculator.Add(-5, -3) == -8);
            Console.WriteLine();

            Console.WriteLine("TASK 17 - TEST STRING METHOD");
            PrintTestResult(
                nameFormatter.GetFullName("Peyman", "Miyandashti")
                == "Peyman Miyandashti");
            Console.WriteLine();

            Console.WriteLine("TASK 18 - TEST VALIDATION LOGIC");
            PrintTestResult(emailValidator.IsValidEmail("test@email.com") == true);
            PrintTestResult(emailValidator.IsValidEmail("wrongemail.com") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 19 - REAL-WORLD TESTING");
            Console.WriteLine("Unit testing is useful in calculators.");
            Console.WriteLine("Unit testing is useful in login systems.");
            Console.WriteLine("Unit testing is useful in game systems.");
            Console.WriteLine();

            Console.WriteLine("TASK 20 - MINI PROJECT");
            Console.WriteLine("Manual testing system completed with multiple PASS / FAIL tests.");
        }

        static void PrintTestResult(bool condition)
        {
            if (condition)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
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
