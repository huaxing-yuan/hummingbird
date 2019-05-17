
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{
    
    ///<summary>
    /// Error code
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Error code")]
    public enum code {
       [EnumMember(Value="MissingProperty")]
       MissingProperty,
       [EnumMember(Value="MalformedData")]
       MalformedData,
       [EnumMember(Value="NotFound")]
       NotFound,
       [EnumMember(Value="ServiceError")]
       ServiceError,
       [EnumMember(Value="Internal")]
       Internal,
       [EnumMember(Value="InvalidRange")]
       InvalidRange,
       [EnumMember(Value="NotSupported")]
       NotSupported,
       [EnumMember(Value="NotAllowed")]
       NotAllowed,
       [EnumMember(Value="BadCertificate")]
       BadCertificate
    }
}
