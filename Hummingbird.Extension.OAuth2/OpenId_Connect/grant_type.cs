
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OpenId_Connect.OpenId_Connect
{
    
    ///<summary>
    /// Type of grant
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Type of grant")]
    public enum grant_type {
       [EnumMember(Value="authorization_code")]
       authorization_code,
       [EnumMember(Value="password")]
       password,
       [EnumMember(Value="client_credentials")]
       client_credentials,
       [EnumMember(Value="refresh_token")]
       refresh_token
    }
}
