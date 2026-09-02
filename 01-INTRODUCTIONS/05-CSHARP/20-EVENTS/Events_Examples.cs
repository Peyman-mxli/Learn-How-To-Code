```csharp
using System;

namespace EventsExamples
{
    class PlayerEventArgs : EventArgs
    {
        public string PlayerName { get; set; }
        public int Level { get; set; }
    }

    class Player
    {
        public event Action OnAttack;

        public event Action OnLevelUp;

        public event EventHandler<PlayerEventArgs> OnPlayerLevelUp;

        public void Attack()
        {
            Console.WriteLine("Player attacks.");

            OnAttack?.Invoke();
        }

        public void LevelUp()
        {
            Console.WriteLine("Player leveled up.");

            OnLevelUp?.Invoke();
        }

        public void LevelUpWithData(string playerName, int level)
        {
            Console.WriteLine("Player leveled up with event data.");

            OnPlayerLevelUp?.Invoke(
                this,
                new PlayerEventArgs
                {
                    PlayerName = playerName,
                    Level = level
                });
        }
    }

    class GameUI
    {
        public void ShowAttackMessage()
        {
            Console.WriteLine("UI: Attack message displayed.");
        }

        public void ShowLevelUpMessage()
        {
            Console.WriteLine("UI: Level up message displayed.");
        }

        public void ShowPlayerLevelUpData(object sender, PlayerEventArgs e)
        {
            Console.WriteLine(
                $"UI: {e.PlayerName} reached level {e.Level}.");
        }
    }

    class AudioSystem
    {
        public void PlayAttackSound()
        {
            Console.WriteLine("Audio: Attack sound played.");
        }

        public void PlayLevelUpSound()
        {
            Console.WriteLine("Audio: Level up sound played.");
        }
    }

    class AchievementSystem
    {
        public void UnlockLevelAchievement()
        {
            Console.WriteLine("Achievement: Level achievement unlocked.");
        }

        public void UnlockPlayerLevelAchievement(object sender, PlayerEventArgs e)
        {
            Console.WriteLine(
                $"Achievement: {e.PlayerName} unlocked a level {e.Level} achievement.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("BASIC EVENT EXAMPLE");
            Console.WriteLine("=========================================");

            Player player = new Player();

            GameUI gameUI = new GameUI();

            player.OnAttack += gameUI.ShowAttackMessage;

            player.Attack();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("MULTIPLE EVENT SUBSCRIBERS");
            Console.WriteLine("=========================================");

            AudioSystem audioSystem = new AudioSystem();

            player.OnAttack += audioSystem.PlayAttackSound;

            player.Attack();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("UNSUBSCRIBING FROM EVENTS");
            Console.WriteLine("=========================================");

            player.OnAttack -= gameUI.ShowAttackMessage;

            player.Attack();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("LEVEL UP EVENT");
            Console.WriteLine("=========================================");

            AchievementSystem achievementSystem = new AchievementSystem();

            player.OnLevelUp += gameUI.ShowLevelUpMessage;
            player.OnLevelUp += audioSystem.PlayLevelUpSound;
            player.OnLevelUp += achievementSystem.UnlockLevelAchievement;

            player.LevelUp();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("EVENTHANDLER WITH CUSTOM DATA");
            Console.WriteLine("=========================================");

            player.OnPlayerLevelUp += gameUI.ShowPlayerLevelUpData;
            player.OnPlayerLevelUp += achievementSystem.UnlockPlayerLevelAchievement;

            player.LevelUpWithData("Peyman", 10);

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("LAMBDA EVENT SUBSCRIPTION");
            Console.WriteLine("=========================================");

            player.OnLevelUp +=
                () => Console.WriteLine("Lambda: Extra level up response.");

            player.LevelUp();

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("EVENTS EXAMPLES COMPLETED");
            Console.WriteLine("=========================================");
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
