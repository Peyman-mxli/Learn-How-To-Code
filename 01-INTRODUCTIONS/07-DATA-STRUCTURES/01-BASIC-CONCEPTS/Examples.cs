```csharp
/*
 * ============================================================
 * File: Examples.cs
 * Path: 07-DATA-STRUCTURES/01-BASIC-CONCEPTS/Examples.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace DataStructuresBasicConceptsExamples
{
    // ============================================================
    // EXAMPLE 1: GEOMETRIC FIGURES
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
    // EXAMPLE 2: ANIMALS
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
    // EXAMPLE 3: PAYMENT METHODS
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

    // ============================================================
    // EXAMPLE 4: EMPLOYEES
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
    // EXAMPLE 5: VEHICLES
    // ============================================================

    public abstract class Vehicle
    {
        public abstract void Start();

        public void Stop()
        {
            Console.WriteLine("Vehicle stopped.");
        }
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car starting.");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle starting.");
        }
    }

    // ============================================================
    // MAIN PROGRAM
    // ============================================================

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== BASIC CONCEPTS EXAMPLES ===");
            Console.WriteLine();

            RunGeometricFigureExample();
            RunAnimalExample();
            RunPaymentMethodExample();
            RunEmployeeExample();
            RunVehicleExample();

            Console.WriteLine();
            Console.WriteLine("End of examples.");
        }

        public static void RunGeometricFigureExample()
        {
            Console.WriteLine("Example 1: Geometric Figures");

            GeometricFigure circle = new Circle(5);
            GeometricFigure square = new Square(4);

            circle.Draw();
            Console.WriteLine("Circle area: " + circle.CalculateArea());

            square.Draw();
            Console.WriteLine("Square area: " + square.CalculateArea());

            Console.WriteLine();
        }

        public static void RunAnimalExample()
        {
            Console.WriteLine("Example 2: Animals");

            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            dog.Sleep();

            cat.MakeSound();
            cat.Sleep();

            Console.WriteLine();
        }

        public static void RunPaymentMethodExample()
        {
            Console.WriteLine("Example 3: Payment Methods");

            PaymentMethod creditCard = new CreditCardPayment();
            PaymentMethod payPal = new PayPalPayment();

            creditCard.ShowPaymentInfo();
            creditCard.Pay(250.75);

            payPal.ShowPaymentInfo();
            payPal.Pay(120.50);

            Console.WriteLine();
        }

        public static void RunEmployeeExample()
        {
            Console.WriteLine("Example 4: Employees");

            Employee fullTimeEmployee = new FullTimeEmployee("Ana Lopez", 15000);
            Employee partTimeEmployee = new PartTimeEmployee("Carlos Rivera", 120, 40);

            fullTimeEmployee.ShowEmployeeInfo();
            Console.WriteLine("Salary: $" + fullTimeEmployee.CalculateSalary());

            partTimeEmployee.ShowEmployeeInfo();
            Console.WriteLine("Salary: $" + partTimeEmployee.CalculateSalary());

            Console.WriteLine();
        }

        public static void RunVehicleExample()
        {
            Console.WriteLine("Example 5: Vehicles");

            Vehicle car = new Car();
            Vehicle motorcycle = new Motorcycle();

            car.Start();
            car.Stop();

            motorcycle.Start();
            motorcycle.Stop();

            Console.WriteLine();
        }
    }
}
```
