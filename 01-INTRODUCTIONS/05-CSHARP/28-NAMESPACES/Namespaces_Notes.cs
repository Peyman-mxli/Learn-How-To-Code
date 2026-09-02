using System;

/*
    ============================================================
    NAMESPACES NOTES
    ============================================================

    In this module, I learn about Namespaces.

    Namespaces are used to organize code into logical groups.

    As projects become larger, they contain many classes,
    interfaces, records, enums, structs, and other types.

    Namespaces help keep everything organized and prevent
    naming conflicts.

    ============================================================
    WHAT IS A NAMESPACE?
    ============================================================

    A namespace is a container that groups related code.

    Example:

        namespace SchoolSystem
        {
            public class Student
            {
            }
        }

    Student belongs to the SchoolSystem namespace.

    ============================================================
    WHY NAMESPACES EXIST
    ============================================================

    Imagine two developers create classes with
    the same name.

    Example:

        Student

    Without namespaces, C# would not know which
    Student class to use.

    Namespaces solve this problem.

    ============================================================
    BASIC NAMESPACE SYNTAX
    ============================================================

    Example:

        namespace MyApplication
        {
            public class Player
            {
            }
        }

    The Player class is now inside the
    MyApplication namespace.

    ============================================================
    ACCESSING A NAMESPACE
    ============================================================

    There are two common ways to access
    a namespace.

    Method 1:

        using MyApplication;

    Then:

        Player player = new Player();

    ------------------------------------------------------------

    Method 2:

        MyApplication.Player player =
            new MyApplication.Player();

    Fully qualified names always work.

    ============================================================
    THE USING KEYWORD
    ============================================================

    The using keyword imports a namespace.

    Example:

        using System;

    This allows me to write:

        Console.WriteLine("Hello");

    Instead of:

        System.Console.WriteLine("Hello");

    ============================================================
    COMMON SYSTEM NAMESPACES
    ============================================================

    Examples:

        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.IO;
        using System.Threading.Tasks;

    These provide access to many built-in features.

    ============================================================
    NESTED NAMESPACES
    ============================================================

    Namespaces can contain other namespaces.

    Example:

        namespace Company
        {
            namespace HR
            {
                public class Employee
                {
                }
            }
        }

    More commonly:

        namespace Company.HR
        {
            public class Employee
            {
            }
        }

    Both are equivalent.

    ============================================================
    REAL-WORLD PROJECT STRUCTURE
    ============================================================

    Example:

        NovaZone

            NovaZone.Player
            NovaZone.Enemy
            NovaZone.Inventory
            NovaZone.Combat
            NovaZone.UI

    Each namespace organizes related classes.

    ============================================================
    AVOIDING NAME CONFLICTS
    ============================================================

    Example:

        namespace School
        {
            public class Student
            {
            }
        }

        namespace University
        {
            public class Student
            {
            }
        }

    Both classes can exist because
    they belong to different namespaces.

    Usage:

        School.Student schoolStudent =
            new School.Student();

        University.Student universityStudent =
            new University.Student();

    ============================================================
    FILE-SCOPED NAMESPACES
    ============================================================

    Modern C# introduced file-scoped namespaces.

    Traditional:

        namespace MyProject
        {
            public class Player
            {
            }
        }

    File-Scoped:

        namespace MyProject;

        public class Player
        {
        }

    Benefits:

    - Less indentation
    - Cleaner files
    - Modern style

    ============================================================
    USING ALIASES
    ============================================================

    I can create aliases for namespaces.

    Example:

        using IO = System.IO;

    Usage:

        IO.File.ReadAllText("data.txt");

    Helpful when namespace names are long.

    ============================================================
    GLOBAL USING
    ============================================================

    Modern C# supports global using.

    Example:

        global using System;

    This makes System available
    throughout the entire project.

    ============================================================
    NAMESPACE BEST PRACTICES
    ============================================================

    Use meaningful names.

    Good:

        Company.Inventory
        Company.Customers
        Company.Payments

    Avoid:

        Namespace1
        TestStuff
        RandomFolder

    ============================================================
    PROJECT ORGANIZATION EXAMPLE
    ============================================================

    Example:

        OnlineStore

            OnlineStore.Products
            OnlineStore.Customers
            OnlineStore.Orders
            OnlineStore.Payments
            OnlineStore.Reports

    This structure is easier to maintain.

    ============================================================
    NAMESPACES AND CLASSES
    ============================================================

    Namespaces contain classes.

    Example:

        namespace Game
        {
            public class Player
            {
            }

            public class Enemy
            {
            }

            public class Inventory
            {
            }
        }

    Multiple classes can exist inside
    the same namespace.

    ============================================================
    NAMESPACES AND INTERFACES
    ============================================================

    Namespaces can contain interfaces.

    Example:

        namespace Services
        {
            public interface ILogger
            {
            }
        }

    ============================================================
    NAMESPACES AND ENUMS
    ============================================================

    Namespaces can contain enums.

    Example:

        namespace Game
        {
            public enum Rank
            {
                Beginner,
                Intermediate,
                Advanced
            }
        }

    ============================================================
    NAMESPACES AND RECORDS
    ============================================================

    Namespaces can contain records.

    Example:

        namespace Models
        {
            public record User(
                string Name
            );
        }

    ============================================================
    BENEFITS OF NAMESPACES
    ============================================================

    - Better organization
    - Cleaner projects
    - Easier maintenance
    - Avoid naming conflicts
    - Professional structure
    - Better teamwork

    ============================================================
    COMMON MISTAKES
    ============================================================

    Mistake #1

    Putting everything into one namespace.

    ------------------------------------------------------------

    Mistake #2

    Using meaningless namespace names.

    ------------------------------------------------------------

    Mistake #3

    Creating namespaces that are too deep.

    Example:

        Company.Project.Module.
        Feature.SubFeature.Version.Test

    This becomes difficult to manage.

    ------------------------------------------------------------

    Mistake #4

    Forgetting to import a namespace.

    This causes compiler errors.

    ============================================================
    WHEN TO CREATE NEW NAMESPACES
    ============================================================

    Create a new namespace when:

    - A feature grows large
    - Classes belong to different systems
    - Code becomes difficult to locate
    - Team organization improves

    ============================================================
    SUMMARY
    ============================================================

    Namespaces help organize code and prevent
    naming conflicts.

    Important concepts:

    - namespace keyword
    - using keyword
    - nested namespaces
    - file-scoped namespaces
    - aliases
    - project organization

    Namespaces are a fundamental part of
    professional C# development.
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
