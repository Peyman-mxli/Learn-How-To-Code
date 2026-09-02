```csharp
using System;

namespace LearnHowToCode.Inheritance
{
    class InheritanceNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        INHERITANCE NOTES
        ============================================================

        In this module, I learn about Inheritance.

        Inheritance is one of the four pillars of
        Object-Oriented Programming (OOP).

        The four pillars are:

        1. Encapsulation
        2. Inheritance
        3. Polymorphism
        4. Abstraction

        Inheritance allows one class to inherit
        fields, properties, methods, and behaviors
        from another class.

        This helps reduce duplicate code and
        improves maintainability.
    */

    /*
        ============================================================
        1. WHAT IS INHERITANCE?
        ============================================================

        Inheritance allows a class to acquire
        members from another class.

        Parent Class
        Base Class
        Super Class

        These names all refer to the class
        being inherited from.

        Child Class
        Derived Class
        Sub Class

        These names all refer to the class
        that inherits from another class.

        Example:

            Animal
               |
            Dog

        Dog inherits from Animal.
    */

    /*
        ============================================================
        2. WHY USE INHERITANCE?
        ============================================================

        Without inheritance:

            Warrior
            Mage
            Archer

        Each class might contain:

            Name
            Health
            Level

        The same code would be repeated.

        With inheritance:

            Character

                |
        -------------------
        |        |        |
      Warrior   Mage   Archer

        Shared code exists only once.
    */

    /*
        ============================================================
        3. BASE CLASS
        ============================================================

        A Base Class contains common functionality.

        Example:

            class Character
            {
                public string Name;
                public int Level;
            }

        This becomes the parent class.
    */

    /*
        ============================================================
        4. DERIVED CLASS
        ============================================================

        A Derived Class inherits from
        the Base Class.

        Example:

            class Warrior : Character
            {

            }

        The colon (:) means inheritance.
    */

    /*
        ============================================================
        5. THE COLON SYMBOL
        ============================================================

        Syntax:

            class Child : Parent

        Example:

            class Dog : Animal

        Dog receives all accessible members
        from Animal.
    */

    /*
        ============================================================
        6. SIMPLE EXAMPLE
        ============================================================

            class Animal
            {
                public void Eat()
                {
                    Console.WriteLine("Eating...");
                }
            }

            class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine("Bark!");
                }
            }

        Dog can use:

            Eat()
            Bark()

        Even though Eat() exists only
        inside Animal.
    */

    /*
        ============================================================
        7. REUSING CODE
        ============================================================

        One of the biggest benefits
        of inheritance is code reuse.

        Instead of writing the same code
        multiple times, I place it inside
        a base class.

        Child classes automatically
        receive that functionality.
    */

    /*
        ============================================================
        8. ACCESSING INHERITED MEMBERS
        ============================================================

        Example:

            Warrior warrior = new Warrior();

            warrior.Name = "Nova";
            warrior.Level = 10;

        Name and Level belong to Character.

        Warrior inherited them.
    */

    /*
        ============================================================
        9. MULTIPLE CHILD CLASSES
        ============================================================

        One parent can have many children.

                     Character
                     /   |   \
                    /    |    \
              Warrior Mage Archer

        Each child receives the same
        inherited members.

        Each child can also add
        unique functionality.
    */

    /*
        ============================================================
        10. ADDING UNIQUE BEHAVIOR
        ============================================================

        Example:

            class Warrior : Character
            {
                public void Slash()
                {
                    Console.WriteLine("Slash!");
                }
            }

            class Mage : Character
            {
                public void CastSpell()
                {
                    Console.WriteLine("Fireball!");
                }
            }

        Both inherit from Character,
        but each has unique abilities.
    */

    /*
        ============================================================
        11. CONSTRUCTORS AND INHERITANCE
        ============================================================

        Constructors are inherited indirectly.

        Parent constructors execute first.

        Then child constructors execute.

        Example:

            Character Constructor

                    ↓

            Warrior Constructor

        This guarantees the parent
        initializes before the child.
    */

    /*
        ============================================================
        12. THE BASE KEYWORD
        ============================================================

        The base keyword refers
        to the parent class.

        Example:

            class Warrior : Character
            {
                public Warrior(string name)
                    : base(name)
                {

                }
            }

        base(name) calls the parent constructor.
    */

    /*
        ============================================================
        13. CONSTRUCTOR CHAINING
        ============================================================

        Example:

            class Character
            {
                public Character(string name)
                {
                    Name = name;
                }
            }

            class Warrior : Character
            {
                public Warrior(string name)
                    : base(name)
                {

                }
            }

        The Warrior constructor passes
        data to the Character constructor.
    */

    /*
        ============================================================
        14. PROTECTED ACCESS MODIFIER
        ============================================================

        protected allows access inside:

        - The current class
        - Derived classes

        Example:

            protected int health;

        Child classes can access health.

        External classes cannot.
    */

    /*
        ============================================================
        15. PUBLIC VS PROTECTED
        ============================================================

        public

        Accessible everywhere.

        protected

        Accessible only inside the class
        and its derived classes.

        private

        Accessible only inside the
        current class.
    */

    /*
        ============================================================
        16. REAL-WORLD EXAMPLE
        ============================================================

        Vehicle

            Brand
            Model
            StartEngine()

        Derived Classes:

            Car
            Motorcycle
            Truck

        All vehicles share common features.

        Each vehicle can add
        unique behavior.
    */

    /*
        ============================================================
        17. GAME DEVELOPMENT EXAMPLE
        ============================================================

        Character

            Name
            Health
            Attack()

        Warrior

            ShieldBash()

        Mage

            Fireball()

        Archer

            MultiShot()

        Shared logic stays in Character.
    */

    /*
        ============================================================
        18. BUSINESS SOFTWARE EXAMPLE
        ============================================================

        Employee

            Name
            Salary

        Manager

            ApproveBudget()

        Developer

            WriteCode()

        Designer

            CreateMockups()

        Shared information stays
        inside Employee.
    */

    /*
        ============================================================
        19. COMMON BEGINNER MISTAKES
        ============================================================

        Mistake #1

        Creating inheritance when
        classes are not related.

        Example:

            Dog : Car

        This relationship makes
        no logical sense.

        ------------------------------------------------

        Mistake #2

        Duplicating code instead of
        using inheritance.

        ------------------------------------------------

        Mistake #3

        Creating deep inheritance trees
        unnecessarily.

        Too many layers can make
        code difficult to understand.
    */

    /*
        ============================================================
        20. BEST PRACTICES
        ============================================================

        ✔ Use inheritance only when
          there is a true relationship.

        ✔ Keep base classes focused.

        ✔ Avoid unnecessary complexity.

        ✔ Reuse code responsibly.

        ✔ Use protected carefully.

        ✔ Prefer composition when
          inheritance becomes excessive.

        ✔ Design class hierarchies clearly.
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Inheritance allows me to:

        - Reuse code
        - Reduce duplication
        - Create parent-child relationships
        - Build scalable applications
        - Organize object-oriented programs

        Inheritance is one of the most
        powerful tools in C# and forms
        the foundation for advanced OOP
        concepts such as Polymorphism
        and Abstraction.
    */
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx //  mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
