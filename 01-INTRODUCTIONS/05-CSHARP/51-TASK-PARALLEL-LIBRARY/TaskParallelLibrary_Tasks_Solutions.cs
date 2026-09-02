```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibraryTaskSolutions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("TASK 1:");
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Task is running");
            });

            task1.Wait();

            Console.WriteLine("\nTASK 2:");
            Task task2 = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Delayed task completed");
            });

            task2.Wait();

            Console.WriteLine("\nTASK 3:");
            Task<int> task3 = Task.Run(() =>
            {
                int number1 = 10;
                int number2 = 20;

                return number1 + number2;
            });

            Console.WriteLine($"Returned value: {task3.Result}");

            Console.WriteLine("\nTASK 4:");
            Task task4A = Task.Run(() => Console.WriteLine("Task 1 finished"));
            Task task4B = Task.Run(() => Console.WriteLine("Task 2 finished"));
            Task task4C = Task.Run(() => Console.WriteLine("Task 3 finished"));

            Task.WaitAll(task4A, task4B, task4C);

            Console.WriteLine("\nTASK 5:");
            Task work1 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Work 1 completed");
            });

            Task work2 = Task.Run(() =>
            {
                Thread.Sleep(1500);
                Console.WriteLine("Work 2 completed");
            });

            Task work3 = Task.Run(() =>
            {
                Thread.Sleep(800);
                Console.WriteLine("Work 3 completed");
            });

            Task.WaitAll(work1, work2, work3);

            Console.WriteLine("All tasks finished");

            Console.WriteLine("\nTASK 6:");
            Console.WriteLine("Task.WhenAll() creates a task that completes when all supplied tasks finish.");
            Console.WriteLine("Task.WaitAll() blocks the current thread until all tasks finish.");
            Console.WriteLine("Task.WhenAll() is better for async/await programming.");

            Console.WriteLine("\nTASK 7:");
            Task errorTask = Task.Run(() =>
            {
                throw new InvalidOperationException("Example task error");
            });

            try
            {
                errorTask.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Exception message: {ex.InnerException?.Message}");
                Console.WriteLine("Exception handling is important because tasks can fail while running in the background.");
            }

            Console.WriteLine("\nTASK 8:");
            Console.WriteLine("A Thread is a low-level execution unit managed by the operating system.");
            Console.WriteLine("A Task is a higher-level job managed by .NET.");
            Console.WriteLine("Tasks are usually preferred because they are cleaner, easier to manage, and use the ThreadPool.");
            Console.WriteLine("Advantages of Tasks:");
            Console.WriteLine("1. Easier syntax.");
            Console.WriteLine("2. Better exception handling.");
            Console.WriteLine("3. Works naturally with async/await.");

            Console.WriteLine("\nTASK 9:");
            Console.WriteLine("CPU-bound work uses the processor heavily.");
            Console.WriteLine("CPU-bound examples: calculations, image processing, data analysis.");
            Console.WriteLine("I/O-bound work waits for external resources.");
            Console.WriteLine("I/O-bound examples: file reading, database queries, API calls.");
            Console.WriteLine("Task.Run() is commonly used for CPU-bound work.");

            Console.WriteLine("\nTASK 10:");
            Console.WriteLine("Task Parallel Library Best Practices:");
            Console.WriteLine("1. Use Tasks instead of manually creating Threads when possible.");
            Console.WriteLine("2. Handle exceptions using try-catch.");
            Console.WriteLine("3. Use cancellation tokens for cancelable operations.");
            Console.WriteLine("4. Use Task.WhenAll() when waiting for multiple async operations.");
            Console.WriteLine("5. Avoid unnecessary blocking with Wait() or Result in async code.");
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
