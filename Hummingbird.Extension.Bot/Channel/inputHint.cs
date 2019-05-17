
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    
    ///<summary>
    /// Indicates whether the bot is accepting, expecting, or ignoring input
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Indicates whether the bot is accepting, expecting, or ignoring input")]
    public enum inputHint {
       [EnumMember(Value="acceptingInput")]
       acceptingInput,
       [EnumMember(Value="ignoringInput")]
       ignoringInput,
       [EnumMember(Value="expectingInput")]
       expectingInput
    }
}
