
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// pet status in the store
    ///</summary>
    [Serializable]    
    public enum status_1 {
       [EnumMember(Value="available")]
       available,
       [EnumMember(Value="pending")]
       pending,
       [EnumMember(Value="sold")]
       sold
    }
}
