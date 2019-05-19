
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
    /// Asynchronous operation to create a new knowledgebase.
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Asynchronous operation to create a new knowledgebase.")]
    public class Create_Knowledgebase {
        
        /// <summary>
        /// Post body of the request.
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Post body of the request.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.CreateKbDTO Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// Details of the asynchronous operation.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("202")]
    [System.ComponentModel.Description("Details of the asynchronous operation.")]
    public class Create_Knowledgebase_202 {
        
        [Hummingbird.TestFramework.Services.HttpHeaderAttribute("Location")]
        [System.ComponentModel.Description("Relative URI to the target location of the asynchronous operation. Client should poll this resource to get status of the operation.")]
        public string Location {get; set;}

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
    
    public class Create_Knowledgebase_400 {
        
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
    
    public class Create_Knowledgebase_401 {
        
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
    
    public class Create_Knowledgebase_403 {
        
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
    
    public class Create_Knowledgebase_404 {
        
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
    
    public class Create_Knowledgebase_500 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}
