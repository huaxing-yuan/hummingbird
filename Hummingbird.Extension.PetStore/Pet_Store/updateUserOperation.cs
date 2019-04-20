
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
    /// Updated user
    ///</summary>
    [Serializable]    
    
    public class updateUser {
        
        /// <summary>
        /// name that need to be updated
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("username")]
        [System.ComponentModel.Description("name that need to be updated")]
        public string username {get; set;}


        /// <summary>
        /// Updated user object
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Updated user object")]
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.User Body {get; set;}

    }
}

