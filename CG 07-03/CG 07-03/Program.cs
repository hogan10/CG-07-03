using System;

namespace CG_7_3
{
    class Program
    {

        //this is the main program and the deck and card.cs are the classes 
        //we call the classes from the main program. THis helps to keep the code clean
        static void Main(string[] args)
        {

            //call class deck to generate a random card, 
            Deck deck = new Deck(52);
            int counter = 0;

            for (int i = 2; i < 14; i++)
            {
                for (int j = 1; j <= 4; j++)

                {
                    string face;
                    if (i < 11) face = i.ToString();
                    else if (i == 11) face = "Jack";
                    else if (i == 12) face = "Queen";
                    else if (i == 13) face = "King";
                    else face = "Ace";

                    string suit;
                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Clubs";
                    else if (j == 3) suit = "Diamonds";
                    else suit = "Spades";

                    //call the card class to return the full value of the randomly generated card --> face and suit
                    deck.Cards[counter] = new Card

                    {
                        face = face,
                        suit = suit
                    };
                    counter++;
                }
            }

            var card = deck.Draw();
            Console.WriteLine(card.GetFullName());

            Console.ReadLine();
        }
    }
}