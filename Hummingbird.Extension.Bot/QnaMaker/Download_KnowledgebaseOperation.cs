
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
    /// Download the knowledgebase.
    ///</summary>
    [Serializable]    
    
    [System.ComponentModel.Description("Download the knowledgebase.")]
    public class Download_Knowledgebase {
        
        /// <summary>
        /// Knowledgebase id
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("kbId")]
        [System.ComponentModel.Description("Knowledgebase id")]
        public string kbId {get; set;}


        /// <summary>
        /// Specifies whether environment is Test or Prod.
        /// </summary>
        [Hummingbird.TestFramework.Services.UriPathAttribute("environment")]
        [System.ComponentModel.Description("Specifies whether environment is Test or Prod.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.environment environment {get; set;}

    }
}


namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// Collection of all Q-A in the knowledgebase.
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("200")]
    [System.ComponentModel.Description("Collection of all Q-A in the knowledgebase.")]
    public class Download_Knowledgebase_200 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("List of QnADTO")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.QnADocumentsDTO Body {get; set;}

    }
}

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{
    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [HttpResponseAttribute("400")]
    
    public class Download_Knowledgebase_400 {
        
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
    
    public class Download_Knowledgebase_401 {
        
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
    
    public class Download_Knowledgebase_403 {
        
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
    
    public class Download_Knowledgebase_404 {
        
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
    
    public class Download_Knowledgebase_500 {
        
        [Hummingbird.TestFramework.Services.HttpBodyAttribute]
        [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorResponse Body {get; set;}

    }
}
