using System;
using System.Collections.Generic;

namespace IndexerExamples
{
    class StudentList
    {
        private string[] students = new string[5];

        public string this[int index]
        {
            get
            {
                return students[index];
            }

            set
            {
                students[index] = value;
            }
        }
    }

    class Inventory
    {
        private string[] items = new string[5];

        public string this[int slot]
        {
            get
            {
                return items[slot];
            }

            set
            {
                items[slot] = value;
            }
        }
    }

    class Scores
    {
        private int[] values = new int[10];

        public int this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }
    }

    class ReadOnlyDays
    {
        private string[] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"
        };

        public string this[int index]
        {
            get
            {
                return days[index];
            }
        }
    }

    class ProductCatalog
    {
        private List<string> products =
            new List<string>();

        public void Add(string product)
        {
            products.Add(product);
        }

        public string this[int index]
        {
            get
            {
                return products[index];
            }

            set
            {
                products[index] = value;
            }
        }
    }

    class DictionaryExample
    {
        private Dictionary<string, string> words =
            new Dictionary<string, string>();

        public string this[string key]
        {
            get
            {
                return words[key];
            }

            set
            {
                words[key] = value;
            }
        }
    }

    class SafeStudentList
    {
        private string[] students = new string[3];

        public string this[int index]
        {
            get
            {
                if (index < 0 ||
                    index >= students.Length)
                {
                    return "Invalid Index";
                }

                return students[index];
            }

            set
            {
                if (index >= 0 &&
                    index < students.Length)
                {
                    students[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("INDEXER EXAMPLES");
            Console.WriteLine("=================================\n");

            /*
            ---------------------------------
            Example 1
            Basic Indexer
            ---------------------------------
            */

            StudentList students =
                new StudentList();

            students[0] = "Peyman";
            students[1] = "Sara";

            Console.WriteLine("Example 1");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 2
            Inventory System
            ---------------------------------
            */

            Inventory inventory =
                new Inventory();

            inventory[0] = "Sword";
            inventory[1] = "Shield";
            inventory[2] = "Potion";

            Console.WriteLine("Example 2");
            Console.WriteLine(inventory[0]);
            Console.WriteLine(inventory[1]);
            Console.WriteLine(inventory[2]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 3
            Integer Indexer
            ---------------------------------
            */

            Scores scores =
                new Scores();

            scores[0] = 95;
            scores[1] = 88;
            scores[2] = 100;

            Console.WriteLine("Example 3");
            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 4
            Read-Only Indexer
            ---------------------------------
            */

            ReadOnlyDays days =
                new ReadOnlyDays();

            Console.WriteLine("Example 4");
            Console.WriteLine(days[0]);
            Console.WriteLine(days[1]);
            Console.WriteLine(days[2]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 5
            List Indexer
            ---------------------------------
            */

            ProductCatalog catalog =
                new ProductCatalog();

            catalog.Add("Laptop");
            catalog.Add("Keyboard");
            catalog.Add("Mouse");

            Console.WriteLine("Example 5");
            Console.WriteLine(catalog[0]);
            Console.WriteLine(catalog[1]);
            Console.WriteLine(catalog[2]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 6
            Updating Values
            ---------------------------------
            */

            catalog[1] = "Mechanical Keyboard";

            Console.WriteLine("Example 6");
            Console.WriteLine(catalog[1]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 7
            String Indexer
            ---------------------------------
            */

            DictionaryExample dictionary =
                new DictionaryExample();

            dictionary["Hello"] = "Hola";
            dictionary["Goodbye"] = "Adiós";

            Console.WriteLine("Example 7");
            Console.WriteLine(dictionary["Hello"]);
            Console.WriteLine(dictionary["Goodbye"]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 8
            Bounds Validation
            ---------------------------------
            */

            SafeStudentList safeList =
                new SafeStudentList();

            safeList[0] = "Ali";
            safeList[1] = "Sara";

            Console.WriteLine("Example 8");
            Console.WriteLine(safeList[0]);
            Console.WriteLine(safeList[10]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 9
            Loop Through Indexer
            ---------------------------------
            */

            Console.WriteLine("Example 9");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(inventory[i]);
            }

            Console.WriteLine();

            /*
            ---------------------------------
            Example 10
            Employee Collection
            ---------------------------------
            */

            StudentList employees =
                new StudentList();

            employees[0] = "Manager";
            employees[1] = "Developer";
            employees[2] = "Designer";

            Console.WriteLine("Example 10");
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 11
            Overwriting Existing Value
            ---------------------------------
            */

            students[0] = "Nova";

            Console.WriteLine("Example 11");
            Console.WriteLine(students[0]);
            Console.WriteLine();

            /*
            ---------------------------------
            Example 12
            Practical Usage
            ---------------------------------
            */

            Inventory bag =
                new Inventory();

            bag[0] = "Health Potion";
            bag[1] = "Mana Potion";
            bag[2] = "Sword";

            Console.WriteLine("Example 12");
            Console.WriteLine($"Slot 0: {bag[0]}");
            Console.WriteLine($"Slot 1: {bag[1]}");
            Console.WriteLine($"Slot 2: {bag[2]}");
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("END OF INDEXER EXAMPLES");
            Console.WriteLine("=================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
