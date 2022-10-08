
using System;

namespace Lab_1
{
    internal class Games
    {
        public bool IsWin { get; }
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        private static int GameID = 28462;
        public string GameIndex { get; }

        public Games(bool isWin, int rating, GameAccount player, GameAccount opponent)
        {
            this.GameIndex = GameID.ToString();
            GameID++;
            this.IsWin = isWin;
            this.Player = player;
            this.Opponent = opponent;
            this.Rating = rating;
        }
    }
}
