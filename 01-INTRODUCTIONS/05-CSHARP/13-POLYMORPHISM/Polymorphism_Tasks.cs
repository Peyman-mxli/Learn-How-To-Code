```csharp
namespace LearnHowToCode.Polymorphism
{
    /*
        ============================================================
        POLYMORPHISM TASKS
        ============================================================

        In this practice file, I complete tasks about polymorphism.

        These tasks help me practice:

        - Base classes
        - Derived classes
        - virtual methods
        - override methods
        - Runtime polymorphism
        - Base class references
        - Arrays of base class objects
        - Flexible object-oriented design

        IMPORTANT:

        This file contains task descriptions only.

        I do not write solutions here.

        The complete solutions are located in:

        Polymorphism_Tasks_Solutions.cs
    */

    class PolymorphismTasks
    {
        /*
            ============================================================
            Rank 1 Beginner 🌱
            ============================================================
        */

        /*
            Task 1

            Create a base class named Animal.

            Requirements:

            - Create a virtual method named MakeSound()
            - Print:
              "Animal makes a sound."

            Create a derived class named Dog.

            Requirements:

            - Override MakeSound()
            - Print:
              "Dog says: Woof!"

            Create a Dog object and call MakeSound().
        */

        /*
            Task 2

            Create a base class named Character.

            Requirements:

            - Create a virtual method named Attack()
            - Print:
              "Character attacks."

            Create a derived class named Warrior.

            Requirements:

            - Override Attack()
            - Print:
              "Warrior attacks with a sword."

            Call Attack() using a Character reference.
        */

        /*
            Task 3

            Create a base class named Vehicle.

            Requirements:

            - Create a virtual method named Drive()
            - Print:
              "Vehicle is driving."

            Create a derived class named Car.

            Requirements:

            - Override Drive()
            - Print:
              "Car is driving on the road."
        */

        /*
            ============================================================
            Rank 2 Easy 🙂
            ============================================================
        */

        /*
            Task 4

            Create a base class named Shape.

            Requirements:

            - Create a virtual method named Draw()
            - Print:
              "Drawing a shape."

            Create derived classes:

            - Circle
            - Rectangle

            Requirements:

            - Override Draw() in each class
            - Print a different message for each shape
        */

        /*
            Task 5

            Create a base class named PaymentMethod.

            Requirements:

            - Create a virtual method named ProcessPayment()

            Create derived classes:

            - CreditCard
            - PayPal
            - BankTransfer

            Requirements:

            - Override ProcessPayment() in each class
            - Print a different payment message for each type
        */

        /*
            Task 6

            Create a base class named Employee.

            Requirements:

            - Create a virtual method named CalculateSalary()

            Create derived classes:

            - Manager
            - Developer

            Requirements:

            - Override CalculateSalary() in each class
            - Print a different salary message for each employee type
        */

        /*
            ============================================================
            Rank 3 Intermediate ⚙️
            ============================================================
        */

        /*
            Task 7

            Create a base class named Enemy.

            Requirements:

            - Create a virtual method named Attack()

            Create derived classes:

            - Goblin
            - Dragon
            - Skeleton

            Requirements:

            - Override Attack() in each class
            - Store all enemies inside an Enemy array
            - Loop through the array and call Attack()
        */

        /*
            Task 8

            Create a base class named Notification.

            Requirements:

            - Create a virtual method named Send()

            Create derived classes:

            - EmailNotification
            - SmsNotification
            - PushNotification

            Requirements:

            - Override Send() in each class
            - Store notifications inside an array
            - Loop through and call Send()
        */

        /*
            Task 9

            Create a base class named Instrument.

            Requirements:

            - Create a virtual method named Play()

            Create derived classes:

            - Guitar
            - Piano
            - Drum

            Requirements:

            - Override Play() in each class
            - Demonstrate runtime polymorphism
        */

        /*
            ============================================================
            Rank 4 Advanced 🚀
            ============================================================
        */

        /*
            Task 10

            Create a base class named GameSkill.

            Requirements:

            - Property:
              SkillName

            - Virtual method:
              UseSkill()

            Create derived classes:

            - FireballSkill
            - HealSkill
            - ShieldSkill

            Requirements:

            - Override UseSkill()
            - Print the skill name and special effect
            - Store all skills in one GameSkill array
            - Loop through the skills and use them
        */

        /*
            Task 11

            Create a base class named Order.

            Requirements:

            - Property:
              OrderId

            - Virtual method:
              CalculateTotal()

            Create derived classes:

            - OnlineOrder
            - StoreOrder
            - InternationalOrder

            Requirements:

            - Override CalculateTotal()
            - Print a different total calculation message
            - Demonstrate polymorphism using an Order array
        */

        /*
            Task 12

            Create a base class named Report.

            Requirements:

            - Property:
              Title

            - Virtual method:
              Generate()

            Create derived classes:

            - SalesReport
            - InventoryReport
            - FinanceReport

            Requirements:

            - Override Generate()
            - Print a unique report message
            - Store reports in a Report array
        */

        /*
            ============================================================
            Rank 5 Professional 🏗️
            ============================================================
        */

        /*
            Task 13

            Create a base class named UserAccount.

            Requirements:

            - Property:
              Username

            - Virtual method:
              GetPermissions()

            Create derived classes:

            - AdminAccount
            - StudentAccount
            - GuestAccount

            Requirements:

            - Override GetPermissions()
            - Print different permissions
            - Demonstrate runtime polymorphism
        */

        /*
            Task 14

            Create a base class named DeliveryService.

            Requirements:

            - Property:
              PackageId

            - Virtual method:
              DeliverPackage()

            Create derived classes:

            - StandardDelivery
            - ExpressDelivery
            - InternationalDelivery

            Requirements:

            - Override DeliverPackage()
            - Print different delivery behavior
            - Store all delivery types in one array
            - Loop through the array
        */

        /*
            ============================================================
            FINAL CHALLENGE
            ============================================================
        */

        /*
            Final Challenge

            Create a complete polymorphic RPG attack system.

            Base Class:

                Character

            Properties:

                Name
                Level

            Virtual Method:

                Attack()

            Derived Classes:

                Warrior
                Mage
                Archer
                Healer

            Requirements:

            - Override Attack() in every derived class
            - Give every class a unique attack behavior
            - Store all characters in one Character array
            - Loop through the array and call Attack()
            - Demonstrate runtime polymorphism clearly
            - Print each character name, level, and attack style
        */
    }
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
