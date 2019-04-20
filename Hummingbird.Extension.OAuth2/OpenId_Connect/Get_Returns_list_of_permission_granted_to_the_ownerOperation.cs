
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
    /// Returns list of permission granted to the owner
    ///</summary>
    [Serializable]    
    
    public class Get_Returns_list_of_permission_granted_to_the_owner {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Id")]
        
        public string X_IBM_Client_Id {get; set;}

        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-IBM-Client-Secret")]
        
        public string X_IBM_Client_Secret {get; set;}
    }
}


namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{
    ///<summary>
    /// json document containing issued information, etc.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class Get_Returns_list_of_permission_granted_to_the_owner_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect.issued_response[] Body {get; set;}

    }
}
