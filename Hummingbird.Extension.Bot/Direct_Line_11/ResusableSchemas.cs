
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
        public string conversationId {get; set;} 

        public string token {get; set;} 

        public int expires_in {get; set;} 

        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A standardized message error payload")]
    public class ErrorMessage{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Error error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An error message")]
    public class Error{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.code code {get; set;} 

        public string message {get; set;} 

        public int statusCode {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A collection of messages")]
    public class MessageSet{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Message[] messages {get; set;} 

        public string watermark {get; set;} 

        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A communication message sent to/from Direct Line")]
    public class Message{
        public string id {get; set;} 

        public string conversationId {get; set;} 

        public DateTime created {get; set;} 

        public string from {get; set;} 

        public string text {get; set;} 

        public object channelData {get; set;} 

        public string[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_11.Attachment[] attachments {get; set;} 

        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An attachment")]
    public class Attachment{
        public string url {get; set;} 

        public string contentType {get; set;} 

    }

}
