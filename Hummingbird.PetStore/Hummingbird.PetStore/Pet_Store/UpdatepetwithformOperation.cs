
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Updates a pet in the store with form data
    ///</summary>
    [Serializable]    
    
    public class updatePetWithForm {
        
        /// <summary>
        /// ID of pet that needs to be updated
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("petId")]
        public long petId {get; set;}


        /// <summary>
        /// 
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [Hummingbird.TestFramework.Services.FormUrlEncodedAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.UnnamedClass_0 Body {get; set;}

    }
}
