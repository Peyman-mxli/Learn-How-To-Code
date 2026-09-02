```csharp
using System;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static async Task DisplayLoadingMessageAsync()
        {
            Console.WriteLine("Loading data...");

            await Task.Delay(2000);

            Console.WriteLine("Data loaded successfully.");
        }

        static async Task<int> GetPlayerLevelAsync()
        {
            await Task.Delay(1500);

            return 25;
        }

        static async Task<string> GetPlayerNameAsync()
        {
            await Task.Delay(1000);

            return "Peyman";
        }

        static async Task DownloadFileAsync()
        {
            Console.WriteLine("Downloading file...");

            await Task.Delay(3000);

            Console.WriteLine("File downloaded.");
        }

        static async Task LoadDatabaseAsync()
        {
            Console.WriteLine("Loading database...");

            await Task.Delay(2500);

            Console.WriteLine("Database loaded.");
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

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(1000);

            throw new Exception("Simulated async error.");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("BASIC ASYNC METHOD");
            Console.WriteLine("=========================================");

            await DisplayLoadingMessageAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK<T> RETURN VALUE");
            Console.WriteLine("=========================================");

            int playerLevel =
                await GetPlayerLevelAsync();

            Console.WriteLine($"Player Level: {playerLevel}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK<T> STRING RETURN");
            Console.WriteLine("=========================================");

            string playerName =
                await GetPlayerNameAsync();

            Console.WriteLine($"Player Name: {playerName}");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ASYNC FILE DOWNLOAD");
            Console.WriteLine("=========================================");

            await DownloadFileAsync();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("MULTIPLE TASKS");
            Console.WriteLine("=========================================");

            Task databaseTask =
                LoadDatabaseAsync();

            Task fileTask =
                DownloadFileAsync();

            await databaseTask;
            await fileTask;

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK.WHENALL");
            Console.WriteLine("=========================================");

            await Task.WhenAll(
                LoadTexturesAsync(),
                LoadSoundsAsync());

            Console.WriteLine("All resources loaded.");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK.WHENANY");
            Console.WriteLine("=========================================");

            Task textureTask =
                LoadTexturesAsync();

            Task soundTask =
                LoadSoundsAsync();

            Task completedTask =
                await Task.WhenAny(
                    textureTask,
                    soundTask);

            Console.WriteLine(
                "First task completed.");

            await textureTask;
            await soundTask;

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ASYNC EXCEPTION HANDLING");
            Console.WriteLine("=========================================");

            try
            {
                await ThrowExceptionAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Exception Caught: {ex.Message}");
            }

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("RESPONSIVE APPLICATION EXAMPLE");
            Console.WriteLine("=========================================");

            Task loadingTask =
                DisplayLoadingMessageAsync();

            Console.WriteLine(
                "Application continues running...");

            Console.WriteLine(
                "User can still interact with the program.");

            await loadingTask;

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("ASYNC AWAIT EXAMPLES COMPLETED");
            Console.WriteLine("=========================================");
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
