
using System;

namespace Lab_1
{
    internal class Game
    {
        public bool IsWin { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        private static double GameID = 28462;
        public string GameIndex { get; }

        public Game(bool isWin, int rating, GameAccount player, GameAccount opponent)
        {
            this.GameIndex = ((int)GameID).ToString();
            GameID += 0.5;
            //this make a possibility to have the same game index for both players
            this.IsWin = isWin;
            this.Opponent = opponent;
            this.Rating = rating;
        }
    }
}
