using System;

# /*

09 - CLASSES & OBJECTS
ClassesObjects_Notes.cs
=======================

In this module, I learn the foundation of
Object-Oriented Programming (OOP) in C#.

Classes and objects are used in almost every
real-world C# application.

Understanding them is one of the most important
steps in becoming a professional developer.

==================================================

1. WHAT IS A CLASS?
   ==================================================

A class is a blueprint.

A class defines:

* Data
* Properties
* Behaviors
* Methods

Example:

class Player
{

}

The class itself does not create anything.

It only defines the structure.

==================================================
2. WHAT IS AN OBJECT?
=====================

An object is an instance of a class.

Example:

Player hero = new Player();

Player = Class

hero = Object

new Player() creates an object.

==================================================
3. REAL-WORLD EXAMPLE
=====================

Blueprint:

Car

Objects:

* Red Car
* Blue Car
* Black Car

The class defines what a car is.

The objects are actual cars created from
the blueprint.

==================================================
4. CLASS SYNTAX
===============

Example:

class Player
{

}

Basic Structure:

class ClassName
{

}

Class names usually use PascalCase.

Examples:

Player
Enemy
Weapon
Student

==================================================
5. FIELDS
=========

Fields store data inside a class.

Example:

class Player
{
public string playerName;
}

Field:

playerName

Data Type:

string

==================================================
6. MULTIPLE FIELDS
==================

Example:

class Player
{
public string playerName;
public int level;
public int health;
}

Fields store information about an object.

==================================================
7. CREATING OBJECTS
===================

Objects are created using the new keyword.

Example:

Player hero = new Player();

The object now exists in memory.

==================================================
8. ACCESSING FIELDS
===================

Fields are accessed using dot notation.

Example:

hero.playerName = "Peyman";

hero.level = 25;

hero.health = 100;

==================================================
9. READING FIELD VALUES
=======================

Example:

Console.WriteLine(hero.playerName);

Output:

Peyman

==================================================
10. METHODS INSIDE CLASSES
==========================

Classes can contain methods.

Example:

class Player
{
public void SayHello()
{
Console.WriteLine("Hello");
}
}

==================================================
11. CALLING OBJECT METHODS
==========================

Example:

hero.SayHello();

Output:

Hello

==================================================
12. COMPLETE CLASS EXAMPLE
==========================

class Player
{
public string playerName;

```
public void DisplayName()
{
    Console.WriteLine(playerName);
}
```

}

Usage:

Player hero = new Player();

hero.playerName = "Peyman";

hero.DisplayName();

==================================================
13. MULTIPLE OBJECTS
====================

Many objects can be created from one class.

Example:

Player hero1 = new Player();
Player hero2 = new Player();
Player hero3 = new Player();

Each object stores its own data.

==================================================
14. OBJECT DATA IS SEPARATE
===========================

Example:

hero1.playerName = "Peyman";

hero2.playerName = "Maria";

hero3.playerName = "John";

Each object contains different values.

==================================================
15. GAME EXAMPLE
================

class Enemy
{
public string enemyName;
public int health;
}

Enemy wolf = new Enemy();

wolf.enemyName = "Wolf";

wolf.health = 100;

==================================================
16. STUDENT EXAMPLE
===================

class Student
{
public string studentName;
public int age;
}

Student student1 = new Student();

student1.studentName = "Peyman";

student1.age = 25;

==================================================
17. BANK ACCOUNT EXAMPLE
========================

class BankAccount
{
public string ownerName;
public double balance;
}

BankAccount account = new BankAccount();

==================================================
18. WHY OBJECTS ARE IMPORTANT
=============================

Objects allow programs to:

* Organize data
* Group related functionality
* Reuse code
* Model real-world systems
* Build large projects

==================================================
19. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Forgetting the new keyword.

Incorrect:

Player hero;

Correct:

Player hero = new Player();

---

Mistake 2:

Trying to access fields before creating
the object.

---

Mistake 3:

Misspelling object names.

---

Mistake 4:

Confusing classes and objects.

Class:

Player

Object:

hero

==================================================
20. BEST PRACTICES
==================

* Use PascalCase for class names.
* Use meaningful names.
* Keep classes focused on one purpose.
* Create methods for behavior.
* Group related data together.
* Create multiple objects when needed.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What a class is
✓ What an object is
✓ Class syntax
✓ Fields
✓ Multiple fields
✓ Creating objects
✓ Accessing fields
✓ Reading values
✓ Methods inside classes
✓ Calling methods
✓ Multiple objects
✓ Game examples
✓ Student examples
✓ Bank examples
✓ Common mistakes
✓ Best practices

Classes and objects are the foundation of
Object-Oriented Programming and are used in
almost every modern C# application.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
