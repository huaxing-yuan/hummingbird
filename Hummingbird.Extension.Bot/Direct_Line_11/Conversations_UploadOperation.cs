
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
    /// Upload file(s) and send as attachment(s)
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Upload file(s) and send as attachment(s)")]
    public class Conversations_Upload {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// User ID (optional)
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("userId", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("User ID (optional)")]
        public string userId {get; set;}

    }
}

