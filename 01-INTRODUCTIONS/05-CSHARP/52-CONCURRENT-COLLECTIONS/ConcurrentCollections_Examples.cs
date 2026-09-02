```csharp
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionsExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("CONCURRENT COLLECTIONS EXAMPLES");
            Console.WriteLine("========================================");

            Example1_ConcurrentDictionary();
            Example2_ConcurrentQueue();
            Example3_ConcurrentStack();
            Example4_ConcurrentBag();
            Example5_BlockingCollection();
            Example6_ParallelAccess();

            Console.WriteLine("\nAll examples completed.");
        }

        // ----------------------------------------------------
        // Example 1
        // ConcurrentDictionary
        // ----------------------------------------------------
        static void Example1_ConcurrentDictionary()
        {
            Console.WriteLine("\nEXAMPLE 1 - ConcurrentDictionary");

            ConcurrentDictionary<int, string> users =
                new ConcurrentDictionary<int, string>();

            users.TryAdd(1, "Peyman");
            users.TryAdd(2, "Nova");

            users.TryGetValue(1, out string userName);

            Console.WriteLine($"User 1: {userName}");

            users.AddOrUpdate(
                1,
                "New User",
                (key, oldValue) => oldValue + " Updated");

            Console.WriteLine($"Updated User 1: {users[1]}");
        }

        // ----------------------------------------------------
        // Example 2
        // ConcurrentQueue
        // ----------------------------------------------------
        static void Example2_ConcurrentQueue()
        {
            Console.WriteLine("\nEXAMPLE 2 - ConcurrentQueue");

            ConcurrentQueue<string> tasks =
                new ConcurrentQueue<string>();

            tasks.Enqueue("Download File");
            tasks.Enqueue("Process Data");
            tasks.Enqueue("Save Results");

            while (tasks.TryDequeue(out string task))
            {
                Console.WriteLine($"Processing: {task}");
            }
        }

        // ----------------------------------------------------
        // Example 3
        // ConcurrentStack
        // ----------------------------------------------------
        static void Example3_ConcurrentStack()
        {
            Console.WriteLine("\nEXAMPLE 3 - ConcurrentStack");

            ConcurrentStack<int> numbers =
                new ConcurrentStack<int>();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            while (numbers.TryPop(out int value))
            {
                Console.WriteLine($"Popped: {value}");
            }
        }

        // ----------------------------------------------------
        // Example 4
        // ConcurrentBag
        // ----------------------------------------------------
        static void Example4_ConcurrentBag()
        {
            Console.WriteLine("\nEXAMPLE 4 - ConcurrentBag");

            ConcurrentBag<string> items =
                new ConcurrentBag<string>();

            items.Add("Sword");
            items.Add("Shield");
            items.Add("Potion");

            while (items.TryTake(out string item))
            {
                Console.WriteLine($"Removed: {item}");
            }
        }

        // ----------------------------------------------------
        // Example 5
        // BlockingCollection
        // ----------------------------------------------------
        static void Example5_BlockingCollection()
        {
            Console.WriteLine("\nEXAMPLE 5 - BlockingCollection");

            BlockingCollection<int> jobs =
                new BlockingCollection<int>();

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
        }

        // ----------------------------------------------------
        // Example 6
        // Parallel Access
        // ----------------------------------------------------
        static void Example6_ParallelAccess()
        {
            Console.WriteLine("\nEXAMPLE 6 - Parallel Access");

            ConcurrentDictionary<int, string> dictionary =
                new ConcurrentDictionary<int, string>();

            Parallel.For(1, 11, i =>
            {
                dictionary.TryAdd(i, $"User {i}");
            });

            Console.WriteLine($"Total Items: {dictionary.Count}");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
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
