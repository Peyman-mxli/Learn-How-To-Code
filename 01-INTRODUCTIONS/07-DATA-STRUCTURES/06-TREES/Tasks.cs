/*
=========================================================
TASKS.CS
Module: 07-DATA-STRUCTURES
Topic: 06-TREES
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;

namespace TreesTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            =================================================
            EXERCISE 1: SEARCH AND TREE HEIGHT
            =================================================

            Objective:
            Modify the binary search tree example to add two
            new methods:

            1. Search for a specific value.
            2. Calculate the height of the tree.

            Instructions:

            1. Use the BinarySearchTree class from Examples.cs.

            2. Add this public method:

               public bool Search(int value)

               This method must return:

               true  → if the value exists in the tree
               false → if the value does not exist in the tree

            3. Add a private recursive method:

               private bool SearchRecursive(Node node, int value)

            4. Search rules:

               - If the current node is null, return false.
               - If value equals node.Value, return true.
               - If value is less than node.Value, search left.
               - If value is greater than node.Value, search right.

            5. Add this public method:

               public int CalculateHeight()

               This method must return the maximum height of the tree.

            6. Add a private recursive method:

               private int CalculateHeightRecursive(Node node)

            7. Height rules:

               - If the node is null, return 0.
               - Calculate the height of the left subtree.
               - Calculate the height of the right subtree.
               - Return the bigger height plus 1.

            8. In Main(), insert these values:

               50, 30, 20, 40, 70, 60, 80

            9. Test Search() with:

               40 → should return true
               99 → should return false

            10. Test CalculateHeight().

            Expected output:

               Does value 40 exist? True
               Does value 99 exist? False
               Tree height: 3

            Concepts:
            Binary search tree, recursion, search, height.
            */

            Console.WriteLine("Trees Tasks");
            Console.WriteLine("Complete the exercise above.");
        }
    }
}
