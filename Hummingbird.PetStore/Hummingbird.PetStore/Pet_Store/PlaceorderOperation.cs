
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
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
        public Hummingbird.PetStore.Pet_Store.Pet_Store.Order Body {get; set;}

    }
}