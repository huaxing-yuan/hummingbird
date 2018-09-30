
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Update an existing pet
    ///</summary>
    [Serializable]    
    public class updatePet {
        
        /// <summary>
        /// Pet object that needs to be added to the store
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.Pet Body {get; set;}

    }
}
