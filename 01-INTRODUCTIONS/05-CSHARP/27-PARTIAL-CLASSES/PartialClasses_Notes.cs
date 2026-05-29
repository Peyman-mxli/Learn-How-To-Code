using System;

/*
    ============================================================
    PARTIAL CLASSES NOTES
    ============================================================

    In this module, I learn about Partial Classes.

    A partial class allows me to split one class into
    multiple files.

    Even though the class is separated into different files,
    C# combines all parts into one complete class when
    the project is compiled.

    ============================================================
    WHAT IS A PARTIAL CLASS?
    ============================================================

    A partial class is a class that is divided into more than
    one file using the partial keyword.

    Example:

        public partial class Player
        {
            public string Name { get; set; }
        }

    Another file:

        public partial class Player
        {
            public void Attack()
            {
                Console.WriteLine("Player attacks!");
            }
        }

    Both parts belong to the same Player class.

    ============================================================
    WHY PARTIAL CLASSES EXIST
    ============================================================

    Partial classes help organize code.

    They are useful when:

    - A class becomes too large
    - Code is generated automatically
    - I want to separate responsibilities
    - Multiple developers work on the same class
    - I want cleaner project structure

    ============================================================
    THE PARTIAL KEYWORD
    ============================================================

    To create a partial class, every part of the class must
    use the partial keyword.

    Correct:

        public partial class Character
        {
        }

        public partial class Character
        {
        }

    Incorrect:

        public class Character
        {
        }

        public partial class Character
        {
        }

    All parts must be marked as partial.

    ============================================================
    SAME NAMESPACE REQUIREMENT
    ============================================================

    Partial class parts must be in the same namespace.

    Example:

        namespace GameProject
        {
            public partial class Player
            {
            }
        }

        namespace GameProject
        {
            public partial class Player
            {
            }
        }

    If the namespaces are different, C# treats them
    as different classes.

    ============================================================
    SAME ACCESS MODIFIER
    ============================================================

    Partial class parts should use the same accessibility.

    Example:

        public partial class Player
        {
        }

        public partial class Player
        {
        }

    I should not mix:

        public partial class Player

    with:

        internal partial class Player

    ============================================================
    HOW COMPILATION WORKS
    ============================================================

    C# combines all partial class files during compilation.

    This means:

    - I write the class in separate files
    - The compiler treats it as one class
    - One object can use members from all parts

    Example:

        Player player = new Player();

        player.Name = "Peyman";
        player.Attack();

    Name may be in one file.
    Attack may be in another file.
    But both work on the same object.

    ============================================================
    PARTIAL CLASSES WITH PROPERTIES
    ============================================================

    One file can store properties.

    Example:

        public partial class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

    Another file can store methods.

        public partial class Student
        {
            public void DisplayInfo()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
            }
        }

    ============================================================
    PARTIAL CLASSES WITH METHODS
    ============================================================

    Partial classes can contain normal methods.

    Example:

        public partial class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        public partial class Calculator
        {
            public int Subtract(int a, int b)
            {
                return a - b;
            }
        }

    Both methods belong to the same Calculator class.

    ============================================================
    PARTIAL METHODS
    ============================================================

    Partial classes can also use partial methods.

    A partial method allows one part of a class to declare
    a method, and another part to implement it.

    Example:

        public partial class Logger
        {
            partial void LogMessage(string message);
        }

        public partial class Logger
        {
            partial void LogMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

    ============================================================
    RULES FOR PARTIAL METHODS
    ============================================================

    Older C# partial methods had strict rules:

    - They had to return void
    - They were private by default
    - They could not use access modifiers

    Modern C# allows more flexible partial methods,
    but for beginner learning, I should start with
    simple private void partial methods.

    ============================================================
    GENERATED CODE
    ============================================================

    Partial classes are commonly used with generated code.

    Example:

    File 1:

        Form1.Designer.cs

    This file may contain automatically generated UI code.

    File 2:

        Form1.cs

    This file contains my own code.

    Both files use:

        public partial class Form1

    This keeps generated code separate from handwritten code.

    ============================================================
    REAL-WORLD EXAMPLES
    ============================================================

    1. Windows Forms

        Form1.cs
        Form1.Designer.cs

    ------------------------------------------------------------

    2. WPF

        MainWindow.xaml.cs
        Generated UI code

    ------------------------------------------------------------

    3. Entity Framework

        Generated database models
        Custom handwritten logic

    ------------------------------------------------------------

    4. Game Development

        PlayerData.cs
        PlayerCombat.cs
        PlayerMovement.cs

    ============================================================
    GAME DEVELOPMENT EXAMPLE
    ============================================================

    Example:

        public partial class Player
        {
            public string Name { get; set; }
            public int Health { get; set; }
        }

        public partial class Player
        {
            public void Attack()
            {
                Console.WriteLine("Attack!");
            }
        }

        public partial class Player
        {
            public void Move()
            {
                Console.WriteLine("Move!");
            }
        }

    This can organize a large Player class.

    ============================================================
    IMPORTANT WARNING
    ============================================================

    Partial classes are useful, but they should not be abused.

    If a class becomes too big, sometimes it is better
    to create separate classes instead.

    Partial classes organize files.
    They do not replace good class design.

    ============================================================
    PARTIAL CLASS VS NORMAL CLASS
    ============================================================

    Normal Class:

    - Written in one file
    - Easier for small classes
    - Simple to understand

    Partial Class:

    - Split across multiple files
    - Useful for large or generated code
    - Better organization in special cases

    ============================================================
    WHEN TO USE PARTIAL CLASSES
    ============================================================

    Use partial classes when:

    - A class has generated code
    - A class is very large
    - I want to separate file responsibilities
    - A framework requires it
    - I am working with UI designer files

    ============================================================
    WHEN NOT TO USE PARTIAL CLASSES
    ============================================================

    Do not use partial classes when:

    - A normal class is simple enough
    - Splitting makes code harder to follow
    - The class should actually be separate classes
    - I am only trying to hide messy code

    ============================================================
    BENEFITS OF PARTIAL CLASSES
    ============================================================

    - Better organization
    - Cleaner generated code separation
    - Easier teamwork
    - Smaller files
    - Framework support
    - More maintainable large classes

    ============================================================
    COMMON MISTAKES
    ============================================================

    Mistake #1:
    Forgetting the partial keyword on one file.

    ------------------------------------------------------------

    Mistake #2:
    Putting partial parts in different namespaces.

    ------------------------------------------------------------

    Mistake #3:
    Using partial classes instead of proper class design.

    ------------------------------------------------------------

    Mistake #4:
    Editing generated designer files manually.

    ============================================================
    SUMMARY
    ============================================================

    Partial classes allow one class to be split into
    multiple files.

    Important points:

    - Use the partial keyword
    - All parts share the same class name
    - All parts must be in the same namespace
    - The compiler combines all parts
    - Useful for generated code and organization

    Partial classes are helpful when I need better structure
    in larger C# projects.
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
