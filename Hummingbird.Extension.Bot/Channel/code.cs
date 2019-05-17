
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
    /// Codes indicating why a conversation has ended
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Codes indicating why a conversation has ended")]
    public enum code {
       [EnumMember(Value="unknown")]
       unknown,
       [EnumMember(Value="completedSuccessfully")]
       completedSuccessfully,
       [EnumMember(Value="userCancelled")]
       userCancelled,
       [EnumMember(Value="botTimedOut")]
       botTimedOut,
       [EnumMember(Value="botIssuedInvalidMessage")]
       botIssuedInvalidMessage,
       [EnumMember(Value="channelFailed")]
       channelFailed
    }
}
