// <copyright file="Attributes31.cs" company="APIMatic">
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
    /// Attributes31.
    /// </summary>
    public class Attributes31
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes31"/> class.
        /// </summary>
        public Attributes31()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes31"/> class.
        /// </summary>
        /// <param name="chargesAmount">charges_amount.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="compensationAmount">compensation_amount.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="returnAmount">return_amount.</param>
        /// <param name="returnCode">return_code.</param>
        /// <param name="returnInitiator">return_initiator.</param>
        /// <param name="schemeProcessingDate">scheme_processing_date.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="settlement">settlement.</param>
        public Attributes31(
            Models.CurrencyAndAmount chargesAmount = null,
            string clearingId = null,
            Models.CurrencyAndAmount compensationAmount = null,
            DateTime? processingDate = null,
            Models.CurrencyAndAmount returnAmount = null,
            string returnCode = null,
            Models.ReturnInitiatorEnum? returnInitiator = null,
            DateTime? schemeProcessingDate = null,
            string schemeTransactionId = null,
            Models.Settlement settlement = null)
        {
            this.ChargesAmount = chargesAmount;
            this.ClearingId = clearingId;
            this.CompensationAmount = compensationAmount;
            this.ProcessingDate = processingDate;
            this.ReturnAmount = returnAmount;
            this.ReturnCode = returnCode;
            this.ReturnInitiator = returnInitiator;
            this.SchemeProcessingDate = schemeProcessingDate;
            this.SchemeTransactionId = schemeTransactionId;
            this.Settlement = settlement;
        }

        /// <summary>
        /// Gets or sets ChargesAmount.
        /// </summary>
        [JsonProperty("charges_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyAndAmount ChargesAmount { get; set; }

        /// <summary>
        /// Unique identifier for organisations collecting payments
        /// </summary>
        [JsonProperty("clearing_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingId { get; set; }

        /// <summary>
        /// Gets or sets CompensationAmount.
        /// </summary>
        [JsonProperty("compensation_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyAndAmount CompensationAmount { get; set; }

        /// <summary>
        /// Date on which the operation is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets ReturnAmount.
        /// </summary>
        [JsonProperty("return_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyAndAmount ReturnAmount { get; set; }

        /// <summary>
        /// Gets or sets ReturnCode.
        /// </summary>
        [JsonProperty("return_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Gets or sets ReturnInitiator.
        /// </summary>
        [JsonProperty("return_initiator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnInitiatorEnum? ReturnInitiator { get; set; }

        /// <summary>
        /// Date on which the operation is processed by the scheme. Formatted according to ISO 8601 format: YYYY-MM-DD. Only used if different from `processing_date`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("scheme_processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SchemeProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets SchemeTransactionId.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Specifies the details on how the settlement of the transaction between the instructing agent and the instructed agent is completed
        /// </summary>
        [JsonProperty("settlement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Settlement Settlement { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes31 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes31 other &&                ((this.ChargesAmount == null && other.ChargesAmount == null) || (this.ChargesAmount?.Equals(other.ChargesAmount) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.CompensationAmount == null && other.CompensationAmount == null) || (this.CompensationAmount?.Equals(other.CompensationAmount) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.ReturnAmount == null && other.ReturnAmount == null) || (this.ReturnAmount?.Equals(other.ReturnAmount) == true)) &&
                ((this.ReturnCode == null && other.ReturnCode == null) || (this.ReturnCode?.Equals(other.ReturnCode) == true)) &&
                ((this.ReturnInitiator == null && other.ReturnInitiator == null) || (this.ReturnInitiator?.Equals(other.ReturnInitiator) == true)) &&
                ((this.SchemeProcessingDate == null && other.SchemeProcessingDate == null) || (this.SchemeProcessingDate?.Equals(other.SchemeProcessingDate) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.Settlement == null && other.Settlement == null) || (this.Settlement?.Equals(other.Settlement) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChargesAmount = {(this.ChargesAmount == null ? "null" : this.ChargesAmount.ToString())}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.CompensationAmount = {(this.CompensationAmount == null ? "null" : this.CompensationAmount.ToString())}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.ReturnAmount = {(this.ReturnAmount == null ? "null" : this.ReturnAmount.ToString())}");
            toStringOutput.Add($"this.ReturnCode = {(this.ReturnCode == null ? "null" : this.ReturnCode)}");
            toStringOutput.Add($"this.ReturnInitiator = {(this.ReturnInitiator == null ? "null" : this.ReturnInitiator.ToString())}");
            toStringOutput.Add($"this.SchemeProcessingDate = {(this.SchemeProcessingDate == null ? "null" : this.SchemeProcessingDate.ToString())}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.Settlement = {(this.Settlement == null ? "null" : this.Settlement.ToString())}");
        }
    }
}