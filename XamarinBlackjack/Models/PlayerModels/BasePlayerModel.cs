using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Models.PlayerModels
{
    /// <summary>
    /// WARNING: DEPRECATED
    /// </summary>
    [Obsolete("This class is not used. This is a case of unnecessary inheritance. " +
        "Consider deleting this class.")]
    public class BasePlayerModel
    {
        public List<HandModel> Hands { get; set; }
    }
}
