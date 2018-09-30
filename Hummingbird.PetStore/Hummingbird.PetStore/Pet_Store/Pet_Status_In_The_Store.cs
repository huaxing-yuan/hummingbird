
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
    /// pet status in the store
    ///</summary>
    [Serializable]    
    public enum Pet_Status_In_The_Store {
       [EnumMember(Value="available")]
       Available,
       [EnumMember(Value="pending")]
       Pending,
       [EnumMember(Value="sold")]
       Sold
    }
}
