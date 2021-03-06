/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// DeliveryReceiptResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Conversations.V1.Conversation.Message
{

    public class DeliveryReceiptResource : Resource
    {
        public sealed class DeliveryStatusEnum : StringEnum
        {
            private DeliveryStatusEnum(string value) : base(value) {}
            public DeliveryStatusEnum() {}
            public static implicit operator DeliveryStatusEnum(string value)
            {
                return new DeliveryStatusEnum(value);
            }

            public static readonly DeliveryStatusEnum Read = new DeliveryStatusEnum("read");
            public static readonly DeliveryStatusEnum Failed = new DeliveryStatusEnum("failed");
            public static readonly DeliveryStatusEnum Delivered = new DeliveryStatusEnum("delivered");
            public static readonly DeliveryStatusEnum Undelivered = new DeliveryStatusEnum("undelivered");
            public static readonly DeliveryStatusEnum Sent = new DeliveryStatusEnum("sent");
        }

        private static Request BuildFetchRequest(FetchDeliveryReceiptOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Conversations/" + options.PathConversationSid + "/Messages/" + options.PathMessageSid + "/Receipts/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch DeliveryReceipt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DeliveryReceipt </returns>
        public static DeliveryReceiptResource Fetch(FetchDeliveryReceiptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch DeliveryReceipt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DeliveryReceipt </returns>
        public static async System.Threading.Tasks.Task<DeliveryReceiptResource> FetchAsync(FetchDeliveryReceiptOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this delivery receipt. </param>
        /// <param name="pathMessageSid"> The sid of the message the delivery receipt belongs to </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DeliveryReceipt </returns>
        public static DeliveryReceiptResource Fetch(string pathConversationSid,
                                                    string pathMessageSid,
                                                    string pathSid,
                                                    ITwilioRestClient client = null)
        {
            var options = new FetchDeliveryReceiptOptions(pathConversationSid, pathMessageSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this delivery receipt. </param>
        /// <param name="pathMessageSid"> The sid of the message the delivery receipt belongs to </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DeliveryReceipt </returns>
        public static async System.Threading.Tasks.Task<DeliveryReceiptResource> FetchAsync(string pathConversationSid,
                                                                                            string pathMessageSid,
                                                                                            string pathSid,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new FetchDeliveryReceiptOptions(pathConversationSid, pathMessageSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadDeliveryReceiptOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Conversations/" + options.PathConversationSid + "/Messages/" + options.PathMessageSid + "/Receipts",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DeliveryReceipt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DeliveryReceipt </returns>
        public static ResourceSet<DeliveryReceiptResource> Read(ReadDeliveryReceiptOptions options,
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DeliveryReceiptResource>.FromJson("delivery_receipts", response.Content);
            return new ResourceSet<DeliveryReceiptResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DeliveryReceipt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DeliveryReceipt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeliveryReceiptResource>> ReadAsync(ReadDeliveryReceiptOptions options,
                                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DeliveryReceiptResource>.FromJson("delivery_receipts", response.Content);
            return new ResourceSet<DeliveryReceiptResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this delivery receipt. </param>
        /// <param name="pathMessageSid"> The sid of the message the delivery receipt belongs to </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DeliveryReceipt </returns>
        public static ResourceSet<DeliveryReceiptResource> Read(string pathConversationSid,
                                                                string pathMessageSid,
                                                                int? pageSize = null,
                                                                long? limit = null,
                                                                ITwilioRestClient client = null)
        {
            var options = new ReadDeliveryReceiptOptions(pathConversationSid, pathMessageSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this delivery receipt. </param>
        /// <param name="pathMessageSid"> The sid of the message the delivery receipt belongs to </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DeliveryReceipt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeliveryReceiptResource>> ReadAsync(string pathConversationSid,
                                                                                                        string pathMessageSid,
                                                                                                        int? pageSize = null,
                                                                                                        long? limit = null,
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new ReadDeliveryReceiptOptions(pathConversationSid, pathMessageSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DeliveryReceiptResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DeliveryReceiptResource>.FromJson("delivery_receipts", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DeliveryReceiptResource> NextPage(Page<DeliveryReceiptResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Conversations)
            );

            var response = client.Request(request);
            return Page<DeliveryReceiptResource>.FromJson("delivery_receipts", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DeliveryReceiptResource> PreviousPage(Page<DeliveryReceiptResource> page,
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Conversations)
            );

            var response = client.Request(request);
            return Page<DeliveryReceiptResource>.FromJson("delivery_receipts", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a DeliveryReceiptResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DeliveryReceiptResource object represented by the provided JSON </returns>
        public static DeliveryReceiptResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DeliveryReceiptResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The sid of the message the delivery receipt belongs to
        /// </summary>
        [JsonProperty("message_sid")]
        public string MessageSid { get; private set; }
        /// <summary>
        /// The conversation_sid
        /// </summary>
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }
        /// <summary>
        /// A messaging channel-specific identifier for the message delivered to participant
        /// </summary>
        [JsonProperty("channel_message_sid")]
        public string ChannelMessageSid { get; private set; }
        /// <summary>
        /// The unique id of the participant the delivery receipt belongs to.
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The message delivery status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeliveryReceiptResource.DeliveryStatusEnum Status { get; private set; }
        /// <summary>
        /// The message [delivery error code](https://www.twilio.com/docs/sms/api/message-resource#delivery-related-errors) for a `failed` status
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An absolute URL for this delivery receipt.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private DeliveryReceiptResource()
        {

        }
    }

}