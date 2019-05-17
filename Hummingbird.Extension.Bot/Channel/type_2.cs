
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
    /// Defines action types for clickable buttons.
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Defines action types for clickable buttons.")]
    public enum type_2 {
       [EnumMember(Value="openUrl")]
       openUrl,
       [EnumMember(Value="imBack")]
       imBack,
       [EnumMember(Value="postBack")]
       postBack,
       [EnumMember(Value="playAudio")]
       playAudio,
       [EnumMember(Value="playVideo")]
       playVideo,
       [EnumMember(Value="showImage")]
       showImage,
       [EnumMember(Value="downloadFile")]
       downloadFile,
       [EnumMember(Value="signin")]
       signin,
       [EnumMember(Value="call")]
       call,
       [EnumMember(Value="payment")]
       payment,
       [EnumMember(Value="messageBack")]
       messageBack
    }
}
