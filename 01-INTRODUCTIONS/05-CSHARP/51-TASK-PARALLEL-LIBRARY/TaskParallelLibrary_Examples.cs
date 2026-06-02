```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibraryExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("TASK PARALLEL LIBRARY EXAMPLES");
            Console.WriteLine("========================================");

            Example1_CreateTask();
            Example2_TaskRun();
            Example3_TaskWithReturnValue();
            Example4_MultipleTasks();
            Example5_TaskWaitAll();
            Example6_TaskExceptionHandling();

            Console.WriteLine("\nAll examples completed.");
        }

        static void Example1_CreateTask()
        {
            Console.WriteLine("\nEXAMPLE 1 - Create Task");

            Task task = new Task(() =>
            {
                Console.WriteLine("Task created manually.");
            });

            task.Start();
            task.Wait();
        }

        static void Example2_TaskRun()
        {
            Console.WriteLine("\nEXAMPLE 2 - Task.Run");

            Task task = Task.Run(() =>
            {
                Console.WriteLine("Task is running in the background.");
                Thread.Sleep(1000);
                Console.WriteLine("Task completed.");
            });

            task.Wait();
        }

        static void Example3_TaskWithReturnValue()
        {
            Console.WriteLine("\nEXAMPLE 3 - Task With Return Value");

            Task<int> task = Task.Run(() =>
            {
                int number1 = 10;
                int number2 = 20;

                return number1 + number2;
            });

            Console.WriteLine($"Result: {task.Result}");
        }

        static void Example4_MultipleTasks()
        {
            Console.WriteLine("\nEXAMPLE 4 - Multiple Tasks");

            Task task1 = Task.Run(() => PrintWork("Task 1"));
            Task task2 = Task.Run(() => PrintWork("Task 2"));
            Task task3 = Task.Run(() => PrintWork("Task 3"));

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("All tasks finished.");
        }

        static void Example5_TaskWaitAll()
        {
            Console.WriteLine("\nEXAMPLE 5 - Task.WaitAll");

            Task downloadTask = Task.Run(() =>
            {
                Console.WriteLine("Downloading data...");
                Thread.Sleep(1000);
                Console.WriteLine("Download completed.");
            });

            Task processTask = Task.Run(() =>
            {
                Console.WriteLine("Processing data...");
                Thread.Sleep(1500);
                Console.WriteLine("Processing completed.");
            });

            Task saveTask = Task.Run(() =>
            {
                Console.WriteLine("Saving data...");
                Thread.Sleep(800);
                Console.WriteLine("Save completed.");
            });

            Task.WaitAll(downloadTask, processTask, saveTask);

            Console.WriteLine("All operations completed.");
        }

        static void Example6_TaskExceptionHandling()
        {
            Console.WriteLine("\nEXAMPLE 6 - Task Exception Handling");

            Task task = Task.Run(() =>
            {
                throw new InvalidOperationException("Something went wrong inside the task.");
            });

            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Task exception caught.");

                foreach (Exception innerException in ex.InnerExceptions)
                {
                    Console.WriteLine($"Error: {innerException.Message}");
                }
            }
        }

        static void PrintWork(string taskName)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{taskName} working... Step {i}");
                Thread.Sleep(500);
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
