using System;
using System.Collections;

namespace CardShuffler
{
    public class Deck
    {
        private string[] suits = { "H", "D", "S", "C" };
        private string[] values = { "2", "3", "4", "5", "6", "7", "8",
            "9", "10", "J", "Q", "K", "A" };

        private ArrayList cards = new ArrayList();

        public Deck(bool shuffled=false) 
        {
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    this.cards.Add(value + suit);
                }
            }

            if (shuffled) {
                this.shuffle();
            }

        }

        public Deck shuffle()
        {
            Random r = new Random();

            for (int i = 0; i < this.cards.Count; i++)
            {
                object tmp = this.cards[i];
                int idx = r.Next(this.cards.Count - i) + i;
                this.cards[i] = this.cards[idx];
                this.cards[idx] = tmp;
            }

            // Returns the current instance so it can be chained
            return this;
        }

        public void print()
        {
            foreach (string card in this.cards)
            {
                Console.Write(card + " ");
            }
            Console.Write("\n");
            Console.WriteLine("Total cards in deck: " + this.cards.Count);
        }
    }
}
