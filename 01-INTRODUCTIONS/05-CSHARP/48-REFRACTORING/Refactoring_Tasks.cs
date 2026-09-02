/*
=========================================
REFACTORING TASKS
=========================================

Instructions:

These tasks are designed to help me practice
Refactoring in C#.

I should solve the tasks myself before
looking at the solutions file.

Difficulty Ranking:

🌱 Rank 1 = Beginner
🙂 Rank 2 = Easy
⚙️ Rank 3 = Intermediate
🚀 Rank 4 = Advanced
🏗️ Rank 5 = Professional
*/

/////////////////////////////////////////////////////
// Task 1 - Rank 1 🌱
/////////////////////////////////////////////////////

/*
Refactor unclear variable names.

Original idea:

int x = 20;
int y = 5;
int z = x * y;

Requirements:

- Rename variables clearly
- Display the result
*/

/////////////////////////////////////////////////////
// Task 2 - Rank 1 🌱
/////////////////////////////////////////////////////

/*
Create a method named ShowWelcomeMessage().

Requirements:

- Move welcome message output into the method
- Call the method from Main()

This practices Extract Method.
*/

/////////////////////////////////////////////////////
// Task 3 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create a reusable method named ShowSeparator().

Requirements:

- Display a separator line
- Call it multiple times

This practices removing duplicate code.
*/

/////////////////////////////////////////////////////
// Task 4 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Replace a magic number.

Original idea:

if (score >= 70)

Requirements:

- Create a constant named PassingScore
- Use it in the condition
*/

/////////////////////////////////////////////////////
// Task 5 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Refactor a condition.

Requirements:

- Store age
- Store exam score
- Create readable boolean variables:
  - isAdult
  - passedExam

Use them inside an if statement.
*/

/////////////////////////////////////////////////////
// Task 6 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Split a large user registration method.

Requirements:

Create separate methods:

- ValidateUser()
- SaveUser()
- SendWelcomeEmail()

Call them from RegisterUser().
*/

/////////////////////////////////////////////////////
// Task 7 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Refactor duplicate price calculation.

Requirements:

Create a method named CalculateTotalPrice().

The method should:

- Accept product price
- Accept quantity
- Return total price
*/

/////////////////////////////////////////////////////
// Task 8 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Refactor messy order logic.

Requirements:

Create separate methods:

- ValidateOrder()
- CalculateOrderTotal()
- ApplyDiscount()
- ProcessPayment()

Each method should do one clear job.
*/

/////////////////////////////////////////////////////
// Task 9 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Refactor a large class design.

Requirements:

Create:

- Product class
- ProductRepository class
- ProductPrinter class

Responsibilities:

Product:
Stores product data

ProductRepository:
Saves product data

ProductPrinter:
Displays product data
*/

/////////////////////////////////////////////////////
// Task 10 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Use early returns.

Requirements:

Create a method named CheckAccess().

The method should:

- Check if username is empty
- Check if user is active
- Display access granted only when valid

Use early returns to avoid deep nesting.
*/

/////////////////////////////////////////////////////
// Task 11 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Refactor a customer registration system.

Requirements:

Create separate classes:

- Customer
- CustomerValidator
- CustomerRepository
- EmailService
- CustomerRegistrationService

Each class should have one clear responsibility.
*/

/////////////////////////////////////////////////////
// Task 12 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Refactor a calculator system.

Requirements:

Create separate methods:

- Add()
- Subtract()
- Multiply()
- Divide()

Create one method named DisplayResult()
to show the result.

Avoid duplicate output code.
*/

/////////////////////////////////////////////////////
// Task 13 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Refactor a complete employee system.

Requirements:

Create:

- Employee class
- EmployeeValidator class
- EmployeeRepository class
- EmployeePrinter class
- EmployeeService class

Responsibilities:

Employee:
Stores employee data

EmployeeValidator:
Validates employee data

EmployeeRepository:
Saves employee data

EmployeePrinter:
Displays employee data

EmployeeService:
Coordinates validation, saving, and printing

This task practices professional refactoring.
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
