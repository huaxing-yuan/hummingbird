
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30
{

    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Parameters for creating a token")]
    public class TokenParameters{
        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount user {get; set;} 

        [System.ComponentModel.Description("Trusted origins to embed within the token")]
        public string[] trustedOrigins {get; set;} 

        
        public string eTag {get; set;} 

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
        public string role {get; set;} 

    }


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

        [System.ComponentModel.Description("URL for this conversation's message stream")]
        public string streamUrl {get; set;} 

        [System.ComponentModel.Description("ID for the reference grammar for this bot")]
        public string referenceGrammarId {get; set;} 

        
        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A collection of activities")]
    public class ActivitySet{
        [System.ComponentModel.Description("Activities")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Activity[] activities {get; set;} 

        [System.ComponentModel.Description("Maximum watermark of activities within this set")]
        public string watermark {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An Activity is the basic communication type for the Bot Framework 3.0 protocol.")]
    public class Activity{
        [System.ComponentModel.Description("Contains the activity type.")]
        public string type {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount from {get; set;} 

        [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ConversationAccount conversation {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount recipient {get; set;} 

        [System.ComponentModel.Description("Format of text fields Default:markdown")]
        public string textFormat {get; set;} 

        [System.ComponentModel.Description("The layout hint for multiple attachments. Default: list.")]
        public string attachmentLayout {get; set;} 

        [System.ComponentModel.Description("The collection of members added to the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount[] membersAdded {get; set;} 

        [System.ComponentModel.Description("The collection of members removed from the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount[] membersRemoved {get; set;} 

        [System.ComponentModel.Description("The collection of reactions added to the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MessageReaction[] reactionsAdded {get; set;} 

        [System.ComponentModel.Description("The collection of reactions removed from the conversation.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MessageReaction[] reactionsRemoved {get; set;} 

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

        [System.ComponentModel.Description("Indicates whether your bot is accepting,\r\nexpecting, or ignoring user input after the message is delivered to the client.")]
        public string inputHint {get; set;} 

        [System.ComponentModel.Description("The text to display if the channel cannot render cards.")]
        public string summary {get; set;} 

        [System.ComponentModel.Description("SuggestedActions that can be performed")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.SuggestedActions suggestedActions {get; set;} 

        [System.ComponentModel.Description("Attachments")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Attachment[] attachments {get; set;} 

        [System.ComponentModel.Description("Represents the entities that were mentioned in the message.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Entity[] entities {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ConversationReference relatesTo {get; set;} 

        [System.ComponentModel.Description("The a code for endOfConversation activities that indicates why the conversation ended.")]
        public string code {get; set;} 

        [System.ComponentModel.Description("The time at which the activity should be considered to be 'expired' and should not be presented to the recipient.")]
        public DateTime expiration {get; set;} 

        [System.ComponentModel.Description("The importance of the activity.")]
        public string importance {get; set;} 

        [System.ComponentModel.Description("A delivery hint to signal to the recipient alternate delivery paths for the activity.\r\nThe default delivery mode is 'default'.")]
        public string deliveryMode {get; set;} 

        [System.ComponentModel.Description("List of phrases and references that speech and language priming systems should listen for")]
        public string[] listenFor {get; set;} 

        [System.ComponentModel.Description("The collection of text fragments to highlight when the activity contains a ReplyToId value.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.TextHighlight[] textHighlights {get; set;} 

        [System.ComponentModel.Description("Represents a reference to a programmatic action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.SemanticAction semanticAction {get; set;} 

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
        public string role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Message reaction object")]
    public class MessageReaction{
        [System.ComponentModel.Description("Message reaction type")]
        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("SuggestedActions that can be performed")]
    public class SuggestedActions{
        [System.ComponentModel.Description("Ids of the recipients that the actions should be shown to.  These Ids are relative to the channelId and a subset of all recipients of the activity")]
        public string[] to {get; set;} 

        [System.ComponentModel.Description("Actions that can be shown to the user")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] actions {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount user {get; set;} 

        [System.ComponentModel.Description("Channel account information needed to route a message")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount bot {get; set;} 

        [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ConversationAccount conversation {get; set;} 

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
        [System.ComponentModel.Description("State of this action. Allowed values: `start`, `continue`, `done`")]
        public string state {get; set;} 

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
        [System.ComponentModel.Description("The type of action implemented by this button")]
        public string type {get; set;} 

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
    [System.ComponentModel.Description("A response containing a resource ID")]
    public class ResourceResponse{
        [System.ComponentModel.Description("Id of the resource")]
        public string id {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An HTTP API response")]
    public class ErrorResponse{
        [System.ComponentModel.Description("Object representing error information")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Error error {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.InnerHttpError innerHttpError {get; set;} 

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
    [System.ComponentModel.Description("An animation card (Ex: gif or short video clip)")]
    public class AnimationCard{
        [System.ComponentModel.Description("Title of this card")]
        public string title {get; set;} 

        [System.ComponentModel.Description("Subtitle of this card")]
        public string subtitle {get; set;} 

        [System.ComponentModel.Description("Text of this card")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Thumbnail URL")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.Fact[] facts {get; set;} 

        [System.ComponentModel.Description("Array of Receipt Items")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ReceiptItem[] items {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

        [System.ComponentModel.Description("Total amount of money paid (or to be paid)")]
        public string total {get; set;} 

        [System.ComponentModel.Description("Total amount of tax paid (or to be paid)")]
        public string tax {get; set;} 

        [System.ComponentModel.Description("Total amount of VAT paid (or to be paid)")]
        public string vat {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardImage image {get; set;} 

        [System.ComponentModel.Description("Amount with currency")]
        public string price {get; set;} 

        [System.ComponentModel.Description("Number of items of given kind")]
        public string quantity {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to sign in")]
    public class SigninCard{
        [System.ComponentModel.Description("Text for signin request")]
        public string text {get; set;} 

        [System.ComponentModel.Description("Action to use to perform signin")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardImage[] images {get; set;} 

        [System.ComponentModel.Description("Set of actions applicable to the current card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

        [System.ComponentModel.Description("A clickable action")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction tap {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ThumbnailUrl image {get; set;} 

        [System.ComponentModel.Description("Media URLs for this card. When this field contains more than one URL, each URL is an alternative format of the same content.")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.MediaUrl[] media {get; set;} 

        [System.ComponentModel.Description("Actions on this card")]
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line_30.ChannelAccount mentioned {get; set;} 

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

}
