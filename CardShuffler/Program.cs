using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CardShuffler
{
    class Program
    {
    
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            ArrayList cards = deck.createDeck();

            deck.writeToConsole(cards);

            deck.shuffleDeck(cards);

            deck.writeToConsole(cards);
        
        }
        
    }
}
