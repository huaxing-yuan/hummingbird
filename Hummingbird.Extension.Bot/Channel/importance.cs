
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
    /// Defines the importance of an Activity
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Defines the importance of an Activity")]
    public enum importance {
       [EnumMember(Value="low")]
       low,
       [EnumMember(Value="normal")]
       normal,
       [EnumMember(Value="high")]
       high
    }
}
