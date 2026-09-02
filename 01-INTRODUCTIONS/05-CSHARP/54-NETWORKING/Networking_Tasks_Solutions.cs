```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetworkingTaskSolutions
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("TASK 1:");
            Console.WriteLine("Networking means allowing computers and applications to communicate with each other.");
            Console.WriteLine("Applications communicate to send data, receive data, connect to APIs, and work with online services.");
            Console.WriteLine("Examples: a browser opening a website, an app calling an API, and a game connecting to a server.");

            Console.WriteLine("\nTASK 2:");
            Console.WriteLine("A Client is the application or device that sends a request.");
            Console.WriteLine("A Server is the system that receives the request and sends back a response.");
            Console.WriteLine("Example: A web browser is the client, and a website is the server.");

            Console.WriteLine("\nTASK 3:");
            Console.WriteLine("HTTP means HyperText Transfer Protocol.");
            Console.WriteLine("HTTPS means HyperText Transfer Protocol Secure.");
            Console.WriteLine("HTTP sends data normally, while HTTPS encrypts the communication.");
            Console.WriteLine("HTTPS is preferred because it protects privacy, passwords, tokens, and sensitive data.");

            Console.WriteLine("\nTASK 4:");
            Console.WriteLine("A URL is the full address of a resource on the internet.");
            Console.WriteLine("An endpoint is a specific path on a server that provides a specific resource.");
            Console.WriteLine("URL example: https://api.example.com/users");
            Console.WriteLine("Endpoint example: /users");

            Console.WriteLine("\nTASK 5:");
            Console.WriteLine("GET retrieves data. Example: Get all users.");
            Console.WriteLine("POST creates new data. Example: Create a new user.");
            Console.WriteLine("PUT updates existing data. Example: Update user number 5.");
            Console.WriteLine("DELETE removes data. Example: Delete user number 5.");

            Console.WriteLine("\nTASK 6:");
            Console.WriteLine("200 means OK. The request was successful.");
            Console.WriteLine("201 means Created. A new resource was created.");
            Console.WriteLine("400 means Bad Request. The request was invalid.");
            Console.WriteLine("404 means Not Found. The requested resource does not exist.");
            Console.WriteLine("500 means Internal Server Error. The server had a problem.");

            Console.WriteLine("\nTASK 7:");
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("HttpClient created successfully.");
            }

            Console.WriteLine("\nTASK 8:");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response =
                    await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

                Console.WriteLine($"Status Code: {(int)response.StatusCode}");
            }

            Console.WriteLine("\nTASK 9:");
            using (HttpClient client = new HttpClient())
            {
                string content =
                    await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");

                Console.WriteLine("Downloaded Content:");
                Console.WriteLine(content);
            }

            Console.WriteLine("\nTASK 10:");
            try
            {
                using HttpClient client = new HttpClient();

                string result =
                    await client.GetStringAsync("https://invalid-url-example.com");

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Networking error caught:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception handling is important because network requests can fail for many reasons.");
            }

            Console.WriteLine("\nTASK 11:");
            Console.WriteLine("An API is a way for applications to communicate with each other.");
            Console.WriteLine("JSON is a lightweight text format used to exchange data.");
            Console.WriteLine("APIs often send and receive JSON data.");
            Console.WriteLine("JSON example:");
            Console.WriteLine("{ \"id\": 1, \"name\": \"Peyman\" }");

            Console.WriteLine("\nTASK 12:");
            Console.WriteLine("Networking Best Practices:");
            Console.WriteLine("1. Use HTTPS whenever possible.");
            Console.WriteLine("2. Use async/await for network operations.");
            Console.WriteLine("3. Handle exceptions with try-catch.");
            Console.WriteLine("4. Check status codes before trusting responses.");
            Console.WriteLine("5. Use timeouts to avoid waiting forever.");
            Console.WriteLine("6. Protect sensitive data such as API keys and tokens.");
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
