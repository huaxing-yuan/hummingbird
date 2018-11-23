
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    
    ///<summary>
    /// Logs user into the system
    ///</summary>
    [Serializable]    
    
    public class loginUser {
        
        /// <summary>
        /// The user name for login
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("username", QueryFieldFormat.PlainText)]
        public string username {get; set;}


        /// <summary>
        /// The password for login in clear text
        /// </summary>
        [Hummingbird.TestFramework.Services.QueryFieldAttribute("password", QueryFieldFormat.PlainText)]
        public string password {get; set;}

    }
}


namespace Hummingbird.PetStore.Pet_Store.Pet_Store
{
    ///<summary>
    /// successful operation
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    public class loginUser_200 {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-Rate-Limit")]
        public int X_Rate_Limit {get; set;}

        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("X-Expires-After")]
        public DateTime X_Expires_After {get; set;}

        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        public string Body {get; set;}

    }
}
