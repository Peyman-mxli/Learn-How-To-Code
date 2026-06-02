/*
=========================================
DEPENDENCY INJECTION NOTES
=========================================

In this module, I learn about Dependency Injection (DI) in C#.

Dependency Injection is one of the most important concepts
in modern software development.

It is heavily used in:

- ASP.NET Core
- Web APIs
- Desktop Applications
- Cloud Applications
- Enterprise Software
- Microservices

Understanding Dependency Injection helps me write
cleaner, more maintainable, and more testable code.

=========================================
WHAT IS A DEPENDENCY?
=========================================

A dependency is any object that another class needs
in order to perform its work.

Example:

A UserService may need:

- A database repository
- A logger
- An email sender

These objects are dependencies.

Example:

UserService
    ↓
EmailService

UserService depends on EmailService.

=========================================
WITHOUT DEPENDENCY INJECTION
=========================================

Example:

public class UserService
{
    private EmailService emailService =
        new EmailService();
}

Problem:

UserService creates EmailService itself.

Consequences:

- Tight coupling
- Harder testing
- Difficult maintenance
- Difficult replacement

The class controls the creation of its own dependency.

This is usually not ideal.

=========================================
WHAT IS DEPENDENCY INJECTION?
=========================================

Dependency Injection means:

Instead of creating dependencies myself,
I receive them from outside.

Example:

public class UserService
{
    private EmailService emailService;

    public UserService(EmailService emailService)
    {
        this.emailService = emailService;
    }
}

Now UserService receives EmailService
from another object.

This is Dependency Injection.

=========================================
BENEFITS OF DEPENDENCY INJECTION
=========================================

1. Loose Coupling

Classes become less dependent on
specific implementations.

-----------------------------------------

2. Easier Testing

Mock objects can replace real objects.

-----------------------------------------

3. Better Maintenance

Dependencies can be updated without
changing business logic.

-----------------------------------------

4. Better Flexibility

Implementations can be swapped easily.

-----------------------------------------

5. Cleaner Architecture

Responsibilities become separated.

=========================================
TIGHT COUPLING
=========================================

Tight coupling occurs when classes
depend heavily on specific implementations.

Example:

UserService
    ↓
EmailService

UserService creates EmailService itself.

If EmailService changes,
UserService may also require changes.

This creates maintenance problems.

=========================================
LOOSE COUPLING
=========================================

Loose coupling means classes depend
on abstractions instead of concrete classes.

Example:

UserService
    ↓
IEmailService

UserService no longer cares about
the actual implementation.

Benefits:

- Easier replacement
- Easier testing
- Better scalability

=========================================
CONSTRUCTOR INJECTION
=========================================

The most common Dependency Injection technique.

Example:

public class UserService
{
    private readonly IEmailService emailService;

    public UserService(IEmailService emailService)
    {
        this.emailService = emailService;
    }
}

Advantages:

- Clear dependencies
- Easy testing
- Immutable references

Constructor Injection is the preferred
approach in most applications.

=========================================
INTERFACES AND DI
=========================================

Dependency Injection works best with interfaces.

Example:

public interface ILogger
{
    void Log(string message);
}

Implementation:

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

Service:

public class UserService
{
    private readonly ILogger logger;

    public UserService(ILogger logger)
    {
        this.logger = logger;
    }
}

UserService depends on ILogger
instead of FileLogger.

=========================================
REAL-WORLD EXAMPLE
=========================================

Imagine an online store.

Dependencies:

OrderService
    ↓
PaymentService
    ↓
EmailService
    ↓
Logger

Instead of creating all objects manually,
they can be injected.

Benefits:

- Easier maintenance
- Easier testing
- Better architecture

=========================================
MANUAL DEPENDENCY INJECTION
=========================================

Example:

EmailService emailService =
    new EmailService();

UserService userService =
    new UserService(emailService);

The dependency is created outside
and passed into the class.

This is manual Dependency Injection.

=========================================
MOCK OBJECTS
=========================================

Mock objects are fake implementations
used during testing.

Example:

IEmailService
    ↓
FakeEmailService

Instead of sending real emails,
the fake object simulates behavior.

Benefits:

- Faster tests
- Safer tests
- No external systems required

=========================================
DEPENDENCY INVERSION PRINCIPLE
=========================================

One of the SOLID principles.

Rule:

High-level modules should not depend
on low-level modules.

Both should depend on abstractions.

Bad:

UserService
    ↓
EmailService

Good:

UserService
    ↓
IEmailService

This makes applications more flexible.

=========================================
ASP.NET CORE AND DI
=========================================

ASP.NET Core has built-in Dependency Injection.

Example:

builder.Services.AddScoped<IEmailService,
                           EmailService>();

The framework automatically creates
and injects dependencies.

This is one reason DI is essential
for professional C# development.

=========================================
COMMON MISTAKES
=========================================

1. Creating dependencies inside classes

Bad:

new EmailService();

-----------------------------------------

2. Depending on concrete classes

Bad:

private EmailService emailService;

Better:

private IEmailService emailService;

-----------------------------------------

3. Too many dependencies

If a constructor has many parameters,
the class may have too many responsibilities.

=========================================
WHEN TO USE DI
=========================================

Use Dependency Injection when:

- Classes depend on services
- Testing is important
- Applications are growing
- Flexibility is needed
- Maintainability matters

=========================================
SUMMARY
=========================================

In this module, I learned:

- What a dependency is
- What Dependency Injection is
- Constructor Injection
- Tight coupling
- Loose coupling
- Interfaces and DI
- Mock objects
- Dependency Inversion Principle
- ASP.NET Core Dependency Injection
- Professional architecture concepts

Dependency Injection is one of the most
important skills for becoming a professional
C# developer because it promotes clean,
maintainable, and testable software.
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
