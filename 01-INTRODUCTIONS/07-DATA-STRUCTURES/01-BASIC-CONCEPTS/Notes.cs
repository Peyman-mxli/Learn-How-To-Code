```csharp
/*
 * ============================================================
 * File: Notes.cs
 * Path: 07-DATA-STRUCTURES/01-BASIC-CONCEPTS/Notes.cs
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
     * BASIC CONCEPTS OF DATA STRUCTURES
     * ============================================================
     *
     * Data Structures are one of the most important topics in
     * computer science because they determine how information
     * is stored, organized, processed, and retrieved.
     *
     * Choosing the appropriate data structure allows programs
     * to become more efficient and easier to maintain.
     */


    /*
     * ============================================================
     * WHAT IS A DATA STRUCTURE?
     * ============================================================
     *
     * A data structure is a storage mechanism used to organize,
     * process, and manage information while a program is running.
     *
     * Unlike databases or files, data structures live in the
     * computer's RAM and exist only while the application
     * is executing.
     *
     * A simple variable stores only one value:
     *
     *     string name = "John";
     *     double score = 78.9;
     *
     * Data structures, however, can store collections of values.
     *
     * Examples:
     *
     *     • Multiple strings
     *     • Multiple numbers
     *     • Objects
     *     • Different pieces of related information
     *
     * The way information is stored affects:
     *
     *     • Memory usage
     *     • Speed of access
     *     • Speed of insertion
     *     • Speed of deletion
     *     • Search efficiency
     *     • Relationships among elements
     */


    /*
     * ============================================================
     * WHY ARE DATA STRUCTURES IMPORTANT?
     * ============================================================
     *
     * Imagine organizing clothes inside a closet.
     *
     * You could organize them:
     *
     *     • By color
     *     • By season
     *     • By outfit
     *     • By type of clothing
     *
     * Each organization method has advantages
     * and disadvantages.
     *
     * Example:
     *
     * Organizing clothes by outfit makes it easier
     * to choose what to wear, but adding new clothes
     * becomes more difficult.
     *
     * Data structures work exactly the same way.
     *
     * No data structure is universally better than
     * another. Each one is designed to solve
     * different problems efficiently.
     */


    /*
     * ============================================================
     * DATA STRUCTURES VS DATABASES AND FILES
     * ============================================================
     *
     * Data Structures:
     *
     *     • Exist in RAM.
     *     • Temporary.
     *     • Used while programs execute.
     *     • Optimized for processing information.
     *
     * Databases:
     *
     *     • Stored permanently.
     *     • Saved on storage devices.
     *     • Remain after the program closes.
     *     • Designed for long-term persistence.
     *
     * Files:
     *
     *     • Stored on disks.
     *     • Used to save information permanently.
     *     • Can be accessed by different applications.
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
     * Linear structures store elements sequentially,
     * one after another.
     *
     * Examples:
     *
     *     • Arrays
     *     • Linked Lists
     *     • Stacks
     *     • Queues
     *
     * Linear structures can be:
     *
     * Static:
     *
     *     Fixed memory size.
     *
     * Dynamic:
     *
     *     Their size can grow or shrink as
     *     elements are added or removed.
     */


    /*
     * ============================================================
     * NON-LINEAR DATA STRUCTURES
     * ============================================================
     *
     * Non-linear structures do not store elements
     * sequentially.
     *
     * Relationships between elements are more complex.
     *
     * Examples:
     *
     *     • Trees
     *     • Graphs
     *
     * Traversing and managing these structures
     * is generally more complicated than working
     * with linear structures.
     */


    /*
     * ============================================================
     * ARRAYS
     * ============================================================
     *
     * An array is a collection of elements of the
     * same data type stored in contiguous memory.
     *
     * Characteristics:
     *
     *     • Fixed size.
     *     • Same data type.
     *     • Fast access by index.
     *     • Efficient for reading information.
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
     *     • Simple to use.
     *
     * Disadvantages:
     *
     *     • Difficult to resize.
     *     • Inserting and deleting elements
     *       can be inefficient.
     */


    /*
     * ============================================================
     * LINKED LISTS
     * ============================================================
     *
     * Unlike arrays, linked lists do not store
     * elements next to each other in memory.
     *
     * Each node contains:
     *
     *     • Data
     *     • A reference to the next node
     *
     * To access an element, the list must be
     * traversed from the beginning.
     *
     * Advantages:
     *
     *     • Easy insertion.
     *     • Easy deletion.
     *     • Dynamic size.
     *
     * Disadvantages:
     *
     *     • Slower access.
     *     • Sequential traversal required.
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
     * The last element added is the first one removed.
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
     * Waiting line:
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
     *     • Printing systems
     *     • Customer service
     *     • Task scheduling
     */


    /*
     * ============================================================
     * ABSTRACT DATA TYPES (ADT)
     * ============================================================
     *
     * An Abstract Data Type defines WHAT an object
     * can do without describing HOW it does it.
     *
     * It specifies behavior rather than implementation.
     *
     * Examples:
     *
     *     • Stack
     *     • Queue
     *     • List
     *
     * In C#, ADTs are commonly implemented using
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
     *     public abstract class Animal
     *     {
     *         public abstract void MakeSound();
     *     }
     *
     *     public class Dog : Animal
     *     {
     *         public override void MakeSound()
     *         {
     *             Console.WriteLine("Woof!");
     *         }
     *     }
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
     * • Choosing the correct structure improves efficiency.
     *
     * • Linear structures store data sequentially.
     *
     * • Non-linear structures organize data differently.
     *
     * • Arrays provide fast access.
     *
     * • Linked lists provide flexibility.
     *
     * • Stacks use the LIFO principle.
     *
     * • Queues use the FIFO principle.
     *
     * • Abstract Data Types define behavior.
     *
     * • Abstract classes help implement ADTs in C#.
     *
     * Understanding these concepts provides the
     * foundation for learning advanced data structures.
     */
}
```
