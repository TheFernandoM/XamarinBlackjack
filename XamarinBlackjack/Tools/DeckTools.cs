using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Tools
{
    public static class DeckTools
    {
        [Obsolete("Made obsolete by GenericShuffler class. Use that instead")]
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
                    j = rand.Next(0, deckSize + 1);
                }
                // swap positions of the two cards
                CardModel temp = deck.Cards[i];
                deck.Cards[i] = deck.Cards[j];
                deck.Cards[j] = temp;
            }
            return deck;
        }
        /// <summary>
        /// Fills a deck with 52 cards, unshuffled.
        /// </summary>
        public static Deck FillDeckWithUnshuffledCards(Deck deck)
        {
            foreach (CardSuitEnum suit in Enum.GetValues(typeof(CardSuitEnum)))
            {
                foreach (CardFaceValueEnum faceValue in Enum.GetValues(typeof(CardFaceValueEnum)))
                {
                    Color color;
                    switch (suit)
                    {
                        case CardSuitEnum.CLUBS:
                            color = Color.Black;
                            break;
                        case CardSuitEnum.SPADES:
                            color = Color.Black;
                            break;
                        case CardSuitEnum.HEARTS:
                            color = Color.Black;
                            break;
                        case CardSuitEnum.DIAMONDS:
                            color = Color.Black;
                            break;
                        default:
                            color = Color.Green;
                            break;
                    }
                    deck.Cards.Add(new CardModel(color, suit, faceValue));
                }
            }
            return deck;
        }
        /// <summary>
        /// Merge two or more decks together.
        /// <br></br>
        /// This method works by merging all the cards of the decks into the first deck of the list.
        /// </summary>
        public static Deck MergeDecks(List<Deck> decks)
        {
            // Start at index 1 on purpose
            for(int i = 1; i < decks.Count; i++)
            {
                foreach(CardModel card in decks[i].Cards)
                {
                    decks[0].Cards.Add(card);
                }
            }
            return decks[0];
        }
    }
}
