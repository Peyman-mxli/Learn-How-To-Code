/*
=========================================================
EXAMPLES.CS
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

namespace DictionariesExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Example1_PhoneBook();

            Console.WriteLine("\nPress ENTER for Example 2...");
            Console.ReadLine();

            Example2_ApplicationSettings();

            Console.WriteLine("\nEnd of dictionary examples.");
        }

        /*
        =========================================================
        EXAMPLE 1: PHONE BOOK
        =========================================================
        */

        public static void Example1_PhoneBook()
        {
            Console.Clear();

            Console.WriteLine("=== EXAMPLE 1: PHONE BOOK ===\n");

            // 1. Declaration and initialization
            Dictionary<string, long> phoneBook =
                new Dictionary<string, long>();

            // 2. Add elements using Add()
            phoneBook.Add("Juan Perez", 1234567890);
            phoneBook.Add("Maria Garcia", 9876543210);

            // 3. Add element using direct assignment
            phoneBook["Carlos Ruiz"] = 5551234567;

            // 4. Access a value using its key
            Console.WriteLine(
                $"Juan's phone number: {phoneBook["Juan Perez"]}");

            // 5. Verify whether a key exists
            if (phoneBook.ContainsKey("Maria Garcia"))
            {
                Console.WriteLine(
                    $"Maria is in the phone book. Her number is: " +
                    $"{phoneBook["Maria Garcia"]}");
            }

            // 6. Remove an element
            phoneBook.Remove("Carlos Ruiz");

            // 7. Iterate through the dictionary
            Console.WriteLine("\nRemaining contacts:");

            foreach (KeyValuePair<string, long> contact in phoneBook)
            {
                Console.WriteLine(
                    $"Contact: {contact.Key}, " +
                    $"Phone: {contact.Value}");
            }
        }

        /*
        =========================================================
        EXAMPLE 2: APPLICATION SETTINGS
        =========================================================
        */

        public static void Example2_ApplicationSettings()
        {
            Console.Clear();

            Console.WriteLine("=== EXAMPLE 2: APPLICATION SETTINGS ===\n");

            // Create dictionary
            Dictionary<string, string> settings =
                new Dictionary<string, string>();

            // Add settings
            settings["Theme"] = "Dark";
            settings["Language"] = "English";
            settings["FontSize"] = "Small";

            // Retrieve a setting
            string currentTheme = settings["Theme"];

            Console.WriteLine($"Current theme: {currentTheme}");

            // Display all settings
            Console.WriteLine("\nApplication Settings:");

            foreach (KeyValuePair<string, string> setting in settings)
            {
                Console.WriteLine(
                    $"{setting.Key}: {setting.Value}");
            }
        }
    }
}
