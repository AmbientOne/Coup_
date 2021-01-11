using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Coup
{
    public class Game
    {
        
        private static Random rng = new Random();
        
         public List<string> cards = new List<string>()
        {
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin",
            "Captain", "Ambassador", "Contessa", "Duke", "Assassin"
        };
        
        public Game()
        {
            
            
        }

        public string randomCard()
        {

            return cards[rng.Next(cards.Count)];
        }
        public  void printList()
        {

            foreach (var card in cards)
            {
                Console.WriteLine(card + " ");
            }

            
            
        }
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


        public void showTopCards()
        {
            Console.WriteLine(cards[0] + " " + cards[1]);
        }
        public static void menu()
        {
            Console.WriteLine("-------------------------------");
            
            
            
            
            
            

            Console.WriteLine("-------------------------------");
        }

        /*
         * Main menu:
         * Needs a way to target players
         * See other players cards
         * See current players cards and coins
         * Option List for the player
         *
         */
    }
}