```csharp
using System;

namespace DelegatesExamples
{
    // Delegate Declarations
    delegate void MessageDelegate();

    delegate void GreetingDelegate(string name);

    delegate int MathDelegate(int a, int b);

    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void ExecuteAction(MessageDelegate action)
        {
            Console.WriteLine("Executing Delegate:");

            action();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("BASIC DELEGATE EXAMPLE");
            Console.WriteLine("=========================================");

            MessageDelegate message = SayHello;

            message();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("CHANGING METHODS");
            Console.WriteLine("=========================================");

            message = SayGoodbye;

            message();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("DELEGATE WITH PARAMETERS");
            Console.WriteLine("=========================================");

            GreetingDelegate greeting = Greet;

            greeting("Peyman");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("DELEGATE WITH RETURN VALUE");
            Console.WriteLine("=========================================");

            MathDelegate calculate = Add;

            Console.WriteLine($"5 + 10 = {calculate(5, 10)}");

            calculate = Multiply;

            Console.WriteLine($"5 * 10 = {calculate(5, 10)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("PASSING DELEGATES");
            Console.WriteLine("=========================================");

            ExecuteAction(SayHello);

            ExecuteAction(SayGoodbye);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("MULTICAST DELEGATE");
            Console.WriteLine("=========================================");

            MessageDelegate messages = SayHello;

            messages += SayGoodbye;

            messages();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("REMOVING A METHOD");
            Console.WriteLine("=========================================");

            messages -= SayGoodbye;

            messages();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ANONYMOUS METHOD");
            Console.WriteLine("=========================================");

            MessageDelegate anonymousMethod =
                delegate ()
                {
                    Console.WriteLine("Anonymous Method Executed");
                };

            anonymousMethod();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("LAMBDA EXPRESSION");
            Console.WriteLine("=========================================");

            MessageDelegate lambdaMethod =
                () => Console.WriteLine("Lambda Expression Executed");

            lambdaMethod();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ACTION DELEGATE");
            Console.WriteLine("=========================================");

            Action action =
                () => Console.WriteLine("Action Delegate");

            action();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("FUNC DELEGATE");
            Console.WriteLine("=========================================");

            Func<int, int, int> subtract =
                (a, b) => a - b;

            Console.WriteLine($"20 - 5 = {subtract(20, 5)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("PREDICATE DELEGATE");
            Console.WriteLine("=========================================");

            Predicate<int> isEven =
                number => number % 2 == 0;

            Console.WriteLine($"10 Is Even: {isEven(10)}");
            Console.WriteLine($"7 Is Even: {isEven(7)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("NULL SAFE INVOCATION");
            Console.WriteLine("=========================================");

            MessageDelegate emptyDelegate = null;

            emptyDelegate?.Invoke();

            Console.WriteLine("No exception occurred.");

            Console.WriteLine();

            Console.WriteLine("Delegates Examples Completed!");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
