```csharp
using System;

namespace EventsTaskSolutions
{
    class ScoreEventArgs : EventArgs
    {
        public int Score { get; set; }
    }

    class HealthEventArgs : EventArgs
    {
        public int CurrentHealth { get; set; }
    }

    class ItemEventArgs : EventArgs
    {
        public string ItemName { get; set; }
    }

    class LoginEventArgs : EventArgs
    {
        public string Username { get; set; }
    }

    class QuestEventArgs : EventArgs
    {
        public string QuestName { get; set; }
    }

    class PurchaseEventArgs : EventArgs
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
    }

    class Button
    {
        public event Action OnClick;

        public void Click()
        {
            OnClick?.Invoke();
        }
    }

    class GameStarter
    {
        public event Action OnGameStart;

        public void StartGame()
        {
            OnGameStart?.Invoke();
        }
    }

    class NotificationSystem
    {
        public event Action OnNotification;

        public void SendNotification()
        {
            OnNotification?.Invoke();
        }
    }

    class Player
    {
        public event Action OnAttack;
        public event Action OnLevelUp;
        public event Action OnDeath;

        public void Attack()
        {
            Console.WriteLine("Player attacked.");
            OnAttack?.Invoke();
        }

        public void LevelUp()
        {
            Console.WriteLine("Player leveled up.");
            OnLevelUp?.Invoke();
        }

        public void Die()
        {
            Console.WriteLine("Player died.");
            OnDeath?.Invoke();
        }
    }

    class PlayerLevel
    {
        public event Action OnLevelUp;

        public void LevelUp()
        {
            OnLevelUp?.Invoke();
        }
    }

    class GameManager
    {
        public event EventHandler OnGameOver;

        public void GameOver()
        {
            OnGameOver?.Invoke(this, EventArgs.Empty);
        }
    }

    class ScoreSystem
    {
        public event EventHandler<ScoreEventArgs> OnScoreChanged;

        public void AddScore(int score)
        {
            OnScoreChanged?.Invoke(
                this,
                new ScoreEventArgs
                {
                    Score = score
                });
        }
    }

    class HealthSystem
    {
        public event EventHandler<HealthEventArgs> OnHealthChanged;

        public int CurrentHealth { get; private set; } = 100;

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }

            OnHealthChanged?.Invoke(
                this,
                new HealthEventArgs
                {
                    CurrentHealth = CurrentHealth
                });
        }
    }

    class Inventory
    {
        public event EventHandler<ItemEventArgs> OnItemCollected;

        public void CollectItem(string itemName)
        {
            OnItemCollected?.Invoke(
                this,
                new ItemEventArgs
                {
                    ItemName = itemName
                });
        }
    }

    class Enemy
    {
        public event Action OnEnemyDefeated;

        public void Defeat()
        {
            Console.WriteLine("Enemy defeated.");
            OnEnemyDefeated?.Invoke();
        }
    }

    class UserAccount
    {
        public event EventHandler<LoginEventArgs> OnLogin;

        public void Login(string username)
        {
            OnLogin?.Invoke(
                this,
                new LoginEventArgs
                {
                    Username = username
                });
        }
    }

    class FileDownloader
    {
        public event Action OnDownloadComplete;

        public void DownloadFile()
        {
            Console.WriteLine("Downloading file...");
            Console.WriteLine("Download complete.");

            OnDownloadComplete?.Invoke();
        }
    }

    class Quest
    {
        public event EventHandler<QuestEventArgs> OnQuestCompleted;

        public void CompleteQuest(string questName)
        {
            OnQuestCompleted?.Invoke(
                this,
                new QuestEventArgs
                {
                    QuestName = questName
                });
        }
    }

    class Shop
    {
        public event EventHandler<PurchaseEventArgs> OnItemPurchased;

        public void PurchaseItem(string itemName, double price)
        {
            OnItemPurchased?.Invoke(
                this,
                new PurchaseEventArgs
                {
                    ItemName = itemName,
                    Price = price
                });
        }
    }

    class Program
    {
        static void ShowButtonMessage()
        {
            Console.WriteLine("Button was clicked.");
        }

        static void LoadPlayerData()
        {
            Console.WriteLine("Player data loaded.");
        }

        static void LoadWorld()
        {
            Console.WriteLine("World loaded.");
        }

        static void PlayStartMusic()
        {
            Console.WriteLine("Start music played.");
        }

        static void ShowNotification()
        {
            Console.WriteLine("Notification displayed.");
        }

        static void PlayNotificationSound()
        {
            Console.WriteLine("Notification sound played.");
        }

        static void ShowAttackMessage()
        {
            Console.WriteLine("UI shows attack message.");
        }

        static void ShowLevelUpMessage()
        {
            Console.WriteLine("UI shows level up message.");
        }

        static void PlayLevelUpSound()
        {
            Console.WriteLine("Level up sound played.");
        }

        static void ShowGameOver(object sender, EventArgs e)
        {
            Console.WriteLine("Game Over");
        }

        static void ShowScore(object sender, ScoreEventArgs e)
        {
            Console.WriteLine($"Score changed: {e.Score}");
        }

        static void ShowHealth(object sender, HealthEventArgs e)
        {
            Console.WriteLine($"Current Health: {e.CurrentHealth}");
        }

        static void ShowCollectedItem(object sender, ItemEventArgs e)
        {
            Console.WriteLine($"Collected Item: {e.ItemName}");
        }

        static void GiveXP()
        {
            Console.WriteLine("XP given to player.");
        }

        static void DropLoot()
        {
            Console.WriteLine("Loot dropped.");
        }

        static void WelcomeUser(object sender, LoginEventArgs e)
        {
            Console.WriteLine($"Welcome, {e.Username}.");
        }

        static void ShowDownloadComplete()
        {
            Console.WriteLine("File download finished successfully.");
        }

        static void ShowQuestCompleted(object sender, QuestEventArgs e)
        {
            Console.WriteLine($"Quest Completed: {e.QuestName}");
        }

        static void ShowPurchase(object sender, PurchaseEventArgs e)
        {
            Console.WriteLine($"Purchased: {e.ItemName} | Price: ${e.Price}");
        }

        static void PlayAttackSound()
        {
            Console.WriteLine("Attack sound played.");
        }

        static void UnlockLevelAchievement()
        {
            Console.WriteLine("Level achievement unlocked.");
        }

        static void ShowDeathScreen()
        {
            Console.WriteLine("Death screen displayed.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 1: BASIC EVENT");
            Console.WriteLine("=========================================");

            Button button = new Button();

            button.OnClick += ShowButtonMessage;

            button.Click();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 2: MULTIPLE SUBSCRIBERS");
            Console.WriteLine("=========================================");

            GameStarter gameStarter = new GameStarter();

            gameStarter.OnGameStart += LoadPlayerData;
            gameStarter.OnGameStart += LoadWorld;
            gameStarter.OnGameStart += PlayStartMusic;

            gameStarter.StartGame();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 3: UNSUBSCRIBE FROM EVENT");
            Console.WriteLine("=========================================");

            NotificationSystem notificationSystem = new NotificationSystem();

            notificationSystem.OnNotification += ShowNotification;
            notificationSystem.OnNotification += PlayNotificationSound;

            notificationSystem.SendNotification();

            Console.WriteLine("After unsubscribe:");

            notificationSystem.OnNotification -= PlayNotificationSound;

            notificationSystem.SendNotification();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 4: ACTION WITH EVENTS");
            Console.WriteLine("=========================================");

            Player attackPlayer = new Player();

            attackPlayer.OnAttack += ShowAttackMessage;

            attackPlayer.Attack();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 5: LEVEL UP EVENT");
            Console.WriteLine("=========================================");

            PlayerLevel playerLevel = new PlayerLevel();

            playerLevel.OnLevelUp += ShowLevelUpMessage;
            playerLevel.OnLevelUp += PlayLevelUpSound;

            playerLevel.LevelUp();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 6: EVENTHANDLER");
            Console.WriteLine("=========================================");

            GameManager gameManager = new GameManager();

            gameManager.OnGameOver += ShowGameOver;

            gameManager.GameOver();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 7: CUSTOM EVENTARGS");
            Console.WriteLine("=========================================");

            ScoreSystem scoreSystem = new ScoreSystem();

            scoreSystem.OnScoreChanged += ShowScore;

            scoreSystem.AddScore(500);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 8: HEALTH CHANGE EVENT");
            Console.WriteLine("=========================================");

            HealthSystem healthSystem = new HealthSystem();

            healthSystem.OnHealthChanged += ShowHealth;

            healthSystem.TakeDamage(25);
            healthSystem.TakeDamage(40);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 9: ITEM COLLECTED EVENT");
            Console.WriteLine("=========================================");

            Inventory inventory = new Inventory();

            inventory.OnItemCollected += ShowCollectedItem;

            inventory.CollectItem("Iron Sword");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 10: ENEMY DEFEATED EVENT");
            Console.WriteLine("=========================================");

            Enemy enemy = new Enemy();

            enemy.OnEnemyDefeated += GiveXP;
            enemy.OnEnemyDefeated += DropLoot;

            enemy.Defeat();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 11: LOGIN EVENT");
            Console.WriteLine("=========================================");

            UserAccount userAccount = new UserAccount();

            userAccount.OnLogin += WelcomeUser;

            userAccount.Login("Peyman");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 12: DOWNLOAD COMPLETE EVENT");
            Console.WriteLine("=========================================");

            FileDownloader fileDownloader = new FileDownloader();

            fileDownloader.OnDownloadComplete += ShowDownloadComplete;

            fileDownloader.DownloadFile();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 13: QUEST COMPLETED EVENT");
            Console.WriteLine("=========================================");

            Quest quest = new Quest();

            quest.OnQuestCompleted += ShowQuestCompleted;

            quest.CompleteQuest("Find the Ancient Key");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 14: SHOP PURCHASE EVENT");
            Console.WriteLine("=========================================");

            Shop shop = new Shop();

            shop.OnItemPurchased += ShowPurchase;

            shop.PurchaseItem("Health Potion", 25.99);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("TASK 15: COMPLETE EVENT SYSTEM");
            Console.WriteLine("=========================================");

            Player completePlayer = new Player();

            completePlayer.OnAttack += ShowAttackMessage;
            completePlayer.OnAttack += PlayAttackSound;

            completePlayer.OnLevelUp += ShowLevelUpMessage;
            completePlayer.OnLevelUp += UnlockLevelAchievement;

            completePlayer.OnDeath += ShowDeathScreen;

            completePlayer.Attack();
            completePlayer.LevelUp();
            completePlayer.Die();

            Console.WriteLine();

            Console.WriteLine("Events Task Solutions Completed!");
        }
    }
}

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
