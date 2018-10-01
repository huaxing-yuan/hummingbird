
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Finds Pets by status
    ///</summary>
    [Serializable]    
    public class findPetsByStatus {
        
        /// <summary>
        /// Status values that need to be considered for filter
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("status", QueryFieldFormat.PlainText)]
        public Hummingbird.PetStore.Pet_Store.Pet_Store.Status[] status {get; set;}

    }
}
