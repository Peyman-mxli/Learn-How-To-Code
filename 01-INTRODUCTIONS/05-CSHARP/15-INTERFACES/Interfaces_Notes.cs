```csharp
using System;

namespace LearnHowToCode.Interfaces
{
    class InterfacesNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        INTERFACES NOTES
        ============================================================

        In this module, I learn about Interfaces.

        Interfaces are one of the most important
        concepts in Object-Oriented Programming.

        An interface acts as a contract.

        It defines what a class must do,
        but not how it does it.

        Classes that implement an interface
        must provide the required functionality.

        Interfaces help create flexible,
        reusable, and maintainable software.
    */

    /*
        ============================================================
        1. WHAT IS AN INTERFACE?
        ============================================================

        An interface is a blueprint of behavior.

        It contains definitions for methods,
        properties, events, or indexers.

        An interface does not contain
        implementation logic.

        Example:

            interface IAttackable
            {
                void Attack();
            }

        Any class implementing this interface
        must create the Attack() method.
    */

    /*
        ============================================================
        2. WHY USE INTERFACES?
        ============================================================

        Interfaces provide:

        ✔ Flexibility

        ✔ Reusability

        ✔ Better architecture

        ✔ Easier testing

        ✔ Reduced coupling

        ✔ Professional design
    */

    /*
        ============================================================
        3. THE INTERFACE KEYWORD
        ============================================================

        Interfaces are created using:

            interface

        Example:

            interface IMovable
            {
                void Move();
            }

        By convention, interface names
        start with the letter I.
    */

    /*
        ============================================================
        4. INTERFACE NAMING CONVENTION
        ============================================================

        Examples:

            IAttackable
            IMovable
            IDamageable
            IPaymentProcessor

        This immediately tells developers
        that the type is an interface.
    */

    /*
        ============================================================
        5. IMPLEMENTING AN INTERFACE
        ============================================================

        Example:

            interface IAttackable
            {
                void Attack();
            }

            class Warrior : IAttackable
            {
                public void Attack()
                {
                    Console.WriteLine("Sword Attack");
                }
            }

        The class must implement
        all required members.
    */

    /*
        ============================================================
        6. INTERFACE METHODS
        ============================================================

        Methods inside interfaces
        contain no implementation.

        Example:

            interface IJumpable
            {
                void Jump();
            }

        The class provides the code.
    */

    /*
        ============================================================
        7. INTERFACE PROPERTIES
        ============================================================

        Interfaces can define properties.

        Example:

            interface ICharacter
            {
                string Name { get; set; }
            }

        Implementing classes must
        provide the property.
    */

    /*
        ============================================================
        8. MULTIPLE INTERFACES
        ============================================================

        A class can implement
        multiple interfaces.

        Example:

            class Warrior :
                IAttackable,
                IMovable,
                IJumpable
            {

            }

        This is a major advantage
        of interfaces.
    */

    /*
        ============================================================
        9. INTERFACES VS INHERITANCE
        ============================================================

        Class inheritance:

            One base class only.

        Example:

            Warrior : Character

        Interfaces:

            Multiple interfaces allowed.

        Example:

            Warrior :
                IAttackable,
                IMovable,
                IJumpable
    */

    /*
        ============================================================
        10. INTERFACES VS ABSTRACT CLASSES
        ============================================================

        Abstract Class:

        - Can contain implementation
        - Can contain fields
        - Supports constructors

        Interface:

        - Defines contracts
        - No instance fields
        - No constructors

        Both support abstraction,
        but serve different purposes.
    */

    /*
        ============================================================
        11. GAME DEVELOPMENT EXAMPLE
        ============================================================

        Interfaces:

            IAttackable
            IDamageable
            IInteractable

        Classes:

            Warrior
            Mage
            Archer
            NPC

        Different objects can share
        common behavior contracts.
    */

    /*
        ============================================================
        12. PAYMENT SYSTEM EXAMPLE
        ============================================================

        Interface:

            IPaymentProcessor

        Classes:

            CreditCardProcessor
            PayPalProcessor
            CryptoProcessor

        Every payment processor must
        implement ProcessPayment().
    */

    /*
        ============================================================
        13. DATABASE EXAMPLE
        ============================================================

        Interface:

            IDatabase

        Classes:

            SqlDatabase
            MySqlDatabase
            PostgreSqlDatabase

        All databases expose
        common functionality.
    */

    /*
        ============================================================
        14. DEVICE EXAMPLE
        ============================================================

        Interface:

            IStartable

        Classes:

            Computer
            Smartphone
            Tablet

        Every device must implement Start().
    */

    /*
        ============================================================
        15. POLYMORPHISM WITH INTERFACES
        ============================================================

        Example:

            IAttackable character;

        Can reference:

            Warrior
            Mage
            Archer

        Interfaces support polymorphism
        just like base classes.
    */

    /*
        ============================================================
        16. BENEFITS OF INTERFACES
        ============================================================

        ✔ Better flexibility

        ✔ Better architecture

        ✔ Easier maintenance

        ✔ Easier testing

        ✔ Cleaner design

        ✔ Reusable contracts

        ✔ Professional software patterns
    */

    /*
        ============================================================
        17. COMMON BEGINNER MISTAKES
        ============================================================

        Mistake #1

        Forgetting to implement
        required methods.

        Result:

        Compile-time error.

        ------------------------------------------------

        Mistake #2

        Confusing interfaces
        with abstract classes.

        ------------------------------------------------

        Mistake #3

        Creating too many interfaces
        unnecessarily.
    */

    /*
        ============================================================
        18. WHEN TO USE INTERFACES
        ============================================================

        Use interfaces when:

        - Multiple classes share behavior

        - You need flexibility

        - You need loose coupling

        - You want professional architecture

        Examples:

            Payment Systems

            Game Mechanics

            File Systems

            Logging Systems

            Database Systems
    */

    /*
        ============================================================
        19. REAL-WORLD SOFTWARE
        ============================================================

        Interfaces are heavily used in:

        - ASP.NET

        - Unity

        - Enterprise Software

        - Mobile Apps

        - APIs

        - Database Frameworks

        They are one of the most
        important professional tools.
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Interfaces allow me to:

        - Define contracts

        - Create flexible systems

        - Support polymorphism

        - Improve maintainability

        - Reduce coupling

        - Build professional applications

        Interfaces are a fundamental
        concept used extensively in
        modern C# development.
    */
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
