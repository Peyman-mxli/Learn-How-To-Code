/*
=========================================
SOLID PRINCIPLES TASKS
=========================================

Instructions:

These tasks are designed to help me practice
SOLID Principles in C#.

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
Create a class named Student.

Requirements:

- Store student name
- Store student age

This task practices keeping a class focused
on simple data only.
*/

/////////////////////////////////////////////////////
// Task 2 - Rank 1 🌱
/////////////////////////////////////////////////////

/*
Create a class named StudentPrinter.

Requirements:

- Create a method named PrintStudent()
- Accept a student name
- Display the student name

This task practices separating display logic
from data logic.
*/

/////////////////////////////////////////////////////
// Task 3 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create a class named Product.

Requirements:

- Store product name
- Store product price

Create a separate class named ProductRepository.

Requirements:

- Create a method named SaveProduct()
- Display that the product was saved

This task practices the Single Responsibility Principle.
*/

/////////////////////////////////////////////////////
// Task 4 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create an interface named IDiscount.

Requirements:

- Declare a method named CalculateDiscount()

Create a class named StudentDiscount.

Requirements:

- Implement IDiscount

This task practices the Open/Closed Principle.
*/

/////////////////////////////////////////////////////
// Task 5 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create an interface named IPaymentProcessor.

Requirements:

- Declare a method named ProcessPayment()

Create two classes:

- CreditCardPayment
- PayPalPayment

Both classes should implement IPaymentProcessor.

This task practices adding new behavior
without changing existing payment logic.
*/

/////////////////////////////////////////////////////
// Task 6 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create a base class named Animal.

Requirements:

- Create a virtual method named MakeSound()

Create a class named Dog.

Requirements:

- Inherit from Animal
- Override MakeSound()

This task practices the Liskov Substitution Principle.
*/

/////////////////////////////////////////////////////
// Task 7 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create two interfaces:

- IWorkable
- IEatable

Requirements:

IWorkable should contain:

- Work()

IEatable should contain:

- Eat()

Create two classes:

- Human
- Robot

Human should work and eat.

Robot should only work.

This task practices the Interface Segregation Principle.
*/

/////////////////////////////////////////////////////
// Task 8 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create an interface named IMessageService.

Requirements:

- Declare a method named SendMessage()

Create a class named EmailMessageService.

Requirements:

- Implement IMessageService

Create a class named NotificationService.

Requirements:

- Receive IMessageService through the constructor
- Use it to send a message

This task practices the Dependency Inversion Principle.
*/

/////////////////////////////////////////////////////
// Task 9 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create a report system.

Requirements:

Create:

- Report class
- ReportPrinter class
- ReportRepository class

Each class should have one clear responsibility.

This task practices the Single Responsibility Principle
in a more realistic structure.
*/

/////////////////////////////////////////////////////
// Task 10 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create a shipping system.

Requirements:

Create an interface named IShippingCalculator.

Create two classes:

- LocalShippingCalculator
- InternationalShippingCalculator

Both should implement IShippingCalculator.

Create an OrderShippingService that receives
IShippingCalculator through the constructor.

This task practices Open/Closed Principle
and Dependency Inversion Principle together.
*/

/////////////////////////////////////////////////////
// Task 11 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a professional user registration system.

Requirements:

Create interfaces:

- IUserRepository
- IEmailService
- ILoggerService

Create classes that implement them.

Create UserRegistrationService.

Requirements:

- Receive all dependencies through constructor
- Save user
- Send welcome email
- Log registration

This task practices SRP, DIP, and DI together.
*/

/////////////////////////////////////////////////////
// Task 12 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a payment system.

Requirements:

Create interface:

- IPaymentProcessor

Create classes:

- CreditCardProcessor
- PayPalProcessor
- BankTransferProcessor

Create CheckoutService.

Requirements:

- Receive IPaymentProcessor through constructor
- Process checkout

This task practices Open/Closed Principle
because new payment types can be added
without changing CheckoutService.
*/

/////////////////////////////////////////////////////
// Task 13 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a complete notification system.

Requirements:

Create interfaces:

- INotificationSender
- ILoggerService

Create classes:

- EmailSender
- SmsSender
- ConsoleLoggerService
- NotificationManager

NotificationManager requirements:

- Receive INotificationSender and ILoggerService
  through constructor
- Send notification
- Log notification result

This task practices professional SOLID design.
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
