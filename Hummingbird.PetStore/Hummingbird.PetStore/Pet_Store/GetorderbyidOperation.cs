
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
    /// Find purchase order by ID
    ///</summary>
    [Serializable]    
    
    public class getOrderById {
        
        /// <summary>
        /// ID of pet that needs to be fetched
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("orderId")]
        public long orderId {get; set;}

    }
}


namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class getOrderById_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.Order Body {get; set;}

    }
}
