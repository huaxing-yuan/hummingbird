
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
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
        public string username {get; set;}

    }
}
