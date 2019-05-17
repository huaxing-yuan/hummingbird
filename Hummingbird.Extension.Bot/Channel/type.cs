
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{
    
    ///<summary>
    /// Types of Activities
    ///</summary>
    [Serializable]
    [System.ComponentModel.Description("Types of Activities")]
    public enum type {
       [EnumMember(Value="message")]
       message,
       [EnumMember(Value="contactRelationUpdate")]
       contactRelationUpdate,
       [EnumMember(Value="conversationUpdate")]
       conversationUpdate,
       [EnumMember(Value="typing")]
       typing,
       [EnumMember(Value="endOfConversation")]
       endOfConversation,
       [EnumMember(Value="event")]
       @event,
       [EnumMember(Value="invoke")]
       invoke,
       [EnumMember(Value="deleteUserData")]
       deleteUserData,
       [EnumMember(Value="messageUpdate")]
       messageUpdate,
       [EnumMember(Value="messageDelete")]
       messageDelete,
       [EnumMember(Value="installationUpdate")]
       installationUpdate,
       [EnumMember(Value="messageReaction")]
       messageReaction,
       [EnumMember(Value="suggestion")]
       suggestion,
       [EnumMember(Value="trace")]
       trace,
       [EnumMember(Value="handoff")]
       handoff
    }
}
