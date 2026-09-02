```csharp
using System;

namespace LearnHowToCode.Encapsulation
{
    /*
        ============================================================
        ENCAPSULATION NOTES
        ============================================================

        In this module, I learn about Encapsulation.

        Encapsulation is one of the four pillars of
        Object-Oriented Programming (OOP).

        Encapsulation means hiding internal data and controlling
        how that data is accessed or modified.

        Instead of allowing direct access to variables,
        I protect them and provide safe ways to interact
        with the data.

        Benefits:

        - Better security
        - Better data protection
        - Easier maintenance
        - Cleaner code
        - Reduced bugs
        - Professional design
    */

    class EncapsulationNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        1. WHAT IS ENCAPSULATION?
        ============================================================

        Encapsulation is the process of:

        1. Hiding data
        2. Protecting data
        3. Controlling access to data

        Example:

        Instead of:

            person.age = -100;

        We protect age and validate it before storing it.

        This prevents invalid values from entering our system.
    */

    /*
        ============================================================
        2. ACCESS MODIFIERS
        ============================================================

        Access modifiers control who can access members
        of a class.

        Common modifiers:

        public
        private
        protected
        internal

        Beginner focus:

        public
        private
    */

    /*
        ============================================================
        3. PUBLIC
        ============================================================

        Public members can be accessed from anywhere.

        Example:

            public string Name;

        Any class can read or modify it.

        Use carefully because unrestricted access
        can create bugs.
    */

    /*
        ============================================================
        4. PRIVATE
        ============================================================

        Private members can only be accessed
        inside their own class.

        Example:

            private int age;

        No external class can directly access age.

        This is the foundation of encapsulation.
    */

    /*
        ============================================================
        5. WHY PRIVATE IS IMPORTANT
        ============================================================

        Consider:

            public int Age;

        A programmer could write:

            Age = -50;

        That value makes no sense.

        Instead:

            private int age;

        Then validation can be performed before
        storing the value.
    */

    /*
        ============================================================
        6. GETTER METHODS
        ============================================================

        A Getter returns data.

        Example:

            public int GetAge()
            {
                return age;
            }

        Purpose:

        - Read private data safely
        - Control what is exposed
    */

    /*
        ============================================================
        7. SETTER METHODS
        ============================================================

        A Setter updates data.

        Example:

            public void SetAge(int value)
            {
                if (value >= 0)
                {
                    age = value;
                }
            }

        Purpose:

        - Validate input
        - Prevent invalid values
    */

    /*
        ============================================================
        8. FULL ENCAPSULATION EXAMPLE
        ============================================================

            class Person
            {
                private int age;

                public void SetAge(int value)
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                }

                public int GetAge()
                {
                    return age;
                }
            }

        External classes cannot directly change age.

        They must use the provided methods.
    */

    /*
        ============================================================
        9. PROPERTIES
        ============================================================

        C# provides Properties.

        Properties simplify encapsulation.

        Instead of creating separate Getter
        and Setter methods, I can use:

            public int Age
            {
                get;
                set;
            }

        This is cleaner and more professional.
    */

    /*
        ============================================================
        10. GET ACCESSOR
        ============================================================

        The get accessor returns a value.

            get
            {
                return age;
            }

        Used whenever someone reads the property.
    */

    /*
        ============================================================
        11. SET ACCESSOR
        ============================================================

        The set accessor assigns a value.

            set
            {
                age = value;
            }

        Used whenever someone updates the property.
    */

    /*
        ============================================================
        12. PROPERTY WITH VALIDATION
        ============================================================

            private int age;

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                }
            }

        This combines encapsulation and validation.
    */

    /*
        ============================================================
        13. AUTO-IMPLEMENTED PROPERTIES
        ============================================================

        Simplified syntax:

            public string Name { get; set; }

        The compiler automatically creates
        the hidden backing field.

        This is very common in modern C#.
    */

    /*
        ============================================================
        14. READ-ONLY PROPERTY
        ============================================================

            public string Country
            {
                get;
            }

        Value can be read.

        Value cannot be modified externally.

        Useful for protected information.
    */

    /*
        ============================================================
        15. PRIVATE SETTER
        ============================================================

            public string Username
            {
                get;
                private set;
            }

        Anyone can read it.

        Only the class itself can modify it.
    */

    /*
        ============================================================
        16. ENCAPSULATION IN BANKING
        ============================================================

        Example:

            private decimal balance;

        Never expose balance directly.

        Instead:

            Deposit()
            Withdraw()
            GetBalance()

        This prevents invalid transactions.
    */

    /*
        ============================================================
        17. ENCAPSULATION IN GAMES
        ============================================================

        Example:

            private int health;

        Instead of:

            player.Health = -999;

        Use:

            TakeDamage()
            Heal()

        This keeps health values valid.
    */

    /*
        ============================================================
        18. ENCAPSULATION IN BUSINESS SOFTWARE
        ============================================================

        Employee:

            private decimal salary;

        Customer:

            private string password;

        Product:

            private decimal price;

        Sensitive information should be protected.
    */

    /*
        ============================================================
        19. COMMON BEGINNER MISTAKES
        ============================================================

        Mistake #1

            Making everything public

        Problem:

            No protection.

        ------------------------------------------------

        Mistake #2

            No validation

        Problem:

            Invalid data enters the system.

        ------------------------------------------------

        Mistake #3

            Exposing sensitive information

        Problem:

            Security risks.
    */

    /*
        ============================================================
        20. BEST PRACTICES
        ============================================================

        ✔ Keep fields private

        ✔ Use properties

        ✔ Validate data

        ✔ Protect sensitive values

        ✔ Expose only what is necessary

        ✔ Keep classes responsible for their own data

        ✔ Follow C# naming conventions

        ✔ Use encapsulation in every object-oriented project
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Encapsulation allows me to:

        - Hide data
        - Protect data
        - Validate data
        - Prevent bugs
        - Create professional applications

        Encapsulation is one of the most important
        skills in Object-Oriented Programming and
        serves as the foundation for larger and
        more secure software systems.
    */
}

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
