
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
    /// Replace knowledgebase contents.
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Replace knowledgebase contents.")]
    public class Replace_Knowledgebase {
        
        /// <summary>
        /// Knowledgebase id
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("kbId")]
        [System.ComponentModel.Description("Knowledgebase id")]
        public string kbId {get; set;}


        /// <summary>
        /// An instance of ReplaceKbDTO which contains list of qnas to be uploaded
        /// </summary>
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("An instance of ReplaceKbDTO which contains list of qnas to be uploaded")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ReplaceKbDTO Body {get; set;}

    }
}


namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("400")]
    
    public class Replace_Knowledgebase_400 {
        
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
    
    public class Replace_Knowledgebase_401 {
        
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
    
    public class Replace_Knowledgebase_403 {
        
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
    
    public class Replace_Knowledgebase_404 {
        
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
    
    public class Replace_Knowledgebase_500 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}
