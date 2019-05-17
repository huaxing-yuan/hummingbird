
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    
    ///<summary>
    /// GetConversationMembers
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("GetConversationMembers")]
    public class Conversations_GetConversationMembers {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An array of ChannelAccount objects
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("An array of ChannelAccount objects")]
    public class Conversations_GetConversationMembers_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// The operation failed and the response is an error object describing the status code and failure.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("default")]
    [System.ComponentModel.Description("The operation failed and the response is an error object describing the status code and failure.")]
    public class Conversations_GetConversationMembers_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
