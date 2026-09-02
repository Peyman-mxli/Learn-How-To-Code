using System;

/*
    ============================================================
    EXTENSION METHODS NOTES
    ============================================================

    In this module, I learn about Extension Methods.

    Extension methods allow me to add new methods to existing
    types without changing the original source code.

    This means I can make a class, struct, string, int, list,
    or other type appear to have extra methods.

    ============================================================
    WHAT IS AN EXTENSION METHOD?
    ============================================================

    An extension method is a static method that behaves like
    an instance method.

    Example:

        string name = "peyman";

        string result = name.Capitalize();

    Capitalize() looks like it belongs to string,
    but it is actually an extension method.

    ============================================================
    WHY EXTENSION METHODS EXIST
    ============================================================

    Extension methods help me:

    - Add reusable helper methods
    - Improve readability
    - Avoid repeating code
    - Keep original classes unchanged
    - Write cleaner professional code

    ============================================================
    EXTENSION METHOD RULES
    ============================================================

    To create an extension method:

    1. The method must be inside a static class.
    2. The method itself must be static.
    3. The first parameter must use the this keyword.
    4. The this parameter defines the type being extended.

    Example:

        public static class StringExtensions
        {
            public static string AddExclamation(this string text)
            {
                return text + "!";
            }
        }

    ============================================================
    THE THIS KEYWORD
    ============================================================

    In extension methods, this tells C# what type
    the method extends.

    Example:

        public static string AddExclamation(this string text)

    This means:

        AddExclamation can be called on a string.

    Usage:

        string message = "Hello";
        Console.WriteLine(message.AddExclamation());

    ============================================================
    EXTENDING STRING
    ============================================================

    Example:

        public static string Capitalize(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

    Usage:

        string name = "peyman";
        Console.WriteLine(name.Capitalize());

    Output:

        Peyman

    ============================================================
    EXTENDING INT
    ============================================================

    Example:

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

    Usage:

        int number = 10;

        if (number.IsEven())
        {
            Console.WriteLine("Even");
        }

    ============================================================
    EXTENDING DOUBLE
    ============================================================

    Example:

        public static double Square(this double number)
        {
            return number * number;
        }

    Usage:

        double value = 5;
        Console.WriteLine(value.Square());

    ============================================================
    EXTENSION METHODS WITH PARAMETERS
    ============================================================

    Extension methods can accept extra parameters.

    Example:

        public static string Repeat(this string text, int times)
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += text;
            }

            return result;
        }

    Usage:

        Console.WriteLine("Hi".Repeat(3));

    Output:

        HiHiHi

    ============================================================
    EXTENSION METHODS DO NOT MODIFY ORIGINAL TYPES
    ============================================================

    Extension methods do not actually change the original class.

    They only allow me to call helper methods using dot syntax.

    Example:

        string text = "Hello";

        text.AddExclamation();

    The string class itself is not changed.

    ============================================================
    EXTENSION METHODS AND NAMESPACES
    ============================================================

    Extension methods must be in scope.

    If the extension method is in another namespace,
    I must import it using:

        using MyExtensions;

    Otherwise, C# will not find the method.

    ============================================================
    EXTENSION METHOD PRIORITY
    ============================================================

    If a real instance method exists with the same name,
    C# uses the real instance method first.

    Extension methods are only used when no matching
    instance method exists.

    ============================================================
    COMMON REAL-WORLD USE CASES
    ============================================================

    1. String Formatting

        name.Capitalize();

    ------------------------------------------------------------

    2. Number Checking

        number.IsEven();

    ------------------------------------------------------------

    3. Validation

        email.IsValidEmail();

    ------------------------------------------------------------

    4. Display Formatting

        price.ToCurrency();

    ------------------------------------------------------------

    5. Collection Helpers

        items.IsEmpty();

    ============================================================
    EXTENSION METHODS IN LINQ
    ============================================================

    LINQ uses extension methods heavily.

    Examples:

        numbers.Where(n => n > 5);
        numbers.Select(n => n * 2);
        numbers.Count();

    These methods feel like they belong to the collection,
    but they are extension methods.

    ============================================================
    ADVANTAGES OF EXTENSION METHODS
    ============================================================

    - Cleaner syntax
    - Better readability
    - Reusable helper logic
    - No need to modify original class
    - Works with built-in types
    - Works with custom types

    ============================================================
    COMMON MISTAKES
    ============================================================

    Mistake #1:
    Forgetting to make the class static.

    ------------------------------------------------------------

    Mistake #2:
    Forgetting to make the method static.

    ------------------------------------------------------------

    Mistake #3:
    Forgetting the this keyword in the first parameter.

    ------------------------------------------------------------

    Mistake #4:
    Putting the this keyword on the wrong parameter.

    ------------------------------------------------------------

    Mistake #5:
    Forgetting to import the namespace.

    ============================================================
    WHEN TO USE EXTENSION METHODS
    ============================================================

    Use extension methods when:

    - I want cleaner helper methods
    - I cannot modify the original class
    - The method logically belongs to the type
    - I want reusable formatting or validation logic

    ============================================================
    WHEN NOT TO USE EXTENSION METHODS
    ============================================================

    Do not use extension methods when:

    - The method does not logically relate to the type
    - The code becomes confusing
    - A normal class method would be clearer
    - The extension method hides important logic

    ============================================================
    SUMMARY
    ============================================================

    Extension methods allow me to add helpful methods
    to existing types without modifying them.

    Important rules:

    - Static class
    - Static method
    - First parameter uses this
    - Method must be in scope

    Extension methods are very common in modern C#,
    especially in LINQ and reusable helper code.
*/

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
