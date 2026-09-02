```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetworkingExamples
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NETWORKING EXAMPLES");
            Console.WriteLine("========================================");

            await Example1_CreateHttpClient();
            await Example2_GetRequest();
            await Example3_GetStringAsync();
            await Example4_StatusCode();
            await Example5_ResponseHeaders();
            await Example6_ExceptionHandling();

            Console.WriteLine("\nAll examples completed.");
        }

        // ----------------------------------------------------
        // Example 1
        // Create HttpClient
        // ----------------------------------------------------
        static async Task Example1_CreateHttpClient()
        {
            Console.WriteLine("\nEXAMPLE 1 - Create HttpClient");

            using HttpClient client = new HttpClient();

            Console.WriteLine("HttpClient created successfully.");

            await Task.CompletedTask;
        }

        // ----------------------------------------------------
        // Example 2
        // Send GET Request
        // ----------------------------------------------------
        static async Task Example2_GetRequest()
        {
            Console.WriteLine("\nEXAMPLE 2 - GET Request");

            using HttpClient client = new HttpClient();

            HttpResponseMessage response =
                await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

            Console.WriteLine($"Status Code: {(int)response.StatusCode}");
        }

        // ----------------------------------------------------
        // Example 3
        // Download Text Content
        // ----------------------------------------------------
        static async Task Example3_GetStringAsync()
        {
            Console.WriteLine("\nEXAMPLE 3 - GetStringAsync");

            using HttpClient client = new HttpClient();

            string content =
                await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");

            Console.WriteLine("Downloaded Content:");
            Console.WriteLine(content);
        }

        // ----------------------------------------------------
        // Example 4
        // Check Status Code
        // ----------------------------------------------------
        static async Task Example4_StatusCode()
        {
            Console.WriteLine("\nEXAMPLE 4 - Status Code");

            using HttpClient client = new HttpClient();

            HttpResponseMessage response =
                await client.GetAsync("https://jsonplaceholder.typicode.com/users");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Request successful.");
            }
            else
            {
                Console.WriteLine("Request failed.");
            }
        }

        // ----------------------------------------------------
        // Example 5
        // Read Response Headers
        // ----------------------------------------------------
        static async Task Example5_ResponseHeaders()
        {
            Console.WriteLine("\nEXAMPLE 5 - Response Headers");

            using HttpClient client = new HttpClient();

            HttpResponseMessage response =
                await client.GetAsync("https://jsonplaceholder.typicode.com/posts");

            foreach (var header in response.Headers)
            {
                Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
            }
        }

        // ----------------------------------------------------
        // Example 6
        // Exception Handling
        // ----------------------------------------------------
        static async Task Example6_ExceptionHandling()
        {
            Console.WriteLine("\nEXAMPLE 6 - Exception Handling");

            try
            {
                using HttpClient client = new HttpClient();

                string result =
                    await client.GetStringAsync("https://invalid-url-example.com");

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Networking Error:");
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
```
