```csharp
/*
 * ============================================================
 * File: Tasks.cs
 * Path: 07-DATA-STRUCTURES/01-BASIC-CONCEPTS/Tasks.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace DataStructuresBasicConceptsTasks
{
    /*
     * ============================================================
     * TASK 1: VEHICLE HIERARCHY
     * ============================================================
     *
     * Instructions:
     *
     * 1. Create an abstract class called Vehicle.
     *
     * 2. Inside Vehicle, create an abstract method called Start().
     *
     * 3. Create two classes that inherit from Vehicle:
     *
     *      • Car
     *      • Bicycle
     *
     * 4. Implement the Start() method in each derived class:
     *
     *      Car:
     *          Print:
     *          "Car starting."
     *
     *      Bicycle:
     *          Print:
     *          "Bicycle starting."
     *
     * 5. In the Main() method:
     *
     *      • Create an object of Car.
     *      • Create an object of Bicycle.
     *      • Call Start() on each object.
     *
     * Expected Output:
     *
     *      Car starting.
     *      Bicycle starting.
     */


    /*
     * ============================================================
     * TASK 2: GEOMETRIC SHAPES
     * ============================================================
     *
     * Description:
     *
     * Create a class hierarchy to represent different
     * geometric shapes.
     *
     * Instructions:
     *
     * 1. Create an abstract class called Shape.
     *
     * 2. Inside Shape, create two abstract methods:
     *
     *      • CalculateArea()
     *      • CalculatePerimeter()
     *
     * 3. Create three classes that inherit from Shape:
     *
     *      • Circle
     *      • Rectangle
     *      • Triangle
     *
     * 4. Circle:
     *
     *      Attribute:
     *          Radius
     *
     *      Implement:
     *          CalculateArea()
     *          CalculatePerimeter()
     *
     * 5. Rectangle:
     *
     *      Attributes:
     *          Width
     *          Height
     *
     *      Implement:
     *          CalculateArea()
     *          CalculatePerimeter()
     *
     * 6. Triangle:
     *
     *      Attributes:
     *          SideA
     *          SideB
     *          SideC
     *
     *      Implement:
     *          CalculateArea()
     *          CalculatePerimeter()
     *
     *      Hint:
     *
     *          Use Heron's Formula to calculate the area.
     *
     *          s = perimeter / 2
     *
     *          Area = √(s(s - a)(s - b)(s - c))
     *
     * 7. In the Main() method:
     *
     *      • Create one object of each shape.
     *      • Assign values.
     *      • Display the area.
     *      • Display the perimeter.
     */


    /*
     * ============================================================
     * TASK 3: ANIMAL SHELTER
     * ============================================================
     *
     * Description:
     *
     * Practice abstract classes, inheritance, and method
     * overriding by creating different types of animals.
     *
     * Instructions:
     *
     * 1. Create an abstract class called Animal.
     *
     * 2. Add an abstract method called MakeSound().
     *
     * 3. Add a normal method called Sleep() that prints:
     *
     *      "The animal is sleeping."
     *
     * 4. Create three classes that inherit from Animal:
     *
     *      • Dog
     *      • Cat
     *      • Bird
     *
     * 5. Implement MakeSound() in each class:
     *
     *      Dog:
     *          "The dog barks."
     *
     *      Cat:
     *          "The cat meows."
     *
     *      Bird:
     *          "The bird sings."
     *
     * 6. In Main():
     *
     *      • Create one object of each animal.
     *      • Call MakeSound().
     *      • Call Sleep().
     */


    /*
     * ============================================================
     * TASK 4: PAYMENT PROCESSING
     * ============================================================
     *
     * Description:
     *
     * Create a simple payment system using an abstract class.
     *
     * Instructions:
     *
     * 1. Create an abstract class called PaymentMethod.
     *
     * 2. Add an abstract method called Pay(double amount).
     *
     * 3. Add a normal method called ShowPaymentInfo() that prints:
     *
     *      "Processing payment..."
     *
     * 4. Create three classes that inherit from PaymentMethod:
     *
     *      • CreditCardPayment
     *      • PayPalPayment
     *      • CashPayment
     *
     * 5. Implement Pay(double amount) in each class:
     *
     *      CreditCardPayment:
     *          "Paid $amount using Credit Card."
     *
     *      PayPalPayment:
     *          "Paid $amount using PayPal."
     *
     *      CashPayment:
     *          "Paid $amount using Cash."
     *
     * 6. In Main():
     *
     *      • Create one object of each payment method.
     *      • Call ShowPaymentInfo().
     *      • Call Pay().
     */


    /*
     * ============================================================
     * TASK 5: EMPLOYEE SALARY SYSTEM
     * ============================================================
     *
     * Description:
     *
     * Use an abstract class to create a simple employee
     * salary system.
     *
     * Instructions:
     *
     * 1. Create an abstract class called Employee.
     *
     * 2. Add a property called FullName.
     *
     * 3. Create a constructor that receives the employee name.
     *
     * 4. Add an abstract method called CalculateSalary().
     *
     * 5. Add a normal method called ShowEmployeeInfo() that prints
     *    the employee's full name.
     *
     * 6. Create two classes that inherit from Employee:
     *
     *      • FullTimeEmployee
     *      • PartTimeEmployee
     *
     * 7. FullTimeEmployee:
     *
     *      Attribute:
     *          MonthlySalary
     *
     *      CalculateSalary():
     *          Return MonthlySalary.
     *
     * 8. PartTimeEmployee:
     *
     *      Attributes:
     *          HourlyRate
     *          HoursWorked
     *
     *      CalculateSalary():
     *          Return HourlyRate * HoursWorked.
     *
     * 9. In Main():
     *
     *      • Create one FullTimeEmployee.
     *      • Create one PartTimeEmployee.
     *      • Display their information.
     *      • Display their salary.
     */


    /*
     * ============================================================
     * TASK 6: CONCEPT QUESTIONS
     * ============================================================
     *
     * Answer the following questions in your own words.
     *
     * 1. What is a data structure?
     *
     * 2. Why are data structures important?
     *
     * 3. What is the difference between a data structure
     *    and a database?
     *
     * 4. What is a linear data structure?
     *
     * 5. What is a non-linear data structure?
     *
     * 6. What is the main advantage of an array?
     *
     * 7. What is the main disadvantage of an array?
     *
     * 8. Why can linked lists be better than arrays
     *    for insertion and deletion?
     *
     * 9. What does LIFO mean?
     *
     * 10. What does FIFO mean?
     *
     * 11. What is an Abstract Data Type?
     *
     * 12. What is an abstract class in C#?
     *
     * 13. Why can we not create an object directly from
     *     an abstract class?
     *
     * 14. What is method overriding?
     *
     * 15. What is polymorphism?
     */


    /*
     * ============================================================
     * CHALLENGE TASK
     * ============================================================
     *
     * Think About It:
     *
     * You are designing a simple school system.
     *
     * Choose the best concept or structure for each situation
     * and explain why.
     *
     * Situations:
     *
     * 1. You need to store student grades that will not change.
     *
     * 2. You need to manage students waiting in line
     *    for assistance.
     *
     * 3. You need to create an Undo button.
     *
     * 4. You need to frequently insert and remove students
     *    from a collection.
     *
     * 5. You need to create a common blueprint for different
     *    types of users such as Student, Teacher, and Admin.
     *
     * Write your answers clearly and justify your choices.
     */
}
```
