/*
=========================================
DESIGN PATTERNS TASKS
=========================================

Instructions:

These tasks are designed to help me practice
Design Patterns in C#.

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
Create a class named AppSettings.

Requirements:

- Store an application name
- Display the application name

This task introduces simple shared settings.
*/

/////////////////////////////////////////////////////
// Task 2 - Rank 1 🌱
/////////////////////////////////////////////////////

/*
Create a class named Logger.

Requirements:

- Create a method named Log()
- Accept a string message
- Display the message

This task introduces a common service object.
*/

/////////////////////////////////////////////////////
// Task 3 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create a Singleton class named SettingsManager.

Requirements:

- Only one instance should be accessible
- Use a private constructor
- Use a public static Instance property
- Create a method named ShowSettings()
*/

/////////////////////////////////////////////////////
// Task 4 - Rank 2 🙂
/////////////////////////////////////////////////////

/*
Create an interface named IAnimal.

Requirements:

- Declare a method named MakeSound()

Create two classes:

- Dog
- Cat

Both classes should implement IAnimal.
*/

/////////////////////////////////////////////////////
// Task 5 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create a Factory class named AnimalFactory.

Requirements:

- Create a method named CreateAnimal()
- Return Dog when input is "Dog"
- Return Cat when input is "Cat"

This task practices the Factory Pattern.
*/

/////////////////////////////////////////////////////
// Task 6 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create a class named Computer.

Requirements:

- Store CPU
- Store RAM
- Store Storage

Create a class named ComputerBuilder.

Requirements:

- Add CPU
- Add RAM
- Add Storage
- Return the completed Computer

This task practices the Builder Pattern.
*/

/////////////////////////////////////////////////////
// Task 7 - Rank 3 ⚙️
/////////////////////////////////////////////////////

/*
Create a simple Observer system.

Requirements:

- Create a class named NewsPublisher
- Store a list of subscribers
- Add subscribers
- Notify subscribers when news is published

This task practices the Observer Pattern.
*/

/////////////////////////////////////////////////////
// Task 8 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create a Strategy Pattern payment system.

Requirements:

Create interface:

- IPaymentStrategy

Create classes:

- CreditCardStrategy
- PayPalStrategy

Create PaymentContext.

Requirements:

- Receive IPaymentStrategy through constructor
- Process payment using selected strategy
*/

/////////////////////////////////////////////////////
// Task 9 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create a Facade Pattern example.

Requirements:

Create classes:

- AudioSystem
- VideoSystem
- LightSystem

Create HomeTheaterFacade.

Requirements:

- Receive all systems
- Create a method named StartMovie()
- Start all systems with one method call
*/

/////////////////////////////////////////////////////
// Task 10 - Rank 4 🚀
/////////////////////////////////////////////////////

/*
Create an Adapter Pattern example.

Requirements:

Create class:

- OldPrinter

OldPrinter should have method:

- PrintOld()

Create interface:

- INewPrinter

INewPrinter should have method:

- Print()

Create class:

- PrinterAdapter

PrinterAdapter should allow OldPrinter
to work as INewPrinter.
*/

/////////////////////////////////////////////////////
// Task 11 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a Decorator Pattern example.

Requirements:

Create interface:

- ICoffee

Create class:

- SimpleCoffee

Create decorator classes:

- MilkDecorator
- SugarDecorator

Each decorator should add information
to the coffee description.

This task practices adding behavior
without modifying the original class.
*/

/////////////////////////////////////////////////////
// Task 12 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a Command Pattern example.

Requirements:

Create interface:

- ICommand

Create class:

- Light

Create commands:

- TurnOnCommand
- TurnOffCommand

Create RemoteControl.

Requirements:

- Receive command
- Execute command

This task practices turning actions into objects.
*/

/////////////////////////////////////////////////////
// Task 13 - Rank 5 🏗️
/////////////////////////////////////////////////////

/*
Create a complete professional pattern example.

Requirements:

Build a notification system using Strategy Pattern.

Create interface:

- INotificationStrategy

Create classes:

- EmailNotificationStrategy
- SmsNotificationStrategy
- PushNotificationStrategy

Create NotificationContext.

Requirements:

- Receive INotificationStrategy through constructor
- Send notification using selected strategy

Test all notification strategies.
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
