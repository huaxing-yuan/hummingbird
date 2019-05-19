
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11
{

    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
    public class Conversation{
        [System.ComponentModel.Description("ID for this conversation")]
        public string conversationId {get; set;} 

        [System.ComponentModel.Description("Token scoped to this conversation")]
        public string token {get; set;} 

        [System.ComponentModel.Description("Expiration for token")]
        public int expires_in {get; set;} 

        
        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A standardized message error payload")]
    public class ErrorMessage{
        [System.ComponentModel.Description("An error message")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Error error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An error message")]
    public class Error{
        [System.ComponentModel.Description("Error code")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.code code {get; set;} 

        [System.ComponentModel.Description("Error message")]
        public string message {get; set;} 

        [System.ComponentModel.Description("Status code")]
        public int statusCode {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A collection of messages")]
    public class MessageSet{
        [System.ComponentModel.Description("Messages")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Message[] messages {get; set;} 

        [System.ComponentModel.Description("Maximum watermark included in this set of messages")]
        public string watermark {get; set;} 

        
        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A communication message sent to/from Direct Line")]
    public class Message{
        [System.ComponentModel.Description("ID for this message")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Conversation ID for this message")]
        public string conversationId {get; set;} 

        [System.ComponentModel.Description("UTC timestamp when this message was created")]
        public DateTime created {get; set;} 

        [System.ComponentModel.Description("Identity of the sender of this message")]
        public string from {get; set;} 

        [System.ComponentModel.Description("Text in this message")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Opaque block of data passed to/from bot via the ChannelData field")]
        public object channelData {get; set;} 

        [System.ComponentModel.Description("Array of URLs for images included in this message")]
        public string[] images {get; set;} 

        [System.ComponentModel.Description("Array of non-image attachments included in this message")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Attachment[] attachments {get; set;} 

        
        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An attachment")]
    public class Attachment{
        [System.ComponentModel.Description("URL for this attachment")]
        public string url {get; set;} 

        [System.ComponentModel.Description("Content type for this attachment")]
        public string contentType {get; set;} 

    }

}
