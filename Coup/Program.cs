using System;
using System.Collections.Generic;
namespace Coup
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Game game = new Game();
            Player first = new Player("Abdi", game.randomCard(), game.randomCard());
            game.Shuffle();
            first.getFirstInfluence();
            game.showTopCards();
        }
    
    }
}





/*
 
 Storage of Cards:
    List
    
Classes:

Player:
Will keep track of players gold, cards, 


Game:
Will have game menu



        
*/