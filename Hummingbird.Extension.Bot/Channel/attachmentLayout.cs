
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
    /// Attachment layout types
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Attachment layout types")]
    public enum attachmentLayout {
       [EnumMember(Value="list")]
       list,
       [EnumMember(Value="carousel")]
       carousel
    }
}
