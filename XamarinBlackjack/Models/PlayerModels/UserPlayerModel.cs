using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Models.PlayerModels
{
    /// <summary>
    /// Data model class representing a User-controllable player object.
    /// </summary>
    public class UserPlayerModel
    {
        // Player can have multiple hands. Ex: When they split a pair of cards
        public List<HandModel> Hands { get; set; } = new List<HandModel>() { new HandModel() };
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
