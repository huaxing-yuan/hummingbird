
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code
{
    
    ///<summary>
    /// Request Access Token
    ///</summary>
    [Serializable]    
    
    public class getToken {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [Hummingbird.TestFramework.Services.FormUrlEncodedAttribute]
        
        public Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code.UnnamedClass_0 Body {get; set;}

    }
}

