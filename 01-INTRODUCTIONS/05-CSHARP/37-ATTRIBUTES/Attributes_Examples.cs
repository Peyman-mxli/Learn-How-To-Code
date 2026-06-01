```csharp
/*
=========================================
37 - ATTRIBUTES
Attributes_Examples.cs
=========================================
*/

using System;
using System.Diagnostics;
using System.Reflection;

namespace AttributesExamples
{
    // =========================================
    // Obsolete Attribute Example
    // =========================================

    class Calculator
    {
        [Obsolete("Use NewAdd() instead.")]
        public int OldAdd(int a, int b)
        {
            return a + b;
        }

        public int NewAdd(int a, int b)
        {
            return a + b;
        }
    }

    // =========================================
    // Serializable Attribute Example
    // =========================================

    [Serializable]
    class PlayerData
    {
        public string Name;
        public int Level;
    }

    // =========================================
    // Conditional Attribute Example
    // =========================================

    class DebugTools
    {
        [Conditional("DEBUG")]
        public static void LogMessage()
        {
            Console.WriteLine("Debug message displayed.");
        }
    }

    // =========================================
    // Flags Attribute Example
    // =========================================

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    // =========================================
    // Custom Attribute Example
    // =========================================

    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public string Version { get; set; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("Peyman", Version = "1.0")]
    class Project
    {
    }

    // =========================================
    // Method Attribute Example
    // =========================================

    class GameSystem
    {
        [Obsolete("Use NewAttack() instead.")]
        public void OldAttack()
        {
            Console.WriteLine("Old Attack Executed.");
        }

        public void NewAttack()
        {
            Console.WriteLine("New Attack Executed.");
        }
    }

    // =========================================
    // Property Attribute Example
    // =========================================

    class User
    {
        [Obsolete("Use Username instead.")]
        public string OldUsername
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }
    }

    // =========================================
    // Reflection Example
    // =========================================

    class ReflectionHelper
    {
        public static void DisplayAttributes(Type type)
        {
            object[] attributes =
                type.GetCustomAttributes(true);

            Console.WriteLine($"Attributes for: {type.Name}");

            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("OBSOLETE ATTRIBUTE");
            Console.WriteLine("=================================");

            Calculator calculator = new Calculator();

#pragma warning disable CS0618
            Console.WriteLine(calculator.OldAdd(5, 3));
#pragma warning restore CS0618

            Console.WriteLine(calculator.NewAdd(5, 3));

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("SERIALIZABLE ATTRIBUTE");
            Console.WriteLine("=================================");

            PlayerData player = new PlayerData();

            player.Name = "Peyman";
            player.Level = 25;

            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Level: {player.Level}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("CONDITIONAL ATTRIBUTE");
            Console.WriteLine("=================================");

            DebugTools.LogMessage();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("FLAGS ATTRIBUTE");
            Console.WriteLine("=================================");

            Permissions userPermissions =
                Permissions.Read | Permissions.Write;

            Console.WriteLine(userPermissions);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("CUSTOM ATTRIBUTE");
            Console.WriteLine("=================================");

            ReflectionHelper.DisplayAttributes(typeof(Project));

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("METHOD ATTRIBUTE");
            Console.WriteLine("=================================");

            GameSystem gameSystem = new GameSystem();

#pragma warning disable CS0618
            gameSystem.OldAttack();
#pragma warning restore CS0618

            gameSystem.NewAttack();

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("PROPERTY ATTRIBUTE");
            Console.WriteLine("=================================");

            User user = new User();

#pragma warning disable CS0618
            user.OldUsername = "OldUser";
#pragma warning restore CS0618

            user.Username = "NewUser";

            Console.WriteLine(user.Username);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("REFLECTION DETAILS");
            Console.WriteLine("=================================");

            Type projectType = typeof(Project);

            AuthorAttribute authorAttribute =
                (AuthorAttribute)Attribute.GetCustomAttribute
                (
                    projectType,
                    typeof(AuthorAttribute)
                );

            Console.WriteLine($"Author: {authorAttribute.Name}");
            Console.WriteLine($"Version: {authorAttribute.Version}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("ATTRIBUTES EXAMPLES COMPLETE");
            Console.WriteLine("=================================");
        }
    }
}

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
```
