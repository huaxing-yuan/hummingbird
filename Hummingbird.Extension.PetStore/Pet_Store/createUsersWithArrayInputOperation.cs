
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
    /// Creates list of users with given input array
    ///</summary>
    [Serializable]    
    
    public class createUsersWithArrayInput {
        
        /// <summary>
        /// List of user object
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("List of user object")]
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.User[] Body {get; set;}

    }
}

