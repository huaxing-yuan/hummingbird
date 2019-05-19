
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    
    ///<summary>
    /// Gets endpoint keys for an endpoint
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Gets endpoint keys for an endpoint")]
    public class Get_Endpoint_Keys {
        
    }
}


namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// response with endpoint info in it.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("response with endpoint info in it.")]
    public class Get_Endpoint_Keys_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Schema for EndpointKeys generate/refresh operations.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.EndpointKeysDTO Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("400")]
    
    public class Get_Endpoint_Keys_400 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("401")]
    
    public class Get_Endpoint_Keys_401 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("403")]
    
    public class Get_Endpoint_Keys_403 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("404")]
    
    public class Get_Endpoint_Keys_404 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("500")]
    
    public class Get_Endpoint_Keys_500 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}
