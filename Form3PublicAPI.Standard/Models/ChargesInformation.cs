// <copyright file="ChargesInformation.cs" company="APIMatic">
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
    /// ChargesInformation.
    /// </summary>
    public class ChargesInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesInformation"/> class.
        /// </summary>
        public ChargesInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesInformation"/> class.
        /// </summary>
        /// <param name="bearerCode">bearer_code.</param>
        /// <param name="receiverChargesAmount">receiver_charges_amount.</param>
        /// <param name="receiverChargesCurrency">receiver_charges_currency.</param>
        /// <param name="senderCharges">sender_charges.</param>
        public ChargesInformation(
            string bearerCode = null,
            string receiverChargesAmount = null,
            string receiverChargesCurrency = null,
            List<Models.SenderCharge> senderCharges = null)
        {
            this.BearerCode = bearerCode;
            this.ReceiverChargesAmount = receiverChargesAmount;
            this.ReceiverChargesCurrency = receiverChargesCurrency;
            this.SenderCharges = senderCharges;
        }

        /// <summary>
        /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction. Can be one of the following: `DEBT`, `CRED`, `SHAR` or `SLEV`
        /// </summary>
        [JsonProperty("bearer_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BearerCode { get; set; }

        /// <summary>
        /// Transaction charges due to the receiver of the transaction. Requires 1 to 2 decimal places. Must be > 0.
        /// </summary>
        [JsonProperty("receiver_charges_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverChargesAmount { get; set; }

        /// <summary>
        /// Currency of `receiver_charges_amount`. Currency code as defined in [ISO 4217](http://www.iso.org/iso/home/standards/currency_codes.htm).
        /// </summary>
        [JsonProperty("receiver_charges_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverChargesCurrency { get; set; }

        /// <summary>
        /// Gets or sets SenderCharges.
        /// </summary>
        [JsonProperty("sender_charges", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SenderCharge> SenderCharges { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChargesInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChargesInformation other &&                ((this.BearerCode == null && other.BearerCode == null) || (this.BearerCode?.Equals(other.BearerCode) == true)) &&
                ((this.ReceiverChargesAmount == null && other.ReceiverChargesAmount == null) || (this.ReceiverChargesAmount?.Equals(other.ReceiverChargesAmount) == true)) &&
                ((this.ReceiverChargesCurrency == null && other.ReceiverChargesCurrency == null) || (this.ReceiverChargesCurrency?.Equals(other.ReceiverChargesCurrency) == true)) &&
                ((this.SenderCharges == null && other.SenderCharges == null) || (this.SenderCharges?.Equals(other.SenderCharges) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BearerCode = {(this.BearerCode == null ? "null" : this.BearerCode)}");
            toStringOutput.Add($"this.ReceiverChargesAmount = {(this.ReceiverChargesAmount == null ? "null" : this.ReceiverChargesAmount)}");
            toStringOutput.Add($"this.ReceiverChargesCurrency = {(this.ReceiverChargesCurrency == null ? "null" : this.ReceiverChargesCurrency)}");
            toStringOutput.Add($"this.SenderCharges = {(this.SenderCharges == null ? "null" : $"[{string.Join(", ", this.SenderCharges)} ]")}");
        }
    }
}