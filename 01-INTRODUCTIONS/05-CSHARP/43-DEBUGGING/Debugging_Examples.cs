using System;

namespace DebuggingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("DEBUGGING EXAMPLES");
            Console.WriteLine("=================================");

            Example1_VariableInspection();

            Example2_MethodDebugging();

            Example3_ConditionalDebugging();

            Example4_LoopDebugging();

            Example5_ExceptionDebugging();

            Example6_LogicalErrorDebugging();

            Console.WriteLine("\nAll examples completed.");
        }

        // =========================================
        // Example 1
        // =========================================
        static void Example1_VariableInspection()
        {
            Console.WriteLine("\n--- Example 1: Variable Inspection ---");

            string firstName = "Peyman";
            int age = 25;
            double score = 95.5;

            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Score: {score}");

            /*
             Place a breakpoint on the line below.

             Inspect:
             - firstName
             - age
             - score

             using:
             - Locals Window
             - Watch Window
            */
        }

        // =========================================
        // Example 2
        // =========================================
        static void Example2_MethodDebugging()
        {
            Console.WriteLine("\n--- Example 2: Method Debugging ---");

            int result = AddNumbers(10, 20);

            Console.WriteLine($"Result: {result}");

            /*
             Put a breakpoint on AddNumbers().
             Press F11 (Step Into)
             and inspect the method execution.
            */
        }

        static int AddNumbers(int a, int b)
        {
            int total = a + b;

            return total;
        }

        // =========================================
        // Example 3
        // =========================================
        static void Example3_ConditionalDebugging()
        {
            Console.WriteLine("\n--- Example 3: Conditional Debugging ---");

            int age = 18;

            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            /*
             Place a breakpoint inside the IF block.

             Inspect:
             age

             Verify why the condition
             evaluates to true.
            */
        }

        // =========================================
        // Example 4
        // =========================================
        static void Example4_LoopDebugging()
        {
            Console.WriteLine("\n--- Example 4: Loop Debugging ---");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            /*
             Put a breakpoint inside the loop.

             Watch:
             i

             Use F10 (Step Over)
             to move through each iteration.
            */
        }

        // =========================================
        // Example 5
        // =========================================
        static void Example5_ExceptionDebugging()
        {
            Console.WriteLine("\n--- Example 5: Exception Debugging ---");

            try
            {
                int number = 10;
                int zero = 0;

                int result = number / zero;

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            /*
             Debug this example.

             Observe:
             - Exception type
             - Exception message
             - Line causing the problem
            */
        }

        // =========================================
        // Example 6
        // =========================================
        static void Example6_LogicalErrorDebugging()
        {
            Console.WriteLine("\n--- Example 6: Logical Error Debugging ---");

            int width = 5;
            int height = 10;

            int area = width + height;

            Console.WriteLine($"Area: {area}");

            /*
             This example contains
             a logical error.

             Expected area:
             width * height

             Actual code:
             width + height

             Use debugging tools
             to discover the problem.
            */
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
