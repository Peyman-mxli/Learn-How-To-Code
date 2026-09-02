using System;

/*
    ============================================================
    RECORDS NOTES
    ============================================================

    In this module, I learn about Records.

    Records were introduced in C# 9 to simplify the creation
    of data-focused objects.

    Many classes exist only to store information.

    Before records, developers often had to write:

    - Constructors
    - Properties
    - Equals()
    - GetHashCode()
    - ToString()

    Records automatically generate much of this code.

    ============================================================
    WHAT IS A RECORD?
    ============================================================

    A record is a reference type designed primarily for storing data.

    Example:

        public record Person(string Name, int Age);

    This single line creates:

    - A constructor
    - Properties
    - Value equality support
    - ToString()
    - GetHashCode()

    ============================================================
    WHY RECORDS EXIST
    ============================================================

    Records reduce boilerplate code.

    Traditional class:

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

    Record:

        public record Person(string Name, int Age);

    Much shorter and cleaner.

    ============================================================
    POSITIONAL RECORDS
    ============================================================

    Positional records define properties directly
    in the record declaration.

    Example:

        public record Student(
            string Name,
            int Age,
            string Major
        );

    Automatically creates:

        public string Name { get; init; }
        public int Age { get; init; }
        public string Major { get; init; }

    ============================================================
    PROPERTY-BASED RECORDS
    ============================================================

    Records can also be written like classes.

    Example:

        public record Product
        {
            public int Id { get; init; }
            public string Name { get; init; }
            public decimal Price { get; init; }
        }

    This style gives more flexibility.

    ============================================================
    VALUE-BASED EQUALITY
    ============================================================

    Classes compare references by default.

    Example:

        Person p1 = new Person("Peyman", 25);
        Person p2 = new Person("Peyman", 25);

        Console.WriteLine(p1 == p2);

    Class Output:

        False

    Record Output:

        True

    Records compare actual values.

    This is one of their biggest advantages.

    ============================================================
    REFERENCE EQUALITY VS VALUE EQUALITY
    ============================================================

    Reference Equality:

    Two objects are equal only if they point
    to the same memory location.

    Value Equality:

    Two objects are equal if their data matches.

    Records use value equality.

    ============================================================
    IMMUTABILITY
    ============================================================

    Records encourage immutable data.

    Immutable means:

    Once created, data should not change.

    Example:

        public record User(
            string Name,
            int Age
        );

        User user = new User("Peyman", 25);

    Properties use:

        init

    instead of:

        set

    Meaning values are assigned only during creation.

    ============================================================
    INIT ACCESSOR
    ============================================================

    Example:

        public string Name { get; init; }

    init means:

    - Value can be assigned during object creation
    - Cannot be changed afterward

    Safer than public setters.

    ============================================================
    WITH EXPRESSIONS
    ============================================================

    Records support cloning with modifications.

    Example:

        User user1 =
            new User("Peyman", 25);

        User user2 =
            user1 with { Age = 26 };

    Result:

        user1 remains unchanged
        user2 is a copy with new values

    This is extremely useful in modern applications.

    ============================================================
    TOSTRING()
    ============================================================

    Records automatically generate ToString().

    Example:

        Person person =
            new Person("Peyman", 25);

        Console.WriteLine(person);

    Output:

        Person { Name = Peyman, Age = 25 }

    Useful for debugging.

    ============================================================
    RECORD INHERITANCE
    ============================================================

    Records can inherit from other records.

    Example:

        public record Person(
            string Name
        );

        public record Employee(
            string Name,
            string Department
        ) : Person(Name);

    Inheritance works similarly to classes.

    ============================================================
    RECORD STRUCTS
    ============================================================

    C# also supports record structs.

    Example:

        public record struct Point(
            int X,
            int Y
        );

    Characteristics:

    - Value type
    - Stored differently than classes
    - Supports value equality

    ============================================================
    RECORD CLASS
    ============================================================

    These are equivalent:

        public record Person(string Name);

        public record class Person(string Name);

    record class is explicit.

    ============================================================
    RECORD VS CLASS
    ============================================================

    Use Class When:

    - Object behavior is important
    - Mutable data is needed
    - Complex business logic exists

    Use Record When:

    - Data storage is primary purpose
    - Immutability is desired
    - Value equality is needed
    - DTOs are being created

    ============================================================
    COMMON USE CASES
    ============================================================

    1. API Responses

        public record UserResponse(
            int Id,
            string Name
        );

    ------------------------------------------------------------

    2. Configuration Data

        public record DatabaseSettings(
            string Server,
            string Database
        );

    ------------------------------------------------------------

    3. DTOs

        public record ProductDto(
            int Id,
            string Name,
            decimal Price
        );

    ------------------------------------------------------------

    4. Domain Models

        public record Address(
            string Street,
            string City
        );

    ============================================================
    BENEFITS OF RECORDS
    ============================================================

    - Less code
    - Better readability
    - Built-in equality
    - Immutability support
    - Cleaner models
    - Easier maintenance
    - Modern C# development

    ============================================================
    SUMMARY
    ============================================================

    Records are specialized reference types designed
    for storing data efficiently.

    Key features:

    - Value equality
    - Immutability support
    - Cleaner syntax
    - Built-in methods
    - with expressions
    - Ideal for DTOs and models

    Records are one of the most useful modern
    features added to C#.
*/

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
