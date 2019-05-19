
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    
    public enum environment {
       [EnumMember(Value="Prod")]
       Prod,
       [EnumMember(Value="Test")]
       Test
    }
}
