
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.OAuth2Extension.OAuth2_Grant.Client_Credentials
{
    
    ///<summary>
    /// Value MUST be set to "client_credentials" as per RFC
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Value MUST be set to 'client_credentials' as per RFC")]
    public enum grant_type {
       [EnumMember(Value="client_credentials")]
       client_credentials
    }
}
