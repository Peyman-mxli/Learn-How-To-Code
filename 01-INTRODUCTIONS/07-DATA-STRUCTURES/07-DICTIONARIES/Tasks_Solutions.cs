/*
=========================================================
TASKS_SOLUTIONS.CS
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
using System.Collections.Generic;

namespace DictionariesTasksSolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== PLAYER SCORE STORAGE ===\n");

            // Create the dictionary
            Dictionary<int, string> players =
                new Dictionary<int, string>();

            /*
            =========================================================
            A) ADD 5 PLAYERS USING Add()
            =========================================================
            */

            players.Add(100, "Juan");
            players.Add(200, "Maria");
            players.Add(300, "Pedro");
            players.Add(400, "Ana");
            players.Add(500, "Luis");

            Console.WriteLine("Initial players:");

            DisplayPlayers(players);

            /*
            =========================================================
            B) ADD MORE PLAYERS USING DIRECT ASSIGNMENT
            =========================================================
            */

            Console.WriteLine("\nAdding more players...\n");

            players[600] = "Sofia";
            players[700] = "Carlos";

            DisplayPlayers(players);

            /*
            =========================================================
            C) REMOVE A PLAYER
            =========================================================
            */

            Console.WriteLine("\nRemoving player with score 300...\n");

            bool removed = players.Remove(300);

            if (removed)
            {
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }

            /*
            =========================================================
            D) PRINT REMAINING PLAYERS
            =========================================================
            */

            Console.WriteLine("\nRemaining players:");

            DisplayPlayers(players);

            Console.WriteLine("\nTotal players: " + players.Count);

            Console.WriteLine("\nEnd of dictionary task solution.");
        }

        /*
        =========================================================
        HELPER METHOD
        =========================================================
        */

        public static void DisplayPlayers(
            Dictionary<int, string> players)
        {
            foreach (KeyValuePair<int, string> player in players)
            {
                Console.WriteLine(
                    $"Score: {player.Key} | " +
                    $"Player: {player.Value}");
            }
        }
    }
}
