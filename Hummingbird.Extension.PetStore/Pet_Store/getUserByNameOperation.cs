
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
    /// Get user by user name
    ///</summary>
    [Serializable]    
    
    public class getUserByName {
        
        /// <summary>
        /// The name that needs to be fetched. Use user1 for testing. 
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("username")]
        [System.ComponentModel.Description("The name that needs to be fetched. Use user1 for testing. ")]
        public string username {get; set;}

    }
}


namespace Hummingbird.PetStoreExtension.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class getUserByName_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.User Body {get; set;}

    }
}
