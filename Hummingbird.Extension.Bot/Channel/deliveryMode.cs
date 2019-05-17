
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
    /// Values for deliveryMode field
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Values for deliveryMode field")]
    public enum deliveryMode {
       [EnumMember(Value="normal")]
       normal,
       [EnumMember(Value="notification")]
       notification
    }
}
