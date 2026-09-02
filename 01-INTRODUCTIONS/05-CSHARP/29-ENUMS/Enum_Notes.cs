using System;

/*
=========================================
ENUM NOTES
=========================================

In this module, I learn about Enums in C#.

Enum stands for Enumeration.

An enum is a special type that allows me to define
a group of named constants.

Enums make code easier to read, understand,
maintain, and debug.

Instead of using random numbers throughout
my code, I can use meaningful names.

-----------------------------------------
WHY ENUMS ARE IMPORTANT
-----------------------------------------

Without Enums:

int status = 1;

What does 1 mean?

Active?
Pending?
Completed?
Cancelled?

The meaning is unclear.

With Enums:

Status status = Status.Active;

The meaning becomes obvious.

Enums eliminate magic numbers and improve readability.

-----------------------------------------
CREATING AN ENUM
-----------------------------------------
*/

enum Status
{
    Pending,
    Active,
    Suspended,
    Deleted
}

/*
-----------------------------------------
DEFAULT ENUM VALUES
-----------------------------------------

Enums automatically start at 0.

Example:

enum Status
{
    Pending,    // 0
    Active,     // 1
    Suspended,  // 2
    Deleted     // 3
}

Every new member increases by 1.

-----------------------------------------
CUSTOM ENUM VALUES
-----------------------------------------

I can assign my own values.
*/

enum Priority
{
    Low = 1,
    Medium = 5,
    High = 10,
    Critical = 100
}

/*
-----------------------------------------
ACCESSING ENUM VALUES
-----------------------------------------

Status userStatus = Status.Active;

Console.WriteLine(userStatus);

Output:

Active

-----------------------------------------
CONVERTING ENUM TO INTEGER
-----------------------------------------

Enums internally store integer values.

Example:

Status status = Status.Active;

int value = (int)status;

Console.WriteLine(value);

Output:

1

-----------------------------------------
CONVERTING INTEGER TO ENUM
-----------------------------------------

Example:

int value = 2;

Status status = (Status)value;

Console.WriteLine(status);

Output:

Suspended

-----------------------------------------
ENUMS IN SWITCH STATEMENTS
-----------------------------------------

Enums work very well with switch.

Example:

switch(status)
{
    case Status.Pending:
        Console.WriteLine("Pending");
        break;

    case Status.Active:
        Console.WriteLine("Active");
        break;
}

This makes code cleaner and easier to maintain.

-----------------------------------------
ENUMS IN IF STATEMENTS
-----------------------------------------

Example:

if(status == Status.Active)
{
    Console.WriteLine("User is active");
}

-----------------------------------------
ENUMS IN GAMES
-----------------------------------------

Game development frequently uses enums.

Example:
*/

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

/*
Possible Usage:

CharacterState state = CharacterState.Running;

Benefits:

✔ Easier to understand
✔ Less bugs
✔ Easier debugging
✔ Cleaner code

-----------------------------------------
ENUMS FOR USER ROLES
-----------------------------------------
*/

enum UserRole
{
    Guest,
    Member,
    Moderator,
    Administrator
}

/*
Usage:

UserRole role = UserRole.Administrator;

-----------------------------------------
ENUMS FOR DAYS OF WEEK
-----------------------------------------
*/

enum DayOfWeekCustom
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

/*
-----------------------------------------
ENUMS FOR ORDER STATUS
-----------------------------------------
*/

enum OrderStatus
{
    Created,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

/*
-----------------------------------------
ENUMS FOR APPLICATION STATES
-----------------------------------------
*/

enum ApplicationState
{
    Starting,
    Running,
    Paused,
    Closing
}

/*
-----------------------------------------
GETTING ALL ENUM VALUES
-----------------------------------------

Enum.GetValues()

Example:

foreach(Status status in Enum.GetValues(typeof(Status)))
{
    Console.WriteLine(status);
}

Output:

Pending
Active
Suspended
Deleted

-----------------------------------------
GETTING ENUM NAMES
-----------------------------------------

Enum.GetNames()

Example:

string[] names =
    Enum.GetNames(typeof(Status));

foreach(string name in names)
{
    Console.WriteLine(name);
}

-----------------------------------------
CHECKING IF VALUE EXISTS
-----------------------------------------

Example:

bool exists =
    Enum.IsDefined(typeof(Status), 1);

Returns:

True

-----------------------------------------
FLAGS ENUMS (ADVANCED)
-----------------------------------------

Enums can represent combinations of values.

Example:

[Flags]
enum Permissions
{
    Read = 1,
    Write = 2,
    Execute = 4
}

This allows:

Read + Write

at the same time.

This topic is commonly used in professional software.

-----------------------------------------
BEST PRACTICES
-----------------------------------------

✔ Use enums instead of magic numbers

✔ Give meaningful names

✔ Use PascalCase

✔ Group related constants together

✔ Use enums when choices are limited

✔ Use enums for states and statuses

✔ Keep enum names descriptive

-----------------------------------------
COMMON MISTAKES
-----------------------------------------

❌ Using random integers

int role = 3;

❌ Unclear meanings

int state = 5;

❌ Too many unrelated values
inside one enum

❌ Forgetting enum type casting

-----------------------------------------
SUMMARY
-----------------------------------------

Enums allow me to:

✔ Create named constants

✔ Improve readability

✔ Reduce bugs

✔ Replace magic numbers

✔ Build cleaner applications

✔ Create game states

✔ Manage user roles

✔ Manage statuses

✔ Write professional C# code

Enums are one of the simplest but most
valuable features in C#.
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
