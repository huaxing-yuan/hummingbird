
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
    /// Message reaction types
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Message reaction types")]
    public enum type_1 {
       [EnumMember(Value="like")]
       like,
       [EnumMember(Value="plusOne")]
       plusOne
    }
}
