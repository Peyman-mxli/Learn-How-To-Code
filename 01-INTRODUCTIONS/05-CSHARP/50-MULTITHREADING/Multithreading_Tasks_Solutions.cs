```csharp
using System;
using System.Threading;

namespace MultithreadingTaskSolutions
{
    class Program
    {
        static int counter = 0;
        static object locker = new object();

        static void Main()
        {
            Console.WriteLine("TASK 1:");
            Thread thread1 = new Thread(PrintMessage);
            thread1.Start();
            thread1.Join();

            Console.WriteLine("\nTASK 2:");
            Thread thread2 = new Thread(() =>
            {
                Console.WriteLine("Thread started");
                Thread.Sleep(2000);
                Console.WriteLine("Thread finished");
            });

            thread2.Start();
            thread2.Join();

            Console.WriteLine("\nTASK 3:");
            Thread numberThread1 = new Thread(() => PrintNumbers("Thread 1"));
            Thread numberThread2 = new Thread(() => PrintNumbers("Thread 2"));

            numberThread1.Start();
            numberThread2.Start();

            numberThread1.Join();
            numberThread2.Join();

            Console.WriteLine("\nTASK 4:");
            Thread workerThread = new Thread(() =>
            {
                Console.WriteLine("Worker thread is running...");
                Thread.Sleep(1000);
                Console.WriteLine("Worker thread finished.");
            });

            workerThread.Start();
            workerThread.Join();

            Console.WriteLine("Main thread continues after worker thread finishes.");

            Console.WriteLine("\nTASK 5:");
            counter = 0;

            Thread unsafeThread1 = new Thread(UnsafeIncrement);
            Thread unsafeThread2 = new Thread(UnsafeIncrement);

            unsafeThread1.Start();
            unsafeThread2.Start();

            unsafeThread1.Join();
            unsafeThread2.Join();

            Console.WriteLine($"Final counter value: {counter}");
            Console.WriteLine("The result may not always be correct because both threads modify the same value.");

            Console.WriteLine("\nTASK 6:");
            Console.WriteLine("A race condition happens when multiple threads access and change shared data at the same time.");
            Console.WriteLine("counter++ is not always safe because it reads, changes, and writes the value in separate steps.");
            Console.WriteLine("When two threads modify the same value together, some updates may be lost.");

            Console.WriteLine("\nTASK 7:");
            counter = 0;

            Thread safeThread1 = new Thread(SafeIncrement);
            Thread safeThread2 = new Thread(SafeIncrement);

            safeThread1.Start();
            safeThread2.Start();

            safeThread1.Join();
            safeThread2.Join();

            Console.WriteLine($"Final counter value with lock: {counter}");
            Console.WriteLine("The result is correct because lock allows only one thread to update the counter at a time.");

            Console.WriteLine("\nTASK 8:");
            Console.WriteLine("A foreground thread keeps the application alive until it finishes.");
            Console.WriteLine("A background thread does not keep the application alive.");
            Console.WriteLine("If all foreground threads finish, background threads stop automatically.");

            Console.WriteLine("\nTASK 9:");
            Console.WriteLine("Deadlock happens when two or more threads wait forever for each other.");
            Console.WriteLine("Example: Thread A waits for Thread B, and Thread B waits for Thread A.");
            Console.WriteLine("Deadlocks should be avoided because they can freeze the application.");

            Console.WriteLine("\nTASK 10:");
            Console.WriteLine("Best Practices:");
            Console.WriteLine("1. Use lock when multiple threads access shared data.");
            Console.WriteLine("2. Avoid creating too many threads.");
            Console.WriteLine("3. Avoid shared data when possible.");
            Console.WriteLine("4. Keep locked code short and simple.");
            Console.WriteLine("5. Avoid deadlocks by locking objects in a consistent order.");
        }

        static void PrintMessage()
        {
            Console.WriteLine("Running on another thread");
        }

        static void PrintNumbers(string threadName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{threadName}: {i}");
                Thread.Sleep(500);
            }
        }

        static void UnsafeIncrement()
        {
            for (int i = 0; i < 100000; i++)
            {
                counter++;
            }
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
