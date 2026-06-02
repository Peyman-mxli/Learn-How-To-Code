using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationTasksSolutions
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
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            Console.WriteLine("TASK 1 - CREATE A CLASS");

            Student student = new Student
            {
                Name = "Peyman",
                Age = 25,
                Major = "Information Technology"
            };

            Console.WriteLine($"{student.Name} - {student.Age} - {student.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 2 - SERIALIZE AN OBJECT");

            string studentJson = JsonSerializer.Serialize(student);

            Console.WriteLine(studentJson);
            Console.WriteLine();

            Console.WriteLine("TASK 3 - PRETTY PRINT JSON");

            string formattedStudentJson = JsonSerializer.Serialize(student, options);

            Console.WriteLine(formattedStudentJson);
            Console.WriteLine();

            Console.WriteLine("TASK 4 - DESERIALIZE JSON");

            string manualJson =
                "{\"Name\":\"Nova\",\"Age\":22,\"Major\":\"Computer Science\"}";

            Student manualStudent =
                JsonSerializer.Deserialize<Student>(manualJson);

            Console.WriteLine($"{manualStudent.Name} - {manualStudent.Age} - {manualStudent.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 5 - CREATE A PRODUCT CLASS");

            Product product = new Product
            {
                Name = "Laptop",
                Price = 1500.99m,
                Category = "Electronics"
            };

            string productJson = JsonSerializer.Serialize(product, options);

            Console.WriteLine(productJson);
            Console.WriteLine();

            Console.WriteLine("TASK 6 - SERIALIZE MULTIPLE OBJECTS");

            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name = "Ali",
                    Age = 20,
                    Major = "Engineering"
                },

                new Student
                {
                    Name = "Sara",
                    Age = 21,
                    Major = "Design"
                },

                new Student
                {
                    Name = "Aria",
                    Age = 22,
                    Major = "Cybersecurity"
                }
            };

            string studentsJson = JsonSerializer.Serialize(students, options);

            Console.WriteLine(studentsJson);
            Console.WriteLine();

            Console.WriteLine("TASK 7 - DESERIALIZE A LIST");

            List<Student> restoredStudents =
                JsonSerializer.Deserialize<List<Student>>(studentsJson);

            foreach (Student item in restoredStudents)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 8 - SAVE JSON TO FILE");

            File.WriteAllText("student.json", formattedStudentJson);

            Console.WriteLine("student.json saved successfully.");
            Console.WriteLine();

            Console.WriteLine("TASK 9 - READ JSON FROM FILE");

            string fileContent = File.ReadAllText("student.json");

            Console.WriteLine(fileContent);
            Console.WriteLine();

            Console.WriteLine("TASK 10 - RESTORE OBJECT FROM FILE");

            Student restoredStudentFromFile =
                JsonSerializer.Deserialize<Student>(fileContent);

            Console.WriteLine($"{restoredStudentFromFile.Name} - {restoredStudentFromFile.Age} - {restoredStudentFromFile.Major}");
            Console.WriteLine();

            Console.WriteLine("TASK 11 - SERIALIZE AN ARRAY");

            Student[] studentArray =
            {
                new Student
                {
                    Name = "Mina",
                    Age = 19,
                    Major = "Mathematics"
                },

                new Student
                {
                    Name = "Reza",
                    Age = 23,
                    Major = "Software"
                }
            };

            string arrayJson = JsonSerializer.Serialize(studentArray, options);

            Console.WriteLine(arrayJson);
            Console.WriteLine();

            Console.WriteLine("TASK 12 - DESERIALIZE AN ARRAY");

            Student[] restoredArray =
                JsonSerializer.Deserialize<Student[]>(arrayJson);

            foreach (Student item in restoredArray)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 13 - CREATE A SETTINGS CLASS");

            Settings settings = new Settings
            {
                Theme = "Dark",
                Language = "English",
                FontSize = 16
            };

            string settingsJson = JsonSerializer.Serialize(settings, options);

            Console.WriteLine(settingsJson);
            Console.WriteLine();

            Console.WriteLine("TASK 14 - APPLICATION SETTINGS FILE");

            File.WriteAllText("settings.json", settingsJson);

            Console.WriteLine("settings.json saved successfully.");
            Console.WriteLine();

            Console.WriteLine("TASK 15 - LOAD SETTINGS FILE");

            string settingsFileContent = File.ReadAllText("settings.json");

            Settings loadedSettings =
                JsonSerializer.Deserialize<Settings>(settingsFileContent);

            Console.WriteLine($"Theme: {loadedSettings.Theme}");
            Console.WriteLine($"Language: {loadedSettings.Language}");
            Console.WriteLine($"Font Size: {loadedSettings.FontSize}");
            Console.WriteLine();

            Console.WriteLine("TASK 16 - CREATE A GAME SAVE FILE");

            Player player = new Player
            {
                Name = "Nova Pahlavan",
                Level = 15,
                Health = 250
            };

            string playerJson = JsonSerializer.Serialize(player, options);

            File.WriteAllText("savegame.json", playerJson);

            Console.WriteLine("savegame.json saved successfully.");
            Console.WriteLine();

            Console.WriteLine("TASK 17 - LOAD GAME SAVE FILE");

            string saveGameContent = File.ReadAllText("savegame.json");

            Player loadedPlayer =
                JsonSerializer.Deserialize<Player>(saveGameContent);

            Console.WriteLine($"Player: {loadedPlayer.Name}");
            Console.WriteLine($"Level: {loadedPlayer.Level}");
            Console.WriteLine($"Health: {loadedPlayer.Health}");
            Console.WriteLine();

            Console.WriteLine("TASK 18 - JSON VS OBJECT");

            Console.WriteLine("Serialization means Object to JSON.");
            Console.WriteLine("Deserialization means JSON to Object.");
            Console.WriteLine();

            Console.WriteLine("TASK 19 - SERIALIZATION BENEFITS");

            Console.WriteLine("Serialization helps save data.");
            Console.WriteLine("Serialization helps load data.");
            Console.WriteLine("Serialization helps send data through APIs.");
            Console.WriteLine("Serialization helps create configuration files.");
            Console.WriteLine("Serialization helps restore application state.");
            Console.WriteLine();

            Console.WriteLine("TASK 20 - MINI PROJECT");

            List<Student> managementStudents = new List<Student>
            {
                new Student
                {
                    Name = "Peyman",
                    Age = 25,
                    Major = "IT Engineering"
                },

                new Student
                {
                    Name = "Nova",
                    Age = 24,
                    Major = "Software Development"
                }
            };

            string managementJson =
                JsonSerializer.Serialize(managementStudents, options);

            File.WriteAllText("students.json", managementJson);

            string loadedManagementJson =
                File.ReadAllText("students.json");

            List<Student> loadedManagementStudents =
                JsonSerializer.Deserialize<List<Student>>(loadedManagementJson);

            foreach (Student item in loadedManagementStudents)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Major}");
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
