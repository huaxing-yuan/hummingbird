
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Order Status
    ///</summary>
    [Serializable]    
    public enum status {
       [EnumMember(Value="placed")]
       placed,
       [EnumMember(Value="approved")]
       approved,
       [EnumMember(Value="delivered")]
       delivered
    }
}
