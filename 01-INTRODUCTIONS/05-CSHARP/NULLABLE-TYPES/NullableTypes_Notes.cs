using System;

/*
    ============================================================
    NULLABLE TYPES NOTES
    ============================================================

    In this module, I learn about Nullable Types.

    Nullable types allow variables to hold a normal value
    or no value at all.

    In C#, the word used for no value is:

        null

    Null means:

        nothing
        missing
        unknown
        not assigned

    ============================================================
    WHY NULL MATTERS
    ============================================================

    In real applications, data is not always available.

    Examples:

    - A user may not enter a phone number
    - A database field may be empty
    - An API response may not contain a value
    - A file may not have optional information
    - A form field may be skipped

    Nullable types help me handle these cases safely.

    ============================================================
    VALUE TYPES AND NULL
    ============================================================

    Normal value types cannot store null.

    Example:

        int age = null;

    This is not allowed.

    Value types include:

    - int
    - double
    - bool
    - decimal
    - char
    - DateTime

    These types always need a value.

    ============================================================
    NULLABLE VALUE TYPES
    ============================================================

    To allow a value type to store null,
    I add the ? symbol.

    Example:

        int? age = null;

    This means:

        age can store an integer
        or age can store null

    Other examples:

        double? price = null;
        bool? isActive = null;
        DateTime? birthDate = null;

    ============================================================
    NULLABLE<T>
    ============================================================

    This syntax:

        int? age

    is a shorter version of:

        Nullable<int> age

    Both mean the same thing.

    Example:

        Nullable<int> score = null;

    ============================================================
    HASVALUE
    ============================================================

    Nullable value types have a property called HasValue.

    Example:

        int? age = 25;

        if (age.HasValue)
        {
            Console.WriteLine("Age exists");
        }

    HasValue returns true if the variable is not null.

    ============================================================
    VALUE PROPERTY
    ============================================================

    Nullable value types also have a Value property.

    Example:

        int? age = 25;

        Console.WriteLine(age.Value);

    Important:

    If the variable is null and I use .Value,
    the program will crash.

    Bad example:

        int? age = null;
        Console.WriteLine(age.Value);

    This causes an error.

    ============================================================
    SAFE NULL CHECKING
    ============================================================

    Better way:

        int? age = null;

        if (age.HasValue)
        {
            Console.WriteLine(age.Value);
        }
        else
        {
            Console.WriteLine("Age is unknown");
        }

    This avoids errors.

    ============================================================
    NULL COALESCING OPERATOR ??
    ============================================================

    The ?? operator gives a default value when something is null.

    Example:

        int? age = null;

        int finalAge = age ?? 0;

    Meaning:

        If age has a value, use it.
        If age is null, use 0.

    ============================================================
    STRING EXAMPLE WITH ??
    ============================================================

    Example:

        string name = null;

        string finalName = name ?? "Unknown";

    If name is null, finalName becomes "Unknown".

    ============================================================
    NULL COALESCING ASSIGNMENT ??=
    ============================================================

    The ??= operator assigns a value only if
    the variable is currently null.

    Example:

        string username = null;

        username ??= "Guest";

    Meaning:

        If username is null, set it to "Guest".
        If username already has a value, keep it.

    ============================================================
    NULL CONDITIONAL OPERATOR ?.
    ============================================================

    The ?. operator safely accesses members
    only if the object is not null.

    Example:

        string name = null;

        int? length = name?.Length;

    If name is null, length becomes null.
    The program does not crash.

    ============================================================
    NORMAL ACCESS VS SAFE ACCESS
    ============================================================

    Unsafe:

        string name = null;
        Console.WriteLine(name.Length);

    This causes NullReferenceException.

    Safe:

        string name = null;
        Console.WriteLine(name?.Length);

    This does not crash.

    ============================================================
    NULLABLE REFERENCE TYPES
    ============================================================

    Reference types can normally be null.

    Reference types include:

    - string
    - class objects
    - arrays
    - lists
    - interfaces

    Modern C# supports nullable reference type warnings.

    Example:

        string? phoneNumber = null;

    The ? means:

        This reference is allowed to be null.

    ============================================================
    NON-NULLABLE REFERENCE TYPES
    ============================================================

    Example:

        string name = "Peyman";

    This means name should not be null.

    If nullable reference types are enabled,
    the compiler warns me when I use possible null values.

    ============================================================
    NULL FORGIVING OPERATOR !
    ============================================================

    The ! operator tells the compiler:

        I know this value is not null.

    Example:

        string? name = "Peyman";

        Console.WriteLine(name!.Length);

    Important:

    This does not remove null at runtime.
    It only removes compiler warning.

    Use carefully.

    ============================================================
    COMMON NULL ERROR
    ============================================================

    NullReferenceException happens when I try to use
    something that is null.

    Example:

        string message = null;
        Console.WriteLine(message.Length);

    message has no object, so Length cannot be accessed.

    ============================================================
    REAL-WORLD EXAMPLE
    ============================================================

    Example:

        public class UserProfile
        {
            public string Name { get; set; }
            public string? PhoneNumber { get; set; }
        }

    Name is required.
    PhoneNumber is optional.

    ============================================================
    WHEN TO USE NULLABLE TYPES
    ============================================================

    Use nullable types when:

    - A value is optional
    - A value may be missing
    - A database column allows null
    - An API response may not return data
    - A form field is not required

    ============================================================
    WHEN NOT TO USE NULLABLE TYPES
    ============================================================

    Do not use nullable types when:

    - A value is always required
    - Missing data is not valid
    - The object should always exist
    - The program cannot continue without it

    ============================================================
    COMMON USE CASES
    ============================================================

    1. Optional Age

        int? age = null;

    ------------------------------------------------------------

    2. Optional Price

        decimal? discountPrice = null;

    ------------------------------------------------------------

    3. Optional Phone Number

        string? phoneNumber = null;

    ------------------------------------------------------------

    4. Optional Date

        DateTime? completedDate = null;

    ============================================================
    BENEFITS OF NULLABLE TYPES
    ============================================================

    - Safer code
    - Better handling of missing data
    - Fewer runtime crashes
    - Cleaner validation
    - Better communication of intent
    - More professional code

    ============================================================
    SUMMARY
    ============================================================

    Nullable types help me represent missing data safely.

    Important tools:

    - ?
    - ??
    - ??=
    - ?.
    - HasValue
    - Value
    - is null
    - is not null

    Understanding nullable types helps me avoid
    NullReferenceException and write safer C# programs.
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
