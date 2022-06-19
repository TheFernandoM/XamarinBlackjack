using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model class representing a player's hand of cards. A "hand of cards"
    /// is the same as saying a collection of cards (in this case specifically: a list)
    /// </summary>
    public class HandModel
    {
        public List<CardModel> Cards { get; set; }
    }
}
