using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinBlackjack.Controllers;
using XamarinBlackjack.Models;
using XamarinBlackjack.Models.PlayerModels;
using XamarinBlackjack.Tools;

namespace XamarinBlackjack
{
    public partial class GamePage : ContentPage
    {
        // Game controller (handles game logic)
        private IGameController controller { get; set; }

        // Player objects (data models without behaviors). Computer and User players.
        private ComputerPlayerModel dealerPlayer;
        private UserPlayerModel userPlayer { get; set; }

        /// <summary>
        /// Player's current active Hand. (Required because the player can have multiple hands after a split)
        /// </summary>
        private HandModel ActiveHandPlayer { get; set; }

        // UI Frames
        private Frame dealerFrame { get; set; }
        private Frame middleFrame { get; set; } // middle frame has the deck
        private Frame playerFrame { get; set; } // player's hand(s)
        private Frame actionFrame { get; set; } // frame with buttons for player actions

        public GamePage()
        {
            InitializeComponent();
            SetUpNewGame();
            DealOutRound(); // deal the starting cards

        }
        private void DealOutRound()
        {
            // TO DO: Consider putting this logic in GameController, not here
            // TO DO: It's too tightly coupled (View logic + Business logic coupling)
            int numOfCardsToDealAtTheStart = 2;

            // deal cards to dealer
            for (int i = 0; i < numOfCardsToDealAtTheStart - 1; i++)
            {
                var card = controller.DrawTopCardIntoHand(dealerPlayer.Hand);
                DrawCardToFrame(card, dealerFrame, DealerFrameLabel);
            }
            MiddleFrameDealerValueLabel.Text = $"Dealer hand value: {HandTools.CalculateHandValue(userPlayer.Hands[0])}";


            // deal cards to player
            for (int i = 0; i < numOfCardsToDealAtTheStart - 1; i++)
            {
                var card = controller.DrawTopCardIntoHand(userPlayer.Hands[0]);
                DrawCardToFrame(card, playerFrame, PlayerFrameLabel);
            }
                MiddleFramePlayerValueLabel.Text = $"Player hand value: {HandTools.CalculateHandValue(userPlayer.Hands[0])}";

        }
        private void SetUpNewGame()
        {
            controller = new GameController();
            controller.Dealer = dealerPlayer = new ComputerPlayerModel();
            controller.Player = userPlayer = new UserPlayerModel();

            controller.SetupGame(numberOfDecks: 3);
            dealerPlayer = controller.Dealer;
            userPlayer = controller.Player;
            DealOutRound();
        }

        private void DrawCardToFrame(CardModel card, Frame frame, Label label)
        {
            string value = card.FaceValue.ToString();
            string suit = card.Suit.ToString();

            bool isEmpty = string.IsNullOrEmpty(label.Text);
            string optionalNewLine = isEmpty ? "" : System.Environment.NewLine;
            string text = $"{optionalNewLine}{value} of {suit}";
            label.Text += text;
        }

        void HitButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var card = controller.DrawTopCardIntoHand(userPlayer.Hands[0]);
            DrawCardToFrame(card, playerFrame, PlayerFrameLabel);
            MiddleFramePlayerValueLabel.Text = $"Player hand value: {HandTools.CalculateHandValue(userPlayer.Hands[0])}";
        }
    }
}
