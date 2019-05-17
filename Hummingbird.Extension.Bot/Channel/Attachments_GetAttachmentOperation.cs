
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
    /// GetAttachment
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("GetAttachment")]
    public class Attachments_GetAttachment {
        
        /// <summary>
        /// attachment id
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("attachmentId")]
        [System.ComponentModel.Description("attachment id")]
        public string attachmentId {get; set;}


        /// <summary>
        /// View id from attachmentInfo
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("viewId")]
        [System.ComponentModel.Description("View id from attachmentInfo")]
        public string viewId {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// Attachment stream
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("Attachment stream")]
    public class Attachments_GetAttachment_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.MS.Bot.Bot_Framework.Channel.UnnamedClass_0 Body {get; set;}

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
    public class Attachments_GetAttachment_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
