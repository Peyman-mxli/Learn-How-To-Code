/*
=========================================================
TASKS_SOLUTIONS.CS
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

namespace TreesTasksSolutions
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

        public bool Search(int value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(Node node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                return SearchRecursive(node.Left, value);
            }
            else
            {
                return SearchRecursive(node.Right, value);
            }
        }

        public int CalculateHeight()
        {
            return CalculateHeightRecursive(root);
        }

        private int CalculateHeightRecursive(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = CalculateHeightRecursive(node.Left);
            int rightHeight = CalculateHeightRecursive(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
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
            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("=== TREE SEARCH AND HEIGHT SOLUTION ===\n");

            Console.WriteLine("Inserted values:");
            Console.WriteLine("50, 30, 20, 40, 70, 60, 80");

            Console.WriteLine();

            tree.InorderTraversal();
            tree.PreorderTraversal();
            tree.PostorderTraversal();

            Console.WriteLine();

            int valueToSearch = 40;
            Console.WriteLine($"Does value {valueToSearch} exist? {tree.Search(valueToSearch)}");

            valueToSearch = 99;
            Console.WriteLine($"Does value {valueToSearch} exist? {tree.Search(valueToSearch)}");

            Console.WriteLine($"Tree height: {tree.CalculateHeight()}");

            Console.WriteLine("\nEnd of tree task solution.");
        }
    }
}
