using System;

namespace SearchingAlgorithmsNotes
{
    /*
     * ==========================================================
     * 01 - SEARCHING ALGORITHMS
     * ==========================================================
     *
     * WHAT IS A SEARCHING ALGORITHM?
     *
     * A searching algorithm is a method used to find a specific
     * element inside a collection of data.
     *
     * Examples from everyday life:
     *
     * - Looking for a friend's name in your contacts.
     * - Finding a book in a library.
     * - Searching for a product in an online store.
     *
     * ==========================================================
     * LINEAR SEARCH
     * ==========================================================
     *
     * Linear Search checks each element one by one until:
     *
     * 1. The target is found.
     * 2. The end of the collection is reached.
     *
     * Example:
     *
     * Numbers: [10, 25, 7, 40, 15]
     * Target: 40
     *
     * Step 1: Check 10 → Not found
     * Step 2: Check 25 → Not found
     * Step 3: Check 7  → Not found
     * Step 4: Check 40 → Found
     *
     * Advantages:
     * - Easy to understand.
     * - Works on unsorted data.
     *
     * Disadvantages:
     * - Slow for large collections.
     *
     * Time Complexity:
     * Worst Case: O(n)
     *
     * ==========================================================
     * BINARY SEARCH
     * ==========================================================
     *
     * Binary Search repeatedly divides the search space in half.
     *
     * IMPORTANT:
     * The data MUST be sorted before Binary Search can be used.
     *
     * Example:
     *
     * Numbers: [5, 10, 15, 20, 25, 30, 35]
     * Target: 25
     *
     * Middle = 20
     * 25 > 20 → Search right side
     *
     * Middle = 30
     * 25 < 30 → Search left side
     *
     * Middle = 25
     * Found!
     *
     * Advantages:
     * - Very fast for large sorted collections.
     *
     * Disadvantages:
     * - Requires sorted data.
     *
     * Time Complexity:
     * Worst Case: O(log n)
     *
     * ==========================================================
     * LINEAR SEARCH VS BINARY SEARCH
     * ==========================================================
     *
     * Linear Search:
     * - Works on unsorted data.
     * - Simpler.
     * - Slower.
     *
     * Binary Search:
     * - Requires sorted data.
     * - More efficient.
     * - Faster for large datasets.
     *
     * ==========================================================
     * WHY ARE SEARCHING ALGORITHMS IMPORTANT?
     * ==========================================================
     *
     * - They help find information efficiently.
     * - They improve application performance.
     * - They are used in databases, games,
     *   websites, and mobile applications.
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
            Console.WriteLine("01 - Searching Algorithms Notes");
            Console.WriteLine("Study the comments in this file to learn the concepts.");
        }
    }
}
