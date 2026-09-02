```csharp
using System;

/*
=========================================
EVENTS NOTES
=========================================

In this module, I learn about Events.

Events are one of the most important features in C#.

Events allow one object to notify other objects
when something happens.

Events are built on top of Delegates.

This means that before learning Events,
I should already understand Delegates.

Events are used everywhere in modern C# development.

Examples include:

• Button Clicks
• User Input
• Game Systems
• File Operations
• Network Connections
• Level Up Systems
• Notifications

=========================================
WHAT IS AN EVENT?
=========================================

An Event is a notification system.

When something important happens,
an Event can notify other parts of the program.

Example:

Player levels up.

The Event can notify:

• UI System
• Sound System
• Achievement System
• Quest System

Without Events, every system would need
to constantly check for changes.

Events make communication cleaner.

=========================================
WHY EVENTS EXIST
=========================================

Without Events, systems become tightly coupled.

Example:

Player directly updates:

• UI
• Audio
• Achievements
• Quests

This creates problems.

With Events:

Player raises an Event.

Other systems listen for the Event.

Benefits:

• Cleaner code
• Less dependency
• Better scalability
• Easier maintenance

=========================================
EVENTS AND DELEGATES
=========================================

Events are built on Delegates.

A Delegate defines:

"What methods are allowed?"

An Event defines:

"When should those methods run?"

Events use Delegates internally.

=========================================
EVENT DECLARATION
=========================================

Basic Syntax:

public event DelegateType EventName;

Example:

public event MessageDelegate OnMessage;

The event can now notify subscribers.

=========================================
USING BUILT-IN DELEGATES
=========================================

Often I do not need a custom delegate.

Example:

public event Action OnAttack;

Action is commonly used for simple events.

=========================================
THE EVENT KEYWORD
=========================================

The event keyword provides protection.

Example:

public event Action OnLevelUp;

Benefits:

• External classes can subscribe
• External classes can unsubscribe
• External classes cannot invoke the event

This protects the event system.

=========================================
SUBSCRIBING TO EVENTS
=========================================

The += operator subscribes a method.

Example:

player.OnLevelUp += ShowLevelUpMessage;

Now the method listens for the event.

=========================================
UNSUBSCRIBING FROM EVENTS
=========================================

The -= operator removes a subscription.

Example:

player.OnLevelUp -= ShowLevelUpMessage;

The method no longer receives notifications.

=========================================
RAISING AN EVENT
=========================================

The object that owns the Event
raises the Event.

Example:

OnLevelUp?.Invoke();

This notifies all subscribers.

=========================================
NULL SAFE INVOCATION
=========================================

Always use null-safe invocation.

Good:

OnLevelUp?.Invoke();

Bad:

OnLevelUp();

Without subscribers,
the second version throws an exception.

=========================================
EVENT HANDLERS
=========================================

An Event Handler is a method
that responds to an Event.

Example:

void ShowLevelUpMessage()
{
    Console.WriteLine("Level Up!");
}

The Event Handler runs when the Event occurs.

=========================================
MULTIPLE SUBSCRIBERS
=========================================

Many methods can subscribe
to the same Event.

Example:

player.OnLevelUp += ShowMessage;
player.OnLevelUp += PlaySound;
player.OnLevelUp += UnlockAchievement;

When the Event occurs:

• ShowMessage executes
• PlaySound executes
• UnlockAchievement executes

=========================================
BUILT-IN EVENTHANDLER
=========================================

The most common Event Delegate is:

EventHandler

Example:

public event EventHandler OnGameStart;

This follows Microsoft's standard pattern.

=========================================
EVENTHANDLER<T>
=========================================

Generic EventHandler allows custom data.

Example:

public event EventHandler<PlayerEventArgs> OnLevelUp;

This passes extra information.

=========================================
CUSTOM EVENT ARGUMENTS
=========================================

Sometimes an Event needs data.

Example:

Player Level
Player Name
Current Health

Create a class that inherits EventArgs.

Example:

class PlayerEventArgs : EventArgs
{
    public int Level { get; set; }

    public string PlayerName { get; set; }
}

Now Event subscribers receive data.

=========================================
RAISING CUSTOM EVENTS
=========================================

Example:

OnLevelUp?.Invoke(
    this,
    new PlayerEventArgs
    {
        Level = 10,
        PlayerName = "Peyman"
    });

Subscribers can access the data.

=========================================
EVENT FLOW
=========================================

Typical Event Flow:

1. Event declared

↓

2. Method subscribes

↓

3. Event occurs

↓

4. Event raised

↓

5. Subscribers execute

This is how most Event systems work.

=========================================
REAL-WORLD GAME EXAMPLE
=========================================

Player gains experience.

↓

Player reaches next level.

↓

OnLevelUp Event raised.

↓

UI updates.

↓

Sound plays.

↓

Achievement unlocks.

↓

Quest tracker updates.

One Event can notify many systems.

=========================================
REAL-WORLD UI EXAMPLE
=========================================

Button clicked.

↓

OnClick Event raised.

↓

Open menu.

↓

Play sound.

↓

Update interface.

Events are heavily used in UI development.

=========================================
ADVANTAGES OF EVENTS
=========================================

1. Decoupling

Systems remain independent.

-----------------------------------------

2. Scalability

Easy to add more subscribers.

-----------------------------------------

3. Reusability

One Event can trigger many actions.

-----------------------------------------

4. Cleaner Code

Less direct dependencies.

-----------------------------------------

5. Professional Architecture

Used throughout .NET applications.

=========================================
COMMON MISTAKES
=========================================

Mistake #1

Forgetting to unsubscribe.

This can create memory leaks.

Example:

button.OnClick -= MyMethod;

-----------------------------------------

Mistake #2

Invoking Events without null checking.

Bad:

OnClick();

Good:

OnClick?.Invoke();

-----------------------------------------

Mistake #3

Using Events for everything.

Only use Events when notification
behavior is needed.

-----------------------------------------

Mistake #4

Creating unnecessary custom delegates.

Prefer:

EventHandler

or

EventHandler<T>

when possible.

=========================================
BEST PRACTICES
=========================================

• Use EventHandler when possible
• Use EventHandler<T> for custom data
• Always use null-safe invocation
• Unsubscribe when no longer needed
• Keep Event Handlers small
• Use meaningful Event names
• Follow Microsoft naming conventions

=========================================
NAMING CONVENTIONS
=========================================

Good:

OnPlayerDeath

OnLevelUp

OnQuestCompleted

OnItemCollected

Bad:

Event1

MyEvent

TestEvent

Use descriptive names.

=========================================
MODULE SUMMARY
=========================================

In this module, I learned:

• What Events are
• Why Events are useful
• Events and Delegates
• Event declaration
• Event subscriptions
• Event unsubscriptions
• Event invocation
• EventHandler
• EventHandler<T>
• Custom EventArgs
• Event architecture
• Professional Event patterns

Events are one of the most important
communication systems in C#.

They allow different parts of an application
to react to changes without creating
tight dependencies between systems.
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
