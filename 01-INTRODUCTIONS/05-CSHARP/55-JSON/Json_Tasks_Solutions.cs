```csharp
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonTaskSolutions
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
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
            Console.WriteLine("TASK 1:");
            Console.WriteLine("JSON means JavaScript Object Notation.");
            Console.WriteLine("JSON is used to store and exchange data between applications.");
            Console.WriteLine("JSON is commonly used in APIs, configuration files, and web applications.");

            Console.WriteLine("\nTASK 2:");
            Console.WriteLine("JSON strings store text values.");
            Console.WriteLine("JSON numbers store numeric values.");
            Console.WriteLine("JSON booleans store true or false.");
            Console.WriteLine("JSON null represents missing or empty data.");
            Console.WriteLine("JSON objects store key/value pairs.");
            Console.WriteLine("JSON arrays store multiple values.");

            Console.WriteLine("\nTASK 3:");
            Console.WriteLine("{");
            Console.WriteLine("  \"Name\": \"Peyman\",");
            Console.WriteLine("  \"Age\": 25,");
            Console.WriteLine("  \"Country\": \"Mexico\"");
            Console.WriteLine("}");

            Console.WriteLine("\nTASK 4:");
            string[] items =
            {
                "Sword",
                "Shield",
                "Potion",
                "Helmet",
                "Armor"
            };

            string itemsJson = JsonSerializer.Serialize(items);
            Console.WriteLine(itemsJson);

            Console.WriteLine("\nTASK 5:");
            Person person = new Person
            {
                Name = "Peyman",
                Age = 25,
                Country = "Mexico"
            };

            string personJson = JsonSerializer.Serialize(person);
            Console.WriteLine(personJson);

            Console.WriteLine("\nTASK 6:");
            string jsonText =
                "{\"Name\":\"Nova\",\"Age\":30,\"Country\":\"Mexico\"}";

            Person deserializedPerson =
                JsonSerializer.Deserialize<Person>(jsonText);

            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine($"Country: {deserializedPerson.Country}");

            Console.WriteLine("\nTASK 7:");
            JsonSerializerOptions options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string formattedJson =
                JsonSerializer.Serialize(person, options);

            Console.WriteLine(formattedJson);

            Console.WriteLine("\nTASK 8:");
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

            string playerJson =
                JsonSerializer.Serialize(player, options);

            Console.WriteLine(playerJson);

            Console.WriteLine("\nTASK 9:");
            List<Person> people = new List<Person>
            {
                new Person
                {
                    Name = "Peyman",
                    Age = 25,
                    Country = "Mexico"
                },
                new Person
                {
                    Name = "Nova",
                    Age = 30,
                    Country = "Mexico"
                },
                new Person
                {
                    Name = "Aria",
                    Age = 20,
                    Country = "Mexico"
                }
            };

            string peopleJson =
                JsonSerializer.Serialize(people, options);

            Console.WriteLine(peopleJson);

            Console.WriteLine("\nTASK 10:");
            Console.WriteLine("Serialization means converting a C# object into JSON text.");
            Console.WriteLine("Deserialization means converting JSON text into a C# object.");
            Console.WriteLine("Both are important because applications need to send, receive, save, and load data.");

            Console.WriteLine("\nTASK 11:");
            Console.WriteLine("APIs commonly use JSON to send and receive data.");
            Console.WriteLine("C# receives JSON as text from an API response.");
            Console.WriteLine("C# can deserialize JSON into objects using System.Text.Json.");

            Console.WriteLine("\nTASK 12:");
            Console.WriteLine("JSON Best Practices:");
            Console.WriteLine("1. Validate JSON before using it.");
            Console.WriteLine("2. Handle exceptions when parsing JSON.");
            Console.WriteLine("3. Use readable formatting when debugging.");
            Console.WriteLine("4. Match JSON structure with C# classes.");
            Console.WriteLine("5. Use clear property names.");
            Console.WriteLine("6. Avoid unnecessary complex JSON structures.");
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
