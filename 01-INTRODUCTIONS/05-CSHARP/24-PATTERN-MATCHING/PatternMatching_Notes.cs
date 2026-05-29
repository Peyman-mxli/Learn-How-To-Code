using System;

/*
    ============================================================
    PATTERN MATCHING NOTES
    ============================================================

    In this module, I learn about Pattern Matching.

    Pattern Matching is a modern C# feature that allows
    me to check values, types, properties, and conditions
    in a clean and readable way.

    It helps reduce complex if-else chains and makes code
    easier to understand and maintain.

    Pattern Matching became much more powerful in C# 7, 8,
    9, 10, and later versions.

    ============================================================
    WHAT IS PATTERN MATCHING?
    ============================================================

    Pattern Matching allows me to test an object against
    a specific pattern.

    Examples:

    - Type Pattern
    - Constant Pattern
    - Relational Pattern
    - Logical Pattern
    - Property Pattern
    - Switch Pattern

    Instead of writing complicated conditions,
    I can describe the shape of the data I want.

    ============================================================
    TYPE PATTERNS
    ============================================================

    Type patterns check if an object belongs
    to a specific type.

    Example:

        object value = "Hello";

        if (value is string text)
        {
            Console.WriteLine(text);
        }

    Explanation:

    - Checks whether value is a string
    - Creates variable text
    - Automatically casts the value

    Benefits:

    - Safer
    - Cleaner
    - No manual casting

    ============================================================
    OLD STYLE VS TYPE PATTERN
    ============================================================

    Old Style:

        if (value is string)
        {
            string text = (string)value;
        }

    Pattern Matching:

        if (value is string text)
        {
            Console.WriteLine(text);
        }

    Much shorter and safer.

    ============================================================
    CONSTANT PATTERNS
    ============================================================

    Constant patterns compare values against
    fixed constants.

    Example:

        int number = 5;

        if (number is 5)
        {
            Console.WriteLine("Matched");
        }

    Useful for:

    - Status codes
    - Menu options
    - Game states
    - Validation

    ============================================================
    NULL PATTERN
    ============================================================

    Pattern matching can check null values.

    Example:

        string name = null;

        if (name is null)
        {
            Console.WriteLine("Null");
        }

    Opposite:

        if (name is not null)
        {
            Console.WriteLine(name);
        }

    Modern and readable.

    ============================================================
    RELATIONAL PATTERNS
    ============================================================

    Relational patterns compare values.

    Operators:

        <
        >
        <=
        >=

    Example:

        int age = 20;

        if (age is >= 18)
        {
            Console.WriteLine("Adult");
        }

    ============================================================
    MULTIPLE RELATIONAL PATTERNS
    ============================================================

    Example:

        int score = 85;

        if (score is >= 80 and <= 100)
        {
            Console.WriteLine("Passed");
        }

    Cleaner than:

        if(score >= 80 && score <= 100)

    ============================================================
    LOGICAL PATTERNS
    ============================================================

    Logical patterns combine multiple conditions.

    Keywords:

        and
        or
        not

    ============================================================
    AND PATTERN
    ============================================================

    Example:

        int age = 25;

        if(age is >= 18 and <= 65)
        {
            Console.WriteLine("Working Age");
        }

    ============================================================
    OR PATTERN
    ============================================================

    Example:

        string role = "Admin";

        if(role is "Admin" or "Manager")
        {
            Console.WriteLine("Access Granted");
        }

    ============================================================
    NOT PATTERN
    ============================================================

    Example:

        if(role is not "Guest")
        {
            Console.WriteLine("Allowed");
        }

    ============================================================
    SWITCH EXPRESSIONS
    ============================================================

    Modern switch expressions are one of the
    most common uses of pattern matching.

    Example:

        string role = "Admin";

        string result = role switch
        {
            "Admin" => "Full Access",
            "User" => "Basic Access",
            _ => "Unknown"
        };

    Benefits:

    - Cleaner
    - Shorter
    - Easier to maintain

    ============================================================
    PROPERTY PATTERNS
    ============================================================

    Property patterns inspect object properties.

    Example:

        public class Person
        {
            public int Age { get; set; }
        }

        Person person =
            new Person { Age = 25 };

        if(person is { Age: >= 18 })
        {
            Console.WriteLine("Adult");
        }

    Very useful when working with objects.

    ============================================================
    NESTED PROPERTY PATTERNS
    ============================================================

    Example:

        if(order is
        {
            Customer:
            {
                Age: >= 18
            }
        })
        {
            Console.WriteLine("Valid");
        }

    Patterns can be nested deeply.

    ============================================================
    PATTERN MATCHING WITH RECORDS
    ============================================================

    Records work extremely well with patterns.

    Example:

        public record User(
            string Name,
            int Age
        );

        User user =
            new User("Peyman", 25);

        if(user is { Age: >= 18 })
        {
            Console.WriteLine("Adult");
        }

    ============================================================
    SWITCH WITH RELATIONAL PATTERNS
    ============================================================

    Example:

        int score = 88;

        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

    Very common in real projects.

    ============================================================
    PATTERN MATCHING WITH OBJECTS
    ============================================================

    Example:

        object item = 100;

        string result = item switch
        {
            int number => $"Integer {number}",
            string text => $"String {text}",
            bool value => $"Boolean {value}",
            _ => "Unknown"
        };

    Handles multiple types elegantly.

    ============================================================
    REAL-WORLD USE CASES
    ============================================================

    1. User Authentication

        role switch
        {
            "Admin" => FullAccess,
            "User" => BasicAccess,
            _ => NoAccess
        };

    ------------------------------------------------------------

    2. Grade Systems

        score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            _ => "F"
        };

    ------------------------------------------------------------

    3. API Response Processing

        response switch
        {
            SuccessResponse s => Process(s),
            ErrorResponse e => Handle(e),
            _ => Log()
        };

    ------------------------------------------------------------

    4. Game Development

        playerLevel switch
        {
            >= 100 => "Legend",
            >= 50 => "Hero",
            _ => "Novice"
        };

    ============================================================
    BENEFITS OF PATTERN MATCHING
    ============================================================

    - Cleaner code
    - Fewer casts
    - Better readability
    - Safer type checking
    - Less boilerplate code
    - Easier maintenance
    - Modern C# style

    ============================================================
    COMMON MISTAKES
    ============================================================

    Mistake #1

    Using old casting when pattern matching
    would be simpler.

    ------------------------------------------------------------

    Mistake #2

    Writing huge if-else chains instead
    of switch expressions.

    ------------------------------------------------------------

    Mistake #3

    Forgetting the default case (_).

    ============================================================
    SUMMARY
    ============================================================

    Pattern Matching is one of the most powerful
    modern features in C#.

    Key concepts:

    - Type Patterns
    - Constant Patterns
    - Relational Patterns
    - Logical Patterns
    - Property Patterns
    - Switch Expressions

    Pattern Matching helps me write cleaner,
    safer, and more professional code.
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
