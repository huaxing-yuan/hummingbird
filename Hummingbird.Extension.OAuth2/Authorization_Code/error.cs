
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OAuth2_Grant.Authorization_Code
{
    
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    
    public enum error {
       [EnumMember(Value="invalid_request")]
       invalid_request,
       [EnumMember(Value="invalid_client")]
       invalid_client,
       [EnumMember(Value="invalid_grant")]
       invalid_grant,
       [EnumMember(Value="unauthorized_client")]
       unauthorized_client,
       [EnumMember(Value="unsupported_grant_type")]
       unsupported_grant_type
    }
}
