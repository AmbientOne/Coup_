using System;
using System.Collections.Generic;

namespace Coup
{
    public class Game
    {
        //Random generator
        private static Random rng = new Random();
        //Storage for players 
        // Queue
        public List<Player> playr = new List<Player>();

        //Initial List of cards, mutable only when exchanging, shuffling card back into deck
         private List<string> cards = new List<string>()
        {
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin"
        };

         public List<string> revealedCards = new List<string>();
         
        //Constructor for Game
        public Game()
        {
            
            
        }
        
        /*
         *Check to see if game is over
         * Checks to see if there is only one player remaining
         */

        public bool gameOver()
        {
            return playr.Count == 1;
            
        }
        /*
         *Requires 7 coins and forces player to reveal card (no counter)
         */
        public void coup(Player player)
        {
            
        }
        /*
         * Returns a random card
         * TO DO: Make sure it removes it from deck after randomizing
         */
        public string randomCard()
        {
            int i = rng.Next(cards.Count);
            string card = cards[i];
            cards.RemoveAt(i);
            return card;
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
         *Exchange, looks at top two cards in the available cards and allows for user to exchange cards
         */
        public void exchange(Player player)
        {
            Console.WriteLine("Choose which cards to exchange, when finished exit by typing -1");
            
            Console.WriteLine("Cards available: \n1: {0} \n2:{1}", cards[0], cards[1]);
            Console.WriteLine("Your cards: ");
            for (int i = 0; i < player.playersCards.Count; i++)
            {
                Console.WriteLine(player.playersCards[i]);
            }
            
            

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
        public void menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("It is currently player {0}'s turn!", playr[0].getName());
            Console.WriteLine("You currently have {0} coins!", playr[0].getCoins());
            if (playr[0].getCoins() >= 10)
            {
                Console.WriteLine("You must coup this round, choose a target!");
                for (int i = 1; i < playr.Count; i++)
                {
                    Console.WriteLine("Player {0}: {1}",i, playr[i].getName());
                    int target = Console.Read();
                    playr[target].reveal(this.playr, this.revealedCards, target);
                }
            }
            
            else
            {
                Console.WriteLine("Your options are as follows: \n" +
                                  "1: Assassinate \n" +
                                  "2: Exchange \n" +
                                  "3: Tax \n" +
                                  "4: Foreign Aid \n" +
                                  "5: Income");
                if (playr[0].getCoins() > 7)
                {
                    Console.WriteLine("6: Coup");
                }
            }
   

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
                playr.Add(temp);
                playerCount--;
            }
        }

        public string currentPlayer()
        {
            return playr[0].playerName;

        }
    }
}