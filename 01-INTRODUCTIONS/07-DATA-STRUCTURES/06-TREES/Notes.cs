/*
=========================================================
NOTES.CS
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

namespace TreesNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TREES NOTES ===");
            Console.WriteLine();

            /*
            =========================================================
            WHAT IS A TREE?
            =========================================================

            A tree is a hierarchical data structure made up
            of nodes connected by relationships.

            Unlike arrays, lists, stacks, and queues,
            trees are NOT linear.

            Trees branch into multiple paths.

            Example:

                      A
                    / | \
                   B  C  D
                  / \
                 E   F

            =========================================================
            BASIC TREE TERMINOLOGY
            =========================================================
            */

            Console.WriteLine("Tree Terminology");
            Console.WriteLine();

            /*
            ---------------------------------------------------------
            ROOT NODE
            ---------------------------------------------------------

            The first node of the tree.

            Example:

                      A

            A is the root node.
            */

            Console.WriteLine("Root Node → Starting point of the tree.");

            /*
            ---------------------------------------------------------
            LEAF NODE
            ---------------------------------------------------------

            A node without children.

            Example:

                      A
                    / | \
                   B  C  D
                  / \
                 E   F

            Leaf Nodes:
                E, F, C, D
            */

            Console.WriteLine("Leaf Node → Node without children.");

            /*
            ---------------------------------------------------------
            INTERNAL NODE
            ---------------------------------------------------------

            A node that has children.

            Example:

                A and B

            are internal nodes.
            */

            Console.WriteLine("Internal Node → Node with children.");

            /*
            ---------------------------------------------------------
            TREE LEVEL
            ---------------------------------------------------------

            Level indicates the position of a node.

            Example:

                      A          Level 1
                    / | \
                   B  C  D       Level 2
                  / \
                 E   F           Level 3

            The maximum level determines the level of the tree.

            This tree has 3 levels.
            */

            Console.WriteLine("Tree Level → Position of a node.");

            /*
            ---------------------------------------------------------
            DEGREE OF A NODE
            ---------------------------------------------------------

            The number of children a node has.

            Example:

                      A
                    / | \
                   B  C  D
                  / \
                 E   F

            Degree of A = 3
            Degree of B = 2
            Degree of C = 0
            */

            Console.WriteLine("Node Degree → Number of children.");

            /*
            ---------------------------------------------------------
            DEGREE OF A TREE
            ---------------------------------------------------------

            The highest node degree found in the tree.

            Example:

                Degree of Tree = 3
            */

            Console.WriteLine("Tree Degree → Maximum node degree.");

            /*
            ---------------------------------------------------------
            PATH LENGTH
            ---------------------------------------------------------

            The number of levels needed to reach a node
            from the root.

            Root path length = 1.

            Example:

                      A          Path Length 1
                    / | \
                   B  C  D       Path Length 2
                  / \
                 E   F           Path Length 3
            */

            Console.WriteLine("Path Length → Distance from root.");

            /*
            ---------------------------------------------------------
            BINARY TREE
            ---------------------------------------------------------

            A binary tree allows each node to have
            at most TWO children.

            Left Child
            Right Child

            Example:

                     10
                    /  \
                   5   15
                  / \    \
                 2   7   20
            */

            Console.WriteLine("Binary Tree → Maximum of 2 children.");

            Console.WriteLine();

            /*
            =========================================================
            COMMON TREE OPERATIONS
            =========================================================
            */

            Console.WriteLine("Common Operations");
            Console.WriteLine();

            /*
            ---------------------------------------------------------
            INSERTION
            ---------------------------------------------------------

            Adds a new node to the tree.
            */

            Console.WriteLine("Insertion → Add a node.");

            /*
            ---------------------------------------------------------
            SEARCH
            ---------------------------------------------------------

            Finds a specific value inside the tree.
            */

            Console.WriteLine("Search → Find a value.");

            /*
            ---------------------------------------------------------
            DELETION
            ---------------------------------------------------------

            Removes a node from the tree.
            */

            Console.WriteLine("Deletion → Remove a node.");

            /*
            ---------------------------------------------------------
            HEIGHT
            ---------------------------------------------------------

            Calculates the maximum number of levels
            in the tree.

            Example:

                     10
                    /  \
                   5   15
                  / \    \
                 2   7   20

            Height = 3
            */

            Console.WriteLine("Height → Maximum depth.");

            Console.WriteLine();

            /*
            =========================================================
            TREE TRAVERSALS
            =========================================================

            Example Tree:

                     50
                    /  \
                  30    70
                 / \   / \
               20 40 60 80

            =========================================================
            INORDER
            =========================================================

            Left → Root → Right

            Result:

            20 30 40 50 60 70 80

            Useful because BST values appear sorted.
            */

            Console.WriteLine("Inorder:");
            Console.WriteLine("Left → Root → Right");

            /*
            =========================================================
            PREORDER
            =========================================================

            Root → Left → Right

            Result:

            50 30 20 40 70 60 80

            Useful for copying trees.
            */

            Console.WriteLine("Preorder:");
            Console.WriteLine("Root → Left → Right");

            /*
            =========================================================
            POSTORDER
            =========================================================

            Left → Right → Root

            Result:

            20 40 30 60 80 70 50

            Useful for deleting trees.
            */

            Console.WriteLine("Postorder:");
            Console.WriteLine("Left → Right → Root");

            Console.WriteLine();

            /*
            =========================================================
            ADVANTAGES OF TREES
            =========================================================

            • Efficient searching.
            • Natural hierarchical representation.
            • Dynamic structure.
            • Fast insertion in BSTs.
            • Useful in many computer systems.
            */

            Console.WriteLine("Advantages:");
            Console.WriteLine("- Hierarchical organization");
            Console.WriteLine("- Efficient searching");
            Console.WriteLine("- Dynamic growth");

            /*
            =========================================================
            LIMITATIONS OF TREES
            =========================================================

            • More complex than linear structures.
            • Can become unbalanced.
            • Recursive algorithms can be harder to understand.
            */

            Console.WriteLine();
            Console.WriteLine("Limitations:");
            Console.WriteLine("- More complex");
            Console.WriteLine("- May become unbalanced");

            /*
            =========================================================
            SUMMARY
            =========================================================

            Tree             → Hierarchical structure
            Root             → Starting node
            Leaf             → Node without children
            Internal Node    → Node with children
            Degree           → Number of children
            Binary Tree      → Maximum 2 children
            Search           → Find values
            Height           → Maximum depth
            Inorder          → Left Root Right
            Preorder         → Root Left Right
            Postorder        → Left Right Root
            =========================================================
            */

            Console.WriteLine();
            Console.WriteLine("End of Notes.");
        }
    }
}
