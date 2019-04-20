
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStoreExtension.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Place an order for a pet
    ///</summary>
    [Serializable]    
    
    public class placeOrder {
        
        /// <summary>
        /// order placed for purchasing the pet
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("order placed for purchasing the pet")]
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.Order Body {get; set;}

    }
}


namespace Hummingbird.PetStoreExtension.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class placeOrder_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.Order Body {get; set;}

    }
}
