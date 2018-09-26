using System;
using System.Collections.Generic;
using System.Text;

namespace CG_7_3
{
    //setting to public allows you to call the class 
    //it increases the scope
    public class Deck
    {
        public Card[] Cards { get; set; }

        public Deck(int numberofcards)
        {
            Cards = new Card[numberofcards];
        }

        public Card Draw()
        {
            var rnd = new Random();
            var number = rnd.Next(Cards.Length);
            return Cards[number];
        }
    }
}