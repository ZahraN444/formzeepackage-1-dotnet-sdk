// <copyright file="Header.cs" company="APIMatic">
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
    /// Header.
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        public Header()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        /// <param name="destination">destination.</param>
        /// <param name="messageType">message_type.</param>
        /// <param name="priority">priority.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="source">source.</param>
        /// <param name="userReference">user_reference.</param>
        public Header(
            string destination = null,
            string messageType = null,
            string priority = null,
            string recipient = null,
            string source = null,
            string userReference = null)
        {
            this.Destination = destination;
            this.MessageType = messageType;
            this.Priority = priority;
            this.Recipient = recipient;
            this.Source = source;
            this.UserReference = userReference;
        }

        /// <summary>
        /// Destination SWIFT logical terminal address. Complete 12-character SWIFT destination, including BIC (x8), logical terminal code (x1) and branch code (x).
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// The message type of the SWIFT payment, has to match `[A-Z]{2}[0-9]{3}`. Currently `MT103` is the only supported value
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageType { get; set; }

        /// <summary>
        /// SWIFT priority. Either `Normal` or `Priority`.
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// The destination SWIFT BIC for SWIFT MT messages being sent by Form3 client to SWIFT. Formatted as BIC8 or BIC11.
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public string Recipient { get; set; }

        /// <summary>
        /// The source SWIFT BIC for SWIFT MT messages being received by Form3 client from SWIFT. Formatted as BIC8 or BIC11.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Message User Reference (MUR) value, which can be up to 16 characters, and will be returned in the ACK
        /// </summary>
        [JsonProperty("user_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string UserReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Header : ({string.Join(", ", toStringOutput)})";
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
            return obj is Header other &&                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                ((this.MessageType == null && other.MessageType == null) || (this.MessageType?.Equals(other.MessageType) == true)) &&
                ((this.Priority == null && other.Priority == null) || (this.Priority?.Equals(other.Priority) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.UserReference == null && other.UserReference == null) || (this.UserReference?.Equals(other.UserReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination)}");
            toStringOutput.Add($"this.MessageType = {(this.MessageType == null ? "null" : this.MessageType)}");
            toStringOutput.Add($"this.Priority = {(this.Priority == null ? "null" : this.Priority)}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient)}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.UserReference = {(this.UserReference == null ? "null" : this.UserReference)}");
        }
    }
}