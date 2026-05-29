using System;
using System.Collections.Generic;

namespace IndexerTasksSolutions
{
    class StudentList
    {
        private string[] students = new string[3];

        public string this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
    }

    class NumberList
    {
        private int[] numbers = new int[5];

        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }
    }

    class Inventory
    {
        private string[] items = new string[5];

        public string this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }

    class ScoreBoard
    {
        private int[] scores = new int[4];

        public int this[int index]
        {
            get { return scores[index]; }
            set { scores[index] = value; }
        }
    }

    class ProductList
    {
        private string[] products = new string[3];

        public string this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }
    }

    class TemperatureWeek
    {
        private double[] temperatures = new double[7];

        public double this[int index]
        {
            get { return temperatures[index]; }
            set { temperatures[index] = value; }
        }
    }

    class WeekDays
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
            get { return days[index]; }
        }
    }

    class SafeNames
    {
        private string[] names = new string[3];

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= names.Length)
                {
                    return "Invalid Index";
                }

                return names[index];
            }

            set
            {
                if (index >= 0 && index < names.Length)
                {
                    names[index] = value;
                }
            }
        }
    }

    class Library
    {
        private string[] books = new string[5];

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    class ProductCatalog
    {
        private List<string> products =
            new List<string>();

        public void AddProduct(string product)
        {
            products.Add(product);
        }

        public string this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }
    }

    class DictionaryWords
    {
        private Dictionary<string, string> words =
            new Dictionary<string, string>();

        public string this[string key]
        {
            get { return words[key]; }
            set { words[key] = value; }
        }
    }

    class EmployeeList
    {
        private string[] employees = new string[3];

        public string this[int index]
        {
            get { return employees[index]; }
            set { employees[index] = value; }
        }
    }

    class GameInventory
    {
        private string[] items = new string[10];

        public string this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }

    class StudentGrades
    {
        private string[] studentNames =
        {
            "Ali",
            "Sara",
            "Peyman"
        };

        private int[] studentGrades =
        {
            85,
            92,
            100
        };

        public string this[int index]
        {
            get
            {
                return $"{studentNames[index]} - {studentGrades[index]}";
            }
        }
    }

    class BankAccounts
    {
        private string[] accountNumbers =
        {
            "ACC-001",
            "ACC-002",
            "ACC-003"
        };

        private double[] balances =
        {
            5000,
            2500,
            10000
        };

        public string this[int index]
        {
            get
            {
                return $"Account: {accountNumbers[index]} | Balance: {balances[index]}";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("INDEXER TASK SOLUTIONS");
            Console.WriteLine("=================================\n");

            StudentList students = new StudentList();

            students[0] = "Ali";
            students[1] = "Sara";
            students[2] = "Peyman";

            Console.WriteLine("Task 1");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);

            Console.WriteLine();

            NumberList numbers = new NumberList();

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine("Task 2");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            Inventory inventory = new Inventory();

            inventory[0] = "Sword";
            inventory[1] = "Shield";
            inventory[2] = "Potion";

            Console.WriteLine("Task 3");

            Console.WriteLine(inventory[0]);
            Console.WriteLine(inventory[1]);
            Console.WriteLine(inventory[2]);

            Console.WriteLine();

            ScoreBoard scoreBoard = new ScoreBoard();

            scoreBoard[0] = 100;
            scoreBoard[1] = 90;
            scoreBoard[2] = 80;
            scoreBoard[3] = 70;

            Console.WriteLine("Task 4");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(scoreBoard[i]);
            }

            Console.WriteLine();

            ProductList productList = new ProductList();

            productList[0] = "Laptop";
            productList[1] = "Mouse";
            productList[2] = "Keyboard";

            Console.WriteLine("Task 5");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(productList[i]);
            }

            Console.WriteLine();

            TemperatureWeek week = new TemperatureWeek();

            week[0] = 25.5;
            week[1] = 26.1;
            week[2] = 27.8;
            week[3] = 28.4;
            week[4] = 29.2;
            week[5] = 30.0;
            week[6] = 31.5;

            Console.WriteLine("Task 6");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(week[i]);
            }

            Console.WriteLine();

            WeekDays days = new WeekDays();

            Console.WriteLine("Task 7");

            Console.WriteLine(days[0]);
            Console.WriteLine(days[1]);
            Console.WriteLine(days[2]);

            Console.WriteLine();

            SafeNames safeNames = new SafeNames();

            safeNames[0] = "Peyman";

            Console.WriteLine("Task 8");

            Console.WriteLine(safeNames[0]);
            Console.WriteLine(safeNames[10]);

            Console.WriteLine();

            Library library = new Library();

            library[0] = "Clean Code";
            library[1] = "Head First C#";

            Console.WriteLine("Task 9");

            Console.WriteLine(library[0]);
            Console.WriteLine(library[1]);

            Console.WriteLine();

            ProductCatalog catalog = new ProductCatalog();

            catalog.AddProduct("Monitor");
            catalog.AddProduct("Keyboard");
            catalog.AddProduct("Mouse");

            Console.WriteLine("Task 10");

            Console.WriteLine(catalog[0]);
            Console.WriteLine(catalog[1]);
            Console.WriteLine(catalog[2]);

            Console.WriteLine();

            DictionaryWords dictionary =
                new DictionaryWords();

            dictionary["Hello"] = "Hola";
            dictionary["Goodbye"] = "Adiós";

            Console.WriteLine("Task 11");

            Console.WriteLine(dictionary["Hello"]);
            Console.WriteLine(dictionary["Goodbye"]);

            Console.WriteLine();

            EmployeeList employees =
                new EmployeeList();

            employees[0] = "Manager";
            employees[1] = "Developer";
            employees[2] = "Designer";

            Console.WriteLine("Task 12");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(employees[i]);
            }

            Console.WriteLine();

            GameInventory gameInventory =
                new GameInventory();

            gameInventory[0] = "Sword";
            gameInventory[1] = "Armor";
            gameInventory[2] = "Potion";

            Console.WriteLine("Task 13");

            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(gameInventory[i]))
                {
                    Console.WriteLine(
                        $"Slot {i}: {gameInventory[i]}");
                }
            }

            Console.WriteLine();

            StudentGrades grades =
                new StudentGrades();

            Console.WriteLine("Task 14");

            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[1]);
            Console.WriteLine(grades[2]);

            Console.WriteLine();

            BankAccounts accounts =
                new BankAccounts();

            Console.WriteLine("Task 15");

            Console.WriteLine(accounts[0]);
            Console.WriteLine(accounts[1]);
            Console.WriteLine(accounts[2]);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("END OF INDEXER SOLUTIONS");
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
