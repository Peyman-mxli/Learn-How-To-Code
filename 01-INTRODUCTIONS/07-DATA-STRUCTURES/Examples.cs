```csharp
/*
 * ============================================================
 * File: Examples.cs
 * Path: 01-INTRODUCTIONS/07-DATA-STRUCTURES/Examples.cs
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

namespace DataStructuresExamples
{
    // ============================================================
    // EXAMPLE 1: ABSTRACT CLASS WITH GEOMETRIC FIGURES
    // ============================================================

    public abstract class GeometricFigure
    {
        public abstract double CalculateArea();

        public void Draw()
        {
            Console.WriteLine("Drawing the figure...");
        }
    }

    public class Circle : GeometricFigure
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
    }

    public class Square : GeometricFigure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    // ============================================================
    // EXAMPLE 2: ABSTRACT CLASS WITH ANIMALS
    // ============================================================

    public abstract class Animal
    {
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }

        public abstract void MakeSound();
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

    // ============================================================
    // EXAMPLE 3: ARRAY
    // ============================================================

    public static class ArrayExample
    {
        public static void Run()
        {
            int[] scores = { 85, 90, 78, 92 };

            Console.WriteLine("Array example:");
            Console.WriteLine("First score: " + scores[0]);
            Console.WriteLine("Second score: " + scores[1]);

            Console.WriteLine("All scores:");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }

    // ============================================================
    // EXAMPLE 4: STACK - LIFO
    // ============================================================

    public static class StackExample
    {
        public static void Run()
        {
            Stack<string> books = new Stack<string>();

            books.Push("C# Basics");
            books.Push("Object-Oriented Programming");
            books.Push("Data Structures");

            Console.WriteLine("Stack example:");
            Console.WriteLine("Last book added: " + books.Peek());

            Console.WriteLine("Removing books:");
            while (books.Count > 0)
            {
                Console.WriteLine(books.Pop());
            }
        }
    }

    // ============================================================
    // EXAMPLE 5: QUEUE - FIFO
    // ============================================================

    public static class QueueExample
    {
        public static void Run()
        {
            Queue<string> students = new Queue<string>();

            students.Enqueue("Ana");
            students.Enqueue("Carlos");
            students.Enqueue("Maria");

            Console.WriteLine("Queue example:");
            Console.WriteLine("First student in line: " + students.Peek());

            Console.WriteLine("Serving students:");
            while (students.Count > 0)
            {
                Console.WriteLine(students.Dequeue());
            }
        }
    }

    // ============================================================
    // MAIN PROGRAM
    // ============================================================

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DATA STRUCTURES EXAMPLES ===");
            Console.WriteLine();

            Console.WriteLine("Example 1: Geometric Figures");
            Circle myCircle = new Circle(5);
            Square mySquare = new Square(4);

            myCircle.Draw();
            Console.WriteLine("Circle area: " + myCircle.CalculateArea());

            mySquare.Draw();
            Console.WriteLine("Square area: " + mySquare.CalculateArea());

            Console.WriteLine();

            Console.WriteLine("Using abstract base class collection:");
            GeometricFigure[] figures = { myCircle, mySquare };

            foreach (GeometricFigure figure in figures)
            {
                figure.Draw();
                Console.WriteLine("Area: " + figure.CalculateArea());
            }

            Console.WriteLine();

            Console.WriteLine("Example 2: Animals");
            Animal myDog = new Dog();
            myDog.MakeSound();
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();

            Console.WriteLine();

            ArrayExample.Run();

            Console.WriteLine();

            StackExample.Run();

            Console.WriteLine();

            QueueExample.Run();

            Console.WriteLine();
            Console.WriteLine("End of examples.");
        }
    }
}
```
