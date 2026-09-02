```csharp
using System;
using System.Threading;

namespace MultithreadingExamples
{
    class Program
    {
        static int counter = 0;
        static object locker = new object();

        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("MULTITHREADING EXAMPLES");
            Console.WriteLine("========================================");

            Example1_CreateThread();
            Example2_ThreadSleep();
            Example3_MultipleThreads();
            Example4_ThreadJoin();
            Example5_RaceCondition();
            Example6_LockKeyword();

            Console.WriteLine("\nAll examples completed.");
        }

        static void Example1_CreateThread()
        {
            Console.WriteLine("\nEXAMPLE 1 - Create Thread");

            Thread thread = new Thread(PrintMessage);

            thread.Start();

            thread.Join();
        }

        static void PrintMessage()
        {
            Console.WriteLine("This message is running on another thread.");
        }

        static void Example2_ThreadSleep()
        {
            Console.WriteLine("\nEXAMPLE 2 - Thread Sleep");

            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Thread started.");
                Thread.Sleep(2000);
                Console.WriteLine("Thread finished after 2 seconds.");
            });

            thread.Start();
            thread.Join();
        }

        static void Example3_MultipleThreads()
        {
            Console.WriteLine("\nEXAMPLE 3 - Multiple Threads");

            Thread thread1 = new Thread(() => PrintNumbers("Thread 1"));
            Thread thread2 = new Thread(() => PrintNumbers("Thread 2"));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        static void PrintNumbers(string threadName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{threadName}: {i}");
                Thread.Sleep(500);
            }
        }

        static void Example4_ThreadJoin()
        {
            Console.WriteLine("\nEXAMPLE 4 - Thread Join");

            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Worker thread is working...");
                Thread.Sleep(1000);
                Console.WriteLine("Worker thread finished.");
            });

            thread.Start();

            Console.WriteLine("Main thread waits for worker thread.");

            thread.Join();

            Console.WriteLine("Main thread continues after Join().");
        }

        static void Example5_RaceCondition()
        {
            Console.WriteLine("\nEXAMPLE 5 - Race Condition");

            counter = 0;

            Thread thread1 = new Thread(UnsafeIncrement);
            Thread thread2 = new Thread(UnsafeIncrement);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Expected counter: 200000");
            Console.WriteLine($"Actual counter  : {counter}");
        }

        static void UnsafeIncrement()
        {
            for (int i = 0; i < 100000; i++)
            {
                counter++;
            }
        }

        static void Example6_LockKeyword()
        {
            Console.WriteLine("\nEXAMPLE 6 - Lock Keyword");

            counter = 0;

            Thread thread1 = new Thread(SafeIncrement);
            Thread thread2 = new Thread(SafeIncrement);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Expected counter: 200000");
            Console.WriteLine($"Actual counter  : {counter}");
        }

        static void SafeIncrement()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (locker)
                {
                    counter++;
                }
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
