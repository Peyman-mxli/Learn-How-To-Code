```csharp
using System;
using System.Collections.Generic;

namespace GenericsTaskSolutions
{
    class Box<T>
    {
        public T Value { get; set; }

        public void Display()
        {
            Console.WriteLine($"Box Value: {Value}");
        }
    }

    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public void DisplayPair()
        {
            Console.WriteLine($"First: {First} | Second: {Second}");
        }
    }

    interface IStorage<T>
    {
        void Save(T item);
        T Get();
    }

    class StringStorage : IStorage<string>
    {
        private string savedItem;

        public void Save(string item)
        {
            savedItem = item;
        }

        public string Get()
        {
            return savedItem;
        }
    }

    class Repository<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item)
        {
            items.Remove(item);
        }

        public void DisplayItems()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Inventory<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item} added to inventory.");
        }

        public void RemoveItem(T item)
        {
            if (items.Remove(item))
            {
                Console.WriteLine($"{item} removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{item} was not found.");
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("Inventory Items:");

            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Manager<T>
    {
        private List<T> objects = new List<T>();

        public void Add(T item)
        {
            objects.Add(item);
        }

        public void Remove(T item)
        {
            objects.Remove(item);
        }

        public int Count()
        {
            return objects.Count;
        }

        public void DisplayAll()
        {
            foreach (T item in objects)
            {
                Console.WriteLine(item);
            }
        }
    }

    class TestObject
    {
        public string Name { get; set; }

        public TestObject()
        {
            Name = "New Test Object";
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Program
    {
        static void PrintItem<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }

        static void PrintReferenceType<T>(T value) where T : class
        {
            Console.WriteLine($"Reference Type Value: {value}");
        }

        static void PrintValueType<T>(T value) where T : struct
        {
            Console.WriteLine($"Value Type Value: {value}");
        }

        static void CreateNewObject<T>() where T : new()
        {
            T newObject = new T();
            Console.WriteLine($"New object created: {newObject}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 1: GENERIC BOX CLASS");
            Console.WriteLine("=========================================");

            Box<int> intBox = new Box<int>();
            intBox.Value = 100;
            intBox.Display();

            Box<string> stringBox = new Box<string>();
            stringBox.Value = "Hello Generics";
            stringBox.Display();

            Box<double> doubleBox = new Box<double>();
            doubleBox.Value = 45.75;
            doubleBox.Display();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 2: GENERIC PRINT METHOD");
            Console.WriteLine("=========================================");

            PrintItem(25);
            PrintItem("Peyman");
            PrintItem(true);
            PrintItem(99.99);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 3: GENERIC PAIR CLASS");
            Console.WriteLine("=========================================");

            Pair<int, string> studentPair = new Pair<int, string>();
            studentPair.First = 1;
            studentPair.Second = "Peyman";
            studentPair.DisplayPair();

            Pair<string, double> productPair = new Pair<string, double>();
            productPair.First = "Laptop";
            productPair.Second = 1500.99;
            productPair.DisplayPair();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 4: LIST<T>");
            Console.WriteLine("=========================================");

            List<string> students = new List<string>();

            students.Add("Peyman");
            students.Add("Sarah");
            students.Add("David");
            students.Add("Maria");
            students.Add("John");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            students.Remove("John");

            Console.WriteLine("After removing one student:");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 5: DICTIONARY<TKey, TValue>");
            Console.WriteLine("=========================================");

            Dictionary<int, string> studentDictionary =
                new Dictionary<int, string>();

            studentDictionary.Add(1, "Peyman");
            studentDictionary.Add(2, "Sarah");
            studentDictionary.Add(3, "David");
            studentDictionary.Add(4, "Maria");
            studentDictionary.Add(5, "John");

            foreach (KeyValuePair<int, string> student in studentDictionary)
            {
                Console.WriteLine($"ID: {student.Key} | Name: {student.Value}");
            }

            int searchId = 3;

            if (studentDictionary.ContainsKey(searchId))
            {
                Console.WriteLine($"Student found: {studentDictionary[searchId]}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 6: QUEUE<T>");
            Console.WriteLine("=========================================");

            Queue<string> customers = new Queue<string>();

            customers.Enqueue("Customer 1");
            customers.Enqueue("Customer 2");
            customers.Enqueue("Customer 3");
            customers.Enqueue("Customer 4");

            while (customers.Count > 0)
            {
                string customer = customers.Dequeue();

                Console.WriteLine($"Serving: {customer}");
                Console.WriteLine($"Customers remaining: {customers.Count}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 7: STACK<T>");
            Console.WriteLine("=========================================");

            Stack<string> actions = new Stack<string>();

            actions.Push("Open File");
            actions.Push("Edit File");
            actions.Push("Save File");
            actions.Push("Close File");

            while (actions.Count > 0)
            {
                string action = actions.Pop();

                Console.WriteLine($"Undo action: {action}");
                Console.WriteLine($"Actions remaining: {actions.Count}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 8: HASHSET<T>");
            Console.WriteLine("=========================================");

            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(40);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 9: GENERIC REPOSITORY");
            Console.WriteLine("=========================================");

            Repository<string> stringRepository = new Repository<string>();

            stringRepository.AddItem("File One");
            stringRepository.AddItem("File Two");
            stringRepository.AddItem("File Three");
            stringRepository.RemoveItem("File Two");
            stringRepository.DisplayItems();

            Repository<int> numberRepository = new Repository<int>();

            numberRepository.AddItem(100);
            numberRepository.AddItem(200);
            numberRepository.AddItem(300);
            numberRepository.RemoveItem(200);
            numberRepository.DisplayItems();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 10: GENERIC INTERFACE");
            Console.WriteLine("=========================================");

            StringStorage storage = new StringStorage();

            storage.Save("Saved generic data");
            Console.WriteLine(storage.Get());

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 11: CLASS CONSTRAINT");
            Console.WriteLine("=========================================");

            PrintReferenceType("This is a reference type");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 12: STRUCT CONSTRAINT");
            Console.WriteLine("=========================================");

            PrintValueType(100);
            PrintValueType(25.5);
            PrintValueType(true);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 13: NEW() CONSTRAINT");
            Console.WriteLine("=========================================");

            CreateNewObject<TestObject>();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 14: GENERIC GAME INVENTORY");
            Console.WriteLine("=========================================");

            Inventory<string> weaponInventory = new Inventory<string>();

            weaponInventory.AddItem("Iron Sword");
            weaponInventory.AddItem("Steel Axe");
            weaponInventory.AddItem("Hunter Bow");
            weaponInventory.RemoveItem("Steel Axe");
            weaponInventory.DisplayItems();

            Inventory<string> potionInventory = new Inventory<string>();

            potionInventory.AddItem("Health Potion");
            potionInventory.AddItem("Mana Potion");
            potionInventory.AddItem("Stamina Potion");
            potionInventory.DisplayItems();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 15: REAL-WORLD GENERIC SYSTEM");
            Console.WriteLine("=========================================");

            Manager<Student> studentManager = new Manager<Student>();

            Student studentOne = new Student("Peyman");
            Student studentTwo = new Student("Sarah");

            studentManager.Add(studentOne);
            studentManager.Add(studentTwo);

            Console.WriteLine($"Total Students: {studentManager.Count()}");
            studentManager.DisplayAll();

            Manager<Product> productManager = new Manager<Product>();

            Product productOne = new Product("Laptop");
            Product productTwo = new Product("Keyboard");

            productManager.Add(productOne);
            productManager.Add(productTwo);

            Console.WriteLine($"Total Products: {productManager.Count()}");
            productManager.DisplayAll();

            Console.WriteLine();

            Console.WriteLine("Generics Task Solutions Completed!");
        }
    }
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
