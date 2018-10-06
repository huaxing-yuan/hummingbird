
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
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
        public long petId {get; set;}

    }
}
