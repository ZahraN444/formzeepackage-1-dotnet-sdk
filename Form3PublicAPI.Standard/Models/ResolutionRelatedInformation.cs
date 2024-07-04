// <copyright file="ResolutionRelatedInformation.cs" company="APIMatic">
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
    /// ResolutionRelatedInformation.
    /// </summary>
    public class ResolutionRelatedInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionRelatedInformation"/> class.
        /// </summary>
        public ResolutionRelatedInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionRelatedInformation"/> class.
        /// </summary>
        /// <param name="clearingChannel">clearing_channel.</param>
        /// <param name="references">references.</param>
        /// <param name="settlementDate">settlement_date.</param>
        public ResolutionRelatedInformation(
            Models.ClearingChannelEnum? clearingChannel = null,
            List<Models.Reference> references = null,
            DateTime? settlementDate = null)
        {
            this.ClearingChannel = clearingChannel;
            this.References = references;
            this.SettlementDate = settlementDate;
        }

        /// <summary>
        /// Answer to the recall request. Can either be `MPNS`, `RTGS` or `RTNS`.
        /// </summary>
        [JsonProperty("clearing_channel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClearingChannelEnum? ClearingChannel { get; set; }

        /// <summary>
        /// Block to represent a list of references
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Reference> References { get; set; }

        /// <summary>
        /// Date that the payment will be settled
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SettlementDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResolutionRelatedInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResolutionRelatedInformation other &&                ((this.ClearingChannel == null && other.ClearingChannel == null) || (this.ClearingChannel?.Equals(other.ClearingChannel) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.SettlementDate == null && other.SettlementDate == null) || (this.SettlementDate?.Equals(other.SettlementDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClearingChannel = {(this.ClearingChannel == null ? "null" : this.ClearingChannel.ToString())}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
        }
    }
}