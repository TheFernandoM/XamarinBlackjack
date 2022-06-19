using System;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Controllers
{
    public interface IGameController
    {
        void DrawTopCardIntoHand(HandModel hand);

        void SetupGame(int numberOfDecks);

        void ResetGame();

        void StartGame();

        void EnactPlayerAction(PlayerActionEnum playerAction);
    }
}
