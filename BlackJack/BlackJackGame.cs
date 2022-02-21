using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class BlackJackGame : Game 
    {

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome Black Jack Players");
            base.ListPlayers();
        }

    }
}
