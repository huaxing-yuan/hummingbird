
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Updated user
    ///</summary>
    [Serializable]    
    public class updateUser {
        
        /// <summary>
        /// name that need to be updated
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("username")]
        public string username {get; set;}


        /// <summary>
        /// Updated user object
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.User Body {get; set;}

    }
}
