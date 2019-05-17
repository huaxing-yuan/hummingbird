
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
    /// Text format types
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Text format types")]
    public enum textFormat {
       [EnumMember(Value="markdown")]
       markdown,
       [EnumMember(Value="plain")]
       plain,
       [EnumMember(Value="xml")]
       xml
    }
}
