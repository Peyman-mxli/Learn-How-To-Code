```csharp
using System;

/*
=========================================
DELEGATES NOTES
=========================================

In this module, I learn about Delegates.

Delegates are one of the most powerful features in C#.

A delegate is a type that stores a reference to a method.

This allows me to treat methods like variables.

I can:

• Store methods
• Pass methods as parameters
• Return methods from methods
• Execute methods dynamically

Delegates are the foundation of:

• Events
• Callbacks
• Lambda Expressions
• LINQ
• Many advanced C# features

=========================================
WHAT IS A DELEGATE?
=========================================

A delegate is a type-safe function pointer.

A delegate can point to a method that matches
its signature.

The method signature includes:

• Return type
• Parameter types
• Parameter order

Example:

delegate void MessageDelegate();

The delegate can only reference methods that:

• Return void
• Have no parameters

=========================================
WHY DELEGATES EXIST
=========================================

Without delegates, programs are often rigid.

I would need to manually call methods directly.

Example:

Attack();
Heal();
Run();

With delegates, I can choose which method
runs while the application is running.

Benefits:

• Flexibility
• Reusability
• Cleaner code
• Easier maintenance

=========================================
DECLARING A DELEGATE
=========================================

Basic Syntax:

delegate ReturnType DelegateName(ParameterList);

Example:

delegate void MessageDelegate();

Example:

delegate int MathDelegate(int x, int y);

The delegate creates a custom type.

=========================================
CREATING A DELEGATE
=========================================

Example:

delegate void MessageDelegate();

class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

The method matches the delegate signature.

=========================================
ASSIGNING A METHOD TO A DELEGATE
=========================================

Example:

MessageDelegate message = SayHello;

Now the delegate points to the method.

=========================================
INVOKING A DELEGATE
=========================================

Example:

message();

This executes the method.

Equivalent to:

SayHello();

The difference is that the delegate can
be changed dynamically.

=========================================
DELEGATE WITH PARAMETERS
=========================================

Example:

delegate void GreetingDelegate(string name);

Method:

static void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}

Assignment:

GreetingDelegate greeting = Greet;

Invocation:

greeting("Peyman");

Output:

Hello Peyman

=========================================
DELEGATE WITH RETURN VALUES
=========================================

Delegates can return values.

Example:

delegate int MathDelegate(int a, int b);

Method:

static int Add(int a, int b)
{
    return a + b;
}

Assignment:

MathDelegate calculate = Add;

Usage:

int result = calculate(5, 10);

Result:

15

=========================================
MULTIPLE METHODS
=========================================

Delegates can point to different methods.

Example:

AttackDelegate action;

action = Attack;

Later:

action = Heal;

The same delegate variable can execute
different methods.

This creates flexible systems.

=========================================
PASSING DELEGATES AS PARAMETERS
=========================================

Delegates can be passed into methods.

Example:

delegate void ActionDelegate();

Method:

static void ExecuteAction(ActionDelegate action)
{
    action();
}

Usage:

ExecuteAction(Attack);

Benefits:

• Reusable code
• Dynamic behavior
• Cleaner architecture

=========================================
CALLBACKS
=========================================

A callback is a method passed to another method.

Example:

DownloadFile(OnDownloadComplete);

When the download finishes,
the callback executes.

Common Uses:

• Games
• Networking
• User Interfaces
• APIs

=========================================
MULTICAST DELEGATES
=========================================

Delegates can reference multiple methods.

Example:

delegate void MessageDelegate();

MessageDelegate message;

message += SayHello;
message += SayGoodbye;

Invocation:

message();

Output:

Hello
Goodbye

Both methods execute.

=========================================
REMOVING METHODS
=========================================

Methods can be removed.

Example:

message -= SayGoodbye;

Now only:

SayHello

will execute.

=========================================
INVOCATION LIST
=========================================

Multicast delegates maintain a list
of assigned methods.

This list is called the:

Invocation List

Methods execute in the order added.

=========================================
ANONYMOUS METHODS
=========================================

Anonymous methods allow creating methods
without explicitly naming them.

Example:

MessageDelegate message =
delegate()
{
    Console.WriteLine("Anonymous Method");
};

Invocation:

message();

Benefits:

• Less code
• Quick implementation

=========================================
LAMBDA EXPRESSIONS
=========================================

Lambda expressions are a shorter way
to write anonymous methods.

Example:

MessageDelegate message =
() => Console.WriteLine("Lambda");

Invocation:

message();

Lambda expressions are heavily used in:

• LINQ
• Collections
• Events
• Modern C# Development

=========================================
BUILT-IN DELEGATES
=========================================

C# provides built-in delegates.

=========================================
ACTION
=========================================

Represents a method that returns void.

Example:

Action greet =
() => Console.WriteLine("Hello");

greet();

=========================================
FUNC
=========================================

Represents a method that returns a value.

Example:

Func<int, int, int> add =
(a, b) => a + b;

Output:

15

=========================================
PREDICATE
=========================================

Represents a method that returns bool.

Example:

Predicate<int> isEven =
number => number % 2 == 0;

Result:

True

=========================================
REAL-WORLD USES
=========================================

Delegates are used in:

• Events
• User Interfaces
• Unity Development
• LINQ
• APIs
• Networking
• Game Systems
• Enterprise Applications

Almost every professional C# application
uses delegates indirectly.

=========================================
ADVANTAGES OF DELEGATES
=========================================

1. Flexibility

Methods can change dynamically.

-----------------------------------------

2. Reusability

The same code can execute different methods.

-----------------------------------------

3. Cleaner Code

Reduces repetitive logic.

-----------------------------------------

4. Event Support

Delegates power events.

-----------------------------------------

5. Extensibility

Makes systems easier to expand.

=========================================
COMMON MISTAKES
=========================================

Mistake #1

Delegate signature does not match method.

Wrong:

delegate void Test();

int MyMethod()
{
    return 5;
}

Cannot assign.

-----------------------------------------

Mistake #2

Forgetting to check for null.

Example:

message();

If no method is assigned,
an exception occurs.

Safer:

message?.Invoke();

-----------------------------------------

Mistake #3

Creating custom delegates when Action,
Func, or Predicate already exists.

Prefer built-in delegates when possible.

=========================================
BEST PRACTICES
=========================================

• Use Action for void methods
• Use Func for return values
• Use Predicate for boolean results
• Use delegates to reduce duplication
• Use null-safe invocation
• Prefer lambda expressions when appropriate
• Keep delegate logic simple

=========================================
MODULE SUMMARY
=========================================

In this module, I learned:

• What delegates are
• Why delegates are useful
• Delegate declaration
• Method references
• Delegate invocation
• Delegate parameters
• Delegate return values
• Multicast delegates
• Anonymous methods
• Lambda expressions
• Action
• Func
• Predicate

Delegates are one of the most important
features in C# and serve as the foundation
for events and many advanced programming
techniques.
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
