using System;

/*
=========================================
INDEXER NOTES
=========================================

In this module, I learn about Indexers in C#.

An Indexer allows an object to be accessed
like an array.

This means I can use square brackets [ ]
on my own classes and structs.

Indexers provide a clean and natural way
to access internal data.

-----------------------------------------
WHAT IS AN INDEXER?
-----------------------------------------

Normally, arrays use indexes.

Example:

string[] names =
{
    "Ali",
    "Sara",
    "Peyman"
};

Console.WriteLine(names[0]);

Output:

Ali

Indexers allow my own classes to behave
in a similar way.

Example:

students[0]

inventory[1]

library[2]

-----------------------------------------
WHY USE INDEXERS?
-----------------------------------------

Without Indexers:

studentList.SetStudent(0, "Peyman");

string name =
    studentList.GetStudent(0);

With Indexers:

studentList[0] = "Peyman";

string name = studentList[0];

Cleaner and easier to read.

-----------------------------------------
INDEXER SYNTAX
-----------------------------------------

Basic Syntax:

public string this[int index]
{
    get
    {
        return data[index];
    }

    set
    {
        data[index] = value;
    }
}

Important:

The keyword "this" defines
the indexer.

-----------------------------------------
SIMPLE INDEXER EXAMPLE
-----------------------------------------
*/

class StudentList
{
    private string[] students =
        new string[5];

    public string this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }
}

/*
Usage:

StudentList list =
    new StudentList();

list[0] = "Peyman";

Console.WriteLine(list[0]);

-----------------------------------------
GET ACCESSOR
-----------------------------------------

The get accessor retrieves a value.

Example:

get
{
    return students[index];
}

When:

list[0]

is used, the get accessor runs.

-----------------------------------------
SET ACCESSOR
-----------------------------------------

The set accessor stores a value.

Example:

set
{
    students[index] = value;
}

When:

list[0] = "Peyman";

is used, the set accessor runs.

-----------------------------------------
VALUE KEYWORD
-----------------------------------------

Inside set, "value" represents the
incoming value.

Example:

set
{
    students[index] = value;
}

Equivalent:

students[index] = "Peyman";

-----------------------------------------
INDEXERS WITH INTEGERS
-----------------------------------------
*/

class Scores
{
    private int[] scores =
        new int[10];

    public int this[int index]
    {
        get
        {
            return scores[index];
        }

        set
        {
            scores[index] = value;
        }
    }
}

/*
-----------------------------------------
INDEXERS WITH DOUBLE VALUES
-----------------------------------------
*/

class Temperatures
{
    private double[] values =
        new double[7];

    public double this[int index]
    {
        get
        {
            return values[index];
        }

        set
        {
            values[index] = value;
        }
    }
}

/*
-----------------------------------------
READ-ONLY INDEXERS
-----------------------------------------

Sometimes values should only be read.

Example:
*/

class Days
{
    private string[] names =
    {
        "Monday",
        "Tuesday",
        "Wednesday"
    };

    public string this[int index]
    {
        get
        {
            return names[index];
        }
    }
}

/*
No set accessor exists.

Users can read values but cannot
change them.

-----------------------------------------
INDEXERS WITH LISTS
-----------------------------------------
*/

using System.Collections.Generic;

class Products
{
    private List<string> products =
        new List<string>();

    public string this[int index]
    {
        get
        {
            return products[index];
        }

        set
        {
            products[index] = value;
        }
    }
}

/*
-----------------------------------------
MULTIPLE INDEXERS
-----------------------------------------

A class can contain more than one
indexer.

Example:

public string this[int index]
{
}

public string this[string name]
{
}

Different parameter types are allowed.

-----------------------------------------
STRING INDEXER EXAMPLE
-----------------------------------------
*/

class DictionaryExample
{
    private Dictionary<string, string>
        words =
        new Dictionary<string, string>();

    public string this[string key]
    {
        get
        {
            return words[key];
        }

        set
        {
            words[key] = value;
        }
    }
}

/*
Usage:

dictionary["Hello"] = "Hola";

Console.WriteLine(
    dictionary["Hello"]);

-----------------------------------------
INDEXERS IN GAME DEVELOPMENT
-----------------------------------------

Inventory Systems

inventory[0] = "Sword";

inventory[1] = "Shield";

inventory[2] = "Potion";

-----------------------------------------
INDEXERS IN BUSINESS SOFTWARE
-----------------------------------------

Employee Systems

employees[0]

employees[1]

employees[2]

-----------------------------------------
INDEXERS IN LIBRARIES
-----------------------------------------

Book Collections

library[0]

library[1]

library[2]

-----------------------------------------
INDEXERS VS PROPERTIES
-----------------------------------------

Property:

person.Name

Indexer:

person[0]

Properties access a single value.

Indexers access collections of values.

-----------------------------------------
COMMON MISTAKES
-----------------------------------------

❌ Forgetting the keyword this

❌ Returning the wrong collection

❌ Missing bounds validation

❌ Using indexers when a property
would be simpler

❌ Not understanding get and set

-----------------------------------------
BOUNDS CHECKING
-----------------------------------------

Safer Example:

get
{
    if(index < 0 ||
       index >= students.Length)
    {
        return "Invalid Index";
    }

    return students[index];
}

This prevents runtime errors.

-----------------------------------------
BEST PRACTICES
-----------------------------------------

✔ Use indexers for collection-like
objects

✔ Keep indexer logic simple

✔ Validate indexes

✔ Use meaningful internal names

✔ Use read-only indexers when needed

✔ Use indexers only when they
improve readability

-----------------------------------------
SUMMARY
-----------------------------------------

Indexers allow me to:

✔ Access objects like arrays

✔ Use square brackets

✔ Create cleaner APIs

✔ Build custom collections

✔ Store and retrieve values

✔ Improve readability

✔ Write more professional C# code

Indexers are commonly used in custom
collections, inventory systems,
libraries, and data containers.
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
