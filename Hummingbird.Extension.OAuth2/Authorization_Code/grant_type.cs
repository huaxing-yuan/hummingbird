
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
    /// Value MUST be set to "authorization_code" as per RFC
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Value MUST be set to 'authorization_code' as per RFC")]
    public enum grant_type {
       [EnumMember(Value="authorization_code")]
       authorization_code
    }
}
