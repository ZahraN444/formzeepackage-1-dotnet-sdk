// <copyright file="Attributes35.cs" company="APIMatic">
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
    /// Attributes35.
    /// </summary>
    public class Attributes35
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes35"/> class.
        /// </summary>
        public Attributes35()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes35"/> class.
        /// </summary>
        /// <param name="chargesAmount">charges_amount.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="reason">reason.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="reversalAmount">reversal_amount.</param>
        /// <param name="schemeProcessingDate">scheme_processing_date.</param>
        public Attributes35(
            Models.ChargesAmount chargesAmount = null,
            DateTime? processingDate = null,
            string reason = null,
            string reasonCode = null,
            Models.ReversalAmount reversalAmount = null,
            DateTime? schemeProcessingDate = null)
        {
            this.ChargesAmount = chargesAmount;
            this.ProcessingDate = processingDate;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.ReversalAmount = reversalAmount;
            this.SchemeProcessingDate = schemeProcessingDate;
        }

        /// <summary>
        /// Only present when a DirectDebitReversal contains charges. SEPA only
        /// </summary>
        [JsonProperty("charges_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargesAmount ChargesAmount { get; set; }

        /// <summary>
        /// Date on which the operation is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Further explanation of the reason given in reason_code. Only evaluated for certain reason codes.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// The reason for the direct debit reversal. Has to be a valid [reversal reason code](http://api-docs.form3.tech/api.html#enumerations-reversal-reason-codes).
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// SEPA only
        /// </summary>
        [JsonProperty("reversal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReversalAmount ReversalAmount { get; set; }

        /// <summary>
        /// Date on which the operation is processed by the scheme. Formatted according to ISO 8601 format: YYYY-MM-DD. Only used if different from `processing_date`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("scheme_processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SchemeProcessingDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes35 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes35 other &&                ((this.ChargesAmount == null && other.ChargesAmount == null) || (this.ChargesAmount?.Equals(other.ChargesAmount) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.ReversalAmount == null && other.ReversalAmount == null) || (this.ReversalAmount?.Equals(other.ReversalAmount) == true)) &&
                ((this.SchemeProcessingDate == null && other.SchemeProcessingDate == null) || (this.SchemeProcessingDate?.Equals(other.SchemeProcessingDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargesAmount = {(this.ChargesAmount == null ? "null" : this.ChargesAmount.ToString())}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.ReversalAmount = {(this.ReversalAmount == null ? "null" : this.ReversalAmount.ToString())}");
            toStringOutput.Add($"this.SchemeProcessingDate = {(this.SchemeProcessingDate == null ? "null" : this.SchemeProcessingDate.ToString())}");
        }
    }
}