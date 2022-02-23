using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by entering your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much Money did your bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a Black Jack Game right now?");
            string answer = Console.ReadLine().ToLower();
            if (answer =="yes" || answer =="yeah" || answer =="ya" || answer =="y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackJackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
            }

            //BlackJackGame game = new BlackJackGame();
            //game.Players = new List<Player>() { "Jonah", "Jeff", "Hakon" };
            //game.Play();
            //Game game = new BlackJackGame();
            //game.ListPlayers();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Hakon";
            //game += player;
            //game -= player;
            //Console.ReadLine();

            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);
            //Console.ReadLine();

            //Card card1 = new Card();
            //Card card2 = new Card();
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //deck = Shuffle(deck, 3);
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //List<int> numberList = new List<int>() { 1, 2, 3, 565, 478, 87 };
            //int sum = numberList.Sum();
            //Console.WriteLine(sum);
            //    Deck deck = new Deck();


            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " of " + card.Suit);
            //    }
            //    Console.WriteLine(deck.Cards.Count);
            //    Console.ReadLine();
            //}

            //public static Deck Shuffle(Deck deck, int times = 1)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        List<Card> TempList = new List<Card>();
            //        Random random = new Random();

            //        while (deck.Cards.Count > 0)
            //        {
            //            int randomIndex = random.Next(0, deck.Cards.Count);
            //            TempList.Add(deck.Cards[randomIndex]);
            //            deck.Cards.RemoveAt(randomIndex);
            //        }
            //        deck.Cards = TempList;
            //    }
            //    return deck;
        }
    }
}
