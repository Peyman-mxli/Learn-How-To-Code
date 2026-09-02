/*
=========================================
DESIGN PATTERNS NOTES
=========================================

In this module, I learn about Design Patterns in C#.

Design Patterns are proven solutions to
common software design problems.

They are not complete applications.

They are reusable templates that help
developers organize code in better ways.

Design Patterns help me write code that is:

- Cleaner
- More flexible
- Easier to maintain
- Easier to extend
- Easier to understand
- More professional

=========================================
WHAT IS A DESIGN PATTERN?
=========================================

A Design Pattern is a common solution
to a recurring software problem.

Think of design patterns like blueprints.

An architect uses blueprints to build houses.

A software developer uses design patterns
to build applications.

Patterns save time because developers
do not need to reinvent solutions.

=========================================
WHY DESIGN PATTERNS MATTER
=========================================

Without design patterns:

- Code becomes difficult to maintain
- Classes become tightly coupled
- Applications become harder to extend
- Bugs become more common

With design patterns:

- Code becomes organized
- Systems become flexible
- Features become easier to add
- Maintenance becomes easier

=========================================
THREE MAIN CATEGORIES
=========================================

Design patterns are usually divided into:

1. Creational Patterns
2. Structural Patterns
3. Behavioral Patterns

=========================================
CREATIONAL PATTERNS
=========================================

Creational patterns focus on object creation.

Questions they solve:

- How should objects be created?
- Who should create them?
- How many should exist?

Examples:

- Singleton
- Factory Method
- Abstract Factory
- Builder
- Prototype

=========================================
SINGLETON PATTERN
=========================================

Purpose:

Ensure that only one object exists.

Example:

Application Settings

There should be only one settings manager.

Example:

public class SettingsManager
{
    private static SettingsManager instance;

    private SettingsManager()
    {
    }

    public static SettingsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance =
                    new SettingsManager();
            }

            return instance;
        }
    }
}

Benefits:

- Single shared object
- Centralized access

Common Uses:

- Configuration
- Logging
- Caching

=========================================
FACTORY PATTERN
=========================================

Purpose:

Create objects without exposing
creation logic.

Example:

Instead of:

new Dog()

new Cat()

Use a factory:

AnimalFactory.CreateAnimal()

Benefits:

- Cleaner code
- Easier expansion
- Centralized object creation

=========================================
BUILDER PATTERN
=========================================

Purpose:

Construct complex objects step by step.

Example:

Creating a gaming computer.

Parts:

- CPU
- RAM
- GPU
- Storage

Instead of one huge constructor,
the Builder assembles the object gradually.

Benefits:

- Better readability
- Easier customization

=========================================
STRUCTURAL PATTERNS
=========================================

Structural patterns focus on how
objects and classes are connected.

Examples:

- Adapter
- Decorator
- Facade
- Composite
- Proxy

=========================================
ADAPTER PATTERN
=========================================

Purpose:

Allow incompatible classes
to work together.

Example:

Old Payment System

New Payment System

The Adapter acts like a translator.

Benefits:

- Reuse old code
- Easier integration

=========================================
DECORATOR PATTERN
=========================================

Purpose:

Add functionality to objects
without modifying existing code.

Example:

Coffee

Basic Coffee

Decorated Coffee:

- Milk
- Sugar
- Chocolate

Each decorator adds behavior.

Benefits:

- Flexible features
- No modification of original class

=========================================
FACADE PATTERN
=========================================

Purpose:

Provide a simplified interface
to a complex system.

Example:

Home Theater

Without Facade:

- TV
- Speakers
- Lights
- Projector

With Facade:

homeTheater.StartMovie();

Benefits:

- Easier usage
- Cleaner code

=========================================
BEHAVIORAL PATTERNS
=========================================

Behavioral patterns focus on communication
between objects.

Examples:

- Observer
- Strategy
- Command
- State
- Mediator

=========================================
OBSERVER PATTERN
=========================================

Purpose:

Notify multiple objects when
something changes.

Example:

YouTube Subscribers

When a creator uploads a video:

Subscribers receive notifications.

Benefits:

- Automatic updates
- Loose coupling

Common Uses:

- Event systems
- Notifications
- User interfaces

=========================================
STRATEGY PATTERN
=========================================

Purpose:

Switch algorithms at runtime.

Example:

Payment Processing

Strategies:

- Credit Card
- PayPal
- Bank Transfer

The application chooses the strategy
during execution.

Benefits:

- Flexible behavior
- Cleaner code

=========================================
COMMAND PATTERN
=========================================

Purpose:

Convert requests into objects.

Example:

Remote Control

Buttons trigger commands:

- Turn TV On
- Turn TV Off
- Change Channel

Benefits:

- Undo operations
- Flexible commands

=========================================
STATE PATTERN
=========================================

Purpose:

Change object behavior based on state.

Example:

Traffic Light

States:

- Red
- Yellow
- Green

Behavior changes depending
on current state.

Benefits:

- Cleaner conditional logic

=========================================
MEDIATOR PATTERN
=========================================

Purpose:

Reduce direct communication
between objects.

Example:

Chat Room

Users communicate through
the chat room instead of
talking directly to each other.

Benefits:

- Lower coupling
- Easier maintenance

=========================================
DESIGN PATTERNS VS SOLID
=========================================

SOLID Principles help me design classes.

Design Patterns help me solve
common architecture problems.

They work together.

SOLID creates good foundations.

Design Patterns provide proven solutions.

=========================================
WHEN TO USE DESIGN PATTERNS
=========================================

Use patterns when:

- A problem appears repeatedly
- A pattern clearly improves design
- Maintenance becomes difficult
- Flexibility is needed

Do not use patterns simply because
they exist.

=========================================
COMMON MISTAKE
=========================================

Overusing Design Patterns.

Bad:

Adding patterns everywhere.

Good:

Using patterns only when they
solve a real problem.

Remember:

Simple code is usually better than
complicated code.

=========================================
REAL-WORLD EXAMPLES
=========================================

Singleton:

- Configuration Manager
- Logger

Factory:

- Creating game enemies
- Creating database providers

Builder:

- Character creators
- Computer builders

Observer:

- Notifications
- Event systems

Strategy:

- Payment methods
- AI behavior systems

=========================================
SUMMARY
=========================================

In this module, I learned:

- What Design Patterns are
- Why Design Patterns matter
- Creational Patterns
- Singleton Pattern
- Factory Pattern
- Builder Pattern
- Structural Patterns
- Adapter Pattern
- Decorator Pattern
- Facade Pattern
- Behavioral Patterns
- Observer Pattern
- Strategy Pattern
- Command Pattern
- State Pattern
- Mediator Pattern

Design Patterns help me write
professional software by providing
reusable solutions to common
design problems.
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
