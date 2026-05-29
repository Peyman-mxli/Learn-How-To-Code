```csharp
using System;
using System.Threading.Tasks;

namespace AsyncAwaitTaskSolutions
{
    class Program
    {
        static async Task SayHelloAsync()
        {
            Console.WriteLine("Hello");
            await Task.Delay(2000);
            Console.WriteLine("Goodbye");
        }

        static async Task CountdownAsync()
        {
            Console.WriteLine("3");
            await Task.Delay(1000);

            Console.WriteLine("2");
            await Task.Delay(1000);

            Console.WriteLine("1");
            await Task.Delay(1000);

            Console.WriteLine("Go!");
        }

        static async Task LoadTexturesAsync()
        {
            Console.WriteLine("Loading textures...");
            await Task.Delay(2000);
            Console.WriteLine("Textures loaded.");
        }

        static async Task LoadSoundsAsync()
        {
            Console.WriteLine("Loading sounds...");
            await Task.Delay(1500);
            Console.WriteLine("Sounds loaded.");
        }

        static async Task<int> GetPlayerLevelAsync()
        {
            await Task.Delay(2000);
            return 25;
        }

        static async Task<string> GetPlayerNameAsync()
        {
            await Task.Delay(1000);
            return "Peyman";
        }

        static async Task LoadUserDataAsync()
        {
            Console.WriteLine("Loading user...");
            await Task.Delay(2000);
            Console.WriteLine("User loaded.");
        }

        static async Task DownloadFileAsync()
        {
            Console.WriteLine("Download started.");
            await Task.Delay(3000);
            Console.WriteLine("Download complete.");
        }

        static async Task LoadDatabaseAsync()
        {
            Console.WriteLine("Connecting to database...");
            await Task.Delay(2000);
            Console.WriteLine("Database loaded.");
        }

        static async Task LoadNPCsAsync()
        {
            Console.WriteLine("Loading NPCs...");
            await Task.Delay(1800);
            Console.WriteLine("NPCs loaded.");
        }

        static async Task LoadMapsAsync()
        {
            Console.WriteLine("Loading maps...");
            await Task.Delay(2500);
            Console.WriteLine("Maps loaded.");
        }

        static async Task ThrowAsyncError()
        {
            await Task.Delay(1000);
            throw new Exception("Something went wrong during the async operation.");
        }

        static async Task<string> LoadPlayerDataAsync()
        {
            Console.WriteLine("Loading player data...");
            await Task.Delay(1000);
            return "Player data loaded";
        }

        static async Task<string> LoadInventoryAsync()
        {
            Console.WriteLine("Loading inventory...");
            await Task.Delay(1200);
            return "Inventory loaded";
        }

        static async Task<string> LoadQuestsAsync()
        {
            Console.WriteLine("Loading quests...");
            await Task.Delay(1300);
            return "Quests loaded";
        }

        static async Task<string> LoadSkillsAsync()
        {
            Console.WriteLine("Loading skills...");
            await Task.Delay(1100);
            return "Skills loaded";
        }

        static async Task<string> LoadProductsAsync()
        {
            await Task.Delay(1000);
            return "Products loaded";
        }

        static async Task<string> LoadCategoriesAsync()
        {
            await Task.Delay(900);
            return "Categories loaded";
        }

        static async Task<string> LoadCustomerDataAsync()
        {
            await Task.Delay(1200);
            return "Customer data loaded";
        }

        static async Task<string> LoadOrdersAsync()
        {
            await Task.Delay(1500);
            return "Orders loaded";
        }

        static async Task<string> LoadConfigurationAsync()
        {
            await Task.Delay(1000);
            return "Configuration files loaded";
        }

        static async Task<string> ConnectDatabaseAsync()
        {
            await Task.Delay(1300);
            return "Database connected";
        }

        static async Task<string> LoadUserSettingsAsync()
        {
            await Task.Delay(800);
            return "User settings loaded";
        }

        static async Task<string> LoadPermissionsAsync()
        {
            await Task.Delay(900);
            return "Permissions loaded";
        }

        static async Task<string> LoadModulesAsync()
        {
            await Task.Delay(1400);
            return "Modules loaded";
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 1: CREATE YOUR FIRST ASYNC METHOD");
            Console.WriteLine("=========================================");

            await SayHelloAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 2: USE TASK.DELAY");
            Console.WriteLine("=========================================");

            await CountdownAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 3: CREATE MULTIPLE ASYNC METHODS");
            Console.WriteLine("=========================================");

            await LoadTexturesAsync();
            await LoadSoundsAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 4: RETURN A VALUE USING TASK<T>");
            Console.WriteLine("=========================================");

            int playerLevel = await GetPlayerLevelAsync();

            Console.WriteLine($"Player Level: {playerLevel}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 5: RETURN A STRING");
            Console.WriteLine("=========================================");

            string playerName = await GetPlayerNameAsync();

            Console.WriteLine($"Player Name: {playerName}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 6: LOAD USER DATA");
            Console.WriteLine("=========================================");

            await LoadUserDataAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 7: FILE DOWNLOAD SIMULATION");
            Console.WriteLine("=========================================");

            await DownloadFileAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 8: DATABASE QUERY SIMULATION");
            Console.WriteLine("=========================================");

            await LoadDatabaseAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 9: MULTIPLE AWAITS");
            Console.WriteLine("=========================================");

            await LoadTexturesAsync();
            await LoadSoundsAsync();
            await LoadNPCsAsync();

            Console.WriteLine("Game Loaded");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 10: HANDLE ASYNC EXCEPTIONS");
            Console.WriteLine("=========================================");

            try
            {
                await ThrowAsyncError();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Caught: {ex.Message}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 11: USE TASK.WHENALL");
            Console.WriteLine("=========================================");

            await Task.WhenAll(
                LoadTexturesAsync(),
                LoadSoundsAsync(),
                LoadMapsAsync());

            Console.WriteLine("All resources loaded");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 12: USE TASK.WHENANY");
            Console.WriteLine("=========================================");

            Task textureTask = LoadTexturesAsync();
            Task soundTask = LoadSoundsAsync();
            Task mapTask = LoadMapsAsync();

            Task firstCompletedTask = await Task.WhenAny(
                textureTask,
                soundTask,
                mapTask);

            Console.WriteLine("One task finished first.");

            await Task.WhenAll(textureTask, soundTask, mapTask);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 13: GAME LOADING SYSTEM");
            Console.WriteLine("=========================================");

            string playerData = await LoadPlayerDataAsync();
            string inventory = await LoadInventoryAsync();
            string quests = await LoadQuestsAsync();
            string skills = await LoadSkillsAsync();

            Console.WriteLine(playerData);
            Console.WriteLine(inventory);
            Console.WriteLine(quests);
            Console.WriteLine(skills);
            Console.WriteLine("Character Ready");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 14: ONLINE STORE LOADING SYSTEM");
            Console.WriteLine("=========================================");

            string[] storeResults = await Task.WhenAll(
                LoadProductsAsync(),
                LoadCategoriesAsync(),
                LoadCustomerDataAsync(),
                LoadOrdersAsync());

            foreach (string result in storeResults)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Store loading complete.");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 15: COMPLETE APPLICATION STARTUP");
            Console.WriteLine("=========================================");

            try
            {
                string[] startupResults = await Task.WhenAll(
                    LoadConfigurationAsync(),
                    ConnectDatabaseAsync(),
                    LoadUserSettingsAsync(),
                    LoadPermissionsAsync(),
                    LoadModulesAsync());

                Console.WriteLine("Startup Summary:");

                foreach (string result in startupResults)
                {
                    Console.WriteLine($"- {result}");
                }

                Console.WriteLine("Application started successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Startup failed: {ex.Message}");
            }

            Console.WriteLine();

            Console.WriteLine("Async Await Task Solutions Completed!");
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
