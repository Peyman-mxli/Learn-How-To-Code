```csharp
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonExamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Player
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public List<string> Inventory { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("JSON EXAMPLES");
            Console.WriteLine("========================================");

            Example1_SerializeObject();
            Example2_DeserializeObject();
            Example3_PrettyPrintJson();
            Example4_JsonArray();
            Example5_NestedObject();
            Example6_ListSerialization();

            Console.WriteLine("\nAll examples completed.");
        }

        // ----------------------------------------------------
        // Example 1
        // Serialize Object
        // ----------------------------------------------------
        static void Example1_SerializeObject()
        {
            Console.WriteLine("\nEXAMPLE 1 - Serialize Object");

            Person person = new Person
            {
                Name = "Peyman",
                Age = 25
            };

            string json =
                JsonSerializer.Serialize(person);

            Console.WriteLine(json);
        }

        // ----------------------------------------------------
        // Example 2
        // Deserialize Object
        // ----------------------------------------------------
        static void Example2_DeserializeObject()
        {
            Console.WriteLine("\nEXAMPLE 2 - Deserialize Object");

            string json =
                "{\"Name\":\"Nova\",\"Age\":30}";

            Person person =
                JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age : {person.Age}");
        }

        // ----------------------------------------------------
        // Example 3
        // Pretty Print JSON
        // ----------------------------------------------------
        static void Example3_PrettyPrintJson()
        {
            Console.WriteLine("\nEXAMPLE 3 - Pretty Print JSON");

            Person person = new Person
            {
                Name = "Aria",
                Age = 20
            };

            JsonSerializerOptions options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string json =
                JsonSerializer.Serialize(person, options);

            Console.WriteLine(json);
        }

        // ----------------------------------------------------
        // Example 4
        // JSON Array
        // ----------------------------------------------------
        static void Example4_JsonArray()
        {
            Console.WriteLine("\nEXAMPLE 4 - JSON Array");

            string[] items =
            {
                "Sword",
                "Shield",
                "Potion"
            };

            string json =
                JsonSerializer.Serialize(items);

            Console.WriteLine(json);
        }

        // ----------------------------------------------------
        // Example 5
        // Nested Object
        // ----------------------------------------------------
        static void Example5_NestedObject()
        {
            Console.WriteLine("\nEXAMPLE 5 - Nested Object");

            Player player = new Player
            {
                CharacterName = "Nova",
                Level = 80,
                Inventory = new List<string>
                {
                    "Sword",
                    "Shield",
                    "Potion"
                }
            };

            JsonSerializerOptions options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string json =
                JsonSerializer.Serialize(player, options);

            Console.WriteLine(json);
        }

        // ----------------------------------------------------
        // Example 6
        // List Serialization
        // ----------------------------------------------------
        static void Example6_ListSerialization()
        {
            Console.WriteLine("\nEXAMPLE 6 - List Serialization");

            List<Person> people =
                new List<Person>
                {
                    new Person
                    {
                        Name = "Peyman",
                        Age = 25
                    },
                    new Person
                    {
                        Name = "Nova",
                        Age = 30
                    },
                    new Person
                    {
                        Name = "Aria",
                        Age = 20
                    }
                };

            JsonSerializerOptions options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string json =
                JsonSerializer.Serialize(people, options);

            Console.WriteLine(json);
        }
    }
}

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
```
