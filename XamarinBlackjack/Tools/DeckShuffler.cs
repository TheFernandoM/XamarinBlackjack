using System;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Tools
{
    public static class DeckShuffler
    {
        /// <summary>
        /// Shuffles a Deck of Cards. Runtime is O(n).
        /// <br></br>
        /// This implementation is based on
        /// Wikipedia's  pseudocode description of the modern version of the
        /// Fisher-Yates shuffle.
        ///
        /// Author: Fernando Molina
        /// </summary>
        public static Deck ShuffleDeck(Deck deck)
        {
            Random rand = new Random();
            int deckSize = deck.Cards.Count;

            for(int i = deckSize-1; i > 1; i--)
            {
                int j = -1; // j here is just an index variable, like i

                while(!(0 <= j && j <= i)) // 0 ≤ j ≤ i
                {
                    // generate a random number for j until it falls between
                    // 0 and i, inclusive
                    rand.Next(0, deckSize + 1);
                }
                // swap positions of the two cards
                Card temp = deck.Cards[i];
                deck.Cards[i] = deck.Cards[j];
                deck.Cards[j] = temp;
            }
            return deck;
        }
    }
}
