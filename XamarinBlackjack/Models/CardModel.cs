using System;
using Xamarin.Forms;
using XamarinBlackjack.Enums;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model class represting a standard playing card.
    /// </summary>
    public class CardModel
    {
        public Color Color { get; set; }
        public CardSuitEnum Suit { get; set; }
        public CardFaceValueEnum FaceValue { get; set; } // examples: Ace, 5, Queen

        public CardModel(Color color, CardSuitEnum suit, CardFaceValueEnum faceValue)
        {
            Color = color;
            Suit = suit;
            FaceValue = faceValue;
        }
    }
}
