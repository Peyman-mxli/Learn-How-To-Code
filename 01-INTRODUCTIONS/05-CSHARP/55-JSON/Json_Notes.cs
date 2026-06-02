```csharp id="e7f4p2"
/*
    ============================================================
    MODULE: 55 - JSON
    FILE: Json_Notes.cs
    ============================================================

    JSON is one of the most important
    data formats in modern software development.

    JSON is widely used for:

    - APIs
    - Web Applications
    - Mobile Applications
    - Configuration Files
    - Databases
    - Cloud Services
    - Games

    Understanding JSON is essential
    for professional C# development.

    ============================================================
    WHAT DOES JSON MEAN?
    ============================================================

    JSON means:

        JavaScript Object Notation

    Even though the name includes JavaScript,
    JSON is used by many programming languages,
    including C#.

    ============================================================
    WHAT IS JSON?
    ============================================================

    JSON is a text-based format used
    to store and exchange data.

    Example:

        {
            "name": "Peyman",
            "age": 25
        }

    JSON is:

    ✓ Lightweight

    ✓ Human-readable

    ✓ Easy to parse

    ✓ Language-independent

    ============================================================
    JSON STRUCTURE
    ============================================================

    JSON uses:

    - Curly braces {}
    - Square brackets []
    - Key/value pairs

    Example:

        {
            "name": "Nova",
            "level": 50
        }

    ============================================================
    KEY/VALUE PAIRS
    ============================================================

    JSON stores information using:

        "key": value

    Example:

        "name": "Peyman"

    Key:

        "name"

    Value:

        "Peyman"

    ============================================================
    JSON DATA TYPES
    ============================================================

    JSON supports:

    Strings

        "Peyman"

    Numbers

        25

        99.5

    Booleans

        true

        false

    Null

        null

    Objects

        { }

    Arrays

        [ ]

    ============================================================
    JSON OBJECTS
    ============================================================

    Objects use curly braces.

    Example:

        {
            "id": 1,
            "name": "Peyman"
        }

    Objects can contain multiple properties.

    ============================================================
    JSON ARRAYS
    ============================================================

    Arrays use square brackets.

    Example:

        [
            "Sword",
            "Shield",
            "Potion"
        ]

    Arrays store multiple values.

    ============================================================
    NESTED OBJECTS
    ============================================================

    JSON objects can contain
    other objects.

    Example:

        {
            "player":
            {
                "name": "Nova",
                "level": 80
            }
        }

    ============================================================
    JSON ARRAY OF OBJECTS
    ============================================================

    Example:

        [
            {
                "name": "Peyman"
            },
            {
                "name": "Nova"
            }
        ]

    Very common in APIs.

    ============================================================
    WHY JSON IS IMPORTANT
    ============================================================

    JSON is commonly used for:

    - APIs
    - Server communication
    - Saving settings
    - Sending data between applications
    - Web services
    - Cloud systems

    Most modern APIs return JSON.

    ============================================================
    JSON IN C#
    ============================================================

    Modern C# commonly uses:

        System.Text.Json

    Namespace:

        using System.Text.Json;

    ============================================================
    SERIALIZATION
    ============================================================

    Serialization means:

        Converting a C# object into JSON.

    Example:

        Person person =
            new Person();

        string json =
            JsonSerializer.Serialize(person);

    C# Object
            ↓
        JSON Text

    ============================================================
    DESERIALIZATION
    ============================================================

    Deserialization means:

        Converting JSON into a C# object.

    Example:

        Person person =
            JsonSerializer.Deserialize<Person>(json);

    JSON Text
            ↓
        C# Object

    ============================================================
    SIMPLE SERIALIZATION EXAMPLE
    ============================================================

    Example:

        Person person =
            new Person
            {
                Name = "Peyman",
                Age = 25
            };

        string json =
            JsonSerializer.Serialize(person);

    Result:

        {
            "Name":"Peyman",
            "Age":25
        }

    ============================================================
    SIMPLE DESERIALIZATION EXAMPLE
    ============================================================

    Example:

        string json =
            "{\"Name\":\"Nova\",\"Age\":30}";

        Person person =
            JsonSerializer.Deserialize<Person>(json);

    ============================================================
    PRETTY PRINT JSON
    ============================================================

    JSON can be formatted for readability.

    Example:

        JsonSerializerOptions options =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

    Result:

        Nicely formatted JSON.

    ============================================================
    JSON PROPERTY NAMES
    ============================================================

    JSON property names are usually strings.

    Example:

        {
            "username": "Peyman"
        }

    Naming conventions often use:

    camelCase

        userName

    or

    PascalCase

        UserName

    ============================================================
    NULL VALUES
    ============================================================

    JSON supports null values.

    Example:

        {
            "name": null
        }

    Useful when data is missing.

    ============================================================
    JSON FILES
    ============================================================

    JSON is often stored in files.

    Example extension:

        .json

    Example files:

    - appsettings.json
    - configuration.json
    - gameData.json

    ============================================================
    COMMON JSON ERRORS
    ============================================================

    Examples:

    Missing comma

        {
            "name": "Peyman"
            "age": 25
        }

    Invalid quotes

        {
            name: "Peyman"
        }

    JSON requires double quotes.

    ============================================================
    JSON AND APIS
    ============================================================

    APIs commonly return JSON.

    Example response:

        {
            "id": 1,
            "title": "Post Title"
        }

    C# applications deserialize
    this data into objects.

    ============================================================
    BENEFITS OF JSON
    ============================================================

    ✓ Lightweight

    ✓ Readable

    ✓ Easy to use

    ✓ Cross-platform

    ✓ API-friendly

    ✓ Human-readable

    ✓ Language-independent

    ============================================================
    LIMITATIONS OF JSON
    ============================================================

    JSON is text-based.

    Large JSON files can:

    - Increase memory usage
    - Reduce performance

    Complex structures can become difficult to manage.

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Use System.Text.Json

    ✓ Validate JSON data

    ✓ Handle exceptions

    ✓ Use proper property names

    ✓ Keep JSON clean and readable

    ✓ Use WriteIndented when debugging

    ✓ Match JSON structure with C# classes

    ✓ Avoid unnecessary complexity

    ============================================================
    SUMMARY
    ============================================================

    JSON is one of the most important
    technologies in modern software development.

    Important concepts include:

    - JSON Objects
    - JSON Arrays
    - Key/Value Pairs
    - Serialization
    - Deserialization
    - System.Text.Json

    JSON is heavily used in:

    - APIs
    - Web Development
    - Mobile Apps
    - Cloud Systems
    - Game Development

    Understanding JSON is essential
    for professional C# programming.
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
```
