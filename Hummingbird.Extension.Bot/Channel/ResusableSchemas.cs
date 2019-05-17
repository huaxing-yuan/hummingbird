
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
        public string name {get; set;} 

        public string type {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.AttachmentView[] views {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Attachment View name and size")]
    public class AttachmentView{
        public string viewId {get; set;} 

        public int size {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An HTTP API response")]
    public class ErrorResponse{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Error error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Object representing error information")]
    public class Error{
        public string code {get; set;} 

        public string message {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.InnerHttpError innerHttpError {get; set;} 

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
    [System.ComponentModel.Description("Parameters for creating a new conversation")]
    public class ConversationParameters{
        public bool isGroup {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount bot {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

        public string topicName {get; set;} 

        public string tenantId {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.Activity activity {get; set;} 

        public object channelData {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Channel account information needed to route a message")]
    public class ChannelAccount{
        public string id {get; set;} 

        public string name {get; set;} 

        public string aadObjectId {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.role role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An Activity is the basic communication type for the Bot Framework 3.0 protocol.")]
    public class Activity{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type type {get; set;} 

        public string id {get; set;} 

        public DateTime timestamp {get; set;} 

        public DateTime localTimestamp {get; set;} 

        public string localTimezone {get; set;} 

        public string serviceUrl {get; set;} 

        public string channelId {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount from {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationAccount conversation {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount recipient {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.textFormat textFormat {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.attachmentLayout attachmentLayout {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] membersAdded {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] membersRemoved {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MessageReaction[] reactionsAdded {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MessageReaction[] reactionsRemoved {get; set;} 

        public string topicName {get; set;} 

        public bool historyDisclosed {get; set;} 

        public string locale {get; set;} 

        public string text {get; set;} 

        public string speak {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.inputHint inputHint {get; set;} 

        public string summary {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.SuggestedActions suggestedActions {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.Attachment[] attachments {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.Entity[] entities {get; set;} 

        public object channelData {get; set;} 

        public string action {get; set;} 

        public string replyToId {get; set;} 

        public string label {get; set;} 

        public string valueType {get; set;} 

        public object value {get; set;} 

        public string name {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationReference relatesTo {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.code code {get; set;} 

        public DateTime expiration {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.importance importance {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.deliveryMode deliveryMode {get; set;} 

        public string[] listenFor {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.TextHighlight[] textHighlights {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.SemanticAction semanticAction {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.role_1 role {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Message reaction object")]
    public class MessageReaction{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type_1 type {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("SuggestedActions that can be performed")]
    public class SuggestedActions{
        public string[] to {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] actions {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount user {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount bot {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationAccount conversation {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Channel.state state {get; set;} 

        public string id {get; set;} 

        public object entities {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A clickable action")]
    public class CardAction{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.type_2 type {get; set;} 

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
    [System.ComponentModel.Description("A response containing a resource")]
    public class ConversationResourceResponse{
        public string activityId {get; set;} 

        public string serviceUrl {get; set;} 

        public string id {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversations result")]
    public class ConversationsResult{
        public string continuationToken {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ConversationMembers[] conversations {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Conversation and its members")]
    public class ConversationMembers{
        public string id {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

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
    [System.ComponentModel.Description("Transcript")]
    public class Transcript{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.Activity[] activities {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Page of members.")]
    public class PagedMembersResult{
        public string continuationToken {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount[] members {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Attachment data")]
    public class AttachmentData{
        public string type {get; set;} 

        public string name {get; set;} 

        public string originalBase64 {get; set;} 

        public string thumbnailBase64 {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A Hero card (card with a single, large image)")]
    public class HeroCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An image on a card")]
    public class CardImage{
        public string url {get; set;} 

        public string alt {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An animation card (Ex: gif or short video clip)")]
    public class AnimationCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Media card")]
    public class MediaCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.Fact[] facts {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ReceiptItem[] items {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

        public string total {get; set;} 

        public string tax {get; set;} 

        public string vat {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

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

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage image {get; set;} 

        public string price {get; set;} 

        public string quantity {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to sign in")]
    public class SigninCard{
        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A card representing a request to perform a sign in via OAuth")]
    public class OAuthCard{
        public string text {get; set;} 

        public string connectionName {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A thumbnail card (card with a single, small thumbnail image)")]
    public class ThumbnailCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardImage[] images {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction tap {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Video card")]
    public class VideoCard{
        public string title {get; set;} 

        public string subtitle {get; set;} 

        public string text {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.ThumbnailUrl image {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.MediaUrl[] media {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.CardAction[] buttons {get; set;} 

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
        public Hummingbird.MS.Bot.Bot_Framework.Channel.ChannelAccount mentioned {get; set;} 

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
    [System.ComponentModel.Description("Supplementary parameter for media events")]
    public class MediaEventValue{
        public object cardValue {get; set;} 

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
        public string merchantId {get; set;} 

        public string[] supportedNetworks {get; set;} 

        public string[] supportedTypes {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Address within a Payment Request")]
    public class PaymentAddress{
        public string country {get; set;} 

        public string[] addressLine {get; set;} 

        public string region {get; set;} 

        public string city {get; set;} 

        public string dependentLocality {get; set;} 

        public string postalCode {get; set;} 

        public string sortingCode {get; set;} 

        public string languageCode {get; set;} 

        public string organization {get; set;} 

        public string recipient {get; set;} 

        public string phone {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Supplies monetary amounts")]
    public class PaymentCurrencyAmount{
        public string currency {get; set;} 

        public string value {get; set;} 

        public string currencySystem {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides information about the requested transaction")]
    public class PaymentDetails{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem total {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem[] displayItems {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentShippingOption[] shippingOptions {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetailsModifier[] modifiers {get; set;} 

        public string error {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates what the payment request is for and the value asked for")]
    public class PaymentItem{
        public string label {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentCurrencyAmount amount {get; set;} 

        public bool pending {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Describes a shipping option")]
    public class PaymentShippingOption{
        public string id {get; set;} 

        public string label {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentCurrencyAmount amount {get; set;} 

        public bool selected {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides details that modify the PaymentDetails based on payment method identifier")]
    public class PaymentDetailsModifier{
        public string[] supportedMethods {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem total {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentItem[] additionalDisplayItems {get; set;} 

        public object data {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Indicates a set of supported payment methods and any associated payment method specific data for those methods")]
    public class PaymentMethodData{
        public string[] supportedMethods {get; set;} 

        public object data {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Provides information about the options desired for the payment request")]
    public class PaymentOptions{
        public bool requestPayerName {get; set;} 

        public bool requestPayerEmail {get; set;} 

        public bool requestPayerPhone {get; set;} 

        public bool requestShipping {get; set;} 

        public string shippingType {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A request to make a payment")]
    public class PaymentRequest{
        public string id {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentMethodData[] methodData {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentOptions options {get; set;} 

        public string expires {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Payload delivered when completing a payment request")]
    public class PaymentRequestComplete{
        public string id {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentRequest paymentRequest {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentResponse paymentResponse {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A PaymentResponse is returned when a user has selected a payment method and approved a payment request")]
    public class PaymentResponse{
        public string methodName {get; set;} 

        public object details {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentAddress shippingAddress {get; set;} 

        public string shippingOption {get; set;} 

        public string payerEmail {get; set;} 

        public string payerPhone {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("Result from a completed payment request")]
    public class PaymentRequestCompleteResult{
        public string result {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("An update to a payment request")]
    public class PaymentRequestUpdate{
        public string id {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentAddress shippingAddress {get; set;} 

        public string shippingOption {get; set;} 

    }


    [Serializable]
    /// <summary>
    /// </summary>
    [System.ComponentModel.Description("A result object from a Payment Request Update invoke operation")]
    public class PaymentRequestUpdateResult{
        public Hummingbird.MS.Bot.Bot_Framework.Channel.PaymentDetails details {get; set;} 

    }

}
