
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
    /// 
    ///</summary>
    [Serializable]    
    
    public class Session_GetSessionId {
        
    }
}


namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{
    ///<summary>
    /// OK
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Session_GetSessionId_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public object Body {get; set;}

    }
}
