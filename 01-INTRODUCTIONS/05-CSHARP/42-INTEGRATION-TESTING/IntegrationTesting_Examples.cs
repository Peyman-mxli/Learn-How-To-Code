/*
=========================================================
INTEGRATION TESTING TASKS
=========================================================

TASK 1 - EXPLAIN INTEGRATION TESTING

Write comments explaining what integration testing means.

Explain that integration testing checks how multiple
parts of a program work together.

---------------------------------------------------------

TASK 2 - CREATE USER CLASS

Create a User class.

Add:

- Username
- Password

---------------------------------------------------------

TASK 3 - CREATE USER REPOSITORY

Create a UserRepository class.

Add methods:

- AddUser(User user)
- GetUser(string username)

Use a List<User> to store users.

---------------------------------------------------------

TASK 4 - CREATE USER SERVICE

Create a UserService class.

Connect it to UserRepository.

Add:

- RegisterUser(string username, string password)
- Login(string username, string password)

---------------------------------------------------------

TASK 5 - TEST REGISTER USER

Create UserRepository.

Create UserService.

Register a user.

Display PASS if registration works.

---------------------------------------------------------

TASK 6 - TEST LOGIN SUCCESS

Register a user.

Then login with the correct password.

Display PASS if login works.

---------------------------------------------------------

TASK 7 - TEST LOGIN FAILURE

Register a user.

Then login with the wrong password.

Display PASS if login fails correctly.

---------------------------------------------------------

TASK 8 - TEST DUPLICATE USER

Register the same username twice.

Display PASS if the second registration is rejected.

---------------------------------------------------------

TASK 9 - TEST REPOSITORY CONNECTION

Register a user through UserService.

Then check UserRepository directly to confirm
the user was saved.

---------------------------------------------------------

TASK 10 - CREATE SETTINGS SERVICE

Create a SettingsService class.

Add:

- SaveSettings(string fileName, string content)
- LoadSettings(string fileName)

Use File.WriteAllText() and File.ReadAllText().

---------------------------------------------------------

TASK 11 - TEST FILE SAVE

Save settings into:

settings.txt

Display PASS if the file exists.

---------------------------------------------------------

TASK 12 - TEST FILE LOAD

Load settings from:

settings.txt

Display PASS if the loaded content is correct.

---------------------------------------------------------

TASK 13 - TEST COMPLETE USER WORKFLOW

Create a full workflow:

- Register user
- Login user
- Check repository

Display PASS if all steps work.

---------------------------------------------------------

TASK 14 - TEST USER NOT FOUND

Try to login with a username that does not exist.

Display PASS if login returns false.

---------------------------------------------------------

TASK 15 - TEST FILE CONTENT

Save text into a file.

Read it back.

Display PASS if saved content and loaded content match.

---------------------------------------------------------

TASK 16 - ARRANGE ACT ASSERT

Write comments explaining how Arrange, Act, Assert
can be used in integration testing.

---------------------------------------------------------

TASK 17 - UNIT VS INTEGRATION

Write comments explaining the difference between
unit testing and integration testing.

---------------------------------------------------------

TASK 18 - REAL-WORLD INTEGRATION TESTING

Write comments explaining three real-world examples
where integration testing is useful.

Examples:

- Login system
- Save system
- Inventory system

---------------------------------------------------------

TASK 19 - CLEANUP TEST FILES

After testing file operations, delete the test file
if it exists.

Use:

File.Delete()

---------------------------------------------------------

TASK 20 - MINI PROJECT

Create a small integrated login system.

Requirements:

- User class
- UserRepository class
- UserService class
- SettingsService class
- Register user
- Login user
- Reject duplicate user
- Save settings file
- Load settings file
- Display PASS / FAIL results clearly

=========================================================
END OF INTEGRATION TESTING TASKS
=========================================================
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
