using System;

namespace LearnHowToCode.ClassesObjectsTaskSolutions
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Rank 1 Beginner 🌱
// Rank 2 Easy 🙂
// Rank 3 Intermediate ⚙️
// ==================================================

```
        Player player1 = new Player();

        player1.playerName = "Peyman";
        player1.level = 25;
        player1.health = 100;

        player1.DisplayPlayer();

        Player player2 = new Player();

        player2.playerName = "Nova";
        player2.level = 10;
        player2.health = 80;

        player2.DisplayPlayer();

        // ==================================================
        // Rank 4 Advanced 🚀
        // ==================================================

        Enemy enemy1 = new Enemy();

        enemy1.enemyName = "Wolf";
        enemy1.health = 100;

        enemy1.DisplayEnemy();

        Enemy enemy2 = new Enemy();

        enemy2.enemyName = "Bear";
        enemy2.health = 200;

        enemy2.DisplayEnemy();

        // ==================================================
        // Rank 5 Professional 🏗️
        // ==================================================

        Student student = new Student();

        student.studentName = "Peyman";
        student.age = 25;
        student.university = "Polytechnic University of Baja California";

        student.DisplayStudent();

        BankAccount account = new BankAccount();

        account.ownerName = "Peyman";
        account.balance = 5000.00;

        account.DisplayAccount();

        // ==================================================
        // Challenge Tasks ⭐
        // ==================================================

        Weapon sword = new Weapon();

        sword.weaponName = "Iron Sword";
        sword.damage = 25;

        sword.DisplayWeapon();

        InventoryItem item1 = new InventoryItem();
        item1.itemName = "Health Potion";
        item1.quantity = 5;

        InventoryItem item2 = new InventoryItem();
        item2.itemName = "Mana Potion";
        item2.quantity = 3;

        item1.DisplayItem();
        item2.DisplayItem();

        Character hero = new Character();
        hero.characterName = "Nova";
        hero.characterClass = "Warrior";
        hero.level = 15;

        Quest quest = new Quest();
        quest.questName = "Defeat The Wolf";
        quest.rewardGold = 100;

        Console.WriteLine("\nMini RPG Summary");
        hero.DisplayCharacter();
        enemy1.DisplayEnemy();
        sword.DisplayWeapon();
        quest.DisplayQuest();

        Console.WriteLine("\nAll Classes & Objects Tasks Completed!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

class Player
{
    public string playerName;
    public int level;
    public int health;

    public void DisplayPlayer()
    {
        Console.WriteLine("\nPlayer Information");
        Console.WriteLine("Name: " + playerName);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Health: " + health);
    }
}

class Enemy
{
    public string enemyName;
    public int health;

    public void DisplayEnemy()
    {
        Console.WriteLine("\nEnemy Information");
        Console.WriteLine("Name: " + enemyName);
        Console.WriteLine("Health: " + health);
    }
}

class Student
{
    public string studentName;
    public int age;
    public string university;

    public void DisplayStudent()
    {
        Console.WriteLine("\nStudent Information");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("University: " + university);
    }
}

class BankAccount
{
    public string ownerName;
    public double balance;

    public void DisplayAccount()
    {
        Console.WriteLine("\nBank Account Information");
        Console.WriteLine("Owner: " + ownerName);
        Console.WriteLine("Balance: $" + balance);
    }
}

class Weapon
{
    public string weaponName;
    public int damage;

    public void DisplayWeapon()
    {
        Console.WriteLine("\nWeapon Information");
        Console.WriteLine("Name: " + weaponName);
        Console.WriteLine("Damage: " + damage);
    }
}

class InventoryItem
{
    public string itemName;
    public int quantity;

    public void DisplayItem()
    {
        Console.WriteLine("\nInventory Item");
        Console.WriteLine("Item: " + itemName);
        Console.WriteLine("Quantity: " + quantity);
    }
}

class Character
{
    public string characterName;
    public string characterClass;
    public int level;

    public void DisplayCharacter()
    {
        Console.WriteLine("Character: " + characterName);
        Console.WriteLine("Class: " + characterClass);
        Console.WriteLine("Level: " + level);
    }
}

class Quest
{
    public string questName;
    public int rewardGold;

    public void DisplayQuest()
    {
        Console.WriteLine("Quest: " + questName);
        Console.WriteLine("Reward Gold: " + rewardGold);
    }
}
```

}

/*
👤 Author: Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From Iran (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
