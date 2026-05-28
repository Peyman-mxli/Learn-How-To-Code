```csharp
/*
📘 Module — Basic Data Types: Boolean (bool)
Practice Task Solutions

This file contains clean, readable solutions to all tasks in
Boolean_Tasks.cs.

Multiple answers are possible. These solutions show simple and professional approaches.

⚠️ IMPORTANT:
Only read these solutions AFTER attempting the tasks yourself!
*/


// ===========================================================================
// 🟢 Rank 1 — Beginner
// ===========================================================================


// 🔹 Task 1.1

bool isAlive = true;

Console.WriteLine(isAlive);


// 🔹 Task 1.2

bool isOnline = false;

Console.WriteLine(isOnline);


// 🔹 Task 1.3

bool hasQuest = true;

Console.WriteLine($"Has Quest: {hasQuest}");


// 🔹 Task 1.4

bool isAdmin = false;

Console.WriteLine(isAdmin);


// ===========================================================================
// 🔵 Rank 2 — Easy
// ===========================================================================


// 🔹 Task 2.1

bool greaterThanResult = 10 > 5;

Console.WriteLine(greaterThanResult);


// 🔹 Task 2.2

bool lessThanResult = 3 < 1;

Console.WriteLine(lessThanResult);


// 🔹 Task 2.3

bool equalResult = 25 == 25;

Console.WriteLine(equalResult);


// 🔹 Task 2.4

bool notEqualResult = 100 != 50;

Console.WriteLine(notEqualResult);


// ===========================================================================
// 🟡 Rank 3 — Intermediate
// ===========================================================================


// 🔹 Task 3.1

bool hasSword = true;
bool hasRequiredLevel = true;

bool canEnterDungeon =
    hasSword && hasRequiredLevel;

Console.WriteLine(canEnterDungeon);


// 🔹 Task 3.2

bool hasVIP = false;
bool hasTicket = true;

bool canEnterEvent =
    hasVIP || hasTicket;

Console.WriteLine(canEnterEvent);


// 🔹 Task 3.3

bool isDoorOpen = true;

Console.WriteLine(!isDoorOpen);


// 🔹 Task 3.4

bool questCompleted = false;

questCompleted = true;

Console.WriteLine(questCompleted);


// ===========================================================================
// 🟠 Rank 4 — Advanced
// ===========================================================================


// 🔹 Task 4.1

bool usernameValid = true;
bool passwordValid = true;

bool canLogin =
    usernameValid && passwordValid;

Console.WriteLine(canLogin);


// 🔹 Task 4.2

bool hasKey = true;
bool hasLevel = false;

bool canEnter =
    hasKey && hasLevel;

Console.WriteLine(canEnter);


// 🔹 Task 4.3

bool emailVerified = true;
bool accountBanned = false;

bool accountActive =
    emailVerified && !accountBanned;

Console.WriteLine(accountActive);


// 🔹 Task 4.4

bool hasGoldMembership = false;
bool hasSpecialPass = true;

bool accessGranted =
    hasGoldMembership || hasSpecialPass;

Console.WriteLine(accessGranted);


// ===========================================================================
// 🔴 Rank 5 — Professional
// ===========================================================================


// 🔹 Task 5.1

bool playerAlive = true;
bool playerInCombat = false;
bool playerHasTarget = true;

Console.WriteLine($"Alive: {playerAlive}");
Console.WriteLine($"In Combat: {playerInCombat}");
Console.WriteLine($"Has Target: {playerHasTarget}");


// 🔹 Task 5.2

bool loginUsernameValid = true;
bool loginPasswordValid = true;
bool loginEmailVerified = true;

bool canLoginSystem =
    loginUsernameValid &&
    loginPasswordValid &&
    loginEmailVerified;

Console.WriteLine($"Username Valid: {loginUsernameValid}");
Console.WriteLine($"Password Valid: {loginPasswordValid}");
Console.WriteLine($"Email Verified: {loginEmailVerified}");
Console.WriteLine($"Can Login: {canLoginSystem}");


// 🔹 Task 5.3

bool hasEnoughGold = true;
bool hasRequiredPlayerLevel = true;
bool shopOpen = true;

bool canPurchase =
    hasEnoughGold &&
    hasRequiredPlayerLevel &&
    shopOpen;

Console.WriteLine($"Can Purchase: {canPurchase}");


// 🔹 Task 5.4

bool hasRaidKey = true;
bool hasRaidLevel = true;
bool isBanned = false;

bool canEnterRaid =
    hasRaidKey &&
    hasRaidLevel &&
    !isBanned;

Console.WriteLine($"Can Enter Raid: {canEnterRaid}");



/*
👤 Author

Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
