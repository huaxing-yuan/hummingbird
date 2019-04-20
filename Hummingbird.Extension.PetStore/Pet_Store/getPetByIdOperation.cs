
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
    /// Find pet by ID
    ///</summary>
    [Serializable]    
    
    public class getPetById {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("api_key")]
        
        public string api_key {get; set;}
        /// <summary>
        /// ID of pet to return
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("petId")]
        [System.ComponentModel.Description("ID of pet to return")]
        public long petId {get; set;}

    }
}


namespace Hummingbird.PetStoreExtension.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class getPetById_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.Pet Body {get; set;}

    }
}
