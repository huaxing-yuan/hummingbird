
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{
    
    ///<summary>
    /// Get information about an existing conversation
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Get information about an existing conversation")]
    public class Conversations_ReconnectToConversation {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        
        public string conversationId {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("watermark", QueryFieldFormat.PlainText)]
        
        public string watermark {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{
    ///<summary>
    /// The conversation was successfully created, updated, or retrieved.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("The conversation was successfully created, updated, or retrieved.")]
    public class Conversations_ReconnectToConversation_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Conversation Body {get; set;}

    }
}
