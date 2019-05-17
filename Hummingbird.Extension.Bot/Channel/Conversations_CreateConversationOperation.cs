
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
    /// CreateConversation
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("CreateConversation")]
    public class Conversations_CreateConversation {
        
        /// <summary>
        /// Parameters to create the conversation from
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Parameters to create the conversation from")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationParameters Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing ///
///* the ID for the conversation///
///* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("An object will be returned containing \r\n* the ID for the conversation\r\n* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.")]
    public class Conversations_CreateConversation_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationResourceResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing ///
///* the ID for the conversation///
///* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("201")]
    [System.ComponentModel.Description("An object will be returned containing \r\n* the ID for the conversation\r\n* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.")]
    public class Conversations_CreateConversation_201 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationResourceResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing ///
///* the ID for the conversation///
///* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("202")]
    [System.ComponentModel.Description("An object will be returned containing \r\n* the ID for the conversation\r\n* ActivityId for the activity if provided.  If ActivityId is null then the channel doesn't support returning resource id's for activity.")]
    public class Conversations_CreateConversation_202 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationResourceResponse Body {get; set;}

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
    public class Conversations_CreateConversation_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
