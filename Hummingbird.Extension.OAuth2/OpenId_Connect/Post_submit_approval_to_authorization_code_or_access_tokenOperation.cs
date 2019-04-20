
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
    /// submit approval to authorization code or access token
    ///</summary>
    [Serializable]    
    
    public class Post_submit_approval_to_authorization_code_or_access_token {
        
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("client_id", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("application's client_id")]
        public string client_id {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [Hummingbird.TestFramework.Services.FormUrlEncodedAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.UnnamedClass_0 Body {get; set;}

    }
}

