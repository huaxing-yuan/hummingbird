
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
    /// GetConversations
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("GetConversations")]
    public class Conversations_GetConversations {
        
        /// <summary>
        /// skip or continuation token
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("continuationToken", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("skip or continuation token")]
        public string continuationToken {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing ///
///* an array (Conversations) of ConversationMembers objects///
///* a continuation token///
//////
///Each ConversationMembers object contains:///
///* the Id of the conversation///
///* an array (Members) of ChannelAccount objects
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("An object will be returned containing \r\n* an array (Conversations) of ConversationMembers objects\r\n* a continuation token\r\n\r\nEach ConversationMembers object contains:\r\n* the Id of the conversation\r\n* an array (Members) of ChannelAccount objects")]
    public class Conversations_GetConversations_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Conversations result")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationsResult Body {get; set;}

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
    public class Conversations_GetConversations_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
