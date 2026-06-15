```csharp
/*
 * ============================================================
 * File: Tasks.cs
 * Path: 01-INTRODUCTIONS/07-DATA-STRUCTURES/Tasks.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace DataStructuresTasks
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
     * 2. Add an abstract method named Start().
     *
     * 3. Create two classes that inherit from Vehicle:
     *      • Car
     *      • Bicycle
     *
     * 4. Implement the Start() method:
     *
     *      Car:
     *          Print:
     *          "Car starting."
     *
     *      Bicycle:
     *          Print:
     *          "Bicycle starting."
     *
     * 5. In Main():
     *
     *      • Create instances of Car and Bicycle.
     *      • Call Start() on each object.
     *
     * Expected Output:
     *
     *      Car starting.
     *      Bicycle starting.
     *
     */


    /*
     * ============================================================
     * TASK 2: GEOMETRIC SHAPES
     * ============================================================
     *
     * Description:
     *
     * Create a class hierarchy to represent
     * different geometric shapes.
     *
     * Instructions:
     *
     * 1. Create an abstract class called Shape.
     *
     * 2. Add the following abstract methods:
     *
     *      • CalculateArea()
     *      • CalculatePerimeter()
     *
     * 3. Create the following derived classes:
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
     *      Use Heron's Formula to calculate the area.
     *
     *          s = perimeter / 2
     *
     *          Area =
     *          √(s(s-a)(s-b)(s-c))
     *
     * 7. In Main():
     *
     *      • Create one object of each shape.
     *      • Assign values.
     *      • Display the area.
     *      • Display the perimeter.
     *
     */


    /*
     * ============================================================
     * TASK 3: ARRAY PRACTICE
     * ============================================================
     *
     * Instructions:
     *
     * 1. Create an integer array containing
     *    5 student grades.
     *
     * 2. Display:
     *
     *      • The first grade.
     *      • The last grade.
     *      • All grades using a loop.
     *
     * 3. Calculate the average grade.
     *
     * Example:
     *
     *      Grades:
     *      85, 90, 78, 92, 88
     *
     */


    /*
     * ============================================================
     * TASK 4: STACK PRACTICE
     * ============================================================
     *
     * Instructions:
     *
     * 1. Create a Stack<string>.
     *
     * 2. Push the names of 4 books.
     *
     * 3. Display the book that is on top
     *    using Peek().
     *
     * 4. Remove all books using Pop().
     *
     * 5. Display each removed book.
     *
     * Objective:
     *
     * Understand the LIFO principle:
     *
     *      Last In, First Out.
     *
     */


    /*
     * ============================================================
     * TASK 5: QUEUE PRACTICE
     * ============================================================
     *
     * Instructions:
     *
     * 1. Create a Queue<string>.
     *
     * 2. Add the names of 4 customers.
     *
     * 3. Display the first customer
     *    using Peek().
     *
     * 4. Serve all customers using Dequeue().
     *
     * 5. Display each customer's name.
     *
     * Objective:
     *
     * Understand the FIFO principle:
     *
     *      First In, First Out.
     *
     */


    /*
     * ============================================================
     * CHALLENGE TASK
     * ============================================================
     *
     * Think About It:
     *
     * You are developing a school management system.
     *
     * Which data structure would you choose
     * for each situation?
     *
     * Explain WHY.
     *
     * Situations:
     *
     * 1. Storing student grades that never change.
     *
     * 2. Managing the order of students waiting
     *    for assistance.
     *
     * 3. Implementing an Undo button.
     *
     * 4. Managing a list of students where
     *    students frequently enroll and withdraw.
     *
     * 5. Creating a common blueprint for
     *    different employee types.
     *
     * Write your answers and justify your choices.
     *
     */
}
```
