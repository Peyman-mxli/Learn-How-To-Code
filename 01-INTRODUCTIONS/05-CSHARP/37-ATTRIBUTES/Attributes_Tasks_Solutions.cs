/*
=========================================
37 - ATTRIBUTES
Attributes_Tasks_Solutions.cs
=========================================
*/

using System;
using System.Diagnostics;
using System.Reflection;

namespace AttributesTasksSolutions
{
    [Obsolete("OldCalculator should no longer be used.")]
    class OldCalculator
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This calculator is old and should no longer be used.");
        }
    }

    class LoginSystem
    {
        [Obsolete("Use NewLogin() instead.")]
        public void OldLogin()
        {
            Console.WriteLine("Old login system used.");
        }

        public void NewLogin()
        {
            Console.WriteLine("New login system used.");
        }
    }

    [Serializable]
    class PlayerData
    {
        public string Name;
        public int Level;
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

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

    class DebugTools
    {
        [Conditional("DEBUG")]
        public static void DebugMessage()
        {
            Console.WriteLine("Debug message displayed.");
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class AuthorAttribute : Attribute
    {
        public string Name
        {
            get;
        }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class VersionAttribute : Attribute
    {
        public string VersionNumber
        {
            get;
        }

        public VersionAttribute(string versionNumber)
        {
            VersionNumber = versionNumber;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class DeveloperAttribute : Attribute
    {
        public string DeveloperName
        {
            get;
        }

        public string ProjectName
        {
            get;
        }

        public DeveloperAttribute(string developerName, string projectName)
        {
            DeveloperName = developerName;
            ProjectName = projectName;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class ClassOnlyAttribute : Attribute
    {
        public string Description
        {
            get;
        }

        public ClassOnlyAttribute(string description)
        {
            Description = description;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class ClassMethodInfoAttribute : Attribute
    {
        public string Info
        {
            get;
        }

        public ClassMethodInfoAttribute(string info)
        {
            Info = info;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class DocumentationAttribute : Attribute
    {
        public string Description
        {
            get;
        }

        public string Author
        {
            get;
        }

        public DocumentationAttribute(string description, string author)
        {
            Description = description;
            Author = author;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class DatabaseTableAttribute : Attribute
    {
        public string TableName
        {
            get;
        }

        public DatabaseTableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    class ApiEndpointAttribute : Attribute
    {
        public string Route
        {
            get;
        }

        public string HttpMethod
        {
            get;
        }

        public ApiEndpointAttribute(string route, string httpMethod)
        {
            Route = route;
            HttpMethod = httpMethod;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class CharacterInfoAttribute : Attribute
    {
        public string Name
        {
            get;
        }

        public string Role
        {
            get;
        }

        public int Level
        {
            get;
        }

        public CharacterInfoAttribute(string name, string role, int level)
        {
            Name = name;
            Role = role;
            Level = level;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class ItemInfoAttribute : Attribute
    {
        public string ItemName
        {
            get;
        }

        public string Rarity
        {
            get;
        }

        public int ItemLevel
        {
            get;
        }

        public ItemInfoAttribute(string itemName, string rarity, int itemLevel)
        {
            ItemName = itemName;
            Rarity = rarity;
            ItemLevel = itemLevel;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class SkillInfoAttribute : Attribute
    {
        public string SkillName
        {
            get;
        }

        public string SkillType
        {
            get;
        }

        public int Cooldown
        {
            get;
        }

        public SkillInfoAttribute(string skillName, string skillType, int cooldown)
        {
            SkillName = skillName;
            SkillType = skillType;
            Cooldown = cooldown;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class QuestInfoAttribute : Attribute
    {
        public string QuestName
        {
            get;
        }

        public string Difficulty
        {
            get;
        }

        public int RewardGold
        {
            get;
        }

        public QuestInfoAttribute(string questName, string difficulty, int rewardGold)
        {
            QuestName = questName;
            Difficulty = difficulty;
            RewardGold = rewardGold;
        }
    }

    [Author("Peyman")]
    class Project
    {
    }

    [Version("1.0.0")]
    class ApplicationVersion
    {
    }

    [Developer("Peyman", "Learn How To Code")]
    class DeveloperProject
    {
    }

    [ClassOnly("This attribute can only be applied to classes.")]
    class ClassOnlyExample
    {
    }

    [ClassMethodInfo("This attribute is applied to a class.")]
    class MixedAttributeExample
    {
        [ClassMethodInfo("This attribute is applied to a method.")]
        public void Display()
        {
            Console.WriteLine("Mixed attribute example method.");
        }
    }

    [Documentation("This class stores user profile information.", "Peyman")]
    class UserProfile
    {
    }

    [Documentation("This class stores product information.", "Peyman")]
    class ProductInfo
    {
    }

    [DatabaseTable("Users")]
    class UserTable
    {
    }

    class ApiController
    {
        [ApiEndpoint("/api/users", "GET")]
        public void GetUsers()
        {
        }

        [ApiEndpoint("/api/users", "POST")]
        public void CreateUser()
        {
        }

        [ApiEndpoint("/api/users/delete", "DELETE")]
        public void DeleteUser()
        {
        }
    }

    [Serializable]
    [CharacterInfo("Nova Hero", "Tank", 50)]
    class RPGCharacter
    {
    }

    [ItemInfo("Dragon Sword", "Legendary", 100)]
    class RPGItem
    {
    }

    [SkillInfo("Nova Strike", "Melee Skill", 3)]
    class RPGSkill
    {
    }

    [QuestInfo("Defeat The Dragon", "Hard", 500)]
    class RPGQuest
    {
    }

    class ReflectionHelper
    {
        public static void DisplayClassAttributes(Type type)
        {
            Console.WriteLine($"Attributes for class: {type.Name}");

            object[] attributes = type.GetCustomAttributes(true);

            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }

        public static void DisplayMethodAttributes(Type type, string methodName)
        {
            MethodInfo methodInfo = type.GetMethod(methodName);

            if (methodInfo == null)
            {
                Console.WriteLine("Method not found.");
                return;
            }

            Console.WriteLine($"Attributes for method: {methodInfo.Name}");

            object[] attributes = methodInfo.GetCustomAttributes(true);

            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }

        public static void DisplayAuthor(Type type)
        {
            AuthorAttribute attribute =
                type.GetCustomAttribute<AuthorAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Author: {attribute.Name}");
            }
        }

        public static void DisplayVersion(Type type)
        {
            VersionAttribute attribute =
                type.GetCustomAttribute<VersionAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Version: {attribute.VersionNumber}");
            }
        }

        public static void DisplayDeveloper(Type type)
        {
            DeveloperAttribute attribute =
                type.GetCustomAttribute<DeveloperAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Developer: {attribute.DeveloperName}");
                Console.WriteLine($"Project: {attribute.ProjectName}");
            }
        }

        public static void DisplayDocumentation(Type type)
        {
            DocumentationAttribute attribute =
                type.GetCustomAttribute<DocumentationAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Description: {attribute.Description}");
                Console.WriteLine($"Author: {attribute.Author}");
            }
        }

        public static void DisplayDatabaseTable(Type type)
        {
            DatabaseTableAttribute attribute =
                type.GetCustomAttribute<DatabaseTableAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Database Table: {attribute.TableName}");
            }
        }

        public static void DisplayApiEndpoints(Type type)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                ApiEndpointAttribute attribute =
                    method.GetCustomAttribute<ApiEndpointAttribute>();

                if (attribute != null)
                {
                    Console.WriteLine($"Method: {method.Name}");
                    Console.WriteLine($"Route: {attribute.Route}");
                    Console.WriteLine($"HTTP Method: {attribute.HttpMethod}");
                    Console.WriteLine();
                }
            }
        }

        public static void DisplayRPGMetadata(Type type)
        {
            CharacterInfoAttribute characterInfo =
                type.GetCustomAttribute<CharacterInfoAttribute>();

            if (characterInfo != null)
            {
                Console.WriteLine("Character Metadata");
                Console.WriteLine($"Name: {characterInfo.Name}");
                Console.WriteLine($"Role: {characterInfo.Role}");
                Console.WriteLine($"Level: {characterInfo.Level}");
                Console.WriteLine();
            }

            ItemInfoAttribute itemInfo =
                type.GetCustomAttribute<ItemInfoAttribute>();

            if (itemInfo != null)
            {
                Console.WriteLine("Item Metadata");
                Console.WriteLine($"Item Name: {itemInfo.ItemName}");
                Console.WriteLine($"Rarity: {itemInfo.Rarity}");
                Console.WriteLine($"Item Level: {itemInfo.ItemLevel}");
                Console.WriteLine();
            }

            SkillInfoAttribute skillInfo =
                type.GetCustomAttribute<SkillInfoAttribute>();

            if (skillInfo != null)
            {
                Console.WriteLine("Skill Metadata");
                Console.WriteLine($"Skill Name: {skillInfo.SkillName}");
                Console.WriteLine($"Skill Type: {skillInfo.SkillType}");
                Console.WriteLine($"Cooldown: {skillInfo.Cooldown} seconds");
                Console.WriteLine();
            }

            QuestInfoAttribute questInfo =
                type.GetCustomAttribute<QuestInfoAttribute>();

            if (questInfo != null)
            {
                Console.WriteLine("Quest Metadata");
                Console.WriteLine($"Quest Name: {questInfo.QuestName}");
                Console.WriteLine($"Difficulty: {questInfo.Difficulty}");
                Console.WriteLine($"Reward Gold: {questInfo.RewardGold}");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0618
            OldCalculator oldCalculator = new OldCalculator();
            oldCalculator.DisplayMessage();
#pragma warning restore CS0618

            LoginSystem loginSystem = new LoginSystem();

#pragma warning disable CS0618
            loginSystem.OldLogin();
#pragma warning restore CS0618

            loginSystem.NewLogin();

            PlayerData playerData = new PlayerData();

            playerData.Name = "Peyman";
            playerData.Level = 25;

            Console.WriteLine($"Player Name: {playerData.Name}");
            Console.WriteLine($"Player Level: {playerData.Level}");

            Permissions permissions =
                Permissions.Read | Permissions.Write | Permissions.Delete;

            Console.WriteLine($"Permissions: {permissions}");

            User user = new User();

#pragma warning disable CS0618
            user.OldUsername = "OldPeyman";
            Console.WriteLine($"Old Username: {user.OldUsername}");
#pragma warning restore CS0618

            user.Username = "NewPeyman";
            Console.WriteLine($"Username: {user.Username}");

            DebugTools.DebugMessage();

            ReflectionHelper.DisplayAuthor(typeof(Project));
            ReflectionHelper.DisplayVersion(typeof(ApplicationVersion));
            ReflectionHelper.DisplayDeveloper(typeof(DeveloperProject));

            ReflectionHelper.DisplayClassAttributes(typeof(ClassOnlyExample));

            ReflectionHelper.DisplayClassAttributes(typeof(MixedAttributeExample));
            ReflectionHelper.DisplayMethodAttributes
            (
                typeof(MixedAttributeExample),
                "Display"
            );

            ReflectionHelper.DisplayDocumentation(typeof(UserProfile));
            ReflectionHelper.DisplayDocumentation(typeof(ProductInfo));

            Console.WriteLine("Documentation attributes are useful because they");
            Console.WriteLine("store readable metadata directly on important classes.");

            ReflectionHelper.DisplayDatabaseTable(typeof(UserTable));

            Console.WriteLine("ORM tools use similar metadata to connect classes");
            Console.WriteLine("to database tables and columns.");

            ReflectionHelper.DisplayApiEndpoints(typeof(ApiController));

            Console.WriteLine("Web frameworks use endpoint metadata to understand");
            Console.WriteLine("routes, HTTP methods, and controller behavior.");

            ReflectionHelper.DisplayRPGMetadata(typeof(RPGCharacter));
            ReflectionHelper.DisplayRPGMetadata(typeof(RPGItem));
            ReflectionHelper.DisplayRPGMetadata(typeof(RPGSkill));
            ReflectionHelper.DisplayRPGMetadata(typeof(RPGQuest));

            Console.WriteLine("Game engines and frameworks can use metadata");
            Console.WriteLine("to describe characters, items, skills, and quests");
            Console.WriteLine("without hardcoding every detail inside the logic.");
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
