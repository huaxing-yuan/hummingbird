
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
    /// Send an activity
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Send an activity")]
    public class Conversations_PostActivity {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// Activity to send
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Activity to send")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Activity Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{
    ///<summary>
    /// The operation succeeded.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("The operation succeeded.")]
    public class Conversations_PostActivity_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource ID")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ResourceResponse Body {get; set;}

    }
}
