
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Channel
{

    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Metadata for an attachment")]
    public class AttachmentInfo{
        [System.ComponentModel.Description("Name of the attachment")]
        public string name {get; set;} 

        [System.ComponentModel.Description("ContentType of the attachment")]
        public string type {get; set;} 

        [System.ComponentModel.Description("attachment views")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.AttachmentView[] views {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Attachment View name and size")]
    public class AttachmentView{
        [System.ComponentModel.Description("Content type of the attachment")]
        public string viewId {get; set;} 

        [System.ComponentModel.Description("Name of the attachment")]
        public int size {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An HTTP API response")]
    public class ErrorResponse{
        [System.ComponentModel.Description("Object representing error information")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Error error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Object representing error information")]
    public class Error{
        [System.ComponentModel.Description("Error code")]
        public string code {get; set;} 

        [System.ComponentModel.Description("Error message")]
        public string message {get; set;} 

        [System.ComponentModel.Description("Object representing inner http error")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.InnerHttpError innerHttpError {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Object representing inner http error")]
    public class InnerHttpError{
        [System.ComponentModel.Description("HttpStatusCode from failed request")]
        public int statusCode {get; set;} 

        [System.ComponentModel.Description("Body from failed request")]
        public object body {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Parameters for creating a new conversation")]
    public class ConversationParameters{
        [System.ComponentModel.Description("IsGroup")]
        public bool isGroup {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount bot {get; set;} 

        [System.ComponentModel.Description("Members to add to the conversation")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

        [System.ComponentModel.Description("(Optional) Topic of the conversation (if supported by the channel)")]
        public string topicName {get; set;} 

        [System.ComponentModel.Description("(Optional) The tenant ID in which the conversation should be created")]
        public string tenantId {get; set;} 

        [System.ComponentModel.Description("An Activity is the basic communication type for the Bot Framework 3.0 protocol.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Activity activity {get; set;} 

        [System.ComponentModel.Description("Channel specific payload for creating the conversation")]
        public object channelData {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Channel account information needed to route a message")]
    public class ChannelAccount{
        [System.ComponentModel.Description("Channel id for the user or bot on this channel (Example: joe@smith.com, or @joesmith or 123456)")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Display friendly name")]
        public string name {get; set;} 

        [System.ComponentModel.Description("This account's object ID within Azure Active Directory (AAD)")]
        public string aadObjectId {get; set;} 

        [System.ComponentModel.Description("Role of the entity behind the account (Example: User, Bot, etc.)")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.role role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An Activity is the basic communication type for the Bot Framework 3.0 protocol.")]
    public class Activity{
        [System.ComponentModel.Description("Types of Activities")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type type {get; set;} 

        [System.ComponentModel.Description("Contains an ID that uniquely identifies the activity on the channel.")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Contains the date and time that the message was sent, in UTC, expressed in ISO-8601 format.")]
        public DateTime timestamp {get; set;} 

        [System.ComponentModel.Description("Contains the local date and time of the message, expressed in ISO-8601 format.\r\nFor example, 2016-09-23T13:07:49.4714686-07:00.")]
        public DateTime localTimestamp {get; set;} 

        [System.ComponentModel.Description("Contains the name of the local timezone of the message, expressed in IANA Time Zone database format.\r\nFor example, America/Los_Angeles.")]
        public string localTimezone {get; set;} 

        [System.ComponentModel.Description("Contains the URL that specifies the channel's service endpoint. Set by the channel.")]
        public string serviceUrl {get; set;} 

        [System.ComponentModel.Description("Contains an ID that uniquely identifies the channel. Set by the channel.")]
        public string channelId {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount from {get; set;} 

        [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationAccount conversation {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount recipient {get; set;} 

        [System.ComponentModel.Description("Text format types")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.textFormat textFormat {get; set;} 

        [System.ComponentModel.Description("Attachment layout types")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.attachmentLayout attachmentLayout {get; set;} 

        [System.ComponentModel.Description("The collection of members added to the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] membersAdded {get; set;} 

        [System.ComponentModel.Description("The collection of members removed from the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] membersRemoved {get; set;} 

        [System.ComponentModel.Description("The collection of reactions added to the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MessageReaction[] reactionsAdded {get; set;} 

        [System.ComponentModel.Description("The collection of reactions removed from the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MessageReaction[] reactionsRemoved {get; set;} 

        [System.ComponentModel.Description("The updated topic name of the conversation.")]
        public string topicName {get; set;} 

        [System.ComponentModel.Description("Indicates whether the prior history of the channel is disclosed.")]
        public bool historyDisclosed {get; set;} 

        [System.ComponentModel.Description("A locale name for the contents of the text field.\r\nThe locale name is a combination of an ISO 639 two- or three-letter culture code associated with a language\r\nand an ISO 3166 two-letter subculture code associated with a country or region.\r\nThe locale name can also correspond to a valid BCP-47 language tag.")]
        public string locale {get; set;} 

        [System.ComponentModel.Description("The text content of the message.")]
        public string text {get; set;} 

        [System.ComponentModel.Description("The text to speak.")]
        public string speak {get; set;} 

        [System.ComponentModel.Description("Indicates whether the bot is accepting, expecting, or ignoring input")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.inputHint inputHint {get; set;} 

        [System.ComponentModel.Description("The text to display if the channel cannot render cards.")]
        public string summary {get; set;} 

        [System.ComponentModel.Description("SuggestedActions that can be performed")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.SuggestedActions suggestedActions {get; set;} 

        [System.ComponentModel.Description("Attachments")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Attachment[] attachments {get; set;} 

        [System.ComponentModel.Description("Represents the entities that were mentioned in the message.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Entity[] entities {get; set;} 

        [System.ComponentModel.Description("Contains channel-specific content.")]
        public object channelData {get; set;} 

        [System.ComponentModel.Description("Indicates whether the recipient of a contactRelationUpdate was added or removed from the sender's contact list.")]
        public string action {get; set;} 

        [System.ComponentModel.Description("Contains the ID of the message to which this message is a reply.")]
        public string replyToId {get; set;} 

        [System.ComponentModel.Description("A descriptive label for the activity.")]
        public string label {get; set;} 

        [System.ComponentModel.Description("The type of the activity's value object.")]
        public string valueType {get; set;} 

        [System.ComponentModel.Description("A value that is associated with the activity.")]
        public object value {get; set;} 

        [System.ComponentModel.Description("The name of the operation associated with an invoke or event activity.")]
        public string name {get; set;} 

        [System.ComponentModel.Description("An object relating to a particular point in a conversation")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationReference relatesTo {get; set;} 

        [System.ComponentModel.Description("Codes indicating why a conversation has ended")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.code code {get; set;} 

        [System.ComponentModel.Description("The time at which the activity should be considered to be 'expired' and should not be presented to the recipient.")]
        public DateTime expiration {get; set;} 

        [System.ComponentModel.Description("Defines the importance of an Activity")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.importance importance {get; set;} 

        [System.ComponentModel.Description("Values for deliveryMode field")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.deliveryMode deliveryMode {get; set;} 

        [System.ComponentModel.Description("List of phrases and references that speech and language priming systems should listen for")]
        public string[] listenFor {get; set;} 

        [System.ComponentModel.Description("The collection of text fragments to highlight when the activity contains a ReplyToId value.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.TextHighlight[] textHighlights {get; set;} 

        [System.ComponentModel.Description("Represents a reference to a programmatic action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.SemanticAction semanticAction {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
    public class ConversationAccount{
        [System.ComponentModel.Description("Indicates whether the conversation contains more than two participants at the time the activity was generated")]
        public bool isGroup {get; set;} 

        [System.ComponentModel.Description("Indicates the type of the conversation in channels that distinguish between conversation types")]
        public string conversationType {get; set;} 

        [System.ComponentModel.Description("This conversation's tenant ID")]
        public string tenantId {get; set;} 

        [System.ComponentModel.Description("Channel id for the user or bot on this channel (Example: joe@smith.com, or @joesmith or 123456)")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Display friendly name")]
        public string name {get; set;} 

        [System.ComponentModel.Description("This account's object ID within Azure Active Directory (AAD)")]
        public string aadObjectId {get; set;} 

        [System.ComponentModel.Description("Role of the entity behind the account (Example: User, Bot, etc.)")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.role_1 role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Message reaction object")]
    public class MessageReaction{
        [System.ComponentModel.Description("Message reaction types")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type_1 type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("SuggestedActions that can be performed")]
    public class SuggestedActions{
        [System.ComponentModel.Description("Ids of the recipients that the actions should be shown to.  These Ids are relative to the channelId and a subset of all recipients of the activity")]
        public string[] to {get; set;} 

        [System.ComponentModel.Description("Actions that can be shown to the user")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] actions {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An attachment within an activity")]
    public class Attachment{
        [System.ComponentModel.Description("mimetype/Contenttype for the file")]
        public string contentType {get; set;} 

        [System.ComponentModel.Description("Content Url")]
        public string contentUrl {get; set;} 

        [System.ComponentModel.Description("Embedded content")]
        public object content {get; set;} 

        [System.ComponentModel.Description("(OPTIONAL) The name of the attachment")]
        public string name {get; set;} 

        [System.ComponentModel.Description("(OPTIONAL) Thumbnail associated with attachment")]
        public string thumbnailUrl {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Metadata object pertaining to an activity")]
    public class Entity{
        [System.ComponentModel.Description("Type of this entity (RFC 3987 IRI)")]
        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An object relating to a particular point in a conversation")]
    public class ConversationReference{
        [System.ComponentModel.Description("(Optional) ID of the activity to refer to")]
        public string activityId {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount user {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount bot {get; set;} 

        [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationAccount conversation {get; set;} 

        [System.ComponentModel.Description("Channel ID")]
        public string channelId {get; set;} 

        [System.ComponentModel.Description("Service endpoint where operations concerning the referenced conversation may be performed")]
        public string serviceUrl {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Refers to a substring of content within another field")]
    public class TextHighlight{
        [System.ComponentModel.Description("Defines the snippet of text to highlight")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Occurrence of the text field within the referenced text, if multiple exist.")]
        public int occurrence {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Represents a reference to a programmatic action")]
    public class SemanticAction{
        [System.ComponentModel.Description("Indicates whether the semantic action is starting, continuing, or done")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.state state {get; set;} 

        [System.ComponentModel.Description("ID of this action")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Entities associated with this action")]
        public object entities {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A clickable action")]
    public class CardAction{
        [System.ComponentModel.Description("Defines action types for clickable buttons.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type_2 type {get; set;} 

        [System.ComponentModel.Description("Text description which appears on the button")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Image URL which will appear on the button, next to text label")]
        public string image {get; set;} 

        [System.ComponentModel.Description("Text for this action")]
        public string text {get; set;} 

        [System.ComponentModel.Description("(Optional) text to display in the chat feed if the button is clicked")]
        public string displayText {get; set;} 

        [System.ComponentModel.Description("Supplementary parameter for action. Content of this property depends on the ActionType")]
        public object value {get; set;} 

        [System.ComponentModel.Description("Channel-specific data associated with this action")]
        public object channelData {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A response containing a resource")]
    public class ConversationResourceResponse{
        [System.ComponentModel.Description("ID of the Activity (if sent)")]
        public string activityId {get; set;} 

        [System.ComponentModel.Description("Service endpoint where operations concerning the conversation may be performed")]
        public string serviceUrl {get; set;} 

        [System.ComponentModel.Description("Id of the resource")]
        public string id {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversations result")]
    public class ConversationsResult{
        [System.ComponentModel.Description("Paging token")]
        public string continuationToken {get; set;} 

        [System.ComponentModel.Description("List of conversations")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationMembers[] conversations {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversation and its members")]
    public class ConversationMembers{
        [System.ComponentModel.Description("Conversation ID")]
        public string id {get; set;} 

        [System.ComponentModel.Description("List of members in this conversation")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A response containing a resource ID")]
    public class ResourceResponse{
        [System.ComponentModel.Description("Id of the resource")]
        public string id {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Transcript")]
    public class Transcript{
        [System.ComponentModel.Description("A collection of Activities that conforms to the Transcript schema.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Activity[] activities {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Page of members.")]
    public class PagedMembersResult{
        [System.ComponentModel.Description("Paging token")]
        public string continuationToken {get; set;} 

        [System.ComponentModel.Description("The Channel Accounts.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Attachment data")]
    public class AttachmentData{
        [System.ComponentModel.Description("Content-Type of the attachment")]
        public string type {get; set;} 

        [System.ComponentModel.Description("Name of the attachment")]
        public string name {get; set;} 

        [System.ComponentModel.Description("Attachment content")]
        public string originalBase64 {get; set;} 

        [System.ComponentModel.Description("Attachment thumbnail")]
        public string thumbnailBase64 {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A Hero card (card with a single, large image)")]
    public class HeroCard{
        [System.ComponentModel.Description("Title of the card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of the card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text for the card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Array of images for the card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An image on a card")]
    public class CardImage{
        [System.ComponentModel.Description("URL thumbnail image for major content property")]
        public string url {get; set;} 

        [System.ComponentModel.Description("Image description intended for screen readers")]
        public string alt {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An animation card (Ex: gif or short video clip)")]
    public class AnimationCard{
        [System.ComponentModel.Description("Title of this card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of this card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text of this card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Thumbnail URL")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("This content may be shared with others (default:true)")]
        public bool shareable {get; set;} 

        [System.ComponentModel.Description("Should the client loop playback at end of content (default:true)")]
        public bool autoloop {get; set;} 

        [System.ComponentModel.Description("Should the client automatically start playback of media in this card (default:true)")]
        public bool autostart {get; set;} 

        [System.ComponentModel.Description("Aspect ratio of thumbnail/media placeholder. Allowed values are '16:9' and '4:3'")]
        public string aspect {get; set;} 

        [System.ComponentModel.Description("Describes the length of the media content without requiring a receiver to open the content. Formatted as an ISO 8601 Duration field.")]
        public string duration {get; set;} 

        [System.ComponentModel.Description("Supplementary parameter for this card")]
        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Thumbnail URL")]
    public class ThumbnailUrl{
        [System.ComponentModel.Description("URL pointing to the thumbnail to use for media content")]
        public string url {get; set;} 

        [System.ComponentModel.Description("HTML alt text to include on this thumbnail image")]
        public string alt {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Media URL")]
    public class MediaUrl{
        [System.ComponentModel.Description("Url for the media")]
        public string url {get; set;} 

        [System.ComponentModel.Description("Optional profile hint to the client to differentiate multiple MediaUrl objects from each other")]
        public string profile {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Audio card")]
    public class AudioCard{
        [System.ComponentModel.Description("Title of this card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of this card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text of this card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Thumbnail URL")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("This content may be shared with others (default:true)")]
        public bool shareable {get; set;} 

        [System.ComponentModel.Description("Should the client loop playback at end of content (default:true)")]
        public bool autoloop {get; set;} 

        [System.ComponentModel.Description("Should the client automatically start playback of media in this card (default:true)")]
        public bool autostart {get; set;} 

        [System.ComponentModel.Description("Aspect ratio of thumbnail/media placeholder. Allowed values are '16:9' and '4:3'")]
        public string aspect {get; set;} 

        [System.ComponentModel.Description("Describes the length of the media content without requiring a receiver to open the content. Formatted as an ISO 8601 Duration field.")]
        public string duration {get; set;} 

        [System.ComponentModel.Description("Supplementary parameter for this card")]
        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A basic card")]
    public class BasicCard{
        [System.ComponentModel.Description("Title of the card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of the card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text for the card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Array of images for the card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Media card")]
    public class MediaCard{
        [System.ComponentModel.Description("Title of this card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of this card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text of this card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Thumbnail URL")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("This content may be shared with others (default:true)")]
        public bool shareable {get; set;} 

        [System.ComponentModel.Description("Should the client loop playback at end of content (default:true)")]
        public bool autoloop {get; set;} 

        [System.ComponentModel.Description("Should the client automatically start playback of media in this card (default:true)")]
        public bool autostart {get; set;} 

        [System.ComponentModel.Description("Aspect ratio of thumbnail/media placeholder. Allowed values are '16:9' and '4:3'")]
        public string aspect {get; set;} 

        [System.ComponentModel.Description("Describes the length of the media content without requiring a receiver to open the content. Formatted as an ISO 8601 Duration field.")]
        public string duration {get; set;} 

        [System.ComponentModel.Description("Supplementary parameter for this card")]
        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A receipt card")]
    public class ReceiptCard{
        [System.ComponentModel.Description("Title of the card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Array of Fact objects")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Fact[] facts {get; set;} 

        [System.ComponentModel.Description("Array of Receipt Items")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ReceiptItem[] items {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

        [System.ComponentModel.Description("Total amount of money paid (or to be paid)")]
        public string total {get; set;} 

        [System.ComponentModel.Description("Total amount of tax paid (or to be paid)")]
        public string tax {get; set;} 

        [System.ComponentModel.Description("Total amount of VAT paid (or to be paid)")]
        public string vat {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Set of key-value pairs. Advantage of this section is that key and value properties will be \r\nrendered with default style information with some delimiter between them. So there is no need for developer to specify style information.")]
    public class Fact{
        [System.ComponentModel.Description("The key for this Fact")]
        public string key {get; set;} 

        [System.ComponentModel.Description("The value for this Fact")]
        public string value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An item on a receipt card")]
    public class ReceiptItem{
        [System.ComponentModel.Description("Title of the Card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle appears just below Title field, differs from Title in font styling only")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text field appears just below subtitle, differs from Subtitle in font styling only")]
        public string text {get; set;} 

        [System.ComponentModel.Description("An image on a card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage image {get; set;} 

        [System.ComponentModel.Description("Amount with currency")]
        public string price {get; set;} 

        [System.ComponentModel.Description("Number of items of given kind")]
        public string quantity {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to sign in")]
    public class SigninCard{
        [System.ComponentModel.Description("Text for signin request")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Action to use to perform signin")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to perform a sign in via OAuth")]
    public class OAuthCard{
        [System.ComponentModel.Description("Text for signin request")]
        public string text {get; set;} 

        [System.ComponentModel.Description("The name of the registered connection")]
        public string connectionName {get; set;} 

        [System.ComponentModel.Description("Action to use to perform signin")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A thumbnail card (card with a single, small thumbnail image)")]
    public class ThumbnailCard{
        [System.ComponentModel.Description("Title of the card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of the card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text for the card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Array of images for the card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Video card")]
    public class VideoCard{
        [System.ComponentModel.Description("Title of this card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of this card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text of this card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Thumbnail URL")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("This content may be shared with others (default:true)")]
        public bool shareable {get; set;} 

        [System.ComponentModel.Description("Should the client loop playback at end of content (default:true)")]
        public bool autoloop {get; set;} 

        [System.ComponentModel.Description("Should the client automatically start playback of media in this card (default:true)")]
        public bool autostart {get; set;} 

        [System.ComponentModel.Description("Aspect ratio of thumbnail/media placeholder. Allowed values are '16:9' and '4:3'")]
        public string aspect {get; set;} 

        [System.ComponentModel.Description("Describes the length of the media content without requiring a receiver to open the content. Formatted as an ISO 8601 Duration field.")]
        public string duration {get; set;} 

        [System.ComponentModel.Description("Supplementary parameter for this card")]
        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("GeoCoordinates (entity type: 'https://schema.org/GeoCoordinates')")]
    public class GeoCoordinates{
        [System.ComponentModel.Description("Elevation of the location [WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)")]
        public double elevation {get; set;} 

        [System.ComponentModel.Description("Latitude of the location [WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)")]
        public double latitude {get; set;} 

        [System.ComponentModel.Description("Longitude of the location [WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)")]
        public double longitude {get; set;} 

        [System.ComponentModel.Description("The type of the thing")]
        public string type {get; set;} 

        [System.ComponentModel.Description("The name of the thing")]
        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Mention information (entity type: 'mention')")]
    public class Mention{
        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount mentioned {get; set;} 

        [System.ComponentModel.Description("Sub Text which represents the mention (can be null or empty)")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Type of this entity (RFC 3987 IRI)")]
        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Place (entity type: 'https://schema.org/Place')")]
    public class Place{
        [System.ComponentModel.Description("Address of the place (may be `string` or complex object of type `PostalAddress`)")]
        public object address {get; set;} 

        [System.ComponentModel.Description("Geo coordinates of the place (may be complex object of type `GeoCoordinates` or `GeoShape`)")]
        public object geo {get; set;} 

        [System.ComponentModel.Description("Map to the place (may be `string` (URL) or complex object of type `Map`)")]
        public object hasMap {get; set;} 

        [System.ComponentModel.Description("The type of the thing")]
        public string type {get; set;} 

        [System.ComponentModel.Description("The name of the thing")]
        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Thing (entity type: 'https://schema.org/Thing')")]
    public class Thing{
        [System.ComponentModel.Description("The type of the thing")]
        public string type {get; set;} 

        [System.ComponentModel.Description("The name of the thing")]
        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Supplementary parameter for media events")]
    public class MediaEventValue{
        [System.ComponentModel.Description("Callback parameter specified in the Value field of the MediaCard that originated this event")]
        public object cardValue {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A request to receive a user token")]
    public class TokenRequest{
        [System.ComponentModel.Description("The provider to request a user token from")]
        public string provider {get; set;} 

        [System.ComponentModel.Description("A collection of settings for the specific provider for this request")]
        public object settings {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A response that includes a user token")]
    public class TokenResponse{
        [System.ComponentModel.Description("The channelId of the TokenResponse")]
        public string channelId {get; set;} 

        [System.ComponentModel.Description("The connection name")]
        public string connectionName {get; set;} 

        [System.ComponentModel.Description("The user token")]
        public string token {get; set;} 

        [System.ComponentModel.Description("Expiration for the token, in ISO 8601 format (e.g. '2007-04-05T14:30Z')")]
        public string expiration {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Types of Activities")]
    public class ActivityTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Attachment layout types")]
    public class AttachmentLayoutTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates whether the semantic action is starting, continuing, or done")]
    public class SemanticActionStates{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Defines action types for clickable buttons.")]
    public class ActionTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Action types valid for ContactRelationUpdate activities")]
    public class ContactRelationUpdateActionTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Action types valid for InstallationUpdate activities")]
    public class InstallationUpdateActionTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Message reaction types")]
    public class MessageReactionTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Text format types")]
    public class TextFormatTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates whether the bot is accepting, expecting, or ignoring input")]
    public class InputHints{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Codes indicating why a conversation has ended")]
    public class EndOfConversationCodes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Defines the importance of an Activity")]
    public class ActivityImportance{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Role of the entity behind the account (Example: User, Bot, etc.)")]
    public class RoleTypes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Values for deliveryMode field")]
    public class DeliveryModes{

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("W3C Payment Method Data for Microsoft Pay")]
    public class MicrosoftPayMethodData{
        [System.ComponentModel.Description("Microsoft Pay Merchant ID")]
        public string merchantId {get; set;} 

        [System.ComponentModel.Description("Supported payment networks (e.g., 'visa' and 'mastercard')")]
        public string[] supportedNetworks {get; set;} 

        [System.ComponentModel.Description("Supported payment types (e.g., 'credit')")]
        public string[] supportedTypes {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Address within a Payment Request")]
    public class PaymentAddress{
        [System.ComponentModel.Description("This is the CLDR (Common Locale Data Repository) region code. For example, US, GB, CN, or JP")]
        public string country {get; set;} 

        [System.ComponentModel.Description("This is the most specific part of the address. It can include, for example, a street name, a house number, apartment number, a rural delivery route, descriptive instructions, or a post office box number.")]
        public string[] addressLine {get; set;} 

        [System.ComponentModel.Description("This is the top level administrative subdivision of the country. For example, this can be a state, a province, an oblast, or a prefecture.")]
        public string region {get; set;} 

        [System.ComponentModel.Description("This is the city/town portion of the address.")]
        public string city {get; set;} 

        [System.ComponentModel.Description("This is the dependent locality or sublocality within a city. For example, used for neighborhoods, boroughs, districts, or UK dependent localities.")]
        public string dependentLocality {get; set;} 

        [System.ComponentModel.Description("This is the postal code or ZIP code, also known as PIN code in India.")]
        public string postalCode {get; set;} 

        [System.ComponentModel.Description("This is the sorting code as used in, for example, France.")]
        public string sortingCode {get; set;} 

        [System.ComponentModel.Description("This is the BCP-47 language code for the address. It's used to determine the field separators and the order of fields when formatting the address for display.")]
        public string languageCode {get; set;} 

        [System.ComponentModel.Description("This is the organization, firm, company, or institution at this address.")]
        public string organization {get; set;} 

        [System.ComponentModel.Description("This is the name of the recipient or contact person.")]
        public string recipient {get; set;} 

        [System.ComponentModel.Description("This is the phone number of the recipient or contact person.")]
        public string phone {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Supplies monetary amounts")]
    public class PaymentCurrencyAmount{
        [System.ComponentModel.Description("A currency identifier")]
        public string currency {get; set;} 

        [System.ComponentModel.Description("Decimal monetary value")]
        public string value {get; set;} 

        [System.ComponentModel.Description("Currency system")]
        public string currencySystem {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides information about the requested transaction")]
    public class PaymentDetails{
        [System.ComponentModel.Description("Indicates what the payment request is for and the value asked for")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem total {get; set;} 

        [System.ComponentModel.Description("Contains line items for the payment request that the user agent may display")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem[] displayItems {get; set;} 

        [System.ComponentModel.Description("A sequence containing the different shipping options for the user to choose from")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentShippingOption[] shippingOptions {get; set;} 

        [System.ComponentModel.Description("Contains modifiers for particular payment method identifiers")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetailsModifier[] modifiers {get; set;} 

        [System.ComponentModel.Description("Error description")]
        public string error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates what the payment request is for and the value asked for")]
    public class PaymentItem{
        [System.ComponentModel.Description("Human-readable description of the item")]
        public string label {get; set;} 

        [System.ComponentModel.Description("Supplies monetary amounts")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentCurrencyAmount amount {get; set;} 

        [System.ComponentModel.Description("When set to true this flag means that the amount field is not final.")]
        public bool pending {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Describes a shipping option")]
    public class PaymentShippingOption{
        [System.ComponentModel.Description("String identifier used to reference this PaymentShippingOption")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Human-readable description of the item")]
        public string label {get; set;} 

        [System.ComponentModel.Description("Supplies monetary amounts")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentCurrencyAmount amount {get; set;} 

        [System.ComponentModel.Description("Indicates whether this is the default selected PaymentShippingOption")]
        public bool selected {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides details that modify the PaymentDetails based on payment method identifier")]
    public class PaymentDetailsModifier{
        [System.ComponentModel.Description("Contains a sequence of payment method identifiers")]
        public string[] supportedMethods {get; set;} 

        [System.ComponentModel.Description("Indicates what the payment request is for and the value asked for")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem total {get; set;} 

        [System.ComponentModel.Description("Provides additional display items that are appended to the displayItems field in the PaymentDetails dictionary for the payment method identifiers in the supportedMethods field")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem[] additionalDisplayItems {get; set;} 

        [System.ComponentModel.Description("A JSON-serializable object that provides optional information that might be needed by the supported payment methods")]
        public object data {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates a set of supported payment methods and any associated payment method specific data for those methods")]
    public class PaymentMethodData{
        [System.ComponentModel.Description("Required sequence of strings containing payment method identifiers for payment methods that the merchant web site accepts")]
        public string[] supportedMethods {get; set;} 

        [System.ComponentModel.Description("A JSON-serializable object that provides optional information that might be needed by the supported payment methods")]
        public object data {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides information about the options desired for the payment request")]
    public class PaymentOptions{
        [System.ComponentModel.Description("Indicates whether the user agent should collect and return the payer's name as part of the payment request")]
        public bool requestPayerName {get; set;} 

        [System.ComponentModel.Description("Indicates whether the user agent should collect and return the payer's email address as part of the payment request")]
        public bool requestPayerEmail {get; set;} 

        [System.ComponentModel.Description("Indicates whether the user agent should collect and return the payer's phone number as part of the payment request")]
        public bool requestPayerPhone {get; set;} 

        [System.ComponentModel.Description("Indicates whether the user agent should collect and return a shipping address as part of the payment request")]
        public bool requestShipping {get; set;} 

        [System.ComponentModel.Description("If requestShipping is set to true, then the shippingType field may be used to influence the way the user agent presents the user interface for gathering the shipping address")]
        public string shippingType {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A request to make a payment")]
    public class PaymentRequest{
        [System.ComponentModel.Description("ID of this payment request")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Allowed payment methods for this request")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentMethodData[] methodData {get; set;} 

        [System.ComponentModel.Description("Provides information about the requested transaction")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

        [System.ComponentModel.Description("Provides information about the options desired for the payment request")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentOptions options {get; set;} 

        [System.ComponentModel.Description("Expiration for this request, in ISO 8601 duration format (e.g., 'P1D')")]
        public string expires {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Payload delivered when completing a payment request")]
    public class PaymentRequestComplete{
        [System.ComponentModel.Description("Payment request ID")]
        public string id {get; set;} 

        [System.ComponentModel.Description("A request to make a payment")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentRequest paymentRequest {get; set;} 

        [System.ComponentModel.Description("A PaymentResponse is returned when a user has selected a payment method and approved a payment request")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentResponse paymentResponse {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A PaymentResponse is returned when a user has selected a payment method and approved a payment request")]
    public class PaymentResponse{
        [System.ComponentModel.Description("The payment method identifier for the payment method that the user selected to fulfil the transaction")]
        public string methodName {get; set;} 

        [System.ComponentModel.Description("A JSON-serializable object that provides a payment method specific message used by the merchant to process the transaction and determine successful fund transfer")]
        public object details {get; set;} 

        [System.ComponentModel.Description("Address within a Payment Request")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentAddress shippingAddress {get; set;} 

        [System.ComponentModel.Description("If the requestShipping flag was set to true in the PaymentOptions passed to the PaymentRequest constructor, then shippingOption will be the id attribute of the selected shipping option")]
        public string shippingOption {get; set;} 

        [System.ComponentModel.Description("If the requestPayerEmail flag was set to true in the PaymentOptions passed to the PaymentRequest constructor, then payerEmail will be the email address chosen by the user")]
        public string payerEmail {get; set;} 

        [System.ComponentModel.Description("If the requestPayerPhone flag was set to true in the PaymentOptions passed to the PaymentRequest constructor, then payerPhone will be the phone number chosen by the user")]
        public string payerPhone {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Result from a completed payment request")]
    public class PaymentRequestCompleteResult{
        [System.ComponentModel.Description("Result of the payment request completion")]
        public string result {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An update to a payment request")]
    public class PaymentRequestUpdate{
        [System.ComponentModel.Description("ID for the payment request to update")]
        public string id {get; set;} 

        [System.ComponentModel.Description("Provides information about the requested transaction")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

        [System.ComponentModel.Description("Address within a Payment Request")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentAddress shippingAddress {get; set;} 

        [System.ComponentModel.Description("Updated shipping options")]
        public string shippingOption {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A result object from a Payment Request Update invoke operation")]
    public class PaymentRequestUpdateResult{
        [System.ComponentModel.Description("Provides information about the requested transaction")]
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

    }

}
