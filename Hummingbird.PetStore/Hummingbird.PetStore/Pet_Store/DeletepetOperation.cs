
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
    /// Deletes a pet
    ///</summary>
    [Serializable]    
    
    public class deletePet {
        
        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("api_key")]
        public string api_key {get; set;}


        /// <summary>
        /// Pet id to delete
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("petId")]
        public long petId {get; set;}

    }
}

