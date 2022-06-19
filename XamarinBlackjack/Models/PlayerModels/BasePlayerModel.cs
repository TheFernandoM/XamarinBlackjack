using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model representing a Player and its properties
    /// </summary>
    public class BasePlayerModel
    {
        // Player can have multiple hands. Ex: When they split a pair of cards
        public List<HandModel> Hands { get; set; }
    }
}
