using System;

namespace DebuggingTasksSolutions
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task1_AgeVariable();
            Task2_AddNumbers();
            Task3_MultiplyNumbers();
            Task4_CheckNumber();
            Task5_LoopDebugging();
            Task6_FixAreaFormula();
            Task7_ArrayDebugging();
            Task8_CalculateAverage();
            Task9_RuntimeException();
            Task10_UserInputCondition();
            Task11_Calculator();
            Task12_StudentObjects();
            Task13_CallStackDebugging();
        }

        static void Task1_AgeVariable()
        {
            int age = 25;
            Console.WriteLine($"Age: {age}");
        }

        static void Task2_AddNumbers()
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int result = firstNumber + secondNumber;

            Console.WriteLine($"Result: {result}");
        }

        static void Task3_MultiplyNumbers()
        {
            int result = MultiplyNumbers(5, 4);
            Console.WriteLine($"Multiplication Result: {result}");
        }

        static int MultiplyNumbers(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        static void Task4_CheckNumber()
        {
            int number = 150;

            if (number > 100)
            {
                Console.WriteLine("Number is greater than 100");
            }
            else
            {
                Console.WriteLine("Number is not greater than 100");
            }
        }

        static void Task5_LoopDebugging()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Current number: {i}");
            }
        }

        static void Task6_FixAreaFormula()
        {
            int length = 5;
            int width = 10;

            int area = length * width;

            Console.WriteLine($"Correct Area: {area}");
        }

        static void Task7_ArrayDebugging()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }
        }

        static void Task8_CalculateAverage()
        {
            double average = CalculateAverage(80, 90, 100);
            Console.WriteLine($"Average: {average}");
        }

        static double CalculateAverage(double first, double second, double third)
        {
            return (first + second + third) / 3;
        }

        static void Task9_RuntimeException()
        {
            try
            {
                int number = 10;
                int zero = 0;

                int result = number / zero;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
        }

        static void Task10_UserInputCondition()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 50)
            {
                Console.WriteLine("Large Number");
            }
            else
            {
                Console.WriteLine("Small Number");
            }
        }

        static void Task11_Calculator()
        {
            double firstNumber = 20;
            double secondNumber = 5;
            string operation = "*";

            double result;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                result = 0;
            }

            Console.WriteLine($"Calculator Result: {result}");
        }

        static void Task12_StudentObjects()
        {
            Student studentOne = new Student("Peyman", 25, 95.5);
            Student studentTwo = new Student("Sara", 22, 88.0);
            Student studentThree = new Student("David", 24, 91.2);

            Console.WriteLine($"{studentOne.Name} - {studentOne.Age} - {studentOne.Grade}");
            Console.WriteLine($"{studentTwo.Name} - {studentTwo.Age} - {studentTwo.Grade}");
            Console.WriteLine($"{studentThree.Name} - {studentThree.Age} - {studentThree.Grade}");
        }

        static void Task13_CallStackDebugging()
        {
            MethodA();
        }

        static void MethodA()
        {
            Console.WriteLine("Method A started");
            MethodB();
            Console.WriteLine("Method A ended");
        }

        static void MethodB()
        {
            Console.WriteLine("Method B executed");
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
