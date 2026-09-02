/*
 * ============================================================
 * File: Tasks_Solutions.cs
 * Path: 07-DATA-STRUCTURES/01-BASIC-CONCEPTS/Tasks_Solutions.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace DataStructuresBasicConceptsTaskSolutions
{
    // ============================================================
    // TASK 1 SOLUTION: VEHICLE HIERARCHY
    // ============================================================

    public abstract class Vehicle
    {
        public abstract void Start();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car starting.");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bicycle starting.");
        }
    }

    // ============================================================
    // TASK 2 SOLUTION: GEOMETRIC SHAPES
    // ============================================================

    public abstract class Shape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;

            return Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - SideA) *
                (semiPerimeter - SideB) *
                (semiPerimeter - SideC)
            );
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    // ============================================================
    // TASK 3 SOLUTION: ANIMAL SHELTER
    // ============================================================

    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    public class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The bird sings.");
        }
    }

    // ============================================================
    // TASK 4 SOLUTION: PAYMENT PROCESSING
    // ============================================================

    public abstract class PaymentMethod
    {
        public abstract void Pay(double amount);

        public void ShowPaymentInfo()
        {
            Console.WriteLine("Processing payment...");
        }
    }

    public class CreditCardPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using Credit Card.");
        }
    }

    public class PayPalPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using PayPal.");
        }
    }

    public class CashPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} using Cash.");
        }
    }

    // ============================================================
    // TASK 5 SOLUTION: EMPLOYEE SALARY SYSTEM
    // ============================================================

    public abstract class Employee
    {
        public string FullName { get; set; }

        public Employee(string fullName)
        {
            FullName = fullName;
        }

        public abstract double CalculateSalary();

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Employee: {FullName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string fullName, double monthlySalary)
            : base(fullName)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string fullName, double hourlyRate, int hoursWorked)
            : base(fullName)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    // ============================================================
    // TASK 6 SOLUTION: CONCEPT QUESTIONS
    // ============================================================

    public static class ConceptQuestionSolutions
    {
        public static void Run()
        {
            Console.WriteLine("Task 6: Concept Questions");
            Console.WriteLine();

            Console.WriteLine("1. What is a data structure?");
            Console.WriteLine("A data structure is a way to organize, store, process, and manage information in memory.");
            Console.WriteLine();

            Console.WriteLine("2. Why are data structures important?");
            Console.WriteLine("They help programs work more efficiently by improving access, insertion, deletion, and searching of data.");
            Console.WriteLine();

            Console.WriteLine("3. What is the difference between a data structure and a database?");
            Console.WriteLine("A data structure usually exists in RAM while the program runs. A database stores information permanently.");
            Console.WriteLine();

            Console.WriteLine("4. What is a linear data structure?");
            Console.WriteLine("It is a structure where elements are stored sequentially, one after another.");
            Console.WriteLine();

            Console.WriteLine("5. What is a non-linear data structure?");
            Console.WriteLine("It is a structure where elements are not stored sequentially and relationships can be more complex.");
            Console.WriteLine();

            Console.WriteLine("6. What is the main advantage of an array?");
            Console.WriteLine("An array allows fast access to elements using an index.");
            Console.WriteLine();

            Console.WriteLine("7. What is the main disadvantage of an array?");
            Console.WriteLine("Its size is fixed, so adding or removing elements can be difficult.");
            Console.WriteLine();

            Console.WriteLine("8. Why can linked lists be better than arrays for insertion and deletion?");
            Console.WriteLine("Because linked lists can change connections between nodes without needing to move all elements.");
            Console.WriteLine();

            Console.WriteLine("9. What does LIFO mean?");
            Console.WriteLine("LIFO means Last In, First Out. The last element added is the first one removed.");
            Console.WriteLine();

            Console.WriteLine("10. What does FIFO mean?");
            Console.WriteLine("FIFO means First In, First Out. The first element added is the first one removed.");
            Console.WriteLine();

            Console.WriteLine("11. What is an Abstract Data Type?");
            Console.WriteLine("An Abstract Data Type defines what an object can do without specifying exactly how it does it.");
            Console.WriteLine();

            Console.WriteLine("12. What is an abstract class in C#?");
            Console.WriteLine("An abstract class is a blueprint that cannot be instantiated directly and can contain abstract or implemented methods.");
            Console.WriteLine();

            Console.WriteLine("13. Why can we not create an object directly from an abstract class?");
            Console.WriteLine("Because an abstract class may contain incomplete methods that must be implemented by derived classes.");
            Console.WriteLine();

            Console.WriteLine("14. What is method overriding?");
            Console.WriteLine("Method overriding means providing a specific implementation of a method inherited from a base class.");
            Console.WriteLine();

            Console.WriteLine("15. What is polymorphism?");
            Console.WriteLine("Polymorphism allows objects of different derived classes to be treated as objects of the same base class.");
        }
    }

    // ============================================================
    // CHALLENGE TASK SOLUTION
    // ============================================================

    public static class ChallengeTaskSolution
    {
        public static void Run()
        {
            Console.WriteLine("Challenge Task Answers");
            Console.WriteLine();

            Console.WriteLine("1. Store student grades that will not change:");
            Console.WriteLine("Recommended structure: Array");
            Console.WriteLine("Reason: Arrays are good when the size is fixed and fast access by index is needed.");
            Console.WriteLine();

            Console.WriteLine("2. Manage students waiting in line for assistance:");
            Console.WriteLine("Recommended structure: Queue");
            Console.WriteLine("Reason: A queue uses FIFO, so the first student who arrives is helped first.");
            Console.WriteLine();

            Console.WriteLine("3. Create an Undo button:");
            Console.WriteLine("Recommended structure: Stack");
            Console.WriteLine("Reason: A stack uses LIFO, so the last action is undone first.");
            Console.WriteLine();

            Console.WriteLine("4. Frequently insert and remove students from a collection:");
            Console.WriteLine("Recommended structure: Linked List");
            Console.WriteLine("Reason: Linked lists allow easier insertion and deletion compared to arrays.");
            Console.WriteLine();

            Console.WriteLine("5. Create a common blueprint for Student, Teacher, and Admin:");
            Console.WriteLine("Recommended concept: Abstract Class");
            Console.WriteLine("Reason: An abstract class defines shared behavior while allowing each derived class to implement details differently.");
        }
    }

    // ============================================================
    // MAIN PROGRAM
    // ============================================================

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== BASIC CONCEPTS TASK SOLUTIONS ===");
            Console.WriteLine();

            RunVehicleHierarchySolution();
            RunGeometricShapesSolution();
            RunAnimalShelterSolution();
            RunPaymentProcessingSolution();
            RunEmployeeSalarySystemSolution();

            ConceptQuestionSolutions.Run();

            Console.WriteLine();

            ChallengeTaskSolution.Run();

            Console.WriteLine();
            Console.WriteLine("End of task solutions.");
        }

        public static void RunVehicleHierarchySolution()
        {
            Console.WriteLine("Task 1: Vehicle Hierarchy");

            Vehicle car = new Car();
            Vehicle bicycle = new Bicycle();

            car.Start();
            bicycle.Start();

            Console.WriteLine();
        }

        public static void RunGeometricShapesSolution()
        {
            Console.WriteLine("Task 2: Geometric Shapes");

            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Circle area: " + circle.CalculateArea());
            Console.WriteLine("Circle perimeter: " + circle.CalculatePerimeter());

            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());

            Console.WriteLine("Triangle area: " + triangle.CalculateArea());
            Console.WriteLine("Triangle perimeter: " + triangle.CalculatePerimeter());

            Console.WriteLine();
        }

        public static void RunAnimalShelterSolution()
        {
            Console.WriteLine("Task 3: Animal Shelter");

            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal bird = new Bird();

            dog.MakeSound();
            dog.Sleep();

            cat.MakeSound();
            cat.Sleep();

            bird.MakeSound();
            bird.Sleep();

            Console.WriteLine();
        }

        public static void RunPaymentProcessingSolution()
        {
            Console.WriteLine("Task 4: Payment Processing");

            PaymentMethod creditCard = new CreditCardPayment();
            PaymentMethod payPal = new PayPalPayment();
            PaymentMethod cash = new CashPayment();

            creditCard.ShowPaymentInfo();
            creditCard.Pay(250.75);

            payPal.ShowPaymentInfo();
            payPal.Pay(120.50);

            cash.ShowPaymentInfo();
            cash.Pay(80.00);

            Console.WriteLine();
        }

        public static void RunEmployeeSalarySystemSolution()
        {
            Console.WriteLine("Task 5: Employee Salary System");

            Employee fullTimeEmployee = new FullTimeEmployee("Ana Lopez", 15000);
            Employee partTimeEmployee = new PartTimeEmployee("Carlos Rivera", 120, 40);

            fullTimeEmployee.ShowEmployeeInfo();
            Console.WriteLine("Salary: $" + fullTimeEmployee.CalculateSalary());

            partTimeEmployee.ShowEmployeeInfo();
            Console.WriteLine("Salary: $" + partTimeEmployee.CalculateSalary());

            Console.WriteLine();
        }
    }
}
