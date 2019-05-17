
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
    /// Role of the entity behind the account (Example: User, Bot, etc.)
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Role of the entity behind the account (Example: User, Bot, etc.)")]
    public enum role {
       [EnumMember(Value="user")]
       user,
       [EnumMember(Value="bot")]
       bot
    }
}
