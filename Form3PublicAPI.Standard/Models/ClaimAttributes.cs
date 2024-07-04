// <copyright file="ClaimAttributes.cs" company="APIMatic">
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
    /// ClaimAttributes.
    /// </summary>
    public class ClaimAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimAttributes"/> class.
        /// </summary>
        public ClaimAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimAttributes"/> class.
        /// </summary>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="disputedTransactions">disputed_transactions.</param>
        /// <param name="numberOfClaims">number_of_claims.</param>
        /// <param name="originalInstruction">original_instruction.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="reference">reference.</param>
        /// <param name="contactName">contact_name.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="requestDate">request_date.</param>
        public ClaimAttributes(
            Models.BeneficiaryParty2 beneficiaryParty,
            string clearingId,
            Models.DebtorParty1 debtorParty,
            List<Models.DisputedTransaction> disputedTransactions,
            int numberOfClaims,
            Models.OriginalInstruction originalInstruction,
            string paymentScheme,
            string reasonCode,
            string reference,
            string contactName = null,
            DateTime? processingDate = null,
            DateTime? requestDate = null)
        {
            this.BeneficiaryParty = beneficiaryParty;
            this.ClearingId = clearingId;
            this.ContactName = contactName;
            this.DebtorParty = debtorParty;
            this.DisputedTransactions = disputedTransactions;
            this.NumberOfClaims = numberOfClaims;
            this.OriginalInstruction = originalInstruction;
            this.PaymentScheme = paymentScheme;
            this.ProcessingDate = processingDate;
            this.ReasonCode = reasonCode;
            this.Reference = reference;
            this.RequestDate = requestDate;
        }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party")]
        public Models.BeneficiaryParty2 BeneficiaryParty { get; set; }

        /// <summary>
        /// Gets or sets ClearingId.
        /// </summary>
        [JsonProperty("clearing_id")]
        public string ClearingId { get; set; }

        /// <summary>
        /// Gets or sets ContactName.
        /// </summary>
        [JsonProperty("contact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets DebtorParty.
        /// </summary>
        [JsonProperty("debtor_party")]
        public Models.DebtorParty1 DebtorParty { get; set; }

        /// <summary>
        /// Gets or sets DisputedTransactions.
        /// </summary>
        [JsonProperty("disputed_transactions")]
        public List<Models.DisputedTransaction> DisputedTransactions { get; set; }

        /// <summary>
        /// Gets or sets NumberOfClaims.
        /// </summary>
        [JsonProperty("number_of_claims")]
        public int NumberOfClaims { get; set; }

        /// <summary>
        /// Gets or sets OriginalInstruction.
        /// </summary>
        [JsonProperty("original_instruction")]
        public Models.OriginalInstruction OriginalInstruction { get; set; }

        /// <summary>
        /// Gets or sets PaymentScheme.
        /// </summary>
        [JsonProperty("payment_scheme")]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// Gets or sets ProcessingDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets RequestDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("request_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RequestDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimAttributes other &&                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.ContactName == null && other.ContactName == null) || (this.ContactName?.Equals(other.ContactName) == true)) &&
                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.DisputedTransactions == null && other.DisputedTransactions == null) || (this.DisputedTransactions?.Equals(other.DisputedTransactions) == true)) &&
                this.NumberOfClaims.Equals(other.NumberOfClaims) &&
                ((this.OriginalInstruction == null && other.OriginalInstruction == null) || (this.OriginalInstruction?.Equals(other.OriginalInstruction) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.RequestDate == null && other.RequestDate == null) || (this.RequestDate?.Equals(other.RequestDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.ContactName = {(this.ContactName == null ? "null" : this.ContactName)}");
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.DisputedTransactions = {(this.DisputedTransactions == null ? "null" : $"[{string.Join(", ", this.DisputedTransactions)} ]")}");
            toStringOutput.Add($"this.NumberOfClaims = {this.NumberOfClaims}");
            toStringOutput.Add($"this.OriginalInstruction = {(this.OriginalInstruction == null ? "null" : this.OriginalInstruction.ToString())}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.RequestDate = {(this.RequestDate == null ? "null" : this.RequestDate.ToString())}");
        }
    }
}