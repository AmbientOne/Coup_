using System;
using System.Collections.Generic;

namespace Coup
{
    public class Game
    {
        //Random generator
        private static Random rng = new Random();
        //Storage for players
        public Queue<Player> playr = new Queue<Player>();
        
        //Initial List of cards, mutable only when exchanging, shuffling card back into deck
         private List<string> cards = new List<string>()
        {
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin"
        };
        //Constructor for Game
        public Game()
        {
            
            
        }
        /*
         * Returns a random card
         * TO DO: Make sure it removes it from deck after randomizing
         */
        public string randomCard()
        {

            return cards[rng.Next(cards.Count)];
        }
        
        /*
         * Test function
         */
        public void printList()
        {

            foreach (var card in cards)
            {
                Console.WriteLine(card + " ");
            }

            
            
        }
        
        /*
         * Fisher-Yates shuffle  
         */
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;



            }
        }
    
        /*
         * Function to see if shuffle is working successfully
         * TO DO: Edit to add accessibility for exchanging
         */
        public void showTopCards()
        {
            Console.WriteLine(cards[0] + " " + cards[1]);
        }
        
        
        /*
         * Main menu:
         * Add players:
         *  Minimum of 2:
         *  
         * Track players (Who's turn is it?)
         *         - Queue system? Store them in a queue and deque and requeue
         *         - List?(Store in a list and move to the back/remove if both influences revealed?
         * Needs a way to target players
         *         -Number system? Id System?
         *       
         * See other player cards (revealed, not revealed)
         *         -Negative key implies revealed
         *         -Positive key implies hidden
         * See current players cards and coins
         *         -Main menu should show current players influences and coins
         *         -Must have functionality to FORCE coup if player has >=10 coins
         */
        public static void menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            
            
            
            
            

            Console.WriteLine("-------------------------------");
        }

        /*
         * Main Menu screen: Introduces players and adds their name to a queue
         * Needs user input verification to avoid errors
         * 
         */
        public void mainScreen()
        {
            Console.WriteLine("How many players?");
            string playerCount_ = Console.ReadLine();
            int playerCount = Convert.ToInt32(playerCount_);
            int plyerCount = playerCount;
            while (playerCount != 0)
            {
                Console.WriteLine("What is player {0}'s name?", (playerCount*-1) + (plyerCount+1));
                string name = Console.ReadLine();
                Player temp = new Player(name, randomCard(), randomCard());
                playr.Enqueue(temp);
                playerCount--;
            }
        }
    }
}