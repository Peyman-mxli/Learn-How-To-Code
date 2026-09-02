using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationExamples
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 1 - CREATE AN OBJECT");
            Console.WriteLine("====================================");

            Person person = new Person
            {
                Name = "Peyman",
                Age = 25,
                City = "Mexicali"
            };

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"City: {person.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 2 - SERIALIZE OBJECT");
            Console.WriteLine("====================================");

            string json =
                JsonSerializer.Serialize(person);

            Console.WriteLine(json);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 3 - PRETTY PRINT JSON");
            Console.WriteLine("====================================");

            JsonSerializerOptions options =
                new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string formattedJson =
                JsonSerializer.Serialize(person, options);

            Console.WriteLine(formattedJson);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 4 - DESERIALIZE OBJECT");
            Console.WriteLine("====================================");

            Person restoredPerson =
                JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine($"Name: {restoredPerson.Name}");
            Console.WriteLine($"Age: {restoredPerson.Age}");
            Console.WriteLine($"City: {restoredPerson.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 5 - SERIALIZE A LIST");
            Console.WriteLine("====================================");

            List<Person> people = new List<Person>
            {
                new Person
                {
                    Name = "Peyman",
                    Age = 25,
                    City = "Mexicali"
                },

                new Person
                {
                    Name = "Nova",
                    Age = 30,
                    City = "Tijuana"
                },

                new Person
                {
                    Name = "Aria",
                    Age = 22,
                    City = "Ensenada"
                }
            };

            string peopleJson =
                JsonSerializer.Serialize(
                    people,
                    options);

            Console.WriteLine(peopleJson);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 6 - DESERIALIZE A LIST");
            Console.WriteLine("====================================");

            List<Person> restoredPeople =
                JsonSerializer.Deserialize<List<Person>>(peopleJson);

            foreach (Person p in restoredPeople)
            {
                Console.WriteLine(
                    $"{p.Name} - {p.Age} - {p.City}");
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 7 - SAVE JSON TO FILE");
            Console.WriteLine("====================================");

            File.WriteAllText(
                "person.json",
                formattedJson);

            Console.WriteLine(
                "person.json file created successfully.");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 8 - READ JSON FROM FILE");
            Console.WriteLine("====================================");

            string fileContent =
                File.ReadAllText("person.json");

            Console.WriteLine(fileContent);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 9 - RESTORE OBJECT FROM FILE");
            Console.WriteLine("====================================");

            Person filePerson =
                JsonSerializer.Deserialize<Person>(fileContent);

            Console.WriteLine($"Name: {filePerson.Name}");
            Console.WriteLine($"Age: {filePerson.Age}");
            Console.WriteLine($"City: {filePerson.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 10 - SERIALIZE ARRAY");
            Console.WriteLine("====================================");

            Person[] personArray =
            {
                new Person
                {
                    Name = "Ali",
                    Age = 28,
                    City = "Tehran"
                },

                new Person
                {
                    Name = "Sara",
                    Age = 24,
                    City = "Shiraz"
                }
            };

            string arrayJson =
                JsonSerializer.Serialize(
                    personArray,
                    options);

            Console.WriteLine(arrayJson);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 11 - DESERIALIZE ARRAY");
            Console.WriteLine("====================================");

            Person[] restoredArray =
                JsonSerializer.Deserialize<Person[]>(arrayJson);

            foreach (Person p in restoredArray)
            {
                Console.WriteLine(
                    $"{p.Name} - {p.Age} - {p.City}");
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 12 - COMPLETE");
            Console.WriteLine("====================================");
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
