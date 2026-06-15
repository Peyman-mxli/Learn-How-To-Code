/*
=========================================================
EXAMPLES.CS
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

namespace TreesExamples
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private Node InsertRecursive(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRecursive(node.Right, value);
            }

            return node;
        }

        public void InorderTraversal()
        {
            Console.Write("Inorder: ");
            InorderRecursive(root);
            Console.WriteLine();
        }

        private void InorderRecursive(Node node)
        {
            if (node != null)
            {
                InorderRecursive(node.Left);
                Console.Write(node.Value + " ");
                InorderRecursive(node.Right);
            }
        }

        public void PreorderTraversal()
        {
            Console.Write("Preorder: ");
            PreorderRecursive(root);
            Console.WriteLine();
        }

        private void PreorderRecursive(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreorderRecursive(node.Left);
                PreorderRecursive(node.Right);
            }
        }

        public void PostorderTraversal()
        {
            Console.Write("Postorder: ");
            PostorderRecursive(root);
            Console.WriteLine();
        }

        private void PostorderRecursive(Node node)
        {
            if (node != null)
            {
                PostorderRecursive(node.Left);
                PostorderRecursive(node.Right);
                Console.Write(node.Value + " ");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Example1_ManualBinaryTree();

            Console.WriteLine("\nPress ENTER for Example 2...");
            Console.ReadLine();

            Example2_BinarySearchTreeTraversals();

            Console.WriteLine("\nEnd of tree examples.");
        }

        public static void Example1_ManualBinaryTree()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 1: MANUAL BINARY TREE ===\n");

            Node root = new Node(10);

            root.Left = new Node(5);
            root.Right = new Node(15);

            root.Left.Left = new Node(2);
            root.Left.Right = new Node(7);
            root.Right.Right = new Node(20);

            Console.WriteLine("Tree created manually.");
            Console.WriteLine();

            Console.WriteLine("Tree structure:");
            Console.WriteLine("        10");
            Console.WriteLine("       /  \\");
            Console.WriteLine("      5    15");
            Console.WriteLine("     / \\     \\");
            Console.WriteLine("    2   7     20");

            Console.WriteLine();

            Console.WriteLine("Root value: " + root.Value);
            Console.WriteLine("Left child of root: " + root.Left.Value);
            Console.WriteLine("Right child of root: " + root.Right.Value);
            Console.WriteLine("Left-left child: " + root.Left.Left.Value);
            Console.WriteLine("Left-right child: " + root.Left.Right.Value);
            Console.WriteLine("Right-right child: " + root.Right.Right.Value);
        }

        public static void Example2_BinarySearchTreeTraversals()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 2: BINARY SEARCH TREE TRAVERSALS ===\n");

            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("Inserted values:");
            Console.WriteLine("50, 30, 20, 40, 70, 60, 80");

            Console.WriteLine();

            Console.WriteLine("Tree structure:");
            Console.WriteLine("          50");
            Console.WriteLine("        /    \\");
            Console.WriteLine("      30      70");
            Console.WriteLine("     /  \\    /  \\");
            Console.WriteLine("   20   40  60   80");

            Console.WriteLine();

            tree.InorderTraversal();
            tree.PreorderTraversal();
            tree.PostorderTraversal();

            Console.WriteLine();

            Console.WriteLine("Expected output:");
            Console.WriteLine("Inorder: 20 30 40 50 60 70 80");
            Console.WriteLine("Preorder: 50 30 20 40 70 60 80");
            Console.WriteLine("Postorder: 20 40 30 60 80 70 50");
        }
    }
}
