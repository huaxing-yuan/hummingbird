
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
    /// Gets details of a specific long running operation.
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Gets details of a specific long running operation.")]
    public class Get_Operation_Details {
        
        /// <summary>
        /// Operation id.
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("operationId")]
        [System.ComponentModel.Description("Operation id.")]
        public string operationId {get; set;}

    }
}


namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// Details of the long running operation.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("Details of the long running operation.")]
    public class Get_Operation_Details_200 {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("RetryAfter")]
        [System.ComponentModel.Description("Indicates how long the client should wait before sending a follow up request. The header will be present only if the operation is running or has not started yet.")]
        public int RetryAfter {get; set;}

        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Record to track long running operation.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.Operation Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("400")]
    
    public class Get_Operation_Details_400 {
        
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
    
    public class Get_Operation_Details_401 {
        
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
    
    public class Get_Operation_Details_403 {
        
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
    
    public class Get_Operation_Details_404 {
        
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
    
    public class Get_Operation_Details_500 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}
