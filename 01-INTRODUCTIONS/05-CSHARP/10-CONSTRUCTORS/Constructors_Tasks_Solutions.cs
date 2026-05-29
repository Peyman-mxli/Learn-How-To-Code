using System;

namespace LearnHowToCode.ConstructorsTaskSolutions
{
internal class Program
{
static void Main(string[] args)
{
Player player1 = new Player();
Player player2 = new Player("Peyman");
Player player3 = new Player("Nova", 25);
Player player4 = new Player("Hero", 50, 100);

```
        player1.DisplayPlayer();
        player2.DisplayPlayer();
        player3.DisplayPlayer();
        player4.DisplayPlayer();

        Student student = new Student("Peyman", 25);
        student.DisplayStudent();

        BankAccount account = new BankAccount("Peyman", 5000.00);
        account.DisplayAccount();

        Weapon weapon = new Weapon("Iron Sword", 25);
        weapon.DisplayWeapon();

        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy("Wolf");
        Enemy enemy3 = new Enemy("Bear", 200);

        enemy1.DisplayEnemy();
        enemy2.DisplayEnemy();
        enemy3.DisplayEnemy();

        Character character = new Character("Nova", 15);
        Weapon rpgWeapon = new Weapon("Battle Axe", 40);
        Quest quest = new Quest("Defeat The Wolf", 100);

        Console.WriteLine("\nMini RPG Summary");
        character.DisplayCharacter();
        rpgWeapon.DisplayWeapon();
        quest.DisplayQuest();

        Console.WriteLine("\nAll Constructor Tasks Completed!");

        Console.WriteLine("\nPress any key to exit...");
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

    public Player(string name)
    {
        playerName = name;
        level = 1;
        health = 100;
    }

    public Player(string name, int playerLevel)
    {
        playerName = name;
        level = playerLevel;
        health = 100;
    }

    public Player(string name, int playerLevel, int playerHealth)
    {
        playerName = name;
        level = playerLevel;
        health = playerHealth;
    }

    public void DisplayPlayer()
    {
        Console.WriteLine("\nPlayer Information");
        Console.WriteLine("Name: " + playerName);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Health: " + health);
    }
}

class Student
{
    public string studentName;
    public int age;

    public Student(string name, int studentAge)
    {
        studentName = name;
        age = studentAge;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("\nStudent Information");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + age);
    }
}

class BankAccount
{
    public string ownerName;
    public double balance;

    public BankAccount(string owner, double startingBalance)
    {
        ownerName = owner;
        balance = startingBalance;
    }

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

    public Weapon(string name, int weaponDamage)
    {
        weaponName = name;
        damage = weaponDamage;
    }

    public void DisplayWeapon()
    {
        Console.WriteLine("\nWeapon Information");
        Console.WriteLine("Name: " + weaponName);
        Console.WriteLine("Damage: " + damage);
    }
}

class Enemy
{
    public string enemyName;
    public int health;

    public Enemy()
    {
        enemyName = "Unknown Enemy";
        health = 100;
    }

    public Enemy(string name)
    {
        enemyName = name;
        health = 100;
    }

    public Enemy(string name, int enemyHealth)
    {
        enemyName = name;
        health = enemyHealth;
    }

    public void DisplayEnemy()
    {
        Console.WriteLine("\nEnemy Information");
        Console.WriteLine("Name: " + enemyName);
        Console.WriteLine("Health: " + health);
    }
}

class Character
{
    public string characterName;
    public int level;

    public Character(string name, int characterLevel)
    {
        characterName = name;
        level = characterLevel;
    }

    public void DisplayCharacter()
    {
        Console.WriteLine("Character: " + characterName);
        Console.WriteLine("Level: " + level);
    }
}

class Quest
{
    public string questName;
    public int rewardGold;

    public Quest(string name, int gold)
    {
        questName = name;
        rewardGold = gold;
    }

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
