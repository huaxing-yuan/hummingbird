
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
    /// UploadAttachment
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("UploadAttachment")]
    public class Conversations_UploadAttachment {
        
        /// <summary>
        /// Conversation ID
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        [System.ComponentModel.Description("Conversation ID")]
        public string conversationId {get; set;}


        /// <summary>
        /// Attachment data
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Attachment data")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.AttachmentData Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing the ID for the resource.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("An object will be returned containing the ID for the resource.")]
    public class Conversations_UploadAttachment_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource ID")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ResourceResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// A ResourceResponse object will be returned containing the ID for the resource.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("201")]
    [System.ComponentModel.Description("A ResourceResponse object will be returned containing the ID for the resource.")]
    public class Conversations_UploadAttachment_201 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource ID")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ResourceResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    ///<summary>
    /// An object will be returned containing the ID for the resource.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("202")]
    [System.ComponentModel.Description("An object will be returned containing the ID for the resource.")]
    public class Conversations_UploadAttachment_202 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A response containing a resource ID")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ResourceResponse Body {get; set;}

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
    public class Conversations_UploadAttachment_default {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An HTTP API response")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ErrorResponse Body {get; set;}

[Hummingbird.TestFramework.Services.HttpStatusCodeAttribute]
        public HttpStatusCode HttpStatusCode {get;set;}

    }
}
