```csharp
/*
    ============================================================
    MODULE: 54 - NETWORKING
    FILE: Networking_Notes.cs
    ============================================================

    Networking allows computers and applications
    to communicate with each other.

    Modern applications rarely work completely alone.

    Most software communicates with:

    - Websites
    - APIs
    - Databases
    - Cloud services
    - Servers
    - Mobile applications

    Understanding networking is essential for
    professional software development.

    ============================================================
    WHAT IS A NETWORK?
    ============================================================

    A network is a group of connected devices
    that can exchange information.

    Examples:

    - Home Wi-Fi
    - School Network
    - Company Network
    - The Internet

    Devices communicate by sending
    and receiving data.

    ============================================================
    CLIENT AND SERVER
    ============================================================

    Networking usually follows a:

        Client → Server

    model.

    Client:

        Requests information

    Server:

        Provides information

    Example:

        Web Browser → Website

    Browser:

        Client

    Website:

        Server

    ============================================================
    CLIENT-SERVER EXAMPLE
    ============================================================

    You open:

        https://www.google.com

    Your browser sends:

        Request

    Google sends:

        Response

    This communication happens
    through networking.

    ============================================================
    WHAT IS HTTP?
    ============================================================

    HTTP means:

        HyperText Transfer Protocol

    It is the most common protocol
    used on the Internet.

    HTTP defines how:

    - Requests are sent
    - Responses are returned

    ============================================================
    HTTPS
    ============================================================

    HTTPS means:

        HyperText Transfer Protocol Secure

    HTTPS encrypts communication.

    Benefits:

    ✓ Security

    ✓ Privacy

    ✓ Data protection

    Modern applications should
    use HTTPS whenever possible.

    ============================================================
    URL
    ============================================================

    URL means:

        Uniform Resource Locator

    Example:

        https://api.example.com/users

    Parts:

        Protocol

            https

        Domain

            api.example.com

        Endpoint

            /users

    ============================================================
    ENDPOINT
    ============================================================

    An endpoint is a specific location
    on a server.

    Example:

        /users

        /products

        /orders

    Different endpoints provide
    different data.

    ============================================================
    HTTP REQUEST
    ============================================================

    A request is sent by the client.

    Example:

        "Give me user information"

        "Download product list"

        "Create new order"

    ============================================================
    HTTP RESPONSE
    ============================================================

    A response is sent by the server.

    Example:

        User information

        Product data

        Error messages

    ============================================================
    HTTP METHODS
    ============================================================

    Common HTTP methods:

    GET

        Retrieve data

    POST

        Create data

    PUT

        Update data

    DELETE

        Remove data

    ============================================================
    GET REQUEST
    ============================================================

    GET retrieves information.

    Example:

        GET /users

    Response:

        List of users

    GET is the most common request type.

    ============================================================
    POST REQUEST
    ============================================================

    POST creates new data.

    Example:

        POST /users

    Create a new user.

    ============================================================
    PUT REQUEST
    ============================================================

    PUT updates existing data.

    Example:

        PUT /users/5

    Update user number 5.

    ============================================================
    DELETE REQUEST
    ============================================================

    DELETE removes data.

    Example:

        DELETE /users/5

    Remove user number 5.

    ============================================================
    STATUS CODES
    ============================================================

    Servers return status codes.

    Common codes:

        200 OK

            Success

        201 Created

            New resource created

        400 Bad Request

            Invalid request

        401 Unauthorized

            Authentication required

        403 Forbidden

            Access denied

        404 Not Found

            Resource not found

        500 Internal Server Error

            Server problem

    ============================================================
    WEB API
    ============================================================

    API means:

        Application Programming Interface

    A Web API allows applications
    to communicate over HTTP.

    Example:

        Mobile App
             ↓
            API
             ↓
         Database

    ============================================================
    JSON
    ============================================================

    Most APIs exchange data using JSON.

    Example:

        {
            "id": 1,
            "name": "Peyman"
        }

    JSON is lightweight,
    readable, and widely used.

    ============================================================
    HTTPCLIENT
    ============================================================

    In C# the primary networking class is:

        HttpClient

    Namespace:

        using System.Net.Http;

    Example:

        HttpClient client =
            new HttpClient();

    ============================================================
    SIMPLE GET REQUEST
    ============================================================

    Example:

        HttpClient client =
            new HttpClient();

        string data =
            await client.GetStringAsync(url);

    This downloads text data
    from a server.

    ============================================================
    ASYNC NETWORKING
    ============================================================

    Networking operations often
    take time.

    Examples:

    - Internet delays
    - Slow servers
    - Large downloads

    Therefore networking is commonly used with:

        async

        await

    ============================================================
    NETWORK ERRORS
    ============================================================

    Common networking errors:

    - No internet connection
    - Invalid URL
    - Server offline
    - Timeout
    - Authentication failure

    Always handle exceptions properly.

    ============================================================
    TRY-CATCH
    ============================================================

    Example:

        try
        {
            // Request
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    Prevents application crashes.

    ============================================================
    TIMEOUTS
    ============================================================

    Servers may take too long
    to respond.

    Example:

        client.Timeout =
            TimeSpan.FromSeconds(30);

    Prevents waiting forever.

    ============================================================
    HEADERS
    ============================================================

    Headers provide additional information.

    Examples:

        Authorization

        Content-Type

        User-Agent

    APIs often require headers.

    ============================================================
    AUTHENTICATION
    ============================================================

    Some APIs require identity verification.

    Common methods:

    - API Keys
    - Tokens
    - JWT
    - OAuth

    Authentication protects resources.

    ============================================================
    COMMON USE CASES
    ============================================================

    Networking is used in:

    - Websites
    - Mobile Apps
    - Cloud Services
    - Online Games
    - Banking Systems
    - Social Media
    - E-Commerce Platforms
    - Enterprise Software

    ============================================================
    BEST PRACTICES
    ============================================================

    ✓ Use HttpClient

    ✓ Prefer HTTPS

    ✓ Use async/await

    ✓ Handle exceptions

    ✓ Check status codes

    ✓ Validate responses

    ✓ Use timeouts

    ✓ Protect sensitive data

    ✓ Reuse HttpClient instances

    ============================================================
    SUMMARY
    ============================================================

    Networking allows applications
    to communicate with other systems.

    Important concepts include:

    - Client
    - Server
    - HTTP
    - HTTPS
    - URL
    - Endpoint
    - Request
    - Response
    - Status Codes
    - APIs
    - JSON
    - HttpClient

    Networking is one of the most
    important skills for modern
    software development.
*/

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
