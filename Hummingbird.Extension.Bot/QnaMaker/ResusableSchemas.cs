
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.QnAMaker.QnaMaker
{

    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Collection of word alterations.")]
    public class WordAlterationsDTO{
        [System.ComponentModel.Description("Collection of word alterations.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.AlterationsDTO[] wordAlterations {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Collection of words that are synonyms.")]
    public class AlterationsDTO{
        [System.ComponentModel.Description("Words that are synonymous with each other.")]
        public string[] alterations {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Error response. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
    public class ErrorResponse{
        [System.ComponentModel.Description("The error object.")]
        public object error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("The error object. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
    public class ErrorObject{
        [System.ComponentModel.Description("One of a server-defined set of error codes.")]
        public object code {get; set;} 

        [System.ComponentModel.Description("A human-readable representation of the error.")]
        public string message {get; set;} 

        [System.ComponentModel.Description("The target of the error.")]
        public string target {get; set;} 

        [System.ComponentModel.Description("An array of details about specific errors that led to this reported error.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.ErrorObject[] details {get; set;} 

        [System.ComponentModel.Description("An object containing more specific information than the current object about the error.")]
        public object innerError {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Human readable error code.")]
    public class ErrorCode{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An object containing more specific information about the error. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.")]
    public class InnerErrorModel{
        [System.ComponentModel.Description("A more specific error code than was provided by the containing error.")]
        public string code {get; set;} 

        [System.ComponentModel.Description("An object containing more specific information than the current object about the error.")]
        public object innerError {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Schema for EndpointKeys generate/refresh operations.")]
    public class EndpointKeysDTO{
        [System.ComponentModel.Description("Primary Access Key.")]
        public string primaryEndpointKey {get; set;} 

        [System.ComponentModel.Description("Secondary Access Key.")]
        public string secondaryEndpointKey {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Collection of knowledgebases owned by a user.")]
    public class KnowledgebasesDTO{
        [System.ComponentModel.Description("Collection of knowledgebase records.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.KnowledgebaseDTO[] knowledgebases {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Response schema for CreateKb operation.")]
    public class KnowledgebaseDTO{
        [System.ComponentModel.Description("Unique id that identifies a knowledgebase.")]
        public string id {get; set;} 

        [System.ComponentModel.Description("URL host name at which the knowledgebase is hosted.")]
        public string hostName {get; set;} 

        [System.ComponentModel.Description("Time stamp at which the knowledgebase was last accessed (UTC).")]
        public string lastAccessedTimestamp {get; set;} 

        [System.ComponentModel.Description("Time stamp at which the knowledgebase was last modified (UTC).")]
        public string lastChangedTimestamp {get; set;} 

        [System.ComponentModel.Description("Time stamp at which the knowledgebase was last published (UTC).")]
        public string lastPublishedTimestamp {get; set;} 

        [System.ComponentModel.Description("Friendly name of the knowledgebase.")]
        public string name {get; set;} 

        [System.ComponentModel.Description("User who created / owns the knowledgebase.")]
        public string userId {get; set;} 

        [System.ComponentModel.Description("URL sources from which Q-A were extracted and added to the knowledgebase.")]
        public string[] urls {get; set;} 

        [System.ComponentModel.Description("Custom sources from which Q-A were extracted or explicitly added to the knowledgebase.")]
        public string[] sources {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Post body schema for CreateKb operation.")]
    public class CreateKbDTO{
        [System.ComponentModel.Description("Friendly name for the knowledgebase.")]
        public string name {get; set;} 

        [System.ComponentModel.Description("List of Q-A (QnADTO) to be added to the knowledgebase. Q-A Ids are assigned by the service and should be omitted.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.QnADTO[] qnaList {get; set;} 

        [System.ComponentModel.Description("List of URLs to be used for extracting Q-A.")]
        public string[] urls {get; set;} 

        [System.ComponentModel.Description("List of files from which to Extract Q-A.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.FileDTO[] files {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Q-A object.")]
    public class QnADTO{
        [System.ComponentModel.Description("Unique id for the Q-A.")]
        public int id {get; set;} 

        [System.ComponentModel.Description("Answer text")]
        public string answer {get; set;} 

        [System.ComponentModel.Description("Source from which Q-A was indexed. eg. https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs")]
        public string source {get; set;} 

        [System.ComponentModel.Description("List of questions associated with the answer.")]
        public string[] questions {get; set;} 

        [System.ComponentModel.Description("List of metadata associated with the answer.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.MetadataDTO[] metadata {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Name - value pair of metadata.")]
    public class MetadataDTO{
        [System.ComponentModel.Description("Metadata name.")]
        public string name {get; set;} 

        [System.ComponentModel.Description("Metadata value.")]
        public string value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("DTO to hold details of uploaded files.")]
    public class FileDTO{
        [System.ComponentModel.Description("File name. Supported file types are '.tsv', '.pdf', '.txt', '.docx', '.xlsx'.")]
        public string fileName {get; set;} 

        [System.ComponentModel.Description("Public URI of the file.")]
        public string fileUri {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Record to track long running operation.")]
    public class Operation:Hummingbird.MS.Bot.QnAMaker.QnaMaker.BaseTableRecord{
        [System.ComponentModel.Description("Operation state.")]
        public object operationState {get; set;} 

        [System.ComponentModel.Description("Timestamp when the operation was created.")]
        public DateTime createdTimestamp {get; set;} 

        [System.ComponentModel.Description("Timestamp when the current state was entered.")]
        public DateTime lastActionTimestamp {get; set;} 

        [System.ComponentModel.Description("Relative URI to the target resource location for completed resources.")]
        public string resourceLocation {get; set;} 

        [System.ComponentModel.Description("User Id")]
        public string userId {get; set;} 

        [System.ComponentModel.Description("Operation Id.")]
        public string operationId {get; set;} 

        [System.ComponentModel.Description("Error details in case of failures.")]
        public object errorResponse {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Enumeration of operation states.")]
    public class OperationState{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Base class for entities that need to be stored in table storage.")]
    public class BaseTableRecord{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Enumeration of knowledgebase environments.")]
    public class KnowledgebaseEnvironment{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("List of QnADTO")]
    public class QnADocumentsDTO{
        [System.ComponentModel.Description("List of answers.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.QnADTO[] qnaDocuments {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Post body schema for Replace KB operation.")]
    public class ReplaceKbDTO{
        [System.ComponentModel.Description("List of Q-A (QnADTO) to be added to the knowledgebase. Q-A Ids are assigned by the service and should be omitted.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.QnADTO[] qnAList {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Contains list of QnAs to be updated")]
    public class UpdateKbOperationDTO{
        [System.ComponentModel.Description("An instance of CreateKbInputDTO for add operation")]
        public object add {get; set;} 

        [System.ComponentModel.Description("An instance of DeleteKbContentsDTO for delete Operation")]
        public object delete {get; set;} 

        [System.ComponentModel.Description("An instance of UpdateKbContentsDTO for Update Operation")]
        public object update {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Input to create KB.")]
    public class CreateKbInputDTO{
        [System.ComponentModel.Description("list of QNA to be added to the index. Ids are generated by the service and should be omitted.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.QnADTO[] qnaList {get; set;} 

        [System.ComponentModel.Description("List of URLs to be added to knowledgebase.")]
        public string[] urls {get; set;} 

        [System.ComponentModel.Description("List of files to be added to knowledgebase.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.FileDTO[] files {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("PATCH body schema of Delete Operation in UpdateKb")]
    public class DeleteKbContentsDTO{
        [System.ComponentModel.Description("List of Qna Ids to be deleted")]
        public int[] ids {get; set;} 

        [System.ComponentModel.Description("List of sources to be deleted from knowledgebase.")]
        public string[] sources {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("PATCH body schema for Update operation in Update Kb")]
    public class UpdateKbContentsDTO{
        [System.ComponentModel.Description("Friendly name for the knowledgebase.")]
        public string name {get; set;} 

        [System.ComponentModel.Description("List of Q-A (UpdateQnaDTO) to be added to the knowledgebase.")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.UpdateQnaDTO[] qnaList {get; set;} 

        [System.ComponentModel.Description("List of existing URLs to be refreshed. The content will be extracted again and re-indexed.")]
        public string[] urls {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("PATCH Body schema for Update Qna List")]
    public class UpdateQnaDTO{
        [System.ComponentModel.Description("Unique id for the Q-A")]
        public int id {get; set;} 

        [System.ComponentModel.Description("Answer text")]
        public string answer {get; set;} 

        [System.ComponentModel.Description("Source from which Q-A was indexed. eg. https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs")]
        public string source {get; set;} 

        [System.ComponentModel.Description("List of questions associated with the answer.")]
        public object questions {get; set;} 

        [System.ComponentModel.Description("List of metadata associated with the answer to be updated")]
        public object metadata {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("PATCH Body schema for Update Kb which contains list of questions to be added and deleted")]
    public class UpdateQuestionsDTO{
        [System.ComponentModel.Description("List of questions to be added")]
        public string[] add {get; set;} 

        [System.ComponentModel.Description("List of questions to be deleted.")]
        public string[] delete {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("PATCH Body schema to represent list of Metadata to be updated")]
    public class UpdateMetadataDTO{
        [System.ComponentModel.Description("List of Metadata associated with answer to be deleted")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.MetadataDTO[] delete {get; set;} 

        [System.ComponentModel.Description("List of Metadat associated with answer to be added")]
        public Hummingbird.MS.Bot.QnAMaker.QnaMaker.MetadataDTO[] add {get; set;} 

    }

}
