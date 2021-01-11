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
        Dictionary<int, string> map = new Dictionary<int, string>();
        public Player(string startingCard1, string startingCard2)
        {
            map.Add(1, startingCard1);
            map.Add(1, startingCard2);
            Coins += 2;
            
        }
        
        
        
    }
}