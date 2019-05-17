
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
    /// Start a new conversation
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Start a new conversation")]
    public class Conversations_NewConversation {
        
    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// The conversation was successfully created, updated, or retrieved.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("The conversation was successfully created, updated, or retrieved.")]
    public class Conversations_NewConversation_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Conversation Body {get; set;}

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
    public class Conversations_NewConversation_401 {
        
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
    public class Conversations_NewConversation_403 {
        
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
    public class Conversations_NewConversation_404 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    ///<summary>
    /// The object you are trying to create already exists.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("409")]
    [System.ComponentModel.Description("The object you are trying to create already exists.")]
    public class Conversations_NewConversation_409 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("A standardized message error payload")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.ErrorMessage Body {get; set;}

    }
}
