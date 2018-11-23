
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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


namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class getInventory_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public object Body {get; set;}

    }
}
