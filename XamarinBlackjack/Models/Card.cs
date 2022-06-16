using System;
using Xamarin.Forms;
using XamarinBlackjack.Enums;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model for Cards
    /// </summary>
    public class Card
    {
        public Color Color { get; set; }
        public CardSuitEnum Suit { get; set; }
        public string FaceValue { get; set; }
    }
}
