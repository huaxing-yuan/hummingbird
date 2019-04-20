
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
    /// Authentication Endpoint
    ///</summary>
    [Serializable]    
    
    public class auth {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("response_type", QueryFieldFormat.PlainText)]
        
        public Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code.response_type response_type {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("client_id", QueryFieldFormat.PlainText)]
        
        public string client_id {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("redirect_uri", QueryFieldFormat.PlainText)]
        
        public string redirect_uri {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("scope", QueryFieldFormat.PlainText)]
        
        public string scope {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("state", QueryFieldFormat.PlainText)]
        
        public string state {get; set;}

    }
}

