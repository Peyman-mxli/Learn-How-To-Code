```csharp
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionsTaskSolutions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("TASK 1:");
            ConcurrentDictionary<int, string> users = new ConcurrentDictionary<int, string>();

            users.TryAdd(1, "Peyman");
            users.TryAdd(2, "Nova");
            users.TryAdd(3, "Aria");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value}");
            }

            Console.WriteLine("\nTASK 2:");
            ConcurrentDictionary<int, string> students = new ConcurrentDictionary<int, string>();

            bool firstAdd = students.TryAdd(1, "Student One");
            bool secondAdd = students.TryAdd(1, "Student Duplicate");

            Console.WriteLine($"First Add Result: {firstAdd}");
            Console.WriteLine($"Second Add Result: {secondAdd}");

            Console.WriteLine("\nTASK 3:");
            ConcurrentDictionary<int, string> products = new ConcurrentDictionary<int, string>();

            products.TryAdd(1, "Laptop");
            products.TryAdd(2, "Mouse");
            products.TryAdd(3, "Keyboard");

            bool removed = products.TryRemove(2, out string removedProduct);

            Console.WriteLine($"Removed: {removed}");
            Console.WriteLine($"Removed Value: {removedProduct}");

            Console.WriteLine("\nTASK 4:");
            ConcurrentQueue<string> tasks = new ConcurrentQueue<string>();

            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");
            tasks.Enqueue("Task 4");
            tasks.Enqueue("Task 5");

            while (tasks.TryDequeue(out string task))
            {
                Console.WriteLine($"Dequeued: {task}");
            }

            Console.WriteLine("\nTASK 5:");
            ConcurrentStack<int> numbers = new ConcurrentStack<int>();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            numbers.Push(40);
            numbers.Push(50);

            while (numbers.TryPop(out int number))
            {
                Console.WriteLine($"Popped: {number}");
            }

            Console.WriteLine("\nTASK 6:");
            ConcurrentBag<string> items = new ConcurrentBag<string>();

            items.Add("Sword");
            items.Add("Shield");
            items.Add("Potion");
            items.Add("Helmet");
            items.Add("Armor");

            while (items.TryTake(out string item))
            {
                Console.WriteLine($"Taken: {item}");
            }

            Console.WriteLine("\nTASK 7:");
            ConcurrentDictionary<int, string> gameUsers = new ConcurrentDictionary<int, string>();

            gameUsers.TryAdd(1, "Old Name");

            gameUsers.AddOrUpdate(
                1,
                "New Name",
                (key, oldValue) => "Updated Name");

            Console.WriteLine($"Updated User: {gameUsers[1]}");

            Console.WriteLine("\nTASK 8:");
            BlockingCollection<int> jobs = new BlockingCollection<int>();

            Task producer = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    jobs.Add(i);
                    Console.WriteLine($"Produced: {i}");
                    Thread.Sleep(300);
                }

                jobs.CompleteAdding();
            });

            Task consumer = Task.Run(() =>
            {
                foreach (int job in jobs.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed: {job}");
                    Thread.Sleep(500);
                }
            });

            Task.WaitAll(producer, consumer);

            Console.WriteLine("\nTASK 9:");
            Console.WriteLine("Thread-safe means multiple threads can access data safely without corrupting it.");
            Console.WriteLine("Concurrent Collections exist to protect shared data in multithreaded applications.");
            Console.WriteLine("Standard collections can fail when multiple threads modify them at the same time.");

            Console.WriteLine("\nTASK 10:");
            Console.WriteLine("Concurrent Collection Best Practices:");
            Console.WriteLine("1. Choose the correct collection for the job.");
            Console.WriteLine("2. Use ConcurrentDictionary for shared key/value data.");
            Console.WriteLine("3. Use ConcurrentQueue for FIFO job queues.");
            Console.WriteLine("4. Avoid unnecessary manual locking.");
            Console.WriteLine("5. Test multithreaded code carefully.");
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
```
