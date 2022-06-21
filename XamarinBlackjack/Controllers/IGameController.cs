using System;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;
using XamarinBlackjack.Models.PlayerModels;

namespace XamarinBlackjack.Controllers
{
    interface IGameController
    {
        // === PROPERTIES ===

        /// <summary>
        /// The deck of cards that all players draw from
        /// </summary>
        Deck Deck { get; set; }

        /// <summary>
        /// User player
        /// </summary>
        UserPlayerModel Player { get; set; }

        /// <summary>
        /// Computer player (Dealer)
        /// </summary>
        ComputerPlayerModel Dealer { get; set; }

        /// <summary>
        /// Discard pile is actually a deck too
        /// </summary>
        Deck DiscardDeck { get; set; } 

        // === METHODS ===

        CardModel DrawTopCardIntoHand(HandModel hand);

        void SetupGame(int numberOfDecks);

        void ResetGame();

        void StartGame();

        void EnactPlayerAction(PlayerActionEnum playerAction);
    }
}
