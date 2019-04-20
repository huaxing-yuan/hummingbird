
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
    /// 
    ///</summary>
    [Serializable]
    
    public enum response_type {
       [EnumMember(Value="code")]
       code,
       [EnumMember(Value="token")]
       token
    }
}
