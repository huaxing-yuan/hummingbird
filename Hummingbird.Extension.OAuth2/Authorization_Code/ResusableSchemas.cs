
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code
{

    [Serializable]
    /// <summary>
    /// </summary>
    
    public class Token{
        public string access_token {get; set;} 

        public Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code.token_type token_type {get; set;} 

        public int expires_in {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    
    public class Error{
        public Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code.error error {get; set;} 

        public string error_description {get; set;} 

        public string error_uri {get; set;} 

    }

}
