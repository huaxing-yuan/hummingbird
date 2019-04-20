
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
    /// Add a new pet to the store
    ///</summary>
    [Serializable]    
    
    public class addPet {
        
        /// <summary>
        /// Pet object that needs to be added to the store
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Pet object that needs to be added to the store")]
        public Hummingbird.PetStoreExtension.Pet_Store.Pet_Store.Pet Body {get; set;}

    }
}

