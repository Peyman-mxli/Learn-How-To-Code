using System;

/*
=========================================================
DESERIALIZATION NOTES
=========================================================

Deserialization is one of the most important
concepts in modern software development.

Applications constantly receive data from:

- Files
- Databases
- APIs
- Web Services
- Configuration Files
- Cloud Systems

Deserialization allows that data to become
usable C# objects.

=========================================================
WHAT IS DESERIALIZATION?
=========================================================

Deserialization is the process of converting
stored data back into an object.

Example:

JSON Data

{
    "Name": "Peyman",
    "Age": 25
}

becomes:

Person person = new Person();

The object is recreated from the data.

=========================================================
DESERIALIZATION VS SERIALIZATION
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

---------------------------------------------------------

Together they allow data to move between
applications and storage systems.

=========================================================
WHY DESERIALIZATION IS IMPORTANT
=========================================================

Without deserialization:

- Saved files cannot be restored
- API responses cannot be used
- Settings cannot be loaded
- User data cannot be recovered

Deserialization is required in almost every
modern application.

=========================================================
SYSTEM.TEXT.JSON
=========================================================

Modern .NET applications commonly use:

System.Text.Json

Namespace:

using System.Text.Json;

Main method:

JsonSerializer.Deserialize<T>()

=========================================================
BASIC DESERIALIZATION
=========================================================

Example:

string json =
"{\"Name\":\"Peyman\",\"Age\":25}";

Person person =
    JsonSerializer.Deserialize<Person>(json);

The JSON text becomes a Person object.

=========================================================
GENERIC TYPE PARAMETER
=========================================================

Deserialize<T>()

requires a type.

Example:

Person person =
    JsonSerializer.Deserialize<Person>(json);

T is Person.

This tells C# what object should be created.

=========================================================
DESERIALIZING MULTIPLE PROPERTIES
=========================================================

Example JSON:

{
    "Name":"Peyman",
    "Age":25,
    "City":"Mexicali"
}

All matching properties are restored
automatically.

=========================================================
PROPERTY NAME MATCHING
=========================================================

Property names are matched automatically.

JSON:

{
    "Name":"Peyman"
}

Class:

public string Name { get; set; }

The value is assigned correctly.

=========================================================
DESERIALIZING LISTS
=========================================================

JSON arrays can become List objects.

Example:

[
    {
        "Name":"Ali"
    },
    {
        "Name":"Sara"
    }
]

Can become:

List<Person>

Example:

List<Person> people =
    JsonSerializer.Deserialize<List<Person>>(json);

=========================================================
DESERIALIZING ARRAYS
=========================================================

Arrays can also be restored.

Example:

Person[] people =
    JsonSerializer.Deserialize<Person[]>(json);

=========================================================
DESERIALIZING FROM FILES
=========================================================

Very common workflow.

Step 1

Read file:

string json =
    File.ReadAllText("person.json");

Step 2

Deserialize:

Person person =
    JsonSerializer.Deserialize<Person>(json);

=========================================================
LOADING APPLICATION SETTINGS
=========================================================

Applications often store settings.

Example:

settings.json

{
    "Theme":"Dark",
    "Language":"English"
}

Can become:

Settings settings =
    JsonSerializer.Deserialize<Settings>(json);

=========================================================
RESTORING GAME SAVES
=========================================================

Games commonly use deserialization.

Example:

savegame.json

{
    "Level":15,
    "Health":250
}

Can restore:

Player player =
    JsonSerializer.Deserialize<Player>(json);

=========================================================
MISSING JSON PROPERTIES
=========================================================

Sometimes JSON is missing values.

JSON:

{
    "Name":"Peyman"
}

Class:

public string Name { get; set; }

public int Age { get; set; }

Result:

Name = Peyman

Age = 0

Missing values receive default values.

=========================================================
EXTRA JSON PROPERTIES
=========================================================

JSON may contain extra values.

JSON:

{
    "Name":"Peyman",
    "Age":25,
    "Country":"Mexico"
}

Class:

public string Name { get; set; }

public int Age { get; set; }

Country is ignored.

No error occurs.

=========================================================
NULL VALUES
=========================================================

JSON may contain null.

Example:

{
    "Name": null
}

Result:

Name becomes null.

Always validate important values.

=========================================================
INVALID JSON
=========================================================

Bad JSON causes exceptions.

Example:

{
Name:Peyman
}

This is invalid.

Correct JSON:

{
    "Name":"Peyman"
}

Always validate JSON format.

=========================================================
EXCEPTION HANDLING
=========================================================

Deserialization should be protected.

Example:

try
{
    Person person =
        JsonSerializer.Deserialize<Person>(json);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

=========================================================
REAL-WORLD USE CASES
=========================================================

1. API Responses

Web services send JSON.

---------------------------------------------------------

2. Configuration Files

Applications load settings.

---------------------------------------------------------

3. Save Systems

Games restore progress.

---------------------------------------------------------

4. Cloud Data

Objects are rebuilt from cloud storage.

---------------------------------------------------------

5. Mobile Applications

Local user data is restored.

---------------------------------------------------------

6. Desktop Applications

Preferences are loaded at startup.

=========================================================
ADVANTAGES OF DESERIALIZATION
=========================================================

✓ Restores saved objects

✓ Reads API responses

✓ Loads settings

✓ Easy data recovery

✓ Works with JSON files

✓ Cross-platform support

=========================================================
DISADVANTAGES OF DESERIALIZATION
=========================================================

✗ Invalid JSON causes errors

✗ Large files require more memory

✗ Bad data can create problems

✗ Requires proper validation

=========================================================
SECURITY CONSIDERATIONS
=========================================================

Never trust external data blindly.

Always:

✓ Validate data

✓ Handle exceptions

✓ Check for null values

✓ Verify important properties

External data may be corrupted
or malicious.

=========================================================
BEST PRACTICES
=========================================================

✓ Use strongly typed classes

✓ Validate loaded data

✓ Handle exceptions

✓ Check null values

✓ Use System.Text.Json

✓ Keep models simple

✓ Verify file existence

=========================================================
SUMMARY
=========================================================

Deserialization converts stored data
back into C# objects.

Key concepts:

- JSON
- Deserialize<T>()
- Files
- Lists
- Arrays
- Validation
- Exceptions
- Settings
- API Responses

Deserialization is one of the most important
skills for modern C# development because it
allows applications to restore and use data
from external sources.
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
