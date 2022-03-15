using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(answer =="yes" || answer =="yeah" || answer =="ya" || answer =="y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackJackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing BlackJack!");
            }

            Console.WriteLine("Feel free to look around the Casino! Bye for now.");
            Console.ReadLine();
        }
    }
}
