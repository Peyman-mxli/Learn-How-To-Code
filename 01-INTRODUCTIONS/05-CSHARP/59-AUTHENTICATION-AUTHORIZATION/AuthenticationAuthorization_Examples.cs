using System;
using System.Collections.Generic;

/*
==================================================
AUTHENTICATION & AUTHORIZATION EXAMPLES
==================================================

These examples simulate authentication and
authorization concepts using a Console Application.

In a real ASP.NET Core application, these concepts
would be implemented using:

- ASP.NET Identity
- JWT Tokens
- Cookies
- Claims
- Roles
- Authorization Policies
*/

namespace AuthenticationAuthorizationExamples
{
    // ==========================================
    // USER MODEL
    // ==========================================

    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public List<string> Permissions { get; set; }
            = new List<string>();
    }

    class Program
    {
        static void Main()
        {
            Example1_Authentication();

            Example2_FailedAuthentication();

            Example3_Authorization();

            Example4_AdminAccess();

            Example5_UserAccess();

            Example6_Permissions();

            Example7_Claims();

            Example8_JwtConcept();

            Example9_PublicEndpoint();

            Example10_ProtectedEndpoint();

            Example11_HttpsConcept();

            Example12_MultiFactorAuthentication();
        }

        // ==========================================
        // EXAMPLE 1
        // SUCCESSFUL LOGIN
        // ==========================================

        static void Example1_Authentication()
        {
            Console.WriteLine("========== Example 1 ==========");

            string username = "Peyman";
            string password = "123456";

            if (username == "Peyman" &&
                password == "123456")
            {
                Console.WriteLine(
                    "Authentication Successful");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 2
        // FAILED LOGIN
        // ==========================================

        static void Example2_FailedAuthentication()
        {
            Console.WriteLine("========== Example 2 ==========");

            string username = "Peyman";
            string password = "WrongPassword";

            if (password != "123456")
            {
                Console.WriteLine(
                    "Authentication Failed");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 3
        // AUTHORIZATION
        // ==========================================

        static void Example3_Authorization()
        {
            Console.WriteLine("========== Example 3 ==========");

            User user = new User
            {
                Username = "Peyman",
                Role = "Student"
            };

            if (user.Role == "Student")
            {
                Console.WriteLine(
                    "Can View Profile");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 4
        // ADMIN ACCESS
        // ==========================================

        static void Example4_AdminAccess()
        {
            Console.WriteLine("========== Example 4 ==========");

            User admin = new User
            {
                Username = "AdminUser",
                Role = "Admin"
            };

            if (admin.Role == "Admin")
            {
                Console.WriteLine(
                    "Access Granted To Admin Panel");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 5
        // USER ACCESS DENIED
        // ==========================================

        static void Example5_UserAccess()
        {
            Console.WriteLine("========== Example 5 ==========");

            User user = new User
            {
                Username = "NormalUser",
                Role = "User"
            };

            if (user.Role != "Admin")
            {
                Console.WriteLine(
                    "Access Denied");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 6
        // PERMISSIONS
        // ==========================================

        static void Example6_Permissions()
        {
            Console.WriteLine("========== Example 6 ==========");

            User user = new User
            {
                Username = "Peyman"
            };

            user.Permissions.Add("CreateStudent");
            user.Permissions.Add("UpdateStudent");

            if (user.Permissions.Contains(
                "CreateStudent"))
            {
                Console.WriteLine(
                    "Permission Granted");
            }

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 7
        // CLAIMS
        // ==========================================

        static void Example7_Claims()
        {
            Console.WriteLine("========== Example 7 ==========");

            Dictionary<string, string> claims =
                new Dictionary<string, string>();

            claims["Name"] = "Peyman";

            claims["Email"] =
                "peyman@example.com";

            claims["Role"] = "Admin";

            Console.WriteLine(
                $"Role: {claims["Role"]}");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 8
        // JWT CONCEPT
        // ==========================================

        static void Example8_JwtConcept()
        {
            Console.WriteLine("========== Example 8 ==========");

            string token =
                "eyJhbGciOiJIUzI1NiIs...";

            Console.WriteLine(
                $"JWT Token: {token}");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 9
        // PUBLIC ENDPOINT
        // ==========================================

        static void Example9_PublicEndpoint()
        {
            Console.WriteLine("========== Example 9 ==========");

            Console.WriteLine(
                "GET /api/products");

            Console.WriteLine(
                "Accessible By Everyone");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 10
        // PROTECTED ENDPOINT
        // ==========================================

        static void Example10_ProtectedEndpoint()
        {
            Console.WriteLine("========== Example 10 ==========");

            Console.WriteLine(
                "GET /api/profile");

            Console.WriteLine(
                "Authentication Required");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 11
        // HTTPS
        // ==========================================

        static void Example11_HttpsConcept()
        {
            Console.WriteLine("========== Example 11 ==========");

            Console.WriteLine(
                "https://mywebsite.com");

            Console.WriteLine(
                "Communication Encrypted");

            Console.WriteLine();
        }

        // ==========================================
        // EXAMPLE 12
        // MFA
        // ==========================================

        static void Example12_MultiFactorAuthentication()
        {
            Console.WriteLine("========== Example 12 ==========");

            Console.WriteLine(
                "Step 1: Password");

            Console.WriteLine(
                "Step 2: Phone Code");

            Console.WriteLine(
                "Authentication Complete");

            Console.WriteLine();
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
