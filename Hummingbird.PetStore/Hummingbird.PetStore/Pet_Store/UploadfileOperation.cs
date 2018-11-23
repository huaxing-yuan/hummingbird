
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
    /// uploads an image
    ///</summary>
    [Serializable]    
    
    public class uploadFile {
        
        /// <summary>
        /// ID of pet to update
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("petId")]
        public long petId {get; set;}

    }
}


namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class uploadFile_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.ApiResponse Body {get; set;}

    }
}
