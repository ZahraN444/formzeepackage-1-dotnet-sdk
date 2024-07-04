// <copyright file="PaymentTypeInformation.cs" company="APIMatic">
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
    /// PaymentTypeInformation.
    /// </summary>
    public class PaymentTypeInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTypeInformation"/> class.
        /// </summary>
        public PaymentTypeInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTypeInformation"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="categoryPurpose">category_purpose.</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentPurpose">payment_purpose.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="remittanceInformation">remittance_information.</param>
        /// <param name="schemePaymentSubType">scheme_payment_sub_type.</param>
        /// <param name="schemePaymentType">scheme_payment_type.</param>
        public PaymentTypeInformation(
            string amount = null,
            string categoryPurpose = null,
            string currency = null,
            string paymentPurpose = null,
            DateTime? processingDate = null,
            string remittanceInformation = null,
            string schemePaymentSubType = null,
            string schemePaymentType = null)
        {
            this.Amount = amount;
            this.CategoryPurpose = categoryPurpose;
            this.Currency = currency;
            this.PaymentPurpose = paymentPurpose;
            this.ProcessingDate = processingDate;
            this.RemittanceInformation = remittanceInformation;
            this.SchemePaymentSubType = schemePaymentSubType;
            this.SchemePaymentType = schemePaymentType;
        }

        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
        /// </summary>
        [JsonProperty("category_purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryPurpose { get; set; }

        /// <summary>
        /// Currency of the transaction amount. Currency code as defined in [ISO 4217](https://www.iso.org/iso/home/standards/currency_codes.htm)
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Underlying reason for the payment transaction. Defined in external code list (4 char) or proprietary code (35 char)
        /// </summary>
        [JsonProperty("payment_purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentPurpose { get; set; }

        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Unstructured information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle.
        /// </summary>
        [JsonProperty("remittance_information", NullValueHandling = NullValueHandling.Ignore)]
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// Specifies a local instrument to further qualify the level of service.
        /// </summary>
        [JsonProperty("scheme_payment_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentSubType { get; set; }

        /// <summary>
        /// Specifies a pre-agreed level of service as published in an external code list (4 char) or a proprietary code (35 char).
        /// </summary>
        [JsonProperty("scheme_payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentTypeInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentTypeInformation other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.CategoryPurpose == null && other.CategoryPurpose == null) || (this.CategoryPurpose?.Equals(other.CategoryPurpose) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.PaymentPurpose == null && other.PaymentPurpose == null) || (this.PaymentPurpose?.Equals(other.PaymentPurpose) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.RemittanceInformation == null && other.RemittanceInformation == null) || (this.RemittanceInformation?.Equals(other.RemittanceInformation) == true)) &&
                ((this.SchemePaymentSubType == null && other.SchemePaymentSubType == null) || (this.SchemePaymentSubType?.Equals(other.SchemePaymentSubType) == true)) &&
                ((this.SchemePaymentType == null && other.SchemePaymentType == null) || (this.SchemePaymentType?.Equals(other.SchemePaymentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.CategoryPurpose = {(this.CategoryPurpose == null ? "null" : this.CategoryPurpose)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.PaymentPurpose = {(this.PaymentPurpose == null ? "null" : this.PaymentPurpose)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.RemittanceInformation = {(this.RemittanceInformation == null ? "null" : this.RemittanceInformation)}");
            toStringOutput.Add($"this.SchemePaymentSubType = {(this.SchemePaymentSubType == null ? "null" : this.SchemePaymentSubType)}");
            toStringOutput.Add($"this.SchemePaymentType = {(this.SchemePaymentType == null ? "null" : this.SchemePaymentType)}");
        }
    }
}