
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
    /// GetConversationPagedMembers
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("GetConversationPagedMembers")]
    public class Conversations_GetConversationPagedMembers {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// Suggested page size
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("pageSize", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("Suggested page size")]
        public int pageSize {get; set;}


        /// <summary>
        /// Continuation Token
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("continuationToken", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("Continuation Token")]
        public string continuationToken {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// OK
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("OK")]
    public class Conversations_GetConversationPagedMembers_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Page of members.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PagedMembersResult Body {get; set;}

    }
}
