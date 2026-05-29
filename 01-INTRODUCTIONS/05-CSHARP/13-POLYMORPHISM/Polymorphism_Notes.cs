```csharp
using System;

namespace LearnHowToCode.Polymorphism
{
    class PolymorphismNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        POLYMORPHISM NOTES
        ============================================================

        In this module, I learn about Polymorphism.

        Polymorphism is one of the four pillars of
        Object-Oriented Programming (OOP).

        The word Polymorphism comes from:

            Poly = Many
            Morph = Forms

        Meaning:

            Many Forms

        Polymorphism allows the same method
        to behave differently depending on
        the object using it.

        This creates flexible and reusable code.
    */

    /*
        ============================================================
        1. WHAT IS POLYMORPHISM?
        ============================================================

        Polymorphism allows a base class
        reference to represent many different
        derived class objects.

        Example:

            Character character;

        That variable could refer to:

            Warrior
            Mage
            Archer

        Each class can perform actions
        differently.
    */

    /*
        ============================================================
        2. WHY USE POLYMORPHISM?
        ============================================================

        Without polymorphism:

            WarriorAttack()
            MageAttack()
            ArcherAttack()

        Different code everywhere.

        With polymorphism:

            Attack()

        One common method name.

        Different behaviors.

        Cleaner and easier to maintain.
    */

    /*
        ============================================================
        3. THE VIRTUAL KEYWORD
        ============================================================

        A virtual method allows child classes
        to replace its behavior.

        Example:

            public virtual void Attack()
            {
                Console.WriteLine("Character attacks.");
            }

        Child classes can override it.
    */

    /*
        ============================================================
        4. THE OVERRIDE KEYWORD
        ============================================================

        Override replaces the inherited method.

        Example:

            public override void Attack()
            {
                Console.WriteLine("Warrior attacks.");
            }

        The original behavior changes.
    */

    /*
        ============================================================
        5. BASIC POLYMORPHISM EXAMPLE
        ============================================================

            Character character = new Warrior();

            character.Attack();

        Output:

            Warrior attacks.

        Even though the variable type
        is Character.

        Runtime determines which method
        executes.
    */

    /*
        ============================================================
        6. RUNTIME POLYMORPHISM
        ============================================================

        Runtime polymorphism means the
        correct method is chosen while
        the program is running.

        Example:

            Character c1 = new Warrior();
            Character c2 = new Mage();
            Character c3 = new Archer();

            c1.Attack();
            c2.Attack();
            c3.Attack();

        Same method.

        Different results.
    */

    /*
        ============================================================
        7. BASE CLASS REFERENCES
        ============================================================

        A base class reference can point
        to any derived class object.

            Character character;

        Can store:

            Warrior
            Mage
            Archer

        This makes programs flexible.
    */

    /*
        ============================================================
        8. GAME DEVELOPMENT EXAMPLE
        ============================================================

        Base Class:

            Character

        Method:

            Attack()

        Child Classes:

            Warrior
            Mage
            Archer

        Each attack behaves differently.

        Perfect use case for polymorphism.
    */

    /*
        ============================================================
        9. PAYMENT SYSTEM EXAMPLE
        ============================================================

        Base Class:

            PaymentMethod

        Method:

            ProcessPayment()

        Child Classes:

            CreditCard
            PayPal
            BankTransfer

        Same method.

        Different processing logic.
    */

    /*
        ============================================================
        10. EMPLOYEE SYSTEM EXAMPLE
        ============================================================

        Base Class:

            Employee

        Method:

            CalculateSalary()

        Child Classes:

            Manager
            Developer
            Designer

        Salary calculations may differ.
    */

    /*
        ============================================================
        11. COLLECTIONS AND POLYMORPHISM
        ============================================================

        Example:

            Character[] characters =
            {
                new Warrior(),
                new Mage(),
                new Archer()
            };

        Loop:

            foreach(Character c in characters)
            {
                c.Attack();
            }

        Each object executes its own version.
    */

    /*
        ============================================================
        12. BENEFITS OF POLYMORPHISM
        ============================================================

        ✔ Less code duplication

        ✔ Better scalability

        ✔ Easier maintenance

        ✔ More reusable code

        ✔ Cleaner architecture

        ✔ Professional OOP design
    */

    /*
        ============================================================
        13. COMMON BEGINNER MISTAKES
        ============================================================

        Mistake #1

        Forgetting virtual.

        Result:

        Override cannot be used.

        ------------------------------------------------

        Mistake #2

        Forgetting override.

        Result:

        Parent method executes.

        ------------------------------------------------

        Mistake #3

        Not understanding runtime behavior.

        The object's real type determines
        which method runs.
    */

    /*
        ============================================================
        14. VIRTUAL VS NORMAL METHODS
        ============================================================

        Normal Method:

            Cannot be overridden.

        Virtual Method:

            Can be overridden.

        Virtual methods enable polymorphism.
    */

    /*
        ============================================================
        15. POLYMORPHISM IN REAL SOFTWARE
        ============================================================

        Used in:

        - Video Games
        - Banking Systems
        - Online Stores
        - Mobile Apps
        - Desktop Applications
        - Enterprise Software

        It is one of the most commonly
        used OOP concepts.
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Polymorphism allows me to:

        - Create flexible systems
        - Reuse code
        - Use one method name
        - Execute different behaviors
        - Build scalable applications

        Polymorphism works together with
        inheritance and is one of the most
        powerful concepts in C#.
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
