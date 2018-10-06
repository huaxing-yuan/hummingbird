
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Finds Pets by tags
    ///</summary>
    [Serializable]    
    
    public class findPetsByTags {
        
        /// <summary>
        /// Tags to filter by
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("tags", QueryFieldFormat.PlainText)]
        public string[] tags {get; set;}

    }
}
