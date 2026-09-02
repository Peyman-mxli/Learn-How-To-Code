using System;

/*
==================================================
AUTHENTICATION & AUTHORIZATION NOTES
==================================================

Security is one of the most important parts of
software development.

Without security:

- Anyone can access private data
- Anyone can modify information
- Accounts can be stolen
- Systems can be attacked

Authentication and Authorization help protect
applications and users.

==================================================
WHAT IS AUTHENTICATION?
==================================================

Authentication answers:

"Who are you?"

Authentication verifies a user's identity.

Examples:

- Username and Password
- Email and Password
- Fingerprint
- Face Recognition
- Security Token

Authentication happens first.

==================================================
AUTHENTICATION EXAMPLE
==================================================

User enters:

Username:
Peyman

Password:
123456

System checks:

Is this user valid?

If yes:

Authentication successful.

==================================================
WHAT IS AUTHORIZATION?
==================================================

Authorization answers:

"What are you allowed to do?"

Authorization determines what actions
a user can perform.

Authorization happens after authentication.

==================================================
AUTHORIZATION EXAMPLE
==================================================

User:

Peyman

Role:

Student

Allowed:

✔ View profile

✔ Update profile

Not Allowed:

✘ Delete users

✘ Manage system settings

==================================================
AUTHENTICATION VS AUTHORIZATION
==================================================

Authentication:

Who are you?

--------------------------------

Authorization:

What can you do?

--------------------------------

Authentication happens first.

Authorization happens second.

==================================================
REAL WORLD EXAMPLE
==================================================

Airport

Authentication:

Show passport.

Identity confirmed.

--------------------------------

Authorization:

Can enter airplane?

Can enter VIP lounge?

Can enter staff-only area?

Permissions are checked.

==================================================
USERS
==================================================

Most systems contain users.

Example:

public class User
{
    public string Username { get; set; }

    public string Password { get; set; }
}

Users log in to access systems.

==================================================
ROLES
==================================================

Roles group permissions.

Examples:

Admin

Manager

Teacher

Student

Customer

Employee

==================================================
ROLE EXAMPLE
==================================================

Admin

Can:

✔ Create Users

✔ Delete Users

✔ View Reports

✔ Manage System

--------------------------------

User

Can:

✔ View Profile

✔ Edit Profile

==================================================
PERMISSIONS
==================================================

Permissions define specific actions.

Examples:

CreateStudent

DeleteStudent

UpdateStudent

ViewReports

ManageUsers

Roles usually contain permissions.

==================================================
CLAIMS
==================================================

Claims are pieces of information
about a user.

Examples:

Name

Email

Role

Department

Employee Id

==================================================
CLAIM EXAMPLE
==================================================

User:

Peyman

Claims:

Name:
Peyman

Email:
peyman@example.com

Role:
Admin

Department:
IT

==================================================
LOGIN SYSTEM
==================================================

Basic Login Flow:

User enters:

Username

Password

System checks database.

If valid:

Access granted.

Otherwise:

Access denied.

==================================================
PASSWORDS
==================================================

Passwords should NEVER be stored
as plain text.

Bad:

Password:
123456

Stored:
123456

Very dangerous.

==================================================
PASSWORD HASHING
==================================================

Passwords should be hashed.

Example:

Password:

123456

Stored:

X7A9P2L8K1...

Hashing converts passwords
into unreadable values.

==================================================
WHY HASH PASSWORDS?
==================================================

Benefits:

✔ More Secure

✔ Protects User Data

✔ Prevents Password Exposure

✔ Industry Standard

==================================================
TOKEN AUTHENTICATION
==================================================

Modern APIs commonly use tokens.

After login:

Server generates token.

User receives token.

User sends token
with future requests.

==================================================
TOKEN FLOW
==================================================

Login Request
      ↓

Authentication
      ↓

Token Generated
      ↓

Token Sent To User
      ↓

User Sends Token
      ↓

Protected Endpoint Access

==================================================
WHAT IS JWT?
==================================================

JWT

JSON Web Token

One of the most popular
authentication methods.

JWT contains:

- User Id
- Username
- Claims
- Expiration

==================================================
JWT BENEFITS
==================================================

✔ Stateless

✔ Fast

✔ Widely Supported

✔ Great For APIs

✔ Works Across Platforms

==================================================
PUBLIC ENDPOINTS
==================================================

Public endpoints require
no authentication.

Examples:

/api/products

/api/news

/api/about

Anyone can access.

==================================================
PROTECTED ENDPOINTS
==================================================

Protected endpoints require
authentication.

Examples:

/api/profile

/api/orders

/api/settings

Only authenticated users
can access.

==================================================
ADMIN ENDPOINTS
==================================================

Some endpoints require
specific roles.

Examples:

/api/admin/users

/api/admin/reports

/api/admin/settings

Only Admin users can access.

==================================================
ROLE-BASED AUTHORIZATION
==================================================

Example:

Admin

Can access:

/api/admin

--------------------------------

Student

Cannot access:

/api/admin

Authorization denies access.

==================================================
CLAIM-BASED AUTHORIZATION
==================================================

Authorization can use claims.

Example:

Department = IT

Allowed:

View IT Reports

Department = Sales

Denied.

==================================================
HTTPS
==================================================

HTTPS encrypts communication.

Protects:

- Passwords
- Tokens
- Personal Information
- Financial Data

Always use HTTPS
for secure applications.

==================================================
SESSION AUTHENTICATION
==================================================

Older systems often use sessions.

Login
 ↓

Session Created
 ↓

Server Stores Session
 ↓

User Sends Session Id

Still common in websites.

==================================================
TOKEN AUTHENTICATION VS SESSION
==================================================

Session

Server stores session.

--------------------------------

Token

Client stores token.

--------------------------------

Modern APIs usually prefer JWT.

==================================================
LOGOUT
==================================================

Logout ends access.

Common methods:

- Destroy Session
- Revoke Token
- Remove Authentication Cookie

==================================================
MULTI-FACTOR AUTHENTICATION
==================================================

MFA

Multi-Factor Authentication

Requires multiple checks.

Example:

Password
+
Phone Code

More secure than password alone.

==================================================
AUTHENTICATION BEST PRACTICES
==================================================

✔ Use Strong Passwords

✔ Hash Passwords

✔ Use HTTPS

✔ Use MFA

✔ Use Secure Tokens

✔ Expire Tokens

✔ Validate Input

✔ Limit Login Attempts

==================================================
AUTHORIZATION BEST PRACTICES
==================================================

✔ Least Privilege Principle

✔ Role-Based Access

✔ Claim-Based Access

✔ Validate Permissions

✔ Protect Sensitive Endpoints

==================================================
COMMON SECURITY RISKS
==================================================

Weak Passwords

--------------------------------

Password Reuse

--------------------------------

Token Theft

--------------------------------

Unauthorized Access

--------------------------------

Poor Permission Design

--------------------------------

Unencrypted Communication

==================================================
WHERE AUTHENTICATION IS USED
==================================================

- Banking Systems

- Social Networks

- E-Commerce Platforms

- School Systems

- Hospital Systems

- Cloud Services

- Enterprise Software

==================================================
MODULE SUMMARY
==================================================

In this module I learned:

✔ Authentication

✔ Authorization

✔ Users

✔ Roles

✔ Permissions

✔ Claims

✔ Login Systems

✔ Password Hashing

✔ Tokens

✔ JWT

✔ Protected Endpoints

✔ Public Endpoints

✔ Role-Based Security

✔ Claim-Based Security

✔ HTTPS

✔ MFA

✔ Security Best Practices

These concepts form the foundation
of secure application development
using C# and ASP.NET Core.
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
