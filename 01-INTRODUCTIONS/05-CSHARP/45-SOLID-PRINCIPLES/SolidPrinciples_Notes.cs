/*
=========================================
SOLID PRINCIPLES NOTES
=========================================

In this module, I learn about SOLID Principles in C#.

SOLID is a set of five object-oriented programming principles.

These principles help me write code that is:

- Clean
- Organized
- Flexible
- Testable
- Maintainable
- Professional

SOLID helps me avoid messy code that becomes hard to change later.

=========================================
WHAT DOES SOLID MEAN?
=========================================

SOLID stands for:

S = Single Responsibility Principle

O = Open/Closed Principle

L = Liskov Substitution Principle

I = Interface Segregation Principle

D = Dependency Inversion Principle

Each principle teaches me how to design better classes and systems.

=========================================
WHY SOLID IS IMPORTANT
=========================================

When applications grow, bad design becomes a big problem.

Without good design:

- Classes become too large
- Code becomes hard to understand
- Changes break other features
- Testing becomes difficult
- Maintenance becomes slow
- Bugs become more common

SOLID helps prevent these problems.

=========================================
S - SINGLE RESPONSIBILITY PRINCIPLE
=========================================

The Single Responsibility Principle means:

A class should have only one reason to change.

In simple words:

One class should focus on one job.

Bad example:

A User class that:

- Stores user data
- Saves user to database
- Sends email
- Logs activity

This class has too many responsibilities.

Better design:

- User stores user data
- UserRepository saves user data
- EmailService sends email
- Logger logs activity

Each class has one clear job.

Benefits:

- Easier to understand
- Easier to test
- Easier to change
- Cleaner code

=========================================
O - OPEN/CLOSED PRINCIPLE
=========================================

The Open/Closed Principle means:

Software should be open for extension
but closed for modification.

In simple words:

I should be able to add new behavior
without changing existing code too much.

Bad example:

A payment class with many if statements:

if payment type is credit card
if payment type is PayPal
if payment type is cash

Every time I add a new payment type,
I must modify the same class.

Better design:

Create an interface:

IPaymentProcessor

Then create separate classes:

- CreditCardPayment
- PayPalPayment
- CashPayment

Now I can add new payment types
without changing the main payment logic.

Benefits:

- Safer changes
- Less risk of breaking old code
- Easier expansion

=========================================
L - LISKOV SUBSTITUTION PRINCIPLE
=========================================

The Liskov Substitution Principle means:

Child classes should be usable anywhere
their parent class is expected.

In simple words:

If a class inherits from another class,
it should behave correctly as that parent type.

Bad example:

A Bird class has a Fly() method.

Then Penguin inherits from Bird.

But penguins cannot fly.

This creates a problem because Penguin
cannot correctly replace Bird.

Better design:

Use better abstractions.

Example:

Bird
FlyingBird

Penguin inherits from Bird.

Eagle inherits from FlyingBird.

Benefits:

- Safer inheritance
- Better class design
- Fewer unexpected errors

=========================================
I - INTERFACE SEGREGATION PRINCIPLE
=========================================

The Interface Segregation Principle means:

A class should not be forced to implement
methods it does not need.

In simple words:

Use small specific interfaces instead
of one large interface.

Bad example:

interface IWorker
{
    void Work();
    void Eat();
}

A RobotWorker can work,
but it does not eat.

So RobotWorker is forced to implement
a method it does not need.

Better design:

interface IWorkable
{
    void Work();
}

interface IEatable
{
    void Eat();
}

Now each class uses only what it needs.

Benefits:

- Cleaner interfaces
- Less useless code
- Better flexibility
- Easier testing

=========================================
D - DEPENDENCY INVERSION PRINCIPLE
=========================================

The Dependency Inversion Principle means:

High-level classes should not depend
on low-level classes.

Both should depend on abstractions.

In simple words:

Classes should depend on interfaces,
not concrete implementations.

Bad example:

UserService directly creates EmailService.

This creates tight coupling.

Better design:

UserService depends on IEmailService.

Then EmailService implements IEmailService.

Benefits:

- Easier testing
- Easier replacement
- Better maintainability
- Works well with Dependency Injection

=========================================
SOLID AND DEPENDENCY INJECTION
=========================================

Dependency Injection helps apply
the Dependency Inversion Principle.

Instead of a class creating dependencies,
the dependencies are passed from outside.

Example:

UserService receives IEmailService
through the constructor.

This makes the code:

- Flexible
- Testable
- Professional
- Easy to maintain

=========================================
COMMON SIGNS OF BAD DESIGN
=========================================

Some signs that code may need SOLID:

- One class does too many things
- Many if/else statements for different types
- Child classes break parent behavior
- Interfaces have unused methods
- Classes create dependencies directly
- Code is hard to test
- Small changes break many files

=========================================
REAL-WORLD EXAMPLE
=========================================

Imagine an online store.

Without SOLID:

One large OrderManager class may:

- Validate orders
- Process payments
- Save orders
- Send emails
- Create invoices
- Log activity

This becomes hard to maintain.

With SOLID:

Separate classes:

- OrderValidator
- PaymentProcessor
- OrderRepository
- EmailService
- InvoiceService
- Logger

Each class has one responsibility.

The application becomes cleaner and easier to grow.

=========================================
SUMMARY
=========================================

In this module, I learned:

- What SOLID means
- Why SOLID is important
- Single Responsibility Principle
- Open/Closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle
- How SOLID improves class design
- How SOLID helps professional applications

SOLID Principles help me write code that is not only working,
but also clean, flexible, and maintainable.
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
