/*
=========================================
33 - OVERLOADING
Overloading_Notes.cs
=========================================
*/

using System;

namespace OverloadingNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }
}

/*
==================================================
WHAT IS OVERLOADING?
==================================================

Overloading is the ability to create multiple methods,
constructors, or operators with the same name but
different parameter lists.

C# determines which version to execute based on
the arguments provided.

Overloading improves:

- Readability
- Flexibility
- Code organization
- API design
- Maintainability

==================================================
WHY OVERLOADING EXISTS
==================================================

Imagine creating a calculator.

Without overloading:

AddTwoNumbers()
AddThreeNumbers()
AddFourNumbers()

With overloading:

Add()

The same method name can support different
numbers or types of parameters.

This creates cleaner code.

==================================================
METHOD OVERLOADING
==================================================

Method overloading occurs when multiple methods
share the same name but have different parameters.

Example:

public int Add(int a, int b)

public int Add(int a, int b, int c)

public double Add(double a, double b)

All methods are named Add.

The parameter list is what makes them unique.

==================================================
VALID OVERLOADING RULES
==================================================

Methods can be overloaded by changing:

✓ Number of parameters

Example:

Print(string name)

Print(string firstName, string lastName)

------------------------------------------

✓ Data type of parameters

Example:

Print(int value)

Print(double value)

------------------------------------------

✓ Order of parameters

Example:

Display(int id, string name)

Display(string name, int id)

==================================================
INVALID OVERLOADING
==================================================

Return type alone cannot overload a method.

INVALID:

public int GetData()

public double GetData()

Why?

Because C# does not use return type when
determining which method to call.

This creates ambiguity.

==================================================
EXAMPLE OF METHOD OVERLOADING
==================================================

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

==================================================
HOW C# CHOOSES A METHOD
==================================================

Example:

Add(5, 10)

C# finds:

Add(int, int)

------------------------------------------

Example:

Add(5.5, 2.5)

C# finds:

Add(double, double)

------------------------------------------

Example:

Add(1, 2, 3)

C# finds:

Add(int, int, int)

This process is called:

Method Resolution

==================================================
CONSTRUCTOR OVERLOADING
==================================================

Constructors can also be overloaded.

Example:

class Person
{
    public Person()
    {
    }

    public Person(string name)
    {
    }

    public Person(string name, int age)
    {
    }
}

Each constructor accepts different data.

==================================================
WHY CONSTRUCTOR OVERLOADING IS USEFUL
==================================================

Some objects may require minimal information.

Others may require complete information.

Example:

Person p1 = new Person();

Person p2 = new Person("Peyman");

Person p3 = new Person("Peyman", 25);

The same class supports multiple creation options.

==================================================
REAL-WORLD EXAMPLE
==================================================

Think about an online store.

Search()

Search(string keyword)

Search(string keyword, string category)

Search(string keyword, string category, int page)

Users can search with different amounts
of information.

Overloading keeps the interface simple.

==================================================
ADVANTAGES OF OVERLOADING
==================================================

1. Cleaner code

2. Easier maintenance

3. Better readability

4. Reusable method names

5. Professional API design

6. Consistent naming

7. Less duplicate code

==================================================
DISADVANTAGES OF OVERLOADING
==================================================

1. Too many overloads can be confusing

2. Can create ambiguity

3. Harder to debug if poorly designed

4. Poor parameter choices reduce readability

==================================================
BEST PRACTICES
==================================================

✓ Keep overloads related

✓ Use meaningful parameter combinations

✓ Avoid excessive overloads

✓ Keep behavior consistent

✓ Document all overload versions

✓ Design for readability

==================================================
COMMONLY OVERLOADED METHODS IN C#
==================================================

Console.Write()

Console.WriteLine()

String.Contains()

String.IndexOf()

Math.Round()

DateTime constructors

List constructors

Framework classes heavily use overloading.

==================================================
SUMMARY
==================================================

Overloading allows multiple methods,
constructors, or operators to share
the same name.

Methods are differentiated by:

- Parameter count
- Parameter types
- Parameter order

Return type alone cannot overload a method.

Overloading helps create cleaner,
more flexible, and more professional code.

It is one of the most commonly used
features in modern C# development.
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
