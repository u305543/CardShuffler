﻿using System;
using System.Collections;


namespace CardShuffler
{
    class Program
    {
    
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            deck.print();

            deck.shuffle();

            deck.print();
        
        }
        
    }
}
