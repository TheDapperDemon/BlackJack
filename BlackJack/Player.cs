using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        public Player (string name, int beginingBalance)
        {
            Hand = new List<Card>();
            Balance = beginingBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
      
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
