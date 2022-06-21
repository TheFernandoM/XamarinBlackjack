using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinBlackjack.Controllers;
using XamarinBlackjack.Models;
using XamarinBlackjack.Models.PlayerModels;

namespace XamarinBlackjack
{
    public partial class GamePage : ContentPage
    {
        // Game controller (handles game logic)
        private IGameController controller { get; set; }

        // Player objects (data models without behaviors). Computer and User players.
        private ComputerPlayerModel dealerPlayer;
        private UserPlayerModel userPlayer { get; set; }

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
            // TO DO: THIS SHOULD GO IN GameController, not here
            int numOfCardsToDealAtTheStart = 2;

            // deal cards to dealer
            for (int i = 0; i < numOfCardsToDealAtTheStart - 1; i++)
            {
                var card = controller.DrawTopCardIntoHand(dealerPlayer.Hand);
                DrawCardToFrame(card, dealerFrame, DealerFrameLabel);
            }

            // deal cards to player
            for (int i = 0; i < numOfCardsToDealAtTheStart - 1; i++)
            {
                var card = controller.DrawTopCardIntoHand(userPlayer.Hands[0]);
                DrawCardToFrame(card, playerFrame, PlayerFrameLabel);
            }

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
        }
    }
}
