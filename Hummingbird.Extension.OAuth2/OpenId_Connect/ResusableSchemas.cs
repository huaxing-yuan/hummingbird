
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{

    [Serializable]
    /// <summary>
    /// </summary>
    
    public class access_token_response{
        public object token_type {get; set;} 

        public string access_token {get; set;} 

        public int expires_in {get; set;} 

        public string scope {get; set;} 

        public string refresh_token {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    
    public class introspect_response{
        public bool active {get; set;} 

        public string client_id {get; set;} 

        public string client_name {get; set;} 

        public string username {get; set;} 

        public string sub {get; set;} 

        public string exp {get; set;} 

        public string expstr {get; set;} 

        public string iat {get; set;} 

        public string nbf {get; set;} 

        public string nbfstr {get; set;} 

        public string scope {get; set;} 

        public string miscinfo {get; set;} 

        public string consented_on {get; set;} 

        public string consented_on_str {get; set;} 

        public string grant_type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    
    public class issued_response{
        public string clientId {get; set;} 

        public string clientName {get; set;} 

        public string owner {get; set;} 

        public string scope {get; set;} 

        public string issuedAt {get; set;} 

        public string expiredAt {get; set;} 

        public bool refreshTokenIssued {get; set;} 

        public string miscInfo {get; set;} 

        public string consentedOn {get; set;} 

        public string appId {get; set;} 

        public string org {get; set;} 

        public string orgId {get; set;} 

        public string catalog {get; set;} 

        public string catalogId {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    
    public class issued_responses{

    }

}
