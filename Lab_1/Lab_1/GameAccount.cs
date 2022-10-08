
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
            //adding a win game for this

            rating = MinusRating(opponent.CurrentRating, rating);
            game = new Games(false, rating, opponent, this);
            opponent.AllGames.Add(game);
            //adding a lose game for opponent
        }

        public void LoseGame(GameAccount opponent, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Games(true, rating, opponent, this);
            opponent.AllGames.Add(game);
            // стоїть першим, бо далі rating змінюється
            //adding a win game for this

            rating = MinusRating(CurrentRating, rating);
            game = new Games(false, rating, this, opponent);
            AllGames.Add(game);
        }

        private static int MinusRating(int currentRating, int rating)
        {
            //this method controles rating to be >= 1
            if (currentRating <= rating)
            {
                return 1 - currentRating;
                //завжди залишиться одиниця
            }
            return -rating;
        }

        public string GetStats()
        {
            var stats = new System.Text.StringBuilder();
            int wholeRaiting = 1;
            int gameCount = 0;
            
            stats.AppendLine("Game statistics of " + this.UserName);
            stats.AppendLine("ID\tGame number\tResult\tRating\tChange\tOpponent");
            foreach(var item in AllGames)
            {
                gameCount++;
                wholeRaiting += item.Rating;
                string rating = item.IsWin ? ("+" + item.Rating) : item.Rating.ToString();
                if (rating == "0" && !item.IsWin)
                {
                    rating = "-0";
                }
                string winOrLose = item.IsWin ? "Win" : "Lose";
                stats.AppendLine($"{item.GameIndex}\t{gameCount}\t" +
                    $"\t{winOrLose}\t{wholeRaiting}\t{rating}\t{item.Opponent.UserName}");
            }

            return stats.ToString();
        }
    }
}
