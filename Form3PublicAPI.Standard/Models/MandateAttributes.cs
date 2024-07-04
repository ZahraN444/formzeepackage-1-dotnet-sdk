// <copyright file="MandateAttributes.cs" company="APIMatic">
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
    /// MandateAttributes.
    /// </summary>
    public class MandateAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateAttributes"/> class.
        /// </summary>
        public MandateAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MandateAttributes"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="numericReference">numeric_reference.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="reference">reference.</param>
        /// <param name="schemePaymentType">scheme_payment_type.</param>
        /// <param name="schemeProcessingDate">scheme_processing_date.</param>
        /// <param name="source">source.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        public MandateAttributes(
            string amount = null,
            Models.MandateAttributesBeneficiaryParty beneficiaryParty = null,
            string clearingId = null,
            string currency = null,
            Models.MandateAttributesDebtorParty debtorParty = null,
            Models.MandateFrequencyEnum? frequency = null,
            string numericReference = null,
            string paymentScheme = null,
            DateTime? processingDate = null,
            string reference = null,
            string schemePaymentType = null,
            DateTime? schemeProcessingDate = null,
            string source = null,
            Models.MandateStatusEnum? status = null,
            string statusReason = null,
            string uniqueSchemeId = null)
        {
            this.Amount = amount;
            this.BeneficiaryParty = beneficiaryParty;
            this.ClearingId = clearingId;
            this.Currency = currency;
            this.DebtorParty = debtorParty;
            this.Frequency = frequency;
            this.NumericReference = numericReference;
            this.PaymentScheme = paymentScheme;
            this.ProcessingDate = processingDate;
            this.Reference = reference;
            this.SchemePaymentType = schemePaymentType;
            this.SchemeProcessingDate = schemeProcessingDate;
            this.Source = source;
            this.Status = status;
            this.StatusReason = statusReason;
            this.UniqueSchemeId = uniqueSchemeId;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateAttributesBeneficiaryParty BeneficiaryParty { get; set; }

        /// <summary>
        /// Gets or sets ClearingId.
        /// </summary>
        [JsonProperty("clearing_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingId { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets DebtorParty.
        /// </summary>
        [JsonProperty("debtor_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateAttributesDebtorParty DebtorParty { get; set; }

        /// <summary>
        /// Gets or sets Frequency.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateFrequencyEnum? Frequency { get; set; }

        /// <summary>
        /// Gets or sets NumericReference.
        /// </summary>
        [JsonProperty("numeric_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericReference { get; set; }

        /// <summary>
        /// Gets or sets PaymentScheme.
        /// </summary>
        [JsonProperty("payment_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// Gets or sets ProcessingDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets SchemePaymentType.
        /// </summary>
        [JsonProperty("scheme_payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentType { get; set; }

        /// <summary>
        /// Gets or sets SchemeProcessingDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("scheme_processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SchemeProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateStatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets StatusReason.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Gets or sets UniqueSchemeId.
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MandateAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is MandateAttributes other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                ((this.NumericReference == null && other.NumericReference == null) || (this.NumericReference?.Equals(other.NumericReference) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.SchemePaymentType == null && other.SchemePaymentType == null) || (this.SchemePaymentType?.Equals(other.SchemePaymentType) == true)) &&
                ((this.SchemeProcessingDate == null && other.SchemeProcessingDate == null) || (this.SchemeProcessingDate?.Equals(other.SchemeProcessingDate) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");
            toStringOutput.Add($"this.NumericReference = {(this.NumericReference == null ? "null" : this.NumericReference)}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.SchemePaymentType = {(this.SchemePaymentType == null ? "null" : this.SchemePaymentType)}");
            toStringOutput.Add($"this.SchemeProcessingDate = {(this.SchemeProcessingDate == null ? "null" : this.SchemeProcessingDate.ToString())}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
        }
    }
}