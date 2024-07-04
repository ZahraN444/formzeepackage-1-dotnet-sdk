// <copyright file="SubscriptionDeliveryErrorCountResponse.cs" company="APIMatic">
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
    /// SubscriptionDeliveryErrorCountResponse.
    /// </summary>
    public class SubscriptionDeliveryErrorCountResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDeliveryErrorCountResponse"/> class.
        /// </summary>
        public SubscriptionDeliveryErrorCountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDeliveryErrorCountResponse"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="links">links.</param>
        public SubscriptionDeliveryErrorCountResponse(
            long? count = null,
            Models.Links links = null)
        {
            this.Count = count;
            this.Links = links;
        }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Links Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionDeliveryErrorCountResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionDeliveryErrorCountResponse other &&                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : this.Links.ToString())}");
        }
    }
}