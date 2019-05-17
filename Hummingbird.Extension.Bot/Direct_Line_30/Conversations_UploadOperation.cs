
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
    /// Upload file(s) and send as attachment(s)
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Upload file(s) and send as attachment(s)")]
    public class Conversations_Upload {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        
        public string conversationId {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("userId", QueryFieldFormat.PlainText)]
        
        public string userId {get; set;}

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
    public class Conversations_Upload_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource ID")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ResourceResponse Body {get; set;}

    }
}
