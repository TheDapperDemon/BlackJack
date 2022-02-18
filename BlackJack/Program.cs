using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BlackJackGame game = new BlackJackGame();
            //game.Players = new List<Player>() { "Jonah", "Jeff", "Hakon" };
            //game.Play();
            Game game = new BlackJackGame();
            game.ListPlayers();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Hakon";
            game += player;
            game -= player;
            Console.ReadLine();


            Deck deck = new Deck();
            deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
