using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DeserializationExamples
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
            Console.WriteLine("EXAMPLE 1 - BASIC DESERIALIZATION");
            Console.WriteLine("====================================");

            string jsonPerson =
                "{\"Name\":\"Peyman\",\"Age\":25,\"City\":\"Mexicali\"}";

            Person person =
                JsonSerializer.Deserialize<Person>(jsonPerson);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"City: {person.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 2 - MULTI-LINE JSON");
            Console.WriteLine("====================================");

            string formattedJson =
            """
            {
                "Name": "Nova",
                "Age": 30,
                "City": "Tijuana"
            }
            """;

            Person person2 =
                JsonSerializer.Deserialize<Person>(formattedJson);

            Console.WriteLine($"Name: {person2.Name}");
            Console.WriteLine($"Age: {person2.Age}");
            Console.WriteLine($"City: {person2.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 3 - DESERIALIZE LIST");
            Console.WriteLine("====================================");

            string peopleJson =
            """
            [
                {
                    "Name":"Ali",
                    "Age":20,
                    "City":"Tehran"
                },
                {
                    "Name":"Sara",
                    "Age":22,
                    "City":"Shiraz"
                },
                {
                    "Name":"Aria",
                    "Age":24,
                    "City":"Tabriz"
                }
            ]
            """;

            List<Person> people =
                JsonSerializer.Deserialize<List<Person>>(peopleJson);

            foreach (Person item in people)
            {
                Console.WriteLine(
                    $"{item.Name} - {item.Age} - {item.City}");
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 4 - DESERIALIZE ARRAY");
            Console.WriteLine("====================================");

            Person[] peopleArray =
                JsonSerializer.Deserialize<Person[]>(peopleJson);

            foreach (Person item in peopleArray)
            {
                Console.WriteLine(
                    $"{item.Name} - {item.Age} - {item.City}");
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 5 - MISSING PROPERTY");
            Console.WriteLine("====================================");

            string missingPropertyJson =
            """
            {
                "Name":"Peyman"
            }
            """;

            Person person3 =
                JsonSerializer.Deserialize<Person>(
                    missingPropertyJson);

            Console.WriteLine($"Name: {person3.Name}");
            Console.WriteLine($"Age: {person3.Age}");
            Console.WriteLine($"City: {person3.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 6 - EXTRA PROPERTY");
            Console.WriteLine("====================================");

            string extraPropertyJson =
            """
            {
                "Name":"Peyman",
                "Age":25,
                "City":"Mexicali",
                "Country":"Mexico"
            }
            """;

            Person person4 =
                JsonSerializer.Deserialize<Person>(
                    extraPropertyJson);

            Console.WriteLine($"Name: {person4.Name}");
            Console.WriteLine($"Age: {person4.Age}");
            Console.WriteLine($"City: {person4.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 7 - SAVE FILE");
            Console.WriteLine("====================================");

            File.WriteAllText(
                "person.json",
                formattedJson);

            Console.WriteLine("person.json created.");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 8 - READ FILE");
            Console.WriteLine("====================================");

            string fileContent =
                File.ReadAllText("person.json");

            Console.WriteLine(fileContent);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 9 - DESERIALIZE FILE");
            Console.WriteLine("====================================");

            Person filePerson =
                JsonSerializer.Deserialize<Person>(
                    fileContent);

            Console.WriteLine($"Name: {filePerson.Name}");
            Console.WriteLine($"Age: {filePerson.Age}");
            Console.WriteLine($"City: {filePerson.City}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 10 - TRY/CATCH");
            Console.WriteLine("====================================");

            string badJson =
                "{ Name : Peyman }";

            try
            {
                Person badPerson =
                    JsonSerializer.Deserialize<Person>(badJson);

                Console.WriteLine(badPerson.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 11 - NULL VALUES");
            Console.WriteLine("====================================");

            string nullJson =
            """
            {
                "Name": null,
                "Age": 25,
                "City": "Mexicali"
            }
            """;

            Person nullPerson =
                JsonSerializer.Deserialize<Person>(nullJson);

            Console.WriteLine($"Name: {nullPerson.Name}");
            Console.WriteLine($"Age: {nullPerson.Age}");
            Console.WriteLine($"City: {nullPerson.City}");

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
