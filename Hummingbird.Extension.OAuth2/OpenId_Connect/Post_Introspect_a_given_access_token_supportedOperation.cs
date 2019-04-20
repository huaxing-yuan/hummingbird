
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
    /// Introspect a given access_token supported
    ///</summary>
    [Serializable]    
    
    public class Post_Introspect_a_given_access_token_supported {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Id")]
        
        public string X_IBM_Client_Id {get; set;}

        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Secret")]
        
        public string X_IBM_Client_Secret {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [Hummingbird.TestFramework.Services.FormUrlEncodedAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.UnnamedClass_3 Body {get; set;}

    }
}


namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{
    ///<summary>
    /// json document containing issued information, etc.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Post_Introspect_a_given_access_token_supported_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.introspect_response Body {get; set;}

    }
}
