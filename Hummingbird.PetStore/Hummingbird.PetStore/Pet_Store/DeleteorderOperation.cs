
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
    /// Delete purchase order by ID
    ///</summary>
    [Serializable]    
    
    public class deleteOrder {
        
        /// <summary>
        /// ID of the order that needs to be deleted
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("orderId")]
        public long orderId {get; set;}

    }
}

