/*
=========================================================
TASKS.CS
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

namespace DictionariesTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            =================================================
            EXERCISE 1: PLAYER SCORE STORAGE
            =================================================

            Objective:
            Create a dictionary to store different players.

            The dictionary must use:

                int    → player score
                string → player name

            Instructions:

            1. Create a dictionary using Dictionary<int, string>.

            2. Add 5 players using Add().

               Example:

               players.Add(100, "Player One");

            3. Add more players using direct assignment.

               Example:

               players[600] = "Player Six";

            4. Remove one player using Remove().

               Example:

               players.Remove(300);

            5. Print all remaining data from the dictionary.

            6. Use foreach to display every key-value pair.

            Expected behavior:

               Score: 100 | Player: Juan
               Score: 200 | Player: Maria
               Score: 400 | Player: Pedro

            Important:
            Dictionary keys must be unique.

            If two players have the same score, the dictionary
            cannot store both using the score as the key.

            Concepts:
            Dictionary<int, string>, Add(), direct assignment,
            Remove(), foreach, KeyValuePair.
            */

            Console.WriteLine("Dictionaries Tasks");
            Console.WriteLine("Complete the exercise above.");
        }
    }
}
