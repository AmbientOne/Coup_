using System;
using System.Collections.Generic;
namespace Coup
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            
            Game game = new Game();
            game.mainScreen();

            Console.WriteLine(game.currentPlayer());


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