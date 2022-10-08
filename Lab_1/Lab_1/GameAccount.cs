
using System;
using System.Collections.Generic;

namespace Lab_1
{
    internal class GameAccount
    {
        public string UserName { get; }
        public int CurrentRating 
        {
            get
            {
                int rating = 1;
                foreach(var item in AllGames)
                {
                    rating += item.Rating;
                }
                return rating;
            }
        }
        public int GamesCount 
        {
            get
            {
                return AllGames.Count;
            }
        }
        private static List<string> AllNames = new List<string>();
        public List<Games> AllGames = new List<Games>();

        public GameAccount(string name)
        {
            if (AllNames.Contains(name))
            {
                throw new ArgumentException("This name is unavailable");
            }
            UserName = name;
            AllNames.Add(name);
        }

        public void WinGame(GameAccount opponent, int rating)
        {
            if(rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Games(true, rating, this, opponent);
            AllGames.Add(game);

            opponent.LoseGame(this, rating);
        }

        public void LoseGame(GameAccount opponent, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            opponent.WinGame(this, rating);
            // стоїть першим, бо далі rating змінюється

            if (CurrentRating <= rating)
            {
                rating = CurrentRating - 1;
                //завжди залишиться одиниця
            }
            var game = new Games(false, -rating, this, opponent);
            AllGames.Add(game);
        }

        public string GetStats()
        {
            var stats = new System.Text.StringBuilder();

            stats.AppendLine("ID\tResult\tRating\tOpponent");
            foreach(var item in AllGames)
            {
                int rating = item.IsWin ? item.Rating : -item.Rating;
                string winOrLose = item.IsWin ? "Win" : "Lose";
                stats.AppendLine($"{item.GameIndex}\t{item.IsWin}\t{rating}\t{item.Opponent}");
            }

            return stats.ToString();
        }
    }
}
