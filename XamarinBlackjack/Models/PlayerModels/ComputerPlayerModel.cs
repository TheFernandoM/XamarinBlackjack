using System;
namespace XamarinBlackjack.Models.PlayerModels
{
    /// <summary>
    /// Data model class representing a computer player
    /// </summary>
    public class ComputerPlayerModel
    {
        public HandModel Hand { get; set; } = new HandModel();
    }
}
