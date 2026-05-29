using System;

namespace StructExamples
{
    struct Point
    {
        public int X;
        public int Y;
    }

    struct Person
    {
        public string Name;
        public int Age;
    }

    struct Rectangle
    {
        public double Width;
        public double Height;

        public double GetArea()
        {
            return Width * Height;
        }
    }

    struct Employee
    {
        public string Name;
        public int Age;

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    struct Score
    {
        public int Value;
    }

    struct Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    readonly struct Temperature
    {
        public readonly double Value;

        public Temperature(double value)
        {
            Value = value;
        }
    }

    struct Address
    {
        public string City;
        public string Country;
    }

    struct Customer
    {
        public string Name;
        public Address Address;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("STRUCT EXAMPLES");
            Console.WriteLine("=================================\n");

            /*
            ---------------------------------
            Example 1
            Basic Struct
            ---------------------------------
            */

            Point point;

            point.X = 10;
            point.Y = 20;

            Console.WriteLine("Example 1");
            Console.WriteLine($"Point: ({point.X}, {point.Y})\n");

            /*
            ---------------------------------
            Example 2
            Struct With Multiple Fields
            ---------------------------------
            */

            Person person;

            person.Name = "Peyman";
            person.Age = 25;

            Console.WriteLine("Example 2");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}\n");

            /*
            ---------------------------------
            Example 3
            Struct Method
            ---------------------------------
            */

            Rectangle rectangle;

            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine("Example 3");
            Console.WriteLine($"Area: {rectangle.GetArea()}\n");

            /*
            ---------------------------------
            Example 4
            Struct Constructor
            ---------------------------------
            */

            Employee employee =
                new Employee("Ali", 30);

            Console.WriteLine("Example 4");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}\n");

            /*
            ---------------------------------
            Example 5
            Value Type Behavior
            ---------------------------------
            */

            Score score1;

            score1.Value = 100;

            Score score2 = score1;

            score2.Value = 500;

            Console.WriteLine("Example 5");
            Console.WriteLine($"Score 1: {score1.Value}");
            Console.WriteLine($"Score 2: {score2.Value}\n");

            /*
            ---------------------------------
            Example 6
            Struct Properties
            ---------------------------------
            */

            Student student = new Student
            {
                Name = "Sara",
                Grade = 95
            };

            Console.WriteLine("Example 6");
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Grade: {student.Grade}\n");

            /*
            ---------------------------------
            Example 7
            Readonly Struct
            ---------------------------------
            */

            Temperature temperature =
                new Temperature(36.5);

            Console.WriteLine("Example 7");
            Console.WriteLine($"Temperature: {temperature.Value}\n");

            /*
            ---------------------------------
            Example 8
            Nested Struct
            ---------------------------------
            */

            Customer customer;

            customer.Name = "Peyman";

            customer.Address.City = "Mexicali";
            customer.Address.Country = "Mexico";

            Console.WriteLine("Example 8");
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"City: {customer.Address.City}");
            Console.WriteLine($"Country: {customer.Address.Country}\n");

            /*
            ---------------------------------
            Example 9
            Struct Array
            ---------------------------------
            */

            Point[] points = new Point[3];

            points[0].X = 1;
            points[0].Y = 1;

            points[1].X = 2;
            points[1].Y = 2;

            points[2].X = 3;
            points[2].Y = 3;

            Console.WriteLine("Example 9");

            foreach (Point p in points)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 10
            Passing Struct By Value
            ---------------------------------
            */

            Score score = new Score();

            score.Value = 50;

            UpdateScore(score);

            Console.WriteLine("Example 10");
            Console.WriteLine($"Score After Method: {score.Value}\n");

            /*
            ---------------------------------
            Example 11
            Passing Struct By Reference
            ---------------------------------
            */

            UpdateScoreRef(ref score);

            Console.WriteLine("Example 11");
            Console.WriteLine($"Score After Ref Method: {score.Value}\n");

            Console.WriteLine("=================================");
            Console.WriteLine("END OF STRUCT EXAMPLES");
            Console.WriteLine("=================================");
        }

        static void UpdateScore(Score score)
        {
            score.Value = 999;
        }

        static void UpdateScoreRef(ref Score score)
        {
            score.Value = 999;
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
