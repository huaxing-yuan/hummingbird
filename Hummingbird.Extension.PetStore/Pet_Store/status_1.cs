
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStoreExtension.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// pet status in the store
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("pet status in the store")]
    public enum status_1 {
       [EnumMember(Value="available")]
       available,
       [EnumMember(Value="pending")]
       pending,
       [EnumMember(Value="sold")]
       sold
    }
}
