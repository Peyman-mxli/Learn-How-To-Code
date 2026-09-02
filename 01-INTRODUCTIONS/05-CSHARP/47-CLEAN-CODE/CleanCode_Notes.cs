/*
=========================================
CLEAN CODE NOTES
=========================================

In this module, I learn about Clean Code in C#.

Clean Code means writing code that is easy to read,
easy to understand, easy to maintain, and easy to improve.

Professional code should not only work.

Professional code should also be clear.

=========================================
WHY CLEAN CODE MATTERS
=========================================

Clean Code matters because real software changes over time.

A developer may need to:

- Fix bugs
- Add new features
- Improve performance
- Read old code
- Work with a team
- Maintain a large project

If code is messy, every change becomes harder.

Clean Code helps me avoid confusion and future problems.

=========================================
GOOD NAMING
=========================================

Names should clearly explain what something means.

Bad:

int x;

Good:

int studentAge;

Bad:

string d;

Good:

string userEmail;

Good names help me understand code without guessing.

=========================================
VARIABLE NAMES
=========================================

Variable names should describe the data they store.

Examples:

string firstName;

int totalScore;

double productPrice;

bool isLoggedIn;

A good variable name answers:

What is stored here?

=========================================
METHOD NAMES
=========================================

Method names should describe an action.

Good examples:

CalculateTotalPrice()

SendEmail()

ValidatePassword()

PrintStudentReport()

Method names usually start with verbs because methods do something.

=========================================
CLASS NAMES
=========================================

Class names should describe what the class represents.

Good examples:

Student

OrderService

EmailSender

InvoiceCalculator

CustomerRepository

Class names usually use nouns because classes represent things or concepts.

=========================================
SMALL METHODS
=========================================

A method should do one clear job.

Bad:

RegisterUserAndSendEmailAndSaveLog()

Better:

RegisterUser()

SendWelcomeEmail()

SaveRegistrationLog()

Small methods are easier to:

- Read
- Test
- Debug
- Reuse
- Maintain

=========================================
ONE RESPONSIBILITY
=========================================

Each method and class should have one main responsibility.

If a method does too many things,
it becomes difficult to understand.

If a class does too many things,
it becomes difficult to maintain.

Clean Code works closely with the
Single Responsibility Principle.

=========================================
AVOID DUPLICATE CODE
=========================================

Duplicate code means writing the same logic
in multiple places.

Bad:

Console.WriteLine("Welcome User");
Console.WriteLine("Welcome User");
Console.WriteLine("Welcome User");

Better:

Create a method:

ShowWelcomeMessage();

Benefits:

- Easier updates
- Fewer mistakes
- Cleaner structure

=========================================
COMMENTS
=========================================

Comments should explain why something exists,
not repeat what the code already says.

Bad comment:

// Increase age by 1
age++;

Good comment:

// Age increases after birthday validation.
age++;

Clean code should be understandable mostly
through good names and structure.

=========================================
MAGIC NUMBERS
=========================================

Magic numbers are numbers used without explanation.

Bad:

if (score >= 70)

Better:

int passingScore = 70;

if (score >= passingScore)

Named values make code easier to understand.

=========================================
BOOLEAN NAMES
=========================================

Boolean variables should sound like true or false questions.

Good examples:

bool isActive;

bool hasPermission;

bool canLogin;

bool isValid;

This makes conditions easier to read.

=========================================
CONDITIONS
=========================================

Conditions should be simple and readable.

Bad:

if (age > 18 && score > 70 && isActive == true)

Better:

bool isAdult = age > 18;
bool passedExam = score > 70;

if (isAdult && passedExam && isActive)

Readable conditions reduce mistakes.

=========================================
AVOID DEEP NESTING
=========================================

Deep nesting happens when many if statements
are inside other if statements.

Bad:

if (userExists)
{
    if (passwordCorrect)
    {
        if (isActive)
        {
            Console.WriteLine("Login successful");
        }
    }
}

Better:

Use clear checks and return early when possible.

Deep nesting makes code harder to follow.

=========================================
FORMATTING
=========================================

Good formatting makes code easier to read.

Examples:

- Consistent indentation
- Empty lines between sections
- Clear spacing
- Organized methods
- Consistent braces

Formatting does not change what code does,
but it changes how easy it is to understand.

=========================================
ERROR HANDLING
=========================================

Clean Code handles errors clearly.

Good practices:

- Use try/catch when needed
- Show meaningful error messages
- Avoid hiding errors silently
- Validate input
- Handle invalid data safely

Bad:

catch
{
}

This hides the problem.

Better:

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

=========================================
REFACTORING
=========================================

Refactoring means improving code structure
without changing what the program does.

Examples:

- Rename variables
- Split large methods
- Remove duplicate code
- Simplify conditions
- Extract helper methods
- Organize classes

Refactoring makes code cleaner and easier to maintain.

=========================================
MESSY CODE EXAMPLE
=========================================

Bad:

int x = 50;
int y = 10;
int z = x * y;
Console.WriteLine(z);

Better:

int productPrice = 50;
int quantity = 10;
int totalPrice = productPrice * quantity;

Console.WriteLine(totalPrice);

The second version is easier to understand.

=========================================
REAL-WORLD CLEAN CODE EXAMPLE
=========================================

Imagine a shopping system.

Bad design:

One method does:

- Validate cart
- Calculate total
- Apply discount
- Process payment
- Send receipt

Clean design:

Separate methods:

ValidateCart()

CalculateTotal()

ApplyDiscount()

ProcessPayment()

SendReceipt()

Each method has one job.

=========================================
COMMON CLEAN CODE MISTAKES
=========================================

Common mistakes include:

- Bad variable names
- Long methods
- Large classes
- Duplicate code
- Too many comments
- No comments where needed
- Magic numbers
- Complex conditions
- Deep nesting
- Ignoring errors
- Poor formatting

=========================================
CLEAN CODE CHECKLIST
=========================================

Before finishing code, I can ask:

- Are names clear?
- Is the method too long?
- Does each class have one responsibility?
- Is there duplicate code?
- Are conditions readable?
- Are errors handled?
- Is formatting consistent?
- Can another developer understand this?

=========================================
SUMMARY
=========================================

In this module, I learned:

- What Clean Code is
- Why Clean Code matters
- Good variable names
- Good method names
- Good class names
- Small methods
- One responsibility
- Avoiding duplicate code
- Good comments
- Magic numbers
- Boolean naming
- Simple conditions
- Avoiding deep nesting
- Formatting
- Error handling
- Refactoring

Clean Code helps me write programs that are easier to read,
easier to debug, easier to maintain, and more professional.
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
