
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
    /// Start a new conversation
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Start a new conversation")]
    public class Conversations_StartConversation {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.TokenParameters Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{
    ///<summary>
    /// The conversation was successfully created, updated, or retrieved.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("The conversation was successfully created, updated, or retrieved.")]
    public class Conversations_StartConversation_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Conversation Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{
    ///<summary>
    /// The conversation was successfully created.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("201")]
    [System.ComponentModel.Description("The conversation was successfully created.")]
    public class Conversations_StartConversation_201 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Conversation Body {get; set;}

    }
}
