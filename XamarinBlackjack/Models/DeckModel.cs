using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinBlackjack.Enums;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model class representing a  deck of playing cards.
    /// </summary>
    public class Deck
    {
        public List<CardModel> Cards { get; } = new List<CardModel>();
    }
}
