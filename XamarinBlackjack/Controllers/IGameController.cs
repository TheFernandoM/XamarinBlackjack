using System;
using XamarinBlackjack.Enums;
using XamarinBlackjack.Models;

namespace XamarinBlackjack.Controllers
{
    public interface IGameController
    {
        public void SetupGame();

        public void ResetGame();

        public void StartGame();

        public int CalculateHandValue(Hand hand);

        public void EnactPlayerAction(PlayerActionEnum playerAction);
    }
}
