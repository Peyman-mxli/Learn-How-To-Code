using System;

namespace SortingAlgorithmsNotes
{
    /*
     * ==========================================================
     * 02 - SORTING ALGORITHMS
     * ==========================================================
     *
     * WHAT IS A SORTING ALGORITHM?
     *
     * A sorting algorithm is a method used to arrange data
     * in a specific order.
     *
     * Usually:
     * - Smallest to largest (Ascending)
     * - Largest to smallest (Descending)
     *
     * Examples from everyday life:
     *
     * - Organizing books alphabetically.
     * - Sorting exam grades.
     * - Arranging contacts by name.
     * - Ordering products by price.
     *
     * ==========================================================
     * WHY IS SORTING IMPORTANT?
     * ==========================================================
     *
     * - Makes searching faster.
     * - Makes data easier to understand.
     * - Improves application performance.
     * - Used in databases and websites.
     *
     * ==========================================================
     * BUBBLE SORT
     * ==========================================================
     *
     * Bubble Sort repeatedly compares adjacent elements
     * and swaps them if they are in the wrong order.
     *
     * Example:
     *
     * 5 3 8 1
     *
     * Pass 1:
     * 5 3 -> swap
     * 3 5 8 1
     *
     * 5 8 -> no swap
     *
     * 8 1 -> swap
     * 3 5 1 8
     *
     * Continue until sorted.
     *
     * Advantages:
     * - Very easy to understand.
     *
     * Disadvantages:
     * - Slow for large datasets.
     *
     * Time Complexity:
     * Worst Case: O(n²)
     *
     * ==========================================================
     * SELECTION SORT
     * ==========================================================
     *
     * Selection Sort repeatedly selects the smallest
     * element from the unsorted portion and places it
     * in its correct position.
     *
     * Example:
     *
     * 64 25 12 22 11
     *
     * Smallest = 11
     *
     * 11 25 12 22 64
     *
     * Continue until sorted.
     *
     * Time Complexity:
     * Worst Case: O(n²)
     *
     * ==========================================================
     * INSERTION SORT
     * ==========================================================
     *
     * Insertion Sort builds the sorted list one element
     * at a time.
     *
     * Similar to arranging playing cards in your hand.
     *
     * Example:
     *
     * 5 2 4 6 1
     *
     * Insert each element into its proper position.
     *
     * Time Complexity:
     * Worst Case: O(n²)
     *
     * ==========================================================
     * COMPARISON
     * ==========================================================
     *
     * Bubble Sort:
     * - Simple
     * - Many swaps
     *
     * Selection Sort:
     * - Fewer swaps
     * - Still O(n²)
     *
     * Insertion Sort:
     * - Efficient for small datasets
     * - Good for nearly sorted data
     *
     * ==========================================================
     * AUTHOR
     * ==========================================================
     *
     * Name: Peyman Miyandashti
     * University: Polytechnic University of Baja California
     * Program: Information Technology Engineering & Digital Innovation
     * Origin: IRAN (Mexico)
     * Year: 2026
     *
     */

    internal class Notes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02 - Sorting Algorithms Notes");
            Console.WriteLine("Study the comments in this file to learn the concepts.");
        }
    }
}
