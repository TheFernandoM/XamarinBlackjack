using System;
using System.Collections.Generic;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Controllers
{
    /// <summary>
    /// Game logic goes here
    /// </summary>
    public class GameController :IGameController
    {
        public List<Deck> Decks { get; set; }

        public void ResetGame()
        {
            throw new NotImplementedException();
        }

        public void SetupGame()
        {
            Decks.Add(new Deck());
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
        public int CalculateHandValue(Hand hand)
        {
            foreach(var deck in Decks)
            {
                foreach(var card in deck.Cards)
                {
                    switch (card)
                    {
                        default:
                            break;
                        //TO DO
                    }
                }
            }
            return -1; // TO DO
        }

        public void EnactPlayerAction(PlayerActionEnum playerAction)
        {
            throw new NotImplementedException();
        }
    }
}
