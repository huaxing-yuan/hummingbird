
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Returns pet inventories by status
    ///</summary>
    [Serializable]    
    
    public class getInventory {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("api_key")]
        public string api_key {get; set;}
    }
}