```csharp
using System;

namespace DelegatesTaskSolutions
{
    delegate void MessageDelegate();

    delegate void GreetingDelegate(string name);

    delegate int MathDelegate(int a, int b);

    delegate void CompleteDelegate();

    delegate void GameActionDelegate();

    delegate void MenuCommandDelegate();

    delegate double CalculatorDelegate(double a, double b);

    class Program
    {
        static void ShowMessage()
        {
            Console.WriteLine("This message is displayed using a delegate.");
        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}. Welcome to delegates.");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        static void FirstStep()
        {
            Console.WriteLine("First method executed.");
        }

        static void SecondStep()
        {
            Console.WriteLine("Second method executed.");
        }

        static void ThirdStep()
        {
            Console.WriteLine("Third method executed.");
        }

        static void ProcessTask(CompleteDelegate callback)
        {
            Console.WriteLine("Task is running...");
            Console.WriteLine("Task finished.");

            callback?.Invoke();
        }

        static void OnTaskComplete()
        {
            Console.WriteLine("Callback executed after task completion.");
        }

        static void Attack()
        {
            Console.WriteLine("Player attacks the enemy.");
        }

        static void Heal()
        {
            Console.WriteLine("Player restores health.");
        }

        static void Defend()
        {
            Console.WriteLine("Player blocks incoming damage.");
        }

        static void SaveGame()
        {
            Console.WriteLine("Game saved.");
        }

        static void LoadGame()
        {
            Console.WriteLine("Game loaded.");
        }

        static void ExitGame()
        {
            Console.WriteLine("Game exited.");
        }

        static double AddDouble(double a, double b)
        {
            return a + b;
        }

        static double SubtractDouble(double a, double b)
        {
            return a - b;
        }

        static double MultiplyDouble(double a, double b)
        {
            return a * b;
        }

        static double DivideDouble(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }

            return a / b;
        }

        static void ExecuteMessage(MessageDelegate message)
        {
            message?.Invoke();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 1: BASIC DELEGATE");
            Console.WriteLine("=========================================");

            MessageDelegate message = ShowMessage;

            message();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 2: DELEGATE WITH PARAMETERS");
            Console.WriteLine("=========================================");

            GreetingDelegate greeting = GreetUser;

            greeting("Peyman");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 3: DELEGATE WITH RETURN VALUE");
            Console.WriteLine("=========================================");

            MathDelegate mathOperation = Add;
            Console.WriteLine($"Add: {mathOperation(10, 5)}");

            mathOperation = Subtract;
            Console.WriteLine($"Subtract: {mathOperation(10, 5)}");

            mathOperation = Multiply;
            Console.WriteLine($"Multiply: {mathOperation(10, 5)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 4: PASS A DELEGATE AS A PARAMETER");
            Console.WriteLine("=========================================");

            ExecuteMessage(SayHello);
            ExecuteMessage(SayGoodbye);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 5: MULTICAST DELEGATE");
            Console.WriteLine("=========================================");

            MessageDelegate steps = FirstStep;
            steps += SecondStep;
            steps += ThirdStep;

            steps();

            Console.WriteLine("After removing one method:");

            steps -= SecondStep;
            steps();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 6: NULL-SAFE INVOCATION");
            Console.WriteLine("=========================================");

            MessageDelegate safeMessage = null;

            safeMessage?.Invoke();

            safeMessage = ShowMessage;

            safeMessage?.Invoke();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 7: ANONYMOUS METHOD");
            Console.WriteLine("=========================================");

            MessageDelegate anonymousMessage =
                delegate ()
                {
                    Console.WriteLine("This message comes from an anonymous method.");
                };

            anonymousMessage();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 8: LAMBDA EXPRESSION");
            Console.WriteLine("=========================================");

            MessageDelegate lambdaMessage =
                () => Console.WriteLine("This message comes from a lambda expression.");

            lambdaMessage();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 9: ACTION");
            Console.WriteLine("=========================================");

            Action action =
                () => Console.WriteLine("Action executed successfully.");

            action();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 10: FUNC");
            Console.WriteLine("=========================================");

            Func<int, int, int> addFunction =
                (a, b) => a + b;

            Console.WriteLine($"Func Result: {addFunction(20, 10)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 11: PREDICATE");
            Console.WriteLine("=========================================");

            Predicate<int> isPositive =
                number => number > 0;

            Console.WriteLine($"10 is positive: {isPositive(10)}");
            Console.WriteLine($"-5 is positive: {isPositive(-5)}");
            Console.WriteLine($"0 is positive: {isPositive(0)}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 12: CALLBACK SYSTEM");
            Console.WriteLine("=========================================");

            ProcessTask(OnTaskComplete);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 13: GAME ACTION DELEGATE");
            Console.WriteLine("=========================================");

            GameActionDelegate gameAction = Attack;
            gameAction();

            gameAction = Heal;
            gameAction();

            gameAction = Defend;
            gameAction();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 14: MENU COMMAND SYSTEM");
            Console.WriteLine("=========================================");

            MenuCommandDelegate menuCommand = SaveGame;
            menuCommand();

            menuCommand = LoadGame;
            menuCommand();

            menuCommand = ExitGame;
            menuCommand();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 15: ADVANCED DELEGATE CALCULATOR");
            Console.WriteLine("=========================================");

            CalculatorDelegate calculator = AddDouble;
            Console.WriteLine($"10 + 5 = {calculator(10, 5)}");

            calculator = SubtractDouble;
            Console.WriteLine($"10 - 5 = {calculator(10, 5)}");

            calculator = MultiplyDouble;
            Console.WriteLine($"10 * 5 = {calculator(10, 5)}");

            calculator = DivideDouble;
            Console.WriteLine($"10 / 5 = {calculator(10, 5)}");

            Console.WriteLine();

            Console.WriteLine("Delegates Task Solutions Completed!");
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
