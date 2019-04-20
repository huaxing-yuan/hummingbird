
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{
    
    ///<summary>
    /// Request Access Tokens
    ///</summary>
    [Serializable]    
    
    public class Post_Request_Access_Tokens {
        
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("client_id", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("application's client_id")]
        public string client_id {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [Hummingbird.TestFramework.Services.FormUrlEncodedAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.UnnamedClass_1 Body {get; set;}

    }
}


namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{
    ///<summary>
    /// json document containing token, etc.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Post_Request_Access_Tokens_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.access_token_response Body {get; set;}

    }
}
