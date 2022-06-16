using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model representing a Player and its properties
    /// </summary>
    public class Player
    {
        // Player can have multiple hands. Ex: When they split a pair of cards
        List<Hand> Hands { get; set; }
        decimal Balance { get; set; }
        string Name { get; set; }
    }
}
