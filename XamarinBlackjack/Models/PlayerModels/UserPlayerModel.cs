using System;
namespace XamarinBlackjack.Models
{
    /// <summary>
    /// Data model class representing a User-controllable player object.
    /// </summary>
    public class UserPlayerModel : BasePlayerModel
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
