```csharp
/*
 * ============================================================
 * File: Notes.cs
 * Path: 01-INTRODUCTIONS/07-DATA-STRUCTURES/Notes.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace DataStructuresNotes
{
    /*
     * ============================================================
     * DATA STRUCTURES - THEORY NOTES
     * ============================================================
     */

    /*
     * WHAT IS A DATA STRUCTURE?
     *
     * A data structure is a way to store, organize, process,
     * and manage information in memory.
     *
     * Unlike databases or files, data structures exist in RAM
     * while the program is running.
     *
     * A simple variable stores a single value:
     *
     *     string name = "John";
     *     double score = 78.9;
     *
     * However, data structures can store collections of data:
     *
     *     - Multiple strings
     *     - Multiple numbers
     *     - A combination of different values
     *
     * The way data is organized affects:
     *
     *     • Memory usage
     *     • Speed of access
     *     • Speed of insertion
     *     • Speed of deletion
     *     • Search efficiency
     *     • Relationships between elements
     *
     * No data structure is universally better than another.
     * Each one is designed for specific situations.
     */


    /*
     * ============================================================
     * WHY ARE DATA STRUCTURES IMPORTANT?
     * ============================================================
     *
     * Think about organizing clothes in a closet.
     *
     * You could organize them:
     *
     *     • By color
     *     • By season
     *     • By outfit
     *     • By type of clothing
     *
     * Each method has advantages and disadvantages.
     *
     * Example:
     *
     * Organizing clothes by outfit makes it easy to choose
     * what to wear, but adding new clothes may take longer.
     *
     * Data structures work the same way.
     *
     * Choosing the right structure depends on the problem
     * you are trying to solve.
     */


    /*
     * ============================================================
     * DATA STRUCTURES VS DATABASES
     * ============================================================
     *
     * Data Structures:
     *
     *     • Exist in RAM.
     *     • Used while the program executes.
     *     • Temporary.
     *
     * Databases:
     *
     *     • Stored permanently.
     *     • Saved on disks.
     *     • Survive after the program closes.
     */


    /*
     * ============================================================
     * CLASSIFICATION OF DATA STRUCTURES
     * ============================================================
     *
     * Data structures can be classified into:
     *
     *     1. Linear Data Structures
     *     2. Non-Linear Data Structures
     */


    /*
     * ============================================================
     * LINEAR DATA STRUCTURES
     * ============================================================
     *
     * Elements are stored sequentially,
     * one after another.
     *
     * Examples:
     *
     *     • Arrays
     *     • Linked Lists
     *     • Stacks
     *     • Queues
     *
     * They may be:
     *
     * Static:
     *     Fixed size.
     *
     * Dynamic:
     *     Size can grow or shrink.
     */


    /*
     * ============================================================
     * NON-LINEAR DATA STRUCTURES
     * ============================================================
     *
     * Elements are NOT stored sequentially.
     *
     * Relationships between elements are more complex.
     *
     * Examples:
     *
     *     • Trees
     *     • Graphs
     *
     * Traversing and managing these structures is usually
     * more complicated than linear structures.
     */


    /*
     * ============================================================
     * ARRAYS
     * ============================================================
     *
     * An array is a collection of elements of the same type
     * stored in contiguous memory locations.
     *
     * Characteristics:
     *
     *     • Fixed size.
     *     • Fast access by index.
     *     • Efficient for reading data.
     *     • Difficult to resize.
     *
     * Example:
     *
     *     int[] numbers = { 10, 20, 30 };
     *
     * Access:
     *
     *     numbers[0] → 10
     *     numbers[1] → 20
     *
     * Advantages:
     *
     *     • Very fast access.
     *
     * Disadvantages:
     *
     *     • Cannot easily add or remove elements.
     */


    /*
     * ============================================================
     * LINKED LISTS
     * ============================================================
     *
     * Linked lists do not store elements next to each other
     * in memory.
     *
     * Each element contains:
     *
     *     • Data
     *     • A reference to the next element
     *
     * Advantages:
     *
     *     • Easy insertion.
     *     • Easy deletion.
     *
     * Disadvantages:
     *
     *     • Slower access.
     *     • Must traverse from the beginning.
     */


    /*
     * ============================================================
     * STACKS
     * ============================================================
     *
     * A stack follows the LIFO principle:
     *
     *     Last In, First Out
     *
     * The last element inserted is the first one removed.
     *
     * Example:
     *
     * Stack of plates:
     *
     *     Add:
     *         Plate A
     *         Plate B
     *         Plate C
     *
     * Remove:
     *         Plate C
     *         Plate B
     *         Plate A
     *
     * Common Uses:
     *
     *     • Undo operations
     *     • Browser history
     *     • Function calls
     */


    /*
     * ============================================================
     * QUEUES
     * ============================================================
     *
     * A queue follows the FIFO principle:
     *
     *     First In, First Out
     *
     * The first element inserted is the first removed.
     *
     * Example:
     *
     * People waiting in line:
     *
     *     Person A enters.
     *     Person B enters.
     *     Person C enters.
     *
     * Leaving order:
     *
     *     Person A
     *     Person B
     *     Person C
     *
     * Common Uses:
     *
     *     • Printing jobs
     *     • Customer service systems
     *     • Task scheduling
     */


    /*
     * ============================================================
     * ABSTRACT DATA TYPES (ADT)
     * ============================================================
     *
     * An Abstract Data Type defines WHAT an object can do,
     * without specifying HOW it does it.
     *
     * It describes behavior.
     *
     * Examples:
     *
     *     • Stack
     *     • Queue
     *     • List
     *
     * In C#, ADTs are commonly represented using
     * abstract classes.
     */


    /*
     * ============================================================
     * ABSTRACT CLASSES IN C#
     * ============================================================
     *
     * An abstract class:
     *
     *     • Cannot be instantiated.
     *     • Serves as a blueprint.
     *     • May contain abstract methods.
     *     • May contain implemented methods.
     *
     * Abstract methods:
     *
     *     • Have no body.
     *     • Must be implemented by derived classes.
     *
     * Example:
     *
     * public abstract class Animal
     * {
     *     public abstract void MakeSound();
     * }
     *
     * public class Dog : Animal
     * {
     *     public override void MakeSound()
     *     {
     *         Console.WriteLine("Woof!");
     *     }
     * }
     */


    /*
     * ============================================================
     * KEY TAKEAWAYS
     * ============================================================
     *
     * • Data structures organize information in memory.
     *
     * • Different structures solve different problems.
     *
     * • Linear structures store data sequentially.
     *
     * • Non-linear structures organize data differently.
     *
     * • Arrays provide fast access.
     *
     * • Linked lists provide flexibility.
     *
     * • Stacks use LIFO.
     *
     * • Queues use FIFO.
     *
     * • Abstract Data Types describe behavior.
     *
     * • Abstract classes help implement ADTs in C#.
     *
     * Understanding these concepts provides the
     * foundation for learning advanced data structures.
     */
}
```
