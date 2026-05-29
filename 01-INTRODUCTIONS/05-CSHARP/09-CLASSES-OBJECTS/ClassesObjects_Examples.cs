using System;

namespace LearnHowToCode.ClassesObjectsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Creating A Simple Object
// ==================================================

```
        Player hero = new Player();

        hero.playerName = "Peyman";

        Console.WriteLine("Player Name: " + hero.playerName);

        // ==================================================
        // Example 2 - Multiple Fields
        // ==================================================

        hero.level = 25;
        hero.health = 100;

        Console.WriteLine("Level: " + hero.level);
        Console.WriteLine("Health: " + hero.health);

        // ==================================================
        // Example 3 - Calling A Method
        // ==================================================

        hero.DisplayPlayer();

        // ==================================================
        // Example 4 - Multiple Objects
        // ==================================================

        Player hero2 = new Player();

        hero2.playerName = "Maria";
        hero2.level = 15;
        hero2.health = 80;

        hero2.DisplayPlayer();

        // ==================================================
        // Example 5 - Enemy Object
        // ==================================================

        Enemy wolf = new Enemy();

        wolf.enemyName = "Wolf";
        wolf.health = 100;

        wolf.DisplayEnemy();

        // ==================================================
        // Example 6 - Student Object
        // ==================================================

        Student student = new Student();

        student.studentName = "Peyman";
        student.age = 25;

        student.DisplayStudent();

        // ==================================================
        // Example 7 - Bank Account Object
        // ==================================================

        BankAccount account = new BankAccount();

        account.ownerName = "Peyman";
        account.balance = 5000.00;

        account.DisplayAccount();

        // ==================================================
        // Example 8 - Car Object
        // ==================================================

        Car car = new Car();

        car.brand = "Toyota";
        car.model = "Corolla";

        car.DisplayCar();

        // ==================================================
        // Example 9 - Weapon Object
        // ==================================================

        Weapon sword = new Weapon();

        sword.weaponName = "Iron Sword";
        sword.damage = 25;

        sword.DisplayWeapon();

        // ==================================================
        // Example 10 - Inventory Item
        // ==================================================

        InventoryItem potion = new InventoryItem();

        potion.itemName = "Health Potion";
        potion.quantity = 5;

        potion.DisplayItem();

        // ==================================================
        // Example 11 - NPC Object
        // ==================================================

        NPC merchant = new NPC();

        merchant.npcName = "Merchant";
        merchant.location = "Town";

        merchant.DisplayNPC();

        // ==================================================
        // Example 12 - RPG Character
        // ==================================================

        RPGCharacter tank = new RPGCharacter();

        tank.characterName = "Nova";
        tank.characterClass = "Tank";

        tank.DisplayCharacter();

        // ==================================================
        // Example 13 - Creating Multiple Enemies
        // ==================================================

        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();

        enemy1.enemyName = "Wolf";
        enemy2.enemyName = "Bear";

        Console.WriteLine(enemy1.enemyName);
        Console.WriteLine(enemy2.enemyName);

        // ==================================================
        // Example 14 - Separate Object Data
        // ==================================================

        Player playerA = new Player();
        Player playerB = new Player();

        playerA.playerName = "Player A";
        playerB.playerName = "Player B";

        Console.WriteLine(playerA.playerName);
        Console.WriteLine(playerB.playerName);

        // ==================================================
        // Example 15 - Object With Boolean
        // ==================================================

        AccountStatus userAccount = new AccountStatus();

        userAccount.isActive = true;

        userAccount.DisplayStatus();

        // ==================================================
        // Example 16 - Team Object
        // ==================================================

        Team team = new Team();

        team.teamName = "Nova Guardians";

        team.DisplayTeam();

        // ==================================================
        // Example 17 - Pet Object
        // ==================================================

        Pet pet = new Pet();

        pet.petName = "Dragon";

        pet.DisplayPet();

        // ==================================================
        // Example 18 - Shop Object
        // ==================================================

        Shop shop = new Shop();

        shop.shopName = "Weapon Store";

        shop.DisplayShop();

        // ==================================================
        // Example 19 - Quest Object
        // ==================================================

        Quest quest = new Quest();

        quest.questName = "Defeat The Wolf";

        quest.DisplayQuest();

        // ==================================================
        // Example 20 - Guild Object
        // ==================================================

        Guild guild = new Guild();

        guild.guildName = "Nova Legends";

        guild.DisplayGuild();

        // ==================================================
        // End Of Examples
        // ==================================================

        Console.WriteLine("\nAll Classes & Objects Examples Completed!");

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
        Console.WriteLine(playerName + " | Level " + level + " | Health " + health);
    }
}

class Enemy
{
    public string enemyName;
    public int health;

    public void DisplayEnemy()
    {
        Console.WriteLine(enemyName + " | Health " + health);
    }
}

class Student
{
    public string studentName;
    public int age;

    public void DisplayStudent()
    {
        Console.WriteLine(studentName + " | Age " + age);
    }
}

class BankAccount
{
    public string ownerName;
    public double balance;

    public void DisplayAccount()
    {
        Console.WriteLine(ownerName + " | Balance $" + balance);
    }
}

class Car
{
    public string brand;
    public string model;

    public void DisplayCar()
    {
        Console.WriteLine(brand + " " + model);
    }
}

class Weapon
{
    public string weaponName;
    public int damage;

    public void DisplayWeapon()
    {
        Console.WriteLine(weaponName + " | Damage " + damage);
    }
}

class InventoryItem
{
    public string itemName;
    public int quantity;

    public void DisplayItem()
    {
        Console.WriteLine(itemName + " | Quantity " + quantity);
    }
}

class NPC
{
    public string npcName;
    public string location;

    public void DisplayNPC()
    {
        Console.WriteLine(npcName + " | " + location);
    }
}

class RPGCharacter
{
    public string characterName;
    public string characterClass;

    public void DisplayCharacter()
    {
        Console.WriteLine(characterName + " | " + characterClass);
    }
}

class AccountStatus
{
    public bool isActive;

    public void DisplayStatus()
    {
        Console.WriteLine("Active: " + isActive);
    }
}

class Team
{
    public string teamName;

    public void DisplayTeam()
    {
        Console.WriteLine(teamName);
    }
}

class Pet
{
    public string petName;

    public void DisplayPet()
    {
        Console.WriteLine(petName);
    }
}

class Shop
{
    public string shopName;

    public void DisplayShop()
    {
        Console.WriteLine(shopName);
    }
}

class Quest
{
    public string questName;

    public void DisplayQuest()
    {
        Console.WriteLine(questName);
    }
}

class Guild
{
    public string guildName;

    public void DisplayGuild()
    {
        Console.WriteLine(guildName);
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
