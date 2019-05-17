
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hummingbird.TestFramework.Services;

namespace Hummingbird.MS.Bot.Bot_Framework.Direct_Line
{

    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Parameters for creating a token")]
    public class TokenParameters{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount user {get; set;} 

        public string[] trustedOrigins {get; set;} 

        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Channel account information needed to route a message")]
    public class ChannelAccount{
        public string id {get; set;} 

        public string name {get; set;} 

        public string aadObjectId {get; set;} 

        public string role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An object representing a conversation or a conversation token")]
    public class Conversation{
        public string conversationId {get; set;} 

        public string token {get; set;} 

        public int expires_in {get; set;} 

        public string streamUrl {get; set;} 

        public string referenceGrammarId {get; set;} 

        public string eTag {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A collection of activities")]
    public class ActivitySet{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Activity[] activities {get; set;} 

        public string watermark {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An Activity is the basic communication type for the Bot Framework 3.0 protocol.")]
    public class Activity{
        public string type {get; set;} 

        public string id {get; set;} 

        public DateTime timestamp {get; set;} 

        public DateTime localTimestamp {get; set;} 

        public string localTimezone {get; set;} 

        public string serviceUrl {get; set;} 

        public string channelId {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount from {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ConversationAccount conversation {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount recipient {get; set;} 

        public string textFormat {get; set;} 

        public string attachmentLayout {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount[] membersAdded {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount[] membersRemoved {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MessageReaction[] reactionsAdded {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MessageReaction[] reactionsRemoved {get; set;} 

        public string topicName {get; set;} 

        public bool historyDisclosed {get; set;} 

        public string locale {get; set;} 

        public string text {get; set;} 

        public string speak {get; set;} 

        public string inputHint {get; set;} 

        public string summary {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.SuggestedActions suggestedActions {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Attachment[] attachments {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Entity[] entities {get; set;} 

        public object channelData {get; set;} 

        public string action {get; set;} 

        public string replyToId {get; set;} 

        public string label {get; set;} 

        public string valueType {get; set;} 

        public object value {get; set;} 

        public string name {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ConversationReference relatesTo {get; set;} 

        public string code {get; set;} 

        public DateTime expiration {get; set;} 

        public string importance {get; set;} 

        public string deliveryMode {get; set;} 

        public string[] listenFor {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.TextHighlight[] textHighlights {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.SemanticAction semanticAction {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversation account represents the identity of the conversation within a channel")]
    public class ConversationAccount{
        public bool isGroup {get; set;} 

        public string conversationType {get; set;} 

        public string tenantId {get; set;} 

        public string id {get; set;} 

        public string name {get; set;} 

        public string aadObjectId {get; set;} 

        public string role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Message reaction object")]
    public class MessageReaction{
        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("SuggestedActions that can be performed")]
    public class SuggestedActions{
        public string[] to {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] actions {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An attachment within an activity")]
    public class Attachment{
        public string contentType {get; set;} 

        public string contentUrl {get; set;} 

        public object content {get; set;} 

        public string name {get; set;} 

        public string thumbnailUrl {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Metadata object pertaining to an activity")]
    public class Entity{
        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An object relating to a particular point in a conversation")]
    public class ConversationReference{
        public string activityId {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount user {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount bot {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ConversationAccount conversation {get; set;} 

        public string channelId {get; set;} 

        public string serviceUrl {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Refers to a substring of content within another field")]
    public class TextHighlight{
        public string text {get; set;} 

        public int occurrence {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Represents a reference to a programmatic action")]
    public class SemanticAction{
        public string state {get; set;} 

        public string id {get; set;} 

        public object entities {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A clickable action")]
    public class CardAction{
        public string type {get; set;} 

        public string title {get; set;} 

        public string image {get; set;} 

        public string text {get; set;} 

        public string displayText {get; set;} 

        public object value {get; set;} 

        public object channelData {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A response containing a resource ID")]
    public class ResourceResponse{
        public string id {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A Hero card (card with a single, large image)")]
    public class HeroCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An image on a card")]
    public class CardImage{
        public string url {get; set;} 

        public string alt {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An HTTP API response")]
    public class ErrorResponse{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Error error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Object representing error information")]
    public class Error{
        public string code {get; set;} 

        public string message {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.InnerHttpError innerHttpError {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Object representing inner http error")]
    public class InnerHttpError{
        public int statusCode {get; set;} 

        public object body {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An animation card (Ex: gif or short video clip)")]
    public class AnimationCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public bool shareable {get; set;} 

        public bool autoloop {get; set;} 

        public bool autostart {get; set;} 

        public string aspect {get; set;} 

        public string duration {get; set;} 

        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Thumbnail URL")]
    public class ThumbnailUrl{
        public string url {get; set;} 

        public string alt {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Media URL")]
    public class MediaUrl{
        public string url {get; set;} 

        public string profile {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Audio card")]
    public class AudioCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public bool shareable {get; set;} 

        public bool autoloop {get; set;} 

        public bool autostart {get; set;} 

        public string aspect {get; set;} 

        public string duration {get; set;} 

        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A basic card")]
    public class BasicCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Media card")]
    public class MediaCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public bool shareable {get; set;} 

        public bool autoloop {get; set;} 

        public bool autostart {get; set;} 

        public string aspect {get; set;} 

        public string duration {get; set;} 

        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A receipt card")]
    public class ReceiptCard{
        public string title {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.Fact[] facts {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ReceiptItem[] items {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

        public string total {get; set;} 

        public string tax {get; set;} 

        public string vat {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Set of key-value pairs. Advantage of this section is that key and value properties will be \r\nrendered with default style information with some delimiter between them. So there is no need for developer to specify style information.")]
    public class Fact{
        public string key {get; set;} 

        public string value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An item on a receipt card")]
    public class ReceiptItem{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardImage image {get; set;} 

        public string price {get; set;} 

        public string quantity {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to sign in")]
    public class SigninCard{
        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to perform a sign in via OAuth")]
    public class OAuthCard{
        public string text {get; set;} 

        public string connectionName {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A thumbnail card (card with a single, small thumbnail image)")]
    public class ThumbnailCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Video card")]
    public class VideoCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.CardAction[] buttons {get; set;} 

        public bool shareable {get; set;} 

        public bool autoloop {get; set;} 

        public bool autostart {get; set;} 

        public string aspect {get; set;} 

        public string duration {get; set;} 

        public object value {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("GeoCoordinates (entity type: 'https://schema.org/GeoCoordinates')")]
    public class GeoCoordinates{
        public double elevation {get; set;} 

        public double latitude {get; set;} 

        public double longitude {get; set;} 

        public string type {get; set;} 

        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Mention information (entity type: 'mention')")]
    public class Mention{
        public Hummingbird.MS.Bot.Bot_Framework.Direct_Line.ChannelAccount mentioned {get; set;} 

        public string text {get; set;} 

        public string type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Place (entity type: 'https://schema.org/Place')")]
    public class Place{
        public object address {get; set;} 

        public object geo {get; set;} 

        public object hasMap {get; set;} 

        public string type {get; set;} 

        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Thing (entity type: 'https://schema.org/Thing')")]
    public class Thing{
        public string type {get; set;} 

        public string name {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A request to receive a user token")]
    public class TokenRequest{
        public string provider {get; set;} 

        public object settings {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A response that includes a user token")]
    public class TokenResponse{
        public string channelId {get; set;} 

        public string connectionName {get; set;} 

        public string token {get; set;} 

        public string expiration {get; set;} 

    }

}
