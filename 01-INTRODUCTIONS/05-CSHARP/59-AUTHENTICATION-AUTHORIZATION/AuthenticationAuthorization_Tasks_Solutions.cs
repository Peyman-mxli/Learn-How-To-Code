using System;
using System.Collections.Generic;

/*
=========================================
AUTHENTICATION & AUTHORIZATION TASKS SOLUTIONS
=========================================
*/

namespace AuthenticationAuthorizationTaskSolutions
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ExplainAuthentication();
            ExplainAuthorization();
            CompareAuthenticationAuthorization();
            CreateUserModelExample();
            ExplainRoles();
            ExplainPermissions();
            ExplainClaims();
            PlanLoginFlow();
            ExplainPasswordHashing();
            ExplainTokenAuthentication();
            ExplainJwt();
            ExplainPublicEndpoints();
            ExplainProtectedEndpoints();
            ExplainAdminEndpoints();
            ExplainRoleBasedAuthorization();
            ExplainClaimBasedAuthorization();
            ExplainHttps();
            ExplainMfa();
            SecurityBestPractices();
            DesignSecureSystem();
        }

        static void ExplainAuthentication()
        {
            Console.WriteLine("Authentication answers: Who are you?");
            Console.WriteLine("It verifies the identity of a user.");
            Console.WriteLine("Example: logging in with email and password.");
        }

        static void ExplainAuthorization()
        {
            Console.WriteLine("Authorization answers: What are you allowed to do?");
            Console.WriteLine("It checks the user's permissions after login.");
            Console.WriteLine("Example: an admin can delete users, but a normal user cannot.");
        }

        static void CompareAuthenticationAuthorization()
        {
            Console.WriteLine("Authentication happens first and checks identity.");
            Console.WriteLine("Authorization happens second and checks permissions.");
        }

        static void CreateUserModelExample()
        {
            User user = new User
            {
                Id = 1,
                Username = "Peyman",
                Email = "peyman@example.com",
                PasswordHash = "HASHED_PASSWORD_VALUE",
                Role = "Admin"
            };

            Console.WriteLine($"{user.Id} - {user.Username} - {user.Email} - {user.Role}");
        }

        static void ExplainRoles()
        {
            Console.WriteLine("Roles are groups of users with similar access.");
            Console.WriteLine("Examples: Admin, Manager, Teacher, Student, User.");
        }

        static void ExplainPermissions()
        {
            Console.WriteLine("Permissions are specific actions a user can perform.");
            Console.WriteLine("Examples: CreateUser, DeleteUser, ViewReports, UpdateProfile.");
        }

        static void ExplainClaims()
        {
            Console.WriteLine("Claims are pieces of information about a user.");
            Console.WriteLine("Examples: Name, Email, Role, Department, UserId.");
        }

        static void PlanLoginFlow()
        {
            Console.WriteLine("1. User enters username and password.");
            Console.WriteLine("2. System checks credentials.");
            Console.WriteLine("3. If valid, system grants access.");
            Console.WriteLine("4. If invalid, system denies access.");
        }

        static void ExplainPasswordHashing()
        {
            Console.WriteLine("Passwords should never be stored as plain text.");
            Console.WriteLine("Hashing converts a password into an unreadable value.");
            Console.WriteLine("This is safer because the real password is not stored.");
        }

        static void ExplainTokenAuthentication()
        {
            Console.WriteLine("After successful login, the server gives the user a token.");
            Console.WriteLine("The user sends the token with future requests.");
            Console.WriteLine("APIs use tokens because they are stateless and easy to validate.");
        }

        static void ExplainJwt()
        {
            Console.WriteLine("JWT means JSON Web Token.");
            Console.WriteLine("It can contain user id, username, role, claims, and expiration.");
            Console.WriteLine("It is useful for APIs because it can prove the user's identity.");
        }

        static void ExplainPublicEndpoints()
        {
            Console.WriteLine("Public endpoints do not require login.");
            Console.WriteLine("Examples: /api/products, /api/news, /api/about.");
        }

        static void ExplainProtectedEndpoints()
        {
            Console.WriteLine("Protected endpoints require authentication.");
            Console.WriteLine("Examples: /api/profile, /api/orders, /api/settings.");
        }

        static void ExplainAdminEndpoints()
        {
            Console.WriteLine("Admin endpoints require an Admin role.");
            Console.WriteLine("Examples: /api/admin/users, /api/admin/reports, /api/admin/settings.");
        }

        static void ExplainRoleBasedAuthorization()
        {
            Console.WriteLine("Role-based authorization checks the user's role.");
            Console.WriteLine("Admin can delete users.");
            Console.WriteLine("Normal User cannot delete users.");
        }

        static void ExplainClaimBasedAuthorization()
        {
            Console.WriteLine("Claim-based authorization checks user claims.");
            Console.WriteLine("Department = IT can view IT reports.");
            Console.WriteLine("Department = Sales cannot view IT reports.");
        }

        static void ExplainHttps()
        {
            Console.WriteLine("HTTPS encrypts communication.");
            Console.WriteLine("It protects passwords, tokens, personal information, and financial data.");
        }

        static void ExplainMfa()
        {
            Console.WriteLine("MFA means Multi-Factor Authentication.");
            Console.WriteLine("Example: Password + Phone Code.");
        }

        static void SecurityBestPractices()
        {
            Console.WriteLine("Use strong passwords.");
            Console.WriteLine("Hash passwords.");
            Console.WriteLine("Use HTTPS.");
            Console.WriteLine("Use MFA.");
            Console.WriteLine("Expire tokens.");
            Console.WriteLine("Validate input.");
            Console.WriteLine("Limit login attempts.");
        }

        static void DesignSecureSystem()
        {
            Console.WriteLine("Project Name: Secure Student Portal");
            Console.WriteLine("User Roles: Admin, Teacher, Student.");
            Console.WriteLine("Public Endpoints: /api/login, /api/about.");
            Console.WriteLine("Protected Endpoints: /api/profile, /api/classes.");
            Console.WriteLine("Admin-Only Endpoints: /api/admin/users, /api/admin/reports.");
            Console.WriteLine("Security Rules: hash passwords, use HTTPS, require tokens, validate input, and limit login attempts.");
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
