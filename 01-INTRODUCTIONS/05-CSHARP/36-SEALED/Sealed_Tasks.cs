```csharp
/*
=========================================
36 - SEALED
Sealed_Tasks.cs
=========================================
*/

/*
==================================================
Rank 1 — Beginner 🌱
==================================================
*/

/*
Task 1

Create a sealed class named Calculator.

Add a method:

- Add(int a, int b)

Display the result.

Try to create a class that inherits
from Calculator.

Observe the compiler error.
*/

/*
Task 2

Create a sealed class named GameSettings.

Add:

- MaxLevel
- StartingGold

Display both values.
*/

/*
Task 3

Create a sealed class named CurrencyConverter.

Add methods:

- DollarToPeso()
- PesoToDollar()

Display several conversions.
*/

/*
==================================================
Rank 2 — Easy 🙂
==================================================
*/

/*
Task 4

Create a class named Animal.

Add a virtual method:

- Speak()

Create a class named Dog.

Override Speak() and seal it.

Display the result.
*/

/*
Task 5

Create a class named Vehicle.

Add a virtual method:

- StartEngine()

Create a class named Car.

Override StartEngine() and seal it.

Display the result.
*/

/*
Task 6

Create a class named Employee.

Add a virtual method:

- Work()

Create a class named Manager.

Override Work() and seal it.

Display the result.
*/

/*
==================================================
Rank 3 — Intermediate ⚙️
==================================================
*/

/*
Task 7

Create the following inheritance chain:

Character
↓
Warrior
↓
EliteWarrior

Requirements:

Character:
- virtual Attack()

Warrior:
- sealed override Attack()

EliteWarrior:
- additional method DisplayRank()

Display the results.

Explain why EliteWarrior cannot
override Attack().
*/

/*
Task 8

Create the following inheritance chain:

Account
↓
SavingsAccount
↓
PremiumSavingsAccount

Requirements:

Account:
- virtual CalculateInterest()

SavingsAccount:
- sealed override CalculateInterest()

PremiumSavingsAccount:
- custom method DisplayBenefits()

Display the results.
*/

/*
Task 9

Create a class named AuthenticationSystem.

Add:

- virtual Login()

Create:

SecureAuthenticationSystem

Override Login() and seal it.

Create:

EnterpriseAuthenticationSystem

Add additional methods.

Display the results.
*/

/*
==================================================
Rank 4 — Advanced 🚀
==================================================
*/

/*
Task 10

Create a sealed class named SecurityManager.

Add methods:

- ValidateUser()
- CheckPermissions()

Display the results.

Explain why SecurityManager should
not be inherited.
*/

/*
Task 11

Create a sealed class named PaymentProcessor.

Add methods:

- ProcessPayment()
- RefundPayment()

Display the results.

Explain why payment logic should
remain protected.
*/

/*
Task 12

Create a sealed class named SystemConfiguration.

Add:

- ApplicationName
- Version
- MaxUsers

Display all values.

Explain why configuration classes are
sometimes sealed.
*/

/*
==================================================
Rank 5 — Professional 🏗️
==================================================
*/

/*
Task 13

Create a class hierarchy for a school system.

Person
↓
Teacher
↓
HeadTeacher

Requirements:

Person:
- virtual DisplayRole()

Teacher:
- sealed override DisplayRole()

HeadTeacher:
- additional methods only

Display the results.

Explain why DisplayRole()
cannot be overridden again.
*/

/*
Task 14

Create a game combat hierarchy.

Unit
↓
Knight
↓
EliteKnight

Requirements:

Unit:
- virtual Attack()

Knight:
- sealed override Attack()

EliteKnight:
- additional methods

Display the results.
*/

/*
Task 15

Create a banking hierarchy.

BankAccount
↓
SavingsAccount
↓
VIPSavingsAccount

Requirements:

BankAccount:
- virtual CalculateInterest()

SavingsAccount:
- sealed override CalculateInterest()

VIPSavingsAccount:
- extra features only

Display the results.

Explain why business rules should
sometimes be sealed.
*/

/*
==================================================
CHALLENGE TASK
==================================================
*/

/*
Create a complete MMORPG Security System.

Requirements:

Create sealed classes:

- LoginManager
- AccountSecurity
- PaymentSecurity
- ServerConfiguration

Each class must contain multiple methods.

Create inheritance examples using:

virtual
override
sealed override

Include:

Character
↓
Player
↓
VIPPlayer

and

Account
↓
PremiumAccount
↓
LegendaryAccount

Demonstrate:

✓ Sealed classes

✓ Sealed methods

✓ Protected business rules

✓ Controlled inheritance

Display all results and explain
why sealed improves security,
stability, and maintainability.
*/

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
