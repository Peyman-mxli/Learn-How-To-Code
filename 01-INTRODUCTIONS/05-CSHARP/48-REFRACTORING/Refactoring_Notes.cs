/*
=========================================
REFACTORING NOTES
=========================================

In this module, I learn about Refactoring in C#.

Refactoring means improving the internal
structure of code without changing its behavior.

The program should still produce the same results.

The difference is that the code becomes:

- Cleaner
- Easier to read
- Easier to maintain
- Easier to test
- Easier to extend

Refactoring is one of the most important skills
for professional software developers.

=========================================
WHAT IS REFACTORING?
=========================================

Refactoring means reorganizing existing code.

Important:

Refactoring does NOT add new features.

Refactoring does NOT change what the program does.

Refactoring ONLY improves how the code is written.

Example:

Before:

int x = 50;
int y = 10;
int z = x * y;

After:

int productPrice = 50;
int quantity = 10;
int totalPrice = productPrice * quantity;

Behavior:

Exactly the same.

Readability:

Much better.

=========================================
WHY REFACTORING MATTERS
=========================================

Software changes constantly.

Developers frequently:

- Fix bugs
- Add features
- Improve performance
- Maintain old code

Messy code makes all these tasks harder.

Refactoring helps keep code healthy.

Benefits:

- Better readability
- Better maintainability
- Better testing
- Fewer bugs
- Faster development

=========================================
WHEN TO REFACTOR
=========================================

Common situations:

- Bad variable names
- Duplicate code
- Large methods
- Large classes
- Confusing conditions
- Deep nesting
- Poor structure

If code feels difficult to understand,
it may need refactoring.

=========================================
RENAME VARIABLES
=========================================

One of the simplest refactorings.

Bad:

int x = 100;

Good:

int studentScore = 100;

Good names explain purpose.

Benefits:

- Easier reading
- Less confusion
- Better maintenance

=========================================
RENAME METHODS
=========================================

Bad:

DoThing()

Good:

CalculateOrderTotal()

Method names should clearly describe actions.

Benefits:

- Better readability
- Easier navigation
- Self-documenting code

=========================================
EXTRACT METHOD
=========================================

Large code blocks can be moved into methods.

Before:

Console.WriteLine("Welcome");
Console.WriteLine("Please Login");
Console.WriteLine("Good Luck");

After:

ShowWelcomeMessage();

Method:

static void ShowWelcomeMessage()
{
    Console.WriteLine("Welcome");
    Console.WriteLine("Please Login");
    Console.WriteLine("Good Luck");
}

Benefits:

- Reusability
- Cleaner code
- Smaller methods

=========================================
REMOVE DUPLICATE CODE
=========================================

Duplicate code creates maintenance problems.

Bad:

Console.WriteLine("----------------");
Console.WriteLine("----------------");
Console.WriteLine("----------------");

Better:

ShowSeparator();

Benefits:

- One place to update
- Less code
- Better organization

=========================================
SIMPLIFY CONDITIONS
=========================================

Bad:

if (age > 18 &&
    score > 70 &&
    isActive == true)

Better:

bool isAdult = age > 18;
bool passedExam = score > 70;

if (isAdult && passedExam && isActive)

Benefits:

- Easier reading
- Easier debugging

=========================================
REPLACE MAGIC NUMBERS
=========================================

Magic numbers appear without explanation.

Bad:

if (score >= 70)

Better:

const int PassingScore = 70;

if (score >= PassingScore)

Benefits:

- Clear meaning
- Easier maintenance

=========================================
SPLIT LARGE METHODS
=========================================

Large methods become difficult to understand.

Bad:

RegisterUser()

Inside:

- Validate
- Save
- Send Email
- Log

Better:

ValidateUser()

SaveUser()

SendWelcomeEmail()

LogRegistration()

Each method has one responsibility.

=========================================
SPLIT LARGE CLASSES
=========================================

Large classes often violate
Single Responsibility Principle.

Bad:

UserManager

Handles:

- Database
- Email
- Logging
- Reports

Better:

UserRepository

EmailService

Logger

ReportGenerator

Benefits:

- Easier maintenance
- Better testing

=========================================
EARLY RETURNS
=========================================

Reduce nesting by returning early.

Bad:

if (user != null)
{
    if (user.IsActive)
    {
        Console.WriteLine("Access Granted");
    }
}

Better:

if (user == null)
{
    return;
}

if (!user.IsActive)
{
    return;
}

Console.WriteLine("Access Granted");

Benefits:

- Cleaner code
- Less nesting

=========================================
REFACTORING AND TESTING
=========================================

Before refactoring:

Run tests.

After refactoring:

Run tests again.

Reason:

Refactoring should not change behavior.

Tests verify that everything still works.

=========================================
COMMON REFACTORING TECHNIQUES
=========================================

Most common techniques:

- Rename Variable
- Rename Method
- Extract Method
- Extract Class
- Remove Duplicate Code
- Simplify Conditions
- Replace Magic Numbers
- Split Large Methods
- Split Large Classes
- Improve Formatting

=========================================
REFACTORING VS REWRITING
=========================================

Refactoring:

Improves existing code.

Rewriting:

Creates completely new code.

Refactoring is usually safer because
existing behavior remains unchanged.

=========================================
REAL-WORLD EXAMPLE
=========================================

Original:

ProcessOrder()

Inside:

- Validate Order
- Calculate Total
- Apply Discount
- Process Payment
- Generate Receipt

Refactored:

ValidateOrder()

CalculateOrderTotal()

ApplyDiscount()

ProcessPayment()

GenerateReceipt()

Each method becomes easier to understand.

=========================================
CODE SMELLS
=========================================

Code Smells are warning signs that code
may need refactoring.

Examples:

- Long methods
- Long classes
- Duplicate code
- Poor names
- Deep nesting
- Too many parameters
- Large switch statements
- Magic numbers

Code smells do not always mean bugs.

They indicate possible design problems.

=========================================
PROFESSIONAL REFACTORING RULES
=========================================

1. Refactor gradually
2. Keep behavior unchanged
3. Use tests
4. Improve readability
5. Use meaningful names
6. Remove duplication
7. Simplify complexity
8. Keep methods focused

=========================================
SUMMARY
=========================================

In this module, I learned:

- What refactoring is
- Why refactoring matters
- Renaming variables
- Renaming methods
- Extracting methods
- Removing duplicate code
- Simplifying conditions
- Replacing magic numbers
- Splitting large methods
- Splitting large classes
- Early returns
- Code smells
- Professional refactoring practices

Refactoring helps me improve code quality
without changing program behavior.

It is one of the most valuable skills
for becoming a professional C# developer.
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
