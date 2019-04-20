
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
    /// Type of the token is set to "Bearer"
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Type of the token is set to 'Bearer'")]
    public enum token_type {
       [EnumMember(Value="Bearer")]
       Bearer
    }
}
