```csharp
/*
=========================================
DELEGATES TASKS
=========================================

In this task file, I practice using Delegates in C#.

These tasks help me understand how to store methods,
pass methods as values, execute methods dynamically,
and prepare for events and callbacks.

=========================================
TASK 1: CREATE A BASIC DELEGATE
=========================================

Create a delegate called MessageDelegate.

Requirements:

* The delegate should return void
* The delegate should have no parameters
* Create a method called ShowMessage
* Assign ShowMessage to the delegate
* Invoke the delegate

Goal:

Practice creating and invoking a simple delegate.

=========================================
TASK 2: DELEGATE WITH PARAMETERS
=========================================

Create a delegate called GreetingDelegate.

Requirements:

* The delegate should return void
* The delegate should accept one string parameter
* Create a method called GreetUser
* The method should print a greeting message
* Assign the method to the delegate
* Invoke the delegate with a name

Goal:

Practice using parameters with delegates.

=========================================
TASK 3: DELEGATE WITH RETURN VALUE
=========================================

Create a delegate called MathDelegate.

Requirements:

* The delegate should return int
* The delegate should accept two int parameters
* Create methods for Add, Subtract, and Multiply
* Assign each method to the delegate
* Invoke the delegate for each operation

Goal:

Practice using delegates with return values.

=========================================
TASK 4: PASS A DELEGATE AS A PARAMETER
=========================================

Create a method called ExecuteMessage.

Requirements:

* The method should accept a MessageDelegate parameter
* Create two methods called SayHello and SayGoodbye
* Pass each method into ExecuteMessage
* Invoke the delegate inside ExecuteMessage

Goal:

Practice passing methods as arguments.

=========================================
TASK 5: CREATE A MULTICAST DELEGATE
=========================================

Create a delegate that can call multiple methods.

Requirements:

* Create three methods
* Add all three methods to one delegate using +=
* Invoke the delegate
* Remove one method using -=
* Invoke the delegate again

Goal:

Practice multicast delegate behavior.

=========================================
TASK 6: USE NULL-SAFE INVOCATION
=========================================

Create a delegate variable that starts as null.

Requirements:

* Use ?.Invoke()
* Make sure no error happens when the delegate is null
* Assign a method to the delegate
* Invoke it safely again

Goal:

Practice safe delegate invocation.

=========================================
TASK 7: CREATE AN ANONYMOUS METHOD
=========================================

Create a delegate and assign an anonymous method.

Requirements:

* Use the delegate keyword
* Print a message from the anonymous method
* Invoke the delegate

Goal:

Practice anonymous method syntax.

=========================================
TASK 8: CREATE A LAMBDA EXPRESSION
=========================================

Create a delegate and assign a lambda expression.

Requirements:

* Use lambda syntax
* Print a message from the lambda
* Invoke the delegate

Goal:

Practice lambda expression basics.

=========================================
TASK 9: USE ACTION
=========================================

Use the built-in Action delegate.

Requirements:

* Create an Action variable
* Assign a lambda expression
* Print a message
* Invoke the Action

Goal:

Practice using Action for methods that return void.

=========================================
TASK 10: USE FUNC
=========================================

Use the built-in Func delegate.

Requirements:

* Create a Func<int, int, int>
* Assign a lambda expression that adds two numbers
* Invoke the Func
* Print the result

Goal:

Practice using Func for methods that return values.

=========================================
TASK 11: USE PREDICATE
=========================================

Use the built-in Predicate delegate.

Requirements:

* Create a Predicate<int>
* Check if a number is positive
* Test it with different numbers
* Print the results

Goal:

Practice using Predicate for true or false logic.

=========================================
TASK 12: CREATE A CALLBACK SYSTEM
=========================================

Create a simple callback example.

Requirements:

* Create a delegate called CompleteDelegate
* Create a method called ProcessTask
* ProcessTask should accept a CompleteDelegate parameter
* Print that the task is running
* Invoke the callback when finished

Goal:

Practice callback-style programming.

=========================================
TASK 13: GAME ACTION DELEGATE
=========================================

Create a delegate for game actions.

Requirements:

* Create methods called Attack, Heal, and Defend
* Assign each method to the delegate
* Change the delegate action during runtime
* Invoke each action

Goal:

Practice using delegates in game-style systems.

=========================================
TASK 14: MENU COMMAND SYSTEM
=========================================

Create a menu command system using delegates.

Requirements:

* Create methods called SaveGame, LoadGame, and ExitGame
* Assign each method to a delegate
* Execute different commands using the same delegate variable

Goal:

Practice using delegates for flexible command systems.

=========================================
TASK 15: ADVANCED DELEGATE PRACTICE
=========================================

Create a calculator using delegates.

Requirements:

* Create a delegate called CalculatorDelegate
* Create methods for Add, Subtract, Multiply, and Divide
* Allow the delegate to switch between operations
* Print the result of each operation

Goal:

Practice using delegates in a larger professional example.

=========================================
COMPLETION GOAL
=========================================

After completing these tasks, I should be able to:

* Create delegates
* Assign methods to delegates
* Invoke delegates
* Use delegate parameters
* Use delegate return values
* Pass delegates into methods
* Use multicast delegates
* Use anonymous methods
* Use lambda expressions
* Use Action, Func, and Predicate
* Understand callbacks
* Build flexible C# systems
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
