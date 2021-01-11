using System;
using System.Collections.Generic;


/*
 * Revealed = -1
 * Hidden = 1
 */
namespace Coup
{
    public class Player
    {
        //Current coins
        protected int Coins = 0;
        
        //Player Name
        protected string playerName;
        
        //Player's influences/cards
        protected Dictionary<int, string> map = new Dictionary<int, string>();
        
        /*
         * Constructor for players and for auto adding players starting cards
         * 
         */
        public Player(string player, string startingCard1, string startingCard2)
        {
            this.playerName = player;
            map.Add(1, startingCard1);
            map.Add(2, startingCard2);
            Coins += 2;
            
        }

        public void getFirstInfluence()
        {
            foreach (KeyValuePair<int, string> kvp in map)
            {
                Console.WriteLine("Influence {0} is: {1}", kvp.Key, kvp.Value);
            }

        }
        
        
        
        
        
        
        
    }
}