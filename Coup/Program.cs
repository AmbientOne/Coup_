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
            while (!game.gameOver())
            {
                game.menu();   
            }
            Console.WriteLine("Game Over!");


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