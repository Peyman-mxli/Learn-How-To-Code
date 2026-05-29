using System;

namespace LearnHowToCode.ConstructorsExamples
{
internal class Program
{
static void Main(string[] args)
{
// ==================================================
// Example 1 - Default Constructor
// ==================================================

```
        Player player1 = new Player();

        player1.DisplayPlayer();

        // ==================================================
        // Example 2 - Parameterized Constructor
        // ==================================================

        Player player2 =
            new Player("Peyman", 25, 100);

        player2.DisplayPlayer();

        // ==================================================
        // Example 3 - Another Player Object
        // ==================================================

        Player player3 =
            new Player("Nova", 10, 80);

        player3.DisplayPlayer();

        // ==================================================
        // Example 4 - Student Constructor
        // ==================================================

        Student student =
            new Student("Peyman", 25);

        student.DisplayStudent();

        // ==================================================
        // Example 5 - Car Constructor
        // ==================================================

        Car car =
            new Car("Toyota", "Corolla");

        car.DisplayCar();

        // ==================================================
        // Example 6 - Bank Account Constructor
        // ==================================================

        BankAccount account =
            new BankAccount("Peyman", 5000);

        account.DisplayAccount();

        // ==================================================
        // Example 7 - Enemy Constructor
        // ==================================================

        Enemy wolf =
            new Enemy("Wolf", 100);

        wolf.DisplayEnemy();

        // ==================================================
        // Example 8 - Weapon Constructor
        // ==================================================

        Weapon sword =
            new Weapon("Iron Sword", 25);

        sword.DisplayWeapon();

        // ==================================================
        // Example 9 - Constructor Overloading
        // ==================================================

        NPC npc1 = new NPC();

        NPC npc2 =
            new NPC("Merchant");

        npc1.DisplayNPC();
        npc2.DisplayNPC();

        // ==================================================
        // Example 10 - Product Constructor
        // ==================================================

        Product product =
            new Product("Keyboard", 49.99);

        product.DisplayProduct();

        // ==================================================
        // Example 11 - Pet Constructor
        // ==================================================

        Pet pet =
            new Pet("Dragon");

        pet.DisplayPet();

        // ==================================================
        // Example 12 - Quest Constructor
        // ==================================================

        Quest quest =
            new Quest(
                "Defeat The Wolf",
                100);

        quest.DisplayQuest();

        // ==================================================
        // Example 13 - Guild Constructor
        // ==================================================

        Guild guild =
            new Guild("Nova Legends");

        guild.DisplayGuild();

        // ==================================================
        // Example 14 - Team Constructor
        // ==================================================

        Team team =
            new Team("Nova Guardians");

        team.DisplayTeam();

        // ==================================================
        // Example 15 - Inventory Item Constructor
        // ==================================================

        InventoryItem potion =
            new InventoryItem(
                "Health Potion",
                5);

        potion.DisplayItem();

        // ==================================================
        // Example 16 - Constructor With This Keyword
        // ==================================================

        Character hero =
            new Character(
                "Nova",
                15);

        hero.DisplayCharacter();

        // ==================================================
        // Example 17 - Multiple Objects
        // ==================================================

        Enemy bear =
            new Enemy("Bear", 200);

        Enemy spider =
            new Enemy("Spider", 50);

        bear.DisplayEnemy();
        spider.DisplayEnemy();

        // ==================================================
        // Example 18 - Different Bank Accounts
        // ==================================================

        BankAccount account2 =
            new BankAccount("Maria", 2500);

        account2.DisplayAccount();

        // ==================================================
        // Example 19 - Different Weapons
        // ==================================================

        Weapon axe =
            new Weapon("Battle Axe", 40);

        axe.DisplayWeapon();

        // ==================================================
        // Example 20 - Constructor Review
        // ==================================================

        Console.WriteLine(
            "\nConstructors automatically initialize objects.");

        Console.WriteLine(
            "\nAll Constructor Examples Completed!");

        Console.WriteLine(
            "\nPress any key to exit...");

        Console.ReadKey();
    }
}

class Player
{
    public string playerName;
    public int level;
    public int health;

    public Player()
    {
        playerName = "Unknown";
        level = 1;
        health = 100;
    }

    public Player(
        string name,
        int playerLevel,
        int playerHealth)
    {
        playerName = name;
        level = playerLevel;
        health = playerHealth;
    }

    public void DisplayPlayer()
    {
        Console.WriteLine(
            playerName +
            " | Level " +
            level +
            " | Health " +
            health);
    }
}

class Student
{
    public string studentName;
    public int age;

    public Student(
        string name,
        int studentAge)
    {
        studentName = name;
        age = studentAge;
    }

    public void DisplayStudent()
    {
        Console.WriteLine(
            studentName +
            " | Age " +
            age);
    }
}

class Car
{
    public string brand;
    public string model;

    public Car(
        string carBrand,
        string carModel)
    {
        brand = carBrand;
        model = carModel;
    }

    public void DisplayCar()
    {
        Console.WriteLine(
            brand +
            " " +
            model);
    }
}

class BankAccount
{
    public string ownerName;
    public double balance;

    public BankAccount(
        string owner,
        double startingBalance)
    {
        ownerName = owner;
        balance = startingBalance;
    }

    public void DisplayAccount()
    {
        Console.WriteLine(
            ownerName +
            " | $" +
            balance);
    }
}

class Enemy
{
    public string enemyName;
    public int health;

    public Enemy(
        string name,
        int hp)
    {
        enemyName = name;
        health = hp;
    }

    public void DisplayEnemy()
    {
        Console.WriteLine(
            enemyName +
            " | Health " +
            health);
    }
}

class Weapon
{
    public string weaponName;
    public int damage;

    public Weapon(
        string name,
        int weaponDamage)
    {
        weaponName = name;
        damage = weaponDamage;
    }

    public void DisplayWeapon()
    {
        Console.WriteLine(
            weaponName +
            " | Damage " +
            damage);
    }
}

class NPC
{
    public string npcName;

    public NPC()
    {
        npcName = "Unknown NPC";
    }

    public NPC(string name)
    {
        npcName = name;
    }

    public void DisplayNPC()
    {
        Console.WriteLine(npcName);
    }
}

class Product
{
    public string productName;
    public double price;

    public Product(
        string name,
        double productPrice)
    {
        productName = name;
        price = productPrice;
    }

    public void DisplayProduct()
    {
        Console.WriteLine(
            productName +
            " | $" +
            price);
    }
}

class Pet
{
    public string petName;

    public Pet(string name)
    {
        petName = name;
    }

    public void DisplayPet()
    {
        Console.WriteLine(petName);
    }
}

class Quest
{
    public string questName;
    public int rewardGold;

    public Quest(
        string name,
        int gold)
    {
        questName = name;
        rewardGold = gold;
    }

    public void DisplayQuest()
    {
        Console.WriteLine(
            questName +
            " | Reward " +
            rewardGold +
            " Gold");
    }
}

class Guild
{
    public string guildName;

    public Guild(string name)
    {
        guildName = name;
    }

    public void DisplayGuild()
    {
        Console.WriteLine(guildName);
    }
}

class Team
{
    public string teamName;

    public Team(string name)
    {
        teamName = name;
    }

    public void DisplayTeam()
    {
        Console.WriteLine(teamName);
    }
}

class InventoryItem
{
    public string itemName;
    public int quantity;

    public InventoryItem(
        string name,
        int itemQuantity)
    {
        itemName = name;
        quantity = itemQuantity;
    }

    public void DisplayItem()
    {
        Console.WriteLine(
            itemName +
            " | Quantity " +
            quantity);
    }
}

class Character
{
    public string characterName;
    public int level;

    public Character(
        string characterName,
        int level)
    {
        this.characterName = characterName;
        this.level = level;
    }

    public void DisplayCharacter()
    {
        Console.WriteLine(
            characterName +
            " | Level " +
            level);
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
