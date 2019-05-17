
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
    /// Indicates whether the semantic action is starting, continuing, or done
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Indicates whether the semantic action is starting, continuing, or done")]
    public enum state {
       [EnumMember(Value="start")]
       start,
       [EnumMember(Value="continue")]
       @continue,
       [EnumMember(Value="done")]
       done
    }
}
