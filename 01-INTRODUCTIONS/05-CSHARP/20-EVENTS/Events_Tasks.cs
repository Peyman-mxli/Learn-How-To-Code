```csharp
/*
=========================================
EVENTS TASKS
=========================================

In this task file, I practice using Events in C#.

These tasks help me understand how events notify different parts
of a program when something important happens.

Events are built on delegates, so these tasks also help me strengthen
my understanding of delegate-based communication.

=========================================
TASK 1: CREATE A BASIC EVENT
=========================================

Create a class called Button.

Requirements:

* Create an event called OnClick
* Create a method called Click
* Raise the event inside the Click method
* Create another method that prints a message
* Subscribe the method to the event
* Call the Click method

Goal:

Practice creating and raising a simple event.

=========================================
TASK 2: SUBSCRIBE MULTIPLE METHODS
=========================================

Create an event called OnGameStart.

Requirements:

* Create at least three methods
* Subscribe all three methods to the event
* Raise the event
* Make sure all methods execute

Goal:

Practice using multiple event subscribers.

=========================================
TASK 3: UNSUBSCRIBE FROM AN EVENT
=========================================

Create an event called OnNotification.

Requirements:

* Subscribe two methods to the event
* Raise the event once
* Unsubscribe one method
* Raise the event again
* Confirm only one method runs the second time

Goal:

Practice removing event subscriptions.

=========================================
TASK 4: USE ACTION WITH EVENTS
=========================================

Create a class called Player.

Requirements:

* Create an event using Action
* Name the event OnAttack
* Create an Attack method
* Raise the event when the player attacks
* Subscribe a method that prints an attack message

Goal:

Practice using Action as an event type.

=========================================
TASK 5: CREATE A LEVEL UP EVENT
=========================================

Create a class called PlayerLevel.

Requirements:

* Create an event called OnLevelUp
* Create a method called LevelUp
* Raise the event inside LevelUp
* Subscribe a UI method
* Subscribe a sound method

Goal:

Practice using events to notify multiple systems.

=========================================
TASK 6: USE EVENTHANDLER
=========================================

Create a class called GameManager.

Requirements:

* Create an event using EventHandler
* Name the event OnGameOver
* Create a GameOver method
* Raise the event using this and EventArgs.Empty
* Subscribe a method that prints "Game Over"

Goal:

Practice using the standard EventHandler pattern.

=========================================
TASK 7: CREATE CUSTOM EVENTARGS
=========================================

Create a custom class called ScoreEventArgs.

Requirements:

* Inherit from EventArgs
* Add an int property called Score
* Create an event using EventHandler<ScoreEventArgs>
* Raise the event with a score value
* Print the score inside the event handler

Goal:

Practice sending data through events.

=========================================
TASK 8: CREATE A HEALTH CHANGE EVENT
=========================================

Create a class called HealthSystem.

Requirements:

* Create an event called OnHealthChanged
* Use EventHandler with custom HealthEventArgs
* HealthEventArgs should contain CurrentHealth
* Create a method called TakeDamage
* Raise the event after damage is taken
* Display the updated health

Goal:

Practice building a real-world event system.

=========================================
TASK 9: CREATE AN ITEM COLLECTED EVENT
=========================================

Create a class called Inventory.

Requirements:

* Create an event called OnItemCollected
* Use custom ItemEventArgs
* ItemEventArgs should contain ItemName
* Create a CollectItem method
* Raise the event when an item is collected
* Print the collected item name

Goal:

Practice using events in inventory-style systems.

=========================================
TASK 10: CREATE AN ENEMY DEFEATED EVENT
=========================================

Create a class called Enemy.

Requirements:

* Create an event called OnEnemyDefeated
* Create a method called Defeat
* Raise the event when the enemy is defeated
* Subscribe a method that gives XP
* Subscribe a method that drops loot

Goal:

Practice event communication between game systems.

=========================================
TASK 11: CREATE A LOGIN EVENT
=========================================

Create a class called UserAccount.

Requirements:

* Create an event called OnLogin
* Use custom LoginEventArgs
* LoginEventArgs should contain Username
* Create a Login method
* Raise the event when the user logs in
* Print a welcome message

Goal:

Practice using events in application-style systems.

=========================================
TASK 12: CREATE A DOWNLOAD COMPLETE EVENT
=========================================

Create a class called FileDownloader.

Requirements:

* Create an event called OnDownloadComplete
* Create a method called DownloadFile
* Print that the file is downloading
* Raise the event when download is complete
* Subscribe a method that prints a completion message

Goal:

Practice callback-style event behavior.

=========================================
TASK 13: CREATE A QUEST COMPLETED EVENT
=========================================

Create a class called Quest.

Requirements:

* Create an event called OnQuestCompleted
* Use custom QuestEventArgs
* QuestEventArgs should contain QuestName
* Create a CompleteQuest method
* Raise the event when the quest is completed
* Print the completed quest name

Goal:

Practice building a game quest event system.

=========================================
TASK 14: CREATE A SHOP PURCHASE EVENT
=========================================

Create a class called Shop.

Requirements:

* Create an event called OnItemPurchased
* Use custom PurchaseEventArgs
* PurchaseEventArgs should contain ItemName and Price
* Create a PurchaseItem method
* Raise the event when an item is purchased
* Print purchase information

Goal:

Practice sending multiple values through event data.

=========================================
TASK 15: BUILD A COMPLETE EVENT SYSTEM
=========================================

Create a small game-style event system.

Requirements:

* Create a Player class
* Create events for OnAttack, OnLevelUp, and OnDeath
* Subscribe different systems to each event
* Create methods that raise each event
* Test all events inside Main

Goal:

Practice combining multiple events in one professional example.

=========================================
COMPLETION GOAL
=========================================

After completing these tasks, I should be able to:

* Create events
* Subscribe methods to events
* Unsubscribe methods from events
* Raise events safely
* Use Action with events
* Use EventHandler
* Use EventHandler<T>
* Create custom EventArgs
* Send data through events
* Build event-based systems
* Understand how events improve communication between systems
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
