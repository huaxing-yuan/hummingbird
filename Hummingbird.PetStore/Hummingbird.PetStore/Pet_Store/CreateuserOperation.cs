
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Create user
    ///</summary>
    [Serializable]    
    public class createUser {
        
        /// <summary>
        /// Created user object
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.User Body {get; set;}

    }
}
