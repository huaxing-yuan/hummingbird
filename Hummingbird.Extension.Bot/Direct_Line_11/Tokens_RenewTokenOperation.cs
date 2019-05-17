
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
    /// Renew a token for a conversation
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Renew a token for a conversation")]
    public class Tokens_RenewToken {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("conversationId")]
        
        public string conversationId {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// A string is returned.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("A string is returned.")]
    public class Tokens_RenewToken_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public string Body {get; set;}

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
    public class Tokens_RenewToken_401 {
        
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
    public class Tokens_RenewToken_403 {
        
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
    public class Tokens_RenewToken_404 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}
