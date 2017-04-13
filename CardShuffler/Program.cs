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
            ArrayList deck = createDeck();

            foreach (string card in deck)
            {
                Console.Write(card + ", ");
            }
            Console.Write("\n");
            Console.WriteLine(deck.Count);

            shuffleDeck(deck);

            foreach (string card in deck)
            {
                Console.Write(card + ", ");
            }
            Console.Write("\n");
            Console.WriteLine(deck.Count);
        }
        static public void shuffleDeck(ArrayList arrlist)
        {
            Random r = new Random();

            for (int i = 0; i < arrlist.Count; i++)
            {
                object tmp = arrlist[i];
                int idx = r.Next(arrlist.Count - i) + i;
                arrlist[i] = arrlist[idx];
                arrlist[idx] = tmp;
            }
        }

        static public ArrayList createDeck()
        {
            string[] suits = { "H", "D", "S", "C" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            ArrayList deck = new ArrayList();

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    deck.Add(value + suit);
                }
            }

            return deck;
        }
    }
}
