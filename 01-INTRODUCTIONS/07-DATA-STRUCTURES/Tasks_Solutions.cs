```csharp
/*
 * ============================================================
 * File: Tasks_Solutions.cs
 * Path: 01-INTRODUCTIONS/07-DATA-STRUCTURES/Tasks_Solutions.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;
using System.Collections.Generic;

namespace DataStructuresTasksSolutions
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
            double s = CalculatePerimeter() / 2;

            return Math.Sqrt(
                s *
                (s - SideA) *
                (s - SideB) *
                (s - SideC)
            );
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    // ============================================================
    // TASK 3 SOLUTION: ARRAY PRACTICE
    // ============================================================

    public static class ArrayTaskSolution
    {
        public static void Run()
        {
            int[] grades = { 85, 90, 78, 92, 88 };

            Console.WriteLine("Array Practice:");

            Console.WriteLine("First grade: " + grades[0]);
            Console.WriteLine("Last grade: " + grades[grades.Length - 1]);

            Console.WriteLine("All grades:");

            int total = 0;

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
                total += grade;
            }

            double average = (double)total / grades.Length;

            Console.WriteLine("Average grade: " + average);
        }
    }

    // ============================================================
    // TASK 4 SOLUTION: STACK PRACTICE
    // ============================================================

    public static class StackTaskSolution
    {
        public static void Run()
        {
            Stack<string> books = new Stack<string>();

            books.Push("C# Basics");
            books.Push("Object-Oriented Programming");
            books.Push("Data Structures");
            books.Push("Algorithms");

            Console.WriteLine("Stack Practice:");

            Console.WriteLine("Top book: " + books.Peek());

            Console.WriteLine("Removing books:");

            while (books.Count > 0)
            {
                Console.WriteLine(books.Pop());
            }
        }
    }

    // ============================================================
    // TASK 5 SOLUTION: QUEUE PRACTICE
    // ============================================================

    public static class QueueTaskSolution
    {
        public static void Run()
        {
            Queue<string> customers = new Queue<string>();

            customers.Enqueue("Ana");
            customers.Enqueue("Carlos");
            customers.Enqueue("Maria");
            customers.Enqueue("Luis");

            Console.WriteLine("Queue Practice:");

            Console.WriteLine("First customer: " + customers.Peek());

            Console.WriteLine("Serving customers:");

            while (customers.Count > 0)
            {
                Console.WriteLine(customers.Dequeue());
            }
        }
    }

    // ============================================================
    // CHALLENGE TASK SOLUTION
    // ============================================================

    public static class ChallengeTaskSolution
    {
        public static void Run()
        {
            Console.WriteLine("Challenge Task Answers:");
            Console.WriteLine();

            Console.WriteLine("1. Storing student grades that never change:");
            Console.WriteLine("Recommended structure: Array");
            Console.WriteLine("Reason: The size is fixed and access by index is fast.");
            Console.WriteLine();

            Console.WriteLine("2. Managing students waiting for assistance:");
            Console.WriteLine("Recommended structure: Queue");
            Console.WriteLine("Reason: The first student who arrives should be helped first.");
            Console.WriteLine();

            Console.WriteLine("3. Implementing an Undo button:");
            Console.WriteLine("Recommended structure: Stack");
            Console.WriteLine("Reason: The last action should be undone first.");
            Console.WriteLine();

            Console.WriteLine("4. Managing students who enroll and withdraw frequently:");
            Console.WriteLine("Recommended structure: Linked List");
            Console.WriteLine("Reason: Insertions and deletions are easier than in arrays.");
            Console.WriteLine();

            Console.WriteLine("5. Creating a blueprint for different employee types:");
            Console.WriteLine("Recommended structure: Abstract Class");
            Console.WriteLine("Reason: It defines common behavior that derived classes must implement.");
        }
    }

    // ============================================================
    // MAIN PROGRAM
    // ============================================================

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DATA STRUCTURES TASK SOLUTIONS ===");
            Console.WriteLine();

            Console.WriteLine("Task 1: Vehicle Hierarchy");

            Vehicle myCar = new Car();
            Vehicle myBicycle = new Bicycle();

            myCar.Start();
            myBicycle.Start();

            Console.WriteLine();

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

            ArrayTaskSolution.Run();

            Console.WriteLine();

            StackTaskSolution.Run();

            Console.WriteLine();

            QueueTaskSolution.Run();

            Console.WriteLine();

            ChallengeTaskSolution.Run();

            Console.WriteLine();
            Console.WriteLine("End of task solutions.");
        }
    }
}
```
