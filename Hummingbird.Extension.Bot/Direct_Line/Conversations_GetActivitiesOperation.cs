
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    
    ///<summary>
    /// Get activities in this conversation. This method is paged with the 'watermark' parameter.
    ///</summary>
    [Serializable]    
    
    public class Conversations_GetActivities {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// (Optional) only returns activities newer than this watermark
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("watermark", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("(Optional) only returns activities newer than this watermark")]
        public string watermark {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    ///<summary>
    /// A set of activities and a watermark are returned.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Conversations_GetActivities_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A collection of activities")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ActivitySet Body {get; set;}

    }
}
