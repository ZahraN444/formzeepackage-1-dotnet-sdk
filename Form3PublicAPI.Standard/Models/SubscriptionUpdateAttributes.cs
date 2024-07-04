// <copyright file="SubscriptionUpdateAttributes.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionUpdateAttributes.
    /// </summary>
    public class SubscriptionUpdateAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateAttributes"/> class.
        /// </summary>
        public SubscriptionUpdateAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateAttributes"/> class.
        /// </summary>
        /// <param name="callbackTransport">callback_transport.</param>
        /// <param name="callbackUri">callback_uri.</param>
        /// <param name="callbackUris">callback_uris.</param>
        /// <param name="deactivated">deactivated.</param>
        /// <param name="eventType">event_type.</param>
        /// <param name="filter">filter.</param>
        /// <param name="recordType">record_type.</param>
        /// <param name="userDefinedData">user_defined_data.</param>
        /// <param name="userId">user_id.</param>
        public SubscriptionUpdateAttributes(
            Models.CallbackTransportEnum? callbackTransport = null,
            string callbackUri = null,
            List<Models.CallbackURI> callbackUris = null,
            bool? deactivated = null,
            string eventType = null,
            string filter = null,
            string recordType = null,
            List<Models.SubscriptionUserDefinedData> userDefinedData = null,
            Guid? userId = null)
        {
            this.CallbackTransport = callbackTransport;
            this.CallbackUri = callbackUri;
            this.CallbackUris = callbackUris;
            this.Deactivated = deactivated;
            this.EventType = eventType;
            this.Filter = filter;
            this.RecordType = recordType;
            this.UserDefinedData = userDefinedData;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or sets CallbackTransport.
        /// </summary>
        [JsonProperty("callback_transport", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CallbackTransportEnum? CallbackTransport { get; set; }

        /// <summary>
        /// Deprecated. Please use callback_uris instead
        /// </summary>
        [JsonProperty("callback_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUri { get; set; }

        /// <summary>
        /// Gets or sets CallbackUris.
        /// </summary>
        [JsonProperty("callback_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CallbackURI> CallbackUris { get; set; }

        /// <summary>
        /// Gets or sets Deactivated.
        /// </summary>
        [JsonProperty("deactivated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivated { get; set; }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets RecordType.
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// All purpose list of key-value pairs to store specific data for the associated subscription.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionUserDefinedData> UserDefinedData { get; set; }

        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionUpdateAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscriptionUpdateAttributes other &&                ((this.CallbackTransport == null && other.CallbackTransport == null) || (this.CallbackTransport?.Equals(other.CallbackTransport) == true)) &&
                ((this.CallbackUri == null && other.CallbackUri == null) || (this.CallbackUri?.Equals(other.CallbackUri) == true)) &&
                ((this.CallbackUris == null && other.CallbackUris == null) || (this.CallbackUris?.Equals(other.CallbackUris) == true)) &&
                ((this.Deactivated == null && other.Deactivated == null) || (this.Deactivated?.Equals(other.Deactivated) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.RecordType == null && other.RecordType == null) || (this.RecordType?.Equals(other.RecordType) == true)) &&
                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CallbackTransport = {(this.CallbackTransport == null ? "null" : this.CallbackTransport.ToString())}");
            toStringOutput.Add($"this.CallbackUri = {(this.CallbackUri == null ? "null" : this.CallbackUri)}");
            toStringOutput.Add($"this.CallbackUris = {(this.CallbackUris == null ? "null" : $"[{string.Join(", ", this.CallbackUris)} ]")}");
            toStringOutput.Add($"this.Deactivated = {(this.Deactivated == null ? "null" : this.Deactivated.ToString())}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType)}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter)}");
            toStringOutput.Add($"this.RecordType = {(this.RecordType == null ? "null" : this.RecordType)}");
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
        }
    }
}