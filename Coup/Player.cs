using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;



namespace Coup
{
    public class Player
    {
        //Current coins
        protected int Coins = 0;
        
        //Player Name
        public string playerName;
        
        //Game file
        
        //Player's influences/cards
        public List<string> playersCards = new List<string>();
        
        /*
         * Constructor for players and for auto adding players starting cards
         * 
         */
        public Player(string player, string startingCard1, string startingCard2)
        {
            playerName = player;
            playersCards.Add(startingCard1);
            playersCards.Add(startingCard2);
            Coins += 2;
            
        }
        /*
         *Coins getter
         */
        public int getCoins()
        {
            return Coins;
        }
        public void getInfluences()
        {
            for(int i = 0; i<playersCards.Count; i++)
            {
                Console.WriteLine("Influence {0} is: {1}", i, playersCards[i]);
            }

        }
        /*
         *Getter for a players name
         */
        public string getName()
        {
            return playerName;
        }
        
        /*
         * Revealing a card for a player
         * This function allows for the user to choose which card to reveal if they have 2 else forcefully removes last remaining card
         * This function also allows for user to automatically be removed from queue if they are out of cards
         */
        public void reveal(List<Player> players, List<string> revealedCards, int spotInQueue)
        {
            if (playersCards.Count > 1)
            {
                Console.WriteLine("You've been forced to reveal a card! \n" +
                                  "Choose from the following: \n");
                for(int i = 0; i<playersCards.Count; i++)
                {
                    Console.WriteLine("Influence {0} is: {1}", i, playersCards[i]);
                }

                int choice = Console.Read();
                while (choice > playersCards.Count || choice < 1)
                {
                    Console.WriteLine("That's not an option, try again!");
                    choice = Console.Read();
                    
                }

                choice--;
                revealedCards.Add(playersCards[choice]);
                playersCards.RemoveAt(choice);
                
            }
            else
            {
                Console.WriteLine("Oh no, you have no cards left! Game Over!");
                revealedCards.Add(playersCards[0]);
                playersCards.RemoveAt(0);
                players.RemoveAt(spotInQueue);

            }
            
            
        }
        
        
        
        
        
        
        
    }
}