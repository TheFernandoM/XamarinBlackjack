using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinBlackjack.Controllers;

namespace XamarinBlackjack
{
    public partial class GamePage : ContentPage
    {
        private IGameController controller { get; set; }
        private Frame dealerFrame { get; set; }
        private Frame middleFrame { get; set; }
        private Frame playerFrame { get; set; }
        private Frame actionFrame { get; set; }
        public GamePage()
        {
            InitializeComponent();

        }
        private void SetUpGame()
        {
            controller = new GameController();
            controller.SetupGame(numberOfDecks: 3);
        }
    }
}
