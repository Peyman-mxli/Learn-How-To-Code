/*
=========================================================
NOTES.CS
Module: 07-DATA-STRUCTURES
Topic: 04-QUEUES
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;

namespace QueuesNotes
{
    /*
    =========================================================
    QUEUES IN C#
    =========================================================

    A Queue is a linear data structure that follows the
    FIFO principle:

        FIFO = First In, First Out

    The first element added to the queue is the first
    element removed.

    Think of a queue like people waiting in line:

        Person A enters.
        Person B enters.
        Person C enters.

        Service order:
        A → B → C

    =========================================================
    REAL-LIFE EXAMPLES
    =========================================================

    • Customers waiting at a supermarket.
    • Patients waiting in a hospital.
    • Cars waiting at a traffic light.
    • Print jobs waiting to be printed.
    • Call center waiting systems.

    =========================================================
    QUEUE<T>
    =========================================================

    C# provides the generic Queue<T> class inside:

        System.Collections.Generic

    Syntax:

        Queue<int> numbers = new Queue<int>();

    The <T> represents the type of data stored.

    Examples:

        Queue<int>
        Queue<string>
        Queue<double>
        Queue<Patient>

    =========================================================
    MAIN OPERATIONS
    =========================================================
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== QUEUES NOTES ===");
            Console.WriteLine();

            Console.WriteLine("FIFO = First In, First Out");
            Console.WriteLine();

            /*
            -------------------------------------------------
            ENQUEUE()
            -------------------------------------------------

            Adds an element to the END of the queue.

            Example:

                Queue:
                Front -> [10] [20]

                Enqueue(30)

                Front -> [10] [20] [30]
            */

            Console.WriteLine("Enqueue() → Adds an item to the end.");

            /*
            -------------------------------------------------
            DEQUEUE()
            -------------------------------------------------

            Removes and returns the FIRST element.

            Example:

                Front -> [10] [20] [30]

                Dequeue()

                Returns: 10

                Queue becomes:

                Front -> [20] [30]
            */

            Console.WriteLine("Dequeue() → Removes the first item.");

            /*
            -------------------------------------------------
            PEEK()
            -------------------------------------------------

            Returns the first element WITHOUT removing it.

            Example:

                Front -> [10] [20] [30]

                Peek()

                Returns: 10

                Queue remains unchanged.
            */

            Console.WriteLine("Peek() → Views the first item.");

            /*
            -------------------------------------------------
            COUNT
            -------------------------------------------------

            Returns the number of elements stored.

            Example:

                Queue:
                [10] [20] [30]

                Count = 3
            */

            Console.WriteLine("Count → Number of elements.");

            /*
            -------------------------------------------------
            CLEAR()
            -------------------------------------------------

            Removes all elements.

            Example:

                Before:
                [10] [20] [30]

                Clear()

                After:
                Empty Queue
            */

            Console.WriteLine("Clear() → Removes all items.");

            Console.WriteLine();

            /*
            =================================================
            FIFO VISUALIZATION
            =================================================

            Enqueue("A")
            Enqueue("B")
            Enqueue("C")

            Queue:

            Front
              ↓
            [A] [B] [C]
                     ↑
                    Rear

            Dequeue()

            Front
              ↓
            [B] [C]
                 ↑
                Rear

            =================================================
            ADVANTAGES OF QUEUES
            =================================================

            • Easy to understand.
            • Efficient insertion and removal.
            • Ideal for sequential processing.
            • Useful in scheduling systems.

            =================================================
            LIMITATIONS
            =================================================

            • No direct access to middle elements.
            • Access is restricted to the front.
            • Searching is slower than some structures.

            =================================================
            WHEN SHOULD I USE A QUEUE?
            =================================================

            Use a queue when:

            • Order matters.
            • The oldest item should be processed first.
            • Tasks arrive continuously.
            • Waiting lines must be simulated.

            =================================================
            SUMMARY
            =================================================

            Queue = FIFO

            Enqueue() → Add to rear.
            Dequeue() → Remove from front.
            Peek()    → View front element.
            Count     → Total elements.
            Clear()   → Remove everything.

            =================================================
            */

            Console.WriteLine("Queue Summary:");
            Console.WriteLine("FIFO = First In, First Out");
            Console.WriteLine("Enqueue → Add");
            Console.WriteLine("Dequeue → Remove");
            Console.WriteLine("Peek → View");
            Console.WriteLine("Count → Total");
            Console.WriteLine("Clear → Empty");

            Console.WriteLine();
            Console.WriteLine("End of Notes.");
        }
    }
}
