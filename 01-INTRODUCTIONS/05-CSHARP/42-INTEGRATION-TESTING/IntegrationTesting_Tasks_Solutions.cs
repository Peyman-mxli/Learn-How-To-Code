using System;
using System.Collections.Generic;
using System.IO;

namespace IntegrationTestingTasksSolutions
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserRepository
    {
        private readonly List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUser(string username)
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            return null;
        }
    }

    public class UserService
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository repository)
        {
            userRepository = repository;
        }

        public bool RegisterUser(string username, string password)
        {
            User existingUser = userRepository.GetUser(username);

            if (existingUser != null)
            {
                return false;
            }

            User user = new User
            {
                Username = username,
                Password = password
            };

            userRepository.AddUser(user);

            return true;
        }

        public bool Login(string username, string password)
        {
            User user = userRepository.GetUser(username);

            if (user == null)
            {
                return false;
            }

            return user.Password == password;
        }
    }

    public class SettingsService
    {
        public void SaveSettings(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }

        public string LoadSettings(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }

    class Program
    {
        static void Main()
        {
            UserRepository repository = new UserRepository();
            UserService userService = new UserService(repository);
            SettingsService settingsService = new SettingsService();

            Console.WriteLine("TASK 1 - EXPLAIN INTEGRATION TESTING");
            Console.WriteLine("Integration testing checks how multiple parts of a program work together.");
            Console.WriteLine();

            Console.WriteLine("TASK 2 - CREATE USER CLASS");
            Console.WriteLine("User class created.");
            Console.WriteLine();

            Console.WriteLine("TASK 3 - CREATE USER REPOSITORY");
            Console.WriteLine("UserRepository class created.");
            Console.WriteLine();

            Console.WriteLine("TASK 4 - CREATE USER SERVICE");
            Console.WriteLine("UserService class connected to UserRepository.");
            Console.WriteLine();

            Console.WriteLine("TASK 5 - TEST REGISTER USER");
            PrintTestResult(userService.RegisterUser("Peyman", "Password123"));
            Console.WriteLine();

            Console.WriteLine("TASK 6 - TEST LOGIN SUCCESS");
            PrintTestResult(userService.Login("Peyman", "Password123"));
            Console.WriteLine();

            Console.WriteLine("TASK 7 - TEST LOGIN FAILURE");
            PrintTestResult(userService.Login("Peyman", "WrongPassword") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 8 - TEST DUPLICATE USER");
            PrintTestResult(userService.RegisterUser("Peyman", "AnotherPassword") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 9 - TEST REPOSITORY CONNECTION");
            PrintTestResult(repository.GetUser("Peyman") != null);
            Console.WriteLine();

            Console.WriteLine("TASK 10 - CREATE SETTINGS SERVICE");
            Console.WriteLine("SettingsService class created.");
            Console.WriteLine();

            Console.WriteLine("TASK 11 - TEST FILE SAVE");
            settingsService.SaveSettings("settings.txt", "Theme=Dark");
            PrintTestResult(File.Exists("settings.txt"));
            Console.WriteLine();

            Console.WriteLine("TASK 12 - TEST FILE LOAD");
            string loadedSettings = settingsService.LoadSettings("settings.txt");
            PrintTestResult(loadedSettings == "Theme=Dark");
            Console.WriteLine();

            Console.WriteLine("TASK 13 - TEST COMPLETE USER WORKFLOW");
            bool workflowResult =
                userService.RegisterUser("Nova", "Nova123")
                &&
                userService.Login("Nova", "Nova123")
                &&
                repository.GetUser("Nova") != null;

            PrintTestResult(workflowResult);
            Console.WriteLine();

            Console.WriteLine("TASK 14 - TEST USER NOT FOUND");
            PrintTestResult(userService.Login("Ghost", "123") == false);
            Console.WriteLine();

            Console.WriteLine("TASK 15 - TEST FILE CONTENT");
            settingsService.SaveSettings("content.txt", "Integration Test Content");
            string loadedContent = settingsService.LoadSettings("content.txt");
            PrintTestResult(loadedContent == "Integration Test Content");
            Console.WriteLine();

            Console.WriteLine("TASK 16 - ARRANGE ACT ASSERT");
            Console.WriteLine("Arrange means prepare connected components.");
            Console.WriteLine("Act means run the workflow.");
            Console.WriteLine("Assert means verify the final result.");
            Console.WriteLine();

            Console.WriteLine("TASK 17 - UNIT VS INTEGRATION");
            Console.WriteLine("Unit testing checks one small part.");
            Console.WriteLine("Integration testing checks multiple parts working together.");
            Console.WriteLine();

            Console.WriteLine("TASK 18 - REAL-WORLD INTEGRATION TESTING");
            Console.WriteLine("Integration testing is useful for login systems.");
            Console.WriteLine("Integration testing is useful for save systems.");
            Console.WriteLine("Integration testing is useful for inventory systems.");
            Console.WriteLine();

            Console.WriteLine("TASK 19 - CLEANUP TEST FILES");

            if (File.Exists("settings.txt"))
            {
                File.Delete("settings.txt");
            }

            if (File.Exists("content.txt"))
            {
                File.Delete("content.txt");
            }

            Console.WriteLine("Test files cleaned up.");
            Console.WriteLine();

            Console.WriteLine("TASK 20 - MINI PROJECT");
            Console.WriteLine("Integrated login and settings system completed.");
        }

        static void PrintTestResult(bool condition)
        {
            if (condition)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
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
