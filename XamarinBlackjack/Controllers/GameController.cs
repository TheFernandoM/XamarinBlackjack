using System;
using System.Collections.Generic;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;
using XamarinBlackjack.Models.PlayerModels;
using XamarinBlackjack.Tools;

namespace XamarinBlackjack.Controllers
{
    /// <summary>
    /// Game logic goes here
    /// </summary>
    public class GameController :IGameController
    {
        public Deck Deck { get; set; } = new Deck(); // The deck of cards that all players draw from
        public UserPlayerModel Player { get; set; }
        public ComputerPlayerModel Dealer { get; set; }
        public Deck DiscardDeck { get; set; } // Discard pile is actually a deck too

        public void ResetGame()
        {
            throw new NotImplementedException();
        }

        public void SetupGame(int numberOfDecks)
        {
            for(int i = 0; i < numberOfDecks; i++)
            {
                // Merge the current deck with a new full deck of unshuffled cards.
                Deck = DeckTools.MergeDecks(new List<Deck>() { Deck, DeckTools.FillDeckWithUnshuffledCards(new Deck())});
            }
            GenericShuffler.ShuffleList<CardModel>(Deck.Cards);
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }

        public void EnactPlayerAction(PlayerActionEnum playerAction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws the next card from the top of the deck into the input hand.
        /// </summary>
        /// <param name="hand"></param>
        public CardModel DrawTopCardIntoHand(HandModel hand)
        {
            CardModel topCard = Deck.Cards[0];
            Deck.Cards.Remove(topCard);
            hand.Cards.Add(topCard);
            return topCard;
        }
    }
}
