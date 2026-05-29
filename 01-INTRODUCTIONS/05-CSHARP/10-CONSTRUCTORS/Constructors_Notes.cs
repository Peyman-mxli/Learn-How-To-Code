using System;

# /*

10 - CONSTRUCTORS
Constructors_Notes.cs
=====================

In this module, I learn how constructors work
in C#.

Constructors are special methods that run
automatically when an object is created.

They are used to initialize object data.

==================================================

1. WHAT IS A CONSTRUCTOR?
   ==================================================

A constructor is a special method inside a class.

It executes automatically when an object is
created.

Example:

Player hero = new Player();

When this line runs:

Player()

is automatically executed.

==================================================
2. WHY USE CONSTRUCTORS?
========================

Constructors help:

* Initialize data
* Reduce repetitive code
* Improve readability
* Create valid objects
* Simplify object creation

Without constructors, values often need to be
assigned manually.

==================================================
3. CONSTRUCTOR RULES
====================

Rule 1:

The constructor name must match the class name.

Example:

class Player
{
public Player()
{

```
}
```

}

---

Rule 2:

Constructors do not have a return type.

Incorrect:

public void Player()

Correct:

public Player()

---

Rule 3:

Constructors run automatically.

==================================================
4. DEFAULT CONSTRUCTOR
======================

A constructor with no parameters.

Example:

class Player
{
public Player()
{
Console.WriteLine("Player Created");
}
}

Usage:

Player hero = new Player();

Output:

Player Created

==================================================
5. INITIALIZING DEFAULT VALUES
==============================

Example:

class Player
{
public string playerName;
public int level;

```
public Player()
{
    playerName = "Unknown";
    level = 1;
}
```

}

==================================================
6. PARAMETERIZED CONSTRUCTOR
============================

A constructor can receive parameters.

Example:

class Player
{
public string playerName;

```
public Player(string name)
{
    playerName = name;
}
```

}

Usage:

Player hero = new Player("Peyman");

==================================================
7. MULTIPLE PARAMETERS
======================

Example:

class Player
{
public string playerName;
public int level;
public int health;

```
public Player(string name,
              int playerLevel,
              int playerHealth)
{
    playerName = name;
    level = playerLevel;
    health = playerHealth;
}
```

}

==================================================
8. OBJECT INITIALIZATION
========================

Without Constructor:

Player hero = new Player();

hero.playerName = "Peyman";
hero.level = 25;
hero.health = 100;

---

With Constructor:

Player hero =
new Player("Peyman", 25, 100);

Cleaner and easier.

==================================================
9. MULTIPLE CONSTRUCTORS
========================

A class can contain more than one constructor.

Example:

class Player
{
public Player()
{

```
}

public Player(string name)
{

}
```

}

==================================================
10. CONSTRUCTOR OVERLOADING
===========================

Constructor overloading means multiple
constructors with different parameters.

Example:

Player()

Player(string name)

Player(string name, int level)

Each constructor serves a different purpose.

==================================================
11. STUDENT EXAMPLE
===================

class Student
{
public string studentName;

```
public Student(string name)
{
    studentName = name;
}
```

}

Usage:

Student student =
new Student("Peyman");

==================================================
12. CAR EXAMPLE
===============

class Car
{
public string brand;

```
public Car(string carBrand)
{
    brand = carBrand;
}
```

}

==================================================
13. BANK ACCOUNT EXAMPLE
========================

class BankAccount
{
public string ownerName;
public double balance;

```
public BankAccount(
    string owner,
    double startingBalance)
{
    ownerName = owner;
    balance = startingBalance;
}
```

}

==================================================
14. GAME EXAMPLE
================

class Enemy
{
public string enemyName;
public int health;

```
public Enemy(
    string name,
    int hp)
{
    enemyName = name;
    health = hp;
}
```

}

Usage:

Enemy wolf =
new Enemy("Wolf", 100);

==================================================
15. THIS KEYWORD
================

The this keyword refers to the current object.

Example:

class Player
{
public string playerName;

```
public Player(string playerName)
{
    this.playerName = playerName;
}
```

}

The left side refers to the field.

The right side refers to the parameter.

==================================================
16. BENEFITS OF CONSTRUCTORS
============================

* Automatic initialization
* Cleaner code
* Fewer mistakes
* Better object creation
* Easier maintenance
* Professional coding style

==================================================
17. COMMON BEGINNER MISTAKES
============================

Mistake 1:

Using a return type.

Incorrect:

public void Player()

---

Mistake 2:

Using the wrong constructor name.

Class:

Player

Constructor:

public Character()

Incorrect.

---

Mistake 3:

Passing incorrect arguments.

Example:

new Player(100);

when the constructor expects a string.

---

Mistake 4:

Forgetting required parameters.

==================================================
18. BEST PRACTICES
==================

* Use constructors for initialization.
* Keep constructors simple.
* Use meaningful parameter names.
* Avoid unnecessary complexity.
* Use constructor overloading when helpful.
* Initialize important fields immediately.

==================================================
SUMMARY
=======

In this module, I learned:

✓ What constructors are
✓ Why constructors matter
✓ Constructor rules
✓ Default constructors
✓ Parameterized constructors
✓ Multiple parameters
✓ Object initialization
✓ Multiple constructors
✓ Constructor overloading
✓ Student examples
✓ Car examples
✓ Bank examples
✓ Game examples
✓ This keyword
✓ Common mistakes
✓ Best practices

Constructors automatically prepare objects
when they are created and are a core part of
Object-Oriented Programming.
*/

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
