
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
    /// Revoke an application/client permission by the authorized owner
    ///</summary>
    [Serializable]    
    
    public class Delete_Revoke_an_applicationclient_permission_by_the_authorized_owner {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Id")]
        
        public string X_IBM_Client_Id {get; set;}

        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Secret")]
        
        public string X_IBM_Client_Secret {get; set;}
        /// <summary>
        /// client-id is the OAuth client_id or application id to be revoked
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("client-id", QueryFieldFormat.PlainText)]
        [System.ComponentModel.Description("client-id is the OAuth client_id or application id to be revoked")]
        public string client_id {get; set;}

    }
}

