
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
    /// GetAttachmentInfo
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("GetAttachmentInfo")]
    public class Attachments_GetAttachmentInfo {
        
        /// <summary>
        /// attachment id
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("attachmentId")]
        [System.ComponentModel.Description("attachment id")]
        public string attachmentId {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An attachmentInfo object is returned which describes the:///
///* type of the attachment///
///* name of the attachment///
//////
//////
///and an array of views:///
///* Size - size of the object///
///* ViewId - View Id which can be used to fetch a variation on the content (ex: original or thumbnail)
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("An attachmentInfo object is returned which describes the:\r\n* type of the attachment\r\n* name of the attachment\r\n\r\n\r\nand an array of views:\r\n* Size - size of the object\r\n* ViewId - View Id which can be used to fetch a variation on the content (ex: original or thumbnail)")]
    public class Attachments_GetAttachmentInfo_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Metadata for an attachment")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.AttachmentInfo Body {get; set;}

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
    public class Attachments_GetAttachmentInfo_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
