```csharp
using System;

/*
=========================================
LINQ NOTES
=========================================

In this module, I learn about LINQ.

LINQ stands for:

Language Integrated Query

LINQ allows me to query, filter, sort,
group, and manipulate data directly inside C#.

Before LINQ existed, developers often used
multiple loops, conditions, and temporary
variables to work with data.

LINQ provides a cleaner and more readable way
to perform data operations.

LINQ is one of the most powerful features
in modern C#.

=========================================
WHAT IS LINQ?
=========================================

LINQ is a query system built directly into C#.

It allows me to work with:

• Arrays
• Lists
• Objects
• Collections
• XML
• Databases
• Entity Framework

LINQ helps me retrieve and manipulate data
using simple and readable syntax.

=========================================
WHY LINQ EXISTS
=========================================

Without LINQ:

I often need multiple loops and conditions.

Example:

foreach (int number in numbers)
{
    if (number > 10)
    {
        Console.WriteLine(number);
    }
}

With LINQ:

var result =
numbers.Where(number => number > 10);

LINQ makes code:

• Cleaner
• Shorter
• Easier to maintain
• Easier to understand

=========================================
LINQ NAMESPACE
=========================================

To use LINQ I usually include:

using System.Linq;

Most LINQ methods are located inside
the System.Linq namespace.

=========================================
LINQ SYNTAX TYPES
=========================================

LINQ supports two styles.

1. Query Syntax

Similar to SQL.

2. Method Syntax

Uses methods and lambda expressions.

Both produce similar results.

=========================================
QUERY SYNTAX
=========================================

Example:

var result =
from number in numbers
where number > 10
select number;

This style looks similar to SQL queries.

=========================================
METHOD SYNTAX
=========================================

Example:

var result =
numbers.Where(number => number > 10);

Method syntax is the most common style
used in professional C# development.

=========================================
WHERE()
=========================================

Where filters data.

Example:

var evenNumbers =
numbers.Where(number => number % 2 == 0);

Result:

Only even numbers remain.

Common Uses:

• Active users
• Available products
• High scores
• Search filters

=========================================
SELECT()
=========================================

Select transforms data.

Example:

var names =
students.Select(student => student.Name);

Result:

Returns only names.

Select is often used when I only need
specific information.

=========================================
ORDERBY()
=========================================

OrderBy sorts data in ascending order.

Example:

var sorted =
numbers.OrderBy(number => number);

Result:

1
2
3
4
5

=========================================
ORDERBYDESCENDING()
=========================================

Sorts data in descending order.

Example:

var sorted =
numbers.OrderByDescending(number => number);

Result:

5
4
3
2
1

=========================================
THENBY()
=========================================

Used after OrderBy.

Example:

students
.OrderBy(student => student.Grade)
.ThenBy(student => student.Name);

Allows multiple sorting rules.

=========================================
FIRST()
=========================================

Returns the first item.

Example:

var first =
numbers.First();

Useful when at least one item exists.

=========================================
FIRSTORDEFAULT()
=========================================

Returns the first item or a default value.

Example:

var first =
numbers.FirstOrDefault();

Safer than First().

Default values:

int → 0

string → null

bool → false

=========================================
LAST()
=========================================

Returns the last item.

Example:

var last =
numbers.Last();

=========================================
LASTORDEFAULT()
=========================================

Returns the last item or a default value.

Example:

var last =
numbers.LastOrDefault();

=========================================
SINGLE()
=========================================

Returns exactly one matching item.

Example:

var student =
students.Single(student =>
student.Id == 1);

Use only when exactly one result exists.

=========================================
SINGLEORDEFAULT()
=========================================

Returns one item or default.

Safer than Single().

=========================================
COUNT()
=========================================

Counts items.

Example:

int total =
numbers.Count();

Result:

Number of items.

=========================================
SUM()
=========================================

Adds values together.

Example:

int total =
numbers.Sum();

Useful for totals and statistics.

=========================================
AVERAGE()
=========================================

Calculates the average.

Example:

double average =
numbers.Average();

Useful for grades and reports.

=========================================
MIN()
=========================================

Returns the smallest value.

Example:

int lowest =
numbers.Min();

=========================================
MAX()
=========================================

Returns the largest value.

Example:

int highest =
numbers.Max();

=========================================
ANY()
=========================================

Checks if at least one item exists.

Example:

bool exists =
numbers.Any();

Returns:

true or false

=========================================
ALL()
=========================================

Checks if every item meets a condition.

Example:

bool valid =
numbers.All(number => number > 0);

Returns:

true or false

=========================================
CONTAINS()
=========================================

Checks whether a value exists.

Example:

bool found =
numbers.Contains(10);

Useful for searches.

=========================================
DISTINCT()
=========================================

Removes duplicates.

Example:

var uniqueNumbers =
numbers.Distinct();

Result:

Only unique values remain.

=========================================
GROUPBY()
=========================================

Groups data together.

Example:

var grouped =
students.GroupBy(student =>
student.Grade);

Useful for reports and statistics.

=========================================
TAKE()
=========================================

Returns a specific number of items.

Example:

var firstThree =
numbers.Take(3);

Result:

First 3 values.

=========================================
SKIP()
=========================================

Skips a specific number of items.

Example:

var remaining =
numbers.Skip(3);

Useful for pagination systems.

=========================================
LINQ WITH OBJECTS
=========================================

Example:

class Student
{
    public string Name;
    public int Grade;
}

Query:

var topStudents =
students.Where(student =>
student.Grade >= 90);

LINQ works with custom classes.

=========================================
LINQ WITH LISTS
=========================================

Example:

List<string> names =
new List<string>();

LINQ works extremely well with lists.

Most real-world applications use LINQ
with collections.

=========================================
LINQ WITH ARRAYS
=========================================

Example:

int[] numbers =
{ 1, 2, 3, 4, 5 };

LINQ supports arrays naturally.

=========================================
REAL-WORLD EXAMPLE
=========================================

Imagine a game.

Player Database:

• Name
• Level
• Health
• Class

LINQ can find:

High-level players

players.Where(player =>
player.Level > 50);

Top health players

players.OrderByDescending(
player => player.Health);

Specific classes

players.Where(
player => player.Class == "Mage");

=========================================
ADVANTAGES OF LINQ
=========================================

1. Cleaner Code

Less looping.

-----------------------------------------

2. Better Readability

Queries are easier to understand.

-----------------------------------------

3. Faster Development

Less code to write.

-----------------------------------------

4. Powerful Data Processing

Filtering and sorting become easier.

-----------------------------------------

5. Professional Applications

Used throughout modern .NET projects.

=========================================
COMMON MISTAKES
=========================================

Mistake #1

Forgetting:

using System.Linq;

Many LINQ methods will not work.

-----------------------------------------

Mistake #2

Using First() when no data exists.

Safer:

FirstOrDefault()

-----------------------------------------

Mistake #3

Using LINQ when a simple loop
would be clearer.

Use LINQ appropriately.

-----------------------------------------

Mistake #4

Creating overly complex queries.

Keep queries readable.

=========================================
BEST PRACTICES
=========================================

• Prefer readable queries
• Use meaningful variable names
• Use FirstOrDefault when possible
• Use Any before expensive operations
• Avoid overly complex chains
• Keep LINQ expressive and simple
• Learn both query and method syntax

=========================================
MODULE SUMMARY
=========================================

In this module, I learned:

• What LINQ is
• Why LINQ is important
• Query Syntax
• Method Syntax
• Where
• Select
• OrderBy
• First
• FirstOrDefault
• Count
• Sum
• Average
• GroupBy
• Distinct
• Any
• All
• Take
• Skip

LINQ is one of the most useful tools
in modern C#.

It allows me to work with data in a
clean, readable, and professional way.
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
```
