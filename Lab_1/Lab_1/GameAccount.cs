
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
    }
}
