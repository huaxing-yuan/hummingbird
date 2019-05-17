
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
    /// Send a message
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Send a message")]
    public class Conversations_PostMessage {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// Message to send
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Message to send")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Message Body {get; set;}

    }
}

