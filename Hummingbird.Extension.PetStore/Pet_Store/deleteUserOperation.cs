
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
    /// Delete user
    ///</summary>
    [Serializable]    
    
    public class deleteUser {
        
        /// <summary>
        /// The name that needs to be deleted
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("username")]
        [System.ComponentModel.Description("The name that needs to be deleted")]
        public string username {get; set;}

    }
}

