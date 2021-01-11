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
        protected int Coins = 0;
        protected string playerName;
        
        
        protected Dictionary<int, string> map = new Dictionary<int, string>();
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
                Console.WriteLine("First influence is: " + kvp.Value);
            }

        }
        
        
        
        
    }
}