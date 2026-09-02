using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DeserializationTasksSolutions
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class Settings
    {
        public string Theme { get; set; }
        public string Language { get; set; }
        public int FontSize { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("TASK 1 - CREATE A CLASS");

            string studentJson =
                "{\"Name\":\"Peyman\",\"Age\":25,\"Major\":\"Information Technology\"}";

            Student student =
                JsonSerializer.Deserialize<Student>(studentJson);

            Console.WriteLine($"{student.Name} - {student.Age} - {student.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 2 - DISPLAY OBJECT VALUES");

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Major: {student.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 3 - MULTI-LINE JSON");

            string multiLineJson =
            """
            {
                "Name": "Nova",
                "Age": 22,
                "Major": "Computer Science"
            }
            """;

            Student multiLineStudent =
                JsonSerializer.Deserialize<Student>(multiLineJson);

            Console.WriteLine($"{multiLineStudent.Name} - {multiLineStudent.Age} - {multiLineStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 4 - CREATE A PRODUCT CLASS");

            string productJson =
            """
            {
                "Name": "Laptop",
                "Price": 1500.99,
                "Category": "Electronics"
            }
            """;

            Product product =
                JsonSerializer.Deserialize<Product>(productJson);

            Console.WriteLine($"{product.Name} - {product.Price} - {product.Category}");
            Console.WriteLine();

            Console.WriteLine("TASK 5 - DESERIALIZE MULTIPLE STUDENTS");

            string studentsJson =
            """
            [
                {
                    "Name": "Ali",
                    "Age": 20,
                    "Major": "Engineering"
                },
                {
                    "Name": "Sara",
                    "Age": 21,
                    "Major": "Design"
                },
                {
                    "Name": "Aria",
                    "Age": 22,
                    "Major": "Cybersecurity"
                }
            ]
            """;

            List<Student> students =
                JsonSerializer.Deserialize<List<Student>>(studentsJson);

            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 6 - DESERIALIZE ARRAY");

            Student[] studentArray =
                JsonSerializer.Deserialize<Student[]>(studentsJson);

            foreach (Student item in studentArray)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 7 - SAVE JSON FILE");

            File.WriteAllText("student.json", studentJson);

            Console.WriteLine("student.json saved successfully.");
            Console.WriteLine();

            Console.WriteLine("TASK 8 - READ JSON FILE");

            string fileContent =
                File.ReadAllText("student.json");

            Console.WriteLine(fileContent);
            Console.WriteLine();

            Console.WriteLine("TASK 9 - DESERIALIZE FILE CONTENT");

            Student fileStudent =
                JsonSerializer.Deserialize<Student>(fileContent);

            Console.WriteLine($"{fileStudent.Name} - {fileStudent.Age} - {fileStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 10 - MISSING PROPERTY");

            string missingPropertyJson =
            """
            {
                "Name": "Peyman"
            }
            """;

            Student missingStudent =
                JsonSerializer.Deserialize<Student>(missingPropertyJson);

            Console.WriteLine($"Name: {missingStudent.Name}");
            Console.WriteLine($"Age: {missingStudent.Age}");
            Console.WriteLine($"Major: {missingStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 11 - EXTRA PROPERTY");

            string extraPropertyJson =
            """
            {
                "Name": "Peyman",
                "Age": 25,
                "Major": "IT",
                "Country": "Mexico"
            }
            """;

            Student extraStudent =
                JsonSerializer.Deserialize<Student>(extraPropertyJson);

            Console.WriteLine($"Name: {extraStudent.Name}");
            Console.WriteLine($"Age: {extraStudent.Age}");
            Console.WriteLine($"Major: {extraStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 12 - NULL VALUES");

            string nullJson =
            """
            {
                "Name": null,
                "Age": 25,
                "Major": "Software"
            }
            """;

            Student nullStudent =
                JsonSerializer.Deserialize<Student>(nullJson);

            Console.WriteLine($"Name: {nullStudent.Name}");
            Console.WriteLine($"Age: {nullStudent.Age}");
            Console.WriteLine($"Major: {nullStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 13 - INVALID JSON");

            string invalidJson =
                "{ Name : Peyman }";

            try
            {
                Student invalidStudent =
                    JsonSerializer.Deserialize<Student>(invalidJson);

                Console.WriteLine(invalidStudent.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid JSON error:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 14 - CREATE SETTINGS CLASS");

            string settingsJson =
            """
            {
                "Theme": "Dark",
                "Language": "English",
                "FontSize": 16
            }
            """;

            Settings settings =
                JsonSerializer.Deserialize<Settings>(settingsJson);

            Console.WriteLine($"Theme: {settings.Theme}");
            Console.WriteLine($"Language: {settings.Language}");
            Console.WriteLine($"Font Size: {settings.FontSize}");
            Console.WriteLine();

            Console.WriteLine("TASK 15 - LOAD SETTINGS FILE");

            File.WriteAllText("settings.json", settingsJson);

            string settingsFileContent =
                File.ReadAllText("settings.json");

            Settings loadedSettings =
                JsonSerializer.Deserialize<Settings>(settingsFileContent);

            Console.WriteLine($"Theme: {loadedSettings.Theme}");
            Console.WriteLine($"Language: {loadedSettings.Language}");
            Console.WriteLine($"Font Size: {loadedSettings.FontSize}");
            Console.WriteLine();

            Console.WriteLine("TASK 16 - CREATE PLAYER CLASS");

            string playerJson =
            """
            {
                "Name": "Nova Pahlavan",
                "Level": 15,
                "Health": 250
            }
            """;

            Player player =
                JsonSerializer.Deserialize<Player>(playerJson);

            Console.WriteLine($"Player: {player.Name}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine();

            Console.WriteLine("TASK 17 - LOAD SAVE GAME");

            File.WriteAllText("savegame.json", playerJson);

            string saveGameContent =
                File.ReadAllText("savegame.json");

            Player loadedPlayer =
                JsonSerializer.Deserialize<Player>(saveGameContent);

            Console.WriteLine($"Player: {loadedPlayer.Name}");
            Console.WriteLine($"Level: {loadedPlayer.Level}");
            Console.WriteLine($"Health: {loadedPlayer.Health}");
            Console.WriteLine();

            Console.WriteLine("TASK 18 - JSON TO OBJECT");

            Console.WriteLine("Deserialization means converting JSON data back into a usable C# object.");
            Console.WriteLine();

            Console.WriteLine("TASK 19 - BENEFITS OF DESERIALIZATION");

            Console.WriteLine("Deserialization helps load saved files.");
            Console.WriteLine("Deserialization helps read API responses.");
            Console.WriteLine("Deserialization helps restore game data.");
            Console.WriteLine("Deserialization helps load settings.");
            Console.WriteLine("Deserialization helps rebuild objects from stored data.");
            Console.WriteLine();

            Console.WriteLine("TASK 20 - MINI PROJECT");

            try
            {
                File.WriteAllText("students.json", studentsJson);

                string loadedStudentsJson =
                    File.ReadAllText("students.json");

                List<Student> loadedStudents =
                    JsonSerializer.Deserialize<List<Student>>(loadedStudentsJson);

                foreach (Student item in loadedStudents)
                {
                    Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Student Management Loader error:");
                Console.WriteLine(ex.Message);
            }
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
