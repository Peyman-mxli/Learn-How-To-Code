```csharp
using System;

namespace LearnHowToCode.Exceptions
{
    class ExceptionsNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        EXCEPTIONS NOTES
        ============================================================

        In this module, I learn about Exceptions.

        Exceptions are runtime errors that occur
        while a program is executing.

        Without exception handling, many errors
        would cause a program to crash.

        C# provides tools that allow me to
        detect, handle, and recover from errors.

        Exception handling is a critical skill
        for building reliable applications.
    */

    /*
        ============================================================
        1. WHAT IS AN EXCEPTION?
        ============================================================

        An exception is an unexpected problem
        that occurs while a program is running.

        Examples:

        - Dividing by zero
        - Invalid user input
        - Missing files
        - Database failures
        - Network errors
        - Null references

        Exceptions interrupt normal execution.
    */

    /*
        ============================================================
        2. WHY EXCEPTION HANDLING MATTERS
        ============================================================

        Without exception handling:

        - Programs crash
        - Users lose data
        - Applications become unstable

        With exception handling:

        ✔ Better reliability

        ✔ Better user experience

        ✔ Easier debugging

        ✔ More professional software
    */

    /*
        ============================================================
        3. TRY BLOCK
        ============================================================

        The try block contains code that
        might generate an exception.

        Example:

            try
            {
                int result = 10 / 0;
            }

        If an exception occurs,
        execution jumps to catch.
    */

    /*
        ============================================================
        4. CATCH BLOCK
        ============================================================

        The catch block handles exceptions.

        Example:

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

        This prevents the program from crashing.
    */

    /*
        ============================================================
        5. TRY-CATCH STRUCTURE
        ============================================================

        Example:

            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error handled.");
            }

        This is the most common pattern.
    */

    /*
        ============================================================
        6. FINALLY BLOCK
        ============================================================

        Finally always executes.

        Example:

            finally
            {
                Console.WriteLine("Cleanup completed.");
            }

        Common uses:

        - Closing files
        - Releasing resources
        - Database cleanup
    */

    /*
        ============================================================
        7. MULTIPLE CATCH BLOCKS
        ============================================================

        Different exceptions can be handled
        differently.

        Example:

            try
            {

            }
            catch (FormatException)
            {

            }
            catch (DivideByZeroException)
            {

            }

        Each exception type gets
        its own handling logic.
    */

    /*
        ============================================================
        8. COMMON EXCEPTION TYPES
        ============================================================

        DivideByZeroException

            Division by zero.

        FormatException

            Invalid format conversion.

        NullReferenceException

            Accessing null objects.

        IndexOutOfRangeException

            Invalid array index.

        FileNotFoundException

            Missing file.

        OverflowException

            Numeric overflow.
    */

    /*
        ============================================================
        9. DIVIDE BY ZERO EXCEPTION
        ============================================================

        Example:

            int result = 10 / 0;

        Result:

            DivideByZeroException

        Always validate divisors
        before performing division.
    */

    /*
        ============================================================
        10. FORMAT EXCEPTION
        ============================================================

        Example:

            int age = int.Parse("Hello");

        Result:

            FormatException

        Input is not a valid number.
    */

    /*
        ============================================================
        11. NULL REFERENCE EXCEPTION
        ============================================================

        Example:

            string name = null;

            Console.WriteLine(name.Length);

        Result:

            NullReferenceException

        The object does not exist.
    */

    /*
        ============================================================
        12. INDEX OUT OF RANGE EXCEPTION
        ============================================================

        Example:

            int[] numbers = { 1, 2, 3 };

            Console.WriteLine(numbers[10]);

        Result:

            IndexOutOfRangeException

        The index does not exist.
    */

    /*
        ============================================================
        13. THROW KEYWORD
        ============================================================

        I can create exceptions manually.

        Example:

            throw new Exception("Custom error");

        This forces an exception to occur.

        Useful for validation.
    */

    /*
        ============================================================
        14. CUSTOM VALIDATION
        ============================================================

        Example:

            if(age < 0)
            {
                throw new Exception("Age cannot be negative.");
            }

        This protects invalid data.
    */

    /*
        ============================================================
        15. EXCEPTION OBJECT
        ============================================================

        Example:

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        Common properties:

            ex.Message
            ex.StackTrace
            ex.Source
    */

    /*
        ============================================================
        16. GENERAL EXCEPTION CATCHING
        ============================================================

        Example:

            catch(Exception ex)

        This catches almost all exceptions.

        Useful as a final safety net.

        However, specific exceptions
        should be handled first.
    */

    /*
        ============================================================
        17. BEST PRACTICES
        ============================================================

        ✔ Catch specific exceptions

        ✔ Use finally when needed

        ✔ Validate input

        ✔ Log important errors

        ✔ Display user-friendly messages

        ✔ Avoid empty catch blocks
    */

    /*
        ============================================================
        18. COMMON BEGINNER MISTAKES
        ============================================================

        Mistake #1

        Ignoring exceptions.

        ------------------------------------------------

        Mistake #2

        Catching everything
        without understanding the cause.

        ------------------------------------------------

        Mistake #3

        Using empty catch blocks.

        Example:

            catch
            {

            }

        This hides errors.
    */

    /*
        ============================================================
        19. REAL-WORLD SOFTWARE
        ============================================================

        Exceptions are used everywhere:

        - Banking systems
        - Mobile apps
        - Video games
        - APIs
        - Desktop software
        - Web applications

        Professional applications rely
        heavily on exception handling.
    */

    /*
        ============================================================
        20. WHEN TO USE EXCEPTIONS
        ============================================================

        Use exceptions when:

        - Something unexpected happens
        - Data is invalid
        - Files are missing
        - Connections fail
        - Resources cannot be accessed

        Exceptions help protect
        application stability.
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Exceptions allow me to:

        - Detect errors
        - Handle failures safely
        - Prevent crashes
        - Improve reliability
        - Build professional applications

        Exception handling is one of the
        most important defensive programming
        techniques in C#.
    */
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
