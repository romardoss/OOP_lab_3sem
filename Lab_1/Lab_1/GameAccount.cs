
using System;
using System.Collections.Generic;

namespace Lab_1
{
    internal class GameAccount
    {
        public string UserName { get; }
        public int CurrentRating { get; }
        public int GamesCount { get; }
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
            GamesCount = 0;
            CurrentRating = 1;
        }

        public void WinGame(GameAccount opponent, int rating)
        {
            if(rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Games(true, rating, this, opponent);
            AllGames.Add(game);
            // adding this game to this account

            game = new Games(false, rating, opponent, this); 
            opponent.AllGames.Add(game);
            // adding this game to the opponent account
        }

        public void LoseGame()
        {

        }

    }
}
