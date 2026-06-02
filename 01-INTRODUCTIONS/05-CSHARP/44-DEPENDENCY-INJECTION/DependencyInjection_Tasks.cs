/*
=========================================
DEPENDENCY INJECTION TASKS
=========================================

Instructions:

These tasks are designed to help me practice
Dependency Injection in C#.

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
Create a class named MessageService.

Requirements:

- Create a method named ShowMessage()
- Display a simple message

Then create an object of MessageService
inside Main() and call the method.
*/

/////////////////////////////////////////////////////
// Task 2 - Rank 1 🌱
/////////////////////////////////////////////////////

/*
Create a class named Logger.

Requirements:

- Create a method named Log()
- The method should accept a string message
- Display the message in the console
*/

/////////////////////////////////////////////////////
// Task 3 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create a class named UserService.

Requirements:

- UserService should receive Logger
  through the constructor
- Store Logger in a private field
- Create a method named CreateUser()
- Inside CreateUser(), use Logger to display
  "User created successfully"
*/

/////////////////////////////////////////////////////
// Task 4 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create a class named EmailService.

Requirements:

- Create a method named SendEmail()
- The method should accept a string email message

Create a class named NotificationService.

Requirements:

- Receive EmailService through the constructor
- Use EmailService inside a method named Notify()
*/

/////////////////////////////////////////////////////
// Task 5 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create an interface named IPrinter.

Requirements:

- Declare a method named Print()

Create a class named ConsolePrinter
that implements IPrinter.

Create a class named ReportService.

Requirements:

- Receive IPrinter through the constructor
- Use IPrinter to print a report message
*/

/////////////////////////////////////////////////////
// Task 6 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create an interface named IPaymentProcessor.

Requirements:

- Declare a method named ProcessPayment()

Create two classes:

- CreditCardProcessor
- PayPalProcessor

Both classes should implement IPaymentProcessor.

Create an OrderService class that receives
IPaymentProcessor through the constructor.

Use OrderService to process payment.
*/

/////////////////////////////////////////////////////
// Task 7 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create an interface named IEmailSender.

Requirements:

- Declare a method named Send()

Create a class named GmailSender.

Requirements:

- Implement IEmailSender

Create a class named AccountService.

Requirements:

- Receive IEmailSender through the constructor
- Use it to send a welcome message
*/

/////////////////////////////////////////////////////
// Task 8 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create an interface named IRepository.

Requirements:

- Declare a method named Save()

Create a class named UserRepository.

Requirements:

- Implement IRepository

Create a class named UserManager.

Requirements:

- Receive IRepository through the constructor
- Use it to save user information
*/

/////////////////////////////////////////////////////
// Task 9 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create an interface named INotification.

Requirements:

- Declare a method named SendNotification()

Create two classes:

- EmailNotification
- SmsNotification

Both classes should implement INotification.

Create a NotificationManager class.

Requirements:

- Receive INotification through the constructor
- Send a notification

Test the program with both implementations.
*/

/////////////////////////////////////////////////////
// Task 10 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create a class named ProductService.

Requirements:

- It should depend on:
  - ILoggerService
  - IRepositoryService

Create both interfaces.

Create classes that implement them.

Inject both services through the constructor.

Use both dependencies inside ProductService.
*/

/////////////////////////////////////////////////////
// Task 11 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a small checkout system.

Requirements:

Create interfaces:

- IPaymentService
- IReceiptService
- ILoggerService

Create classes that implement them.

Create CheckoutService.

Requirements:

- Receive all dependencies through
  the constructor
- Process payment
- Create receipt
- Log checkout process
*/

/////////////////////////////////////////////////////
// Task 12 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a fake service for testing.

Requirements:

- Create an interface named IEmailService
- Create a real class named RealEmailService
- Create a fake class named FakeEmailService

Create a UserRegistrationService.

Requirements:

- Receive IEmailService through the constructor
- Use it to send registration email

Test UserRegistrationService with:

- RealEmailService
- FakeEmailService
*/

/////////////////////////////////////////////////////
// Task 13 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a full service structure.

Requirements:

Interfaces:

- ICustomerRepository
- ICustomerValidator
- ILogger

Classes:

- CustomerRepository
- CustomerValidator
- ConsoleLogger
- CustomerService

CustomerService requirements:

- Receive all dependencies through constructor
- Validate customer
- Save customer
- Log the result

This task practices professional
Dependency Injection structure.
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
