
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
    /// endpoint for Authorization Code and Implicit grants
    ///</summary>
    [Serializable]    
    
    public class Get_endpoint_for_Authorization_Code_and_Implicit_grants {
        
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("client_id", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("application's client_id")]
        public string client_id {get; set;}
        /// <summary>
        /// request an authorization code or or access token (implicit)
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("response_type", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("request an authorization code or or access token (implicit)")]
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.response_type response_type {get; set;}


        /// <summary>
        /// Scope being requested
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("scope", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("Scope being requested")]
        public string scope {get; set;}


        /// <summary>
        /// URI where user is redirected to after authorization
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("redirect_uri", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("URI where user is redirected to after authorization")]
        public string redirect_uri {get; set;}


        /// <summary>
        /// This string will be echoed back to application when user is redirected
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("state", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("This string will be echoed back to application when user is redirected")]
        public string state {get; set;}

    }
}

