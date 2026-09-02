using System;

/*
=========================================================
SERIALIZATION NOTES
=========================================================

Serialization is one of the most important concepts
in modern software development.

Many applications need to:

- Save data
- Load data
- Transfer data
- Store settings
- Send information over the internet

Serialization makes all of this possible.

=========================================================
WHAT IS SERIALIZATION?
=========================================================

Serialization is the process of converting an object
into a format that can be:

- Saved to a file
- Stored in a database
- Sent through a network
- Shared with another application

Example:

Person person = new Person();

becomes:

{
    "Name": "Peyman",
    "Age": 25
}

The object is converted into data.

=========================================================
WHAT IS DESERIALIZATION?
=========================================================

Deserialization is the opposite process.

Serialized data is converted back into an object.

Example:

JSON Data

{
    "Name": "Peyman",
    "Age": 25
}

becomes:

Person person = new Person();

The object is reconstructed from stored data.

=========================================================
WHY SERIALIZATION IS IMPORTANT
=========================================================

Without serialization:

- Objects cannot easily be stored
- Objects cannot easily be transferred
- APIs cannot communicate effectively

Serialization allows data to survive
after the program closes.

=========================================================
COMMON SERIALIZATION FORMATS
=========================================================

Several formats are used.

Most common:

1. JSON
2. XML
3. Binary

---------------------------------------------------------
JSON
---------------------------------------------------------

JavaScript Object Notation

Most popular format today.

Example:

{
    "Name": "Peyman",
    "Age": 25
}

Advantages:

✓ Human readable

✓ Lightweight

✓ API friendly

✓ Cross-platform

---------------------------------------------------------
XML
---------------------------------------------------------

Extensible Markup Language

Example:

<Person>
    <Name>Peyman</Name>
    <Age>25</Age>
</Person>

Advantages:

✓ Structured

✓ Widely supported

✓ Good for enterprise systems

---------------------------------------------------------
BINARY
---------------------------------------------------------

Stored as raw bytes.

Advantages:

✓ Smaller size

✓ Faster performance

Disadvantages:

✗ Difficult to read

✗ Difficult to debug

=========================================================
SYSTEM.TEXT.JSON
=========================================================

Modern .NET applications commonly use:

System.Text.Json

Namespace:

using System.Text.Json;

This namespace provides tools for:

- Serialization
- Deserialization

=========================================================
SERIALIZING AN OBJECT
=========================================================

Example:

string json =
    JsonSerializer.Serialize(person);

Result:

{
    "Name":"Peyman",
    "Age":25
}

The object becomes JSON text.

=========================================================
DESERIALIZING AN OBJECT
=========================================================

Example:

Person person =
    JsonSerializer.Deserialize<Person>(json);

The JSON text becomes a Person object.

=========================================================
PRETTY PRINTED JSON
=========================================================

JSON can be formatted for readability.

Example:

JsonSerializerOptions options =
    new JsonSerializerOptions
    {
        WriteIndented = true
    };

This creates cleaner JSON output.

=========================================================
SERIALIZING COLLECTIONS
=========================================================

Lists can also be serialized.

Example:

List<Person> people =
    new List<Person>();

string json =
    JsonSerializer.Serialize(people);

The entire collection is converted.

=========================================================
SERIALIZING ARRAYS
=========================================================

Arrays can also be serialized.

Example:

Person[] people =
{
    new Person(),
    new Person()
};

string json =
    JsonSerializer.Serialize(people);

=========================================================
SAVING JSON TO FILES
=========================================================

Serialized data is often saved to files.

Example:

string json =
    JsonSerializer.Serialize(person);

File.WriteAllText(
    "person.json",
    json);

A file is created.

=========================================================
READING JSON FROM FILES
=========================================================

Example:

string json =
    File.ReadAllText("person.json");

Person person =
    JsonSerializer.Deserialize<Person>(json);

The object is restored.

=========================================================
REAL-WORLD USE CASES
=========================================================

1. Game Save Files

Player progress is saved.

---------------------------------------------------------

2. Configuration Files

Application settings are stored.

---------------------------------------------------------

3. APIs

Data is exchanged between systems.

---------------------------------------------------------

4. Cloud Applications

Objects are transferred through networks.

---------------------------------------------------------

5. Mobile Apps

User data is stored locally.

---------------------------------------------------------

6. Databases

Objects are prepared for storage.

=========================================================
SERIALIZATION ATTRIBUTES
=========================================================

Attributes can control serialization behavior.

Examples:

[JsonIgnore]

Prevents a property from being serialized.

Example:

[JsonIgnore]
public string Password { get; set; }

Password will not appear in JSON.

=========================================================
ADVANTAGES OF SERIALIZATION
=========================================================

✓ Easy data storage

✓ Easy data transfer

✓ Human-readable formats

✓ API compatibility

✓ Platform independence

✓ Configuration support

=========================================================
DISADVANTAGES OF SERIALIZATION
=========================================================

✗ Extra processing time

✗ Large objects create larger files

✗ Sensitive information may be exposed

✗ Incorrect deserialization may cause errors

=========================================================
SECURITY CONSIDERATIONS
=========================================================

Never serialize sensitive information
unless necessary.

Examples:

✗ Passwords

✗ Credit card numbers

✗ Security tokens

Protect important data before storage.

=========================================================
BEST PRACTICES
=========================================================

✓ Prefer JSON for modern applications

✓ Validate incoming data

✓ Handle exceptions properly

✓ Use strong data models

✓ Avoid storing sensitive data

✓ Keep serialized objects simple

✓ Use WriteIndented during learning

=========================================================
SERIALIZATION VS DESERIALIZATION
=========================================================

Serialization

Object → Data

Example:

Person → JSON

---------------------------------------------------------

Deserialization

Data → Object

Example:

JSON → Person

=========================================================
SUMMARY
=========================================================

Serialization converts objects into
a storable or transferable format.

Deserialization converts that data
back into objects.

Key concepts:

- Serialization
- Deserialization
- JSON
- XML
- Binary Data
- System.Text.Json
- Files
- APIs

Serialization is one of the most important
skills in modern C# development and is used
every day in professional applications.
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
