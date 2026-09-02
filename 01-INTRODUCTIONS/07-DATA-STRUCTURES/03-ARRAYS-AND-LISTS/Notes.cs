```csharp
/*
 * ============================================================
 * File: Notes.cs
 * Path: 07-DATA-STRUCTURES/03-ARRAYS-AND-LISTS/Notes.cs
 * ============================================================
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 * ============================================================
 */

using System;

namespace ArraysAndListsNotes
{
    /*
     * ============================================================
     * ARRAYS
     * ============================================================
     *
     * An array is a data structure that stores multiple
     * values of the same type under a single variable name.
     *
     * Elements are stored sequentially and accessed
     * using an index.
     *
     * Array indexes always start at 0.
     */


    /*
     * ============================================================
     * CHARACTERISTICS OF ARRAYS
     * ============================================================
     *
     * • Fixed size.
     *
     * • All elements must have the same data type.
     *
     * • Access elements by index.
     *
     * • Fast access to individual elements.
     *
     * • Have a Length property.
     */


    /*
     * ============================================================
     * ARRAY DECLARATION
     * ============================================================
     *
     * Examples:
     *
     *     int[] numbers = new int[5];
     *
     *     string[] names =
     *     {
     *         "Ana",
     *         "Luis",
     *         "Carlos"
     *     };
     */


    /*
     * ============================================================
     * ACCESSING ELEMENTS
     * ============================================================
     *
     * Examples:
     *
     *     names[0]
     *
     *     numbers[0] = 10;
     *
     * The first position is always index 0.
     */


    /*
     * ============================================================
     * LENGTH PROPERTY
     * ============================================================
     *
     * Length returns the total number of elements
     * stored in an array.
     *
     * Example:
     *
     *     numbers.Length
     */


    /*
     * ============================================================
     * ARRAY TRAVERSAL
     * ============================================================
     *
     * Arrays can be traversed using:
     *
     * • for
     *
     * • foreach
     *
     * for:
     *     Useful when indexes are needed.
     *
     * foreach:
     *     Simpler when only reading values.
     */


    /*
     * ============================================================
     * ARRAYS: ADVANTAGES
     * ============================================================
     *
     * • Fast access.
     *
     * • Simple structure.
     *
     * • Memory efficient.
     */


    /*
     * ============================================================
     * ARRAYS: DISADVANTAGES
     * ============================================================
     *
     * • Fixed size.
     *
     * • Difficult to insert or remove elements.
     *
     * • All elements must be the same type.
     */


    /*
     * ============================================================
     * LISTS
     * ============================================================
     *
     * A List<T> is similar to an array.
     *
     * The main difference is that lists
     * have a dynamic size.
     *
     * Elements can be added or removed
     * after creation.
     */


    /*
     * ============================================================
     * ARRAYS VS LISTS
     * ============================================================
     *
     * Arrays:
     *
     * • Fixed size.
     * • Faster direct access.
     * • Less flexible.
     *
     * Lists:
     *
     * • Dynamic size.
     * • Easier insertion and deletion.
     * • More flexible.
     */


    /*
     * ============================================================
     * COMMON LIST METHODS
     * ============================================================
     *
     * Add(item)
     *     Adds an element to the end.
     *
     * Insert(index, item)
     *     Inserts an element at a position.
     *
     * Remove(item)
     *     Removes the first matching element.
     *
     * RemoveAt(index)
     *     Removes an element by index.
     *
     * RemoveAll(condition)
     *     Removes all matching elements.
     *
     * Clear()
     *     Removes all elements.
     */


    /*
     * ============================================================
     * SEARCH METHODS
     * ============================================================
     *
     * Contains(item)
     *
     * IndexOf(item)
     *
     * LastIndexOf(item)
     *
     * Find(condition)
     *
     * FindAll(condition)
     *
     * FindIndex(condition)
     */


    /*
     * ============================================================
     * OTHER USEFUL METHODS
     * ============================================================
     *
     * Sort()
     *     Sorts elements.
     *
     * Reverse()
     *     Reverses the order.
     *
     * ToArray()
     *     Converts a list to an array.
     *
     * Count
     *     Returns the number of elements.
     */


    /*
     * ============================================================
     * LINQ BASICS
     * ============================================================
     *
     * LINQ stands for:
     *
     * Language Integrated Query.
     *
     * It provides powerful ways to query
     * and manipulate collections.
     */


    /*
     * ============================================================
     * COMMON LINQ OPERATIONS
     * ============================================================
     *
     * Where()
     *     Filters elements.
     *
     * OrderBy()
     *     Sorts elements in ascending order.
     *
     * ToList()
     *     Converts results into a List<T>.
     */


    /*
     * ============================================================
     * LAMBDA EXPRESSIONS
     * ============================================================
     *
     * Example:
     *
     *     l => l.Author
     *
     * l:
     *     Represents each element.
     *
     * =>:
     *     Lambda operator.
     *
     * l.Author:
     *     Property used in the operation.
     */


    /*
     * ============================================================
     * KEY TAKEAWAYS
     * ============================================================
     *
     * • Arrays store fixed-size collections.
     *
     * • Lists provide dynamic collections.
     *
     * • Arrays use Length.
     *
     * • Lists use Count.
     *
     * • Arrays are fast.
     *
     * • Lists are flexible.
     *
     * • LINQ simplifies filtering and sorting.
     *
     * • Choosing the correct structure depends
     *   on the problem being solved.
     */
}
```
