/*
=========================================================
NOTES.CS
Module: 07-DATA-STRUCTURES
Topic: 07-DICTIONARIES
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;

namespace DictionariesNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DICTIONARIES NOTES ===");
            Console.WriteLine();

            /*
            =========================================================
            WHAT IS A DICTIONARY?
            =========================================================

            A Dictionary is a collection that stores data
            as key-value pairs.

            Each key must be UNIQUE.

            A key is used to quickly locate its value.

            Think of a real dictionary:

                Word      → Definition
                Key       → Value

            Examples:

                Name      → Phone Number
                StudentID → Grade
                ProductID → Product Name

            =========================================================
            KEY-VALUE PAIRS
            =========================================================

            Dictionary<TKey, TValue>

                TKey   = Type of the key
                TValue = Type of the value

            Examples:

                Dictionary<string, long>
                Dictionary<int, string>
                Dictionary<string, bool>
                Dictionary<int, double>
            */

            Console.WriteLine("Dictionary = Key + Value");
            Console.WriteLine();

            /*
            =========================================================
            SYSTEM.COLLECTIONS.GENERIC
            =========================================================

            To use dictionaries:

                using System.Collections.Generic;

            Syntax:

                Dictionary<string, int> scores =
                    new Dictionary<string, int>();

            =========================================================
            MAIN OPERATIONS
            =========================================================
            */

            Console.WriteLine("Main Operations");
            Console.WriteLine();

            /*
            ---------------------------------------------------------
            ADD()
            ---------------------------------------------------------

            Adds a new key-value pair.

            Example:

                contacts.Add("John", 12345);

            Important:

            Add() throws an exception if the key already exists.
            */

            Console.WriteLine("Add() → Adds a key-value pair.");

            /*
            ---------------------------------------------------------
            DIRECT ASSIGNMENT
            ---------------------------------------------------------

            Adds a new element or updates an existing one.

            Example:

                contacts["Mary"] = 98765;

            If the key exists:
                Update value.

            If the key does not exist:
                Add new pair.
            */

            Console.WriteLine("[] → Add or update.");

            /*
            ---------------------------------------------------------
            ACCESSING VALUES
            ---------------------------------------------------------

            Use the key to retrieve a value.

            Example:

                Console.WriteLine(contacts["John"]);

            Result:

                12345
            */

            Console.WriteLine("dictionary[key] → Access value.");

            /*
            ---------------------------------------------------------
            CONTAINSKEY()
            ---------------------------------------------------------

            Checks whether a key exists.

            Example:

                if (contacts.ContainsKey("John"))

            Returns:

                True
                False
            */

            Console.WriteLine("ContainsKey() → Check key existence.");

            /*
            ---------------------------------------------------------
            REMOVE()
            ---------------------------------------------------------

            Deletes a key-value pair.

            Example:

                contacts.Remove("John");

            Returns:

                True  → Removed
                False → Key not found
            */

            Console.WriteLine("Remove() → Delete an entry.");

            /*
            ---------------------------------------------------------
            COUNT
            ---------------------------------------------------------

            Returns the number of entries.

            Example:

                contacts.Count

            Result:

                3
            */

            Console.WriteLine("Count → Number of entries.");

            /*
            ---------------------------------------------------------
            CLEAR()
            ---------------------------------------------------------

            Removes all entries.

            Example:

                contacts.Clear();
            */

            Console.WriteLine("Clear() → Remove everything.");

            Console.WriteLine();

            /*
            =========================================================
            ITERATING THROUGH A DICTIONARY
            =========================================================

            foreach (KeyValuePair<TKey, TValue> item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Example:

                John → 12345
                Mary → 98765
                Peter → 55555
            */

            Console.WriteLine("foreach → Iterate through entries.");

            Console.WriteLine();

            /*
            =========================================================
            PHONE BOOK EXAMPLE
            =========================================================

            Contacts:

                Juan Pérez   → 1234567890
                María García → 9876543210
                Carlos Ruiz  → 5551234567

            Operations:

                Add
                Access
                ContainsKey
                Remove
                Iterate

            =========================================================
            CONFIGURATION EXAMPLE
            =========================================================

            Theme          → Dark
            Language       → Spanish
            FontSize       → Small

            Dictionaries are excellent for storing settings.

            =========================================================
            ADVANTAGES OF DICTIONARIES
            =========================================================

            • Fast searching by key.
            • Unique keys prevent duplicates.
            • Flexible value types.
            • Easy insertion and removal.
            • Widely used in applications.
            */

            Console.WriteLine("Advantages:");
            Console.WriteLine("- Fast searches");
            Console.WriteLine("- Unique keys");
            Console.WriteLine("- Flexible data");

            /*
            =========================================================
            LIMITATIONS OF DICTIONARIES
            =========================================================

            • Keys must be unique.
            • No automatic sorting.
            • Accessing a missing key causes exceptions.
            • More memory usage than simple lists.
            */

            Console.WriteLine();
            Console.WriteLine("Limitations:");
            Console.WriteLine("- Unique keys only");
            Console.WriteLine("- Not automatically ordered");

            /*
            =========================================================
            SUMMARY
            =========================================================

            Dictionary<TKey, TValue>

            Add()          → Add pair
            []             → Add or update
            ContainsKey()  → Verify key
            Remove()       → Delete pair
            Count          → Total entries
            Clear()        → Remove all
            foreach        → Iterate

            =========================================================
            */

            Console.WriteLine();
            Console.WriteLine("Dictionary Summary:");
            Console.WriteLine("Key → Value");
            Console.WriteLine("Add → Insert");
            Console.WriteLine("[] → Add/Update");
            Console.WriteLine("ContainsKey → Verify");
            Console.WriteLine("Remove → Delete");
            Console.WriteLine("Count → Total");
            Console.WriteLine("Clear → Empty");

            Console.WriteLine();
            Console.WriteLine("End of Notes.");
        }
    }
}
