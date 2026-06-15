/*
=========================================================
NOTES.CS
Module: 07-DATA-STRUCTURES
Topic: 05-STACKS
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;

namespace StacksNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== STACKS NOTES ===");
            Console.WriteLine();

            /*
            =========================================================
            STACKS IN C#
            =========================================================

            A Stack is a linear data structure that follows the
            LIFO principle:

                LIFO = Last In, First Out

            The last element added to the stack is the first
            element removed.

            Think of a stack of plates:

                    ┌─────┐
                    │ 30  │ ← Top
                    ├─────┤
                    │ 20  │
                    ├─────┤
                    │ 10  │
                    └─────┘

            The last plate placed on top is the first one removed.

            =========================================================
            REAL-LIFE EXAMPLES
            =========================================================

            • Stack of plates.
            • Browser Back button history.
            • Undo/Redo functionality.
            • Function calls in programs.
            • Text editor actions.
            • Expression evaluation.

            =========================================================
            STACK<T>
            =========================================================

            C# provides the generic Stack<T> class inside:

                System.Collections.Generic

            Syntax:

                Stack<int> numbers = new Stack<int>();

            The <T> represents the type of data stored.

            Examples:

                Stack<int>
                Stack<string>
                Stack<double>
                Stack<char>

            =========================================================
            MAIN OPERATIONS
            =========================================================
            */

            Console.WriteLine("LIFO = Last In, First Out");
            Console.WriteLine();

            /*
            ---------------------------------------------------------
            PUSH()
            ---------------------------------------------------------

            Adds an element to the TOP of the stack.

            Example:

                Push(10)
                Push(20)
                Push(30)

                    Top
                     ↓
                  [30]
                  [20]
                  [10]
            */

            Console.WriteLine("Push() → Adds an item to the top.");

            /*
            ---------------------------------------------------------
            POP()
            ---------------------------------------------------------

            Removes and returns the TOP element.

            Example:

                    Top
                     ↓
                  [30]
                  [20]
                  [10]

                Pop()

                Returns: 30

                    Top
                     ↓
                  [20]
                  [10]
            */

            Console.WriteLine("Pop() → Removes the top item.");

            /*
            ---------------------------------------------------------
            PEEK()
            ---------------------------------------------------------

            Returns the TOP element WITHOUT removing it.

            Example:

                    Top
                     ↓
                  [30]
                  [20]
                  [10]

                Peek()

                Returns: 30

                Stack remains unchanged.
            */

            Console.WriteLine("Peek() → Views the top item.");

            /*
            ---------------------------------------------------------
            COUNT
            ---------------------------------------------------------

            Returns the number of elements stored.

            Example:

                Stack:
                [30]
                [20]
                [10]

                Count = 3
            */

            Console.WriteLine("Count → Number of elements.");

            /*
            ---------------------------------------------------------
            CLEAR()
            ---------------------------------------------------------

            Removes all elements from the stack.

            Example:

                Before:

                    [30]
                    [20]
                    [10]

                Clear()

                After:

                    Empty Stack
            */

            Console.WriteLine("Clear() → Removes all items.");

            /*
            ---------------------------------------------------------
            IS EMPTY
            ---------------------------------------------------------

            Stack<T> does not provide IsEmpty().

            Instead, use:

                stack.Count == 0

            Example:

                if (stack.Count == 0)
                {
                    Console.WriteLine("Stack is empty.");
                }
            */

            Console.WriteLine("Count == 0 → Checks if stack is empty.");

            Console.WriteLine();

            /*
            =========================================================
            LIFO VISUALIZATION
            =========================================================

            Push("A")
            Push("B")
            Push("C")

                    Top
                     ↓
                   [C]
                   [B]
                   [A]

            Pop()

            Returns: C

                    Top
                     ↓
                   [B]
                   [A]

            =========================================================
            ADVANTAGES OF STACKS
            =========================================================

            • Easy to understand.
            • Fast insertion and removal.
            • Excellent for reversing data.
            • Useful in many programming problems.
            • Efficient Top access.

            =========================================================
            LIMITATIONS OF STACKS
            =========================================================

            • Access is limited to the top element.
            • No direct access to middle elements.
            • Searching can be inefficient.

            =========================================================
            WHEN SHOULD I USE A STACK?
            =========================================================

            Use a stack when:

            • The most recent item should be processed first.
            • You need Undo/Redo behavior.
            • You need Back button functionality.
            • You need to reverse information.
            • You need expression evaluation.

            =========================================================
            SUMMARY
            =========================================================

            Stack = LIFO

            Push()   → Add to top.
            Pop()    → Remove from top.
            Peek()   → View top element.
            Count    → Total elements.
            Clear()  → Remove everything.
            Count==0 → Check if empty.

            =========================================================
            */

            Console.WriteLine("Stack Summary:");
            Console.WriteLine("LIFO = Last In, First Out");
            Console.WriteLine("Push → Add");
            Console.WriteLine("Pop → Remove");
            Console.WriteLine("Peek → View");
            Console.WriteLine("Count → Total");
            Console.WriteLine("Clear → Empty");
            Console.WriteLine("Count == 0 → Is Empty");

            Console.WriteLine();
            Console.WriteLine("End of Notes.");
        }
    }
}
