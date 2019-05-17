
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    
    ///<summary>
    /// Get messages in this conversation. This method is paged with the 'watermark' parameter.
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Get messages in this conversation. This method is paged with the 'watermark' parameter.")]
    public class Conversations_GetMessages {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// (Optional) only returns messages newer than this watermark
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("watermark", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("(Optional) only returns messages newer than this watermark")]
        public string watermark {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// A set of messages and a watermark are returned.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("A set of messages and a watermark are returned.")]
    public class Conversations_GetMessages_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A collection of messages")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.MessageSet Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// The operation included an invalid or missing Authorization header.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("401")]
    [System.ComponentModel.Description("The operation included an invalid or missing Authorization header.")]
    public class Conversations_GetMessages_401 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// You are forbidden from performing this action because your token or secret is invalid.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("403")]
    [System.ComponentModel.Description("You are forbidden from performing this action because your token or secret is invalid.")]
    public class Conversations_GetMessages_403 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// The requested resource was not found.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("404")]
    [System.ComponentModel.Description("The requested resource was not found.")]
    public class Conversations_GetMessages_404 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}
