
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    
    ///<summary>
    /// Start a new conversation
    ///</summary>
    [Serializable]    
    
    public class Conversations_StartConversation {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.TokenParameters Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    ///<summary>
    /// The conversation was successfully created, updated, or retrieved.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Conversations_StartConversation_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Conversation Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    ///<summary>
    /// The conversation was successfully created.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("201")]
    public class Conversations_StartConversation_201 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Conversation Body {get; set;}

    }
}
