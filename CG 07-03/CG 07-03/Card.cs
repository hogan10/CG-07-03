using System;
using System.Collections.Generic;
using System.Text;

namespace CG_7_3
{
    public class Card
    //collect face and suit value and set them
    {
        public string face { get; set; }
        public string suit { get; set; }

        public string GetFullName()
        //return a the full name of the card to the screen
        {
            return $"{face} of {suit}";
        }
    }
}